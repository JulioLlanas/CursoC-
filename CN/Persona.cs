using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN
{
    public class Persona
    {


        #region Propiedades

        private string _nombrecompleto;

        public string nombrecompleto
        {
            get { return _nombrecompleto; }
            set { _nombrecompleto = value; }
        }

        private DateTime _fechaNacimiento;

        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public int edad
        {
            get {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - fechaNacimiento.Year;

                if (hoy < fechaNacimiento.AddYears(edad))
                {
                    edad--;

                }
                return edad;
            }

        }


        public string direccion { get; set; }
       
        #endregion

        

        #region Constructores

        public Persona(string _nombrecompleto,
                       string _direccion,
                       DateTime _fechaNacimiento)
        {
            this._nombrecompleto = _nombrecompleto;
            this.direccion = _direccion;
            this._fechaNacimiento = _fechaNacimiento;
        }
      
        #endregion

        #region Metodos y Funciones

       public virtual string descripcion()
        {
            string resultado = String.Format("Nombre: {0} - Direccion: {1} - Fecha Nacimiento {2} - Edad {3}",
                nombrecompleto, direccion, fechaNacimiento, edad);

            return resultado;
        }
        #endregion

        public int calcularedad()
        {
            return 0;
        }

    }
}
