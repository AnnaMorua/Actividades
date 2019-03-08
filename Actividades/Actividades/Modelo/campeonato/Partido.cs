using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Modelo.campeonato
{
    class Partido
    {
        private int _id;
        private string _descripcion;
        private DateTime _fecha;
        private string _observaciones;
        private bool _isFinalizado;
        //se asocia con la clase Cancha
        private Cancha _cancha;
        private Equipo _local;
        private Equipo _visitante;
        //Se asocia con arbitro
        //private Arbitro{} arbitros;
        private Arbitro _arbitro1;
        private Arbitro _arbitro2;

        public Partido()
        {
            this._isFinalizado = false;
            this._id = 1;
            Random alea = new Random();
            int dia = alea.Next(1, 31);
            this._fecha = new DateTime(2019, 3, 9, 16, 0, 0);
        }

        public Partido(Equipo equipo1, Equipo equipo2)
        {
            this._local = equipo1;
            this._visitante = equipo2;
        }
        public void addCancha(Cancha cancha)
        {
            this._cancha = cancha;
        }
        
        public Arbitro(Arbitro arbitro1, Arbitro arbitro2)
        {
            this._arbitro1 = arbitro1;
            this._arbitro2 = arbitro2;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public bool IsConcluida { get; set; }
        
    }
}
