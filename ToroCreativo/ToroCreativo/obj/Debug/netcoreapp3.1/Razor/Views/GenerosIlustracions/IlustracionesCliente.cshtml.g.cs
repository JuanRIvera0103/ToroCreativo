#pragma checksum "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f26bad1e836a0f8712f650a78d3854424207865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GenerosIlustracions_IlustracionesCliente), @"mvc.1.0.view", @"/Views/GenerosIlustracions/IlustracionesCliente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f26bad1e836a0f8712f650a78d3854424207865", @"/Views/GenerosIlustracions/IlustracionesCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a62e77cc898383c5c3eefa6bf192863ca3ea6e5", @"/Views/_ViewImports.cshtml")]
    public class Views_GenerosIlustracions_IlustracionesCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToroCreativo.Clases.IlustracionVistaCliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ilustraciones-cliente.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/estilos-generales.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
  
    Layout = "_LayoutCliente";
    ViewData["Title"] = "Index";

    var subImagenes = ViewBag.Imagenes;

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f26bad1e836a0f8712f650a78d38544242078655389", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f26bad1e836a0f8712f650a78d38544242078656567", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div class=\"ilustraciones-cliente\">\r\n    <div class=\"encabezado\">\r\n        <h1>Ilustraciones</h1>\r\n        <div class=\"generos\">\r\n");
#nullable restore
#line 18 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
             foreach (var categoria in ViewBag.Generos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f26bad1e836a0f8712f650a78d38544242078658266", async() => {
#nullable restore
#line 20 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
                            Write(categoria.Nombre);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"galeria\">\r\n");
#nullable restore
#line 26 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"ilustracion ampliar\"");
            BeginWriteAttribute("idIlustracion", " idIlustracion=\"", 816, "\"", 851, 1);
#nullable restore
#line 28 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
WriteAttributeValue("", 832, item.IdIlustracion, 832, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 852, "\"", 857, 0);
            EndWriteAttribute();
            WriteLiteral(" >\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f26bad1e836a0f8712f650a78d385442420786510837", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
               WriteLiteral("~/imgIlustraciones/" + item.ImageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<div class=""ilustracion-modal"" id=""modal"" >
    <div class=""ilustracion"">
        <div class=""imagenes"" id=""imagen"">
        </div>
        <div class=""sub-imagenes"">
        </div>
    </div>
    <div class=""informacion"">
        <i");
            BeginWriteAttribute("onclick", " onclick=\"", 1260, "\"", 1270, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""fas fa-times-circle"" title=""Cerrar"" id=""cerrar""></i>
        <div class=""nombre"">
            <h2>Nombre</h2>
        </div>
        <div class=""descripcion"">
            <h3 class=""title"">Descripción: </h3>
            <p>Descripcion</p>

        </div>
");
#nullable restore
#line 54 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
         if (TempData["Usuario"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"crearComentario\">\r\n            </div>\r\n");
#nullable restore
#line 58 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"capa\" id=\"capa\"></div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        $(document).ready(function () {\r\n\r\n\r\n            var imagenesJSON = JSON.parse(\'");
#nullable restore
#line 68 "C:\Users\RYZEN 3\Source\Repos\ToroCreativo\ToroCreativo\ToroCreativo\Views\GenerosIlustracions\IlustracionesCliente.cshtml"
                                      Write(Html.Raw(subImagenes));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');
            $("".ampliar"").click(function () {
                $("".imagenes"").empty();
                $("".sub-imagenes"").empty();
                var idSubImagen = 0;
                var idImagen = 0;
                var idIlustracion = $(this).attr('idIlustracion');
                

               
                for (var i = 0; i < imagenesJSON.length; i++) {
                    if (imagenesJSON[i].IdIlustracion == idIlustracion) {
                        idSubImagen += 10;
                        idImagen++;
                        if (imagenesJSON[i].Estado == 'Principal') {
                            $("".imagenes"").append('<img class=""img active"" src=""../imgIlustraciones/' + imagenesJSON[i].ImageName + '"" id=""' + idImagen + '"" />');
                        }
                        else {
                            $("".imagenes"").append('<img class=""img"" src=""../imgIlustraciones/' + imagenesJSON[i].ImageName + '"" id=""' + idImagen + '"" />');
                        }
          ");
                WriteLiteral(@"              $("".sub-imagenes"").append('<div class=""sub-imagen""><img class=""sub-img"" src=""../imgIlustraciones/' + imagenesJSON[i].ImageName + '"" id=""' + idSubImagen + '""/></div >');
                    }
                }
                $(""#capa"").addClass(""active"");
                $(""#modal"").addClass(""active"");
            });

            $(""#cerrar"").click(function () {
                $(""#capa"").removeClass(""active"");
                $(""#modal"").removeClass(""active"");
            });

            $(document).on(""click"", "".sub-img"", function () {
                var id = $(this).attr(""id"");
                var idImagen = id / 10;
                var imagen = document.getElementById(idImagen);
                var imagenPrincipal = document.getElementsByClassName(""img active"");
                $(imagenPrincipal).removeClass(""active"");
                $(imagen).addClass(""active"");
            });
        });

    </script>
    <script type=""text/javascript"">
        function AjaxFo");
                WriteLiteral(@"rmSubmit() {
            

            //Add the Field values to FormData object.
            var formData = new FormData();
            formData.append(""texto"", $(""#txtFirstName"").val());
            
            formData.append(""idilustracion"", $(""#Idilus"").val());
            formData.append(""idcomentario"", 0);

            $.ajax({
                type: 'POST',
                url: '../../Comentarios/CrearEditar',
                data: formData,
                processData: false,
                contentType: false
            }).done(function (response) {
                if (response.Status === ""success"") {
                    $(""#lblName"").html(response.Name);
                }
            });
        }
        
        
         
            
            $("".ampliar"").click(function () {
                $("".imagenes"").empty();
                $("".sub-imagenes"").empty();
                var idSubImagen = 0;
                var idImagen = 0;
                var idIlustracio");
                WriteLiteral(@"n = $(this).attr('idIlustracion');
                console.log(idIlustracion);
                var idilus = Number.parseInt(idIlustracion);
                
                $.ajax({
                    type: ""GET"",
                    dataType: ""json"",
                    url: ""../../Comentarios/ObtenerComentarios"",
                    traditional: true,
                    contentType: ""application/json;charset=utf-8"",
                    data: 'id=' + idilus,
                    success: function (data) {
                        $('.descripcion').empty();
                        $('.crearComentario').empty()
                        for (var i = 0; i < data.length; i++) {
                            $('.descripcion').append('<p >' + data[i].texto + ' </p><p>' + data[i].fecha + ' </p><p>' + data[i].correo + ' </p>');
                        }

                        $('.crearComentario').append('<form id=""myForm"" method=""post"" enctype=""multipart/form-data"">\n\
                            <");
                WriteLiteral(@"input class=""comments"" type = ""text"" id = ""txtFirstName""/>\n\
                            <input class=""comments"" type = ""hidden"" id = ""Idilus"" value=""'+ idilus + '""/>\n\
                            <input type=""button"" value=""Submit"" onclick=""AjaxFormSubmit()"" />\n\
                        </form >');

                    },
                    error: function (xhr, status, error) {

                    }
                });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToroCreativo.Clases.IlustracionVistaCliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
