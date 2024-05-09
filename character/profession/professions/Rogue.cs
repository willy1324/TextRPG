using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpg_2.character.profession.professions
{
    class Rogue : Vagabond
    {
        public Rogue()
        {
            professionName = "Picaro";
            hp = 400;
            mp = 10;
            atk = 5;
            dex = 15;
            mag = 6;
            def = 5;
            eva = 10;
            speed = 5;

            professionDescription = "Los Pícaros, hábiles en el arte del sigilo y la astucia, son expertos en el combate furtivo\n" +
                " y las artes ladinas. Con una destreza sin igual, son capaces de moverse silenciosamente entre las sombras y ejecutar\n" +
                " ataques sorpresa con precisión mortal. Aunque su constitución física es más frágil que la de otros guerreros, compensan\n" +
                " su falta de resistencia con una agilidad extraordinaria y una capacidad innata para evadir los golpes enemigos. ";

        }

    }
}
