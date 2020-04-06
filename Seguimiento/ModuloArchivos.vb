Module ModuloArchivos
    Public RutaMensajes As String = "C:\Publico\Seguimiento\Archivos\Mensajes\"
    Sub Archivos_Mover()
        Dim RutaOrigen As String = "d:\Users\Horacio\Downloads\Adjuntos"
        ' Set the default directory of the folder browser to the current directory.

        'My.Computer.FileSystem.CurrentDirectory = RutaOrigen
        'FArchivos.FolderBrowserDialog1.SelectedPath = My.Computer.FileSystem.CurrentDirectory

        'ListarArchivos()
        Call ListFiles(RutaOrigen)

    End Sub

    Sub ListarArchivos()
        If FArchivos.FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ' List files in the folder.
            ListFiles(FArchivos.FolderBrowserDialog1.SelectedPath)

        End If
    End Sub

    Private Sub ListFiles(ByVal RutaOrigen As String)
        ' Dim Ruta As String = "d:\Users\Horacio\Downloads\Adjuntos"
        FArchivos.List_Archivos.Items.Clear()

        Dim fileNames = My.Computer.FileSystem.GetFiles(
            RutaOrigen, FileIO.SearchOption.SearchTopLevelOnly, "*.*")

        For Each fileName As String In fileNames
            FArchivos.List_Archivos.Items.Add(fileName)
        Next

        If FArchivos.List_Archivos.Items.Count > 0 Then
            'es para crear los directorios en donde se cargaran los archivos
            Call Instancia_GuardarArchivos()
            FArchivos.ShowDialog()
        End If

    End Sub

    Sub Instancia_GuardarArchivos()
        Dim RutaArchivoTema As String = RutaArchivos & "Tema-" & CSng(IdTema)
        Dim RutaArchivoInstancia As String = RutaArchivoTema & "\" & "Instancia-" & CStr(IdInstancia)

        My.Computer.FileSystem.CreateDirectory(RutaArchivoTema)
        My.Computer.FileSystem.CreateDirectory(RutaArchivoInstancia)
        'Me.WindowState = FormWindowState.Minimized
        'OpenFileDialog1.InitialDirectory = RutaArchivoInstancia & "\"
        'OpenFileDialog1.ShowDialog()
        'Me.WindowState = FormWindowState.Normal
    End Sub


    Sub BorrarCaracteresConflictivos()

        TextoAAnalizar = Replace(TextoAAnalizar, "'", " ")

    End Sub


End Module
