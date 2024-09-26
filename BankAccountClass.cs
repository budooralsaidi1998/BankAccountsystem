

using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Banksystem
{
    public class BankAccountClass
    {

        public string AccountNumber { get; private set; };
        public string AccountHolderName { get; private set; };
        public decimal Balance { get; private set; }
       

      

        public  BankAccountClass(string accountNumber ,string accountholdername )
        {
            AccountNumber=accountNumber;
            AccountHolderName=accountholdername;
            this.AccountNumber = ;
              
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
           
            Console.WriteLine("enter the moun")
              = +Balance;
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
