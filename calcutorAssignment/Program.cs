//Avklarat
// Välkomnande meddelande
// En lista för att spara historik för räkningar
// Användaren matar in tal och matematiska operation
// OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
// Ifall användaren skulle dela med 0 visa Ogiltig inmatning!
// Lägga resultat till listan
// Visa resultat
// Fråga användaren om den vill visa tidigare resultat.
// Visa tidigare resultat
// Fråga användaren om den vill avsluta eller fortsätta.
// OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!




using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace calculator
{
    class Program
    {

        static List<string> mathCalcList = new List<string>();
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                RunCalculator();
                Console.WriteLine("Vill du kolla dina gamla uträkningar? (J, klicka annars vilken tangent som helst)");
                string arrayAnswer = Convert.ToString(Console.ReadLine());
                if (arrayAnswer.ToUpper() == "J")
                {
                    foreach (var x in mathCalcList)
                    {
                        Console.WriteLine(x);
                    }
                }
                
                Console.WriteLine("Vill du avsluta programmet? (J, klicka annars vilken tangent som helst)");
                string exitAnswer = Convert.ToString(Console.ReadLine());
                if (exitAnswer.ToUpper() == "J")
                {
                    isRunning = false;
                    Console.ReadKey();
                }
                
            }
            
        }

        public static void RunCalculator()
        {
            double num1, num2, result;
            char operation;

            Console.WriteLine("Hej! Och välkommen till din egna miniräknare");

            do
            {
                Console.WriteLine("Skriv in det första talet:");
            }
            while (!double.TryParse(Console.ReadLine(), out num1));

            do
            {
                Console.WriteLine("Skriv in det andra talet:");
            }
            while (!double.TryParse(Console.ReadLine(), out num2));

           
            Console.WriteLine("Välj en av operatorerna: (+, -, %, /, *): ");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Resultat: {result}");
                    string savePlusCalculation = $"{num1} + {num2} = {result}";
                    mathCalcList.Add(savePlusCalculation);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Resultat: {result}");
                    string saveSubCalculation = $"{num1} - {num2} = {result}";
                    mathCalcList.Add(saveSubCalculation);
                    break;
                case '%':
                    result = num1 % num2;
                    Console.WriteLine($"Resultat: {result}");
                    string saveProcentCalculation = $"{num1} % {num2} = {result}";
                    mathCalcList.Add(saveProcentCalculation);
                    break;
                case '/':
                    if (num2 == 0 || num1 == 0)
                    {
                        Console.WriteLine("Ogiltig inmatning!");
                        break;
                    }
                    result = num1 / num2;
                    Console.WriteLine($"Resultat: {result}");
                    string saveDivCalculation = $"{num1} / {num2} = {result}";
                    mathCalcList.Add(saveDivCalculation);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Resultat: {result}");
                    string saveMultiCalculation = $"{num1} * {num2} = {result}";
                    mathCalcList.Add(saveMultiCalculation);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error ogiltig operator! Försök igen.");
                    Console.ResetColor();
                    RunCalculator(); 
                    break;
            }
        }
    }
}