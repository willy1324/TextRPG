using MiniRpg_2.character.race;
using MiniRpg_2.characterBuilder.professions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpg_2.character.race.races
{
    public class OrcCharacter : Character, ICharacterBuilder
    {

        public OrcCharacter()
        {
            hp += 1000;
            def += 5;
            atk += 2;

            race = "Orco";
            raceDescription = "Los Orcos, conocidos por su imponente presencia y su feroz naturaleza, son una raza de criaturas robustas y poderosas" +
                " que emergen de las tierras salvajes y montañosas. Con una constitución física formidable y una determinación inquebrantable," +
                " los Orcos han forjado una reputación como guerreros indomables";
        }

    }
}
