using System;

namespace webCodeGenerator
{
    class Program
    {
        static void Main()
        {
            // begining , enter a command
            Console.WriteLine("enter a command");
         string cmd =   Console.ReadLine();

                // commandCheck 
                    // table
            if (cmd == "table" )
            {
                makeTabsle();
            }

            // bootstrap
            if (cmd == "bootstrap")
            {
                Console.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'>");
                Console.WriteLine("<script src='https://code.jquery.com/jquery-3.5.1.slim.min.js' integrity='sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj' crossorigin='anonymous'></script>");
                Console.WriteLine("<script src = 'https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js' integrity = 'sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo' crossorigin = 'anonymous' ></ script > ");
                Console.WriteLine("<script src = 'https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js' integrity = 'sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI' crossorigin = 'anonymous' ></ script > ");
                Main();
            }
          
        }


        // tables 
        private static void makeTabsle()
        {
            Console.WriteLine("count of rows");
           string rowCount = Console.ReadLine();
            Console.WriteLine("count of coloms");
            string colCount = Console.ReadLine();
            string output = "<table border ='1'> ";
            int row = Int32.Parse(rowCount);
            int col = Int32.Parse(colCount);
            for (int i = 0; i < row; i++)
            {
                output = output + "<tr>";
                for (int x = 0; x < col; x++)
                {
                    output = output + "<td> enter somme text in here </td>";
                }
                    output = output + "</tr>";
            }
            output = output + "</table>";
            Console.WriteLine(output);
            Main();
        }

       
    }
}
