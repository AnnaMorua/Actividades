using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Modelo.campeonato
{
    class Equipo
    {
        private int _id;
        private string _nombre;
        private string _comunidad;
        private string _entrenador;


        //para que nombre siempre asigne un valor
        public Equipo()
        {
            this._nombre = "Deportivo Rio Laja";
        }
        public int Id {
            get
            {
                return this._id;
            }
            set
            {
                if (value > 0)
                    this._id = value;
            }
        }


        public string Nombre { get; set; }
        public string Comunidad { get; set; }
        public string Entrenador { get; set; }

    }
}
