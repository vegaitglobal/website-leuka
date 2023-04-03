window.onload = () => {
  
  const onDonate = () => {
      const endpoint = `/Umbraco/Surface/Inform/Donate`;

    const donor = document.getElementById("donor").value;
    const amount = document.getElementById("amount").value;
    const company = document.getElementById("company").value;
    const email = document.getElementById("email").value;
    const mode = "donate";

    const payload = { donor, amount, company, email, mode };

      $.ajax({
          type: "POST",
          url: endpoint,
          data: payload,
          success: function () {
          }
      });
  }

  const donateButton = document.getElementById("donate-button");
  donateButton.addEventListener('click', onDonate);
};