#pragma checksum "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f46176ca4bde3c64f2f7597ab2afa82afd797dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddArticle), @"mvc.1.0.view", @"/Views/Admin/AddArticle.cshtml")]
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
#line 1 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\_ViewImports.cshtml"
using GymManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\_ViewImports.cshtml"
using GymManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
using GymManager.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f46176ca4bde3c64f2f7597ab2afa82afd797dd", @"/Views/Admin/AddArticle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bd0ab2074001145446b239e85f716a1544e799", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddArticle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Admin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
   var user = (User)ViewBag.User;
                var isManager = (int)ViewBag.User.RoleId == (int)RolesEnum.Manager; 

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f46176ca4bde3c64f2f7597ab2afa82afd797dd4931", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral(@"<div class=""container"">
    <div class=""row profile"">
        <div class=""col-md-3"">
            <div class=""profile-sidebar"">
                <div class=""profile-usertitle"">
                    <div class=""profile-usertitle-name"">
                        ");
#nullable restore
#line 14 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
                   Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
                              Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"profile-userbuttons\">\n                    <button class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 676, "\"", 735, 4);
            WriteAttributeValue("", 686, "window.location", 686, 15, true);
            WriteAttributeValue(" ", 701, "=\'", 702, 3, true);
#nullable restore
#line 18 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
WriteAttributeValue("", 704, Url.Action("Index","Profile"), 704, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 734, "\'", 734, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Panel użytkownika</button>
                </div>
                <hr class=""profile-split-top"" />
                <div class=""profile-usermenu"">
                    <div class=""bg-light border-right"" id=""sidebar-wrapper"">
                        <div class=""list-group list-group-flush"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1056, "\"", 1091, 1);
#nullable restore
#line 24 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
WriteAttributeValue("", 1063, Url.Action("Index","Admin"), 1063, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Lista użytkowników</a>\n");
#nullable restore
#line 25 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
                             if (isManager)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1267, "\"", 1305, 1);
#nullable restore
#line 27 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
WriteAttributeValue("", 1274, Url.Action("AddUser", "Admin"), 1274, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Dodaj użytkownika</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1406, "\"", 1443, 1);
#nullable restore
#line 28 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
WriteAttributeValue("", 1413, Url.Action("Passes", "Admin"), 1413, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Panel zniżek</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1539, "\"", 1580, 1);
#nullable restore
#line 29 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
WriteAttributeValue("", 1546, Url.Action("AddArticle", "Admin"), 1546, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Dodaj artykuł</a>");
#nullable restore
#line 29 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
                                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1678, "\"", 1718, 1);
#nullable restore
#line 30 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
WriteAttributeValue("", 1685, Url.Action("AddDietTP", "Admin"), 1685, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""list-group-item list-group-item-action"">Dodaj plan treningowy lub dietę</a>
                        </div>
                    </div>
                </div>
                <hr class=""profile-split-bottom"" />
            </div>
        </div>
        <div class=""col-md-9"">
            <div class=""profile-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f46176ca4bde3c64f2f7597ab2afa82afd797dd11277", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" name=""header"" placeholder=""Tytuł artykułu"">
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" name=""description"" placeholder=""Treść artykułu..."">
                    </div>
                    <div class=""form-check d-inline m-3"">
                        <input class=""form-check-input"" type=""radio""");
                BeginWriteAttribute("value", " value=\"", 2616, "\"", 2648, 1);
#nullable restore
#line 47 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
WriteAttributeValue("", 2624, (int)NewsEnum.Serious, 2624, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""type"" checked>
                        <label class=""form-check-label"" for=""exampleRadios1"">
                            Normalny artykuł
                        </label>
                    </div>
                    <div class=""form-check d-inline m-3"">
                        <input class=""form-check-input"" type=""radio""");
                BeginWriteAttribute("value", " value=\"", 2980, "\"", 3016, 1);
#nullable restore
#line 53 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
WriteAttributeValue("", 2988, (int)NewsEnum.Advertising, 2988, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""type"">
                        <label class=""form-check-label"" for=""exampleRadios2"">
                            Śmieszny artykuł
                        </label>
                    </div>
                    <div>
                        <button type=""submit"" class=""btn btn-primary mt-2"">Dodaj Artykuł</button>
                    </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\AddArticle.cshtml"
AddHtmlAttributeValue("", 2073, Url.Action("AddNewsP", "Admin"), 2073, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n<br>\n<br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591