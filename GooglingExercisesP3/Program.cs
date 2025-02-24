using System;
using System.Linq;
using System.Reflection;

namespace GooglingExercisesPt3
{
    class Program
    {
        public static void Main()
        {
            bool correct = true;

            try
            {
                if (Source.GetCalculatorType() != typeof(Calculator))
                {
                    Console.WriteLine(typeof(Source).GetMethods().Where(x => x.ReturnType == typeof(Type)).Select(x => x.Name).FirstOrDefault() + "() returned incorrect result.");
                    correct = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(typeof(Source).GetMethods().Where(x => x.ReturnType == typeof(Type)).Select(x => x.Name).FirstOrDefault() + "() threw an exception. See next line for details.");
                Console.WriteLine(ex.Message);
                correct = false;
            }
            
            try
            {
                if (Source.CreateCalculatorUsingReflection().GetType() != typeof(Calculator))
                {
                    Console.WriteLine(typeof(Source).GetMethods().Where(x => x.ReturnType == typeof(Calculator)).Select(x => x.Name).FirstOrDefault() + "() returned incorrect result.");
                    correct = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(typeof(Source).GetMethods().Where(x => x.ReturnType == typeof(Calculator)).Select(x => x.Name).FirstOrDefault() + "() threw an exception. See next line for details.");
                Console.WriteLine(ex.Message);
                correct = false;
            }
            

            try
            {
                if (Source.CreateCalculatorUsingReflection2().GetType() != typeof(Calculator))
                {
                    Console.WriteLine(typeof(Source).GetMethods().Where(x => x.ReturnType == typeof(Calculator)).Select(x => x.Name).Skip(1).FirstOrDefault() + "() returned incorrect result.");
                    correct = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(typeof(Source).GetMethods().Where(x => x.ReturnType == typeof(Calculator)).Select(x => x.Name).Skip(1).FirstOrDefault() + "() threw an exception. See next line for details.");
                Console.WriteLine(ex.Message);
                correct = false;
            }

            try
            {
                if (Source.GetNumberOfPropertiesInCalculator() != 4)
                {
                    Console.WriteLine(typeof(Source).GetMethods().Where(x => x.ReturnType == typeof(Int32)).Select(x => x.Name).FirstOrDefault() + "() returned incorrect result.");
                    correct = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(typeof(Source).GetMethods().Where(x => x.ReturnType == typeof(Int32)).Select(x => x.Name).FirstOrDefault() + "() threw an exception. See next line for details.");
                Console.WriteLine(ex.Message);
                correct = false;
            }

            Source.GetCalculatorPropertyValues(new Program());
            Source.GetCalculatorPropertyValues(new Source());

            Calculator myCalc = new Calculator();
            myCalc.Add(Random.Shared.Next(0, 100) - Random.Shared.NextDouble());

            (double number, double pi, double tau, double e) result = Source.GetCalculatorPropertyValues(myCalc);

            if(result.number != myCalc.Number || result.pi != myCalc.Pi || result.tau != myCalc.Tau || result.e != myCalc.E)
            {
                Console.WriteLine(typeof(Source).GetMethods().Where(x => x.ReturnType == typeof((double number, double pi, double tau, double e)))
                    .Select(x => x.Name).FirstOrDefault() + "() returned incorrect result.");
                correct = false;
            }

            if (Source.GetLineNumber() < 40)
            {
                Console.WriteLine(typeof(Source).GetMethods().Where(x => x.ReturnType == typeof(Int32)).Select(x => x.Name).ElementAt(1) + "() returned incorrect result.");
                correct = false;
            }

            if (correct == true)
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}