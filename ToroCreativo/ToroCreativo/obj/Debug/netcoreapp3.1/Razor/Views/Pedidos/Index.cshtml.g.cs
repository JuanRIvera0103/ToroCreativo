#pragma checksum "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "291138f002d69fcdab92468fbda5490a80c4dad1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"291138f002d69fcdab92468fbda5490a80c4dad1", @"/Views/Pedidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToroCreativo.Models.Entities.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/pedidos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearEditar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
      
    ViewData["Title"] = "Index";
    

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "291138f002d69fcdab92468fbda5490a80c4dad15234", async() => {
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

    <nav>
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
        <div class=""tab-content"" id=""nav-tabContent"">

  ");
            WriteLiteral(@"          <!-- Contenido primer nav -->
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
#line 48 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                             foreach (var item in ViewBag.Aceptados)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 51 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.FechaPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 53 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                            Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 57 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                     if (item.ImageName == null)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-danger\">No</p>\r\n");
#nullable restore
#line 61 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-success\">Si</p>\r\n");
#nullable restore
#line 65 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 67 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <button");
            BeginWriteAttribute("onclick", "\r\n                                        onclick=\"", 3149, "\"", 3269, 13);
            WriteAttributeValue("", 3200, "PedidoPagado(", 3200, 13, true);
#nullable restore
#line 70 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 3213, item.IdPedido, 3213, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3227, ",", 3227, 1, true);
            WriteAttributeValue(" ", 3228, "\'", 3229, 2, true);
#nullable restore
#line 70 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 3230, item.Nombre, 3230, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3242, "\'", 3242, 1, true);
            WriteAttributeValue(" ", 3243, "+", 3244, 2, true);
            WriteAttributeValue(" ", 3245, "\'", 3246, 2, true);
            WriteAttributeValue(" ", 3247, "\'", 3248, 2, true);
            WriteAttributeValue(" ", 3249, "+", 3250, 2, true);
            WriteAttributeValue(" ", 3251, "\'", 3252, 2, true);
#nullable restore
#line 70 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 3253, item.Apellido, 3253, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3267, "\')", 3267, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                        class=\"btn btn-outline-success\">Pagado</button>\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291138f002d69fcdab92468fbda5490a80c4dad113682", async() => {
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
#line 74 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
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
#line 78 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
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
#line 90 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.FechaPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 91 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>Nombre Cliente</th>\r\n                                <th>");
#nullable restore
#line 93 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 94 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 95 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291138f002d69fcdab92468fbda5490a80c4dad118415", async() => {
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
#line 102 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 105 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FechaPedido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 106 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 107 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 107 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem =>
                                    item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 109 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 110 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 111 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <i");
            BeginWriteAttribute("onclick", " onclick=\"", 5792, "\"", 5872, 13);
            WriteAttributeValue("", 5802, "AceptarPedido(", 5802, 14, true);
#nullable restore
#line 113 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 5816, item.IdPedido, 5816, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5830, ",", 5830, 1, true);
            WriteAttributeValue(" ", 5831, "\'", 5832, 2, true);
#nullable restore
#line 113 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 5833, item.Nombre, 5833, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5845, "\'", 5845, 1, true);
            WriteAttributeValue(" ", 5846, "+", 5847, 2, true);
            WriteAttributeValue(" ", 5848, "\'", 5849, 2, true);
            WriteAttributeValue(" ", 5850, "\'", 5851, 2, true);
            WriteAttributeValue(" ", 5852, "+", 5853, 2, true);
            WriteAttributeValue(" ", 5854, "\'", 5855, 2, true);
#nullable restore
#line 113 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 5856, item.Apellido, 5856, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5870, "\')", 5870, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                        class=\"fas fa-check-circle text-success\" title=\"Cambiar\"></i>\r\n                                </td>\r\n                                <td>\r\n                                    <i");
            BeginWriteAttribute("onclick", " onclick=\"", 6093, "\"", 6174, 13);
            WriteAttributeValue("", 6103, "CancelarPedido(", 6103, 15, true);
#nullable restore
#line 117 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 6118, item.IdPedido, 6118, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6132, ",", 6132, 1, true);
            WriteAttributeValue(" ", 6133, "\'", 6134, 2, true);
#nullable restore
#line 117 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 6135, item.Nombre, 6135, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6147, "\'", 6147, 1, true);
            WriteAttributeValue(" ", 6148, "+", 6149, 2, true);
            WriteAttributeValue(" ", 6150, "\'", 6151, 2, true);
            WriteAttributeValue(" ", 6152, "\'", 6153, 2, true);
            WriteAttributeValue(" ", 6154, "+", 6155, 2, true);
            WriteAttributeValue(" ", 6156, "\'", 6157, 2, true);
#nullable restore
#line 117 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 6158, item.Apellido, 6158, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6172, "\')", 6172, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                        class=\"fas fa-times-circle text-danger\" title=\"Cambiar\"></i>\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291138f002d69fcdab92468fbda5490a80c4dad125978", async() => {
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
#line 121 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
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
#line 125 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
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
#line 148 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                             foreach (var item in ViewBag.Cancelados)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 151 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.FechaPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 152 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 153 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 153 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                                            Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 154 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 155 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>");
#nullable restore
#line 157 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291138f002d69fcdab92468fbda5490a80c4dad131876", async() => {
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
#line 160 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
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
#line 164 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function AceptarPedido(id, nombre) {
            Swal.fire({
                title: '¿Estás seguro de aceptar el pedido seleccionado de ' + nombre + '?',
                icon: 'warning',
                iconColor: '#0be881',
                showCancelButton: true,
                confirmButtonColor: '#0be881',
                confirmButtonText: 'Aceptar Pedido'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = ""/Pedidos/AceptarPedido/"" + id;
                }
            });
        };

        function CancelarPedido(id, nombre) {
            Swal.fire({
                title: '¿Estás seguro de cancelar el pedido seleccionado de ' + nombre + '?',
                icon: 'warning',
                iconColor: '#ff6b6b',
                showCancelButton: true,
                confirmButtonColor: '#ff6b6b',
                confirmButtonText: 'Cancelar Pedido'
            }).then((result) => {
      ");
                WriteLiteral(@"          if (result.isConfirmed) {
                    window.location.href = ""/Pedidos/CancelarPedido/"" + id;
                }
            });
        };

        function PedidoPagado(id, nombre) {
            Swal.fire({
                title: '¿Estás seguro de cambiar el estado del pedido seleccionado de ' + nombre + ' a pagado?',
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#ff8c29db',
                confirmButtonText: 'Pagado'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = ""/Pedidos/PedidoAVenta/"" + id;
                }
            });
        };

");
#nullable restore
#line 219 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
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
#line 228 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 231 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
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
#line 240 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Pedidos\Index.cshtml"
                   
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
