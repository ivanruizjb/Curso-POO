using System.Reflection.Metadata;
using System.Text;
using SuperHeroesApp;
using SuperHeroesApp.Models;

var imprimirInfo = new  ImprimirInfo();

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneración";
regeneracion.Descripcion = "Permite regenerar tejidos dañados, lo que otorga una curación rápida y resistencia a heridas.";
regeneracion.Nivel = NivelDePoder.NivelSeis;

var garrasAfiladas = new SuperPoder();
garrasAfiladas.Nombre = "Garras Afiladas";
garrasAfiladas.Descripcion = "Otorga garras afiladas que pueden cortar casi cualquier material, lo que es útil tanto para el combate como para la defensa.";
garrasAfiladas.Nivel = NivelDePoder.NivelCuatro;

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Permite volar a altas velocidades, lo que facilita el desplazamiento y la evasión de ataques.";
poderVolar.Nivel = NivelDePoder.NivelOcho;

var lanzarTelaraña = new SuperPoder();
lanzarTelaraña.Nombre = "Lanzar Telaraña";
lanzarTelaraña.Descripcion = "Permite lanzar telarañas para atrapar a los enemigos o balancearse entre edificios.";
lanzarTelaraña.Nivel = NivelDePoder.NivelCinco;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Otorga una fuerza sobrehumana, permitiendo levantar objetos pesados y derrotar a enemigos con facilidad.";
superFuerza.Nivel = NivelDePoder.NivelSiete;

var superman = new SuperHeroe();
superman.Id = 1;
superman.IdentidadSecreta = "Clark Kent";
superman.Nombre = "   Superman   ";
superman.Edad = 30;
superman.PuedeVolar = true;
imprimirInfo.ImprimirSuperHeroe(superman);

var spiderman = new SuperHeroe();
spiderman.Id = 2;
spiderman.IdentidadSecreta = "Piter Parker";
spiderman.Nombre = "SpiderMan";
spiderman.Edad = 18;
spiderman.PuedeVolar = false;
imprimirInfo.ImprimirSuperHeroe(spiderman);

var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.IdentidadSecreta = "Logan";
wolverine.Nombre = "Wolverine";
wolverine.Edad = 50;
wolverine.PuedeVolar = false;
imprimirInfo.ImprimirSuperHeroe(wolverine);

List<SuperPoder> poderesSpiderMan = new List<SuperPoder>();
poderesSpiderMan.Add(lanzarTelaraña);
poderesSpiderMan.Add(superFuerza);
spiderman.Poderes = poderesSpiderMan;
string resultPoderesSpiderMan = spiderman.UsarSuperPoder();
Console.WriteLine(resultPoderesSpiderMan);
string salvaLaTierraSpiderMan = spiderman.SalvarTierra();
Console.WriteLine(salvaLaTierraSpiderMan);

List<SuperPoder> poderesSuperMan = new List<SuperPoder>();
poderesSuperMan.Add(superFuerza);
poderesSuperMan.Add(poderVolar);
superman.Poderes = poderesSuperMan;
string resultPoderesSuperMan = superman.UsarSuperPoder();
Console.WriteLine(resultPoderesSuperMan);
string salvarElMundoSuperMan = superman.SalvarMundo();
Console.WriteLine(salvarElMundoSuperMan);

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(garrasAfiladas);
wolverine.Poderes = poderesWolverine;
string resultPoderesWolverine = wolverine.UsarSuperPoder();
Console.WriteLine(resultPoderesWolverine);
string accionAntiHeroe = wolverine.RealizarAccionAntiHeroe("Ataco la policia");
Console.WriteLine(accionAntiHeroe);
string asesinarVillano = wolverine.AsesinarVillano("Joker");
Console.WriteLine(asesinarVillano);
string explosion = wolverine.CausoUnaExplosion("Banco Central");
Console.WriteLine(explosion);
string usaPoderesWolverine = wolverine.UsarSuperPoder();
Console.WriteLine(usaPoderesWolverine);


enum NivelDePoder
    {
        NivelUno,
        NivelDos,
        NivelTres,
        NivelCuatro,
        NivelCinco,
        NivelSeis,
        NivelSiete,
        NivelOcho,
        NivelNueve,
        NivelDiez
    }

    public record SuperHeroeRecord(int Id, string Nombre, string NombreDeSuperHeroe);

