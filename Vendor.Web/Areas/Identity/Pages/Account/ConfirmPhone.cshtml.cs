using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RestSharp;
using Vendor.Domain;
using Vendor.Web.Models;

namespace Vendor.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ConfirmPhoneModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<ConfirmPhoneModel> _logger;

        public ConfirmPhoneModel(SignInManager<ApplicationUser> signInManager, ILogger<ConfirmPhoneModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "کد تایید را وارد نمایید")]
            public string Code { get; set; }

            public string CodeConfirm { get; set; }
            public string Phone { get; set; }
        }

        public async Task OnGetAsync(string phone, bool forgot = false)
        {
            var _user = await _signInManager.UserManager.FindByNameAsync(phone);

            if (_user != null)
            {
                var token = await _signInManager.UserManager.GenerateChangePhoneNumberTokenAsync(_user, phone);

                MobileCode mobileCode = new MobileCode()
                {
                    Phone = phone,
                    Code = token
                };

                TempData["CodeConfirm"] = token;
                TempData["PhoneNumber"] = phone;
                TempData["Forgot"] = forgot;


                var client =
                   new
                       RestClient($"https://api.kavenegar.com/v1/50686738705469657761504154597A576F6F377A424E33373056424F4A41694E6678653432534443474A6B3D/verify/lookup.json?receptor={phone}&token={token}&template=ConfirmUser")
                   {
                       Timeout = -1
                   };
                var request = new RestRequest(Method.GET);
                _ = client.Execute(request);


            }

        }

        public async Task<IActionResult> OnPostAsync()
        {
            string codeConfirm = TempData["CodeConfirm"].ToString();
            string PhoneNumber = TempData["PhoneNumber"].ToString();
            bool forgot = Convert.ToBoolean(TempData["Forgot"]);

            if (ModelState.IsValid)
            {

                if (codeConfirm == Input.Code)
                {
                    var _user = await _signInManager.UserManager.FindByNameAsync(PhoneNumber);
                    var _result = await _signInManager.UserManager.ChangePhoneNumberAsync(_user, _user.PhoneNumber, codeConfirm);

                    if (_result.Succeeded)
                    {
                        if (forgot)
                        {
                            var code = await _signInManager.UserManager.GeneratePasswordResetTokenAsync(_user);
                            return RedirectToPage("./ResetPassword", new { code = code, user = PhoneNumber });
                        }
                        else
                        {
                            await _signInManager.SignInAsync(_user, isPersistent: false);
                            return RedirectToAction("Index", "Home", new { Areas = "" });
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "کد تایید اشتباه است");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "کد تایید اشتباه است");
                }

            }

            TempData["CodeConfirm"] = codeConfirm;
            TempData["PhoneNumber"] = PhoneNumber;
            TempData["Forgot"] = forgot;

            return Page();
        }
    }
}
