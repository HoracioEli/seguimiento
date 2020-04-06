
Public Class FArchivos

    Private Sub EliminarArchivosSeleccionadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarArchivosSeleccionadosToolStripMenuItem.Click
        '
        Call EliminarItems()

    End Sub

    Sub EliminarItems()
        Dim Total As Integer = List_Archivos.Items.Count - 1
        Dim x As Integer
        ' Loop through all items the ListBox.
        For x = 0 To Total
            ' Determine if the item is selected.
            If List_Archivos.GetSelected(x) = True Then
                ' Eliminar items seleccionados
                List_Archivos.Items.RemoveAt(List_Archivos.SelectedIndex)
                Exit For
            End If
        Next x
        If x <> Total Then
            Call EliminarItems()
        End If
    End Sub

    Sub Instancia_MoverArchivos()

        Dim RutaArchivoTema As String = RutaArchivos & "Tema-" & CSng(IdTema)
        Dim RutaArchivoInstancia As String = RutaArchivoTema & "\" & "Instancia-" & CStr(IdInstancia)

        Dim x As Byte
        Try


            If IdTema = 0 Or IdInstancia = 0 Then
                Exit Sub
            End If

            For x = 0 To List_Archivos.Items.Count - 1
                RutaOrigen = List_Archivos.Items(x)
                Call BuscarNombreArchivo()
                RutaDestino = RutaArchivoInstancia & "\" & NombreArchivo
                My.Computer.FileSystem.MoveFile(RutaOrigen, RutaDestino)
            Next x
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub BuscarNombreArchivo()
        Dim Ultimo As Byte = 0
        Dim Posicion As Byte
        Dim RutaOrigenCortada As String = RutaOrigen
        Dim Largo As String

        Try
            While Ultimo = 0
                Posicion = RutaOrigenCortada.IndexOf("\")
                Largo = Len(RutaOrigenCortada) - Posicion - 1
                If Posicion = 0 Then
                    Exit While
                End If
                RutaOrigenCortada = RutaOrigenCortada.Substring(Posicion + 1, Largo)
            End While
        Catch ex As Exception
            NombreArchivo = RutaOrigenCortada
        End Try


    End Sub

    Private Sub MoverArchivosAInstanciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoverArchivosAInstanciaToolStripMenuItem.Click
        Call Instancia_MoverArchivos()
        Call ListarArchivos()
        Me.Dispose()

    End Sub


    Private Sub ListarArchivos()
        Dim Ruta As String = "d:\Users\Horacio\Downloads\Adjuntos"
        List_Archivos.Items.Clear()

        Dim fileNames = My.Computer.FileSystem.GetFiles(
            Ruta, FileIO.SearchOption.SearchTopLevelOnly, "*.*")

        For Each fileName As String In fileNames
            List_Archivos.Items.Add(fileName)
        Next



    End Sub




    Private Sub FArchivos_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Call BuscarNombreArchivo()
    End Sub
End Class