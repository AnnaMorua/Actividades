using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Modelo
{
    class Estudiante
    {
        private long _numeroControl;
        private string _nombre;
        private byte _edad;
        private char _genero;

        public long NumeroControl {
            get
            {
                return this._numeroControl;
            }
            set
            {
                if (value > 0)
                { 
                this._numeroControl = value;
                }
             

                }
        }
        public string Nombre { get; set; }
        public byte Edad { get; set;}
            public char Genero { get; set; }
    }
}
