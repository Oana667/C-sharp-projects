class WCalculator
{
    public static double Barbati(double inaltime, double varsta)
    {
        double result = 0;
        result = (inaltime - 100 - ((inaltime-150)/4))+((varsta-20)/4);
        return result;
    }
    public static double Femei(double inaltime, double varsta)
    {
        double result = 0;
        result = (inaltime - 100 - ((inaltime - 150) / 2.5)) + ((varsta - 20) / 6);
        return result;
    }
}


class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;


        while (!endApp)
        {

            string inaltime = "";
            string varsta = "";
            double result = 0;

            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("Barbati - To calculate ideal weight for men");
            Console.WriteLine("Femei - To calculate ideal weight for women");
            Console.Write("Your choice: ");

            string op = Console.ReadLine();
            //op=operator

            if (op == "Barbati")
            {
                Console.Write("Type height and then press Enter: ");
                inaltime = Console.ReadLine();
                Console.Write("Type age and then press Enter: ");
                varsta = Console.ReadLine();
                double cleanNum1 = 0;
                double cleanNum2 = 0;
                while (!double.TryParse(inaltime, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    inaltime = Console.ReadLine();
                }
                while (!double.TryParse(varsta, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    varsta = Console.ReadLine();
                }

                try
                {
                    result = WCalculator.Barbati(cleanNum1, cleanNum2);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An exception occurred trying to do the math.\n - Details: " + ex.Message);
                }
            }

            if (op == "Femei")
            {
                Console.Write("Type height and then press Enter: ");
                inaltime = Console.ReadLine();
                Console.Write("Type age and then press Enter: ");
                varsta = Console.ReadLine();
                double cleanNum3 = 0;
                double cleanNum4 = 0;
                while (!double.TryParse(inaltime, out cleanNum3))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    inaltime = Console.ReadLine();
                }
                while (!double.TryParse(varsta, out cleanNum4))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    varsta = Console.ReadLine();
                }

                try
                {
                    result = WCalculator.Barbati(cleanNum3, cleanNum4);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An exception occurred trying to do the math.\n - Details: " + ex.Message);
                }
            }

            Console.WriteLine("------------------------\n");


            Console.Write("Press 'Q' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "Q") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}

