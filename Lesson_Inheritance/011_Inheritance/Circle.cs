﻿namespace _011_Inheritance
{
    class Circle : Point
    {
        private int r;
        public int R
        {
            get => r;
            set
            {
                if (value <= 0 || value > 100)
                    r = 5;
                else
                    r = value;
            }
        }

        public /*sealed*/ override void Print()
        {
            Console.WriteLine($"({x},{y}), R = {R}");
        }
    }
}
