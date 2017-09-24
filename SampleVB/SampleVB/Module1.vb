Imports System.Collections

Module Module1

    Sub Main()
        Dim sample As New Sample

        sample.test1 = 999
        copyTest(sample)
        Console.WriteLine("copyTest() sample.test1 = {0}", sample.test1)

        sample.test1 = 999
        copyTest2(sample)
        Console.WriteLine("copyTest2() sample.test1 = {0}", sample.test1)

        sample.test1 = 999
        refineTest(sample)
        Console.WriteLine("refineTest() sample.test1 = {0}", sample.test1)

        sample.test1 = 999
        refineTest2(sample)
        Console.WriteLine("refineTest2() sample.test1 = {0}", sample.test1)


        Console.Read()
    End Sub

    Sub copyTest(ByVal sample As Sample)
        sample = New Sample()
        sample.test1 = 1

    End Sub

    Sub copyTest2(ByVal sample As Sample)
        sample.test1 = 2
    End Sub

    Sub refineTest(ByRef sample As Sample)
        sample = New Sample()
        sample.test1 = 3

    End Sub

    Sub refineTest2(ByRef sample As Sample)
        sample.test1 = 4
    End Sub

End Module
