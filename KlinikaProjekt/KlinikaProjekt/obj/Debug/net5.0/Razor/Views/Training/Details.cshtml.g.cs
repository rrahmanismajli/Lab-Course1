#pragma checksum "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec016b7db289ecf23dc4c3e48c6a6507a17dbda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_Details), @"mvc.1.0.view", @"/Views/Training/Details.cshtml")]
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
#line 1 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\_ViewImports.cshtml"
using KlinikaProjekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\_ViewImports.cshtml"
using KlinikaProjekt.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec016b7db289ecf23dc4c3e48c6a6507a17dbda", @"/Views/Training/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5edc81fe146ce39ab93be470b0a1045af55c2156", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Training_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Training>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Department", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Doctors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
  
    ViewData["Title"] = "Offer details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <div class=""card mb-12"">
            <div class=""row g-0"">
                <div class=""col-md-12"">
                    <div class=""card-header text-white bg-info"">
                        <p class=""card-text"">
                            <h5 class=""card-title"">
                                ");
#nullable restore
#line 15 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </h5>\n                        </p>\n                    </div>\n                </div>\n");
            WriteLiteral("                <div class=\"col-md-8\">\n                    <div class=\"card-body\">\n                        <p class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text\">\n                            <b>Hospital: </b>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec016b7db289ecf23dc4c3e48c6a6507a17dbda7181", async() => {
                WriteLiteral("\n                                ");
#nullable restore
#line 29 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                           Write(Model.Department.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                                                                                  WriteLiteral(Model.DepartmentId);

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
            WriteLiteral("\n                        </p>\n                      \n                        <p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 33 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                                                         Write(Model.TrainingCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text\"><b>Start Date: </b>");
#nullable restore
#line 34 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                                                           Write(Model.StartDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text\"><b>End Date: </b>");
#nullable restore
#line 35 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                                                         Write(Model.EndDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text \">\n                            <b>Status: </b>\n");
#nullable restore
#line 38 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                             if (DateTime.Now >= Model.StartDate && DateTime.Now <= Model.EndDate)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-success text-white\">AVAILABLE</span>\n");
#nullable restore
#line 41 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                            }
                            else if (DateTime.Now > Model.EndDate)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-danger text-white\">EXPIRED</span>\n");
#nullable restore
#line 45 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-primary text-white\">UPCOMING</span>\n");
#nullable restore
#line 49 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </p>\n                        <p class=\"card-text\">\n                            <b>Actors: </b>\n                            <hr />\n                            <div class=\"row\">\n");
#nullable restore
#line 55 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                                 foreach (var doctor in Model.Training_Doctor)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"column text-center\">\n                                        <img class=\"border-info rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 2677, "\"", 2715, 1);
#nullable restore
#line 58 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
WriteAttributeValue("", 2683, doctor.Doctor.ProfilePictureURL, 2683, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\n                                        <br />\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec016b7db289ecf23dc4c3e48c6a6507a17dbda13914", async() => {
#nullable restore
#line 60 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                                                                                                                    Write(doctor.Doctor.FullName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                                                                                           WriteLiteral(doctor.DoctorId);

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
            WriteLiteral("\n                                    </div>\n");
#nullable restore
#line 62 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </p>

                    </div>
                </div>
                <div class=""col-md-12"">
                    <div class=""card-footer"">
                        <p class=""card-text"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec016b7db289ecf23dc4c3e48c6a6507a17dbda17199", async() => {
                WriteLiteral("\n                                Back to List\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec016b7db289ecf23dc4c3e48c6a6507a17dbda18534", async() => {
                WriteLiteral("<i class=\"bi bi-cart-plus\"></i> Add to Cart (Price ");
#nullable restore
#line 76 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
                                                                                                                                         Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3476, "btn", 3476, 3, true);
            AddHtmlAttributeValue(" ", 3479, "btn-success", 3480, 12, true);
            AddHtmlAttributeValue(" ", 3491, "text-white", 3492, 11, true);
#nullable restore
#line 74 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
AddHtmlAttributeValue("  ", 3502, (DateTime.Now > Model.EndDate) ? "disabled" : "", 3504, 51, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Training\Details.cshtml"
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
            WriteLiteral("\n                        </p>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Training> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
