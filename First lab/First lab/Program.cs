using System;
using System.Text;

namespace First_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine("boolType = true'");
            bool b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(b);

            Console.WriteLine("byteType = 1");
            byte c = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(c);

            Console.WriteLine("sByteType = -101");
            sbyte d = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine(d);

            Console.WriteLine("charType = 'A'");
            char e = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(e);

            decimal f = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(f);

            Console.WriteLine("doubleType = 3.14D");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(g);

            Console.WriteLine("floatType = 3.14F");
            float h = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(h);

            Console.WriteLine("uIntType = 10");
            uint i = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(i);

            // nint nintType = 12;
            // nuint nintType = 12;

            long s = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(s);

            ulong  w = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(w);


            Console.WriteLine(" shortType = 1");
            short q = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(q);


            Console.WriteLine("uShortType = 1");
            ushort t = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine(t );

            object obj = 1;
            string str = "Hello";
            Console.WriteLine(str);
            dynamic lo = "AllString";

            //Приведение типов 
            // Неявное приведение
            byte i8 = 8;
            Int16 i16 = i8;
            Int32 i32 = i16;
            Int64 i64 = i32; 
            Single k = i32;
            // Явное приведение 

            Byte m = (Byte)i32; 
            Int16 v = (Int16)s;
            Int32 n = (Int32)i16;
            Int64 l = (Int64)i16;
            long o = 1234;
            int p = Convert.ToInt32(l);
            Console.WriteLine("Int = {0}", i);
            Console.ReadLine();
            
            int x = 5;
            Object y = x; // Упаковка 
            byte z = (byte)(int)o; // Распакова

            //Неявно типизированные локальные переменные
            var  la = new[] { 0, 1, 2 };
            Console.Write(la.GetType());
            Console.WriteLine();

            //Nullable type
            Nullable<int> u = 5;
            int? x1 = null;
            if (x1.HasValue)
            {
                int x2 = (int)x1;//явное
                int? x3 = x2; //неявное к T?
                long? x4 = x2; //неявное расширяющее
            }
            */
            //var v1,v2 = 2;

           // SecondTask();
           //ThirdTask();
            FourTask();
            (int, int, int, char) function(int[] arr, string str)
            {
                int max = int.MinValue,
                    min = int.MaxValue,
                    sum = 0;

                foreach (int num in arr)
                {
                    sum += num;

                    if (num > max)
                    {
                        max = num;
                    }

                    if (num < min)
                    {
                        min = num;
                    }
                }


                return (max, min, sum, str[0]);
            }

            Console.WriteLine(function(new int[] { 2, 100, 4, 12 }, "balada"));
            void CheckedFunction()
            {
                checked
                {
                    int value = int.MaxValue;
                    value -= 5;
                    Console.WriteLine(value);
                }
            }

            void UncheckedFunction()
            {
                unchecked
                {
                    int value = int.MaxValue;
                    value += 5;
                    Console.WriteLine(value);

                }
            }
            CheckedFunction();
            UncheckedFunction();
        }

        static void SecondTask( )
        {
       
            string str1 = "hellows worlds!!";
            string str2 = "Hello world???)";
            string str3 = "Hello world$$)";
            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1 + str2);
            Console.WriteLine(String.Copy(str2));
            Console.WriteLine(str1.Substring(5));
            string[] words = str1.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.Write(s);
            }
            double a = 3;
            double b = 4;
            Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
            bool nullStr = String.IsNullOrEmpty(null);
            bool emptyStr = String.IsNullOrEmpty("");
            Console.WriteLine(nullStr + " " + emptyStr);
            Console.WriteLine(str3.Insert(5, " " + words[0]));
            Console.WriteLine(str1.Remove(0, 6));
            StringBuilder sb = new StringBuilder("ABC.", 50);

        }
        static void ThirdTask()
        {
           
            int[,] Array1 =  {{1,2,3},{4,5,6},{7,8,9}};
            for (int i = 0; i < Array1.GetLength(0); i++)
              
            {
                for (int ui = 0; ui < Array1.GetLength(1); ui++)
                {
                    Console.Write (Array1[i, ui] + " ");
                }
                Console.WriteLine();
            }


            string[] mass = { "Hellow ", "I'm", " Mike" };
            foreach (var i in mass)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine(mass.Length);
            mass[2] = " Djake";
            foreach (var i in mass)
            {
                Console.Write(i);
            }
            Console.Write("\n");
            int[][] array = { new[] { 1, 4 }, new[] { 4, 1, 6,  }, new[] { 7, 8, 9, 10 } };

            foreach (int[] row in array)
            {
                foreach (int i in row)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\n");
            }

            var arr = new[] { 1, 2, 3 };
            var sr = "HI";
        }


        static void FourTask()
        {
            (int i1, string i2, char i3, string i4, ulong i5) k = (12, "hello world", 's', "hello", 1346436443L);
            Console.WriteLine($"{k.i1}, {k.i3}, {k.i4}");


            var less1 = k.i1;
            var less2 = k.i2;
            var less3 = k.i3;
            Console.WriteLine();
            Console.Write($"{less1} {less2} {less3}");
            Console.WriteLine();
            Console.ReadKey();
            var kor1 = Tuple.Create(1,2,3);
            var kor2 = Tuple.Create(1,2,3);
            _ = kor1.Item2;
            Console.WriteLine(kor1 == kor2);
        }
    }
}

 