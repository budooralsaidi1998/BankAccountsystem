

using System.ComponentModel.Design;

namespace Banksystem
{
    public class BankAccountClass
    {

        private string AccountNumber;
        private string AccountHolderName;
        public decimal Balance { get; private set; }
        public static decimal balanceamount = 0;


        public  BankAccountClass(string accountNumber ,string accountholdername )
        {
            AccountNumber=accountNumber;
            AccountHolderName=accountholdername;
        }

        public BankAccountClass(decimal initialdeposit, string accountNumber, string accountholdername)
        {
            Balance = initialdeposit;
            AccountNumber = accountNumber;
            AccountHolderName = accountholdername;
          
            


        }
        //increase blanace
        public void deposit()
        {
           
            
                balanceamount = +Balance;
                Console.WriteLine($"the balance after deposir : {balanceamount}");
            

        }

        public void withdrow()
        {
            if (Balance > 5) 
            { 
            balanceamount = -Balance;
            Console.WriteLine($"the balance after withdrow : {balanceamount}");
            }
            else
            {
                Console.WriteLine(" is insufficient balance");
            }
        
        }
        public void GetAccountInfo(decimal initialdeposit, string accountNumber, string accountholdername)
        {
            Console.WriteLine($"the account number : {accountNumber}");
            Console.WriteLine($"the account holder name : {accountholdername}");
            Console.WriteLine($"the balance : {initialdeposit}");
        }



    }
}
