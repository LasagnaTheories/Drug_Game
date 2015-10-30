Public Class City
    Dim WeedBuyPrice As Integer
    Dim WeedSellPrice As Integer
    Dim WhitePowderBuyPrice As Integer
    Dim WhitePowderSellPrice As Integer
    Dim CityName As String
    Dim WeedQty As Integer
    Dim WhitePowderQty As Integer

    Sub New(ByVal s As String)
        CityName = s
        Randomize()
    End Sub

    Public Sub Randomize()
        Dim rnd As New Random()
        WeedBuyPrice = 100 'Math.Round(rnd.Next(155, 450) / 5) * 5   'Round prices to multiples of 5
        WeedSellPrice = 250 'Math.Round(rnd.Next(280, 675) / 5) * 5
        WhitePowderBuyPrice = 450 'Math.Round(rnd.Next(350, 1200) / 5) * 5
        WhitePowderSellPrice = 1000 'Math.Round(rnd.Next(675, 1500) / 5) * 5
        WeedQty = Math.Round(rnd.Next(2, 50))
        WhitePowderQty = Math.Round(rnd.Next(2, 50))

    End Sub

    Public Function GetCityName() As String
        Return CityName
    End Function

    Public Function GetWeedBuyPrice() As Integer
        Return WeedBuyPrice
    End Function

    Public Function GetWeedSellPrice() As Integer
        Return WeedSellPrice
    End Function

    Public Function GetWhitePowderBuyPrice() As Integer
        Return WhitePowderBuyPrice
    End Function

    Public Function GetWhitePowderSellPrice() As Integer
        Return WhitePowderSellPrice
    End Function

    Public Function GetWeedQty() As Integer
        Return WeedQty
    End Function

    Public Function GetWhitePowderQty() As Integer
        Return WhitePowderQty
    End Function

    Public Sub WeedMinusQty()
        WeedQty -= 1
    End Sub

    Public Sub WhitePowderMinusQty()
        WhitePowderQty -= 1
    End Sub


End Class
