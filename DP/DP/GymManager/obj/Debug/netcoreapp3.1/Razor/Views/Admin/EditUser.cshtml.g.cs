#pragma checksum "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b26f8ec24988b016e284076c1d83293c22884cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditUser), @"mvc.1.0.view", @"/Views/Admin/EditUser.cshtml")]
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
#line 1 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
using GymManager.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b26f8ec24988b016e284076c1d83293c22884cb", @"/Views/Admin/EditUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bd0ab2074001145446b239e85f716a1544e799", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
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
#line 4 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
  
    var user = (User)ViewBag.User;
    var isManager = (int)ViewBag.User.RoleId == (int)RolesEnum.Manager;

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b26f8ec24988b016e284076c1d83293c22884cb5099", async() => {
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
#line 17 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
                   Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
                              Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"profile-userbuttons\">\n                    <button class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 697, "\"", 756, 4);
            WriteAttributeValue("", 707, "window.location", 707, 15, true);
            WriteAttributeValue(" ", 722, "=\'", 723, 3, true);
#nullable restore
#line 21 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 725, Url.Action("Index","Profile"), 725, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 755, "\'", 755, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Panel u??ytkownika</button>
                </div>
                <hr class=""profile-split-top"" />
                <div class=""profile-usermenu"">
                    <div class=""bg-light border-right"" id=""sidebar-wrapper"">
                        <div class=""list-group list-group-flush"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1077, "\"", 1112, 1);
#nullable restore
#line 27 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 1084, Url.Action("Index","Admin"), 1084, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Lista u??ytkownik??w</a>\n");
#nullable restore
#line 28 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
                             if (isManager)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1288, "\"", 1326, 1);
#nullable restore
#line 30 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 1295, Url.Action("AddUser", "Admin"), 1295, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Dodaj u??ytkownika</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1464, 1);
#nullable restore
#line 31 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 1434, Url.Action("Passes", "Admin"), 1434, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Panel zni??ek</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1560, "\"", 1601, 1);
#nullable restore
#line 32 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 1567, Url.Action("AddArticle", "Admin"), 1567, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Dodaj artyku??</a>");
#nullable restore
#line 32 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
                                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1699, "\"", 1739, 1);
#nullable restore
#line 33 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 1706, Url.Action("AddDietTP", "Admin"), 1706, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""list-group-item list-group-item-action"">Dodaj plan treningowy lub diet??</a>
                        </div>
                    </div>
                </div>
                <hr class=""profile-split-bottom"" />
            </div>
        </div>
        <div class=""col-md-9"">
            <div class=""profile-content"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b26f8ec24988b016e284076c1d83293c22884cb11425", async() => {
                WriteLiteral("\n                    <div class=\"form-group\">\n                        <label for=\"exampleInputEmail1\">Adres email u??ytkownika:</label>\n                        <input type=\"email\" class=\"form-control\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 2355, "\"", 2375, 1);
#nullable restore
#line 45 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 2363, Model.Email, 2363, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Adres email\">\n                    </div>\n                    <input type=\"text\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 2483, "\"", 2504, 1);
#nullable restore
#line 47 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 2491, Model.UserId, 2491, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:none;\">\n                    <div class=\"form-group\">\n                        <label for=\"exampleInputEmail1\">Imi??</label>\n                        <input type=\"text\" class=\"form-control\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2718, "\"", 2737, 1);
#nullable restore
#line 50 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 2726, Model.Name, 2726, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Imi?? klienta\">\n                    </div>\n                    <div class=\"form-group\">\n                        <label for=\"exampleInputEmail1\">Nazwisko</label>\n                        <input type=\"text\" class=\"form-control\" name=\"surname\"");
                BeginWriteAttribute("value", " value=\"", 2990, "\"", 3012, 1);
#nullable restore
#line 54 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 2998, Model.Surname, 2998, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Nazwisko klienta"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">Has??o</label>
                        <input type=""text"" class=""form-control"" name=""password"" placeholder=""Has??o kt??rym u??ytkownik b??dzie si?? logowa??"">
                    </div>
                    <div>Rola u??ytkownika w systemie:</div>
                    <div class=""form-check d-inline m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""roleId""");
                BeginWriteAttribute("value", " value=\"", 3556, "\"", 3588, 1);
#nullable restore
#line 62 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 3564, (int)RolesEnum.Logged, 3564, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 62 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
                                                                                                                Write(Model.RoleId == (int)RolesEnum.Logged ? "checked" : "" );

#line default
#line hidden
#nullable disable
                WriteLiteral(@">
                        <label class=""form-check-label"" for=""exampleRadios1"">
                            Zwyk??y u??ytkownik
                        </label>
                    </div>
                    <div class=""form-check d-inline m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""roleId""");
                BeginWriteAttribute("value", " value=\"", 3974, "\"", 4007, 1);
#nullable restore
#line 68 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 3982, (int)RolesEnum.Service, 3982, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 68 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
                                                                                                                 Write(Model.RoleId == (int)RolesEnum.Service ? "checked" : "" );

#line default
#line hidden
#nullable disable
                WriteLiteral(@">
                        <label class=""form-check-label"" for=""exampleRadios1"">
                            Obs??uga
                        </label>
                    </div>
                    <div class=""form-check d-inline m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""roleId""");
                BeginWriteAttribute("value", " value=\"", 4384, "\"", 4417, 1);
#nullable restore
#line 74 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 4392, (int)RolesEnum.Trainer, 4392, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 74 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
                                                                                                                 Write(Model.RoleId == (int)RolesEnum.Trainer ? "checked" : "" );

#line default
#line hidden
#nullable disable
                WriteLiteral(@">
                        <label class=""form-check-label"" for=""exampleRadios1"">
                            Trener
                        </label>
                    </div>
                    <div class=""form-check d-inline m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""roleId""");
                BeginWriteAttribute("value", " value=\"", 4793, "\"", 4828, 1);
#nullable restore
#line 80 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 4801, (int)RolesEnum.Secretary, 4801, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 80 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
                                                                                                                   Write(Model.RoleId == (int)RolesEnum.Secretary ? "checked" : "" );

#line default
#line hidden
#nullable disable
                WriteLiteral(@">
                        <label class=""form-check-label"" for=""exampleRadios1"">
                            Sekretarka
                        </label>
                    </div>
                    <div class=""form-check d-inline m-3"">
                        <input class=""form-check-input"" type=""radio"" name=""roleId""");
                BeginWriteAttribute("value", " value=\"", 5210, "\"", 5243, 1);
#nullable restore
#line 86 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 5218, (int)RolesEnum.Manager, 5218, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 86 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
                                                                                                                 Write(Model.RoleId == (int)RolesEnum.Manager ? "checked" : "" );

#line default
#line hidden
#nullable disable
                WriteLiteral(">\n                        <label class=\"form-check-label\" for=\"exampleRadios1\">\n                            Manager\n                        </label>\n                    </div>\n");
                WriteLiteral("                    <div>\n                        <button type=\"submit\" class=\"btn btn-primary mt-2\">Zako??cz edycje</button>\n                    </div>\n                    <div class=\"d-inline\">\n                        <button class=\"btn btn-warning m-2\"");
                BeginWriteAttribute("onclick", " onclick=\"", 6045, "\"", 6108, 5);
                WriteAttributeValue("", 6055, "window.location.href", 6055, 20, true);
                WriteAttributeValue(" ", 6075, "=", 6076, 2, true);
                WriteAttributeValue(" ", 6077, "\'", 6078, 2, true);
#nullable restore
#line 101 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
WriteAttributeValue("", 6079, Url.Action("Index","Admin"), 6079, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6107, "\'", 6107, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Wr????</button>\n                    </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Admin\EditUser.cshtml"
AddHtmlAttributeValue("", 2094, Url.Action("EditUserP", "Admin"), 2094, 33, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
