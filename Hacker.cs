using System; 

namespace HeistPartII
{
    public class Hacker : IRobber
    {
        public string Name {get; set;}
       public  int SkillLevel {get;set;}
       public int PercentageCut {get;set;}
       
          public void PerformSkill(Bank bank)
        {
            int Skill = bank.AlarmScore - SkillLevel;
            bank.AlarmScore = Skill;
        }
         public string Specialty {get ;set; }
        public int id {get;set;}
    }
    
}