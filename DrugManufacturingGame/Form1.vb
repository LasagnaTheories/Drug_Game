Public Class Form1
    'Testing commits from Visual Studio 2012
    'Testing commits a second time
    'Laptop commit test
    'Lasagna branch commit

    Public playerStats, Inventory As New Dictionary(Of String, Integer)
    Public currentCity As Integer
    Public city As New List(Of City)


    '================================================================================================================
    '================================================================================================================

    Public sellWeed As New Job(500, 500)
    Public sellWhitePowder As New Job(750, 1000)

    '================================================================================================================
    '================================================================================================================

    Private Sub initializeInventory()
        Inventory.Add("Weed", 0)
        Inventory.Add("White Powder", 0)
        updateInventory()
    End Sub

    Private Sub initializeStats()
        currentCity = 0
        playerStats.Add("Money", 1000)
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
        barJob.Visible = False
        barJob2.Visible = False

        lblWeed.Text = "Weed"
        lblWhitePowder.Text = "White" & vbNewLine & "Powder"

        lblCity.Text = city(currentCity).GetCityName()
        lsvwCityPrices.ShowItemToolTips = True
        '----------Add Current City Prices----------
        Dim Weed As New ListViewItem("Weed")
        Weed.SubItems.Add(city(currentCity).GetWeedBuyPrice())
        Weed.SubItems.Add(city(currentCity).GetWeedSellPrice())
        Weed.ToolTipText = "Profit: " +
            CStr(FormatCurrency(city(currentCity).GetWeedSellPrice() - city(currentCity).GetWeedBuyPrice(), NumDigitsAfterDecimal:=0))
        lsvwCityPrices.Items.Add(Weed)

        Dim WhitePowder As New ListViewItem("White Powder")
        WhitePowder.SubItems.Add(city(currentCity).GetWhitePowderBuyPrice())
        WhitePowder.SubItems.Add(city(currentCity).GetWhitePowderSellPrice())
        WhitePowder.ToolTipText = "Profit: " +
           CStr(FormatCurrency(city(currentCity).GetWhitePowderSellPrice() - city(currentCity).GetWhitePowderBuyPrice(), NumDigitsAfterDecimal:=0))
        lsvwCityPrices.Items.Add(WhitePowder)

        
    End Sub

    Private Sub updateCityUI()
        lsvwCityPrices.Items.Clear()

        Dim Weed As New ListViewItem("Weed")
        Weed.SubItems.Add(city(currentCity).GetWeedBuyPrice())
        Weed.SubItems.Add(city(currentCity).GetWeedSellPrice())
        Weed.ToolTipText = "Profit: " +
            CStr(FormatCurrency(city(currentCity).GetWeedSellPrice() - city(currentCity).GetWeedBuyPrice(), NumDigitsAfterDecimal:=0))
        lsvwCityPrices.Items.Add(Weed)

        Dim WhitePowder As New ListViewItem("White Powder")
        WhitePowder.SubItems.Add(city(currentCity).GetWhitePowderBuyPrice())
        WhitePowder.SubItems.Add(city(currentCity).GetWhitePowderSellPrice())
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
    '================================================================================================================
    '=============================================Screen/UI Update Timers============================================
    '================================================================================================================

    Private Sub tmrScreenUpdate_Tick(sender As Object, e As EventArgs) Handles tmrScreenUpdate.Tick
        lblMoney.Text = FormatCurrency(playerStats("Money"), NumDigitsAfterDecimal:=0)
    End Sub

    Private Sub tmrUIRefresh_Tick(sender As Object, e As EventArgs) Handles tmrUIRefresh.Tick
        lblCity.Text = city(currentCity).GetCityName()

        If playerStats("Money") < city(currentCity).GetWeedBuyPrice() Then              'Color Buy Weed Button
            btnBuyWeed.BackColor = Color.MidnightBlue
            btnBuyWeed.ForeColor = Color.Gray
        Else
            btnBuyWeed.BackColor = Color.DeepSkyBlue
            btnBuyWeed.ForeColor = Color.White
        End If

        If Inventory("Weed") = 0 Then                                                   'Color Sell Weed Button
            btnSellWeed.BackColor = Color.MidnightBlue
            btnSellWeed.ForeColor = Color.Gray
        Else
            btnSellWeed.BackColor = Color.DeepSkyBlue
            btnSellWeed.ForeColor = Color.White
        End If

        If playerStats("Money") < city(currentCity).GetWhitePowderBuyPrice() Then       'Color Buy White Powder Button
            btnBuyWhitePowder.BackColor = Color.MidnightBlue
            btnBuyWhitePowder.ForeColor = Color.Gray
        Else
            btnBuyWhitePowder.BackColor = Color.DeepSkyBlue
            btnBuyWhitePowder.ForeColor = Color.White
        End If

        If Inventory("White Powder") = 0 Then                                           'Color Sell White Powder Button
            btnSellWhitePowder.BackColor = Color.MidnightBlue
            btnSellWhitePowder.ForeColor = Color.Gray
        Else
            btnSellWhitePowder.BackColor = Color.DeepSkyBlue
            btnSellWhitePowder.ForeColor = Color.White
        End If
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
        city(currentCity).RandomizePrices()
        updateCityUI()
    End Sub

    Private Sub btnAddMoney_Click(sender As Object, e As EventArgs) Handles btnAddMoney.Click
        playerStats("Money") += 100
    End Sub

    Private Sub btnRemoveMoney_Click(sender As Object, e As EventArgs) Handles btnRemoveMoney.Click
        playerStats("Money") -= 100
    End Sub

    '================================================================================================================
    '=================================================Buy/Sell Buttons===============================================
    '================================================================================================================

    Private Sub btnBuyWeed_Click(sender As Object, e As EventArgs) Handles btnBuyWeed.Click
        If playerStats("Money") >= city(currentCity).GetWeedBuyPrice() Then
            playerStats("Money") -= city(currentCity).GetWeedBuyPrice()
            Inventory("Weed") += 1
            updateInventory()
        End If
    End Sub

    Private Sub btnBuyWhitePowder_Click(sender As Object, e As EventArgs) Handles btnBuyWhitePowder.Click
        If playerStats("Money") >= city(currentCity).GetWhitePowderBuyPrice() Then
            playerStats("Money") -= city(currentCity).GetWhitePowderBuyPrice()
            Inventory("White Powder") += 1
            updateInventory()
        End If
    End Sub

    Public Sub btnSellWeed_Click(sender As Object, e As EventArgs) Handles btnSellWeed.Click
        If Inventory("Weed") > 0 Then
            tmrWeed.Interval = sellWeed.getDuration / 10
            barJob.Visible = True
            tmrWeed.Enabled = True
        End If
    End Sub

    Private Sub btnSellWhitePowder_Click(sender As Object, e As EventArgs) Handles btnSellWhitePowder.Click
        If Inventory("White Powder") > 0 Then
            tmrWhitePowder.Interval = sellWhitePowder.getDuration / 10
            barJob2.Visible = True
            tmrWhitePowder.Enabled = True
        End If
    End Sub

    '================================================================================================================
    '===================================================Job Timers===================================================
    '================================================================================================================

    Private Sub tmrJob_Tick(sender As Object, e As EventArgs) Handles tmrWeed.Tick

        barJob.Increment(barJob.Step)

        If barJob.Value = barJob.Maximum Then
            tmrWeed.Stop()
            barJob.Value = 0
            barJob.Visible = False
            playerStats("Money") += sellWeed.getReward
            Inventory("Weed") -= 1
            updateInventory()

            If chkRepeatJob.Checked = True And Inventory("Weed") > 0 Then
                barJob.Visible = True
                tmrWeed.Start()
            End If
        End If

    End Sub

    Private Sub tmrJob2_Tick(sender As Object, e As EventArgs) Handles tmrWhitePowder.Tick

        barJob2.Increment(barJob2.Step)

        If barJob2.Value = barJob2.Maximum Then
            tmrWhitePowder.Stop()
            barJob2.Value = 0
            barJob2.Visible = False
            playerStats("Money") += sellWhitePowder.getReward

            If chkRepeatJob2.Checked = True And Inventory("White Powder") > 0 Then
                barJob2.Visible = True
                tmrWhitePowder.Start()
            End If
        End If

    End Sub
End Class
