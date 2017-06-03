using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashing
{
    class Hashing
    {
        double[] phoneNumbers = new double[10];
        int Id = 0, hashValue = 0;
        
        public void AddNumbers()
        {
            Console.WriteLine("Enter the Id of the student");
            Id = int.Parse(Console.ReadLine());
            hashValue = Id % 10;
            Console.WriteLine("The hash value generated is " + hashValue);
            Console.WriteLine("Now enter the phone number of the student");
            phoneNumbers[hashValue] = double.Parse(Console.ReadLine());
            Console.WriteLine("Phone number added sucessfully");
        }

        public void Display()
        {
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                Console.WriteLine("PhoneNumbers[{0}] = {1} ", i, phoneNumbers[i]); 
            }
        }


    }
}
