const formulario = document.getElementById('formulario-cliente');

formulario.addEventListener('submit', (event) => {
  event.preventDefault();

  const nombre = document.getElementById('nombre').value;
  const correoElectronico = document.getElementById('correo_electronico').value;
  const telefono = document.getElementById('telefono').value;
  const direccion = document.getElementById('direccion').value;

  // Validación básica de datos (opcional)

  if (nombre === '' || correoElectronico === '' || direccion === '') {
    alert('Llene todos los campos obligatorios');
    return;
  }

  // Envío de datos al servidor (reemplazar con tu lógica)
  const datos = {
    nombre,
    correoElectronico,
    telefono,
    direccion
  };

  console.log('Datos del cliente:', datos);
  // Implementar la lógica para enviar los datos a un servidor o base de datos

  alert('¡Datos enviados correctamente!');
});
