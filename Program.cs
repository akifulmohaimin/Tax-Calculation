using static System.Console;
using System;


// Student Name : Akiful Mohaimin
// Student ID : 300369823
// Assignment : 01 (Lab 01)

namespace taxCalculation;
class Program
{
    static void Main(string[] args)
    {

        WriteLine( "Please provide your Marital STATUS! Type M for married & Type S for single ");
        string maritalStatus = ReadLine();
        if (maritalStatus == "M" || maritalStatus == "S") // Restricting user for putting other inputs except M or S
        {

            Write("Please enter your income for tax calculation  ");
            float income = float.Parse(ReadLine());
            float tax = 0.0f;

            if (maritalStatus == "S")
            {
                if (income <= 0)
                {
                    WriteLine("Sorry! your income has to be more than 0");
                    return;
                }

                if (income <= 8000)
                {

                    tax = .1f * income;

                }
                if (income > 8000 && income <= 32000)
                {

                    tax = 800 + .15f * income;

                }
                if (income > 32000)
                {

                    tax = 4400 + .25f * income;

                }



            }

            if (maritalStatus == "M")
            {
                if (income <= 0)
                {
                    WriteLine("Sorry! your income has to be more than 0");
                    return;
                }

                if (income <= 16000)
                {

                    tax = .1f * income;

                }
                if (income > 16000 && income <= 64000)
                {

                    tax = 1600 + .15f * income;

                }
                if (income > 64000)
                {

                    tax = 8800 + .25f * income;

                }



            }

            WriteLine("Your income BEFORE TAX is " + (String.Format("{0:0.00}", income)));
            WriteLine("Your TOTAL TAX is " + (String.Format("{0:0.00}", tax)));
            WriteLine("Your income AFTER TAX is " + (String.Format("{0:0.00}", (income - tax))));
        }

        else
        {
            Write("Sorry WRONG INPUT!! Please read the instruction carefully");
        }


        ReadKey();
    }

}
