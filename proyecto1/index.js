document.getElementById('contactForm').addEventListener('submit', function(event) {
    event.preventDefault();
    const name = document.getElementById('name').value;
    const email = document.getElementById('email').value;
    const message = document.getElementById('message').value;
    alert('Gracias ' + name + ', tu mensaje ha sido enviado.');
});

document.getElementById('clientForm').addEventListener('submit', function(event) {
    event.preventDefault();
    const name = document.getElementById('clientName').value;
    const email = document.getElementById('clientEmail').value;
    const service = document.getElementById('clientService').value;
    alert('Registro completado: ' + name + ', Email: ' + email + ', Servicio: ' + service);
});
