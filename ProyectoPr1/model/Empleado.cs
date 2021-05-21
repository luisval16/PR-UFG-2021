using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPr1.model
{
    public class Empleado
    {
        private String nombre;
        private String apellido;
        private String username;
        private String email;
        private String password;
        private int edad;
        private String genero;
        private String puesto;

        public Empleado()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Puesto { get => puesto; set => puesto = value; }
    }
}
