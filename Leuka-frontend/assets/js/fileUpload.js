document.getElementById("files").onchange = function () {
  document.getElementById("fileName").innerHTML = this.value.replace(/.*[\/\\]/, '');
};