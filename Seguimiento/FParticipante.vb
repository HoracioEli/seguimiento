Public Class FParticipante
    Private Sub FParticipante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Participante_Tipo
            Case "ProductorGuardar"
                Me.Text = "ALTA de Productores"
                txNombre.Text = Form1.txProductor.Text
                btnEditar.Visible = False
                btnGuardar.Visible = True
            Case "AseguradoGuardar"
                Me.Text = "ALTA de Asegurado"
                txNombre.Text = Form1.txAsegurado.Text
                btnEditar.Visible = False
                btnGuardar.Visible = True
            Case "EmpleadoGuardar"
                Me.Text = "ALTA de Empleado"
                txNombre.Text = Form1.txAsegurado.Text
                btnEditar.Visible = False
                btnGuardar.Visible = True
            Case "ProductorEditar"
                Me.Text = "Edicion de Productores"
                txNombre.Text = Form1.txProductor.Text
                Call Productor_Buscar_ID()
                txDatos.Text = Datos
                btnEditar.Visible = True
                btnGuardar.Visible = False

            Case "AseguradoEditar"
                Me.Text = "Edicion de Asegurado"
                txNombre.Text = Form1.txAsegurado.Text
                Call Asegurado_Buscar_ID()
                txDatos.Text = Datos
                btnEditar.Visible = True
                btnGuardar.Visible = False
            Case "EmpleadoEditar"
                Me.Text = "Edicion de Empleado"
                txNombre.Text = Form1.txEmpleado.Text
                Call Empleado_Buscar_ID()
                txDatos.Text = Datos
                btnEditar.Visible = True
                btnGuardar.Visible = False

        End Select
    End Sub

    Private Sub txDatos_Enter(sender As Object, e As EventArgs) Handles txDatos.Enter
        txDatos.SelectAll()
    End Sub

    Private Sub txNombre_Enter(sender As Object, e As EventArgs) Handles txNombre.Enter
        txNombre.SelectAll()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Select Case Participante_Tipo
            Case "ProductorEditar"
                Productor = txNombre.Text
                Datos = txDatos.Text
                'verificar si el nombre no existe
                Call Productor_Duplicado()
                If Existente = 1 Then
                    Exit Sub
                Else
                    Call Productor_Actualizar()
                    Form1.txProductor.Text = UCase(Productor)
                    Call Productor_Buscar()
                    Datos = Nothing
                    Me.Close()
                    Form1.txProductor.Select()
                End If

            Case "AseguradoEditar"
                Asegurado = txNombre.Text
                Datos = txDatos.Text
                'verificar si el nombre no existe
                Call Asegurado_Duplicado()
                If Existente = 1 Then
                    Exit Sub
                Else
                    Call Asegurado_Actualizar()
                    Form1.txAsegurado.Text = UCase(Asegurado)
                    Call Asegurado_Buscar()
                    Datos = Nothing
                    Me.Close()
                    Form1.txAsegurado.Select()
                End If

            Case "EmpleadoEditar"
                Empleado = txNombre.Text
                Datos = txDatos.Text
                'verificar si el nombre no existe
                Call Empleado_Duplicado()
                If Existente = 1 Then
                    Exit Sub
                Else
                    Call Empleado_Actualizar()
                    Form1.txEmpleado.Text = UCase(Empleado)
                    Call Empleado_Buscar()
                    Datos = Nothing
                    Me.Close()
                    Form1.txEmpleado.Select()
                End If


        End Select
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Select Case Participante_Tipo
            Case "ProductorGuardar"
                Productor = txNombre.Text
                Datos = txDatos.Text
                'verificar si el nombre no existe. Lo hace el comando Productor Agregar
                Call Productor_Agregar()
                Form1.txProductor.Text = Productor
                Call Productor_Buscar()
                Datos = Nothing
                Me.Close()
                Form1.txProductor.Select()
            Case "AseguradoGuardar"
                Asegurado = txNombre.Text
                Datos = txDatos.Text
                'verificar si el nombre no existe. Lo hace el comando Productor Agregar
                Call Asegurado_Agregar()
                Form1.txAsegurado.Text = Asegurado
                Call Asegurado_Buscar()
                Datos = Nothing
                Me.Close()
                Form1.txAsegurado.Select()
            Case "EmpleadoGuardar"
                Empleado = txNombre.Text
                Datos = txDatos.Text
                'verificar si el nombre no existe. Lo hace el comando Productor Agregar
                Call Empleado_Agregar()
                Form1.txEmpleado.Text = Empleado
                Call Empleado_Buscar()
                Datos = Nothing
                Me.Close()
                Form1.txEmpleado.Select()

        End Select
    End Sub
End Class