#pragma checksum "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fd1e2c87fbd56e2d131a391df8c93162a3eb2b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_VentaIndex), @"mvc.1.0.view", @"/Views/Pedidos/VentaIndex.cshtml")]
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
#line 1 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\_ViewImports.cshtml"
using ToroCreativo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\_ViewImports.cshtml"
using ToroCreativo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd1e2c87fbd56e2d131a391df8c93162a3eb2b1", @"/Views/Pedidos/VentaIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_VentaIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToroCreativo.Models.Entities.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
  
    ViewData["Title"] = "VentaIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""titulo"">
    <h1>Sistema Administrativo <span>Ventas</span> </h1>
</div>

<nav>
    <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
        <a class=""nav-item nav-link active"" id=""primer-nav-tab"" data-toggle=""tab"" href=""#primer-nav"" role=""tab""
           aria-controls=""primer-nav"" aria-selected=""true"">Ventas por enviar</a>
        <a class=""nav-item nav-link"" id=""segundo-nav-tab"" data-toggle=""tab"" href=""#segundo-nav"" role=""tab""
           aria-controls=""segundo-nav"" aria-selected=""false"">Ventas enviadas</a>
    </div>
</nav>

<div class=""gestion"">
    <div class=""tab-content"" id=""nav-tabContent"">

        <!-- Contenido primer nav -->
        <div class=""tab-pane fade show active"" id=""primer-nav"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">

            <div class=""registros"">
                <table id=""tabla"" class=""table table-hover "">
                    <thead>
                        <tr>
                            <th>Fecha</th>
                        ");
            WriteLiteral(@"    <th>Cédula</th>
                            <th>Nombre Cliente</th>
                            <th>Total</th>
                            <th>Estado</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 41 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                         foreach (var item in ViewBag.SinEnviados)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 44 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                               Write(item.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                               Write(item.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                                            Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                               Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                 <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1960, "\"", 2041, 13);
            WriteAttributeValue("", 1970, "CancelarPedido(", 1970, 15, true);
#nullable restore
#line 50 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
WriteAttributeValue("", 1985, item.IdPedido, 1985, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1999, ",", 1999, 1, true);
            WriteAttributeValue(" ", 2000, "\'", 2001, 2, true);
#nullable restore
#line 50 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
WriteAttributeValue("", 2002, item.Nombre, 2002, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2014, "\'", 2014, 1, true);
            WriteAttributeValue(" ", 2015, "+", 2016, 2, true);
            WriteAttributeValue(" ", 2017, "\'", 2018, 2, true);
            WriteAttributeValue(" ", 2019, "\'", 2020, 2, true);
            WriteAttributeValue(" ", 2021, "+", 2022, 2, true);
            WriteAttributeValue(" ", 2023, "\'", 2024, 2, true);
#nullable restore
#line 50 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
WriteAttributeValue("", 2025, item.Apellido, 2025, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2039, "\')", 2039, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Enviar</button>\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd1e2c87fbd56e2d131a391df8c93162a3eb2b18920", async() => {
                WriteLiteral("<i class=\"fas fa-search-plus\" title=\"detalle registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                                                              WriteLiteral(item.IdPedido);

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
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 56 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>                    
                </table>
            </div>
        </div>

        <!-- Contenido segundo nav -->
        <div class=""tab-pane fade show"" id=""segundo-nav"" role=""tabpanel"" aria-labelledby=""nav-profile-tab"">
            <div class=""registros"">
                <table id=""tabla2"" class=""table table-hover "">
                    <thead>
                        <tr>
                            <th>Fecha Venta</th>
                            <th>");
#nullable restore
#line 69 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                           Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 70 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 70 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                                                                       Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 71 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 72 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th></th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 78 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 81 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FechaVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 82 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 83 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 83 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 84 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 85 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd1e2c87fbd56e2d131a391df8c93162a3eb2b116072", async() => {
                WriteLiteral("<i class=\"fas fa-search-plus\" title=\"detalle registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                                                              WriteLiteral(item.IdPedido);

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
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 92 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        function EnviarVenta(id, nombre) {
            Swal.fire({
                title: '¿Estás seguro de enviar la venta seleccionada de ' + nombre + '?',
                icon: 'warning',
                howCancelButton: true,
                confirmButtonColor: '#ff8c29db',
                confirmButtonText: 'Pagado'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = ""/Pedidos/VentaSinEnviarAVentaEnviada/"" + id;
                }
            });
        };


");
#nullable restore
#line 119 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
         if (TempData["Comprobante"] != null && TempData["Comprobante"].ToString().Equals("si"))
         {
            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            Swal.fire({\r\n                icon: \'error\',\r\n                title: \'Comprobante guardado con éxito\',\r\n            });\r\n\r\n            ");
#nullable restore
#line 128 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\VentaIndex.cshtml"
                   
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToroCreativo.Models.Entities.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
