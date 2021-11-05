using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtEnumStruct
{
    class Car
    {
        private sbyte _age;

        public sbyte Age
        {
            get
            {
                return this._age;
            }
            set {
                if (value >=0)
                {
                    this._age = value;
                }
            }
        }
        //public static int i { get; set; } = 0;
        //public string Brand { get; set; }
        //public Car()
        //{
        //    i++;
        //}

        //static Car()
        //{
        //    i++;
        //    Console.WriteLine($"Static constructor called, {i}");
        //}

        //public static void Display()
        //{
        //    Console.WriteLine("Static display method called");
        //}
    }
}
