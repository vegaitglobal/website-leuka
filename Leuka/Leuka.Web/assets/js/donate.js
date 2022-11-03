var donateModal = document.getElementById("donate-modal");

var donateBtn = document.getElementById("donate-modal-button");

var donateClose = document.getElementById("donate-modal-close");

donateBtn.onclick = function () {
  donateModal.style.display = "block";
};

donateClose.onclick = function () {
  donateModal.style.display = "none";
};

window.onclick = function (event) {
  if (event.target == donateModal) {
    donateModal.style.display = "none";
  }
};
