#pragma checksum "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8448419eca5212316f6f38f427672cb4c7017a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8448419eca5212316f6f38f427672cb4c7017a", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToroCreativo.Clases.ClienteDetalle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalleCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
  
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
#line 19 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n                <th></th>                \r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 35 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>                 \r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 48 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                         if (item.Estado.Equals("Habilitado"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-success\">");
#nullable restore
#line 50 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 51 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-danger\">");
#nullable restore
#line 54 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 55 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n");
#nullable restore
#line 60 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                         if (item.Estado.Equals("Habilitado"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i");
            BeginWriteAttribute("onclick", " onclick=\"", 1962, "\"", 2050, 13);
            WriteAttributeValue("", 1972, "CambiarEstadoCliente(", 1972, 21, true);
#nullable restore
#line 62 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 1993, item.IdCliente, 1993, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2008, ",", 2008, 1, true);
            WriteAttributeValue(" ", 2009, "\'", 2010, 2, true);
#nullable restore
#line 62 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2011, item.Nombre, 2011, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2023, "\'", 2023, 1, true);
            WriteAttributeValue(" ", 2024, "+", 2025, 2, true);
            WriteAttributeValue(" ", 2026, "\'", 2027, 2, true);
            WriteAttributeValue(" ", 2028, "\'", 2029, 2, true);
            WriteAttributeValue(" ", 2030, "+", 2031, 2, true);
            WriteAttributeValue(" ", 2032, "\'", 2033, 2, true);
#nullable restore
#line 62 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2034, item.Apellido, 2034, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2048, "\')", 2048, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-check-circle text-success\" title=\"Cambiar\"></i>\r\n");
#nullable restore
#line 63 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i");
            BeginWriteAttribute("onclick", " onclick=\"", 2229, "\"", 2318, 13);
            WriteAttributeValue("", 2239, "CambiarEstadoCliente(", 2239, 21, true);
#nullable restore
#line 66 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2260, item.IdCliente, 2260, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2275, ",", 2275, 1, true);
            WriteAttributeValue(" ", 2276, "\'", 2277, 2, true);
#nullable restore
#line 66 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2278, item.Nombre, 2278, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2290, "\'", 2291, 2, true);
            WriteAttributeValue(" ", 2292, "+", 2293, 2, true);
            WriteAttributeValue(" ", 2294, "\'", 2295, 2, true);
            WriteAttributeValue(" ", 2296, "\'", 2297, 2, true);
            WriteAttributeValue(" ", 2298, "+", 2299, 2, true);
            WriteAttributeValue(" ", 2300, "\'", 2301, 2, true);
#nullable restore
#line 66 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2302, item.Apellido, 2302, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2316, "\')", 2316, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-times-circle text-danger\" title=\"Cambiar\"></i>\r\n");
#nullable restore
#line 67 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>                    \r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a8448419eca5212316f6f38f427672cb4c7017a12312", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-search-plus\" title=\"detalle registro\"></i>\r\n                        ");
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
#line 71 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
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
#line 76 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n");
#nullable restore
#line 84 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
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
#line 94 "D:\Proyecto\ToroCreativo\ToroCreativo\ToroCreativo\Views\Clientes\Index.cshtml"
                   
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
