Imports System.Collections

Module Module1

    Sub Main()
        Dim sample As New RefTypeTest

        sample.intvalue = 999
        copyTest(sample)
        Console.WriteLine("copyTest() sample.intvalue = {0}", sample.intvalue)

        sample.intvalue = 999
        copyTest2(sample)
        Console.WriteLine("copyTest2() sample.intvalue = {0}", sample.intvalue)

        sample.intvalue = 999
        refineTest(sample)
        Console.WriteLine("refineTest() sample.intvalue = {0}", sample.intvalue)

        sample.intvalue = 999
        refineTest2(sample)
        Console.WriteLine("refineTest2() sample.intvalue = {0}", sample.intvalue)


        Console.Read()
    End Sub

    Sub copyTest(ByVal sample As RefTypeTest)
        sample = New RefTypeTest()
        sample.intvalue = 1

    End Sub

    Sub copyTest2(ByVal sample As RefTypeTest)
        sample.intvalue = 2
    End Sub

    Sub refineTest(ByRef sample As RefTypeTest)
        sample = New RefTypeTest()
        sample.intvalue = 3

    End Sub

    Sub refineTest2(ByRef sample As RefTypeTest)
        sample.intvalue = 4
    End Sub

End Module
