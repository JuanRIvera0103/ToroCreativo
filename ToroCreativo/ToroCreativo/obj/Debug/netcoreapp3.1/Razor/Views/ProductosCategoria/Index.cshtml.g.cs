#pragma checksum "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f05f20ec8c39ce81ab16afdfe4572aef9f91e32f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductosCategoria_Index), @"mvc.1.0.view", @"/Views/ProductosCategoria/Index.cshtml")]
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
#line 1 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\_ViewImports.cshtml"
using ToroCreativo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\_ViewImports.cshtml"
using ToroCreativo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05f20ec8c39ce81ab16afdfe4572aef9f91e32f", @"/Views/ProductosCategoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductosCategoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToroCreativo.Clases.ProductoDetalle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearEditarProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalleProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearEditarCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalleCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""titulo"">
    <h1>Sistema Administrativo <span>Productos</span> </h1>
</div>

<nav>
    <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
        <a class=""nav-item nav-link active"" id=""primer-nav-tab"" data-toggle=""tab"" href=""#primer-nav"" role=""tab""
           aria-controls=""primer-nav"" aria-selected=""true"">Productos</a>
        <a class=""nav-item nav-link"" id=""segundo-nav-tab"" data-toggle=""tab"" href=""#segundo-nav"" role=""tab""
           aria-controls=""segundo-nav"" aria-selected=""false"">Categorías</a>
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
                            <th>
                                ");
#nullable restore
#line 32 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 35 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 38 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("                               \r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 41 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05f20ec8c39ce81ab16afdfe4572aef9f91e32f7458", async() => {
                WriteLiteral("<i class=\"fas fa-plus\" title=\"Agregar registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 55 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 61 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   \r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 64 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                     if (item.Estado.Equals("Habilitado"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-success\">");
#nullable restore
#line 66 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 67 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-danger\">");
#nullable restore
#line 70 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 71 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 74 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                     if (item.Estado.Equals("Habilitado"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i");
            BeginWriteAttribute("onclick", " onclick=\"", 3420, "\"", 3488, 6);
            WriteAttributeValue("", 3430, "CambiarEstadoProductos(", 3430, 23, true);
#nullable restore
#line 76 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 3453, item.idProductos, 3453, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3470, ",", 3471, 2, true);
            WriteAttributeValue(" ", 3472, "\'", 3473, 2, true);
#nullable restore
#line 76 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 3474, item.Nombre, 3474, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3486, "\')", 3486, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-check-circle text-success\" title=\"Cambiar\"></i>\r\n");
#nullable restore
#line 77 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i");
            BeginWriteAttribute("onclick", " onclick=\"", 3715, "\"", 3783, 6);
            WriteAttributeValue("", 3725, "CambiarEstadoProductos(", 3725, 23, true);
#nullable restore
#line 80 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 3748, item.idProductos, 3748, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3765, ",", 3766, 2, true);
            WriteAttributeValue(" ", 3767, "\'", 3768, 2, true);
#nullable restore
#line 80 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 3769, item.Nombre, 3769, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3781, "\')", 3781, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-times-circle text-danger\" title=\"Cambiar\"></i>                                        \r\n");
#nullable restore
#line 81 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05f20ec8c39ce81ab16afdfe4572aef9f91e32f15563", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-edit\" title=\"Editar registro\"></i>\r\n                                    ");
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
#line 86 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                                          WriteLiteral(item.idProductos);

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
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05f20ec8c39ce81ab16afdfe4572aef9f91e32f18034", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-search-plus\" title=\"detalle registro\"></i>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                                      WriteLiteral(item.idProductos);

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
#line 96 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
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
                            <th>Nombre</th>
                            <th>Estado</th>
                            <th>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05f20ec8c39ce81ab16afdfe4572aef9f91e32f21290", async() => {
                WriteLiteral("<i class=\"fas fa-plus\" title=\"Agregar registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 118 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                         foreach (var categorias in ViewBag.Categorias)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 122 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                               Write(categorias.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 125 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                     if (categorias.Estado.Equals("Habilitado"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-success\">");
#nullable restore
#line 127 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                           Write(categorias.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 128 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-danger\">");
#nullable restore
#line 131 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                          Write(categorias.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 132 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 136 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                     if (categorias.Estado.Equals("Habilitado"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i");
            BeginWriteAttribute("onclick", " onclick=\"", 6532, "\"", 6611, 6);
            WriteAttributeValue("", 6542, "CambiarEstadoCategoria(", 6542, 23, true);
#nullable restore
#line 138 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 6565, categorias.idCategoria, 6565, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6588, ",", 6588, 1, true);
            WriteAttributeValue(" ", 6589, "\'", 6590, 2, true);
#nullable restore
#line 138 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 6591, categorias.Nombre, 6591, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6609, "\')", 6609, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-check-circle text-success\" title=\"Cambiar\"></i>\r\n");
#nullable restore
#line 139 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i");
            BeginWriteAttribute("onclick", " onclick=\"", 6838, "\"", 6917, 6);
            WriteAttributeValue("", 6848, "CambiarEstadoCategoria(", 6848, 23, true);
#nullable restore
#line 142 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 6871, categorias.idCategoria, 6871, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6894, ",", 6894, 1, true);
            WriteAttributeValue(" ", 6895, "\'", 6896, 2, true);
#nullable restore
#line 142 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 6897, categorias.Nombre, 6897, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6915, "\')", 6915, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-times-circle text-danger\" title=\"Cambiar\"></i>\r\n");
#nullable restore
#line 143 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05f20ec8c39ce81ab16afdfe4572aef9f91e32f28469", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-edit\" title=\"Editar registro\"></i>\r\n                                    ");
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
#line 147 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                                           WriteLiteral(categorias.idCategoria);

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
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05f20ec8c39ce81ab16afdfe4572aef9f91e32f30948", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-search-plus\" title=\"detalle registro\"></i>\r\n                                    ");
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
            WriteLiteral(" ");
#nullable restore
#line 152 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                                        WriteLiteral(categorias.idCategoria);

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
#line 157 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>                              \r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n");
#nullable restore
#line 172 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
         if (TempData["Cambiar"] != null && TempData["Cambiar"].ToString().Equals("no"))
        {
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            Swal.fire({
                icon: 'error',
                title: 'No se puede cambiar el estado',
                html: 'La categoría seleccionada cuenta con productos habilitados, si desea realizar esta acción deberá deshabilitar todos los productos asociados a esta categoría'
            });

            ");
#nullable restore
#line 182 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 186 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
         if(TempData["Editar"] != null && TempData["Editar"].ToString().Equals("no")) {
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                Swal.fire({
                    icon: 'error',
                    title: 'No se puede editar el registro',
                    html: 'La categoría seleccionada cuenta con productos habilitados, si desea realizar esta acción deberá deshabilitar todos los productos asociados a esta categoría'
                  });

                 ");
#nullable restore
#line 195 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                        
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 200 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
         if (TempData["CambiarProducto"] != null && TempData["CambiarProducto"].ToString().Equals("no"))
        {
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            Swal.fire({
                icon: 'error',
                title: 'No se puede cambiar el estado',
                html: 'El producto seleccionado cuenta con pedidos en proceso, deberá de solucionar el estado de los pedidos con ese producto para poder realizar esta acción'
            });

            ");
#nullable restore
#line 210 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToroCreativo.Clases.ProductoDetalle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
