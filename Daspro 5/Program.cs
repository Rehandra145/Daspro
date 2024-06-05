using System;

class Program
{
    static void Main(string[] args)
    {
        int[] angka = { 5, 10, 15, 20, 25, 30, 35, 40, 45 };

        Console.WriteLine("---------------------------");
        Console.WriteLine("Mesin Pembagi");
        
        for (int i = 0; i < angka.Length - 1; i++)
        {
            try
            {
                Console.WriteLine($"Hasil pembagian {angka[i]} / {angka[i + 1]} = {Bagi(angka[i], angka[i + 1])}");
            }
            catch (DivideByZeroException)
            {
                HandleException("Pembagian dengan nol.");
            }
            catch (ArithmeticException)
            {
                HandleException("Terjadi kesalahan aritmatika.");
            }
            catch (Exception e)
            {
                HandleException(e.Message);
            }
        }

        InputBagi();
    }

    static double Bagi(double angkaPertama, double angkaKedua)
    {
        return angkaPertama / angkaKedua;
    }

    static void InputBagi()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Mesin Pembagi");
                Console.WriteLine("Masukkan angka pertama : ");
                double angkaPertama = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan angka kedua : ");
                double angkaKedua = Convert.ToDouble(Console.ReadLine());
                double hasil = Bagi(angkaPertama, angkaKedua);
                Console.WriteLine($"Hasilnya adalah : {hasil}");
            }
            catch (FormatException)
            {
                HandleException("Input bukan angka.");
            }
            catch (DivideByZeroException)
            {
                HandleException("Pembagian dengan nol.");
            }
            catch (Exception e)
            {
                HandleException(e.Message);
                break;
            }
        }
    }

    static void HandleException(string errorMessage)
    {
        Console.WriteLine("Runtime Error: " + errorMessage);
    }
}


    


    

