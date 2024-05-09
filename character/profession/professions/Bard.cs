using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpg_2.character.profession.professions
{
    class Bard : Vagabond
    {
        public Bard()
        {
            professionName = "Bardo";
            hp = 400;
            mp = 20;
            atk = 8;
            dex = 15;
            mag = 9;
            def = 5;
            eva = 10;
            speed = 10;

            professionDescription = "Los Pícaros, hábiles en el arte del sigilo y la astucia, son expertos en el combate furtivo\n" +
                " y las artes ladinas. Con una destreza sin igual, son capaces de moverse silenciosamente entre las sombras y ejecutar\n" +
                " ataques sorpresa con precisión mortal. Aunque su constitución física es más frágil que la de otros guerreros, compensan\n" +
                " su falta de resistencia con una agilidad extraordinaria y una capacidad innata para evadir los golpes enemigos. ";

        }

    }
}
