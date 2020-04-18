Module ModuloSQL

    Sub BuscarDesdeList()

        Try
            Select Case BusquedaPor
                Case "Productor"

                    ConsultaSQL = "SELECT Productor, idProductor"
                    ConsultaSQL += " FROM Productor"
                    ConsultaSQL += " where Productor = '" & Form1.List_Resultado.Text & "'"
                Case "Asegurado"
                    ConsultaSQL = "SELECT Asegurado, IdAsegurado"
                    ConsultaSQL += " FROM Asegurado"
                    ConsultaSQL += " where Asegurado = '" & Form1.List_Resultado.Text & "'"
                Case "Empleado"
                    ConsultaSQL = "SELECT Empleado, idEmpleado"
                    ConsultaSQL += " FROM Empleado"
                    ConsultaSQL += " where Empleado = '" & Form1.List_Resultado.Text & "'"
            End Select

            Call Consultar()
            If dr.HasRows Then
                dr.Read()
                Select Case BusquedaPor
                    Case "Productor"
                        Productor = dr(0).ToString
                        IdProductor = CInt(dr(1).ToString)
                        Form1.txProductor.Text = Productor
                        Form1.txAsegurado.Select()
                    Case "Asegurado"
                        Asegurado = dr(0).ToString
                        IdAsegurado = CInt(dr(1).ToString)
                        Form1.txAsegurado.Text = Asegurado
                        Form1.txEmpleado.Select()
                    Case "Empleado"
                        Empleado = dr(0).ToString
                        IdEmpleado = CInt(dr(1).ToString)
                        Form1.txEmpleado.Text = Empleado
                        Form1.txGrupo.Select()

                End Select

            End If

            BusquedaPor = Nothing
            Form1.List_Resultado.Visible = False

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    ' INSTRUCCIONES PARA PRODUCTOR

    Sub Productor_Buscar()
        Try
            Controlado = 0
            BusquedaPor = "Productor"
            Contador = 0
            IdProductor = 0
            Productor = Nothing

            ConsultaSQL = "SELECT Productor, IdProductor,Datos"
            ConsultaSQL += " FROM Productor"
            ConsultaSQL += " where Productor like '%" & Form1.txProductor.Text & "%'"
            ConsultaSQL += " order by Productor"
            Form1.List_Resultado.Items.Clear()


            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Contador += 1
                    Productor = dr(0).ToString
                    IdProductor = CInt(dr(1).ToString)
                    Datos = dr(2).ToString
                    Form1.txProductor.Text = Productor
                    Form1.List_Resultado.Items.Add(Productor)
                End While
            End If

            If Contador > 1 Then
                Form1.List_Resultado.Visible = True
                Form1.List_Resultado.Select()
                Form1.txProductor.Text = Nothing
            ElseIf Contador = 0 Then
                dr.Close()
                Productor = Nothing
                IdProductor = 0
                Mensaje = "No se encontraron registros coincidentes con " & Chr(10) & Form1.txProductor.Text
                Mensaje += Chr(10) & "¿Agregarlo?"
                Respuesta = MsgBox(Mensaje, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "REGISTRO NO ENCONTRADO")
                If Respuesta = vbYes Then
                    Productor = InputBox("Se va a ingresar el nombre del productor", "Agregar Productor", Form1.txProductor.Text)
                    If Productor = Nothing Then
                        MsgBox("El dato no es válido", MsgBoxStyle.Critical, "OPERACION ABORTADA")
                    Else
                        Call Productor_Agregar()
                        Form1.txProductor.Text = Productor
                        Call Productor_Buscar()
                        Exit Sub
                    End If
                End If

            ElseIf Contador = 1 Then
                Controlado = 1
                Form1.List_Resultado.Visible = False
                Form1.txAsegurado.Select()
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Productor_Buscar_ID()
        Try

            ConsultaSQL = "SELECT Datos"
            ConsultaSQL += " FROM Productor"
            ConsultaSQL += " where idProductor = " & IdProductor

            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Datos = dr(0).ToString
                End While
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Productor_Agregar()
        Call Productor_Duplicado()

        If Existente = 1 Then
            Exit Sub
        End If

        SQL = "INSERT INTO Productor( Productor,Datos)"
        SQL = SQL & " Values ("
        SQL = SQL & "'" & UCase(Productor) & "',"
        SQL = SQL & "'" & Datos & "'"
        SQL = SQL & ")"

        Call IngresarEnAcces()

    End Sub
    Sub Productor_Actualizar()

        Call Productor_Duplicado()

        If Existente = 1 Then
            Exit Sub
        End If
        SQL = "UPDATE Productor SET "
        SQL += "Productor='" & UCase(Productor) & "',"
        SQL += "Datos='" & Datos & "'"
        SQL += " WHERE idProductor=" & IdProductor

        Call IngresarEnAcces()
    End Sub
    Sub Productor_Duplicado()
        Try
            Existente = 0
            ConsultaSQL = "SELECT Productor,IdProductor"
            ConsultaSQL += " FROM Productor"
            ConsultaSQL += " where Productor = '" & Productor & "'"


            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Productor = dr(0).ToString
                    IdEncontrado = CInt(dr(1).ToString)
                    If IdEncontrado <> IdProductor Then ' Esto permite agregar datos sin cambiar el nombre del productor por ya existente.
                        Existente = 1
                        MsgBox("El productor que se quiere dar de alta o modificar (" & Productor & "), ya existe", MsgBoxStyle.Exclamation, "REGISTRO EXISTENTE, OPERACION ABORTADA")
                    End If
                End While
            End If

            dr.Close()



        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    ' INSTRUCCIONES PARA asegurado

    Sub Asegurado_Buscar()
        Try
            Controlado = 0
            BusquedaPor = "Asegurado"
            Contador = 0
            IdAsegurado = 0
            Asegurado = Nothing

            ConsultaSQL = "SELECT Asegurado, idAsegurado, Datos"
            ConsultaSQL += " FROM Asegurado"
            ConsultaSQL += " where Asegurado like '%" & Form1.txAsegurado.Text & "%'"
            ConsultaSQL += " order by Asegurado"
            Form1.List_Resultado.Items.Clear()


            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Contador += 1
                    Asegurado = dr(0).ToString
                    Datos = dr(2).ToString
                    IdAsegurado = CInt(dr(1).ToString)
                    Form1.txAsegurado.Text = Asegurado
                    Form1.List_Resultado.Items.Add(Asegurado)
                End While
            End If

            If Contador > 1 Then
                Form1.List_Resultado.Visible = True
                Form1.List_Resultado.Select()
                Form1.txAsegurado.Text = Nothing
            ElseIf Contador = 0 Then
                dr.Close()
                Asegurado = Nothing
                IdAsegurado = 0
                Datos = Nothing
                Mensaje = "No se encontraron registros coincidentes con " & Chr(10) & Form1.txAsegurado.Text
                Mensaje += Chr(10) & "¿Agregarlo?"
                Respuesta = MsgBox(Mensaje, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "REGISTRO NO ENCONTRADO")
                If Respuesta = vbYes Then
                    Asegurado = InputBox("Se va a ingresar el nombre del ASEGURADO", "Agregar ASEGURADO", Form1.txAsegurado.Text)
                    If Asegurado = Nothing Then
                        MsgBox("El dato no es válido", MsgBoxStyle.Critical, "OPERACION ABORTADA")
                    Else
                        Call Asegurado_Agregar()
                        Form1.txAsegurado.Text = Asegurado
                        Call Asegurado_Buscar()
                        Exit Sub
                    End If
                End If

            ElseIf Contador = 1 Then
                Controlado = 1
                Form1.List_Resultado.Visible = False
                Form1.txEmpleado.Select()
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Asegurado_Buscar_ID()
        Try

            ConsultaSQL = "SELECT Datos"
            ConsultaSQL += " FROM Asegurado"
            ConsultaSQL += " where IdAsegurado = " & IdAsegurado

            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Datos = dr(0).ToString
                End While
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Asegurado_Agregar()
        Call Asegurado_Duplicado()

        If Existente = 1 Then
            Exit Sub
        End If

        SQL = "INSERT INTO Asegurado( Asegurado,Datos)"
        SQL = SQL & " Values ("
        SQL = SQL & "'" & UCase(Asegurado) & "',"
        SQL = SQL & "'" & Datos & "'"
        SQL = SQL & ")"

        Call IngresarEnAcces()

    End Sub
    Sub Asegurado_Actualizar()

        Call Asegurado_Duplicado()

        If Existente = 1 Then
            Exit Sub
        End If
        SQL = "UPDATE Asegurado SET "
        SQL += "Asegurado='" & Asegurado & "',"
        SQL += "Datos='" & Datos & "'"
        SQL += " WHERE idAsegurado=" & IdAsegurado

        Call IngresarEnAcces()
    End Sub
    Sub Asegurado_Duplicado()
        Try
            Existente = 0
            ConsultaSQL = "SELECT Asegurado, IdAsegurado"
            ConsultaSQL += " FROM Asegurado"
            ConsultaSQL += " where Asegurado = '" & Asegurado & "'"


            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Asegurado = dr(0).ToString
                    IdEncontrado = CInt(dr(1).ToString)
                    If IdAsegurado <> IdEncontrado Then 'Esto permite modificar el dato del Asegurado
                        Existente = 1
                        MsgBox("El ASEGURADO que se quiere dar de alta o modificar (" & Asegurado & "), ya existe", MsgBoxStyle.Exclamation, "REGISTRO EXISTENTE, OPERACION ABORTADA")
                    End If
                End While
            End If

            dr.Close()



        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    ' INSTRUCCIONES PARA EMPLEADO
    Sub Empleado_Buscar()
        Try
            Controlado = 0
            BusquedaPor = "Empleado"
            Contador = 0
            IdEmpleado = 0
            Empleado = Nothing

            ConsultaSQL = "SELECT Empleado, IdEmpleado,Datos"
            ConsultaSQL += " FROM Empleado"
            ConsultaSQL += " where Empleado like '%" & Form1.txEmpleado.Text & "%'"
            ConsultaSQL += " order by empleado"
            Form1.List_Resultado.Items.Clear()


            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Contador += 1
                    Empleado = dr(0).ToString
                    IdEmpleado = CInt(dr(1).ToString)
                    Datos = dr(2).ToString
                    Form1.txEmpleado.Text = Empleado
                    Form1.List_Resultado.Items.Add(Empleado)
                End While
            End If

            If Contador > 1 Then
                Form1.List_Resultado.Visible = True
                Form1.List_Resultado.Select()
                Form1.txEmpleado.Text = Nothing
            ElseIf Contador = 0 Then
                dr.Close()
                Empleado = Nothing
                IdEmpleado = 0
                Datos = Nothing
                Mensaje = "No se encontraron registros coincidentes con " & Chr(10) & Form1.txEmpleado.Text
                Mensaje += Chr(10) & "¿Agregarlo?"
                Respuesta = MsgBox(Mensaje, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "REGISTRO NO ENCONTRADO")
                If Respuesta = vbYes Then
                    Empleado = InputBox("Se va a ingresar el nombre del EMPLEADO", "Agregar EMPLEADO", Form1.txEmpleado.Text)
                    If Empleado = Nothing Then
                        MsgBox("El dato no es válido", MsgBoxStyle.Critical, "OPERACION ABORTADA")
                    Else
                        Call Empleado_Agregar()
                        Form1.txEmpleado.Text = Empleado
                        Call Empleado_Buscar()
                        Exit Sub
                    End If
                End If

            ElseIf Contador = 1 Then
                Controlado = 1
                Form1.List_Resultado.Visible = False
                Form1.txGrupo.Select()
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Empleado_Buscar_ID()
        Try

            ConsultaSQL = "SELECT Datos"
            ConsultaSQL += " FROM Empleado"
            ConsultaSQL += " where idEmpleado = " & IdEmpleado

            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Datos = dr(0).ToString
                End While
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Empleado_Agregar()
        Call Empleado_Duplicado()

        If Existente = 1 Then
            Exit Sub
        End If

        SQL = "INSERT INTO Empleado( Empleado,Datos)"
        SQL = SQL & " Values ("
        SQL = SQL & "'" & UCase(Empleado) & "',"
        SQL = SQL & "'" & Datos & "'"
        SQL = SQL & ")"

        Call IngresarEnAcces()

    End Sub
    Sub Empleado_Actualizar()

        Call Empleado_Duplicado()

        If Existente = 1 Then
            Exit Sub
        End If
        SQL = "UPDATE Empleado SET "
        SQL += "Empleado='" & Empleado & "',"
        SQL += "Datos='" & Datos & "'"
        SQL += " WHERE idEmpleado=" & IdEmpleado

        Call IngresarEnAcces()
    End Sub
    Sub Empleado_Duplicado()
        Try
            Existente = 0
            ConsultaSQL = "SELECT Empleado, IdEmpleado"
            ConsultaSQL += " FROM Empleado"
            ConsultaSQL += " where Empleado = '" & Empleado & "'"


            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Empleado = dr(0).ToString
                    IdEncontrado = CInt(dr(1).ToString)
                    If IdEncontrado <> IdEmpleado Then 'Esto permite editar el campo dato de empleado
                        Existente = 1
                        MsgBox("El EMPLEADO que se quiere dar de alta o modificar (" & Empleado & "), ya existe", MsgBoxStyle.Exclamation, "REGISTRO EXISTENTE, OPERACION ABORTADA")
                    End If
                End While
            End If

            dr.Close()



        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    ' BUSCA NRO POLIZA EXISTENTE
    Sub Poliza_Buscar_Existente()
        Try

            ConsultaSQL = "SELECT Poliza, IdEstado"
            ConsultaSQL += " FROM Temas"
            ConsultaSQL += " where Poliza = '" & Form1.TxPoliza.Text & "'"

            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    PolizaExistente = dr(0).ToString
                    IdEstadoPoliza = CInt(dr(1).ToString)
                    If IdEstadoPoliza <> 1 Then
                        Respuesta = (MsgBox("La poliza tiene TEMAS NO TERMINADOS" & Chr(10) & "¿Quiere consultarla?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "POLIZA CON TEMAS ABIERTOS"))
                        dr.Close()
                        If Respuesta = vbYes Then
                            Dim PolizaTemporal As String = Form1.TxPoliza.Text
                            Call Form1.TemaNuevo_Rutina()
                            Form1.TxPoliza.Text = PolizaTemporal
                            Call Temas_Buscar()
                        End If
                        Exit Sub
                    End If
                End While
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    ' BUSCA COTIZACION EXISTENTE
    Sub Cotizacion_Buscar_Existente()
        Try

            ConsultaSQL = "SELECT Cotizacion, IdEstado"
            ConsultaSQL += " FROM Temas"
            ConsultaSQL += " where Cotizacion = '" & Form1.txCotizacion.Text & "'"

            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    CotizacionExistente = dr(0).ToString
                    IdEstadoCotizacion = dr(1).ToString
                    If IdEstadoCotizacion <> 1 Then
                        Respuesta = (MsgBox("La COTIZACION tiene TEMAS en NO TERMINADOS" & Chr(10) & "¿Quiere consultarla?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "COTIZACION CON TEMAS ABIERTOS"))
                        dr.Close()
                        If Respuesta = vbYes Then
                            Dim CotizacionTemporal As String = Form1.txCotizacion.Text
                            Call Form1.TemaNuevo_Rutina()
                            Form1.txCotizacion.Text = CotizacionTemporal
                            Call Temas_Buscar()
                        End If
                        Exit Sub
                    End If
                End While
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    ' BUSCA SINIESTRO EXISTENTE
    Sub Siniestro_Buscar_Existente()
        Try

            ConsultaSQL = "SELECT Siniestro, IdEstado"
            ConsultaSQL += " FROM Temas"
            ConsultaSQL += " where Siniestro = '" & Form1.txSiniestro.Text & "'"

            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    SiniestroExistente = dr(0).ToString
                    IdEstadoPoliza = CInt(dr(1).ToString)
                    If IdEstadoPoliza <> 1 Then
                        Respuesta = (MsgBox("El SINIESTRO tiene TEMAS NO TERMINADOS" & Chr(10) & "¿Quiere consultarlo?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "SINIESTRO CON TEMAS ABIERTOS"))
                        dr.Close()
                        If Respuesta = vbYes Then
                            Dim SiniestroTemporal As String = Form1.txSiniestro.Text
                            Call Form1.TemaNuevo_Rutina()
                            Form1.txSiniestro.Text = SiniestroTemporal
                            Call Temas_Buscar()
                        End If
                        Exit Sub
                    End If
                End While
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Estado_Listar()

        Try
            Form1.CboEstado.Items.Clear()

            ConsultaSQL = "SELECT Estado"
            ConsultaSQL += " FROM Estado"


            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Form1.CboEstado.Items.Add(dr(0).ToString)
                End While
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub Estado_BuscarID()

        Try

            IdEstado = 0
            ConsultaSQL = "SELECT idEstado"
            ConsultaSQL += " FROM Estado"
            ConsultaSQL += " where Estado='" & Form1.CboEstado.Text & "'"

            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    IdEstado = CInt((dr(0).ToString))
                End While
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try


    End Sub

    Sub Estado_Agregar()

        SQL = "INSERT INTO Estado(Estado)"
        SQL = SQL & " Values ("
        SQL = SQL & "'" & Estado & "'"
        SQL = SQL & ")"

        Call IngresarEnAcces()




    End Sub
    Sub Estado_Buscar()
        Try
            Controlado = 0

            ConsultaSQL = "SELECT IdEstado,Estado"
            ConsultaSQL += " FROM Estado"
            ConsultaSQL += " where Estado = '" & Form1.CboEstado.Text & "'"

            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    IdEstado = CInt(dr(0).ToString)
                    Estado = dr(1).ToString
                    Controlado = 1
                End While
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Estado_Duplicado()
        Try
            Controlado = 0

            ConsultaSQL = "SELECT Estado"
            ConsultaSQL += " FROM Estado"
            ConsultaSQL += " where Estado = '" & NuevoEstado & "'"

            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    Estado = dr(0).ToString
                    Controlado = 1
                End While
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Estado_Editar()
        SQL = "UPDATE Estado SET "
        SQL += "Estado='" & NuevoEstado & "'"
        SQL += " WHERE idEstado=" & IdEstado

        Call IngresarEnAcces()
    End Sub


    'TEMA
    Sub Tema_Agregar()
        TareasPendientes = Form1.rtxTareasPendientes.Text
        TareasPendientes = Replace(TareasPendientes, "'", " ")

        Grupo = Form1.txGrupo.Text
        Grupo = Replace(Grupo, "'", " ")


        SQL = "INSERT INTO Temas(Titulo,Poliza,Cotizacion,TareasPendientes,IdEstado,IdProductor,IdAsegurado,IdEmpleado,Grupo,Siniestro)"
        SQL = SQL & " Values ("
        SQL = SQL & "'" & Titulo & "',"
        SQL = SQL & "'" & Poliza & "',"
        SQL = SQL & "'" & Cotizacion & "',"
        SQL = SQL & "'" & TareasPendientes & "',"
        SQL = SQL & IdEstado & ","
        SQL = SQL & IdProductor & ","
        SQL = SQL & IdAsegurado & ","
        SQL = SQL & IdEmpleado & ","
        SQL = SQL & "'" & Grupo & "',"
        SQL = SQL & "'" & Siniestro & "'"
        SQL = SQL & ")"

        Call IngresarEnAcces()




    End Sub
    Sub IdTema_BuscarUltimo()

        Try

            ConsultaSQL = "SELECT Max(IdTemas) AS Maximo"
            ConsultaSQL += " FROM Temas"


            Call Consultar()
            If dr.HasRows Then
                dr.Read()
                IdTema = dr(0).ToString
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Temas_Buscar()
        Try
            IdTema = 0
            IdInstancia = 0

            Form1.DGV_Instancias.Rows.Clear()


            ConsultaSQL = "SELECT"
            ConsultaSQL += " Temas.IdTemas, Temas.Titulo, Temas.Poliza, Temas.Cotizacion, Estado.Estado, Temas.Siniestro"
            ConsultaSQL += " FROM"
            ConsultaSQL += " (Empleado "
            ConsultaSQL += " RIGHT JOIN (Productor "
            ConsultaSQL += " RIGHT JOIN (Estado "
            ConsultaSQL += " RIGHT JOIN (Temas"
            ConsultaSQL += " LEFT JOIN Instancias "
            ConsultaSQL += " ON Temas.IdTemas = Instancias.IdTemas) "
            ConsultaSQL += " ON Estado.IdEstado = Temas.IdEstado) "
            ConsultaSQL += " ON Productor.idProductor = Temas.IdProductor)"
            ConsultaSQL += " ON Empleado.IdEmpleado = Temas.IdEmpleado)"
            ConsultaSQL += " LEFT JOIN Asegurado "
            ConsultaSQL += " ON Temas.IdAsegurado = Asegurado.IdAsegurado"
            ConsultaSQL += " WHERE Temas.IdTemas >0 "


            If Titulo <> Nothing Then
                ConsultaSQL += " And Temas.Titulo Like '%" & Titulo & "%'"
            End If

            If Form1.TxPoliza.Text <> Nothing Then
                ConsultaSQL += " and Temas.Poliza = '" & Form1.TxPoliza.Text & "'"
            End If

            If Form1.txCotizacion.Text <> Nothing Then
                ConsultaSQL += " and Temas.Cotizacion = '" & Form1.txCotizacion.Text & "'"
            End If

            If Form1.txSiniestro.Text <> Nothing Then
                ConsultaSQL += " and Temas.Siniestro = '" & Form1.txSiniestro.Text & "'"
            End If

            If Form1.rtxTareasPendientes.Text <> Nothing Then
                ConsultaSQL += " and Temas.TareasPendientes LIKE '%" & Form1.rtxTareasPendientes.Text & "%'"
            End If

            If Form1.CboEstado.Text <> Nothing Then
                ConsultaSQL += " and Estado.Estado = '" & Form1.CboEstado.Text & "'"
            End If

            If Form1.txProductor.Text <> Nothing Then
                ConsultaSQL += " and Productor.Productor like '%" & Form1.txProductor.Text & "%'"
            End If

            If Form1.txAsegurado.Text <> Nothing Then
                ConsultaSQL += " and Asegurado.Asegurado like '%" & Form1.txAsegurado.Text & "%'"
            End If

            If Form1.txEmpleado.Text <> Nothing Then
                ConsultaSQL += " and Empleado.Empleado like '%" & Form1.txEmpleado.Text & "%'"
            End If

            If Form1.txGrupo.Text <> Nothing Then
                ConsultaSQL += " and Temas.Grupo like '%" & Form1.txGrupo.Text & "%'"
            End If

            If Form1.TxAsunto.Text <> Nothing Then
                ConsultaSQL += " and Instancias.AsuntoEmail like '%" & Form1.TxAsunto.Text & "%'"
            End If

            If Form1.rtxMensaje.Text <> Nothing Then
                ConsultaSQL += " and Instancias.Mensaje like '%" & Form1.rtxMensaje.Text & "%'"
            End If

            ConsultaSQL += " ORDER BY Temas.IdTemas desc"

            Form1.dgv_Resultado.Rows.Clear()
            Call Consultar()


            If dr.HasRows Then
                While dr.Read()
                    Dim IdTemaAnterior As String = IdTema

                    IdTema = dr(0).ToString()
                    Titulo = dr(1).ToString()
                    Estado = dr(4).ToString()
                    Poliza = dr(2).ToString()
                    Cotizacion = dr(3).ToString()
                    Siniestro = dr(5).ToString
                    If IdTema <> IdTemaAnterior Then
                        Form1.dgv_Resultado.Rows.Add(IdTema, Titulo, Estado, Poliza, Cotizacion, Siniestro)

                    End If
                    IdTemaAnterior = IdTema
                End While
            Else
                MsgBox("No existen registros para la combinación buscada", MsgBoxStyle.Critical, "SIN REGISTROS")
            End If

            IdTema = 0
            Titulo = Nothing
            Estado = Nothing
            Poliza = Nothing
            Cotizacion = Nothing
            Siniestro = Nothing

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Temas_Busqueda_ID()
        Try
            If IdTema = 0 Then
                Exit Sub
            End If

            ConsultaSQL = "SELECT "
            ConsultaSQL += " Titulo,Poliza, Cotizacion, TareasPendientes, Grupo, Empleado, Estado, Productor, Asegurado,Siniestro "
            ConsultaSQL += " FROM "
            ConsultaSQL += " (Empleado RIGHT JOIN (Productor RIGHT JOIN (Estado LEFT JOIN Temas   "
            ConsultaSQL += " ON Estado.IdEstado = Temas.IdEstado) "
            ConsultaSQL += " ON Productor.idProductor = Temas.IdProductor)   "
            ConsultaSQL += " ON Empleado.IdEmpleado = Temas.IdEmpleado) LEFT JOIN Asegurado "
            ConsultaSQL += " ON Temas.IdAsegurado = Asegurado.IdAsegurado  "
            ConsultaSQL += " WHERE (((Temas.IdTemas)=" & IdTema & " ))"

            Call Consultar()
            If dr.HasRows Then
                dr.Read()
                Titulo = dr(0).ToString
                Poliza = dr(1).ToString
                Cotizacion = dr(2).ToString
                Form1.rtxTareasPendientes.Text = dr(3).ToString
                Grupo = dr(4).ToString
                Empleado = dr(5).ToString
                Estado = dr(6).ToString
                Productor = dr(7).ToString
                Asegurado = dr(8).ToString
                Siniestro = dr(9).ToString


                Form1.TxPoliza.Text = Poliza
                Form1.txCotizacion.Text = Cotizacion
                Form1.txGrupo.Text = Grupo
                Form1.txEmpleado.Text = Empleado
                Form1.CboEstado.Text = Estado
                Form1.txProductor.Text = Productor
                Form1.txAsegurado.Text = Asegurado
                Form1.txSiniestro.Text = Siniestro


            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Tema_Editar()
        Asunto = Form1.TxAsunto.Text
        Asunto = Replace(Asunto, "'", " ")
        TextoMensaje = Form1.rtxMensaje.Text
        TextoMensaje = Replace(TextoMensaje, "'", " ")
        TareasPendientes = Form1.rtxTareasPendientes.Text


        SQL = "UPDATE Temas SET "
        SQL += "Titulo='" & Titulo & "',"
        SQL += "Poliza='" & Poliza & "',"
        SQL += "Cotizacion='" & Cotizacion & "',"
        SQL += "TareasPendientes='" & TareasPendientes & "',"
        SQL += "IdEstado=" & IdEstado & ","
        SQL += "IdProductor=" & IdProductor & ","
        SQL += "IdAsegurado=" & IdAsegurado & ","
        SQL += "IdEmpleado=" & IdEmpleado & ","
        SQL += "Grupo='" & Grupo & "',"
        SQL += "Siniestro='" & Siniestro & "'"
        SQL += " WHERE IdTemas=" & IdTema

        Call IngresarEnAcces()
    End Sub



    'INSTANCIAS
    Sub Instancia_Agregar()
        Asunto = Form1.TxAsunto.Text
        Asunto = Replace(Asunto, "'", " ")
        TextoMensaje = Form1.rtxMensaje.Text
        TextoMensaje = Replace(TextoMensaje, "'", " ")

        SQL = "INSERT INTO Instancias(IdTemas,AsuntoEmail,Mensaje,FechaInstancia)"
        SQL = SQL & " Values ("
        SQL = SQL & IdTema & ","
        SQL = SQL & "'" & Asunto & "',"
        SQL = SQL & "'" & TextoMensaje & "',"
        SQL = SQL & "'" & Now & "'"
        SQL = SQL & ")"

        Call IngresarEnAcces()


    End Sub
    Sub IdInstancias_BuscarUltimo()

        Try

            ConsultaSQL = "SELECT Max(IdInstancias) AS Maximo"
            ConsultaSQL += " FROM Instancias"
            ConsultaSQL += " where IdTemas=" & IdTema


            Call Consultar()
            If dr.HasRows Then
                dr.Read()
                IdInstancia = dr(0).ToString
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Instancias_Buscar()
        Try


            ConsultaSQL = "SELECT IdInstancias, FechaInstancia"
            ConsultaSQL += " FROM Instancias "
            ConsultaSQL += " WHERE IdTemas= " & IdTema
            ConsultaSQL += " ORDER BY FechaInstancia DESC"


            Form1.DGV_Instancias.Rows.Clear()

            Call Consultar()
            If dr.HasRows Then
                While dr.Read()
                    IdInstancia = dr(0).ToString
                    FechaInstancia = dr(1).ToString
                    Form1.DGV_Instancias.Rows.Add(IdInstancia, FechaInstancia)
                End While
            End If

            IdInstancia = 0
            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Instancia_Rutina()
        Call Instancia_Agregar()
        Call IdInstancias_BuscarUltimo()
        Call Archivos_Mover()
        Form1.rtxMensaje.SaveFile(RutaMensajes & CStr(IdInstancia) & ".rtf")
        Call Instancias_Buscar()

        Respuesta = MsgBox("La instancia fue ingresada." & Chr(10) & "¿Agregar nueva instancia?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "OPERACION EXITOSA")
        If Respuesta = vbNo Then
            Call Form1.LimpiarControles()
            Form1.GBotonesInstancia.Visible = False
            Form1.btnAgregarTema.Enabled = True
            Form1.btnEditarTema.Enabled = False
            Call Temas_Buscar()


        Else
            IdInstancia = 0
            Form1.GBotonesInstancia.Visible = True
            Form1.TxAsunto.Text = Nothing
            Form1.rtxMensaje.Text = Nothing
        End If
    End Sub
    Sub Instancias_Busqueda_ID()
        Try


            ConsultaSQL = "SELECT IdTemas, AsuntoEmail"
            ConsultaSQL += " FROM Instancias "
            ConsultaSQL += " WHERE IdInstancias= " & IdInstancia


            Call Consultar()
            If dr.HasRows Then
                dr.Read()
                IdTema = dr(0).ToString
                Form1.TxAsunto.Text = dr(1).ToString
            End If

            dr.Close()
        Catch ex As Exception
            dr.Close()
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Instancia_Editar()
        Asunto = Form1.TxAsunto.Text
        Asunto = Replace(Asunto, "'", " ")
        TextoMensaje = Form1.rtxMensaje.Text
        TextoMensaje = Replace(TextoMensaje, "'", " ")


        SQL = "UPDATE Instancias SET "
        SQL += "AsuntoEmail='" & Asunto & "',"
        SQL += "Mensaje='" & TextoMensaje & "'"
        SQL += " WHERE IdInstancias=" & IdInstancia & " AND IDTemas=" & IdTema

        Call IngresarEnAcces()
    End Sub






End Module
