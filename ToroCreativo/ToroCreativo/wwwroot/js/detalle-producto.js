const container = document.querySelector('.container');

//variables caracteristicas
const caracteristicas_formulario = document.querySelector('#caracteristicas .formulario');
const caracteristicas_cerrar = document.querySelector('#caracteristicas .formulario .cancelar');
const caracteristicas_agregar = document.querySelector('#caracteristicas .registros .agregar');

//variables precios
const precios_formulario = document.querySelector('#precios .formulario');
const precios_cerrar = document.querySelector('#precios .formulario .cancelar');
const precios_agregar = document.querySelector('#precios .registros .agregar');

//variables iva
const iva_formulario = document.querySelector('#iva .formulario');
const iva_cerrar = document.querySelector('#iva .formulario .cancelar');
const iva_agregar = document.querySelector('#iva .registros .agregar');

//variables precios
const entradas_formulario = document.querySelector('#entradas .formulario');
const entradas_cerrar = document.querySelector('#entradas .formulario .cancelar');
const entradas_agregar = document.querySelector('#entradas .registros .agregar');


//funciones para formulario caracteristicas
caracteristicas_cerrar.addEventListener('click', () => {
    caracteristicas_formulario.classList.toggle('active');
    container.classList.toggle('active');
});
caracteristicas_agregar.addEventListener('click', () => {
    caracteristicas_formulario.classList.toggle('active');
    container.classList.toggle('active');
});

//funciones para formulario precios
precios_cerrar.addEventListener('click', () => {
    precios_formulario.classList.toggle('active');
    container.classList.toggle('active');
});
precios_agregar.addEventListener('click', () => {
    precios_formulario.classList.toggle('active');
    container.classList.toggle('active');
});


//funciones para formulario iva
iva_cerrar.addEventListener('click', () => {
    iva_formulario.classList.toggle('active');
    container.classList.toggle('active');
});
iva_agregar.addEventListener('click', () => {
    iva_formulario.classList.toggle('active');
    container.classList.toggle('active');
});

//funciones para formulario entradas
entradas_cerrar.addEventListener('click', () => {
    entradas_formulario.classList.toggle('active');
    container.classList.toggle('active');
});
entradas_agregar.addEventListener('click', () => {
    entradas_formulario.classList.toggle('active');
    container.classList.toggle('active');
});
function Cambiarestado() {
    confirm("¿Estas seguros que deseas cambiar el estado de este registro?");
}
