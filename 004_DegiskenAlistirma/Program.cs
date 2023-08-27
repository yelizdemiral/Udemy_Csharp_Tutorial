namespace DegiskenAlistirmalari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("İsminiz nedir ? ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminiz nedir ?");
            string soyisim = Console.ReadLine();

            Console.Write("Yaşadığınız şehri giriniz");
            string sehir = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("İsim : " + isim); // İsim Yeliz
            Console.WriteLine("Soyisim : " +soyisim);
            Console.WriteLine("Şehir : " + sehir);

            Console.ReadLine(); 
        }
    }
}
