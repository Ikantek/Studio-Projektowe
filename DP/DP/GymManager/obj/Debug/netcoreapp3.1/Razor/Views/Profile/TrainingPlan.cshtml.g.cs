#pragma checksum "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79b66d30ae44762954a49aad14121a978bf19bfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_TrainingPlan), @"mvc.1.0.view", @"/Views/Profile/TrainingPlan.cshtml")]
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
#line 1 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
using GymManager.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b66d30ae44762954a49aad14121a978bf19bfe", @"/Views/Profile/TrainingPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bd0ab2074001145446b239e85f716a1544e799", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_TrainingPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Profile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" width:100%; height:50rem; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
  
    var user = (User)ViewBag.User;

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79b66d30ae44762954a49aad14121a978bf19bfe4851", async() => {
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
#line 15 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
                   Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
                              Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"profile-userbuttons\">\n");
#nullable restore
#line 19 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
                     if (user.RoleId == (int)RolesEnum.Manager)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 689, "\"", 746, 4);
            WriteAttributeValue("", 699, "window.location", 699, 15, true);
            WriteAttributeValue(" ", 714, "=\'", 715, 3, true);
#nullable restore
#line 21 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
WriteAttributeValue("", 717, Url.Action("Index","Admin"), 717, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 745, "\'", 745, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Panel Managera</button>\n");
#nullable restore
#line 22 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
                     if (user.RoleId == (int)RolesEnum.Trainer)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"btn btn-success btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 942, "\"", 999, 4);
            WriteAttributeValue("", 952, "window.location", 952, 15, true);
            WriteAttributeValue(" ", 967, "=\'", 968, 3, true);
#nullable restore
#line 25 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
WriteAttributeValue("", 970, Url.Action("Index","Admin"), 970, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 998, "\'", 998, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Panel Trenera</button>\n");
#nullable restore
#line 26 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
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
            BeginWriteAttribute("href", " href=\"", 1338, "\"", 1375, 1);
#nullable restore
#line 32 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
WriteAttributeValue("", 1345, Url.Action("Index","Profile"), 1345, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Wyniki</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1465, "\"", 1506, 1);
#nullable restore
#line 33 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
WriteAttributeValue("", 1472, Url.Action("Discounts","Profile"), 1472, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Karnety</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1597, "\"", 1633, 1);
#nullable restore
#line 34 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
WriteAttributeValue("", 1604, Url.Action("Diet","Profile"), 1604, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">Dieta</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1722, "\"", 1766, 1);
#nullable restore
#line 35 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
WriteAttributeValue("", 1729, Url.Action("TrainingPlan","Profile"), 1729, 37, false);

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
");
#nullable restore
#line 44 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
                 if ((bool)ViewBag.FileExist)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2 class=\"text-center\">Twój plan treningowy:</h2>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("iframe", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79b66d30ae44762954a49aad14121a978bf19bfe12106", async() => {
                WriteLiteral("\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2243, "~/TrainingPlan/", 2243, 15, true);
#nullable restore
#line 47 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
AddHtmlAttributeValue("", 2258, user.UserId, 2258, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2272, ".pdf", 2272, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 49 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <h2 class=""text-center"">Przykładowy plan treningowy:</h2>
                    <p class=""text-center"">Ten plan treningowy został stworzony dla innego człowieka. Stosowanie go bez konsultacji z trenerem personalnym może skutkować problemami zdrowotnymi. W celu wykupienia własnego planu treningowego skontaktuj się z osobą będącą na recepcji.</p>
                    <iframe src=""https://fitnessplatinium.pl/content/uploads/2018/02/Plan-treningowy-Szymon-Najzer.pdf"" style="" width:100%; height:50rem; "">
                    </iframe>
");
#nullable restore
#line 56 "C:\Users\mczad\source\repos\Ikantek\DP\DP\GymManager\Views\Profile\TrainingPlan.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n<br>\n<br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591