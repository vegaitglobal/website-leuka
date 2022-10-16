function myFunction() {
  var header = document.getElementById("header");
  if (!header.classList.contains("header-open")) {
    header.classList.add("header-open");
    document.getElementById("hamburger-icon-img").src =
      "images/hamburger-x.svg";
    document.getElementById("hamburger-icon-img").style.marginLeft = "2.2em";
  } else {
    header.classList.remove("header-open");
    document.getElementById("hamburger-icon-img").src = "images/hamburger.svg";
  }
}
