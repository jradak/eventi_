#pragma checksum "C:\Users\jopy_\OneDrive\Desktop\Eventi_PMA\EventiWebApp\EventiWebApp\Views\Home\Eventi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a15e5b0e61e9529d31b0ed6982422b33674dbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Eventi), @"mvc.1.0.view", @"/Views/Home/Eventi.cshtml")]
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
#line 1 "C:\Users\jopy_\OneDrive\Desktop\Eventi_PMA\EventiWebApp\EventiWebApp\Views\_ViewImports.cshtml"
using EventiWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jopy_\OneDrive\Desktop\Eventi_PMA\EventiWebApp\EventiWebApp\Views\_ViewImports.cshtml"
using EventiWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a15e5b0e61e9529d31b0ed6982422b33674dbc", @"/Views/Home/Eventi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba2c780577e12b7ece9d61237c7539af65388d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Eventi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""table-responsive-sm"">
        <table class=""table-light table-hover table-responsive-md col-md-12 flex-md-grow-1"">
            <thead>
            <th>Naziv</th>
            <th>Vrijeme</th>
            <th>Mjesto</th>
            <th>Adresa</th>
            <th>Cijena</th>
            <th>Vrsta Eventa</th>
            <th>Ograniceni Posjetitelji</th>
            <th>Organizator</th>
            </thead>
            <tbody id=""tbody"">
                <tr>
                    <td>Naziv</td>
                    <td>Vrijeme</td>
                    <td>Mjesto</td>
                    <td>Adresa</td>
                    <td>Cijena</td>
                    <td>Vrsta Eventa</td>
                    <td>OgraniceniPosjetitelji</td>
                    <td>Organizator</td>
                </tr>
            </tbody>
        </table>
    </div>");
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
