#pragma checksum "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8fee91897c0cc09b8f7c8704f7992ecf3974f02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Discounts), @"mvc.1.0.view", @"/Views/Profile/Discounts.cshtml")]
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
#line 2 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
using GymManager.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8fee91897c0cc09b8f7c8704f7992ecf3974f02", @"/Views/Profile/Discounts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bd0ab2074001145446b239e85f716a1544e799", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Discounts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Discount>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Profile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
  
    var user = (User)ViewBag.User;

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8fee91897c0cc09b8f7c8704f7992ecf3974f024285", async() => {
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
#line 15 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                   Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                              Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"profile-userbuttons\">\n");
#nullable restore
#line 19 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                     if (user.RoleId == (int)RolesEnum.Manager)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 689, "\"", 746, 4);
            WriteAttributeValue("", 699, "window.location", 699, 15, true);
            WriteAttributeValue(" ", 714, "=\'", 715, 3, true);
#nullable restore
#line 21 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
WriteAttributeValue("", 717, Url.Action("Index","Admin"), 717, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 745, "\'", 745, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Panel Managera</button>\n");
#nullable restore
#line 22 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                     if (user.RoleId == (int)RolesEnum.Trainer)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"btn btn-success btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 938, "\"", 995, 4);
            WriteAttributeValue("", 948, "window.location", 948, 15, true);
            WriteAttributeValue(" ", 963, "=\'", 964, 3, true);
#nullable restore
#line 25 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
WriteAttributeValue("", 966, Url.Action("Index","Admin"), 966, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 994, "\'", 994, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Panel Trenera</button>\n");
#nullable restore
#line 26 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <hr class=""profile-split-top"" />
                <div class=""profile-usermenu"">
                    <div class=""bg-light border-right"" id=""sidebar-wrapper"">
                        <div class=""list-group list-group-flush"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1334, "\"", 1371, 1);
#nullable restore
#line 32 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
WriteAttributeValue("", 1341, Url.Action("Index","Profile"), 1341, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Wyniki</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1461, "\"", 1502, 1);
#nullable restore
#line 33 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
WriteAttributeValue("", 1468, Url.Action("Discounts","Profile"), 1468, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Karnety</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1593, "\"", 1629, 1);
#nullable restore
#line 34 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
WriteAttributeValue("", 1600, Url.Action("Diet","Profile"), 1600, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Dieta</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1718, "\"", 1762, 1);
#nullable restore
#line 35 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
WriteAttributeValue("", 1725, Url.Action("TrainingPlan","Profile"), 1725, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""list-group-item list-group-item-action"">Plan Treningowy</a>
                        </div>
                    </div>
                </div>
                <hr class=""profile-split-bottom"" />
            </div>
        </div>
        <div class=""col-md-9"">
            <div class=""profile-content"">
                <div class=""profile-content"">
                    <table class=""table table-exercises"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th scope=""col"">L.P</th>
                                <th scope=""col"">Nazwa promocji</th>
                                <th scope=""col"">Wartość zniżki</th>
                                <th scope=""col"">Opis promocji</th>
                                <th scope=""col"">Data ważności promocji</th>
                                <th scope=""col"">Kod promocyjny</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 57 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                             for (int i = 0; i < Model.Count(); i++)
                            {
                                var lp = i + 1;
                                var element = Model.ElementAt(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <th scope=\"row\">");
#nullable restore
#line 62 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                                               Write(lp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <td>");
#nullable restore
#line 63 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                                   Write(element.DiscountName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 64 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                                   Write(element.DiscountValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 65 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                                   Write(element.DiscountDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 66 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                                   Write(element.ExpiryDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 67 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"
                                   Write(element.DiscountCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                </tr>\n");
#nullable restore
#line 69 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\Discounts.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<br>\n<br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Discount>> Html { get; private set; }
    }
}
#pragma warning restore 1591