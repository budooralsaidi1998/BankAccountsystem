

using System.Collections.Specialized;

namespace Banksystem
{
    public class BankClass
    {

    List<BankAccountClass>BankAccount =new List<BankAccountClass>();

    public void AddAccount()
        {

            Console.WriteLine("enter the name account :");
            string name = Console.ReadLine();
            Console.WriteLine("enter the number account :");
            string numberaccount= Console.ReadLine();

            BankAccount.Add(new BankAccountClass(100,name, numberaccount));

        }

        public void getAccountByNumberAccount()
        {

        }








    }
}
