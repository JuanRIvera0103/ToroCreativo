#pragma checksum "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e8ba4cae6c268348a137bf3ab67f2195b1914e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_PedidosClientes), @"mvc.1.0.view", @"/Views/Pedidos/PedidosClientes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e8ba4cae6c268348a137bf3ab67f2195b1914e", @"/Views/Pedidos/PedidosClientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_PedidosClientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToroCreativo.Models.Entities.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PedidoAVenta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearEditar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AceptarPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelarPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<article>
    <div class=""container"">
        <div class=""titulo"">
            <h1>Sistema Administrativo <span>Pedidos</span> </h1>
        </div>

        <nav>
            <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                <a class=""nav-item nav-link active"" id=""primer-nav-tab"" data-toggle=""tab"" href=""#primer-nav"" role=""tab""
                   aria-controls=""primer-nav"" aria-selected=""true"">Aceptados <i class=""fas fa-circle text-success""></i></a>
                <a class=""nav-item nav-link"" id=""segundo-nav-tab"" data-toggle=""tab"" href=""#segundo-nav"" role=""tab""
                   aria-controls=""segundo-nav"" aria-selected=""false"">Pendientes <i class=""fas fa-circle text-warning""></i></a>
                <a class=""nav-item nav-link"" id=""tercer-nav-tab"" data-toggle=""tab"" href=""#tercer-nav"" role=""tab""
                   aria-controls=""tercer-nav"" aria-selected=""false"">Cancelar <i class=""fas fa-circle text-danger""></i></a>
            </div>
        </nav>

        <div class");
            WriteLiteral(@"=""gestion"">
            <div class=""tab-content"" id=""nav-tabContent"">

                <!-- Contenido primer nav -->
                <div class=""tab-pane fade show active"" id=""primer-nav"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">

                    <div class=""registros"">
                        <table id=""tabla"" class=""table table-hover "">
                            <thead>
                                <tr>
                                    <th>Fecha</th>
                                    <th>Cédula</th>
                                    <th>Nombre Cliente</th>
                                    <th>Dirección</th>
                                    <th>Teléfono</th>
                                    <th>Comprobante</th>
                                    <th>Estado</th>
                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tb");
            WriteLiteral("ody>\r\n");
#nullable restore
#line 46 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                 foreach (var item in ViewBag.Aceptados)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 49 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.FechaPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 50 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 51 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                                    Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 52 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 53 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 55 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                             if (item.ImageName == null)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"text-danger\">No</p>\r\n");
#nullable restore
#line 59 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"text-success\">Si</p>\r\n");
#nullable restore
#line 63 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>");
#nullable restore
#line 65 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e8ba4cae6c268348a137bf3ab67f2195b1914e11917", async() => {
                WriteLiteral("Pagado");
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
#line 66 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                                                           WriteLiteral(item.IdPedido);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e8ba4cae6c268348a137bf3ab67f2195b1914e14380", async() => {
                WriteLiteral("<i class=\"fas fa-search-plus\" title=\"detalle registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
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
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 71 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>

                <!-- Contenido segundo nav -->
                <div class=""tab-pane fade show"" id=""segundo-nav"" role=""tabpanel"" aria-labelledby=""nav-profile-tab"">
                    <div class=""registros"">
                        <table id=""tabla2"" class=""table table-hover "">
                            <thead>
                                <tr>
                                    <th>");
#nullable restore
#line 83 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FechaPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 84 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>Nombre Cliente</th>\r\n                                    <th>");
#nullable restore
#line 86 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 87 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 88 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e8ba4cae6c268348a137bf3ab67f2195b1914e19252", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                                    <th></th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 95 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 98 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.FechaPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 99 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 100 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 100 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                                                                  Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 101 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 102 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 103 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e8ba4cae6c268348a137bf3ab67f2195b1914e23579", async() => {
                WriteLiteral("\r\n                                                <i class=\"fas fa-check-circle text-success\"\r\n                                                   title=\"Activar registro\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
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
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e8ba4cae6c268348a137bf3ab67f2195b1914e26147", async() => {
                WriteLiteral("\r\n                                                <i class=\"fas fa-times-circle text-danger\"\r\n                                                   title=\"Desactivar registro\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
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
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e8ba4cae6c268348a137bf3ab67f2195b1914e28718", async() => {
                WriteLiteral("<i class=\"fas fa-search-plus\" title=\"detalle registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
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
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 120 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>

                <!-- Contenido tercer nav -->
                <div class=""tab-pane fade show"" id=""tercer-nav"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">

                    <div class=""registros"">
                        <table id=""tabla3"" class=""table table-hover "">
                            <thead>
                                <tr>
                                    <th>Fecha</th>
                                    <th>Cédula</th>
                                    <th>Nombre Cliente</th>
                                    <th>Dirección</th>
                                    <th>Teléfono</th>
                                    <th>Estado</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 143 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                 foreach (var item in ViewBag.Cancelados)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 146 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.FechaPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 147 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 148 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 148 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                                    Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 149 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 150 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>");
#nullable restore
#line 152 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                       Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e8ba4cae6c268348a137bf3ab67f2195b1914e34913", async() => {
                WriteLiteral("<i class=\"fas fa-search-plus\" title=\"detalle registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 155 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
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
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 158 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\PedidosClientes.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</article>\r\n");
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
