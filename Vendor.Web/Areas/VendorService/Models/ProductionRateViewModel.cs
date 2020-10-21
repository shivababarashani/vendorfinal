using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendor.Web.Areas.VendorService.Models
{
   

    public class Root
    {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductProductTypeId { get; set; }
        public string ProductCompanyId { get; set; }
       // public UploadControlForm UploadControlForm { get; set; }
        public string ProductCorroborantId { get; set; }
        public bool ProductGuarantee { get; set; }
        public bool ProductEnvironment { get; set; }
        public List<ExportViewModel> exports { get; set; }
        public List<ProductionRateViewModel> productionRates { get; set; }
    }
    
    public class FormFileWrapper
    {
        public IFormFile File { get; set; }
    }

        public class UploadControlForm
        {
            public long lastModified { get; set; }
            public DateTime lastModifiedDate { get; set; }
            public string name { get; set; }
            public int size { get; set; }
            public string type { get; set; }
        }

    

    public class ProductionRateViewModel
    {

        public string productionRateYear { get; set; }
        public string productionRateAmount { get; set; }

    }

    public class ExportViewModel
    {
        public string ExportYear { get; set; }
        public string ExportEmployer { get; set; }
        public string ExportContractNumber { get; set; }
        public string ExportWeightNumber { get; set; }
        public string ExportDescription { get; set; }
    }
}
