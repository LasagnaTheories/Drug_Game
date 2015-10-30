Public Class City
    Dim WeedBuyPrice As Integer
    Dim WeedSellPrice As Integer
    Dim WhitePowderBuyPrice As Integer
    Dim WhitePowderSellPrice As Integer
    Dim CityName As String

    Sub New(ByVal s As String)
        CityName = s
        RandomizePrices()
    End Sub

    Public Sub RandomizePrices()
        Dim rnd As New Random()
        WeedBuyPrice = Math.Round(rnd.Next(155, 450) / 5) * 5
        WeedSellPrice = Math.Round(rnd.Next(280, 675) / 5) * 5
        WhitePowderBuyPrice = Math.Round(rnd.Next(350, 1200) / 5) * 5
        WhitePowderSellPrice = Math.Round(rnd.Next(675, 1500) / 5) * 5
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


End Class
