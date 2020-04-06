Imports System.IO
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Conectarse()
        Call Estado_Listar()
    End Sub

    Private Sub txProductor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txProductor.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Productor_Buscar()
        End If

    End Sub

    Private Sub List_Resultado_Click(sender As Object, e As EventArgs) Handles List_Resultado.Click
        Call BuscarDesdeList()
    End Sub

    Private Sub List_Resultado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles List_Resultado.KeyPress
        If e.KeyChar = Chr(13) Then
            Call BuscarDesdeList()
        End If

    End Sub

    Private Sub EditarProductorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If IdProductor = 0 Then
            Mensaje = "Primeramente debe seleccionar el PRODUCTOR que desea editar"
            MsgBox(Mensaje, MsgBoxStyle.Critical, "DATO FALTANTE")
            txProductor.SelectAll()
            Exit Sub
        End If


        Productor = InputBox("Ingresar el Nombre correcto del PRODUCTOR", "EDITAR PRODUCTOR", Productor)
        Productor = UCase(Productor)

        If Len(Productor) = 0 Then
            Exit Sub
        End If

        Call Productor_Actualizar()
        txProductor.Text = Productor
        txAsegurado.SelectAll()



    End Sub

    Private Sub EditarAseguradoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If IdAsegurado = 0 Then
            Mensaje = "Primeramente debe seleccionar el ASEGURADO que desea editar"
            MsgBox(Mensaje, MsgBoxStyle.Critical, "DATO FALTANTE")
            txAsegurado.SelectAll()
            Exit Sub
        End If


        Asegurado = InputBox("Ingresar el Nombre correcto del ASEGURADO", "EDITAR ASEGURADO", Asegurado)
        Asegurado = UCase(Asegurado)

        If Len(Asegurado) = 0 Then
            Exit Sub
        End If

        Call Asegurado_Actualizar()
        txAsegurado.Text = Asegurado
        txEmpleado.SelectAll()

    End Sub

    Private Sub txAsegurado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txAsegurado.KeyPress

        If e.KeyChar = Chr(13) Then
            Call Asegurado_Buscar()
        End If

    End Sub

    Private Sub txEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txEmpleado.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Empleado_Buscar()
        End If
    End Sub

    Private Sub EditarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If IdEmpleado = 0 Then
            Mensaje = "Primeramente debe seleccionar el EMPLEADO que desea editar"
            MsgBox(Mensaje, MsgBoxStyle.Critical, "DATO FALTANTE")
            txEmpleado.SelectAll()
            Exit Sub
        End If


        Empleado = InputBox("Ingresar el Nombre correcto del EMPLEADO", "EDITAR EMPLEADO", Empleado)
        Empleado = UCase(Empleado)

        If Len(Empleado) = 0 Then
            Exit Sub
        End If

        Call Empleado_Actualizar()
        txEmpleado.Text = Empleado
        txGrupo.SelectAll()
    End Sub

    Sub Controlaringreso()
        Controlado = 0
        Poliza = TxPoliza.Text
        Cotizacion = txCotizacion.Text
        If txProductor.Text <> Nothing Then
            Call Productor_Buscar()
            If Controlado = 0 Then
                txProductor.Select()
                txProductor.SelectAll()
                MsgBox("Deben realizarse las correcciones para poder ingresar el tema", MsgBoxStyle.Critical, "OPERACION ABORTADA")
                Exit Sub
            End If
        End If

        If txAsegurado.Text <> Nothing Then
            Call Asegurado_Buscar()
            If Controlado = 0 Then
                txAsegurado.Select()
                txAsegurado.SelectAll()
                MsgBox("Deben realizarse las correcciones para poder ingresar el tema", MsgBoxStyle.Critical, "OPERACION ABORTADA")
                Exit Sub
            End If
        End If

        If txEmpleado.Text <> Nothing Then
            Call Empleado_Buscar()
            If Controlado = 0 Then
                txEmpleado.Select()
                txEmpleado.SelectAll()
                MsgBox("Deben realizarse las correcciones para poder ingresar el tema", MsgBoxStyle.Critical, "OPERACION ABORTADA")
                Exit Sub
            End If
        End If


        ' Call Estado()
        Call Estado_Buscar()

        If Controlado = 0 Then
            CboEstado.Select()
            MsgBox("Deben realizarse las correcciones para poder ingresar el tema", MsgBoxStyle.Critical, "OPERACION ABORTADA")
            Exit Sub
        End If

        Controlado = 0

        If TxPoliza.Text <> Nothing Then
            If Len(TxPoliza.Text) <> 17 Then
                MsgBox("Controlar Nro de Póliza (tiene que tener 17 digitos)", MsgBoxStyle.Critical, "DATOS ERRONEOS")
                TxPoliza.Select()
                TxPoliza.SelectAll()
                Exit Sub
            End If
        End If

        If txCotizacion.Text <> Nothing Then
            If Len(txCotizacion.Text) <> 14 Then
                MsgBox("Controlar Nro de COTIZACION (tiene que tener 14 digitos)", MsgBoxStyle.Critical, "DATOS ERRONEOS")
                txCotizacion.Select()
                txCotizacion.SelectAll()
                Exit Sub
            End If
        End If

        If IdEstado = 0 Then
            MsgBox("Falta indicar el ESTADO de este TEMA", MsgBoxStyle.Critical, "DATOS FALTANTES")
            CboEstado.Select()
            Exit Sub
        End If

        Titulo = InputBox("Se puede agregar un pequeño resumen del tema", "AGREGAR TITULO DEL TEMA", TxAsunto.Text & Titulo)



        Controlado = 1
    End Sub



    Private Sub TxPoliza_Leave(sender As Object, e As EventArgs) Handles TxPoliza.Leave
        If TxPoliza.Text <> Nothing Then
            Call Poliza_Buscar_Existente()
        End If
    End Sub

    Private Sub txCotizacion_Leave(sender As Object, e As EventArgs) Handles txCotizacion.Leave
        If txCotizacion.Text <> Nothing Then
            Cotizacion_Buscar_Existente()

        End If

    End Sub

    Private Sub txGrupo_Leave(sender As Object, e As EventArgs) Handles txGrupo.Leave
        Grupo = txGrupo.Text
    End Sub

    Private Sub CboEstado_Leave(sender As Object, e As EventArgs) Handles CboEstado.Leave
        Call Estado_BuscarID()
    End Sub



    Sub LimpiarControles()
        IdTema = 0
        IdInstancia = 0
        IdProductor = 0
        txProductor.Text = Nothing
        IdAsegurado = 0
        txAsegurado.Text = Nothing
        IdEmpleado = 0
        txEmpleado.Text = Nothing
        TxAsunto.Text = Nothing
        txGrupo.Text = Nothing
        rtxTareasPendientes.Text = Nothing
        rtxMensaje.Text = Nothing
        Call Estado_Listar()
        TxPoliza.Text = Nothing
        txCotizacion.Text = Nothing
        Poliza = Nothing
        Cotizacion = Nothing
        Empleado = Nothing
        Titulo = Nothing
        dgv_Resultado.Rows.Clear()
        DGV_Instancias.Rows.Clear()
        TxPoliza.Select()

    End Sub

    Sub LimpiarControlesInstancia()
        IdInstancia = 0
        TxAsunto.Text = Nothing
        rtxMensaje.Text = Nothing
        TxAsunto.Select()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscarTema.Click
        IdTema = 0
        IdInstancia = 0

        Titulo = InputBox("Tiene la posibilidad de agregar el TITULO a buscar o bien dejarlo en blanco", "AGREGAR TITULO", TxAsunto.Text)
        Call Temas_Buscar()
    End Sub

    Private Sub dgv_Resultado_Click(sender As Object, e As EventArgs) Handles dgv_Resultado.Click
        IdTema = CLng(dgv_Resultado.CurrentRow.Cells(0).Value.ToString)
        Call Temas_Busqueda_ID()
        GBotonesInstancia.Visible = True
        btnAgregarTema.Enabled = False
        btnEditarTema.Enabled = True
        btnInstanciaEditar.Enabled = False

        Call Instancias_Buscar()
    End Sub

    Private Sub DGV_Instancias_Click(sender As Object, e As EventArgs) Handles DGV_Instancias.Click
        Try
            IdInstancia = CLng(DGV_Instancias.CurrentRow.Cells(0).Value.ToString)
            Call Instancias_Busqueda_ID()
            Call Temas_Busqueda_ID()
            rtxMensaje.LoadFile(RutaMensajes & CStr(IdInstancia) & ".rtf")
            btnInstanciaEditar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevaInstancia.Click
        Call LimpiarControlesInstancia()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Participante_Tipo = "ProductorGuardar"
        FParticipante.ShowDialog()
    End Sub

    Private Sub GuardarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem1.Click
        Participante_Tipo = "AseguradoGuardar"
        FParticipante.ShowDialog()
    End Sub

    Private Sub GuardarDatosEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarDatosEmpleadoToolStripMenuItem.Click
        Participante_Tipo = "EmpleadoGuardar"
        FParticipante.ShowDialog()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If IdProductor = 0 Then
            MsgBox("Primero debe seleccionar el PRODUCTOR que desea Editar", MsgBoxStyle.Critical, "ELEGIR PRODUCTOR")
            txProductor.Select()
            txProductor.SelectAll()
            Exit Sub
        End If
        Call Productor_Buscar_ID()
        Participante_Tipo = "ProductorEditar"
        Dim F As New FParticipante
        F.ShowDialog()
    End Sub

    Private Sub EditarDatosAseguradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarDatosAseguradoToolStripMenuItem.Click
        If IdAsegurado = 0 Then
            MsgBox("Primero debe seleccionar el ASEGURADO que desea Editar", MsgBoxStyle.Critical, "ELEGIR ASEGURADO")
            txAsegurado.Select()
            txAsegurado.SelectAll()
            Exit Sub
        End If
        Participante_Tipo = "AseguradoEditar"
        FParticipante.ShowDialog()
    End Sub

    Private Sub EditarDatosEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarDatosEmpleadoToolStripMenuItem.Click
        If IdEmpleado = 0 Then
            MsgBox("Primero debe seleccionar el EMPLEADO que desea Editar", MsgBoxStyle.Critical, "ELEGIR EMPLEADO")
            txEmpleado.Select()
            txEmpleado.SelectAll()
            Exit Sub
        End If
        Participante_Tipo = "EmpleadoEditar"
        FParticipante.ShowDialog()
    End Sub

    Private Sub btnTemaNuevo_Click(sender As Object, e As EventArgs) Handles btnTemaNuevo.Click
        Call LimpiarControles()
        GBotonesInstancia.Visible = False
        GBotonesTema.Visible = True
        btnAgregarTema.Enabled = True
        btnEditarTema.Enabled = False

        TxPoliza.Select()


    End Sub

    Private Sub BtnTemaAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregarTema.Click
        Controlado = 0
        Call Controlaringreso()
        If Controlado = 0 Then ' HAY DATOS INCONSISTENTES
            Exit Sub
        End If

        If IdTema = 0 Then
            Call Tema_Agregar()
            Call IdTema_BuscarUltimo()
            Call Instancia_Rutina()
        Else
            MsgBox("Primero clic sobre Nuevo Tema", MsgBoxStyle.Critical, "ID TEMA NO ES CERO")
        End If
    End Sub

    Private Sub btnInstanciaAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregarInstancia.Click
        If IdTema = 0 Then
            MsgBox("Primero debe seleccionarse un TEMA en donde se desea agregar esta instancia", MsgBoxStyle.Critical, "FALTA EL TEMA")
            Exit Sub
        End If
        If rtxMensaje.Text = Nothing Then
            MsgBox("El mansaje está vació. Debería agregarse un texto para continuar", MsgBoxStyle.Critical, "DATOS FALTANTES")
            rtxMensaje.Select()
            Exit Sub

        End If

        Call Instancia_Rutina()

    End Sub

    Private Sub btnCarpetaBuscar_Click(sender As Object, e As EventArgs) Handles btnCarpetaBuscar.Click
        Dim RutaArchivoTema As String = RutaArchivos & "Tema-" & CSng(IdTema)
        Dim RutaArchivoInstancia As String = RutaArchivoTema & "\" & "Instancia-" & CStr(IdInstancia)
        Try
            If IdInstancia = 0 Then
                MsgBox("Primeramente debe ELEGIR una instancia", MsgBoxStyle.Critical, "FALTA SELECCIONAR INSTANCIA")
                Exit Sub
            End If

            If Not Directory.Exists(RutaArchivoInstancia) Then
                Respuesta = (MsgBox("No hay archivos adjuntos para esta instancia" & Chr(10) & "¿Desea agregarlos?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "DIRECTORIO INEXISTENTE"))
                If Respuesta = vbYes Then
                    Directory.CreateDirectory(RutaArchivoInstancia)
                    OpenFileDialog1.InitialDirectory = RutaArchivoInstancia & "\"
                    OpenFileDialog1.ShowDialog()
                End If
            Else
                OpenFileDialog1.InitialDirectory = RutaArchivoInstancia & "\"
                OpenFileDialog1.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnInstanciaEditar_Click(sender As Object, e As EventArgs) Handles btnInstanciaEditar.Click
        If IdInstancia = 0 Then
            MsgBox("No hay una instancia asociadas para editar", MsgBoxStyle.Critical, "FALTA SELECCIONAR UNA INSTANCIA")
            Exit Sub
        End If

        If rtxMensaje.Text = Nothing Then
            MsgBox("No hay texto en el mensaje", MsgBoxStyle.Critical, "FALTA EL MENSAJE")
            Exit Sub
        End If
        Call Instancia_Editar()

        Call Archivos_Mover()
        rtxMensaje.SaveFile(RutaMensajes & CStr(IdInstancia) & ".rtf")
        Call Instancias_Buscar()

        MsgBox("La instancia fue Editada", MsgBoxStyle.Critical, "OPERACION EXITOSA")

        ' vuelve todos los datos a cero. Hay que elegir nuevo tema
        Call LimpiarControles()

        GBotonesInstancia.Visible = False
        IdInstancia = 0
        TxAsunto.Text = Nothing
        rtxMensaje.Text = Nothing
    End Sub

    Private Sub btnEditarTema_Click(sender As Object, e As EventArgs) Handles btnEditarTema.Click
        Controlado = 0
        Call Controlaringreso()
        If Controlado = 0 Then ' HAY DATOS INCONSISTENTES
            Exit Sub
        End If
        Call Tema_Editar()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        NuevoEstado = InputBox("Se va a agregar un nuevo Estado para los temas", "INGRESAR NUEVA OPCION PARA ESTADO", CboEstado.Text)
        Call Estado_Duplicado()
        If Controlado = 1 Then
            MsgBox("El estado = " & Estado & " ya existe", MsgBoxStyle.Critical, "REGISTRO EXISTENTE")
            Exit Sub
        End If
        Estado = NuevoEstado
        NuevoEstado = Nothing
        Call Estado_Agregar()
        Call Estado_Listar()
        CboEstado.Text = Estado


    End Sub

    Private Sub EditarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem1.Click
        Call Estado_BuscarID()

        If IdEstado = 0 Then
            MsgBox("Debe seleccionarse el ESTADO a modificar", MsgBoxStyle.Critical, "FALTA ELIGIR ENDOSO")
            Exit Sub
        End If
        NuevoEstado = InputBox("Se reemplazará el estado = " & CboEstado.Text & " por el que se ingrese", "EDITAR ESTADO", CboEstado.Text)
        Call Estado_Duplicado()
        If Controlado = 1 Then
            MsgBox("El estado = " & Estado & " ya existe", MsgBoxStyle.Critical, "REGISTRO EXISTENTE")
            Exit Sub
        End If

        Call Estado_Editar()
        Call Estado_Listar()
        CboEstado.Text = NuevoEstado
        NuevoEstado = Nothing

    End Sub
End Class
