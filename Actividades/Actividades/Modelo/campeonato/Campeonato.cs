using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Modelo.campeonato
{
    class Campeonato
    {
        private int _id;
        private string _nombre;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;

        //Constructor default
        public Campeonato()
        {
            this._nombre = "Campeonato de la segunda division Doleondres";
            this._id = 1;

            for (int i = 1; i <= 20; i++)
            {
                Jornada j = new Jornada(i);
                _jornadas.Add(j);
            }

            
        }

        //Resultado de laasociacion entre campeonato y jornada
        private List<Jornada> _jornadas = new List<Jornada>();



        //Metodos Getter`s y Setter`s
        public int Id {
            get {
                return _id;
            }

            set {
            }
        }
        public string Nombre{
            get {
                return _nombre;
            }

            set {

            }
                    
         }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }


    }
}
