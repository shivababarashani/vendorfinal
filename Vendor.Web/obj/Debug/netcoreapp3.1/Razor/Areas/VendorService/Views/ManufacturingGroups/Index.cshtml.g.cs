#pragma checksum "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4118b3efe73b77cecaa37d132fcdf6ae829322dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_VendorService_Views_ManufacturingGroups_Index), @"mvc.1.0.view", @"/Areas/VendorService/Views/ManufacturingGroups/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4118b3efe73b77cecaa37d132fcdf6ae829322dd", @"/Areas/VendorService/Views/ManufacturingGroups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b89ce51ccf45b1c282b0c1f07cce8adb9c9e10", @"/Areas/VendorService/Views/_ViewImports.cshtml")]
    public class Areas_VendorService_Views_ManufacturingGroups_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vendor.Domain.Entites.Companies.ManufacturingGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""extended"">
    <div class=""row justify-content-lg-center"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title-wrap bar-success mb-2 text-bold-700 font-size-1-3"">
                        نوع تولیدات شرکت
                    </div>
                </div>

                <div class=""col-lg-12 container-fluid  text-right"">
                    <a onclick=""Add()"" class=""btn btn-outline btn-success font-size-0-9""><i class=""fas fa-plus""></i> افزودن </a>
                </div>

                <div class=""card-body m-3"">
                    <div");
            BeginWriteAttribute("class", " class=\"", 740, "\"", 748, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <table class=""table table-responsive-md text-center table-bordered table-striped"" id=""mytable"">
                            <thead class=""thead-dark text-white"">
                                <tr>
                                    <th>
                                        ");
#nullable restore
#line 22 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 26 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 32 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 36 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 39 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-sm btn-primary pull-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2104, "\"", 2130, 3);
            WriteAttributeValue("", 2114, "Edit(\'", 2114, 6, true);
#nullable restore
#line 42 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
WriteAttributeValue("", 2120, item.Id, 2120, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2128, "\')", 2128, 2, true);
            EndWriteAttribute();
            WriteLiteral(">ویرایش</a> |\r\n                                            <a class=\"btn btn-sm btn-danger pull-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2233, "\"", 2258, 3);
            WriteAttributeValue("", 2243, "Del(\'", 2243, 5, true);
#nullable restore
#line 43 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
WriteAttributeValue("", 2248, item.Id, 2248, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2256, "\')", 2256, 2, true);
            EndWriteAttribute();
            WriteLiteral("> حذف</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 46 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<script>\r\n\r\n    function Add() {\r\n            var SendingUrl = \'");
#nullable restore
#line 59 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
                         Write(Url.Action("Create", "ManufacturingGroups"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            $.get(SendingUrl,
                function (frmEdit) {
                    $(""#itemEdit"").html(frmEdit);
                    $(""#edit-files"").modal(""show"");

                });
        }

    function Edit(Id) {
            var SendingUrl = '");
#nullable restore
#line 69 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
                         Write(Url.Action("Edit", "ManufacturingGroups"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        var SendingData = 'Id=' + Id ;
            $.get(SendingUrl,
                SendingData,
                function (frmEdit) {
                    $(""#itemEdit"").html(frmEdit);
                    $(""#edit-files"").modal(""show"");

                });
    }



    function Del(Id) {
            var SendingUrl = '");
#nullable restore
#line 83 "E:\SourceControl\VendorProject\Vendor.Web\Areas\VendorService\Views\ManufacturingGroups\Index.cshtml"
                         Write(Url.Action("Delete", "ManufacturingGroups"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        var SendingData = 'Id=' +Id;
            $.get(SendingUrl,
                SendingData,
                function (frmEdit) {
                    $(""#itemEdit"").html(frmEdit);
                    $(""#edit-files"").modal(""show"");

                });
        }


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vendor.Domain.Entites.Companies.ManufacturingGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
