using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MiniRpg_2.character;

namespace MiniRpg_2.characterBuilder.professions
{

    public class Profession
    {
        public int hp;
        public int mp;
        public int atk;
        public int dex;
        public int mag;
        public int def;
        public int eva;
        public int speed;

        public string professionName;
        public string professionDescription;
        int weaponType;
    }

}
