#pragma checksum "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f063aa7edf1b23c6ceb38df0b92c986584859381"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InicioAdmin_Index), @"mvc.1.0.view", @"/Views/InicioAdmin/Index.cshtml")]
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
#line 1 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\_ViewImports.cshtml"
using ToroCreativo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\_ViewImports.cshtml"
using ToroCreativo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f063aa7edf1b23c6ceb38df0b92c986584859381", @"/Views/InicioAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_InicioAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/inicio_admin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
  
    ViewData["Title"] = "- Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f063aa7edf1b23c6ceb38df0b92c9865848593814028", async() => {
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
            WriteLiteral("\r\n<div class=\"titulo\">\r\n    <h1>Sistema Administrativo <span>Inicio</span> </h1>\r\n</div>\r\n\r\n<div class=\"datos-registros\">\r\n    <div class=\"registro\">\r\n        <div class=\"dato\">\r\n            <h2>");
#nullable restore
#line 13 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
           Write(TempData["Usuarios"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <span>Usuarios</span>\r\n        </div>\r\n        <div class=\"icono\">\r\n            <i class=\"fas fa-users\"></i>\r\n        </div>\r\n    </div>\r\n    <div class=\"registro\">\r\n        <div class=\"dato\">\r\n            <h2>");
#nullable restore
#line 22 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
           Write(TempData["Productos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <span>Productos</span>\r\n        </div>\r\n        <div class=\"icono\">\r\n            <i class=\"fas fa-gifts\"></i>\r\n        </div>\r\n    </div>\r\n    <div class=\"registro\">\r\n        <div class=\"dato\">\r\n            <h2>");
#nullable restore
#line 31 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
           Write(TempData["Ilustraciones"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <span>Ilustraciones</span>\r\n        </div>\r\n        <div class=\"icono\">\r\n            <i class=\"fas fa-palette\"></i>\r\n        </div>\r\n    </div>\r\n    <div class=\"registro\">\r\n        <div class=\"dato\">\r\n            <h2>");
#nullable restore
#line 40 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
           Write(TempData["Pedidos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <span>Pedidos</span>\r\n        </div>\r\n        <div class=\"icono\">\r\n            <i class=\"fas fa-mail-bulk\"></i>\r\n        </div>\r\n    </div>\r\n    <div class=\"registro\">\r\n        <div class=\"dato\">\r\n            <h2>");
#nullable restore
#line 49 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
           Write(TempData["Ventas"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            <span>Ventas</span>
        </div>
        <div class=""icono"">
            <i class=""fas fa-coins""></i>
        </div>
    </div>

</div>
<div class=""informes"">
    <div class=""informe-barras"">
        <h3>Diagrama de barras</h3>
        <div class=""barras"">
            <canvas id=""barras"" width=""50"" height=""15""></canvas>
        </div>
    </div>
    <div class=""informe-circular"">
        <div class=""circulo"">
            <canvas id=""circulo"" width=""20"" height=""20""></canvas>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.js""
            integrity=""sha512-hZf9Qhp3rlDJBvAKvmiG+goaaKRZA6LKUO35oK6EsM0/kjPK32Yw7URqrq3Q+Nvbbt8Usss+IekL7CRn83dYmw==""
            crossorigin=""anonymous""></script>

    <script>

        backgrounds = ['rgb(178, 190, 195, 0.5)', 'rgb(108, 92, 231, 0.5)', 'rgb(230, 103, 103, 0.5)', 'rgb(9, 132, 227, 0.5)', 'rgb(0, 184, 148, 0.5)'];
        borders = ['rgb(178, 190, 195)', 'rgb(108, 92, 231)', 'rgb(230, 103, 103)', 'rgb(9, 132, 227)', 'rgb(0, 184, 148)'];
        //Grafica de barras
        var informe_barras = new Chart(barras, {
            type: 'horizontalBar',
            data: {
                labels: ['Usuarios', 'Productos', 'Ilustraciones', 'Pedidos', 'Ventas'],
                datasets: [{
                    label: 'Cantidad',
                    data: [");
#nullable restore
#line 89 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
                      Write(TempData["Usuarios"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 89 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
                                             Write(TempData["Productos"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 89 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
                                                                     Write(TempData["Ilustraciones"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 89 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
                                                                                                 Write(TempData["Pedidos"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 89 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
                                                                                                                       Write(TempData["Ventas"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                    backgroundColor: ['rgb(178, 190, 195, 0.5)', 'rgb(108, 92, 231, 0.5)', 'rgb(230, 103, 103, 0.5)', 'rgb(9, 132, 227, 0.5)', 'rgb(0, 184, 148, 0.5)'],
                    borderColor: ['rgb(178, 190, 195)', 'rgb(108, 92, 231)', 'rgb(230, 103, 103)', 'rgb(9, 132, 227)', 'rgb(0, 184, 148)'],
                    borderWidth: 1,

                }]
            },

            options: {
                legend: {
                    display: false
                },
                scales: {
                    xAxes: [{
                        ticks: {
                            beginAtZero: true
                        }
                    }]
                },
                responsive: true,
                plugins: {
                    title: {
                        display: true,
                        text: 'Diagrama circular'
                    },
                }
            }
        });


        var informe_circulo = new Chart(circulo, {
    ");
                WriteLiteral("        type: \'pie\',\r\n            data: {\r\n                labels: [\'Usuarios\', \'Productos\', \'Ilustraciones\', \'Pedidos\', \'Ventas\'],\r\n                datasets: [{\r\n                    label: \'Cantidad de pedidos\',\r\n                    data: [");
#nullable restore
#line 125 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
                      Write(TempData["Usuarios"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 125 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
                                             Write(TempData["Productos"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 125 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
                                                                     Write(TempData["Ilustraciones"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 125 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
                                                                                                 Write(TempData["Pedidos"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 125 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\InicioAdmin\Index.cshtml"
                                                                                                                       Write(TempData["Ventas"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],
                    backgroundColor: ['rgb(178, 190, 195, 0.5)', 'rgb(108, 92, 231, 0.5)', 'rgb(230, 103, 103, 0.5)', 'rgb(9, 132, 227, 0.5)', 'rgb(0, 184, 148, 0.5)'],
                    borderColor: ['rgb(178, 190, 195)', 'rgb(108, 92, 231)', 'rgb(230, 103, 103)', 'rgb(9, 132, 227)', 'rgb(0, 184, 148)'],
                    borderWidth: 1,
                    barPercentage: .3,
                }]
            },
            options: {
                title: {
                    display: true,
                    text: 'Diagrama circular'
                },
            }

        });
    </script>
    


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
