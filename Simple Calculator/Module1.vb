Module Module1

    Sub Main()
        Try
            Console.WriteLine("Kalkulator sederhana")
            Console.WriteLine()

            Console.WriteLine("Masukkan nilai pertama: ")
            Dim nilai1 As Integer = Console.ReadLine()
            Console.WriteLine("Masukkan nilai kedua: ")
            Dim nilai2 As Integer = Console.ReadLine()
            Console.WriteLine()
            Dim nilai3, nilai4, nilai5, nilai6 As Integer
            nilai3 = nilai1 * nilai2
            nilai4 = nilai1 + nilai2
            nilai5 = nilai1 - nilai2
            nilai6 = nilai1 / nilai2
            Console.WriteLine("Hasil penjumlahan nilai pertama dan kedua adalah " & nilai4)
            Console.WriteLine("Hasil pengurangan nilai pertama dan kedua adalah " & nilai5)
            Console.WriteLine("Hasil perkalian nilai pertama dan kedua adalah " & nilai3)
            Console.WriteLine("Hasil pembagian nilai pertama dan kedua adalah " & nilai6)
            Console.WriteLine()
            Console.WriteLine("Hasil dari nilai pertama pangkat nilai kedua adalah " & nilai1 ^ nilai2)
            Console.ReadLine()

        Catch ex As InvalidCastException
            Console.WriteLine("Galat: Anda memasukkan karakter non-angka. Aplikasi akan ditutup.")
        Catch Ex As Exception
            Console.WriteLine("Galat: " & Ex.Message)
        Finally
            Console.WriteLine("Silakan muat ulang aplikasi.")
            Console.ReadLine()
        End Try
    End Sub

End Module
