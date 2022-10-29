/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
* Link(s) Used: [INSERT LINK(S) HERE]
*/

using System;
using System.Diagnostics;
using System.Reflection;

namespace GooglingExercisesP3
{
    public class Source
    {
        public static Type GetCalculatorType()
        {
            throw new NotImplementedException();
        }

        public static Calculator CreateCalculatorUsingReflection()
        {
            Calculator calc = (Source)Activator.CreateInstance(typeof(Source))!;
            return calc;
        }

        //Get the number of properties in the Calculator class.
        //Do not return a hard-coded value.
        public static int GetNumberOfPropertiesInCalculator()
        {
            throw new NotImplementedException();
        }

        public static (double number, double pi, double tau, double e) GetCalculatorPropertyValues(Object obj)
        {
            Calculator calc = (Calculator)obj;

            return (default(double), default(double), default(double), default(double));
        }

        //Return the line number of the return statement.
        public static int GetLineNumber()
        {
            return default(int);//Return the line number
        }
    }
}
