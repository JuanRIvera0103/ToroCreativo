
function mostrarModal(url, titulo){
    $.ajax({
        method: "GET",
        url: url,
        success: function (res) {
            $("#form-modal .modal-body").html(res);
            $("#form-modal .modal-title").html(titulo);
            $("#form-modal").modal('show');
        }
    });
}