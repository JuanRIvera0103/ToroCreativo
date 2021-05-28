var pedidosNav = $('<nav><div class="nav nav-tabs" id ="nav-tab" role = "tablist" >\n\
                <a class="nav-item nav-link active" id="primer-nav-tab" data-toggle="tab" href="#primer-nav" role="tab"\n\
                    aria-controls="primer-nav" aria-selected="true">Aceptados <i class="fas fa-circle text-success"></i></a>\n\
                <a class="nav-item nav-link" id="segundo-nav-tab" data-toggle="tab" href="#segundo-nav" role="tab"\n\
                    aria-controls="segundo-nav" aria-selected="false">Pendientes <i class="fas fa-circle text-warning"></i></a>\n\
                <a class="nav-item nav-link" id="tercer-nav-tab" data-toggle="tab" href="#tercer-nav" role="tab"\n\
                    aria-controls="tercer-nav" aria-selected="false">Cancelar <i class="fas fa-circle text-danger"></i></a>\n\
            </div></nav>');

var tablaPedidos = $('<div class= "gestion" > <div class="tab-content" id="nav-tabContent">\n\
        <div class="tab-pane fade show active" id="primer-nav" role="tabpanel" aria-labelledby="nav-home-tab">\n\
            <div class="registros">\n\
                <table id="tabla" class="table table-hover ">\n\
                    <thead><tr><th>Fecha</th><th>Cédula</th><th>Nombre Cliente</th><th>Dirección</th>\n\
                    <th>Teléfono</th><th>Comprobante</th><th>Estado</th><th></th></tr></thead>\n\
                    <tbody id="tbAceptados"></tbody>\n\
                </table></div></div>\n\
        <div class="tab-pane fade show" id="segundo-nav" role="tabpanel" aria-labelledby="nav-profile-tab">\n\
            <div class="registros">\n\
                <table id="tabla2" class="table table-hover ">\n\
                    <thead><tr><th>Fecha</th><th>Cédula</th><th>Nombre Cliente</th><th>Dirección</th>\n\
                    <th>Teléfono</th><th>Estado</th><th></th></tr></thead>\n\
                    <tbody id="tbPendientes"></tbody>\n\
                </table></div></div>\n\
        <div class="tab-pane fade show" id="tercer-nav" role="tabpanel" aria-labelledby="nav-home-tab">\n\
            <div class="registros">\n\
                <table id="tabla3" class="table table-hover ">\n\
                    <thead><tr><th>Fecha</th><th>Cédula</th><th>Nombre Cliente</th><th>Dirección</th>\n\
                    <th>Teléfono</th><th>Estado</th><th></th></tr></thead>\n\
                    <tbody id="tbCancelados"></tbody>\n\
                </table></div></div></div></div>');


var ventasNav = $('<nav><div class="nav nav-tabs" id="nav-tab" role="tablist">\n\
        <a class="nav-item nav-link active" id="primer-nav-tab" data-toggle="tab" href="#primer-nav" role="tab"\n\
            aria-controls="primer-nav" aria-selected="true">Ventas por enviar</a>\n\
        <a class="nav-item nav-link" id="segundo-nav-tab" data-toggle="tab" href="#segundo-nav" role="tab"\n\
            aria-controls="segundo-nav" aria-selected="false">Ventas enviadas</a></div></nav>');

var tablaVentas = $('<div class= "gestion" ><div class="tab-content" id="nav-tabContent">\n\
       <div class="tab-pane fade show active" id="primer-nav" role="tabpanel" aria-labelledby="nav-home-tab">\n\
            <div class="registros"><table id="tabla" class="table table-hover ">\n\
                    <thead><tr><th>Fecha</th><th>Cédula</th><th>Nombre Cliente</th>\n\
                            <th>Total</th><th>Estado</th><th></th><th></th></tr></thead>\n\
        <tbody id="tbVentasEnviar"></tbody>\n\
        </table></div></div>\n\
        <div class="tab-pane fade show" id="segundo-nav" role="tabpanel" aria-labelledby="nav-profile-tab">\n\
        <div class="registros"><table id="tabla2" class="table table-hover ">\n\
                <thead><tr><th>Fecha</th><th>Cédula</th><th>Nombre Cliente</th>\n\
                    <th>Total</th><th>Estado</th><th></th><th></th></tr></thead>\n\
            <tbody id="tbVentasEnviadas"></tbody>\n\
        </table></div></div></div></div>');