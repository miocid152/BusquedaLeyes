Imports BusquedaLeyes.Inicio

Public Class AcercaDe
    Dim servicioWebDesactivar As DesactivacionWeb
    Dim eliminarArchivos As DelRegistros
    Dim llave As String



    Private Sub AcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.llave = Inicio.llave
        btnDesactivar.Hide()
    End Sub

    Private Sub btnDesactivar_Click(sender As Object, e As EventArgs) Handles btnDesactivar.Click
        servicioWebDesactivar = New DesactivacionWeb()
        eliminarArchivos = New DelRegistros(llave)

        If MessageBox.Show("Procederás a desactivar el sistema en este equipo y no podrás utilizarlo más. La licencia " & llave & " proporcionada podrá utilizarse para activar otro equipo. ¿Deseas continuar?", "Desactivar licencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            servicioWebDesactivar.desConsumir(llave)
            eliminarArchivos.borrarRegistro()
            MsgBox("Desactivado")

        Else
            MsgBox("No desactivado")
        End If
    End Sub
End Class