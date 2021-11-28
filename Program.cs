using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Randomdata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tarolo = new List<string>();
            foreach (var item in File.ReadAllLines("randomwords.txt"))
            {
                tarolo.Add(item);
            }
            Random v1 = new Random();

            Console.WriteLine(tarolo.Count());

            HashSet<string> dolgok = new HashSet<string>();
            dolgok.Add("INSERT INTO `users`(`userName`, `userEmail`, `userPassword`, `userHighscore`, `userRank`, `userElo`) VALUES");
            for (int i = 0; i < 1000; i++)
            {
                int elsoszam = v1.Next(1, 280);
                int masodikszam = v1.Next(1, 280);
                int randomemail = v1.Next(1, 4);
                int randomhighscore = v1.Next(1000, 100000);
                int randomelo = v1.Next(10, 10000);
                int randomrank = v1.Next(1, 11);
                string email = "";
                string rank = "";
                switch (randomemail)
                {
                    case 1:
                        email = "@gmail.com";
                        break;
                    case 2:
                        email = "@yahoomail.com";
                        break;
                    case 3:
                        email = "@outlook.com";
                        break;
                    case 4:
                        email = "@freemail.hu";
                        break;
                }
                switch (randomrank)
                {
                    case 1:
                        rank = "Iron";
                        break;
                    case 2:
                        rank = "Bronze";
                        break;
                    case 3:
                        rank = "Silver";
                        break;
                    case 4:
                        rank = "Gold";
                        break;
                    case 5:
                        rank = "Plat";
                        break;
                    case 6:
                        rank = "Diamond";
                        break;
                    case 7:
                        rank = "Master";
                        break;
                    case 9:
                        rank = "Grandmaster";
                        break;
                    case 10:
                        rank = "Runner";
                        break;
                }
                string username = tarolo[elsoszam] + tarolo[masodikszam];
                    dolgok.Add($"('{username}','{tarolo[elsoszam] + tarolo[masodikszam] + email}','{tarolo[elsoszam] + tarolo[masodikszam]}',{randomhighscore},'{rank}',{randomelo}),");



            }


            foreach (var item in dolgok)
            {
                Console.WriteLine(item);
            }

            File.WriteAllLines("randomusers.txt", dolgok);
            Console.ReadKey();
        }
    }
}
