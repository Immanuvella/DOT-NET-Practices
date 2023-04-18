using System;
namespace CustomeException

{
    //Creating our own Exception Class by inheriting Exception class
    public class OddNumberException : Exception
    {
        //Overriding the Message property
        public override string Message
        {
            get
            {
                return "Divisor Cannot be Odd Number";
            }
        }

       
       
    }
}