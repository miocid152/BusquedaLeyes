Imports System.IO
Imports System.Text
Imports ValidarLicencia

Public Class Registro
    Private licencia As ValidarLicencia
    Private activacion As ActivaconWeb
    Dim llave As String
    Public status As String

    Public Sub New(licencia As ValidarLicencia)
        Me.licencia = licencia
    End Sub
    Public Sub borrarRegistro()
        Dim exists As Boolean
        Dim list As IList(Of String) = New List(Of String)(licencia.GetRutaRegEdit.Split(New String() {"\"}, StringSplitOptions.None))

        Dim readValue = My.Computer.Registry.GetValue(licencia.GetRutaRegEdit, licencia.GetArchivoRegedito, Nothing)

        If Not (readValue Is Nothing) Then
            My.Computer.Registry.LocalMachine.DeleteSubKey(list.Item(2).ToString)
        End If

        exists = System.IO.File.Exists(licencia.GetRutaArchivo)
        If exists Then
            My.Computer.FileSystem.DeleteFile(licencia.GetRutaArchivo)
        End If
    End Sub
    Public Sub generarRegistro(activacion As ActivaconWeb)
        Me.activacion = activacion
        construirRegEdit()
        construirArchivo()
    End Sub

    Private Sub construirArchivo()
        'Dim ruta As String = "prueba.db1"
        Dim exists As Boolean
        If status = "OK" Then


            exists = System.IO.File.Exists(licencia.GetRutaArchivo)
            If exists Then
                My.Computer.FileSystem.DeleteFile(licencia.GetRutaArchivo)
            End If

            'Else
            Dim fs As FileStream = File.Create(licencia.GetRutaArchivo)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(activacion.GetLlave & "|" & licencia.GetNombreEquipo)
            fs.Write(info, 0, info.Length)
            fs.Close()

            exists = System.IO.File.Exists(licencia.GetRutaArchivo)
            If exists Then
                status = "OK"
            Else
                status = "ERROR"
            End If
        End If
    End Sub
    '    Private rutaArchivo As String = "bqales.db1"
    'Private rutaRegEdit As String = "HKEY_LOCAL_MACHINE\BusqLey"
    'Private GetArchivoRegedit As String = "llave"
    Private Sub construirRegEdit()

        Dim list As IList(Of String) = New List(Of String)(licencia.GetRutaRegEdit.Split(New String() {"\"}, StringSplitOptions.None))
        'MsgBox(list.Item(2).ToString)

        My.Computer.Registry.LocalMachine.SetValue(licencia.GetRutaRegEdit, list.Item(2).ToString)
        Me.llave = convertir(activacion.GetLlave, licencia.GetNombreEquipo)
        My.Computer.Registry.SetValue(licencia.GetRutaRegEdit,
                    licencia.GetArchivoRegedito, llave)
        Dim readValue = My.Computer.Registry.GetValue(licencia.GetRutaRegEdit, licencia.GetArchivoRegedito, Nothing)

        If readValue Is Nothing Then
            status = "ERROR"
        Else
            status = "OK"

        End If
    End Sub



    Private Function convertir(llave As String, maquin1 As String) As String
        Dim retorno As String = ""
        Dim maquina As String
        Dim list As IList(Of String) = New List(Of String)(llave.Split(New String() {"|"}, StringSplitOptions.None))
        Dim contador As Integer
        maquina = New String(maquin1.OrderBy(Function(c) c).ToArray())
        For Each element As String In list
            contador += 1
            retorno = retorno & New String(element.OrderBy(Function(c) c).ToArray())
            If contador <= 5 Then
                retorno = retorno & "|"
            End If
        Next
        retorno = retorno & maquina

        Return retorno
    End Function

End Class
