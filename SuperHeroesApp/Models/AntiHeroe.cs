using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionAntiHeroe(string accion)
        {
            return $"El Antiheroe {NombreEIdentidadSecreta} {accion}";
        }
        
        public string AsesinarVillano(string nombreVillano)
        {
            return $"El Antiheroe {NombreEIdentidadSecreta} ha asesinado al villano {nombreVillano}";
        }
        public string CausoUnaExplosion(string lugar)
        {
            return $"El Antiheroe {NombreEIdentidadSecreta} ha causado una explosion en {lugar}";
        }
        public override string UsarSuperPoder()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Poderes)
            {
                sb.AppendLine($"{Nombre} usa {item.Nombre} de una forma cool.");
            }

            return sb.ToString();
        }
    }
}
