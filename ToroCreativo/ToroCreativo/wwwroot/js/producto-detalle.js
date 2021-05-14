const idproducto = document.getElementById("idproducto").value;
$(document).ready(function () {
    $(".sub-img").click(function () {
        var id = $(this).attr("id");
        var idImagen = id / 10;
        var imagen = document.getElementById(idImagen);
        var imagenPrincipal = document.getElementsByClassName("img active");
        $(imagenPrincipal).removeClass("active");
        $(imagen).addClass("active");
    });

    $(".color").click(function () {
        var color = $(this);
        var colorActivo = document.getElementsByClassName("color active");
        if (colorActivo != null) {
            $(colorActivo).removeClass("active");
        }
        $(color).addClass("active");
        $(".seleccionar").css("display", "none");        
    });


    $("#agregar").click(function () {
        var colorActivo = document.getElementsByClassName("color active");
        var medidaActiva = document.getElementsByClassName("medida active");
        if (colorActivo.length > 0 && medidaActiva.length > 0) {
            var idMedida = $(medidaActiva).attr("id");
            var IdCaracteristica = idMedida.substring(2, idMedida.length);
            var cantidad = document.getElementById("cantidad").value;
            var ProductoPedido = {
                Idproducto: idproducto,
                idCaracteristicas: IdCaracteristica,
                Cantidad: cantidad
            };
            $.ajax({
                method: "POST",
                url: "https://localhost:44363/ProductosCategoria/llamadaCarrito/",
                data: ProductoPedido
            });
        } else {
            Swal.fire({
                icon: 'info',
                title: 'No se ha seleccionado producto',
                text: 'Por favor seleccione un color y una medida',
            })
        }
    });
});
