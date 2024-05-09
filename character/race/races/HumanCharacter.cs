using MiniRpg_2.character.race;
using MiniRpg_2.characterBuilder.professions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpg_2.character.race.races
{


    public class HumanCharacter : Character, ICharacterBuilder
    {
        public HumanCharacter()
        {
            atk += 5;
            dex += 5;
            mag += 5;

            race = "Humano";
            raceDescription = "Los Humanos, una de las razas más prolíficas y versátiles del mundo, son seres de diversidad" +
                " y determinación que prosperan en todos los rincones del reino. Con una herencia de adaptabilidad y creatividad," +
                " los Humanos son conocidos por su capacidad para enfrentar desafíos y forjar su propio destino.";
        }

    }
}
