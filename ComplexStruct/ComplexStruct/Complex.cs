using System;

namespace ComplexStruct
{
    public struct Complex
    {
        private double a;

        public double Re
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }


        private double b;

        public double Im
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }


        public Complex(double re, double im) : this()
        {
            Re = re;
            Im = im;
        }

        public override string ToString()
        {
            switch (Re)
            {
                case 0:
                    switch (Im)
                    {
                        case 0:
                            return $"0";
                        case 1:
                            return $"i";
                        case -1:
                            return $"-i";
                        default:
                            return $"{Re}+{Im}i";
                    }
                default:
                    switch (Im)
                    {
                        case 0:
                            return $"{Re}";
                        case 1:
                            return $"{Re}+i";
                        case -1:
                            return $"{Re}-i";
                        default:
                            return $"{Re}+{Im}i";
                    }
            }

        }

        public override bool Equals(object obj)
        {
            if (obj is Complex)
                return Re == ((Complex)obj).Re && Im == ((Complex)obj).Im;

            throw new ArgumentException("Объект для сравнения не комплекстным числом");
        }

        public override int GetHashCode() =>(a+b).GetHashCode();

        public static bool operator ==(Complex x, Complex y) => x.Equals(y);
        public static bool operator !=(Complex x, Complex y) => !x.Equals(y);

        public static Complex operator +(Complex x, Complex y) {
            var a = x.Re;
            var b = x.Im;
            var c = y.Re;
            var d = y.Im;
            return new Complex(a + c, b + d);
        }

        public static Complex operator -(Complex x, Complex y)
        {
            var a = x.Re;
            var b = x.Im;
            var c = y.Re;
            var d = y.Im;
            return new Complex(a + c, b + c);
        }

        public double Abs() => Math.Sqrt(a * a + b * b);
    }
}
