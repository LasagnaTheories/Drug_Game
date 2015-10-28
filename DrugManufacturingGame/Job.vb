Public Class Job
    Dim reward As Integer
    Dim duration As Integer

    Sub New(ByVal r As Integer, d As Integer)
        reward = r
        duration = d
    End Sub

    Sub New()
        reward = 0
        duration = 0
    End Sub

    Public Sub setReward(ByVal r As Integer)
        reward = r
    End Sub

    Public Sub setDuration(ByVal d As Integer)
        duration = d
    End Sub

    Public Function getReward()
        Return reward
    End Function

    Public Function getDuration()
        Return duration
    End Function
End Class
