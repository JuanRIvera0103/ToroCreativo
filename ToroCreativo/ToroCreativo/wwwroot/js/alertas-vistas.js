
if (TempData["editar"] != null && TempData["editar"].ToString().Equals("si")) {
    <text>
        Swal.fire({
            icon: 'success',
                    title: '¡Se editó correctamente el registro!',
                    showConfirmButton: false,
                    timer: 1250
                })
            </text>
}

if (TempData["guardar"] != null && TempData["guardar"].ToString().Equals("si")) {
    <text>
        Swal.fire({
            icon: 'success',
                    title: '¡Se guardó correctamente el registro!',
                    showConfirmButton: false,
                    timer: 1250
                })
            </text>
}