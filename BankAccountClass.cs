

namespace Banksystem
{
    public class BankAccountClass
    {

        private string AccountNumber;
        private string AccountHolderName;
        private decimal Balance;

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

        public void deposit()
        {

        }




    }
}
