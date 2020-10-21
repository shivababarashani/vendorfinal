using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Vendor.Domain;
using Microsoft.Extensions.Logging;

namespace Vendor.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
       
        private readonly SignInManager<ApplicationUser> _signInManager;
            private readonly ILogger<ForgotPasswordModel> _logger;

            public ForgotPasswordModel(SignInManager<ApplicationUser> signInManager, ILogger<ForgotPasswordModel> logger)
            {
                _signInManager = signInManager;
                _logger = logger;
            }

            [BindProperty]
            public InputModel Input { get; set; }

            public class InputModel
            {
                [Required(ErrorMessage = "شماره همراه را وارد نمایید")]
                [Phone(ErrorMessage = "شماره همراه اشتباه می باشد"),
                    MaxLength(length: 11, ErrorMessage = "شماره همراه اشتباه می باشد"),
                    MinLength(length: 11, ErrorMessage = "شماره همراه اشتباه است")]
                public string UserName { get; set; }
            }

            public void OnGet()
            {

            }

            public async Task<IActionResult> OnPostAsync()
            {

                if (ModelState.IsValid)
                {

                    var _user = await _signInManager.UserManager.FindByNameAsync(Input.UserName);

                    if (_user == null)
                    {
                        ModelState.AddModelError(string.Empty, "شماره همراه اشتباه است");
                        return Page();
                    }
                    else
                    {
                        return RedirectToPage("./ConfirmPhone", new { phone = _user.PhoneNumber, forgot = true });
                    }
                }

                return Page();
            }
        }
    }

