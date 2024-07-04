function guardarCliente(cliente) {
  let clientes = JSON.parse(localStorage.getItem('clientes')) || [];
  clientes.push(cliente);
  localStorage.setItem('clientes', JSON.stringify(clientes));
}

function obtenerClientes() {
  return JSON.parse(localStorage.getItem('clientes')) || [];
}

document.getElementById('formulario').addEventListener('submit', function(event) {
  event.preventDefault();

  let cedula = document.getElementById('cedula').value.trim();
  let apellidos = document.getElementById('apellidos').value.trim();
  let nombres = document.getElementById('nombres').value.trim();
  let direccion = document.getElementById('direccion').value.trim();
  let telefono = document.getElementById('telefono').value.trim();
  let email = document.getElementById('email').value.trim();

  if (!validarCedula(cedula)) {
      alert('Cédula no válida.');
      return;
  }

  if (!validarTelefono(telefono)) {
      alert('Teléfono no válido.');
      return;
  }

  if (!validarEmail(email)) {
      alert('Correo electrónico no válido.');
      return;
  }

  let cliente = {
      cedula: cedula,
      apellidos: apellidos,
      nombres: nombres,
      direccion: direccion,
      telefono: telefono,
      email: email
  };

  guardarCliente(cliente);

  alert('Datos guardados exitosamente.');
  document.getElementById('formulario').reset();
  mostrarClientes();  // Actualiza la tabla después de guardar
});

function validarCedula(cedula) {
  let regex = /^[0-9]{10}$/;
  return regex.test(cedula);
}

function validarTelefono(telefono) {
  let regex = /^[0-9]{10}$/;
  return regex.test(telefono);
}

function validarEmail(email) {
  let regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  return regex.test(email);
}

function mostrarClientes() {
  let clientes = obtenerClientes();
  let tbody = document.querySelector('#tabla-clientes tbody');
  tbody.innerHTML = '';

  clientes.forEach((cliente, index) => {
      let row = tbody.insertRow();

      row.insertCell().textContent = cliente.cedula;
      row.insertCell().textContent = cliente.apellidos;
      row.insertCell().textContent = cliente.nombres;
      row.insertCell().textContent = cliente.direccion;
      row.insertCell().textContent = cliente.telefono;
      row.insertCell().textContent = cliente.email;

      let acciones = row.insertCell();

      let btnEditar = document.createElement('button');
      btnEditar.textContent = 'Editar';
      btnEditar.onclick = function() {
          editarCliente(index);
      };
      acciones.appendChild(btnEditar);

      let btnEliminar = document.createElement('button');
      btnEliminar.textContent = 'Eliminar';
      btnEliminar.onclick = function() {
          eliminarCliente(index);
      };
      acciones.appendChild(btnEliminar);
  });
}

document.addEventListener('DOMContentLoaded', mostrarClientes);

function editarCliente(index) {
  let clientes = obtenerClientes();
  let cliente = clientes[index];

  // Rellenar el formulario con los datos del cliente a editar
  document.getElementById('cedula').value = cliente.cedula;
  document.getElementById('apellidos').value = cliente.apellidos;
  document.getElementById('nombres').value = cliente.nombres;
  document.getElementById('direccion').value = cliente.direccion;
  document.getElementById('telefono').value = cliente.telefono;
  document.getElementById('email').value = cliente.email;

  // Cambiar el evento onsubmit del formulario para actualizar el cliente
  document.getElementById('formulario').onsubmit = function(event) {
      event.preventDefault();

      // Validar los datos
      let cedula = document.getElementById('cedula').value.trim();
      let apellidos = document.getElementById('apellidos').value.trim();
      let nombres = document.getElementById('nombres').value.trim();
      let direccion = document.getElementById('direccion').value.trim();
      let telefono = document.getElementById('telefono').value.trim();
      let email = document.getElementById('email').value.trim();

      if (!validarCedula(cedula)) {
          alert('Cédula no válida.');
          return;
      }

      if (!validarTelefono(telefono)) {
          alert('Teléfono no válido.');
          return;
      }

      if (!validarEmail(email)) {
          alert('Correo electrónico no válido.');
          return;
      }

      // Actualizar los datos del cliente
      cliente.cedula = cedula;
      cliente.apellidos = apellidos;
      cliente.nombres = nombres;
      cliente.direccion = direccion;
      cliente.telefono = telefono;
      cliente.email = email;

      // Guardar los clientes actualizados en localStorage
      localStorage.setItem('clientes', JSON.stringify(clientes));

      alert('Datos actualizados exitosamente.');
      document.getElementById('formulario').reset();
      mostrarClientes();  // Volver a mostrar la tabla con los datos actualizados

      // Restaurar el evento onsubmit original
      document.getElementById('formulario').onsubmit = function(event) {
          event.preventDefault();
          guardarClienteNuevo();
      };
  };
}

function guardarClienteNuevo() {
  let cedula = document.getElementById('cedula').value.trim();
  let apellidos = document.getElementById('apellidos').value.trim();
  let nombres = document.getElementById('nombres').value.trim();
  let direccion = document.getElementById('direccion').value.trim();
  let telefono = document.getElementById('telefono').value.trim();
  let email = document.getElementById('email').value.trim();

  if (!validarCedula(cedula)) {
      alert('Cédula no válida.');
      return;
  }

  if (!validarTelefono(telefono)) {
      alert('Teléfono no válido.');
      return;
  }

  if (!validarEmail(email)) {
      alert('Correo electrónico no válido.');
      return;
  }

  let cliente = {
      cedula: cedula,
      apellidos: apellidos,
      nombres: nombres,
      direccion: direccion,
      telefono: telefono,
      email: email
  };

  guardarCliente(cliente);

  alert('Datos guardados exitosamente.');
  document.getElementById('formulario').reset();
  mostrarClientes();  // Actualiza la tabla después de guardar
}

document.getElementById('formulario').onsubmit = function(event) {
  event.preventDefault();
  guardarClienteNuevo();
};

function eliminarCliente(index) {
  if (confirm('¿Estás seguro de que deseas eliminar este cliente?')) {
      let clientes = obtenerClientes();
      clientes.splice(index, 1);  // Eliminar el cliente del array
      localStorage.setItem('clientes', JSON.stringify(clientes));  // Guardar el array actualizado en localStorage
      mostrarClientes();  // Volver a mostrar la tabla con los datos actualizados
  }
}