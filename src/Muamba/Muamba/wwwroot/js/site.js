// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var stars = document.querySelectorAll(".star-icon");
document.addEventListener("click", function (e) {
    var classStar = e.target.classList;
    if (!classStar.contains("ativo")) {
        stars.forEach(function (star) {
            star.classList.remove("ativo")
        });
        classStar.add("ativo");
    }
});



function Avaliar(estrela, Id) {

    document.getElementById(Id).value = estrela;
}