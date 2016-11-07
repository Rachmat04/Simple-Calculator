Module Module1

    Sub Main()
        Console.WriteLine("Kalkulator sederhana")
        Console.WriteLine()

        Console.WriteLine("Masukkan nilai pertama: ")
        Dim nilai1 As Integer = Console.ReadLine()
        Console.WriteLine("Masukkan nilai kedua: ")
        Dim nilai2 As Integer = Console.ReadLine()
        Console.WriteLine()
        Dim nilai3 As Integer
        nilai3 = nilai1 * nilai2
        Console.WriteLine("Hasil perkalian nilai pertama dan kedua adalah " & nilai3)
        Console.ReadLine()
    End Sub

End Module
