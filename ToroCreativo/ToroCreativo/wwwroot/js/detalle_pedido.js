

const formulario2 = document.querySelector('.formulario2');
const cerrar2 = document.querySelector('.formulario2 .cancelar2');
const agregar2 = document.querySelector('.registros .agregar2');

//funciones para formulario con una sola tabla navs
cerrar2.addEventListener('click', () => {
    formulario2.classList.toggle('active');
    container.classList.toggle('active');
});
agregar2.addEventListener('click', () => {
    formulario2.classList.toggle('active');
    container.classList.toggle('active');
});

