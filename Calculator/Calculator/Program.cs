class Calculator
{
    public static double Operations(double num1, double num2, string op)
    {
        double result = 0; 

        
        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
               
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            
            default:
                break;
        }
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
          
            string InputNr1 = "";
            string InputNr2 = "";
            double result = 0;

            
            Console.Write("Type a number and then press Enter: ");
            InputNr1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(InputNr1, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                InputNr1 = Console.ReadLine();
            }

            
            Console.Write("Type another number, and then press Enter: ");
            InputNr2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(InputNr2, out cleanNum2))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                InputNr2 = Console.ReadLine();
            }

            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("+ - Add");
            Console.WriteLine("- - Subtract");
            Console.WriteLine("* - Multiply");
            Console.WriteLine("/ - Divide");
            Console.Write("Your choice: ");

            string op = Console.ReadLine();
            //op=operator

            try
            {
                result = Calculator.Operations(cleanNum1, cleanNum2, op);
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

            Console.WriteLine("------------------------\n");

            
            Console.Write("Press 'Q' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "Q") endApp = true;

            Console.WriteLine("\n"); 
        }
        return;
    }
}