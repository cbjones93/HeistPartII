using System;
using System.Collections.Generic;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();
            void Create()
            {
            Muscle muscle1 = new Muscle()
            {
                Name = "Chad",
                SkillLevel= 50,
                PercentageCut= 25

            };
           rolodex.Add(muscle1);
         
            Muscle muscle2 = new Muscle()
                {
                Name = "Larry",
                SkillLevel= 60,
                PercentageCut= 25
            };
             rolodex.Add(muscle2);
            Hacker hacker1 = new Hacker()
             {
                Name = "Zip",
                SkillLevel= 40,
                PercentageCut= 25

            };
             rolodex.Add(hacker1);
            Hacker hacker2 = new Hacker()
             {
                Name = "Zeek",
                SkillLevel= 40,
                PercentageCut= 25

            };
            rolodex.Add(hacker2);
            LockSpecialist lock1 = new LockSpecialist()
             {
                Name = "Charles",
                SkillLevel= 70,
                PercentageCut= 50

            };
            rolodex.Add(lock1);
            LockSpecialist lock2 = new LockSpecialist()
             {
                Name = "Dave",
                SkillLevel= 45,
                PercentageCut= 25

            };
            rolodex.Add(lock2);
            }
            Create();
            Console.WriteLine($"There are {rolodex.Count} members in your rolodex");

          

        }
    }

}