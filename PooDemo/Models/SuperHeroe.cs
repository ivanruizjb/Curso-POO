using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _Nombre; 
        public int Id { get; set; } = 1;
        public string IdentidadSecreta { get; set; }
        public override string Nombre
          {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();
            }
        }

        public string NombreEIdentidadSecreta
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta}) ";
            }
        }

        public int Edad { get; set; }
        public List<SuperPoder> Poderes;
        public bool PuedeVolar { get; set; }

        public SuperHeroe()
        {
            Id = 1;
            Poderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public virtual string UsarSuperPoder()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Poderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} tiene el poder de {item.Nombre}");
            }

            return sb.ToString();
        }
        public override string SalvarMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salavado el mundo!";
        }

        public override string SalvarTierra()
        {
            return $"{NombreEIdentidadSecreta} ha salavado la tierra!";
        }


    }

}





