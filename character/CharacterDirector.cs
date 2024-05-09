using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniRpg_2.character.profession.professions;
using MiniRpg_2.character.race;
using MiniRpg_2.character.race.races;
using MiniRpg_2.characterBuilder.professions;

namespace MiniRpg_2.character
{
    public class CharacterDirector
    {
 
        Random randomNumber = new Random();
        RandomName names = new RandomName();

        public Character CreatePlayerCharacter()
        {
            Character newCharacter = new Character();

            bool finishCharacter = false;
            Console.WriteLine("Bienvenido ¿Quieres crear un personaje o deseas comenzar con uno ya creado? \n1- Comenzar desde 0 \n2- Personaje aleatorio\n ");
            string optionResult = Console.ReadLine();          

            while(!finishCharacter)
                if (optionResult == "1")
                {
                    CreateManualCharacter();                   
                    ShowStats(newCharacter);
                    Console.WriteLine("\n¿Deseas jugar con este personaje?   1- Si      2- No");
                    string Finishresult = Console.ReadLine();

                    if (Finishresult == "1") { finishCharacter = true; }
                    else if (Finishresult == "2") 
                    {
                        CreatePlayerCharacter();
                        Console.Clear();
                    }
                    else 
                    {
                        CreatePlayerCharacter();
                        Console.Clear();
                        Console.WriteLine("Escribe una opcion correcta\n"); 
                    }
                }

                else if (optionResult == "2")
                {
                    newCharacter = CreateRandomCharacter();
                    ShowStats(newCharacter);
                    Console.WriteLine("\n¿Deseas jugar con este personaje?   1- Si      2- No");
                    string Finishresult = Console.ReadLine();

                    if (Finishresult == "1") { finishCharacter = true; }
                    else if (Finishresult == "2") { CreatePlayerCharacter(); }
                    else { Console.WriteLine("Escribe una opcion correcta"); }
                    
                }

            return newCharacter;
        }

        void CreateManualCharacter()
        {
            Console.WriteLine("Escribe el nombre del personaje");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Elige el sexo del personaje: \n1- Hombre    2- Mujer");
            int sex = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Elige la raza personaje: \n1- Humano    2- Elfo    3- Orco   4-Elfo Oscuro");
            int race = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Elige la profesion personaje: \n1- Guerrero    2- Picaro    3- Mago   4- Bardo");
        //    int profession = Convert.ToInt32(Console.ReadLine());
        //    newCharacter = new Character(name, profession, race, sex);
        //    Console.Clear();
        }


        void ShowStats(Character newCharacter)
        {
            Console.WriteLine($"\nNombre: {newCharacter.GetName()}" +
                                  $"\nSexo: {newCharacter.GetSex()}" +
                                  $"\nRaza: {newCharacter.GetRace()}" +
                                  $"\nDescripcion: {newCharacter.GetRaceDescription()}" +
                                  $"\n\nProfesion: {newCharacter.GetProfession()}" +
                                  $"\nDescripcion: {newCharacter.GetProfessionDescription()}" +
                                  $"\n\nVida: {newCharacter.hp}" +
                                  $"\nMana: {newCharacter.mp}" +
                                  $"\nAtaque: {newCharacter.atk}" +
                                  $"\nDestreza: {newCharacter.dex}" +
                                  $"\nMagia: {newCharacter.mag}" +
                                  $"\nDefensa: {newCharacter.def}" +
                                  $"\nEvasion: {newCharacter.eva}" +
                                  $"\n: {newCharacter.speed}");
        }

        public Character CreateRandomCharacter()
        {
            Character newCharacter = new Character();
            Profession profession = new Vagabond();

            int sexSelector = randomNumber.Next(0, 2);
            int raceSelector = randomNumber.Next(0, 3);
            //int profSelector = randomNumber.Next(0, 4);                       
            int nameSelector = randomNumber.Next(0, 15);

            //Seleccion de sexo
            newCharacter.SexSelection(sexSelector);

            //Selecciona la raza
            switch (raceSelector)
            {
                case 0: newCharacter = new HumanCharacter(); break;
                case 1: newCharacter = new ElfCharacter(); break;
                case 2: newCharacter = new OrcCharacter(); break;
                case 3: newCharacter = new DarkElfCharacter(); break;                  
            }

            //Seleccion de profesion
            newCharacter.ProfessionSelection(profession);

            //Seleccion de nombre
            string[,] nameListSelected = names.characterName[raceSelector];
            newCharacter.NameSelection(nameListSelected[nameSelector, sexSelector]);

            return newCharacter;
        }

    }
}
