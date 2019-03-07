using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Modelo.campeonato
{
    class Cancha
    {
        private int _id;
        private string _nombre;
        private string _ubicacion;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                {
                    this._id = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                if (value != null || (value.Length > 3 && value.Length <= 300))
                {
                    this._nombre = value;
                }
            }

        }
    }
}
