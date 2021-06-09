using System;

namespace HeistPartII
{

    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            int skill = bank.VaultScore - SkillLevel;
          bank.VaultScore = skill;
        }
         public string Specialty {get ;set; }
        public int id {get;set;}

    }
}