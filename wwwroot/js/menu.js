//Js för navigering

//variabler 
const hamburger = document.querySelector(".hamburger");
const navMenu = document.querySelector(".navMenu");
//eventlyssnare
hamburger.addEventListener("click", mobileMenu);

//gör att menyn öppnar sif
function mobileMenu() {
    hamburger.classList.toggle("active"); 
    navMenu.classList.toggle("active");
}


const navLink = document.querySelectorAll(".navLink");

navLink.forEach(n => n.addEventListener("click", closeMenu));
//gör att navigering stängs  vid klick på länk
function closeMenu() {
    hamburger.classList.remove("active");
    navMenu.classList.remove("active");
}
