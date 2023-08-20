namespace VaribleTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //* String
            string name = "Şeftali Demiral";
            Console.WriteLine(name);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Substring(3, 4));

            //* Char
            char varSelection = 'A';
            Console.WriteLine(varSelection);

            //* Byte
            byte varByte = 181;
            Console.WriteLine("Byte küçük tamsayı değerleri içindir. " + varByte);
            Console.WriteLine("Byte en küçük değeri " + byte.MinValue);
            Console.WriteLine("Byte en büyük değeri " + byte.MaxValue + "\n");

            //* Int
            int varInt = 12345;
            Console.WriteLine("Integer tam sayı değerleri içindir. " + varInt);
            Console.WriteLine("Integer en küçük değeri " + int.MinValue);
            Console.WriteLine("Integer en büyük değeri " + int.MaxValue + "\n");

            //* decimal
            decimal varDecimal = 12334.50M;
            Console.WriteLine("Decimal noktalı sayılar içindir. " + varDecimal);
            Console.WriteLine("Decimal en küçük değeri " + decimal.MinValue);
            Console.WriteLine("Decimal en büyük değeri " + decimal.MaxValue + "\n");

            //* Float
            float varFloat = 6543.20F;
            Console.WriteLine("Float değeri noktalı sayılar içindir. " + varFloat);
            Console.WriteLine("Float en küçük değeri " + float.MinValue);
            Console.WriteLine("Float en büyük değeri " + float.MaxValue + "\n");

            //* Double
            double varDouble = 9876.50D;
            Console.WriteLine("Double daha büyük noktalı sayılar içindir." + varDouble);
            Console.WriteLine("Double en küçük değeri " + double.MinValue);
            Console.WriteLine("Double en büyük değeri " + double.MaxValue + "\n");

            //* Boolean
            bool varBool = true;
            Console.WriteLine("Boolean mantıksal tercihler içindir." + varBool);
            varBool = false;
            Console.WriteLine("Bir boolean değişkeni sadece \"true\" ya da \"false\" " + 
            "değerleri alabilir");
        }
    }
}
