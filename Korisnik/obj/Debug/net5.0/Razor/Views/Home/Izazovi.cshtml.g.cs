#pragma checksum "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9424828667b980577bb5273c434d0fecc7bffb66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Izazovi), @"mvc.1.0.view", @"/Views/Home/Izazovi.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\_ViewImports.cshtml"
using Korisnik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\_ViewImports.cshtml"
using Korisnik.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml"
using Korisnik.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9424828667b980577bb5273c434d0fecc7bffb66", @"/Views/Home/Izazovi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68bbdf88593f164efc2b0f2ae854786fdbfa11c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Izazovi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoslatiIzazoviViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml"
   ViewData["Title"] = "Izazovi";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml"
   int i = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <h1>Izazvani ste od strane:</h1>\n</div>\n");
#nullable restore
#line 10 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml"
 if (Model.Izazovi.Any())
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-dark w-25"">

    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Izazvao</th>
            <th scope=""col""></th>
            <th scope=""col""></th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 26 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml"
         foreach (var lista in Model.Izazovi)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 29 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml"
   Write(Convert.ToString(i++));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 30 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml"
   Write(lista.ImeIzazivaoca);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
    <td>
         <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
            <button class=""btn btn-danger"">Ne prihvatas</button>

            <button class=""btn btn-success"">Prihvatam</button>

            <button class=""btn btn-warning"">Promeni vreme</button>
         </div>
    </td>

</tr>");
#nullable restore
#line 41 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9424828667b980577bb5273c434d0fecc7bffb667415", async() => {
                WriteLiteral("Pocetna");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml"
                                                                                                                }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Niste izazvani</h2>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9424828667b980577bb5273c434d0fecc7bffb669366", async() => {
                WriteLiteral("Pocetna");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 48 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Home\Izazovi.cshtml"
                                                                                                               }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoslatiIzazoviViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
