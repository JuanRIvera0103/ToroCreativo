#pragma checksum "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5623348e4787caa42ffc71386d295b9361bbc8b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Index), @"mvc.1.0.view", @"/Views/Clientes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5623348e4787caa42ffc71386d295b9361bbc8b2", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToroCreativo.Clases.ClienteDetalle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearEditar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalleCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""titulo"">
    <h1>Sistema Administrativo <span>Clientes</span> </h1>
</div>



<div class=""registros"">

    <table id=""tabla"" class=""table table table-hover"">
        <thead>
            <tr>               
                <th>
                    ");
#nullable restore
#line 19 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5623348e4787caa42ffc71386d295b9361bbc8b25916", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </th>\r\n                <th></th>                \r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 37 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>                 \r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 50 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                         if (item.Estado.Equals("Habilitado"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-success\">");
#nullable restore
#line 52 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 53 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-danger\">");
#nullable restore
#line 56 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 57 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n");
#nullable restore
#line 62 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                         if (item.Estado.Equals("Habilitado"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i");
            BeginWriteAttribute("onclick", " onclick=\"", 2079, "\"", 2167, 13);
            WriteAttributeValue("", 2089, "CambiarEstadoCliente(", 2089, 21, true);
#nullable restore
#line 64 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2110, item.IdCliente, 2110, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2125, ",", 2125, 1, true);
            WriteAttributeValue(" ", 2126, "\'", 2127, 2, true);
#nullable restore
#line 64 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2128, item.Nombre, 2128, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2140, "\'", 2140, 1, true);
            WriteAttributeValue(" ", 2141, "+", 2142, 2, true);
            WriteAttributeValue(" ", 2143, "\'", 2144, 2, true);
            WriteAttributeValue(" ", 2145, "\'", 2146, 2, true);
            WriteAttributeValue(" ", 2147, "+", 2148, 2, true);
            WriteAttributeValue(" ", 2149, "\'", 2150, 2, true);
#nullable restore
#line 64 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2151, item.Apellido, 2151, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2165, "\')", 2165, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-check-circle text-success\" title=\"Cambiar\"></i>\r\n");
#nullable restore
#line 65 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i");
            BeginWriteAttribute("onclick", " onclick=\"", 2346, "\"", 2435, 13);
            WriteAttributeValue("", 2356, "CambiarEstadoCliente(", 2356, 21, true);
#nullable restore
#line 68 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2377, item.IdCliente, 2377, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2392, ",", 2392, 1, true);
            WriteAttributeValue(" ", 2393, "\'", 2394, 2, true);
#nullable restore
#line 68 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2395, item.Nombre, 2395, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2407, "\'", 2408, 2, true);
            WriteAttributeValue(" ", 2409, "+", 2410, 2, true);
            WriteAttributeValue(" ", 2411, "\'", 2412, 2, true);
            WriteAttributeValue(" ", 2413, "\'", 2414, 2, true);
            WriteAttributeValue(" ", 2415, "+", 2416, 2, true);
            WriteAttributeValue(" ", 2417, "\'", 2418, 2, true);
#nullable restore
#line 68 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2419, item.Apellido, 2419, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2433, "\')", 2433, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-times-circle text-danger\" title=\"Cambiar\"></i>\r\n");
#nullable restore
#line 69 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>                    \r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5623348e4787caa42ffc71386d295b9361bbc8b214268", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-search-plus\" title=\"detalle registro\"></i>\r\n                        ");
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
#line 73 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                                                         WriteLiteral(item.IdCliente);

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
#line 78 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n");
#nullable restore
#line 86 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
         if (TempData["Cambiar"] != null && TempData["Cambiar"].ToString().Equals("no"))
        {
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            Swal.fire({
                icon: 'error',
                title: 'No se puede cambiar el estado',
                html: 'El cliente seleccionado cuenta con pedidos en proceso, deberá de solucionar el estado de los pedidos con ese cliente para poder realizar esta acción'
            });

            ");
#nullable restore
#line 96 "E:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToroCreativo.Clases.ClienteDetalle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
