const onContact = () => {
    const endpoint = `/Umbraco/Surface/Inform/Contact`;

    const firstName = document.getElementById("firstName").value;
    const lastName = document.getElementById("lastName").value;
    const email = document.getElementById("contact-email").value;
    const messageText = document.getElementById("messageText").value;
    const involveInActions = document.getElementById("involveInActions").checked;
    const mode = "contact";

    const payload = { firstName, lastName, email, messageText, involveInActions, mode };
    if (!firstName || !lastName || !email) {
        alert("Molimo Vas unesite sva neophodna polja");
        return;
    }

    $.ajax({
        type: "POST",
        url: endpoint,
        data: payload,
        success: function (result) {
            alert('Hvala Vam na kontaktiranju');
        },
        error: function () {
            alert("Mejl ne moze biti poslat");
        }
    });
}

const contactButton = document.getElementById("submit-contact-message");
contactButton.addEventListener('click', onContact);
