#pragma checksum "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2827a81e277462e7dfc41db0c8469fefda726425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_VendorService_Views_Companies_Details), @"mvc.1.0.view", @"/Areas/VendorService/Views/Companies/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\_ViewImports.cshtml"
using Vendor.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\_ViewImports.cshtml"
using Vendor.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2827a81e277462e7dfc41db0c8469fefda726425", @"/Areas/VendorService/Views/Companies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b89ce51ccf45b1c282b0c1f07cce8adb9c9e10", @"/Areas/VendorService/Views/_ViewImports.cshtml")]
    public class Areas_VendorService_Views_Companies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vendor.Domain.Entites.Companies.Company>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Company</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RecordNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.RecordNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RecordDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.RecordDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RecordPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.RecordPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FactoryStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.FactoryStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FactoryUseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.FactoryUseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NationalId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.NationalId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EconomicCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.EconomicCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UseLicenseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.UseLicenseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UseLicenseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.UseLicenseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ActivityDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.ActivityDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaterialList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaterialList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Randd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Randd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ConstructionMetod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.ConstructionMetod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QcProgram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.QcProgram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ResearchMember));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.ResearchMember));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UploadUseLicensePic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.UploadUseLicensePic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UploadStatutePic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.UploadStatutePic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UploadOfficialnewspapers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.UploadOfficialnewspapers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UploadProductCatalog));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.UploadProductCatalog));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UploadDocuments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.UploadDocuments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UploadMemberOfTheInstitute));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.UploadMemberOfTheInstitute));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnershipType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnershipType.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyType.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.License));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.License.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2827a81e277462e7dfc41db0c8469fefda72642522044", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 179 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\Companies\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2827a81e277462e7dfc41db0c8469fefda72642524201", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vendor.Domain.Entites.Companies.Company> Html { get; private set; }
    }
}
#pragma warning restore 1591
