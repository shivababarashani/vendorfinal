using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Vendor.Domain;

namespace Vendor.Web.Utilities
{
    
        public static class PrincipalExtensions
        {
        public static string GetFullName(this ClaimsPrincipal user, UserManager<ApplicationUser> userManager)
        {
            if (user.Identity.IsAuthenticated)
            {
                //two way get userId
                //var userId = _userManager.GetUserId(User);

                var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);

                var appUser = userManager.FindByIdAsync(userId).Result;

                return $"{appUser.FirstName} {appUser.LastName}";
            }

            return "";
        }

        public static ApplicationUser GetUser(this ClaimsPrincipal user, UserManager<ApplicationUser> userManager)
            {
                if (user.Identity.IsAuthenticated)
                {
                    //two way get userId
                    //var userId = _userManager.GetUserId(User);

                    var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);

                    var appUser = userManager.FindByIdAsync(userId).Result;

                    return appUser;
                }

                return null;
            }

            public static string GetUserId(this ClaimsPrincipal user, UserManager<ApplicationUser> userManager)
            {
                if (user.Identity.IsAuthenticated)
                {
                    //two way get userId
                    //var userId = _userManager.GetUserId(User);

                    var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);

                    var appUser = userManager.FindByIdAsync(userId).Result;

                    return appUser.Id;
                }

                return null;
            }

            [Authorize]
            public static string GetUserImageAddress(this ClaimsPrincipal user, UserManager<ApplicationUser> userManager)
            {
                if (user.Identity.IsAuthenticated)
                {
                    //two way get userId
                    //var userId = _userManager.GetUserId(User);

                    var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);

                    var appUser = userManager.FindByIdAsync(userId).Result;

                    return appUser.UserImage;
                }

                return null;
            }


            public static string GetFullNameIdentity(this ClaimsPrincipal user, UserManager<ApplicationUser> userManager, string UserId)
            {
                var appUser = userManager.FindByIdAsync(UserId).Result;
                return $"{appUser.FirstName +" "+appUser.LastName}";
            }

            public static string GetImage(this ClaimsPrincipal user, UserManager<ApplicationUser> userManager, string UserId)
            {
                var appUser = userManager.FindByIdAsync(UserId).Result;
                return $"{appUser.UserImage}";
            }


        
    }
}
