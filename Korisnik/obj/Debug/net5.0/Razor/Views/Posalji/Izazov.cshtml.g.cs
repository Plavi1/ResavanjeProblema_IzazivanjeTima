#pragma checksum "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "597f6732fdc047b9ef46b7418da44a42ce05af3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posalji_Izazov), @"mvc.1.0.view", @"/Views/Posalji/Izazov.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
using Korisnik.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"597f6732fdc047b9ef46b7418da44a42ce05af3e", @"/Views/Posalji/Izazov.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68bbdf88593f164efc2b0f2ae854786fdbfa11c", @"/Views/_ViewImports.cshtml")]
    public class Views_Posalji_Izazov : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PosaljiIzazovViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
   ViewData["Title"] = "ListaKorisnika";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
   int i = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js\"></script>\n\n<h1>Lista  Korisnika</h1>\n\n");
#nullable restore
#line 11 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
 if (Model.ApplicationKorisnik.Any())
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "597f6732fdc047b9ef46b7418da44a42ce05af3e7075", async() => {
                WriteLiteral(@"
    <table class=""table table-dark"">

        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Ime</th>
                <th scope=""col"">Prezime</th>
                <th scope=""col"">Stikliraj</th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 26 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
             foreach (var list in Model.ApplicationKorisnik)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 29 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
   Write(Convert.ToString(i++));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n    <td>");
#nullable restore
#line 30 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
   Write(list.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n    <td>");
#nullable restore
#line 31 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
   Write(list.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n\n    <td>\n        <div class=\"form-group\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "597f6732fdc047b9ef46b7418da44a42ce05af3e8886", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 35 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdIzazvanog);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
                                    WriteLiteral(list.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n    </td>\n\n</tr>\n");
#nullable restore
#line 40 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\n\n    </table>\n    <div class=\"form-group\">\n        <button type=\"submit\" class=\"btn btn-primary\">Posalji</button> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "597f6732fdc047b9ef46b7418da44a42ce05af3e11792", async() => {
                    WriteLiteral("Pocetna");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <span class=\"text-danger\">");
#nullable restore
#line 46 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
                             Write(Model.ErrorPoruka);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 48 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
        }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>NEMA DRUGIH REGISTROVANIH KORISNIKA</h2>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "597f6732fdc047b9ef46b7418da44a42ce05af3e15249", async() => {
                WriteLiteral("Pocetna");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 52 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Posalji\Izazov.cshtml"
                                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>$(""input:checkbox"").on('click', function () {
            var $box = $(this);
            if ($box.is("":checked"")) {
                var group = ""input:checkbox[name='"" + $box.attr(""name"") + ""']"";
                $(group).prop(""checked"", false);
                $box.prop(""checked"", true);
            } else {
                $box.prop(""checked"", false);
            }
        });</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PosaljiIzazovViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
