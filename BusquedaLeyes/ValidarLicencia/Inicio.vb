Imports System.IO
Imports System.Text

Public Class Inicio
    Dim licencia As ValidarLicencia
    Dim activacion As ActivaconWeb
    Dim registro As Registro
    Dim arranqueAplicacion As Process
    Dim rutaExe As String = "C:\Users\ReyPhantom\Source\Repos\BusquedaLeyes\BusquedaLeyes\BusquedaLeyes\bin\Release\BusquedaLeyes.exe"


    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.licencia = New ValidarLicencia()
        Me.registro = New Registro(licencia)
        verificar()

    End Sub

    Private Sub verificar()
        Me.licencia.buscarLincenciamieno()
        If Me.licencia.estado.Equals("OK") Then
            arranqueAplicacion = New Process()
            arranqueAplicacion.StartInfo.FileName = rutaExe
            arranqueAplicacion.StartInfo.Arguments = "ejecutar|" & DateTime.Now.ToString("dd/MM/yyyy") & "|ON"
            arranqueAplicacion.Start()
            Me.Close()
        End If
        If Me.licencia.estado.Equals("ERROR") Then
            MsgBox("Existe un problema en el licenciamiento favor de contactar a los responsables de la aplicacion")
            Me.Close()
        End If
        If Me.licencia.estado.Equals("DIFERENTEEQUIPO") Then
            MsgBox("La instalacion fue en otro equipo de computo favor de contactar a los responsables de la aplicacion")
            Me.Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        CheckForIllegalCrossThreadCalls = False
        Me.activacion = New ActivaconWeb

        If activacion.existeArchiv = False Then
            MsgBox("Revisar la instalacion, No se encontro archivo direccion Web Services")
            Me.Close()
        End If

        Me.activacion.consultar(txtSerial.Text)


        If (activacion.Getestatus.Equals("Error")) Then
            MsgBox("Hubo un problema intente de nuevo, si persiste contactar al responsable de la aplicacion")
        End If
        If (activacion.Getestatus.Equals("NoFound")) Then
            MsgBox("LLave no encontrada Intentar de nuevo, asegurese de tener internet en su equipo")
        End If



        If (activacion.Getestatus.Equals("Activa")) Then

            registro.generarRegistro(activacion)

            If registro.status.Equals("OK") Then
                activacion.consumir()
                If activacion.GetEdoConsumidos.Equals("Consumida") Then
                    MsgBox("La activación ha sido satisfactoria")
                    verificar()
                Else
                    registro.borrarRegistro()
                    activacion.desConsumir()

                    MsgBox("Hubo un error de servicio favor de intentarlo")
                End If

            Else
                registro.borrarRegistro()
                MsgBox("Hubo un error favor de volver a intentarlo")
            End If
        End If


    End Sub

End Class

