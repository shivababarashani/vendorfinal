using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Vendor.Domain.Entites.Products;

namespace Vendor.Domain
{
   public class ApplicationUser:IdentityUser
    {
        [Required(ErrorMessage = "وارد نمودن نام اجباری است ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "وارد نمودن نام خانوادگی اجباری است")]
        public string LastName { get; set; }

        public string UserImage { get; set; }

        public DateTime LoginDate { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
