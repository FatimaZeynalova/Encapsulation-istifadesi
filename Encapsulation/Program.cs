using System;

namespace Exception
{
    #region Yeni növ use property
    class Program
    {
        static void Main(string[] args)
        {
                MyClass m = new MyClass();
                m.A = 15;
                Console.WriteLine(m.A);
        }
    }
    class MyClass
    {
        int a;
       
        public int A
        {
            get { return a; }
            set { a = value; }
        }

    }
    #endregion

    #region Əvvəldə encapsulation bu formad olurdu
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyClass m = new MyClass();
    //        m.ASet(15);
    //        Console.WriteLine(m.AGet());
    //    }
    //}
    //class MyClass
    //{
    //    private int a;

    //    public int AGet()
    //    {
    //        return this.a;
    //    }
    //    public void ASet(int value)
    //    {
    //        this.a = value;
    //    }
    //}
    #endregion
}