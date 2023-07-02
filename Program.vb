Imports System
Imports System.Transactions

Module Program
    Sub Main()
        Dim custmCategory, mvCategory, numOfTickets As Integer
        Dim custmName As String

        Console.WriteLine()
        Console.WriteLine("<><><><><><><><><><><><><>WELCOME TO CINEMA<><><><><><><><><><><><><><><>><>")
        Console.WriteLine()

        Console.WriteLine("[1]Regular Member [2]EPLUS Member")
        Console.Write("Choose Your Category: ")
        custmCategory = Console.ReadLine()

        Console.WriteLine("Choose a movie:  [1] PARTNERS IN CRIME(150)  [2]MY TEACHER(160)  [3]LABYU WIT AN ACCENT(170)")
        mvCategory = Console.ReadLine()

        Console.Write("Number of Tickets: ")
        numOfTickets = Console.ReadLine()

        Console.Write("Your Name:")
        custmName = Console.ReadLine()



        Console.WriteLine()
        Console.Write("<><><><><><><><><><><><><><>RECEIPT<><><><><><><><><><><><><><><><><><>")
        Console.WriteLine()
        'receipt'

        Console.WriteLine("Customer name: {0}", custmName)

        'Check Customer Category'
        If custmCategory = 1 Then
            Console.WriteLine("Category: Regular")
        Else
            Console.WriteLine("Category: Eplus")

        End If

        'Declaring and setting price for movies'
        Dim mvOne, mvTwo, mvThree As Double
        Dim mvTotalOne, mvTotalTwo, mvTotalThree As Double
        Dim mvVatOne, mvVatTwo, mvVatThree As Double
        Dim vat As Double
        Dim ttlPlsVatOne, ttlPlsVatTwo, ttlPlsVatThree As Double
        mvOne = 150
        mvTwo = 160
        mvThree = 170

        vat = 0.12

        'calculations for total of every movie'
        'mv is short for movie'
        mvTotalOne = mvOne * numOfTickets
        mvTotalTwo = mvTwo * numOfTickets
        mvTotalThree = mvThree * numOfTickets

        mvVatOne = mvTotalOne * vat
        mvVatTwo = mvTotalTwo * vat
        mvVatThree = mvTotalThree * vat
        'ttlPls is short for total Plus'
        ttlPlsVatOne = mvTotalOne + mvVatOne
        ttlPlsVatTwo = mvTotalTwo + mvVatTwo
        ttlPlsVatThree = mvTotalThree + mvVatThree

        'Display Quantity'
        Console.WriteLine("Quantity: {0}", numOfTickets)

        'Checking Movie Choice'

        If mvCategory = 1 Then
            Console.WriteLine("Movie: PARTNERS IN CRIME")
            Console.WriteLine("Total: {0}", mvTotalOne)
            Console.WriteLine("Vat: {0}", mvVatOne)
            Console.WriteLine("Total + Vat: {0}", ttlPlsVatOne)


        ElseIf mvCategory = 2 Then
            Console.WriteLine("Movie: MY TEACHER")
            Console.WriteLine("Total: {0}", mvTotalTwo)
            Console.WriteLine("Vat: {0}", mvVatTwo)
            Console.WriteLine("Total + Vat: {0}", ttlPlsVatTwo)

        Else
            Console.WriteLine("Movie: LABYU WITH AN ACCENT")
            Console.WriteLine("Total: {0}", mvTotalThree)
            Console.WriteLine("Vat: {0}", mvVatThree)
            Console.WriteLine("Total + Vat: {0}", ttlPlsVatThree)

        End If

        'Discount Calulations'
        'dct is short for discount and dcted is short for discounted'
        Dim dctMembership, mvdiscountOne, mvdiscountTwo, mvdiscountThree As Double
        Dim dctedTotalOne, dctedTotalTwo, dctedTotalThree As Double

        dctMembership = 0.15
        mvdiscountOne = mvTotalOne * dctMembership
        mvdiscountTwo = mvTotalTwo * dctMembership
        mvdiscountThree = mvTotalThree * dctMembership

        dctedTotalOne = ttlPlsVatOne - mvdiscountOne
        dctedTotalTwo = ttlPlsVatTwo - mvdiscountTwo
        dctedTotalThree = ttlPlsVatThree - mvdiscountThree


        Dim payment, sukle As Integer

        'for customer category one'
        'using nested if statements'
        If custmCategory = 1 And mvCategory = 1 Then
            Console.WriteLine()
            Console.WriteLine("Movie Discount: none")
            Console.WriteLine("TotalW/Discount: {0}", ttlPlsVatOne)
            Console.Write("Payment:")
            payment = Console.ReadLine()
            If payment >= ttlPlsVatOne Then
                sukle = payment - ttlPlsVatOne
                Console.WriteLine("Your sukle is: {0}", sukle)
                Console.WriteLine("xxxxxxxxxxxxxxxSalamat!xxxxxxxxxxxxxxxxx")
            Else
                Console.WriteLine("xxxxxxxxxxxxxKulang pa aba!xxxxxxxxxxxxxx")
            End If

        ElseIf custmCategory = 1 And mvCategory = 2 Then
            Console.WriteLine()
            Console.WriteLine("Movie Discount: None")
            Console.WriteLine("TotalW/Discount: {0}", ttlPlsVatTwo)
            Console.Write("Payment:")
            payment = Console.ReadLine()
            If payment >= ttlPlsVatTwo Then
                sukle = payment - ttlPlsVatTwo
                Console.WriteLine("Your sukle is: {0}", sukle)
                Console.WriteLine("xxxxxxxxxxxSalamat!xxxxxxxxxxxx")
            Else
                Console.WriteLine("Kulang pa aba!")
            End If

        ElseIf custmCategory = 1 And mvCategory = 3 Then
            Console.WriteLine()
            Console.WriteLine("Movie Discount: None")
            Console.WriteLine("TotalW/Discount: {0}", ttlPlsVatThree)
            Console.Write("Payment:")
            payment = Console.ReadLine()
            If payment >= ttlPlsVatThree Then
                sukle = payment - ttlPlsVatThree
                Console.WriteLine("Your sukle is: {0}", sukle)
                Console.WriteLine("xxxxxxxxxxxxxxSalamat!xxxxxxxxxxxxx")
            Else
                Console.WriteLine("xxxxxxxxxxxxKulang pa aba!xxxxxxxxxxxx")
            End If
        End If

        'For Customer Category Two'
        'using nested if statements'
        'sukle and payments'
        If custmCategory = 2 And mvCategory = 1 Then
            Console.WriteLine()
            Console.WriteLine("Movie Discount: {0}", mvdiscountOne)
            Console.WriteLine("TotalW/Discount: {0}", dctedTotalOne)
            Console.Write("Payment:")
            payment = Console.ReadLine()
            If payment >= dctedTotalOne Then
                sukle = payment - dctedTotalOne
                Console.WriteLine("Your sukle is: {0}", sukle)
                Console.WriteLine("xxxxxxxxxxxxxxxSalamat!xxxxxxxxxxxxxxxxx")
            Else
                Console.WriteLine("xxxxxxxxxxxxxKulang pa aba!xxxxxxxxxxxxxx")
            End If

        ElseIf custmCategory = 2 And mvCategory = 2 Then
            Console.WriteLine()
            Console.WriteLine("Movie Discount: {0}", mvdiscountTwo)
            Console.WriteLine("TotalW/Discount: {0}", dctedTotalTwo)
            Console.Write("Payment:")
            payment = Console.ReadLine()
            If payment >= dctedTotalTwo Then
                sukle = payment - dctedTotalTwo
                Console.WriteLine("Your sukle is: {0}", sukle)
                Console.WriteLine("Salamat!")
            Else
                Console.WriteLine("Kulang pa aba!")
            End If

        ElseIf custmCategory = 2 And mvCategory = 3 Then
            Console.WriteLine()
            Console.WriteLine("Movie Discount: {0}", mvdiscountThree)
            Console.WriteLine("TotalW/Discount: {0}", dctedTotalThree)
            Console.Write("Payment:")
            payment = Console.ReadLine()
            If payment >= dctedTotalThree Then
                sukle = payment - dctedTotalThree
                Console.WriteLine("Your sukle is: {0}", sukle)
                Console.WriteLine("Salamat!")
            Else
                Console.WriteLine("Kulang pa aba!")
            End If
        End If


    End Sub
End Module
