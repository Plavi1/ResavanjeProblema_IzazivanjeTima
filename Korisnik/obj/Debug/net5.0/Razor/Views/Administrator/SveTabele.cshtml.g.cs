#pragma checksum "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563e81000c4340938c8cbf6fccb1cce070da6cd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_SveTabele), @"mvc.1.0.view", @"/Views/Administrator/SveTabele.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
using Korisnik.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563e81000c4340938c8cbf6fccb1cce070da6cd5", @"/Views/Administrator/SveTabele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b6270fe95601dbd52a618c1efb6b14f01aed62", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_SveTabele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SveTabele_ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ObrisiIzazov", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ObrisiPrihvacen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
   ViewData["Title"] = "SveTabele";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
   int i = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista  Korisnika</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
 if (Model.ApplicationKorisnik.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-dark"">

        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Ime</th>
                <th scope=""col"">Prezime</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 23 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
             foreach (var list in Model.ApplicationKorisnik)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"w-15\">");
#nullable restore
#line 26 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                                Write(Convert.ToString(i++));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"w-15\">");
#nullable restore
#line 27 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                                Write(list.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"w-15\">");
#nullable restore
#line 28 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                                Write(list.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"w-50\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e81000c4340938c8cbf6fccb1cce070da6cd59519", async() => {
                WriteLiteral("\r\n\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e81000c4340938c8cbf6fccb1cce070da6cd59809", async() => {
                    WriteLiteral("Promeni");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                                 WriteLiteral(list.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            <span");
                BeginWriteAttribute("id", " id=\"", 1152, "\"", 1183, 2);
                WriteAttributeValue("", 1157, "confirmDeleteSpan_", 1157, 18, true);
#nullable restore
#line 35 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
WriteAttributeValue("", 1175, list.Id, 1175, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""display:none"">
                                <span>Da li si siguran da zelis da obrises?</span>
                                <button type=""submit"" class=""btn btn-danger"">Da</button>
                                <a href=""#"" class=""btn btn-primary""");
                BeginWriteAttribute("onclick", "\r\n                                   onclick=\"", 1449, "\"", 1527, 4);
                WriteAttributeValue("", 1495, "confirmDelete(\'", 1495, 15, true);
#nullable restore
#line 39 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
WriteAttributeValue("", 1510, list.Id, 1510, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1518, "\',", 1518, 2, true);
                WriteAttributeValue(" ", 1520, "false)", 1521, 7, true);
                EndWriteAttribute();
                WriteLiteral(">Ne</a>\r\n                            </span>\r\n\r\n                            <span");
                BeginWriteAttribute("id", " id=\"", 1609, "\"", 1633, 2);
                WriteAttributeValue("", 1614, "deleteSpan_", 1614, 11, true);
#nullable restore
#line 42 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
WriteAttributeValue("", 1625, list.Id, 1625, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <a href=\"#\" class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", "\r\n                                   onclick=\"", 1703, "\"", 1780, 4);
                WriteAttributeValue("", 1749, "confirmDelete(\'", 1749, 15, true);
#nullable restore
#line 44 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
WriteAttributeValue("", 1764, list.Id, 1764, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1772, "\',", 1772, 2, true);
                WriteAttributeValue(" ", 1774, "true)", 1775, 6, true);
                EndWriteAttribute();
                WriteLiteral(">Obrisi</a>\r\n                            </span>\r\n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                                                                      WriteLiteral(list.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 53 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card text-white bg-secondary mb-3\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">TRENUTNO NEMA <b style=\"color:red\"> REGISTROVANIH KORISNIKA </b>  </h4>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista  Izazova</h1>\r\n\r\n");
#nullable restore
#line 66 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
 if (Model.Izazovi.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e81000c4340938c8cbf6fccb1cce070da6cd519270", async() => {
                WriteLiteral(@"
        <table class=""table table-dark"">

            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Izazivaoc</th>
                    <th scope=""col"">Izazvani</th>
                    <th>Zakazano Mesto</th>
                    <th>Zakazano Vreme i Datum</th>
                    <th>Vreme Slanja</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 83 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                 foreach (var lista in Model.Izazovi)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 86 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                   Write(lista.IdIzazova);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 87 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                   Write(lista.ImeIzazivaoca);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 88 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                   Write(lista.ImeIzazvanog);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 89 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                   Write(lista.Mesto);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 90 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                   Write(lista.ZakazanoVreme);

#line default
#line hidden
#nullable disable
                WriteLiteral("  ");
#nullable restore
#line 90 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                                         Write(lista.ZakazanDatum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 91 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                   Write(lista.VremePoslatogIzazova);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e81000c4340938c8cbf6fccb1cce070da6cd522763", async() => {
                    WriteLiteral(" Obrisi");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                                                                                                             WriteLiteral(lista.IdIzazova);

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
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 96 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 101 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card text-white bg-secondary mb-3\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">TRENUTNO NEMA <b style=\"color:red\"> IZAZOVA U PROCESU</b>  </h4>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 109 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista  Prihvacenih izazova</h1>\r\n\r\n");
#nullable restore
#line 113 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
 if (Model.PrihvaceniIzazovi.Any())
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-dark"">

        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Izazivaoc</th>
                <th scope=""col"">Izazvani</th>
                <th scope=""col"">Zakazano Mesto</th>
                <th scope=""col"">Zakazano Vreme i Datum</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 129 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
             foreach (var lista in Model.PrihvaceniIzazovi)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 132 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
               Write(lista.IdIzazova);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 133 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
               Write(lista.ImeIzazivaoca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 134 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
               Write(lista.ImeIzazvanog);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 135 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
               Write(lista.Mesto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 136 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
               Write(lista.ZakazanoVreme);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 136 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                                     Write(lista.ZakazanDatum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e81000c4340938c8cbf6fccb1cce070da6cd530849", async() => {
                WriteLiteral(" Obrisi");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
                                                                                                            WriteLiteral(lista.IdIzazova);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 141 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 145 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card text-white bg-secondary mb-3\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">TRENUTNO NEMA <b style=\"color:red\"> PRIHVACENIH IZAZOVA </b>  </h4>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 154 "C:\Users\pc\Desktop\ASP.NET Core MVC VEZBA\1.ZADATAK\ResavanjeProblema_IzazivanjeTima-master\Korisnik\Views\Administrator\SveTabele.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "563e81000c4340938c8cbf6fccb1cce070da6cd534640", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SveTabele_ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
