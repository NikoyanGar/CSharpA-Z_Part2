namespace _011_Inheritance
{
    class Cylinder : Circle
    {
        private int h;
        public int H
        {
            get => h;
            set
            {
                if (value <= 0 || value > 100)
                    h = 5;
                else
                    h = value;
            }
        }

        public override void Print()
        {
            Console.WriteLine($"({x},{y}), R = {R}, H = {H}");
        }
    }

}
