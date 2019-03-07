using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades.Modelo.campeonato
{
    class Jugador
    {
        private int _id;
        private string _nombre;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private byte _numero;
        private Equipo _idEquipo;
        public Jugador()
        {
            this._nombre = "Papulince";
            this._apellidos = "Del campo de la via lactea";
            this._fechaNacimiento = DateTime.Today;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte Numero { get; set; }
        public Equipo IdEquipo
        {
            get
            {
                return this._idEquipo;
            }
            set
            {
                if(value != null || ((Equipo)value).Nombre.ToLower().Equals("llanito"))
                {
                    this._idEquipo = value;
                }
            }
        }

    }
}
