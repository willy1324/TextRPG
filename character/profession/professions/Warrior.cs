using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpg_2.character.profession.professions
{
    class Warrior : Vagabond
    {
        public Warrior()
        {
            professionName = "Guerrero";
            hp = 1000;
            mp = 20;
            atk = 10;
            dex = 5;
            mag = 3;
            def = 10;
            eva = 5;
            speed = 5;

            professionDescription = "Los Guerreros, conocidos por su fuerza imponente y su habilidad en el combate cuerpo a cuerpo,\n" +
                " son expertos en el arte de la guerra. Con una constitución robusta y una determinación inquebrantable,\n" +
                " pueden resistir los embates más feroces del enemigo. Su destreza en el campo de batalla se ve reflejada \n" +
                "en su impresionante poder de ataque, su resistencia formidable y su capacidad para proteger a sus aliados.\n" +
                " Aunque carecen de habilidades mágicas avanzadas, compensan esta limitación con su habilidad para desatar el caos\n" +
                " entre las filas enemigas y mantener el equilibrio en cualquier enfrentamiento.";

        }

    }
}
