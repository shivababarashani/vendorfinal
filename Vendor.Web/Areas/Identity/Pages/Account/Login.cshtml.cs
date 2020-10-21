using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Vendor.Domain;
using System.Data.SqlClient;

namespace Vendor.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<ApplicationUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "شماره همراه را وارد نمایید")]
           
            public string UserName { get; set; }


            [Display(Name = "مرا به خاطر بسپار")]
            public bool RememberMe { get; set; }


            [Required(ErrorMessage = "رمز عبور را وارد نمایید")]
            [DataType(DataType.Password)]
            [Display(Name = "پسورد")]
            public string Password { get; set; }

        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/home/index");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                //SqlConnection con = new SqlConnection("Server=192.168.0.19;Database=edeskSama;Trusted_Connection=false;User Id=sa;Password=13490303");

                //SqlCommand cmd = new SqlCommand("select * from Users where loginName='" + Input.UserName + "' and password='" + Input.Password + "'", con);
                //SqlDataReader dr;
                //con.Open();
                //dr = cmd.ExecuteReader();
                //if (dr.HasRows)
                //{
                //    //login

                //}




                    var _user = await _signInManager.UserManager.FindByNameAsync(Input.UserName);

                if (_user == null)
                {
                    ModelState.AddModelError(string.Empty, "شماره همراه یا رمز عبور اشتباه است");
                    return Page();
                }

                var result = await _signInManager.PasswordSignInAsync(_user, Input.Password, Input.RememberMe, lockoutOnFailure: true);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                if (result.IsNotAllowed)
                {
                    return RedirectToPage("./ConfirmPhone", new { phone = _user.PhoneNumber });
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User Lockout");
                    ModelState.AddModelError(string.Empty, "نام کاربری قفل می باشد لطفا 10 دقیقه دیگر سعی نمایید");
                    return Page();
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "شماره همراه یا رمز عبور اشتباه است");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }

}
