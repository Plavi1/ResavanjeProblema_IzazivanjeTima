#pragma checksum "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "558c9fa23861c4e62f27282d7f21d32262731235"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PoslatiIzazovi_ListaIzazovi), @"mvc.1.0.view", @"/Views/PoslatiIzazovi/ListaIzazovi.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
using Korisnik.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"558c9fa23861c4e62f27282d7f21d32262731235", @"/Views/PoslatiIzazovi/ListaIzazovi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68bbdf88593f164efc2b0f2ae854786fdbfa11c", @"/Views/_ViewImports.cshtml")]
    public class Views_PoslatiIzazovi_ListaIzazovi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoslatiIzazoviViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
   ViewData["Title"] = "PoslatiIzazovi";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
   int i = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n <h1>Lista Izazova</h1>\n <h3>Koje ste poslali</h3>\n</div>\n");
#nullable restore
#line 11 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
 if (Model.Izazovi.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "558c9fa23861c4e62f27282d7f21d322627312356499", async() => {
                WriteLiteral("\n    <table class=\"table table-dark w-25\">\n\n        <thead>\n            <tr>\n                <th scope=\"col\">#</th>\n                <th scope=\"col\">Izazvao</th>\n                <th scope=\"col\"></th>\n            </tr>\n        </thead>\n        <tbody>\n\n");
#nullable restore
#line 25 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
             foreach (var lista in Model.Izazovi)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 28 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
   Write(Convert.ToString(i++));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n    <td>");
#nullable restore
#line 29 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
   Write(lista.ImeIzazvanog);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n    <td>\n        <div class=\"form-group\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "558c9fa23861c4e62f27282d7f21d322627312358024", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 32 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdIzazova);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
                                         WriteLiteral(lista.IdIzazova);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <button class=\"btn btn-danger\" type=\"submit\">Obrisi</button>\n        </div>\n    </td>\n\n</tr>\n");
#nullable restore
#line 38 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("         </tbody>\n    </table>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "558c9fa23861c4e62f27282d7f21d3226273123511059", async() => {
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
                WriteLiteral("\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 43 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>NEMA POSLATIH IZAZOVA</h2>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "558c9fa23861c4e62f27282d7f21d3226273123514150", async() => {
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
            WriteLiteral("\n");
#nullable restore
#line 48 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\PoslatiIzazovi\ListaIzazovi.cshtml"
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
