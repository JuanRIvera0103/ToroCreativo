const container = document.querySelector('.container');

//variables primera parte del nav
const primer_formulario = document.querySelector('#primer-nav .formulario');
const primer_cerrar = document.querySelector('#primer-nav .formulario .cancelar');
const primer_agregar = document.querySelector('#primer-nav .registros .agregar');

//variables segunda parte del nav
const segundo_formulario = document.querySelector('#segundo-nav .formulario');
const segundo_cerrar = document.querySelector('#segundo-nav .formulario .cancelar');
const segundo_agregar = document.querySelector('#segundo-nav .registros .agregar');



//funciones para formulario primera parte del nav
primer_cerrar.addEventListener('click', () => {
    primer_formulario.classList.toggle('active');
    container.classList.toggle('active');
});
primer_agregar.addEventListener('click', () => {
    primer_formulario.classList.toggle('active');
    container.classList.toggle('active');
});

//funciones para formulario segunda parte del nav
segundo_cerrar.addEventListener('click', () => {
    segundo_formulario.classList.toggle('active');
    container.classList.toggle('active');
});
segundo_agregar.addEventListener('click', () => {
    segundo_formulario.classList.toggle('active');
    container.classList.toggle('active');
});
