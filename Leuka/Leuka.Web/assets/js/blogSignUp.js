const onBlogSignUp = () => {
  const endpoint = `http://leuka.local/nasi-pobednici`;

  const firstName = document.getElementById("firstName").value;
  const lastName = document.getElementById("lastName").value;
  const email = document.getElementById("contact-email").value;
  const messageText = document.getElementById("messageText").value;
  const file = document.getElementById("files").value;

  var data = new FormData();
  data.append('files', [file]);
  data.append('firstName', firstName);
  data.append('lastName', lastName);
  data.append('email', email);
  data.append('messageText', messageText);
  if (!firstName || !lastName || !email || !file) {
      alert("Molimo Vas unesite sva neophodna polja");
      return;
  }
  fetch(endpoint, {
      method: 'POST',
      headers: {
          'Content-Type': 'multipart/form-data',
      },
      body: data,
  }).then((resp) => {
      resp.status === 200 ? alert('Hvala Vam na kontaktiranju') : alert("Mejl ne moze biti poslat")
  });
}

const signUpButton = document.getElementById("submit-blog-message");
signUpButton.addEventListener('click', onBlogSignUp);
