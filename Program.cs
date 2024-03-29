﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IRobber> crew = new List<IRobber>();

            Random i = new Random();
            Bank bank = new Bank()
            {
                CashOnHand = i.Next(50000, 1000000),
                AlarmScore = i.Next(0, 100),
                VaultScore = i.Next(0, 100),
                SecurityGuardScore = i.Next(0, 100)

            };

            List<IRobber> rolodex = new List<IRobber>();
            Muscle muscle1 = new Muscle()
            {
                Name = "Chad",
                SkillLevel = 50,
                PercentageCut = 25,
                Specialty = "Muscle",
                id = 1

            };
            rolodex.Add(muscle1);

            Muscle muscle2 = new Muscle()
            {
                Name = "Larry",
                SkillLevel = 60,
                PercentageCut = 25,
                Specialty = "Muscle",
                id = 2
            };
            rolodex.Add(muscle2);
            Hacker hacker1 = new Hacker()
            {
                Name = "Zip",
                SkillLevel = 40,
                PercentageCut = 25,
                Specialty = "Hacker",
                id = 3

            };
            rolodex.Add(hacker1);
            Hacker hacker2 = new Hacker()
            {
                Name = "Zeek",
                SkillLevel = 40,
                PercentageCut = 25,
                Specialty = "Hacker",
                id = 4

            };
            rolodex.Add(hacker2);
            LockSpecialist lock1 = new LockSpecialist()
            {
                Name = "Charles",
                SkillLevel = 70,
                PercentageCut = 50,
                Specialty = "Lock Specialist",
                id = 5

            };
            rolodex.Add(lock1);
            LockSpecialist lock2 = new LockSpecialist()
            {
                Name = "Dave",
                SkillLevel = 45,
                PercentageCut = 25,
                Specialty = "Lock Specialist",
                id = 6

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
                            PercentageCut = cut,
                            Specialty = "Hacker",
                            id = rolodex.Count() + 1
                        };
                        rolodex.Add(hacker3);
                    }
                    else if (speciality == 2)
                    {
                        Muscle muscle3 = new Muscle()
                        {
                            Name = name,
                            SkillLevel = skill,
                            PercentageCut = cut,
                            Specialty = "Muscle",
                            id = rolodex.Count() + 1
                        };
                        rolodex.Add(muscle3);
                    }
                    else if (speciality == 3)
                    {
                        LockSpecialist lock3 = new LockSpecialist()
                        {
                            Name = name,
                            SkillLevel = skill,
                            PercentageCut = cut,
                            Specialty = "Lock Specialist",
                            id = rolodex.Count() + 1
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
            bool crewSelection = true;
            while (crewSelection)
            {
                Console.WriteLine($"Now select your crew!");
                int index = 1;
                int memberCut = 0;
                var selectedCrew = rolodex.Except(crew).ToList();
                foreach (IRobber member in selectedCrew)
                {
                    Console.Write($"{index}) ");
                    Console.WriteLine($" Id: {member.id} Name: {member.Name} || Speciality : {member.Specialty}  || Skill Level:{member.SkillLevel} || Cut of the loot: {member.PercentageCut}%");

                    index++;
                }
                Console.WriteLine("Enter the index of the crewmember you would like to add to your crew...");
                string selectedmember = Console.ReadLine();
                if (selectedmember == "")
                {
                    break;
                }

                foreach (IRobber member in crew)
                {
                    memberCut += member.PercentageCut;
                }
                if (memberCut < 100)
                {
                    crew.Add(selectedCrew[Int32.Parse(selectedmember) - 1]);
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine($"Current team's cut is {memberCut}");
                    Console.WriteLine("-----------------------------------");

                }
                else
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine($"Their cut is too high (Cannot go above 100%). Current team's cut is {memberCut}");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Play with team? (y/n)");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        crewSelection = false;
                    }
                }




            }
            Console.WriteLine("Your crew:");
            foreach (IRobber member in crew)
            {
                Console.WriteLine($" Id: {member.id} Name: {member.Name} || Speciality : {member.Specialty}  || Skill Level:{member.SkillLevel} || Cut of the loot: {member.PercentageCut}%");
            }
            Console.WriteLine("LETS GO!");
            foreach (IRobber member in crew)
            {
                member.PerformSkill(bank);
            }
            if (bank.IsSecure())
            {
                Console.WriteLine("STRAIGHT TO JAIL");
            }
            else
            {
                Console.WriteLine("You win!!!!");
                Console.WriteLine("Here is each member's cut:");
                int leftoverCash = bank.CashOnHand;
                foreach (IRobber member in crew)
                {
                    Console.Write($"Name: {member.Name} $");
                    Console.WriteLine(bank.CashOnHand / member.PercentageCut);
                    leftoverCash -= (bank.CashOnHand/member.PercentageCut);
                }
                Console.Write("Money left over: $");
                Console.Write(leftoverCash);

            }

        }


    }
}