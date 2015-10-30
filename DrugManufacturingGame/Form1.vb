Public Class Form1
    'Testing commits from Visual Studio 2012
    'Testing commits a second time

    Public playerStats, Inventory As New Dictionary(Of String, Integer)
    Public currentCity, day, maxSlots, currentSlots, maxMoney, hoursLeft As Integer
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
        hoursLeft = 24
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

    Private Sub updateSlots()
        lsvwFloor.Items.Clear()

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

    Private Sub wait(ByVal hr As Integer)
        hoursLeft -= hr
        If hoursLeft = 0 Then
            day += 1
            hoursLeft = 24
            Randomize()
        ElseIf hoursLeft < 0 Then
            hoursLeft = 24 + hoursLeft
            day += 1
            Randomize()
        End If
    End Sub
    '================================================================================================================
    '=============================================Screen/UI Update Timers============================================
    '================================================================================================================

    Private Sub tmrScreenUpdate_Tick(sender As Object, e As EventArgs) Handles tmrScreenUpdate.Tick
        Dim lblMaxMoney, lblSHours As New Label
        Me.Controls.Remove(lblMaxMoney)
        Me.Controls.Remove(lblSHours)


        lblDay.Text = day

        lblSHours.Location = New Point((lblDay.Location.X + lblDay.Width + 20), lblDay.Location.Y)
        lblSHours.Size = New Size(63, 12)
        lblSHours.ForeColor = Color.White
        lblSHours.Text = "Hours Left:"

        lblHoursLeft.Location = New Point((lblSHours.Location.X + 60), lblSHours.Location.Y)
        lblHoursLeft.ForeColor = Color.White
        lblHoursLeft.Text = hoursLeft

        lblMoney.Text = FormatCurrency(playerStats("Money"), NumDigitsAfterDecimal:=0)

        lblMaxMoney.Location = New Point((lblMoney.Location.X + lblMoney.Width), lblMoney.Location.Y)
        lblMaxMoney.ForeColor = Color.RosyBrown
        lblMaxMoney.Text = " / " + FormatCurrency(maxMoney, NumDigitsAfterDecimal:=0)


        lblCleanMoney.Text = FormatCurrency(playerStats("CleanMoney"), NumDigitsAfterDecimal:=0)
        Me.Controls.Add(lblMaxMoney)
        Me.Controls.Add(lblSHours)
        Me.Controls.Add(lblHoursLeft)


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
        If txtAddMoney.Text.Trim.Length > 0 Then
            playerStats("Money") += CInt(txtAddMoney.Text)
        Else
            playerStats("Money") += 100
        End If

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
            If playerStats("Money") >= city(currentCity).GetWeedBuyPrice() And city(currentCity).GetWeedQty() > 0 Then
                playerStats("Money") -= city(currentCity).GetWeedBuyPrice()
                Inventory("Weed") += 1
                city(currentCity).WeedMinusQty()
                wait(1)
                updateCityUI()
                updateInventory()

            ElseIf playerStats("CleanMoney") >= city(currentCity).GetWeedBuyPrice() And city(currentCity).GetWeedQty() > 0 Then
                playerStats("CleanMoney") -= city(currentCity).GetWeedBuyPrice()
                Inventory("Weed") += 1
                city(currentCity).WeedMinusQty()
                wait(1)
                updateCityUI()
                updateInventory()
            End If

        ElseIf lsvwCityPrices.FocusedItem.Index = 1 Then    'if focus is white powder
            If playerStats("Money") >= city(currentCity).GetWhitePowderBuyPrice() And city(currentCity).GetWhitePowderQty() > 0 Then
                playerStats("Money") -= city(currentCity).GetWhitePowderBuyPrice()
                Inventory("White Powder") += 1
                city(currentCity).WhitePowderMinusQty()
                wait(1)
                updateCityUI()
                updateInventory()
            ElseIf playerStats("CleanMoney") >= city(currentCity).GetWhitePowderBuyPrice() And city(currentCity).GetWhitePowderQty() > 0 Then
                playerStats("CleanMoney") -= city(currentCity).GetWhitePowderBuyPrice()
                Inventory("White Powder") += 1
                city(currentCity).WhitePowderMinusQty()
                wait(1)
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

                If playerStats("Money") >= maxMoney Then
                    playerStats("Money") = maxMoney
                End If
                updateInventory()
            End If
        ElseIf lsvwInventory.FocusedItem.Index = 1 Then     'if focus is white powder
            If Inventory("White Powder") > 0 Then
                Inventory("White Powder") -= 1
                playerStats("Money") += city(currentCity).GetWhitePowderSellPrice()

                If playerStats("Money") >= maxMoney Then
                    playerStats("Money") = maxMoney
                End If
                updateInventory()
            End If
        End If
    End Sub


    Private Sub btnAddSlot_Click(sender As Object, e As EventArgs) Handles btnAddSlot.Click
        maxSlots += 1
        updateSlots()
    End Sub

    Private Sub btnWait1_Click(sender As Object, e As EventArgs) Handles btnWait1.Click
        wait(1)
    End Sub

    Private Sub btnWait6_Click(sender As Object, e As EventArgs) Handles btnWait6.Click
        wait(6)
    End Sub

End Class

