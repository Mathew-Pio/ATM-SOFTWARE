using System;

public class cardholder
{
    string cardnum;
    int pin;
    string firstname;
    string lastname;
    double balance;

    public cardholder(string cardnum, int pin, string firstname, string lastname, double balance)
    {
        this.cardnum = cardnum;
        this.pin = pin;
        this.firstname = firstname;
        this.lastname = lastname;
        this.balance = balance;
    }
        

    public string GetCardNum()
    {
        return cardnum;
    }

    public int GetPin()
    {
        return pin;
    }

    public string GetFirstName()
    {
        return firstname;
    }

    public string GetLastname()
    {
        return lastname;
    }

    public double GetBalance()
    {
        return balance;
    }


    public void setnum(string newcardnum)
    {
        cardnum = newcardnum;
    }

    public void setpin(int newpin)
    {
        pin = newpin;
    }

    public void setfirstname(string newfirstname)
    {
        firstname = newfirstname;
    }

    public void setlastname(string newlastname)
    {
        lastname = newlastname;
    }

    public void setbalance(double newbalance)
    {
        balance = newbalance;
    }

    public static void Main(string[] args)
    {
        void options()
        {
            Console.WriteLine("Select from any of the options provided");
            Console.WriteLine("1. Deposit money");
            Console.WriteLine("2. Withdraw money");
            Console.WriteLine("3. Check balance");
            Console.WriteLine("4. exit");
        }

        

        void deposit(cardholder currentuser)
        {
            Console.WriteLine("How much will you like to deposit ? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentuser.setbalance(deposit);

            Console.WriteLine("Thank you for depositing your money. Your current balance is : " + currentuser.GetBalance());
        }

        void withdrawal(cardholder currentuser)
        {
            Console.WriteLine("How much will you like to Withdraw ? ");
            double amountwithdrawed = Double.Parse(Console.ReadLine());
            //check balance
            if (currentuser.GetBalance() < amountwithdrawed)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                Console.WriteLine("You have succesfull redrawn money ." );
                currentuser.setbalance(currentuser.GetBalance() - amountwithdrawed);
                Console.WriteLine("Thank you .");
            }

        }

        void balance(cardholder currentuser)
        {
            Console.WriteLine("Current balance :" + currentuser.GetBalance());
        }

        List<cardholder> cardholders = new List<cardholder>();
        cardholders.Add(new cardholder("73983988",1234 , "Brampy ", " cornelius ",96.98 ));
        cardholders.Add(new cardholder("09932303", 4289, "Frilp ", " dawn ", 89));
        cardholders.Add(new cardholder("32382390", 3378, "Peters ", " john ", 145));
        cardholders.Add(new cardholder("89839238", 9903, "Cash ", " chris ", 67.9));
        cardholders.Add(new cardholder("47834738", 8904, "Bush ", " chandler ", 86));

        Console.WriteLine("Welcome to simpleATM :)");
        Console.WriteLine("Please insert your debit card");

        string debitcardnum = "";
        cardholder currentuser;

        while (true)
        {
            try
            {
                debitcardnum = Console.ReadLine();
                currentuser = cardholders.FirstOrDefault(a => a.cardnum == debitcardnum);
                if(currentuser != null) { break; }
                else { Console.WriteLine("Card number is incorrect . Please try again"); }
            }
            catch
            {
                Console.WriteLine("Card number is incorrect . Please try again");
            }
        }

        Console.WriteLine("Enter your pin");
        int userpin = 0;

        while (true)
        {
            try
            {
                userpin =int.Parse(Console.ReadLine());
                if (currentuser.GetPin() == userpin) { break; }
                else { Console.WriteLine("Your pin is incorrect . Please try again"); }
            }
            catch
            {
                Console.WriteLine("Your pin is incorrect . Please try again");
            }
        }

        Console.WriteLine("Welcome " + currentuser.GetFirstName() + currentuser.GetLastname()  + " :)");
        int option = 0;

        do
        {
            options();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currentuser); }
            else if (option == 2) { withdrawal(currentuser); }
            else if (option == 3) { balance(currentuser); }
            else if (option == 4){ break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you have a nice day."); 



    }

}















