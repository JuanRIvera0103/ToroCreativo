const hamburger = document.querySelector('.header .nav-bar .nav-list .logo');
const mobile_menu = document.querySelector('.header .nav-bar .nav-list ul');
const menu_list = document.querySelectorAll('.header .nav-bar .nav-list ul li a');
const header = document.querySelector('.header.container');
const abajo = document.querySelector('.inicio .triangulo');

hamburger.addEventListener('click', () => {
    hamburger.classList.toggle('active');
    mobile_menu.classList.toggle('active');
});

document.addEventListener('scroll', () => {
    var scroll_position = window.scrollY;
    if(scroll_position > 90){
        header.style.backgroundColor = '#6c5ce7e0';
    } 
    else{   
        header.style.backgroundColor = 'transparent';
    }
});

menu_list.forEach((item) => {
    item.addEventListener('click', () => {
        hamburger.classList.toggle('active');
        mobile_menu.classList.toggle('active');
    });
});
