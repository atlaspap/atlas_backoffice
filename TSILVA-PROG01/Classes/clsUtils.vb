

Public Class clsNav
    Public Property Max_Registos As Integer
    Public Property Registo_Atual As Integer

    Sub New()

    End Sub
    Sub New(pMax As Integer)
        Me.Max_Registos = pMax
        Me.Registo_Atual = If(pMax > 0, 1, 0)
    End Sub

    Public Function Anterior() As Integer

        Registo_Atual = If(Registo_Atual > 1, Registo_Atual - 1, Registo_Atual)

        Return Registo_Atual
    End Function

    Public Function Seguinte() As Integer
        Registo_Atual = If(Registo_Atual < Max_Registos, Registo_Atual + 1, Registo_Atual)

        Return Registo_Atual
    End Function
    Public Function Primeiro() As Integer
        Registo_Atual = If(Max_Registos > 0, 1, 0)
        Return Registo_Atual
    End Function
    Public Function Ultimo() As Integer
        Registo_Atual = Max_Registos
        Return Registo_Atual
    End Function
End Class
