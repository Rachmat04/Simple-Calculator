Module Module1

    Sub Main()
        Try
            Console.WriteLine("Kalkulator sederhana")
            Console.WriteLine()

            Console.WriteLine("Masukkan nilai pertama: ")
            Dim nilai1 As Double = Console.ReadLine()
            Console.WriteLine("Masukkan nilai kedua: ")
            Dim nilai2 As Double = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Menghitung ...")
            Console.WriteLine()
            Dim nilai3, nilai4, nilai5, nilai6, nilai7 As Double
            nilai1 = Math.Round(nilai1)
            nilai2 = Math.Round(nilai2)
            nilai3 = nilai1 * nilai2
            nilai4 = nilai1 + nilai2
            nilai5 = nilai1 - nilai2
            nilai6 = nilai1 / nilai2
            nilai7 = nilai1 ^ nilai2
            Console.WriteLine("Hasil penjumlahan nilai pertama dan kedua adalah " & nilai4)
            Console.WriteLine("Hasil pengurangan nilai pertama dan kedua adalah " & nilai5)
            Console.WriteLine("Hasil perkalian nilai pertama dan kedua adalah " & nilai3)
            Console.WriteLine("Hasil pembagian nilai pertama dan kedua adalah " & nilai6)
            Console.WriteLine()
            Console.WriteLine("Hasil dari nilai pertama pangkat nilai kedua adalah " & nilai7)
            Console.ReadLine()

        Catch ex As InvalidCastException
            Console.WriteLine("Galat: Anda memasukkan karakter selain angka. Aplikasi akan ditutup. Silakan muat ulang aplikasi.")
        Catch Ex As Exception
            Console.WriteLine("Galat: " & Ex.Message)
            Console.ReadLine()
        End Try
    End Sub

End Module
