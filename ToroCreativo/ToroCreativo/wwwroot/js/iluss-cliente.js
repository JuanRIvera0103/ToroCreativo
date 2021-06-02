var img = document.getElementsByClassName('imagen-ilustracion');


for(i = 0 ; i < img.length; i++){
    var alto = img[i].height;
    var ancho = img[i].width;
    if(alto > ancho){
        img[i].className += " vertical";
    }
    else if(alto < ancho){
        img[i].className += " horizontal";
        (img[i].parentNode).parentNode.className += " span";
    }
}

var ilustracion = document.getElementsByClassName('vista-ilustracion');



for(i = 0; i < ilustracion.length; i++){
    var alto_ilustracion = ilustracion[i].height;
    var ancho_ilustracion = ilustracion[i].width;
    if(alto_ilustracion < ancho_ilustracion){
        ilustracion[i].className += " ilustracion-horizontal";
        ilustracion[i].parentNode.className += " imagen-horizontal";
    }else{
        ilustracion[i].className += " ilustracion-vertical";
    }
}

var generos = document.getElementById('generos');
var generos_active = false; 


function mostrarcategorias() {
    if (generos_active) {
        generos.style.height = '0px';
        generos.style.display = 'none';
        generos.style.backgroundColor = 'transparent';
        generos_active = false;
    } else {
        
        generos.style.height = 'auto';
        generos.style.display = 'block';
        generos.style.backgroundColor = '#dbdbdb93';
        generos_active = true;
    }
}




var ver_detalle = document.getElementById('verdetalle');
var detalle = document.getElementById('detalle');
detalle_active = false;

function verdetalle() {
    if (detalle_active) {
        detalle.style.right = '-100%';                
        detalle.style.opacity = 0;
        detalle.style.backgroundColor = 'transparent';
        detalle.style.zIndex = '-1'; 
        detalle_active = false;
        ver_detalle.style.display = "block"; 
    } else {
        detalle.style.right = '0%';
        detalle.style.opacity = 1;
        detalle.style.backgroundColor = '#f5f5f5';
        detalle.style.zIndex = '100';
        detalle_active = true;   
        ver_detalle.style.display = "none"; 
    }
}
