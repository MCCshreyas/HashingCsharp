using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashing
{
    class Hashing
    {
        /*
          declaration of double array where we are going to save phone numbers. 
          Hash table size is 10.
        */
        
        double[] phoneNumbers = new double[10];              
        int Id = 0, hashValue = 0;
        
        public void AddNumbers()
        {
            Console.WriteLine("Enter the Id of the student");
            Id = int.Parse(Console.ReadLine());
            hashValue = Id % 10;                                             //calculate hash value from hash function X mod 10.
            Console.WriteLine("The hash value generated is " + hashValue);
            Console.WriteLine("Now enter the phone number of the student");
            phoneNumbers[hashValue] = double.Parse(Console.ReadLine());      //save the phone number to hash index.
            Console.WriteLine("Phone number added sucessfully");
        }

        
        /*
            following method will display the content in the array
        */
        
        public void Display()
        {
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                Console.WriteLine("PhoneNumbers[{0}] = {1} ", i, phoneNumbers[i]); 
            }
        }


    }
}
