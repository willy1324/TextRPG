using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpg_2.character.profession.professions
{
    class Mage : Vagabond
    {
        public Mage()
        {
            professionName = "Mago";
            hp = 200;
            mp = 40;
            dex = 5;
            mag = 10;
            def = 5;
            eva = 10;
            speed = 10;

            professionDescription = "Los Magos, maestros en el arte de la magia arcana, canalizan poderes ancestrales para manipular\n" +
                " las fuerzas elementales del mundo. Conocedores de los secretos del universo, son capaces de conjurar hechizos devastadores y\n" +
                " desencadenar tormentas de energía mística sobre sus enemigos. Aunque su constitución física es frágil y su resistencia limitada,\n" +
                " su dominio de las artes arcanas los convierte en adversarios temibles en el campo de batalla. ";

        }

    }
}
