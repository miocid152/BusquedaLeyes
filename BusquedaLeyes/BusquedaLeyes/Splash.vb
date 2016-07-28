Public NotInheritable Class Splash

    'TODO: Este formulario se puede establecer fácilmente como pantalla de presentación para la aplicación desde la pestaña "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configure el texto del cuadro de diálogo en tiempo de ejecución según la información del ensamblado de la aplicación.  

        'TODO: Personalice la información del ensamblado de la aplicación en el panel "Aplicación" del cuadro de diálogo 
        '  propiedades del proyecto (bajo el menú "Proyecto").

        'Título de la aplicación
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = "Búsqueda de Artículos y Leyes"
        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
            ApplicationTitle.Text = "Búsqueda de Artículos y Leyes"
        End If

        'Dé formato a la información de versión usando el texto establecido en el control de versiones en tiempo de diseño como
        '  cadena de formato.  Esto le permite una localización efectiva si lo desea.
        '  Se pudo incluir la información de compilación y revisión usando el siguiente código y cambiando el 
        '  texto en tiempo de diseño del control de versiones a "Versión {0}.{1:00}.{2}.{3}" o algo parecido.  Consulte
        '  String.Format() en la Ayuda para obtener más información.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Información de Copyright
        Copyright.Text = My.Application.Info.Copyright
        modoParametros()

    End Sub
    Private Sub modoParametros()
        Dim argumento As String
        If Environment.GetCommandLineArgs.Length > 1 Then
            argumento = Environment.GetCommandLineArgs(1)
            Dim list As IList(Of String) = New List(Of String)(argumento.Split(New String() {"|"}, StringSplitOptions.None))
            If list.Count > 2 Then
                If Not (list.Item(0).ToString.Equals("ejecutar") And
                    list.Item(1).ToString.Equals(DateTime.Now.ToString("dd/MM/yyyy")) And
                     list.Item(2).ToString.Equals("ON")) Then
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub

End Class
