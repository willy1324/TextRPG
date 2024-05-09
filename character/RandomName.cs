using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRpg_2.character
{
    public class RandomName
    {
        string[,] humanCharacterNames = new string[15, 15];
        string[,] elfCharacterNames = new string[15, 15];
        string[,] orcCharacterNames = new string[15, 15];
        string[,] darkElfCharacterNames = new string[15, 15];

        public List<string[,]> characterName = new List<string[,]>();

        public RandomName()
        {
            AddHumanCharacterNames();
            AddElfCharacterNames();
            AddOrcCharacterNames();
            AddDarkElfCharacterNames();

            characterName.Add(humanCharacterNames);
            characterName.Add(elfCharacterNames);
            characterName.Add(orcCharacterNames);
            characterName.Add(darkElfCharacterNames);
        }

        void AddHumanCharacterNames()
        {
            //Nombres masculinos
            humanCharacterNames[0, 0] = "Lordan";
            humanCharacterNames[1, 0] = "Aldric";
            humanCharacterNames[2, 0] = "Thaddeus";
            humanCharacterNames[3, 0] = "Cedric";
            humanCharacterNames[4, 0] = "Roland";
            humanCharacterNames[5, 0] = "Leofric";
            humanCharacterNames[6, 0] = "Alistair";
            humanCharacterNames[7, 0] = "Gideon";
            humanCharacterNames[8, 0] = "Percival";
            humanCharacterNames[9, 0] = "Cormac";
            humanCharacterNames[10, 0] = "Lucian";
            humanCharacterNames[11, 0] = "Tristan";
            humanCharacterNames[12, 0] = "Alaric";
            humanCharacterNames[13, 0] = "Emeric";
            humanCharacterNames[14, 0] = "Darian";

            //Nombres femeninos
            humanCharacterNames[0, 1] = "Eleanor";
            humanCharacterNames[1, 1] = "Isolde";
            humanCharacterNames[2, 1] = "Guinevere";
            humanCharacterNames[3, 1] = "Adelaide";
            humanCharacterNames[4, 1] = "Elowen";
            humanCharacterNames[5, 1] = "Aveline";
            humanCharacterNames[6, 1] = "Rosamund";
            humanCharacterNames[7, 1] = "Clarissa";
            humanCharacterNames[8, 1] = "Rowena";
            humanCharacterNames[9, 1] = "Celestia";
            humanCharacterNames[10, 1] = "Genevieve";
            humanCharacterNames[11, 1] = "Seraphina";
            humanCharacterNames[12, 1] = "Lysandra";
            humanCharacterNames[13, 1] = "Rhiannon";
            humanCharacterNames[14, 1] = "Felicity";
        }

        void AddElfCharacterNames()
        {
            //Nombres masculinos
            elfCharacterNames[0, 0] = "Legolas";
            elfCharacterNames[1, 0] = "Galadriel";
            elfCharacterNames[2, 0] = "Thranduil";
            elfCharacterNames[3, 0] = "Celeborn";
            elfCharacterNames[4, 0] = "Arwen";
            elfCharacterNames[5, 0] = "Elrond";
            elfCharacterNames[6, 0] = "Haldir";
            elfCharacterNames[7, 0] = "Glorfindel";
            elfCharacterNames[8, 0] = "Lúthien";
            elfCharacterNames[9, 0] = "Legolin";
            elfCharacterNames[10, 0] = "Elenion";
            elfCharacterNames[11, 0] = "Fëanor";
            elfCharacterNames[12, 0] = "Finrod";
            elfCharacterNames[13, 0] = "Galadhon";
            elfCharacterNames[14, 0] = "Gil-galad";

            //Nombres femeninos
            elfCharacterNames[0, 1] = "Aranel";
            elfCharacterNames[1, 1] = "Aredhel";
            elfCharacterNames[2, 1] = "Arwen";
            elfCharacterNames[3, 1] = "Celebrian";
            elfCharacterNames[4, 1] = "Earwen";
            elfCharacterNames[5, 1] = "Elwing";
            elfCharacterNames[6, 1] = "Idril";
            elfCharacterNames[7, 1] = "Lalaith";
            elfCharacterNames[8, 1] = "Lúthien";
            elfCharacterNames[9, 1] = "Melian";
            elfCharacterNames[10, 1] = "Nellas";
            elfCharacterNames[11, 1] = "Nimrodel";
            elfCharacterNames[12, 1] = "Tinúviel";
            elfCharacterNames[13, 1] = "Voronwë";
            elfCharacterNames[14, 1] = "Yavanna";
        }

        void AddOrcCharacterNames()
        {
            //Nombres masculinos
            orcCharacterNames[0, 0] = "Gorbag";
            orcCharacterNames[1, 0] = "Shagrat";
            orcCharacterNames[2, 0] = "Uglúk";
            orcCharacterNames[3, 0] = "Gothmog";
            orcCharacterNames[4, 0] = "Grishnákh";
            orcCharacterNames[5, 0] = "Azog";
            orcCharacterNames[6, 0] = "Bolg";
            orcCharacterNames[7, 0] = "Lurtz";
            orcCharacterNames[8, 0] = "Bolg";
            orcCharacterNames[9, 0] = "Gollum";
            orcCharacterNames[10, 0] = "Shelob";
            orcCharacterNames[11, 0] = "Mauhúr";
            orcCharacterNames[12, 0] = "Snaga";
            orcCharacterNames[13, 0] = "Gorbag";
            orcCharacterNames[14, 0] = "Warg";

            //Nombres femeninos
            orcCharacterNames[0, 1] = "Shelob";
            orcCharacterNames[1, 1] = "Gollum";
            orcCharacterNames[2, 1] = "Ufthak";
            orcCharacterNames[3, 1] = "Grishnákh";
            orcCharacterNames[4, 1] = "Gorbag";
            orcCharacterNames[5, 1] = "Shagrat";
            orcCharacterNames[6, 1] = "Snaga";
            orcCharacterNames[7, 1] = "Lagduf";
            orcCharacterNames[8, 1] = "Mauhúr";
            orcCharacterNames[9, 1] = "Gimghash";
            orcCharacterNames[10, 1] = "Ghân-buri-Ghân";
            orcCharacterNames[11, 1] = "Lagdush";
            orcCharacterNames[12, 1] = "Dushnak";
            orcCharacterNames[13, 1] = "Rûk";
            orcCharacterNames[14, 1] = "Gûndabald";
        }

        void AddDarkElfCharacterNames()
        {
            //Nombres masculinos
            darkElfCharacterNames[0, 0] = "Malekith";
            darkElfCharacterNames[1, 0] = "Morathi";
            darkElfCharacterNames[2, 0] = "Hellebron";
            darkElfCharacterNames[3, 0] = "Lokhir";
            darkElfCharacterNames[4, 0] = "Rakarth";
            darkElfCharacterNames[5, 0] = "Kouran";
            darkElfCharacterNames[6, 0] = "Tullaris";
            darkElfCharacterNames[7, 0] = "Dreadlord";
            darkElfCharacterNames[8, 0] = "Darkshards";
            darkElfCharacterNames[9, 0] = "Witch Elves";
            darkElfCharacterNames[10, 0] = "Executioners";
            darkElfCharacterNames[11, 0] = "Har Ganeth";
            darkElfCharacterNames[12, 0] = "Karond";
            darkElfCharacterNames[13, 0] = "Beastmaster";
            darkElfCharacterNames[14, 0] = "Bleak";

            //Nombres femeninos
            darkElfCharacterNames[0, 1] = "Sorceress";
            darkElfCharacterNames[1, 1] = "Crone";
            darkElfCharacterNames[2, 1] = "Shadowblade";
            darkElfCharacterNames[3, 1] = "High Beastmaster";
            darkElfCharacterNames[4, 1] = "Dreadlord";
            darkElfCharacterNames[5, 1] = "Kouran";
            darkElfCharacterNames[6, 1] = "Lokhir";
            darkElfCharacterNames[7, 1] = "Tullaris";
            darkElfCharacterNames[8, 1] = "Dreadlord";
            darkElfCharacterNames[9, 1] = "Witch Elve";
            darkElfCharacterNames[10, 1] = "Executioner";
            darkElfCharacterNames[11, 1] = "Har Ganeth";
            darkElfCharacterNames[12, 1] = "Karond";
            darkElfCharacterNames[13, 1] = "Beastmaster";
            darkElfCharacterNames[14, 1] = "Bleak";
        }

    }
}
