const onContact = () => {
  const endpoint = `http://leuka.local/contact`;

  const firstName = document.getElementById("firstName").value;
  const lastName = document.getElementById("lastName").value;
  const email = document.getElementById("contact-email").value;
  const messageText = document.getElementById("messageText").value;
  const involveInActions = document.getElementById("involveInActions").checked;

  const payload = { firstName, lastName, email, messageText, involveInActions };
  if (!firstName || !lastName || !email) {
      alert("Molimo Vas unesite sva neophodna polja");
      return;
  }
  fetch(endpoint, {
      method: 'POST',
      headers: {
          'Content-Type': 'application/json',
      },
      body: JSON.stringify(payload),
  }).then((resp) => {
      resp.status === 200 ? alert('Hvala Vam na kontaktiranju') : alert("Mejl ne moze biti poslat")
  });
}

const contactButton = document.getElementById("submit-contact-message");
contactButton.addEventListener('click', onContact);
