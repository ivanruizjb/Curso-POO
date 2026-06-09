using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelDePoder Nivel;

        public SuperPoder()
        {
            Nivel = NivelDePoder.NivelUno;
        }
    }

}
