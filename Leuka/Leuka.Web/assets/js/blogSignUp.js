const onBlogSignUp = () => {
    const endpoint = `/Umbraco/Surface/Inform/Contact`;

    const firstName = document.getElementById("firstName").value;
    const lastName = document.getElementById("lastName").value;
    const email = document.getElementById("contact-email").value;
    const messageText = document.getElementById("messageText").value;
    const files = document.querySelector('input[type="file"]');

    var data = new FormData();
    data.append('files', files.files[0]);
    data.append('firstName', firstName);
    data.append('lastName', lastName);
    data.append('email', email);
    data.append('involveInActions', false);
    data.append('messageText', messageText);
    if (!firstName || !lastName || !email || !files) {
        alert("Molimo Vas unesite sva neophodna polja");
        return;
    }
    fetch(endpoint, {
        method: 'POST',
        body: data,
    }).then((resp) => {
        resp.status === 200 ? alert('Hvala Vam na kontaktiranju') : alert("Mejl ne moze biti poslat")
    });
}

const signUpButton = document.getElementById("submit-blog-message");
signUpButton.addEventListener('click', onBlogSignUp);
