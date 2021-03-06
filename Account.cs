using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountdetails
{
    internal class Account
    {
		private int accountNo, accountBalance;
		private static string bankName;
		private string accountPassword;

		public virtual int AccountNo { get; set; }

		public virtual int AccountBalance { get; set; }


		public virtual int getbankName()
		{

			return accountBalance;
		}

		public virtual void setbankName(string bbn)
		{
			bankName = bbn;
		}

		public virtual string AccountPassword
		{
			set
			{
				this.accountPassword = value;
			}
		}
		public virtual void display()
		{
			Console.Write("\n Your account no. is : " + accountNo);
			Console.Write("\n Your account balance is: " + accountBalance);
			Console.Write("\n Your Bank name is : " + bankName);
		}


		public static void Main(string[] args)
		{
			SavingAccount1 obj = new SavingAccount1();
			CurrentAccount obj1 = new CurrentAccount();
			obj.display(345678);
			obj1.display(631289);
		}
	}

	internal class SavingAccount1 : Account
	{
		internal int minimumBalance;
		public virtual void display(int minimumBalance)
		{
			Console.Write("\n Your minimum Balance is : " + minimumBalance);
		}
	}

	internal class CurrentAccount : Account
	{
		internal int overdraftLimitAmount;
		public virtual void display(int overdraftLimitAmount)
		{
			overdraftLimitAmount = 7575;
			Console.Write("\n Your Overdraft limit Amount : " + overdraftLimitAmount);
		}
	}
}

