using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniRpg_2.characterBuilder.professions;

namespace MiniRpg_2.character.race
{
    public class Character : ICharacterBuilder
    {
        protected string sex;
        protected string name;
        protected string race;
        protected string raceDescription;
        public int hp;
        public int mp;
        public int atk;
        public int dex;
        public int mag;
        public int def;
        public int eva;
        public int speed;

        string professionName;
        string professionDescription;
        int weaponType;

        public Character()
        {
            name = "empty";
            sex = "empty";
            hp = 500;
            mp = 10;
            atk = 5;
            dex = 5;
            mag = 5;
            def = 5;
            eva = 5;
            speed = 5;
        }

        public void NameSelection(string _name)
        {
            name = _name;
        }

        public void SexSelection(int _sex)
        {
            switch (_sex)
            {
                case 0:
                    sex = "Hombre";
                    hp += 100;
                    def += 2;
                    break;

                case 1:
                    sex = "Mujer";
                    mp += 5;
                    eva += 5;
                    break;
            }
        }

        public string GetName() { return name; }
        public string GetSex() { return sex; }
        public string GetRace() {  return race; }
        public string GetRaceDescription() {  return raceDescription; }
        public string GetProfession() { return professionName; }
        public string GetProfessionDescription() { return professionDescription; }
       

        public void ProfessionSelection(Profession _profession)
        {
            professionName = _profession.professionName;
            professionDescription = _profession.professionDescription;

            hp += _profession.hp;
            mp += _profession.mp;
            atk += _profession.atk;
            mag += _profession.mag;
            def += _profession.def;
            eva += _profession.eva;
            speed += _profession.speed;
        }

    }


    public interface ICharacterBuilder
    {
        public void NameSelection(string name);
        public void SexSelection(int sex);
        public void ProfessionSelection(Profession _profession);

        public string GetName();
        public string GetSex();
        public string GetRace();
        public string GetRaceDescription();
        public string GetProfession();
        public string GetProfessionDescription();
    }


}