﻿document.addEventListener("DOMContentLoader", function () {
    var element = document.createElement("p");
    element.textContent = "This is the element of fourth js file";
    document.querySelector("body").appendChild(element);
});