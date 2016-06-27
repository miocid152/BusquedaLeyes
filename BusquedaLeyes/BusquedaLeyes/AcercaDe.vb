Public Class AcercaDe
    Dim acercade2 As AcercaDe
    Private Sub AcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub AcercaDe_GotLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Focus()
    End Sub
End Class