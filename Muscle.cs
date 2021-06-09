using System; 

namespace HeistPartII
{
    
    public class Muscle : IRobber
    {
        public string Name {get; set;}
       public  int SkillLevel {get;set;}
       public int PercentageCut {get;set;}
       
          public void PerformSkill(Bank bank)
        {
            int Skill = bank.SecurityGuardScore - SkillLevel;
            bank.SecurityGuardScore = Skill;
        }
        public string Specialty {get ;set; }
        public int id {get;set;}
    }
}