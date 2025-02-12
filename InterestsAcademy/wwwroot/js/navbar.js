document.addEventListener("DOMContentLoaded", function () {
    var menuToggle = document.getElementById("menu-toggle");
    var nav = document.getElementById("site-nav");

    menuToggle.addEventListener("click", function () {
        nav.classList.toggle("is-active");
    });
});
