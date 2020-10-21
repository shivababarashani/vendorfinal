using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Vendor.Domain;

namespace Vendor.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ResetPasswordModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "پسورد را وارد نمایید")]
            [StringLength(100, ErrorMessage = "پسورد حداقل باید شامل 4 کاراکتر باشد", MinimumLength = 4)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "پسورد ها یکسان نیستند")]
            public string ConfirmPassword { get; set; }

            public string Code { get; set; }
        }

        public IActionResult OnGet(string code = null, string user = null)
        {
            if (code == null)
            {
                return BadRequest("برای تغییر پسورد نیازمند کد می باشید");
            }
            else
            {
                Input = new InputModel
                {
                    Code = code
                };

                TempData["PhoneNumber"] = user;

                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            string PhoneNumber = TempData["PhoneNumber"].ToString();

            if (!ModelState.IsValid)
            {
                TempData["PhoneNumber"] = PhoneNumber;
                return Page();
            }

            var user = await _userManager.FindByNameAsync(PhoneNumber);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToPage("./Successchangepassword");
            }

            var result = await _userManager.ResetPasswordAsync(user, Input.Code, Input.Password);
            if (result.Succeeded)
            {
                return RedirectToPage("./Successchangepassword");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            TempData["PhoneNumber"] = PhoneNumber;
            return Page();
        }
    }
}
