﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV1
{
    public class Nomina
    {
        //Miembros PRIVADOS DE LA CLASE

        private string _nombre;
        private string _apellidos;
        private string _puesto;
        private int _horasTrabajadas;
        private float _salarioHora;

        //PROPIEDADES
        /// <summary>
        /// Nombre del Empleado
        /// </summary>
        public string NombreEmpleado
        {
            get {
                //Control de Contenido
                if (string.IsNullOrEmpty(_nombre)) throw new Exception("Nombre de trabajador no establecido");

                //Devolución del Valor
                return _nombre;

            }
            set {
                //Validacion de los Datos a Establecer
                if (string.IsNullOrEmpty(value)) throw new Exception("El nombre del trabajador no puede ser null o la cadena vacia");
                _nombre = value;
            }
        }
        public string ApellidosEmpleado
        {
            get {
            

                //Devolución del Valor
                return _apellidos;

            }
            set {
                
                _apellidos = value;
            }
        }
    }
}
