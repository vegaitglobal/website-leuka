var donateInformationModal = document.getElementById(
  "donate-information-modal"
);

var donateInformationClose = document.getElementById(
  "donate-information-close"
);

var donateInformationCloseBtn = document.getElementById(
  "donate-information-close-button"
);

var donateSubmitBtn = document.getElementById("donate-submit-button");

function closeDonateInfomration() {
  donateInformationModal.style.display = "none";
}

function openDonateInfomration() {
  var donateModal = document.getElementById("donate-modal");
  donateModal.style.display = "none";
  donateInformationModal.style.display = "block";
}

donateInformationCloseBtn.onclick = closeDonateInfomration;
donateInformationClose.onclick = closeDonateInfomration;

window.onclick = function (event) {
  if (event.target == donateInformationModal) {
    donateInformationModal.style.display = "none";
  }
};

const onDonate = () => {
    const endpoint = `/Umbraco/Surface/Inform/Donate`;

  const donor = document.getElementById("donor").value;
  const amount = document.getElementById("amount").value;
  const company = document.getElementById("company").value;
  const email = document.getElementById("email").value;
  const mode = "donate";  

  if (!donor || !amount || !email) {
    alert("Molim Vas da popunite obavezna polja označena znakom *.");
    return;
  }
  openDonateInfomration();

  const payload = { firstName: "", lastName: "", messageText: "", involveInActions: false, mode, donor, amount, company, email };

    $.ajax({
        type: "POST",
        url: endpoint,
        data: payload,
        success: function (result) {
            document.getElementById("donor").value = "";
            document.getElementById("amount").value = "";
            document.getElementById("company").value = "";
            document.getElementById("email").value = "";
        }
    });
};

donateSubmitBtn.onclick = onDonate;