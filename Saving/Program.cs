using System;
using System.IO;
using System.Xml.Serialization;

namespace Saving
{
    class Program
    {
        static void Main(string[] args)
        {
            Zombie z1 = new Zombie();

            int lyckad1 = 0;
            
            int ohp = 0;

            while (lyckad1!=1){
            Console.WriteLine("How much hp do you want the zombie to have?");

            string ihp = Console.ReadLine();

            bool lyckad = int.TryParse(ihp, out ohp);
            
            if (lyckad){
                lyckad1++;
            }
            }
            z1.x = ohp;

            //------------------------

            int lyckad2 = 0;
            
            int odmg = 0;

            while (lyckad2!=1){
              Console.WriteLine("How much dmg do you want the zombie to make?");

            string idmg = Console.ReadLine();

            bool lyckad = int.TryParse(idmg, out odmg);
            
            if (lyckad){
                lyckad2++;
            }
            }
            z1.y = odmg;

             //------------------------

            string hat;
            
            int lyckad3 = 0;

            while (lyckad3!=1){
            Console.WriteLine("Does the zombie have a hat?");
            
            hat = Console.ReadLine();
           
            if (hat == "yes"){
                z1.hat = true;
                lyckad3++;
            }
            if (hat == "no"){
                z1.hat = false;
                lyckad3++;
            }
             }

             XmlSerializer zombieSerializer = new XmlSerializer(typeof(Zombie));
             
             FileStream file = File.Open(@"zombie.xml", FileMode.OpenOrCreate);

             zombieSerializer.Serialize(file,z1);


        }
    }
}
