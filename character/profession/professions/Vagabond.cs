using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniRpg_2.characterBuilder.professions;

namespace MiniRpg_2.character.profession.professions
{
    public class Vagabond : Profession
    {
        public Vagabond()
        {
            professionName = "Vagabundo";
            hp = 1000;
            mp = 50;
            atk = 10;
            dex = 10;
            mag = 10;
            def = 10;
            eva = 10;
            speed = 10;

            professionDescription = "Los Vagabundos, conocidos por su naturaleza nómada y su espíritu aventurero,\n" +
                " sin un lugar fijo al que llamar hogar, recorren los caminos polvorientos y las tierras salvajes en busca de su destino.\n" +
                " Aunque carecen de experiencia y habilidades especializadas, su determinación y curiosidad los impulsan a enfrentar \n" +
                "los desafíos que se les presentan.";

        }

    }
}
