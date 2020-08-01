document.addEventListener("DOMContentLoader", function () {
    var element = document.createElement("p");
    element.textContent = "This is the element of third js file";
    document.querySelector("body").appendChild(element);
});