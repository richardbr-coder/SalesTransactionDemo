using System;
using static System.Console; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransactionDemo
{
    public class SalesTransaction
    {
        //declaring feilds
        public string name;
        public int sales_amount; 
        public double commission;
        private readonly double commission_rate;

        //constructor 1
        public SalesTransaction(string n, int sAmount, double rate)
        {
            //was going to use 'this.Salestransaction = n;', I assumed what I did below was better...Please advise.
            name = n;
            sales_amount = sAmount;
            commission_rate = rate;
            commission = sales_amount * commission_rate;
        }

        //constructor 2
        public SalesTransaction(string n, int sAmount)
        {
            name = n;
            sales_amount = sAmount;
            commission_rate = 0;
            commission = sales_amount * commission_rate;
        }

        //constructor 3
        public SalesTransaction(string n)
        {
            name = n;
            sales_amount = 0;
            commission_rate = 0;
            commission = 0;
        }

        //overloaded + operator
        public static SalesTransaction operator +(SalesTransaction one, SalesTransaction two)
        {
            string combinedName = one.name + " and " + two.name;
            int combinedSales = one.sales_amount + two.sales_amount;
            double combinedCommissionRate = one.commission_rate + two.commission_rate;
            return (new SalesTransaction(combinedName, combinedSales, combinedCommissionRate));
        }

        //function to display details
        public string toString()
        {
            string details = "Salespersons name: " + name + "\n";
            details += "Sales amount: " + sales_amount + "\n";
            details += "Commission Rate: " + commission_rate + "\n";
            details += "Commission: " + commission + "\n";
            return details;
        }
    }//end of SalesTransaction class

    class Program
    {
        //main method
        static void Main()
        {
            //displaying to the console and committing objects to memory
            WriteLine("Information for SaleTransactions 1st object is: ");
            SalesTransaction st1 = new SalesTransaction("Michael Scott", 800, .35);
            WriteLine(st1.toString());

            WriteLine("Information for SaleTransactions 2nd object is: ");
            SalesTransaction st2 = new SalesTransaction("Jim Halpert", 750, .15);
            WriteLine(st2.toString());

            WriteLine("Information for SaleTransactions 3rd object is: ");
            SalesTransaction st3 = new SalesTransaction("Dwight Schrute 'Assisstant to the manager'", 1200, .25);
            WriteLine(st3.toString());

            WriteLine("Information for SaleTransactions 4th object is: ");
            SalesTransaction st4 = new SalesTransaction("Stanley Hudson", 200);
            WriteLine(st4.toString());

            WriteLine("Information for SaleTransactions 5th object is: ");
            SalesTransaction st5 = new SalesTransaction("Phyllis Vance");
            WriteLine(st5.toString());

            SalesTransaction st23 = st2 + st3;
            WriteLine("The result of adding Jim and Dwights sales are: ");
            WriteLine(st23.toString());

            ReadLine();
            


        }//end of main
    }//end of program class
}//end of name space
