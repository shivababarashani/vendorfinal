using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Vendor.Domain;

namespace Vendor.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        //private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "شماره همراه را وارد نمایید")]
            [Phone(ErrorMessage = "شماره همراه اشتباه می باشد"),
               MaxLength(length: 11, ErrorMessage = "شماره همراه اشتباه می باشد"),
               MinLength(length: 11, ErrorMessage = "شماره همراه اشتباه است")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "نام را وارد نمایید")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "نام خانوادگی را وارد نمایید")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "پسوورد  را وارد نمایید")]
            [StringLength(100, ErrorMessage = "پسورد حداقل باید شامل 4 کاراکتر باشد", MinimumLength = 4)]
            [DataType(DataType.Password)]
            [Display(Name = "پسورد")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "تکرار پسورد")]
            [Compare("Password", ErrorMessage = "پسورد ها مانند یکدیگر نیستند")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
         
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = Input.UserName,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    LoginDate = DateTime.Now,
                    PhoneNumber = Input.UserName,
                    PhoneNumberConfirmed = false,
                    EmailConfirmed = false
                };

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("ثبت نام کاربر جدید با موفقیت انجام شد");

                    //var token = await _userManager.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);
                    //var _result = await _userManager.ChangePhoneNumberAsync(user, user.PhoneNumber, token);

                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToPage("./ConfirmPhone", new { phone = user.PhoneNumber });
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }


            return Page();
        }
    }
}
