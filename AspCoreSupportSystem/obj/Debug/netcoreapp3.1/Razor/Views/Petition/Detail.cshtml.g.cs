#pragma checksum "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c862d52f3aa8ba2f92f2aca9a741c65cc34614"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Petition_Detail), @"mvc.1.0.view", @"/Views/Petition/Detail.cshtml")]
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
#line 3 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\_ViewImports.cshtml"
using AspCoreSupportSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\_ViewImports.cshtml"
using AspCoreSupportSystem.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\_ViewImports.cshtml"
using Entities.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c862d52f3aa8ba2f92f2aca9a741c65cc34614", @"/Views/Petition/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544268a3750244c98f0fedee9b58b30ba76b6e41", @"/Views/_ViewImports.cshtml")]
    public class Views_Petition_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListPetitionDetailDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary mt-4 ml-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("7"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddContent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Content", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col-md-2\"></div>\r\n        <div class=\"col-md-8 bg-white border border-dark mb-5 rounded\">\r\n");
#nullable restore
#line 7 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
              
                if (ViewBag.ContentStatus == "ContentAdded")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-success mt-4\">\r\n                        <small>Yorumunuz Başarıyla Eklendi.</small>\r\n                    </div>\r\n");
#nullable restore
#line 13 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                }
                else if (ViewBag.ContentStatus == "ContentNotAdded")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger mt-4\">\r\n                        <small>Yorum Eklenirken Bir Hata Oluştu.</small>\r\n                    </div>\r\n");
#nullable restore
#line 19 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                }
                else if (ViewBag.ContentStatus == "ContentSpam")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger mt-4\">\r\n                        <small>Ardı Ardına En Fazla 2 Yorum Ekleyebilirsiniz.</small>\r\n                    </div>\r\n");
#nullable restore
#line 25 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                }


            

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <h5 class=\"mt-4\">Dilekçe Bilgisi</h5>\r\n            </div>\r\n            <div class=\"col-md-7\"></div>\r\n            <div class=\"col-md-2\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c862d52f3aa8ba2f92f2aca9a741c65cc346149809", async() => {
                WriteLiteral("Dökümanlar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1294, "~/Documents/", 1294, 12, true);
#nullable restore
#line 35 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
AddHtmlAttributeValue("", 1306, Model.Petition.PetitionID, 1306, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div><hr />\r\n            \r\n            <h6>Dilekçe Numarası : ");
#nullable restore
#line 39 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                              Write(Model.Petition.PetitionID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><hr/>\r\n            <h6>Oluşturan : ");
#nullable restore
#line 40 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                       Write(Model.Petition.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><hr/>\r\n            <h6>Oluşturulma Tarihi : ");
#nullable restore
#line 41 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                                Write(Model.Petition.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><hr/>\r\n            <h6>Durumu :\r\n");
#nullable restore
#line 43 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                  if (Model.Petition.Statu == Statu.Gönderildi)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"text-primary\">Gönderildi</span>\r\n");
#nullable restore
#line 46 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                }
                else if (Model.Petition.Statu == Statu.İşlemeAlındı)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"text-warning\">İşleme Alındı</span>\r\n");
#nullable restore
#line 50 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"text-success\">Çözüldü</span>\r\n");
#nullable restore
#line 54 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </h6><hr/>\r\n\r\n\r\n            <h6>Konu : ");
#nullable restore
#line 58 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                  Write(Model.Petition.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n            <br/><br/>\r\n            <h5>İçerik</h5><hr/>\r\n\r\n");
#nullable restore
#line 63 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
             foreach (var content in Model.Contents)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                 if (content.isAdmin)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card text-center mb-5 mt-5\">\r\n                        <div class=\"card-header bg-white\">\r\n                            <b>");
#nullable restore
#line 69 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                          Write(content.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Yönetici)</b>\r\n                        </div>\r\n                        <div class=\"card-body bg-light\">\r\n\r\n                            <p class=\"card-text\">");
#nullable restore
#line 73 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                                            Write(content.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        </div>\r\n                        <div class=\"card-footer text-muted bg-white\">\r\n                            <b>Tarih : </b>");
#nullable restore
#line 77 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                                      Write(content.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b class=\"ml-4\">Saat : </b>");
#nullable restore
#line 77 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                                                                                                      Write(content.Date.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 80 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card text-center mb-5 mt-5\">\r\n                        <div class=\"card-header\">\r\n                            <b>");
#nullable restore
#line 85 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                          Write(content.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n\r\n                            <p class=\"card-text\">");
#nullable restore
#line 89 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                                            Write(content.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        </div>\r\n                        <div class=\"card-footer text-muted\">\r\n                            <b>Tarih : </b>");
#nullable restore
#line 93 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                                      Write(content.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b class=\"ml-4\">Saat : </b>");
#nullable restore
#line 93 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                                                                                                      Write(content.Date.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 96 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
                 
           
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 101 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
             if (Model.Petition.Statu != Statu.Çözüldü)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c862d52f3aa8ba2f92f2aca9a741c65cc3461419264", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c862d52f3aa8ba2f92f2aca9a741c65cc3461419543", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 104 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c862d52f3aa8ba2f92f2aca9a741c65cc3461421305", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 107 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AddContent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c862d52f3aa8ba2f92f2aca9a741c65cc3461422928", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 108 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AddContent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c862d52f3aa8ba2f92f2aca9a741c65cc3461424656", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 109 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AddContent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group mt-4 mb-5\">\r\n                        <input type=\"submit\" value=\"Yorum Ekle\" class=\"btn btn-block btn-primary mt-3 mb-5\"/>\r\n                    </div>\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12c862d52f3aa8ba2f92f2aca9a741c65cc3461426592", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 116 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Petition.PetitionID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12c862d52f3aa8ba2f92f2aca9a741c65cc3461428343", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 117 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.UserID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12c862d52f3aa8ba2f92f2aca9a741c65cc3461430079", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 118 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.isAdmin);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 120 "C:\Users\eren_\Desktop\örnekc#\DestekSistemi\AspCoreSupportSystem\Views\Petition\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-2\"></div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListPetitionDetailDto> Html { get; private set; }
    }
}
#pragma warning restore 1591