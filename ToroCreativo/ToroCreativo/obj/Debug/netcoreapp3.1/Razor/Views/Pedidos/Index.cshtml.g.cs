#pragma checksum "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a2c623aa13160612c73c67eb23a8fdb4268dbed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Index), @"mvc.1.0.view", @"/Views/Pedidos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2c623aa13160612c73c67eb23a8fdb4268dbed", @"/Views/Pedidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToroCreativo.Models.Entities.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/pedidos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearEditar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pedidos.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
      
    ViewData["Title"] = "Index";
    

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a2c623aa13160612c73c67eb23a8fdb4268dbed5587", async() => {
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
                WriteLiteral("\r\n    ");
            }
            );
            WriteLiteral(@"
    <div class=""titulo"">
        <h1>Sistema Administrativo <span>Pedidos</span> </h1>
    </div>

    <nav class=""nav-registros"">
        <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
            <a class=""nav-item nav-link active"" id=""primer-nav-tab"" data-toggle=""tab"" href=""#primer-nav"" role=""tab""
                aria-controls=""primer-nav"" aria-selected=""true"">Aceptados <i class=""fas fa-circle text-success""></i></a>
            <a class=""nav-item nav-link"" id=""segundo-nav-tab"" data-toggle=""tab"" href=""#segundo-nav"" role=""tab""
                aria-controls=""segundo-nav"" aria-selected=""false"">Pendientes <i
                    class=""fas fa-circle text-warning""></i></a>
            <a class=""nav-item nav-link"" id=""tercer-nav-tab"" data-toggle=""tab"" href=""#tercer-nav"" role=""tab""
                aria-controls=""tercer-nav"" aria-selected=""false"">Cancelar <i class=""fas fa-circle text-danger""></i></a>
        </div>
    </nav>

    <div class=""gestion"">
        <div class=""tab-content"" id=""");
            WriteLiteral(@"nav-tabContent"">

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
                        <tbody>
");
#nullable restore
#line 48 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                             foreach (var item in ViewBag.Aceptados)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 51 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.FechaPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 53 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                            Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 57 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                     if (item.ImageName == null)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-danger\">No</p>\r\n");
#nullable restore
#line 61 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-success\">Si</p>\r\n");
#nullable restore
#line 65 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 67 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <button");
            BeginWriteAttribute("onclick", "\r\n                                        onclick=\"", 3171, "\"", 3291, 13);
            WriteAttributeValue("", 3222, "PedidoPagado(", 3222, 13, true);
#nullable restore
#line 70 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 3235, item.IdPedido, 3235, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3249, ",", 3249, 1, true);
            WriteAttributeValue(" ", 3250, "\'", 3251, 2, true);
#nullable restore
#line 70 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 3252, item.Nombre, 3252, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3264, "\'", 3264, 1, true);
            WriteAttributeValue(" ", 3265, "+", 3266, 2, true);
            WriteAttributeValue(" ", 3267, "\'", 3268, 2, true);
            WriteAttributeValue(" ", 3269, "\'", 3270, 2, true);
            WriteAttributeValue(" ", 3271, "+", 3272, 2, true);
            WriteAttributeValue(" ", 3273, "\'", 3274, 2, true);
#nullable restore
#line 70 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 3275, item.Apellido, 3275, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3289, "\')", 3289, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                        class=\"btn btn-outline-success\">Pagado</button>\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2c623aa13160612c73c67eb23a8fdb4268dbed14059", async() => {
                WriteLiteral("<i class=\"fas fa-search-plus\"\r\n                                            title=\"detalle registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
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
#line 78 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
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
#line 90 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.FechaPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 91 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>Nombre Cliente</th>\r\n                                <th>");
#nullable restore
#line 93 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 94 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 95 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2c623aa13160612c73c67eb23a8fdb4268dbed18792", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            WriteLiteral("</th>\r\n                                <th></th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 102 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 105 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FechaPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 106 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 107 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 107 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem =>
                                    item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 109 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 110 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 111 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <i");
            BeginWriteAttribute("onclick", " onclick=\"", 5814, "\"", 5894, 13);
            WriteAttributeValue("", 5824, "AceptarPedido(", 5824, 14, true);
#nullable restore
#line 113 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 5838, item.IdPedido, 5838, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5852, ",", 5852, 1, true);
            WriteAttributeValue(" ", 5853, "\'", 5854, 2, true);
#nullable restore
#line 113 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 5855, item.Nombre, 5855, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5867, "\'", 5867, 1, true);
            WriteAttributeValue(" ", 5868, "+", 5869, 2, true);
            WriteAttributeValue(" ", 5870, "\'", 5871, 2, true);
            WriteAttributeValue(" ", 5872, "\'", 5873, 2, true);
            WriteAttributeValue(" ", 5874, "+", 5875, 2, true);
            WriteAttributeValue(" ", 5876, "\'", 5877, 2, true);
#nullable restore
#line 113 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 5878, item.Apellido, 5878, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5892, "\')", 5892, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                        class=\"fas fa-check-circle text-success\" title=\"Cambiar\"></i>\r\n                                </td>\r\n                                <td>\r\n                                    <i");
            BeginWriteAttribute("onclick", " onclick=\"", 6115, "\"", 6196, 13);
            WriteAttributeValue("", 6125, "CancelarPedido(", 6125, 15, true);
#nullable restore
#line 117 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 6140, item.IdPedido, 6140, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6154, ",", 6154, 1, true);
            WriteAttributeValue(" ", 6155, "\'", 6156, 2, true);
#nullable restore
#line 117 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 6157, item.Nombre, 6157, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6169, "\'", 6169, 1, true);
            WriteAttributeValue(" ", 6170, "+", 6171, 2, true);
            WriteAttributeValue(" ", 6172, "\'", 6173, 2, true);
            WriteAttributeValue(" ", 6174, "\'", 6175, 2, true);
            WriteAttributeValue(" ", 6176, "+", 6177, 2, true);
            WriteAttributeValue(" ", 6178, "\'", 6179, 2, true);
#nullable restore
#line 117 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 6180, item.Apellido, 6180, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6194, "\')", 6194, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                        class=\"fas fa-times-circle text-danger\" title=\"Cambiar\"></i>\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2c623aa13160612c73c67eb23a8fdb4268dbed26355", async() => {
                WriteLiteral("<i class=\"fas fa-search-plus\"\r\n                                            title=\"detalle registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
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
#line 125 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
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
#line 148 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                             foreach (var item in ViewBag.Cancelados)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 151 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.FechaPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 152 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 153 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 153 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                            Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 154 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 155 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>");
#nullable restore
#line 157 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2c623aa13160612c73c67eb23a8fdb4268dbed32253", async() => {
                WriteLiteral("<i class=\"fas fa-search-plus\"\r\n                                            title=\"detalle registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 160 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
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
#line 164 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a2c623aa13160612c73c67eb23a8fdb4268dbed35089", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>   \r\n\r\n");
#nullable restore
#line 177 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
         if(TempData["CambiarPedido"] != null && TempData["CambiarPedido"].ToString().Equals("si")) {
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                Swal.fire({
                    icon: 'success',
                    title: 'Se ha cambiado el estado del pedido',
                    html: 'Se le enviará una notificación de la acción del pedido seleccionado a su dueño'
                });

            ");
#nullable restore
#line 186 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 189 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
         if(TempData["Comprobante"] != null && TempData["Comprobante"].ToString().Equals("no")) {
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                Swal.fire({
                    icon: 'error',
                    title: 'El pedido no puede pasar a una venta',
                    html: 'El pedido seleccionado no posee un comprobante de pago, por favor espere a que el cliente suba el comprobante o en su defecto podrá realizar esta acción por su cuenta'
                });

            ");
#nullable restore
#line 198 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </script>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToroCreativo.Models.Entities.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
