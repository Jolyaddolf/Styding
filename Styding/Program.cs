
class Program
{
     static void Main(string[] args)
     {



     


    
        Console.WriteLine("Enter nember");
        double FirstNumebr = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter znak +, - , * ,/ ");
        char Znak = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter number");
        double SecondNumber = double.Parse(Console.ReadLine());
        double result;
        if (Znak == '+')
        {
            result = FirstNumebr + SecondNumber;
            Console.WriteLine(result);
        }
        if (Znak =='-')
        {
            result = FirstNumebr - SecondNumber;
            Console.WriteLine(result);
        }
        if (Znak =='*')
        {
            result = FirstNumebr * SecondNumber;
            Console.WriteLine(result);
        }
        if (Znak =='/')
        {
            result = FirstNumebr / SecondNumber;
            Console.WriteLine(result);
        

        }


        //while (true)
        //{
        //    Console.WriteLine("Enter Number");
        //    double firstNumber = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter Number");
        //    double SecondNumber = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter znak + - * / ");
        //    char a = char.Parse(Console.ReadLine());


}

        //    switch (a)

        //    {
        //        case '+':

        //            Console.WriteLine(firstNumber + SecondNumber);
        //            break;
        //        case '-':

        //            Console.WriteLine(firstNumber - SecondNumber);
        //            break;
        //        case '*':

        //            Console.WriteLine(firstNumber * SecondNumber);
        //            break;
        //        case '/':
        //            Console.WriteLine(firstNumber / SecondNumber);
        //            ;
        //            break;
        //        default:

        //            Console.WriteLine("Гавно написал давай заново");
        //            break;
        //    }

        //    Console.ReadLine();
        //}
    //{
    //    uint NectectNumber = 0;
    //    uint ChetNumber = 0;

    //    int ot = int.Parse(Console.ReadLine());
    //    int doo = int.Parse(Console.ReadLine());

    //    int summNechet = 0;
    //    int summChet = 0;

    //    while (ot <= doo) {

    //        if (ot % 2 == 0) 
    //        {
    //            ChetNumber++;
    //            summChet = summChet + ot;

    //        }
    //        else
    //        {
    //           NectectNumber++;

    //            summNechet = summNechet + ot;
    //        }
    //        ot++;
        
    //    }

    //    Console.WriteLine("Колво нечет " + NectectNumber);
    //    Console.WriteLine("Колво чет " + ChetNumber);
    //    Console.WriteLine("Sum нечет " + summNechet);
    //    Console.WriteLine("Sum чет " + summChet);
    //    Console.ReadLine();
    //}
        }