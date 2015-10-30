Public Class Form1
    'Testing commits from Visual Studio 2012
    'Testing commits a second time

    Public playerStats, Inventory As New Dictionary(Of String, Integer)
    Public currentCity, day, maxSlots, currentSlots, maxMoney As Integer
    Public city As New List(Of City)

    Private Sub initializeInventory()
        Inventory.Add("Weed", 0)
        Inventory.Add("White Powder", 0)
        updateInventory()
    End Sub

    Private Sub initializeStats()
        currentCity = 0
        day = 1
        maxSlots = 16
        maxMoney = 10000
        playerStats.Add("Money", 1000)
        playerStats.Add("CleanMoney", 0)
    End Sub

    Private Sub initializeCities()
        Dim city1 As New City("Kansasville")
        Dim city2 As New City("City 2")
        city.Add(city1)
        city.Add(city2)
    End Sub

    Private Sub initializeUI()
        tmrScreenUpdate.Enabled = True
        tmrUIRefresh.Enabled = True

        lblCity.Text = city(currentCity).GetCityName()
        lsvwCityPrices.ShowItemToolTips = True
        '----------Add Current City Prices----------
        Dim Weed As New ListViewItem("Weed")
        Weed.SubItems.Add(city(currentCity).GetWeedBuyPrice())
        Weed.SubItems.Add(city(currentCity).GetWeedQty())
        Weed.ToolTipText = "Profit: " +
            CStr(FormatCurrency(city(currentCity).GetWeedSellPrice() - city(currentCity).GetWeedBuyPrice(), NumDigitsAfterDecimal:=0))
        lsvwCityPrices.Items.Add(Weed)

        Dim WhitePowder As New ListViewItem("White Powder")
        WhitePowder.SubItems.Add(city(currentCity).GetWhitePowderBuyPrice())
        WhitePowder.SubItems.Add(city(currentCity).GetWhitePowderQty())
        WhitePowder.ToolTipText = "Profit: " +
           CStr(FormatCurrency(city(currentCity).GetWhitePowderSellPrice() - city(currentCity).GetWhitePowderBuyPrice(), NumDigitsAfterDecimal:=0))
        lsvwCityPrices.Items.Add(WhitePowder)

        '---Add Floor slots---
        Dim Slots As New ListViewItem("(Free Slots)")
        Slots.ForeColor = Color.DimGray
        Slots.SubItems.Add(maxSlots)
        lsvwFloor.Items.Add(Slots)


        
    End Sub

    Private Sub updateCityUI()
        lsvwCityPrices.Items.Clear()

        Dim Weed As New ListViewItem("Weed")
        Weed.SubItems.Add(city(currentCity).GetWeedBuyPrice())
        Weed.SubItems.Add(city(currentCity).GetWeedQty())
        Weed.ToolTipText = "Profit: " +
            CStr(FormatCurrency(city(currentCity).GetWeedSellPrice() - city(currentCity).GetWeedBuyPrice(), NumDigitsAfterDecimal:=0))
        lsvwCityPrices.Items.Add(Weed)

        Dim WhitePowder As New ListViewItem("White Powder")
        WhitePowder.SubItems.Add(city(currentCity).GetWhitePowderBuyPrice())
        WhitePowder.SubItems.Add(city(currentCity).GetWhitePowderQty())
        WhitePowder.ToolTipText = "Profit: " +
            CStr(FormatCurrency(city(currentCity).GetWhitePowderSellPrice() - city(currentCity).GetWhitePowderBuyPrice(), NumDigitsAfterDecimal:=0))
        lsvwCityPrices.Items.Add(WhitePowder)
    End Sub

    Private Sub updateSlots()

    End Sub

    Private Sub updateInventory()
        lsvwInventory.Items.Clear()

        Dim Weed As New ListViewItem("Weed")
        Weed.SubItems.Add(Inventory("Weed"))
        lsvwInventory.Items.Add(Weed)

        Dim WhitePowder As New ListViewItem("White Powder")
        WhitePowder.SubItems.Add(Inventory("White Powder"))
        lsvwInventory.Items.Add(WhitePowder)
    End Sub

    Private Sub checkStats()
        'check if stats already exist, otherwise create new stats
        initializeStats()
        initializeInventory()
    End Sub
    '================================================================================================================
    '=============================================Screen/UI Update Timers============================================
    '================================================================================================================

    Private Sub tmrScreenUpdate_Tick(sender As Object, e As EventArgs) Handles tmrScreenUpdate.Tick
        lblDay.Text = day
        lblMoney.Text = FormatCurrency(playerStats("Money"), NumDigitsAfterDecimal:=0)
        lblCleanMoney.Text = FormatCurrency(playerStats("CleanMoney"), NumDigitsAfterDecimal:=0)
    End Sub

    Private Sub tmrUIRefresh_Tick(sender As Object, e As EventArgs) Handles tmrUIRefresh.Tick
        lblCity.Text = city(currentCity).GetCityName()

    End Sub

    '================================================================================================================

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeCities()
        checkStats()
        initializeUI()
    End Sub
    '================================================================================================================
    '==================================================Cheat Buttons=================================================
    '================================================================================================================

    Private Sub btnRandomizePrices_Click(sender As Object, e As EventArgs) Handles btnRandomizePrices.Click
        city(currentCity).Randomize()
        updateCityUI()
    End Sub

    Private Sub btnAddCleanMoney_Click(sender As Object, e As EventArgs) Handles btnAddCleanMoney.Click
        playerStats("CleanMoney") += 100
    End Sub

    Private Sub btnAddMoney_Click(sender As Object, e As EventArgs) Handles btnAddMoney.Click
        playerStats("Money") += 100
    End Sub


    Private Sub btnRemoveMoney_Click(sender As Object, e As EventArgs) Handles btnRemoveMoney.Click
        playerStats("Money") -= 100
    End Sub

    '================================================================================================================
    '================================================================================================================

    Private Sub btnNextDay_Click(sender As Object, e As EventArgs) Handles btnNextDay.Click
        day += 1
        city(currentCity).Randomize()
        updateCityUI()
    End Sub

    '================================================================================================================
    '=================================================Buy/Sell Buttons===============================================
    '================================================================================================================
    ' Tries to pay with dirty money, but if there isn't enough dirty money, pays with clean money

    Private Sub lsvwCityPrices_DoubleClick(sender As Object, e As EventArgs) Handles lsvwCityPrices.DoubleClick
        If lsvwCityPrices.FocusedItem.Index = 0 Then        'if focus is weed
            If playerStats("Money") >= city(currentCity).GetWeedBuyPrice() Then
                playerStats("Money") -= city(currentCity).GetWeedBuyPrice()
                Inventory("Weed") += 1
                city(currentCity).WeedMinusQty()
                updateCityUI()
                updateInventory()

            ElseIf playerStats("CleanMoney") >= city(currentCity).GetWeedBuyPrice() Then
                playerStats("CleanMoney") -= city(currentCity).GetWeedBuyPrice()
                Inventory("Weed") += 1
                city(currentCity).WeedMinusQty()
                updateCityUI()
                updateInventory()
            End If

        ElseIf lsvwCityPrices.FocusedItem.Index = 1 Then    'if focus is white powder
            If playerStats("Money") >= city(currentCity).GetWhitePowderBuyPrice() Then
                playerStats("Money") -= city(currentCity).GetWhitePowderBuyPrice()
                Inventory("White Powder") += 1
                city(currentCity).WhitePowderMinusQty()
                updateCityUI()
                updateInventory()
            ElseIf playerStats("CleanMoney") >= city(currentCity).GetWhitePowderBuyPrice() Then
                playerStats("CleanMoney") -= city(currentCity).GetWhitePowderBuyPrice()
                Inventory("White Powder") += 1
                city(currentCity).WhitePowderMinusQty()
                updateCityUI()
                updateInventory()

            End If
        End If
    End Sub


    
    Private Sub lsvwInventory_DoubleClick(sender As Object, e As EventArgs) Handles lsvwInventory.DoubleClick, lsvwFloor.DoubleClick
        If lsvwInventory.FocusedItem.Index = 0 Then         'if focus is weed
            If Inventory("Weed") > 0 Then
                Inventory("Weed") -= 1
                playerStats("Money") += city(currentCity).GetWeedSellPrice()
                updateInventory()
            End If
        ElseIf lsvwInventory.FocusedItem.Index = 1 Then     'if focus is white powder
            If Inventory("White Powder") > 0 Then
                Inventory("White Powder") -= 1
                playerStats("Money") += city(currentCity).GetWhitePowderSellPrice()
                updateInventory()
            End If
        End If
    End Sub

    
    Private Sub btnAddSlot_Click(sender As Object, e As EventArgs) Handles btnAddSlot.Click
        maxSlots += 1
    End Sub
End Class

