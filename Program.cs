using System;
using System.Collections.Generic;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {
          
                Random i = new Random();
                Bank bank = new Bank()
                {
                    CashOnHand = i.Next(50000, 1000000),
                    AlarmScore = i.Next(0,100),
                    VaultScore = i.Next(0,100),
                    SecurityGuardScore= i.Next(0,100)
                 
                };
            
            List<IRobber> rolodex = new List<IRobber>();
            Muscle muscle1 = new Muscle()
            {
                Name = "Chad",
                SkillLevel = 50,
                PercentageCut = 25

            };
            rolodex.Add(muscle1);

            Muscle muscle2 = new Muscle()
            {
                Name = "Larry",
                SkillLevel = 60,
                PercentageCut = 25
            };
            rolodex.Add(muscle2);
            Hacker hacker1 = new Hacker()
            {
                Name = "Zip",
                SkillLevel = 40,
                PercentageCut = 25

            };
            rolodex.Add(hacker1);
            Hacker hacker2 = new Hacker()
            {
                Name = "Zeek",
                SkillLevel = 40,
                PercentageCut = 25

            };
            rolodex.Add(hacker2);
            LockSpecialist lock1 = new LockSpecialist()
            {
                Name = "Charles",
                SkillLevel = 70,
                PercentageCut = 50

            };
            rolodex.Add(lock1);
            LockSpecialist lock2 = new LockSpecialist()
            {
                Name = "Dave",
                SkillLevel = 45,
                PercentageCut = 25

            };
            rolodex.Add(lock2);
            void Create()
            {



                Console.WriteLine($"There are {rolodex.Count} members in your rolodex");
                Console.WriteLine("Add a new member");
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                if (name.Length > 0)
                {
                    Console.WriteLine(@"Choose a class >
                1) Hacker (Disables alarms)
                2) Muscle (Disarms guards)
                3)Lock Specialist (Cracks vault)");
                    int speciality = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(@"Enter skill level (between 1 and 100)");
                    int skill = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"Enter {name}'s cut of the cash. (between 1 and 100%)");
                    int cut = Int32.Parse(Console.ReadLine());
                    if (speciality == 1)
                    {
                        Hacker hacker3 = new Hacker()
                        {
                            Name = name,
                            SkillLevel = skill,
                            PercentageCut = cut
                        };
                        rolodex.Add(hacker3);
                    }
                    else if (speciality == 2)
                    {
                        Muscle muscle3 = new Muscle()
                        {
                            Name = name,
                            SkillLevel = skill,
                            PercentageCut = cut
                        };
                        rolodex.Add(muscle3);
                    }
                    else if (speciality == 3)
                    {
                        LockSpecialist lock3 = new LockSpecialist()
                        {
                            Name = name,
                            SkillLevel = skill,
                            PercentageCut = cut
                        };
                        rolodex.Add(lock3);
                    }
                    Create();
                }
                else
                {

                }
            }
           

            Create();
            Console.WriteLine("Lets recon the bank!");
             if (bank.AlarmScore > bank.VaultScore && bank.AlarmScore > bank.SecurityGuardScore)
            {
                Console.WriteLine("Most Secure: Alarm");
            }
            else if (bank.VaultScore > bank.AlarmScore && bank.VaultScore > bank.SecurityGuardScore)
            {
                Console.WriteLine("Most Secure: Vault");
            }
            else if (bank.SecurityGuardScore > bank.AlarmScore && bank.SecurityGuardScore > bank.VaultScore)
            {
                Console.WriteLine("Most Secure: Security");
            }
            if (bank.AlarmScore < bank.VaultScore && bank.AlarmScore < bank.SecurityGuardScore)
            {
                Console.WriteLine("Least Secure: Alarm");
            }
            else if (bank.VaultScore < bank.AlarmScore && bank.VaultScore < bank.SecurityGuardScore)
            {
                Console.WriteLine("Least Secure: Vault");
            }
            else if (bank.SecurityGuardScore < bank.AlarmScore && bank.SecurityGuardScore < bank.VaultScore)
            {
                Console.WriteLine("Least Secure: Security");
            }
        }


    }
}