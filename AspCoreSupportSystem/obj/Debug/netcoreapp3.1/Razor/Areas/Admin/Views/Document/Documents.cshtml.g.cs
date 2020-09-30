#pragma checksum "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\Document\Documents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3104b4f33641c4c2bba5d8cc50468379df0d8ce3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Document_Documents), @"mvc.1.0.view", @"/Areas/Admin/Views/Document/Documents.cshtml")]
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
#line 1 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\_ViewImports.cshtml"
using AspCoreSupportSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\_ViewImports.cshtml"
using AspCoreSupportSystem.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\_ViewImports.cshtml"
using Entities.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\_ViewImports.cshtml"
using AspCoreSupportSystem.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\Document\Documents.cshtml"
using Entities.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3104b4f33641c4c2bba5d8cc50468379df0d8ce3", @"/Areas/Admin/Views/Document/Documents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ffc33f498d25c4e1f3aadc7689eef83efb6057", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Document_Documents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Entities.Document>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row mt-5\">\r\n    <div class=\"col-md-3\"></div>\r\n    <div class=\"col-md-6\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\Document\Documents.cshtml"
          if (ViewBag.DocumentStatus == "DocumentAdded")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success mt-4 mb-4\">\r\n                <small>Döküman Başarıyla Eklendi.</small>\r\n            </div>\r\n");
#nullable restore
#line 14 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\Document\Documents.cshtml"
        }
        else if (ViewBag.DocumentStatus == "DocumentNotAdded")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger mt-4 mb-4\">\r\n                <small>Döküman Eklenemedi.</small>\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\Document\Documents.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-hover mt-4\">\r\n            <thead>\r\n            <th class=\"text-center\">Döküman Adı</th>\r\n            <th class=\"text-center\">İndir</th>\r\n            </thead>\r\n                \r\n            <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\Document\Documents.cshtml"
             foreach (Document document in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 31 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\Document\Documents.cshtml"
                                       Write(document.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\"><a class=\"btn btn-sm btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1056, "\"", 1123, 2);
            WriteAttributeValue("", 1063, "/Admin/Document/Download?documentName=", 1063, 38, true);
#nullable restore
#line 32 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\Document\Documents.cshtml"
WriteAttributeValue("", 1101, document.DocumentName, 1101, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">İndir</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Areas\Admin\Views\Document\Documents.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"col-md-3\"></div>\r\n    </div></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Entities.Document>> Html { get; private set; }
    }
}
#pragma warning restore 1591