<<<<<<< HEAD
#pragma checksum "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32aed70008cb68a49f56e41c7f4f345fd79b44c9"
=======
#pragma checksum "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32aed70008cb68a49f56e41c7f4f345fd79b44c9"
>>>>>>> Generos
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Index), @"mvc.1.0.view", @"/Views/Categorias/Index.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\_ViewImports.cshtml"
=======
#line 1 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\_ViewImports.cshtml"
>>>>>>> Generos
using ToroCreativo;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\_ViewImports.cshtml"
=======
#line 2 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\_ViewImports.cshtml"
>>>>>>> Generos
using ToroCreativo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32aed70008cb68a49f56e41c7f4f345fd79b44c9", @"/Views/Categorias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToroCreativo.Models.Entities.Categorias>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearEditar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CambiarEstado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return CambiarEstadoRegistro()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 3 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
  
    ViewData["Title"] = "Gestión Productos";
   

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

            <div class=""formulario categoria"">
                <h2>Crear Categoria</h2>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aed70008cb68a49f56e41c7f4f345fd79b44c96659", async() => {
                WriteLiteral("\r\n                    <input type=\"text\" class=\"form-control\" placeholder=\"Categoria\" required>\r\n                    <a class=\"boton cancelar\">Cancelar</a>\r\n                    <button type=\"submit\" class=\"boton crear\">Crear</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"registros\">\r\n                <table id=\"tabla\" class=\"table table-hover \">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>\r\n                                ");
#nullable restore
<<<<<<< HEAD
#line 43 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 43 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
<<<<<<< HEAD
#line 46 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 46 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aed70008cb68a49f56e41c7f4f345fd79b44c99269", async() => {
                WriteLiteral("<i class=\"fas fa-plus\" title=\"Agregar registro\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </th>
                            <th></th>
                            <th></th>
                        </tr>                                                                                                    
                    </thead>
                    <tbody>
");
#nullable restore
<<<<<<< HEAD
#line 56 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 56 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
<<<<<<< HEAD
#line 60 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 60 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
<<<<<<< HEAD
#line 63 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 63 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                 if (item.Estado.Equals("Habilitado"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-success\">");
#nullable restore
<<<<<<< HEAD
#line 65 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 65 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                                       Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>                                    \r\n");
#nullable restore
<<<<<<< HEAD
#line 66 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 66 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"text-danger\">");
#nullable restore
<<<<<<< HEAD
#line 69 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 69 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                                      Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>                                    \r\n");
#nullable restore
<<<<<<< HEAD
#line 70 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 70 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 74 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                 if (item.Estado.Equals("Habilitado"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aed70008cb68a49f56e41c7f4f345fd79b44c913548", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-check-circle text-success\" title=\"Cambiar\"></i>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 76 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 76 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                                                                                              WriteLiteral(item.idCategoria);

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
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 79 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 79 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                }
                                else 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aed70008cb68a49f56e41c7f4f345fd79b44c916346", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-times-circle text-danger\" title=\"Cambiar\"></i>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 82 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 82 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                                                                                             WriteLiteral(item.idCategoria);

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
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 85 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 85 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aed70008cb68a49f56e41c7f4f345fd79b44c919141", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-edit\" title=\"Editar registro\"></i>\r\n                                ");
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
<<<<<<< HEAD
#line 89 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 89 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                                              WriteLiteral(item.idCategoria);

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
            WriteLiteral("                                \r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aed70008cb68a49f56e41c7f4f345fd79b44c921586", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-search-plus\" title=\"detalle registro\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 94 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 94 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
                                                          WriteLiteral(item.idCategoria);

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
            WriteLiteral("                          \r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 99 "C:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
=======
#line 99 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Categorias\Index.cshtml"
>>>>>>> Generos
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
            <div class=""formulario productos"">
                <h2>Crear Producto</h2>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aed70008cb68a49f56e41c7f4f345fd79b44c924596", async() => {
                WriteLiteral(@"
                    <input type=""file"" class=""form-control"" required>
                    <input type=""text"" class=""form-control"" placeholder=""Nombre Producto"" required>
                    <input type=""number"" class=""form-control"" placeholder=""Precio"" required>
                    <select class=""form-control"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aed70008cb68a49f56e41c7f4f345fd79b44c925213", async() => {
                    WriteLiteral("seleccione una Categoria");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32aed70008cb68a49f56e41c7f4f345fd79b44c926479", async() => {
                    WriteLiteral("camisas");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                    <textarea class=""form-control"" placeholder=""descripción""></textarea>
                    <a class=""boton cancelar"">Cancelar</a>
                    <button type=""submit"" class=""boton crear"">Crear</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

            <div class=""registros"">
                <table id=""tabla2"" class=""table table-hover "">
                    <thead>
                        <tr>
                            <th>Nombre</th>
                            <th>Precio</th>
                            <th>Categoria</th>
                            <th>Calificación</th>
                            <th>Estado</th>
                            <th><i class=""fas fa-plus agregar"" title=""Agregar registro""></i></th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Camisa</td>
                            <td>30000</td>
                            <td>Camisas</td>
                            <td>4.5</td>
                            <th>Activado</th>
                            <td>
                                <a");
            BeginWriteAttribute("href", " href=\"", 6820, "\"", 6827, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""Cambiarestado()"">
                                    <i class=""fas fa-check-circle text-success""
                                       title=""Activar registro""></i>
                                </a>
                            </td>
                            <td><a");
            BeginWriteAttribute("href", " href=\"", 7115, "\"", 7122, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-edit"" title=""Editar registro""></i></a></td>
                            <td>
                                <a href=""./detalle-producto.html""><i class=""fas fa-search-plus"" title=""detalle registro""></i></a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>

        </div>

    </div>
</div>
<script>
    
</script>




            

            

            
       
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToroCreativo.Models.Entities.Categorias>> Html { get; private set; }
    }
}
#pragma warning restore 1591
