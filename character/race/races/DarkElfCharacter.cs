using MiniRpg_2.character.race;
using MiniRpg_2.characterBuilder.professions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpg_2.character.race.races
{
    public class DarkElfCharacter : Character, ICharacterBuilder
    {
        public DarkElfCharacter()
        {
            dex += 5;
            eva += 5;
            speed += 5;

            race = "Elfo Oscuro";
            raceDescription = "Los Elfos Oscuros, son una raza misteriosa y enigmática que habita en las regiones más sombrías y" +
                " siniestras del mundo. Se distinguen por su piel pálida y sus ojos penetrantes, que reflejan la oscuridad de sus almas." +
                " Son seres elegantes y ágiles, pero suelen ser vistos con desconfianza por otras razas debido a su reputación de astucia y crueldad.";
        }

    }
}
