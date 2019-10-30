using System;
using System.Text.RegularExpressions;

namespace Lab7RegularExpressions
{
    class Program
    {
        //EMAIL
        static public bool validEmail(string email)
        {
            return Regex.IsMatch(email, @"[A-Za-z0-9]{5,30}@{1}[A-Za-z]{5,10}\.{1}[A-Za-z]{2,3}$");
        }
       
        // NAME
        static public bool validName(string name)
        {
            return Regex.IsMatch(name, "([A-Z]{1}[a-z]{1,30}\\s{1}[A-Z]{1}[a-z]{1,30})");
        }
     
        // PHONE NUMBER
        static public bool validPhone(string phone)
        {
            return Regex.IsMatch(phone, @"([0-9]{3}\-{1}[0-9]{3}\-[0-9]{4}$)");
        }
      
        // DATE
        static public bool validDate(string date)
        {
           return Regex.IsMatch(date, @"(0[1-9]|[12][0-9]|3[01])[ /](0[1-9]|1[012])[ /](19|20)\d\d$");
        }

        static void Main(string[] args)  // MAIN METHOD***********
        {

  ////EMAIL***********************
  
          Console.WriteLine("ENTER YOUR EMAIL");  // ENTER A VALID EMAIL
            string email = (Console.ReadLine());
            bool emailCheck = validEmail(email);

            while (emailCheck == false)
            {
                Console.WriteLine("Email is INVALID. Please re-enter your email.");
                email = Console.ReadLine();
                emailCheck = validEmail(email);
            }

            if (emailCheck == true)
            {
                Console.WriteLine("You have correctly entered your Email.\n");
            }

//NAME***********************************
            Console.WriteLine("ENTER YOUR NAME");  // ENTER A VALID NAME
            string name = (Console.ReadLine());
            bool nameCheck = validName(name);

            while (nameCheck == false)
            {
                Console.WriteLine("Name is INVALID. Please re-enter your Name as follows: John Smith.");
                name = Console.ReadLine();
                nameCheck = validName(name);
            }
            if (nameCheck == true)
            {
                Console.WriteLine("You have successfully entered your Name.\n");
            }

////PHONE NUMBER***********************************
            Console.WriteLine("ENTER YOUR PHONE NUMBER AS FOLLOWS: XXX-XXX-XXXX.");  // ENTER A VALID PHONE
            string phone = (Console.ReadLine());
            bool phoneCheck = validPhone(phone);

            while (phoneCheck == false)
            {
                Console.WriteLine("Phone is INVALID. Please re-enter your Phone as follows: XXX-XXX-XXXX.");
                phone = Console.ReadLine();
                phoneCheck = validPhone(phone);
            }
            if (phoneCheck == true)
            {
                Console.WriteLine("You have successfully entered your Phone.\n");
            }

////DATE***********************************
            Console.WriteLine("Enter the date as follows: DD/MM/YYYY.");  // ENTER A VALID DATE
            string date = (Console.ReadLine());
            bool dateCheck = validDate(date);

            while (dateCheck == false)
            {
                Console.WriteLine("Date is INVALID. Please re-enter your Date as follows: DD/MM/YYYY.");
                date = Console.ReadLine();
                dateCheck = validDate(date);
            }
            if (dateCheck == true)
            {
                Console.WriteLine("You have successfully entered your Date.\n");
            }

                Console.WriteLine("Thank you for your personal information. We will probably not SPAM you or sell your information. Have a great day!");
        }
    }
}

 












