using System;

namespace interfaceMember
{
    class Program
    {
        static void PrintPoint(AppInterface p)
        {
            Console.WriteLine(p.GetType());
            Console.WriteLine("Number 1 ={0}, Number 2 ={1}", p.x, p.y);
        }

        static void Main()
        {
            Addition p = new Addition(20, 30);
            PrintPoint(p);
            Console.ReadLine();
        }
    }

    class Addition : AppInterface
    {
        private int _num1;
        private int _num2;

        public Addition(int x, int y)
        {
            _num1 = x + y;
            _num2 = y - x;
        }

        public int x
        {
            get { return _num1; }
            set { _num1 = value; }
        }

        public int y
        {
            get { return _num2; }
            set { _num2 = value; }
        }
    }
}
