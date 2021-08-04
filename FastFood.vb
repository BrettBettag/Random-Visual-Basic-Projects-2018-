Public Class frmFastFood
    ' Class level Constants as Decimal values
    Const TAX_RATE As Decimal = 0.0875D     ' 8.75% tax rate
    Const PRICE_HAMBURGER As Decimal = 2.75D
    Const PRICE_FISH_SANDWICH As Decimal = 0.0875D
    Const PRICE_CHICKEN_SANDWICH As Decimal = 0.0875D
    Const PRICE_CHEESE As Decimal = 0.0875D
    Const PRICE_TOMATO As Decimal = 0.0875D

    ' Class Level Variables - Subtotal, Tax and Total
    Dim subtotal As Decimal
    Dim tax As Decimal
    Dim total As Decimal

    ' Form Load Event
    '   Initialize variables and clear the form
    Private Sub frmFastFood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeVariables()
        ClearTheCustomerSelections()
        ClearTheReceipt()
    End Sub

    Private Sub InitializeVariables()  ' for each new customer
        subtotal = 0
        tax = 0
        total = 0
    End Sub

    Private Sub ClearTheCustomerSelections()  ' for each new customer 
        radNoSandwich.Checked = True
        chkCheese.Checked = False
        chkTomato.Checked = False

        radNoDrink.Checked = True
    End Sub

    Private Sub ClearTheReceipt()
        lstTotal.Items.Clear()  ' clear the customer receipt
        lstOrderReceipt.Items.Clear()
    End Sub

    Private Sub ComputeCurrentSelection()
        If radHamburger.Checked Then
            subtotal += PRICE_HAMBURGER
            Dim HamburgerItem As String =
                PRICE_HAMBURGER.ToString("C") & " Hamburger "
            lstOrderReceipt.Items.Add(HamburgerItem)
        End If
        If radFishSandwich.Checked Then
            subtotal += PRICE_FISH_SANDWICH
            Dim FishSandwichItem As String =
                PRICE_FISH_SANDWICH.ToString("C") & " Fish Sandwich "
            lstOrderReceipt.Items.Add(HamburgerItem)
        End If
        If radChickenSandwich.Checked Then
            subtotal += PRICE_HAMBURGER
            Dim HamburgerItem As String =
                PRICE_CHICKEN_SANDWICH.ToString("C") & " Chicken Sandwich "
            lstOrderReceipt.Items.Add(ChickenSandwichItem)
        End If
        If chkCheese.Checked Then
            subtotal += PRICE_HAMBURGER
            Dim HamburgerItem As String =
                PRICE_CHEESE.ToString("C") & " Cheese "
            lstOrderReceipt.Items.Add(CheeseItem)
        End If
        If chkTomato.Checked Then
            subtotal += PRICE_HAMBURGER
            Dim HamburgerItem As String =
                PRICE_TOMATO.ToString("C") & " Tomato "
            lstOrderReceipt.Items.Add(TomatoItem)
        End If
    End Sub

    Private Sub UpdateTotal()
        ' Clear the previous subtotal, tax and total
        lstTotal.Items.Clear()
        ' Compute and display the subtotal
        lstTotal.Items.Add("SUB TOTAL = " & subtotal.ToString("C"))
        ' Compute and display the tax
        tax = subtotal * TAX_RATE
        lstTotal.Items.Add("    TAX = " & tax.ToString("C"))
        ' Compute and display the total
        total = subtotal + tax
        lstTotal.Items.Add("    TOTAL = " & total.ToString("C"))

        ' Separate each person's order on the receipt 
        lstOrderReceipt.Items.Add("----------------------")
    End Sub

    Private Sub btnEnter_Click()
        ComputeCurrentSelection()
        UpdateTotal()
        ClearTheCustomerSelections()
    End Sub

    Private Sub btnClear_Click()
        InitializeVariables()
        ClearTheCustomerSelections()
        ClearTheReceipt()
    End Sub

    Private Sub btnExit_Click()
        Me.Close()
    End Sub
End Class