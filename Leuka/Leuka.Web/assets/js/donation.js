window.onload = () => {
  
  const onDonate = () => {
    const endpoint = `http://leuka.local/kontakt`;

    const donor = document.getElementById("donor").value;
    const amount = document.getElementById("amount").value;
    const company = document.getElementById("company").value;
    const email = document.getElementById("email").value;
    const mode = "donate";

    const payload = { donor, amount, company, email, mode };
    fetch(endpoint, {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify(payload),
        })
  }

  const donateButton = document.getElementById("donate-button");
  donateButton.addEventListener('click', onDonate);
};