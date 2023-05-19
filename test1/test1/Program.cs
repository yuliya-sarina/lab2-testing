using System;
using System.Collections.Generic;
using System.Text;


namespace test1
{
    public class Drob
    {
        private int X;
        private int Y;

        // Инициализация
        public void Init(int x, int y)
        {
            X = x;
            Y = y;
        }
        // GET-функции
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }

        public void Read()
        {
            Console.Write("\nVvod chislitely X: ");
            X = Int32.Parse(Console.ReadLine());
            Console.Write("Vvod znamenately Y: ");
            Y = Int32.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("\nChislitel X: " + X);
            Console.WriteLine("Znamenatel Y: " + Y);
        }

        public double VidelDrob()
        {
            double drob = (double)X / (double)Y;
            return drob;
        }

        // Сумма дробей
        public Drob Add(Drob a, Drob b)
        {
            Drob c = new Drob();
            c.X = a.GetX() * b.GetY() + b.GetX() * a.GetY();
            c.Y = a.GetY() * b.GetY();
            return c;
        }

        public double VidelSumDrob()
        {
            double drob = (double)X / (double)Y;
            return drob;
        }

        public Drob VychDrob(Drob a, Drob b)
        {
            Drob c = new Drob();
            c.X = a.GetX() * b.GetY() - b.GetX() * a.GetY();
            c.Y = a.GetY() * b.GetY();
            return c;
        }
        public Drob UmnozhDrob(Drob a, Drob b)
        {
            Drob c = new Drob();
            c.X = a.GetX() * b.GetX();
            c.Y = a.GetY() * b.GetY();
            return c;
        }
        public int VidelCelChast()
        {
            int drob = X / Y;
            return drob;
        }

        public bool RavnyeDroby(Drob a, Drob b)
        {
            bool i = true;
            double c1, c2;
            c1 = a.VidelDrob();
            c2 = b.VidelDrob();
            if (c1 == c2)
                i= true;
            else i=false;
            return i;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n- Drob A -");
            Drob DrobA; DrobA = new Drob();
            DrobA.Init(0, 0);
            DrobA.Display();
            DrobA.Read();
            DrobA.Display();
            Console.WriteLine("\n- Drob B -");
            Drob DrobB = new Drob(); 
            DrobB.Init(0, 0);
            DrobB.Display(); 
            DrobB.Read();
            DrobB.Display();
            Console.WriteLine("\n- Drob C (summa drobei) -"); 
            Drob DrobC = new Drob();
            DrobC = DrobC.Add(DrobA, DrobB); 
            DrobC.Display();
            double chast;
            chast = DrobC.VidelDrob(); 
            Console.WriteLine("\nVidel drobnoi chasti: " + chast);
            Console.WriteLine("\n- Drob D (raznost drobei) -"); 
            DrobC = DrobC.VychDrob(DrobA, DrobB); 
            DrobC.Display();
            Console.WriteLine("\n- Drob E (raznost drobei) -");
            DrobC = DrobC.UmnozhDrob(DrobA, DrobB);
            DrobC.Display();

        }
    }
}

