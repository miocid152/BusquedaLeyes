Public Class AcercaDe

    Private Sub AcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDesactivar_Click(sender As Object, e As EventArgs) Handles btnDesactivar.Click
        If MessageBox.Show("Procederás a desactivar el sistema en este equipo y no podrás utilizarlo más. La licencia proporcionada podrá utilizarse para activar otro equipo. ¿Deseas continuar?", "Desactivar licencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            MsgBox("Desactivado")
        Else
            MsgBox("No desactivado")
        End If
    End Sub
End Class