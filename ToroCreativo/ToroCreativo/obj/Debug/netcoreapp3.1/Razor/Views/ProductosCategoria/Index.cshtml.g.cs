#pragma checksum "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3f41586d82a8bdbff33dfb8cb16e9c3702c99ff"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3f41586d82a8bdbff33dfb8cb16e9c3702c99ff", @"/Views/ProductosCategoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductosCategoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToroCreativo.Clases.ProductoDetalle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearEditarCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalleCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearEditarProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalleProducto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
  
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
           aria-controls=""primer-nav"" aria-selected=""true"">Categorias</a>
        <a class=""nav-item nav-link"" id=""segundo-nav-tab"" data-toggle=""tab"" href=""#segundo-nav"" role=""tab""
           aria-controls=""segundo-nav"" aria-selected=""false"">Productos</a>
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
                            <th>Nombre</th>
                            <th>E");
            WriteLiteral("stado</th>\r\n                            <th>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f41586d82a8bdbff33dfb8cb16e9c3702c99ff5849", async() => {
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
#line 41 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                         foreach (var categorias in ViewBag.Categorias)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 45 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                               Write(categorias.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 48 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                     if (categorias.Estado.Equals("Habilitado"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-success\">");
#nullable restore
#line 50 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                           Write(categorias.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 51 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-danger\">");
#nullable restore
#line 54 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                          Write(categorias.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 55 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 59 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                     if (categorias.Estado.Equals("Habilitado"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i");
            BeginWriteAttribute("onclick", " onclick=\"", 2502, "\"", 2581, 6);
            WriteAttributeValue("", 2512, "CambiarEstadoCategoria(", 2512, 23, true);
#nullable restore
#line 61 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 2535, categorias.idCategoria, 2535, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2558, ",", 2558, 1, true);
            WriteAttributeValue(" ", 2559, "\'", 2560, 2, true);
#nullable restore
#line 61 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 2561, categorias.Nombre, 2561, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2579, "\')", 2579, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-check-circle text-success\" title=\"Cambiar\"></i>\r\n");
#nullable restore
#line 62 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i");
            BeginWriteAttribute("onclick", " onclick=\"", 2808, "\"", 2887, 6);
            WriteAttributeValue("", 2818, "CambiarEstadoCategoria(", 2818, 23, true);
#nullable restore
#line 65 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 2841, categorias.idCategoria, 2841, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2864, ",", 2864, 1, true);
            WriteAttributeValue(" ", 2865, "\'", 2866, 2, true);
#nullable restore
#line 65 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 2867, categorias.Nombre, 2867, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2885, "\')", 2885, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-times-circle text-danger\" title=\"Cambiar\"></i>\r\n");
#nullable restore
#line 66 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f41586d82a8bdbff33dfb8cb16e9c3702c99ff12761", async() => {
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
#line 70 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f41586d82a8bdbff33dfb8cb16e9c3702c99ff15221", async() => {
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
            WriteLiteral(" ");
#nullable restore
#line 75 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
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
#line 80 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
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
                            <th>
                                ");
#nullable restore
#line 93 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 96 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 99 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("                               \r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 102 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f41586d82a8bdbff33dfb8cb16e9c3702c99ff19982", async() => {
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
#line 112 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 116 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 119 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 122 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   \r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 125 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                     if (item.Estado.Equals("Habilitado"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-success\">");
#nullable restore
#line 127 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 128 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-danger\">");
#nullable restore
#line 131 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 132 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 135 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                     if (item.Estado.Equals("Habilitado"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i");
            BeginWriteAttribute("onclick", " onclick=\"", 6527, "\"", 6595, 6);
            WriteAttributeValue("", 6537, "CambiarEstadoProductos(", 6537, 23, true);
#nullable restore
#line 137 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 6560, item.idProductos, 6560, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6577, ",", 6578, 2, true);
            WriteAttributeValue(" ", 6579, "\'", 6580, 2, true);
#nullable restore
#line 137 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 6581, item.Nombre, 6581, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6593, "\')", 6593, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-check-circle text-success\" title=\"Cambiar\"></i>\r\n");
#nullable restore
#line 138 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i");
            BeginWriteAttribute("onclick", " onclick=\"", 6822, "\"", 6890, 6);
            WriteAttributeValue("", 6832, "CambiarEstadoProductos(", 6832, 23, true);
#nullable restore
#line 141 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 6855, item.idProductos, 6855, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6872, ",", 6873, 2, true);
            WriteAttributeValue(" ", 6874, "\'", 6875, 2, true);
#nullable restore
#line 141 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
WriteAttributeValue("", 6876, item.Nombre, 6876, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6888, "\')", 6888, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-times-circle text-danger\" title=\"Cambiar\"></i>                                        \r\n");
#nullable restore
#line 142 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f41586d82a8bdbff33dfb8cb16e9c3702c99ff27816", async() => {
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
#line 147 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f41586d82a8bdbff33dfb8cb16e9c3702c99ff30270", async() => {
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
#nullable restore
#line 152 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
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
#line 157 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n");
#nullable restore
#line 172 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
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
#line 182 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 186 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
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
#line 195 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                        
        }



          else if (TempData["CambiarProducto"] != null && TempData["CambiarProducto"].ToString().Equals("no"))
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
#line 210 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\ProductosCategoria\Index.cshtml"
                   
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
