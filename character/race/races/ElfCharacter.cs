using MiniRpg_2.character.race;
using MiniRpg_2.characterBuilder.professions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpg_2.character.race.races
{
    public class ElfCharacter : Character, ICharacterBuilder
    {
        public ElfCharacter()
        {
            dex += 5;
            mp += 15;
            mag += 5;

            race = "Elfo";
            raceDescription = "Los Elfos, seres de gracia etérea y sabiduría ancestral, son una raza de seres inmortales" +
                " que habitan en los bosques antiguos y los reinos élficos ocultos. Con una conexión innata con la naturaleza" +
                " y un dominio sobre las artes arcanas, los Elfos encarnan la elegancia y la magia";
        }

    }
}
