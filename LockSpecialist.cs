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
            int Skill = bank.VaultScore - SkillLevel;
        }

    }
}