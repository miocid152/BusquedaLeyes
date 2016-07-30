Public Class DelRegistros
    Private rutaArchivo As String = "bqales.db1"
    Private rutaRegEdit As String = "HKEY_LOCAL_MACHINE\SOFTWARE\BusqLey"
    Private archivoRegedit As String = "llave"
    Private llave

    Public Sub New(llave As String)
        Me.llave = llave
    End Sub

    Public Sub borrarRegistro()
        Dim exists As Boolean

        Dim readValue = My.Computer.Registry.GetValue(rutaRegEdit, archivoRegedit, Nothing)

        If Not (readValue Is Nothing) Then
            'My.Computer.Registry.LocalMachine.DeleteValue(rutaRegEdit)
            My.Computer.Registry.SetValue(rutaRegEdit, archivoRegedit, " ")
        End If

        exists = System.IO.File.Exists(rutaArchivo)
        If exists Then
            My.Computer.FileSystem.DeleteFile(rutaArchivo)
        End If
    End Sub









End Class
