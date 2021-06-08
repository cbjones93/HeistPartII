using System;

namespace HeistPartII
{
    public class Bank
    {
        public int CashOnHand {get;set;}
        
        public int AlarmScore {get;set;}
        
        public int VaultScore {get;set;}
        
        public int SecurityGuardScore {get;set;}

        public bool IsSecure()
        {
            if(CashOnHand >0)
            {
                return true;
            }
            else if(AlarmScore >0)
             {
                return true;
            }
            else if (VaultScore >0)
             {
                return true;
            }
            else if (SecurityGuardScore >0)
             {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}