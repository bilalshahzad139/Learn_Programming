using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Name Spaces are logic unit to Hold classes
namespace BSLearning.Polymorphism
{
    public abstract class Shape
    {
        public Int16 BorderThickness
        {
            get;
            set;
        }
        public Color BorderColor
        {
            get;
            set;
        }
        public Color BorderInnerColor
        {
            get;
            set;
        }
        public Color ShapeColor
        {
            get;
            set;
        }

        public String ID
        {
            get;
            set;
        }
        public String ShapeType
        {
            get;
            set;
        }

        public abstract void Draw();
        public abstract Decimal CalculateArea();
    }

    public abstract class Quadrilateral : Shape
    {
        protected float SideA
        {
            get;
            set;
        }
        protected float SideB
        {
            get;
            set;
        }
        protected float SideC
        {
            get;
            set;
        }
        protected float SideD
        {
            get;
            set;
        }

        protected float Angle_a
        {
            get;
            set;
        }
        protected float Angle_b
        {
            get;
            set;
        }
        protected float Angle_c
        {
            get;
            set;
        }
        protected float Angle_d
        {
            get;
            set;
        }

    }
    public class Square : Quadrilateral
    {
        public float SideLength
        {
            get;
            set;
        }

        public Square(float pLength)
        {
            this.SideA = pLength;
            this.SideB = pLength;
            this.SideC = pLength;
            this.SideD = pLength;
            this.Angle_a = 90;
            this.Angle_b = 90;
            this.Angle_c = 90;
            this.Angle_d = 90;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
        public override decimal CalculateArea()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Square";
        }
    }
    public class Rectangle : Quadrilateral
    {
        public float Length
        {
            get
            {
                return this.SideA;
            }
            set
            {
                this.SideA = this.SideC = value;
            }
        }
        public float Width
        {
            get
            {
                return this.SideB;
            }
            set
            {
                this.SideB = this.SideD = value;
            }
        }

        public Rectangle(float pLength, float pWidth)
        {
            this.SideA = pLength;
            this.SideB = pWidth;
            this.SideC = pLength;
            this.SideD = pWidth;
            this.Angle_a = 90;
            this.Angle_b = 90;
            this.Angle_c = 90;
            this.Angle_d = 90;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
        public override decimal CalculateArea()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Square";
        }

    }

    public class Circle : Shape
    {
        public float Radius
        {
            get;
            set;
        }
        public Tuple<float, float> Center
        {
            get;
            set;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
        public override decimal CalculateArea()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateCircumference()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Circle";
        }
    }

    public class Ellipse : Shape
    {
        public float SemiMinorAxis
        {
            get;
            set;
        }
        public float SemiMajorAxis
        {
            get;
            set;
        }
        public float Focus
        {
            get;
            set;
        }
        public Tuple<float, float> Center
        {
            get;
            set;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
        public override decimal CalculateArea()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateCircumference()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Ellipse";
        }
    }

    public class Triangle : Shape
    {
        protected float SideA
        {
            get;
            set;
        }
        protected float SideB
        {
            get;
            set;
        }
        protected float SideC
        {
            get;
            set;
        }

        protected float Angle_a
        {
            get;
            set;
        }
        protected float Angle_b
        {
            get;
            set;
        }
        protected float Angle_c
        {
            get;
            set;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
        public override decimal CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Ellipse";
        }
    }
}
