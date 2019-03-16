namespace _3__LiskovSubstitutionPrinciple.Animal
{
    #region Using

    using System;

    #endregion

    public class LspDemo
    {
        public void Start()
        {
            var shape = new Rectangle();
            shape.SetWidth(14);
            shape.SetHeight(10);
            Console.WriteLine("Area={0}", shape.Area); // 140        

            shape = new Square();
            shape.SetWidth(14);
            shape.SetHeight(10);
            Console.WriteLine("Area={0}", shape.Area); // 100
            Console.ReadLine();
        }
    }

    public class Rectangle
    {
        protected int _width;
        protected int _height;

        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public virtual void SetWidth(int width)
        {
            _width = width;
        }

        public virtual void SetHeight(int height)
        {
            _height = height;
        }

        public int Area
        {
            get { return _height * _width; }
        }
    }

    public class Square : Rectangle
    {
        public override void SetWidth(int width)
        {
            _width = width;
            _height = width;
        }

        public override void SetHeight(int height)
        {
            _width = height;
            _height = height;
        }
    }
}