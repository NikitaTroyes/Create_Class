using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();

            Character character2 = new Character();

            character.Name = "a";
            character.LifePoint = 100;
            character.Force = 25;
            character.Defense = 10;

            character2.Name = "b";
            character2.LifePoint = 150;
            character2.Force = 15;
            character2.Defense = 10;
            //character.IsAlive();


            
                while (character.LifePoint > 0 && character2.LifePoint > 0)
                {
                    character.Attack(character2);
                    character2.Attack(character);

                    Console.WriteLine("Pv of a remaining : " + character.LifePoint);
                    Console.WriteLine("Pv of b remaining : " + character2.LifePoint);

                }
            
         


            Console.ReadLine();







        }
    }

    public class Character
    {
        public string Name;

        public int LifePoint;

        public int Force;

        public int Defense;

        public bool IsAlive()
        {
            if (LifePoint > 0)
            {
                Console.WriteLine(Name + " is alive !");
                return true;

            }

            else

            {
                Console.WriteLine(Name + "is dead !");
                return false;
            }


        }

        public int Attack(Character Character2)
        {
            {
                int fd = Force - Character2.Defense;
           
                if (fd >0)
                {
                    Character2.LifePoint = Character2.LifePoint - (fd);
                }

               

                return Character2.LifePoint;




            }


        }
    }
}

