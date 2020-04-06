<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GpoParticipantes = New System.Windows.Forms.GroupBox()
        Me.txGrupo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txEmpleado = New System.Windows.Forms.TextBox()
        Me.MenuDatosParticipantes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProductorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AseguradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarDatosAseguradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarDatosEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarDatosEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txAsegurado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txProductor = New System.Windows.Forms.TextBox()
        Me.GComprobante = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txCotizacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxPoliza = New System.Windows.Forms.TextBox()
        Me.GEstado = New System.Windows.Forms.GroupBox()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.GEmail = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxAsunto = New System.Windows.Forms.TextBox()
        Me.GMensaje = New System.Windows.Forms.GroupBox()
        Me.List_Resultado = New System.Windows.Forms.ListBox()
        Me.rtxMensaje = New System.Windows.Forms.RichTextBox()
        Me.GTareasPendientes = New System.Windows.Forms.GroupBox()
        Me.rtxTareasPendientes = New System.Windows.Forms.RichTextBox()
        Me.GInstancias = New System.Windows.Forms.GroupBox()
        Me.DGV_Instancias = New System.Windows.Forms.DataGridView()
        Me.C_IdInstancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GTemas = New System.Windows.Forms.GroupBox()
        Me.dgv_Resultado = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Poliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Cotizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GBotonesTema = New System.Windows.Forms.GroupBox()
        Me.btnEditarTema = New System.Windows.Forms.Button()
        Me.btnAgregarTema = New System.Windows.Forms.Button()
        Me.btnBuscarTema = New System.Windows.Forms.Button()
        Me.GBotonesInstancia = New System.Windows.Forms.GroupBox()
        Me.btnTemaNuevo = New System.Windows.Forms.Button()
        Me.btnAgregarInstancia = New System.Windows.Forms.Button()
        Me.btnInstanciaEditar = New System.Windows.Forms.Button()
        Me.btnNuevaInstancia = New System.Windows.Forms.Button()
        Me.btnCarpetaBuscar = New System.Windows.Forms.Button()
        Me.MenuEstado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GpoParticipantes.SuspendLayout()
        Me.MenuDatosParticipantes.SuspendLayout()
        Me.GComprobante.SuspendLayout()
        Me.GEstado.SuspendLayout()
        Me.GEmail.SuspendLayout()
        Me.GMensaje.SuspendLayout()
        Me.GTareasPendientes.SuspendLayout()
        Me.GInstancias.SuspendLayout()
        CType(Me.DGV_Instancias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GTemas.SuspendLayout()
        CType(Me.dgv_Resultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBotonesTema.SuspendLayout()
        Me.GBotonesInstancia.SuspendLayout()
        Me.MenuEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpoParticipantes
        '
        Me.GpoParticipantes.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GpoParticipantes.Controls.Add(Me.txGrupo)
        Me.GpoParticipantes.Controls.Add(Me.Label4)
        Me.GpoParticipantes.Controls.Add(Me.Label3)
        Me.GpoParticipantes.Controls.Add(Me.txEmpleado)
        Me.GpoParticipantes.Controls.Add(Me.Label2)
        Me.GpoParticipantes.Controls.Add(Me.txAsegurado)
        Me.GpoParticipantes.Controls.Add(Me.Label1)
        Me.GpoParticipantes.Controls.Add(Me.txProductor)
        Me.GpoParticipantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GpoParticipantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GpoParticipantes.Location = New System.Drawing.Point(12, 133)
        Me.GpoParticipantes.Name = "GpoParticipantes"
        Me.GpoParticipantes.Size = New System.Drawing.Size(262, 203)
        Me.GpoParticipantes.TabIndex = 1
        Me.GpoParticipantes.TabStop = False
        '
        'txGrupo
        '
        Me.txGrupo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txGrupo.Location = New System.Drawing.Point(10, 139)
        Me.txGrupo.Multiline = True
        Me.txGrupo.Name = "txGrupo"
        Me.txGrupo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txGrupo.Size = New System.Drawing.Size(246, 58)
        Me.txGrupo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Grupo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Empleado"
        '
        'txEmpleado
        '
        Me.txEmpleado.ContextMenuStrip = Me.MenuDatosParticipantes
        Me.txEmpleado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txEmpleado.Location = New System.Drawing.Point(10, 97)
        Me.txEmpleado.Name = "txEmpleado"
        Me.txEmpleado.Size = New System.Drawing.Size(246, 20)
        Me.txEmpleado.TabIndex = 2
        '
        'MenuDatosParticipantes
        '
        Me.MenuDatosParticipantes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductorToolStripMenuItem, Me.AseguradoToolStripMenuItem, Me.EmpleadoToolStripMenuItem})
        Me.MenuDatosParticipantes.Name = "MenuDatosParticipantes"
        Me.MenuDatosParticipantes.Size = New System.Drawing.Size(132, 70)
        '
        'ProductorToolStripMenuItem
        '
        Me.ProductorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.ProductorToolStripMenuItem.Name = "ProductorToolStripMenuItem"
        Me.ProductorToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ProductorToolStripMenuItem.Text = "Productor"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar Datos Productor"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EditarToolStripMenuItem.Text = "Editar Datos Productor"
        '
        'AseguradoToolStripMenuItem
        '
        Me.AseguradoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem1, Me.EditarDatosAseguradoToolStripMenuItem})
        Me.AseguradoToolStripMenuItem.Name = "AseguradoToolStripMenuItem"
        Me.AseguradoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AseguradoToolStripMenuItem.Text = "Asegurado"
        '
        'GuardarToolStripMenuItem1
        '
        Me.GuardarToolStripMenuItem1.Name = "GuardarToolStripMenuItem1"
        Me.GuardarToolStripMenuItem1.Size = New System.Drawing.Size(209, 22)
        Me.GuardarToolStripMenuItem1.Text = "Guardar Datos Asegurado"
        '
        'EditarDatosAseguradoToolStripMenuItem
        '
        Me.EditarDatosAseguradoToolStripMenuItem.Name = "EditarDatosAseguradoToolStripMenuItem"
        Me.EditarDatosAseguradoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.EditarDatosAseguradoToolStripMenuItem.Text = "Editar Datos Asegurado"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarDatosEmpleadoToolStripMenuItem, Me.EditarDatosEmpleadoToolStripMenuItem})
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'GuardarDatosEmpleadoToolStripMenuItem
        '
        Me.GuardarDatosEmpleadoToolStripMenuItem.Name = "GuardarDatosEmpleadoToolStripMenuItem"
        Me.GuardarDatosEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.GuardarDatosEmpleadoToolStripMenuItem.Text = "Guardar Datos Empleado"
        '
        'EditarDatosEmpleadoToolStripMenuItem
        '
        Me.EditarDatosEmpleadoToolStripMenuItem.Name = "EditarDatosEmpleadoToolStripMenuItem"
        Me.EditarDatosEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EditarDatosEmpleadoToolStripMenuItem.Text = "Editar Datos Empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Asegurado"
        '
        'txAsegurado
        '
        Me.txAsegurado.ContextMenuStrip = Me.MenuDatosParticipantes
        Me.txAsegurado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txAsegurado.Location = New System.Drawing.Point(10, 62)
        Me.txAsegurado.Name = "txAsegurado"
        Me.txAsegurado.Size = New System.Drawing.Size(246, 20)
        Me.txAsegurado.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Productor"
        '
        'txProductor
        '
        Me.txProductor.ContextMenuStrip = Me.MenuDatosParticipantes
        Me.txProductor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txProductor.Location = New System.Drawing.Point(9, 25)
        Me.txProductor.Name = "txProductor"
        Me.txProductor.Size = New System.Drawing.Size(247, 20)
        Me.txProductor.TabIndex = 0
        '
        'GComprobante
        '
        Me.GComprobante.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GComprobante.Controls.Add(Me.Label5)
        Me.GComprobante.Controls.Add(Me.txCotizacion)
        Me.GComprobante.Controls.Add(Me.Label6)
        Me.GComprobante.Controls.Add(Me.TxPoliza)
        Me.GComprobante.Location = New System.Drawing.Point(12, 6)
        Me.GComprobante.Name = "GComprobante"
        Me.GComprobante.Size = New System.Drawing.Size(262, 121)
        Me.GComprobante.TabIndex = 0
        Me.GComprobante.TabStop = False
        Me.GComprobante.Text = "Comprobante"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cotizacion"
        '
        'txCotizacion
        '
        Me.txCotizacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.txCotizacion.Location = New System.Drawing.Point(80, 71)
        Me.txCotizacion.Name = "txCotizacion"
        Me.txCotizacion.Size = New System.Drawing.Size(138, 20)
        Me.txCotizacion.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Poliza"
        '
        'TxPoliza
        '
        Me.TxPoliza.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.TxPoliza.Location = New System.Drawing.Point(80, 33)
        Me.TxPoliza.Name = "TxPoliza"
        Me.TxPoliza.Size = New System.Drawing.Size(138, 20)
        Me.TxPoliza.TabIndex = 0
        '
        'GEstado
        '
        Me.GEstado.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GEstado.Controls.Add(Me.CboEstado)
        Me.GEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GEstado.Location = New System.Drawing.Point(996, 6)
        Me.GEstado.Name = "GEstado"
        Me.GEstado.Size = New System.Drawing.Size(176, 69)
        Me.GEstado.TabIndex = 5
        Me.GEstado.TabStop = False
        Me.GEstado.Text = "Estado"
        '
        'CboEstado
        '
        Me.CboEstado.ContextMenuStrip = Me.MenuEstado
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(6, 30)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(164, 21)
        Me.CboEstado.Sorted = True
        Me.CboEstado.TabIndex = 0
        '
        'GEmail
        '
        Me.GEmail.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GEmail.Controls.Add(Me.Label7)
        Me.GEmail.Controls.Add(Me.TxAsunto)
        Me.GEmail.Location = New System.Drawing.Point(280, 6)
        Me.GEmail.Name = "GEmail"
        Me.GEmail.Size = New System.Drawing.Size(710, 69)
        Me.GEmail.TabIndex = 3
        Me.GEmail.TabStop = False
        Me.GEmail.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Asunto"
        '
        'TxAsunto
        '
        Me.TxAsunto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.TxAsunto.ForeColor = System.Drawing.Color.SeaGreen
        Me.TxAsunto.Location = New System.Drawing.Point(52, 30)
        Me.TxAsunto.Name = "TxAsunto"
        Me.TxAsunto.Size = New System.Drawing.Size(644, 20)
        Me.TxAsunto.TabIndex = 0
        '
        'GMensaje
        '
        Me.GMensaje.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GMensaje.Controls.Add(Me.List_Resultado)
        Me.GMensaje.Controls.Add(Me.rtxMensaje)
        Me.GMensaje.Location = New System.Drawing.Point(280, 78)
        Me.GMensaje.Name = "GMensaje"
        Me.GMensaje.Size = New System.Drawing.Size(710, 376)
        Me.GMensaje.TabIndex = 4
        Me.GMensaje.TabStop = False
        Me.GMensaje.Text = "Mensaje"
        '
        'List_Resultado
        '
        Me.List_Resultado.BackColor = System.Drawing.Color.OldLace
        Me.List_Resultado.FormattingEnabled = True
        Me.List_Resultado.Location = New System.Drawing.Point(163, 87)
        Me.List_Resultado.Name = "List_Resultado"
        Me.List_Resultado.Size = New System.Drawing.Size(369, 134)
        Me.List_Resultado.TabIndex = 1
        Me.List_Resultado.Visible = False
        '
        'rtxMensaje
        '
        Me.rtxMensaje.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxMensaje.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.rtxMensaje.Location = New System.Drawing.Point(9, 19)
        Me.rtxMensaje.Name = "rtxMensaje"
        Me.rtxMensaje.Size = New System.Drawing.Size(687, 331)
        Me.rtxMensaje.TabIndex = 0
        Me.rtxMensaje.Text = ""
        '
        'GTareasPendientes
        '
        Me.GTareasPendientes.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GTareasPendientes.Controls.Add(Me.rtxTareasPendientes)
        Me.GTareasPendientes.Location = New System.Drawing.Point(12, 342)
        Me.GTareasPendientes.Name = "GTareasPendientes"
        Me.GTareasPendientes.Size = New System.Drawing.Size(262, 337)
        Me.GTareasPendientes.TabIndex = 2
        Me.GTareasPendientes.TabStop = False
        Me.GTareasPendientes.Text = "Tareas Pendientes"
        '
        'rtxTareasPendientes
        '
        Me.rtxTareasPendientes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxTareasPendientes.ForeColor = System.Drawing.Color.Crimson
        Me.rtxTareasPendientes.Location = New System.Drawing.Point(6, 19)
        Me.rtxTareasPendientes.Name = "rtxTareasPendientes"
        Me.rtxTareasPendientes.Size = New System.Drawing.Size(247, 311)
        Me.rtxTareasPendientes.TabIndex = 0
        Me.rtxTareasPendientes.Text = ""
        '
        'GInstancias
        '
        Me.GInstancias.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GInstancias.Controls.Add(Me.DGV_Instancias)
        Me.GInstancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GInstancias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GInstancias.Location = New System.Drawing.Point(996, 81)
        Me.GInstancias.Name = "GInstancias"
        Me.GInstancias.Size = New System.Drawing.Size(176, 230)
        Me.GInstancias.TabIndex = 6
        Me.GInstancias.TabStop = False
        Me.GInstancias.Text = "Instancias"
        '
        'DGV_Instancias
        '
        Me.DGV_Instancias.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Instancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Instancias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_IdInstancia, Me.C_Fecha})
        Me.DGV_Instancias.GridColor = System.Drawing.Color.White
        Me.DGV_Instancias.Location = New System.Drawing.Point(6, 20)
        Me.DGV_Instancias.Name = "DGV_Instancias"
        Me.DGV_Instancias.Size = New System.Drawing.Size(164, 204)
        Me.DGV_Instancias.TabIndex = 0
        '
        'C_IdInstancia
        '
        Me.C_IdInstancia.HeaderText = "IdInstancia"
        Me.C_IdInstancia.Name = "C_IdInstancia"
        Me.C_IdInstancia.Visible = False
        '
        'C_Fecha
        '
        Me.C_Fecha.HeaderText = "Fecha"
        Me.C_Fecha.Name = "C_Fecha"
        Me.C_Fecha.Width = 120
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'GTemas
        '
        Me.GTemas.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GTemas.Controls.Add(Me.dgv_Resultado)
        Me.GTemas.Location = New System.Drawing.Point(280, 460)
        Me.GTemas.Name = "GTemas"
        Me.GTemas.Size = New System.Drawing.Size(710, 225)
        Me.GTemas.TabIndex = 14
        Me.GTemas.TabStop = False
        Me.GTemas.Text = "Resultado de la Busqueda"
        '
        'dgv_Resultado
        '
        Me.dgv_Resultado.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Resultado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.C_Titulo, Me.C_Estado, Me.C_Poliza, Me.C_Cotizacion})
        Me.dgv_Resultado.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_Resultado.Location = New System.Drawing.Point(9, 19)
        Me.dgv_Resultado.Name = "dgv_Resultado"
        Me.dgv_Resultado.Size = New System.Drawing.Size(687, 191)
        Me.dgv_Resultado.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'C_Titulo
        '
        Me.C_Titulo.HeaderText = "Titulo"
        Me.C_Titulo.Name = "C_Titulo"
        Me.C_Titulo.Width = 300
        '
        'C_Estado
        '
        Me.C_Estado.HeaderText = "Estado"
        Me.C_Estado.Name = "C_Estado"
        '
        'C_Poliza
        '
        Me.C_Poliza.HeaderText = "Poliza"
        Me.C_Poliza.Name = "C_Poliza"
        '
        'C_Cotizacion
        '
        Me.C_Cotizacion.HeaderText = "Cotizacion"
        Me.C_Cotizacion.Name = "C_Cotizacion"
        '
        'GBotonesTema
        '
        Me.GBotonesTema.Controls.Add(Me.btnTemaNuevo)
        Me.GBotonesTema.Controls.Add(Me.btnEditarTema)
        Me.GBotonesTema.Controls.Add(Me.btnAgregarTema)
        Me.GBotonesTema.Controls.Add(Me.btnBuscarTema)
        Me.GBotonesTema.Location = New System.Drawing.Point(996, 317)
        Me.GBotonesTema.Name = "GBotonesTema"
        Me.GBotonesTema.Size = New System.Drawing.Size(176, 168)
        Me.GBotonesTema.TabIndex = 16
        Me.GBotonesTema.TabStop = False
        Me.GBotonesTema.Text = "Temas"
        '
        'btnEditarTema
        '
        Me.btnEditarTema.Image = Global.Seguimiento.My.Resources.Resources.edit
        Me.btnEditarTema.Location = New System.Drawing.Point(94, 19)
        Me.btnEditarTema.Name = "btnEditarTema"
        Me.btnEditarTema.Size = New System.Drawing.Size(76, 64)
        Me.btnEditarTema.TabIndex = 10
        Me.btnEditarTema.UseVisualStyleBackColor = True
        '
        'btnAgregarTema
        '
        Me.btnAgregarTema.Image = Global.Seguimiento.My.Resources.Resources.plus
        Me.btnAgregarTema.Location = New System.Drawing.Point(6, 19)
        Me.btnAgregarTema.Name = "btnAgregarTema"
        Me.btnAgregarTema.Size = New System.Drawing.Size(76, 64)
        Me.btnAgregarTema.TabIndex = 7
        Me.btnAgregarTema.UseVisualStyleBackColor = True
        '
        'btnBuscarTema
        '
        Me.btnBuscarTema.Image = Global.Seguimiento.My.Resources.Resources.search
        Me.btnBuscarTema.Location = New System.Drawing.Point(6, 92)
        Me.btnBuscarTema.Name = "btnBuscarTema"
        Me.btnBuscarTema.Size = New System.Drawing.Size(76, 59)
        Me.btnBuscarTema.TabIndex = 8
        Me.btnBuscarTema.UseVisualStyleBackColor = True
        '
        'GBotonesInstancia
        '
        Me.GBotonesInstancia.Controls.Add(Me.btnAgregarInstancia)
        Me.GBotonesInstancia.Controls.Add(Me.btnInstanciaEditar)
        Me.GBotonesInstancia.Controls.Add(Me.btnNuevaInstancia)
        Me.GBotonesInstancia.Controls.Add(Me.btnCarpetaBuscar)
        Me.GBotonesInstancia.Location = New System.Drawing.Point(996, 528)
        Me.GBotonesInstancia.Name = "GBotonesInstancia"
        Me.GBotonesInstancia.Size = New System.Drawing.Size(176, 157)
        Me.GBotonesInstancia.TabIndex = 17
        Me.GBotonesInstancia.TabStop = False
        Me.GBotonesInstancia.Text = "Instancias"
        Me.GBotonesInstancia.Visible = False
        '
        'btnTemaNuevo
        '
        Me.btnTemaNuevo.Image = Global.Seguimiento.My.Resources.Resources.NuevoTema
        Me.btnTemaNuevo.Location = New System.Drawing.Point(94, 92)
        Me.btnTemaNuevo.Name = "btnTemaNuevo"
        Me.btnTemaNuevo.Size = New System.Drawing.Size(70, 59)
        Me.btnTemaNuevo.TabIndex = 13
        Me.btnTemaNuevo.UseVisualStyleBackColor = True
        '
        'btnAgregarInstancia
        '
        Me.btnAgregarInstancia.Image = Global.Seguimiento.My.Resources.Resources.plus
        Me.btnAgregarInstancia.Location = New System.Drawing.Point(6, 16)
        Me.btnAgregarInstancia.Name = "btnAgregarInstancia"
        Me.btnAgregarInstancia.Size = New System.Drawing.Size(76, 59)
        Me.btnAgregarInstancia.TabIndex = 6
        Me.btnAgregarInstancia.UseVisualStyleBackColor = True
        '
        'btnInstanciaEditar
        '
        Me.btnInstanciaEditar.Image = Global.Seguimiento.My.Resources.Resources.edit
        Me.btnInstanciaEditar.Location = New System.Drawing.Point(88, 16)
        Me.btnInstanciaEditar.Name = "btnInstanciaEditar"
        Me.btnInstanciaEditar.Size = New System.Drawing.Size(76, 59)
        Me.btnInstanciaEditar.TabIndex = 9
        Me.btnInstanciaEditar.UseVisualStyleBackColor = True
        '
        'btnNuevaInstancia
        '
        Me.btnNuevaInstancia.Image = Global.Seguimiento.My.Resources.Resources.nuevo
        Me.btnNuevaInstancia.Location = New System.Drawing.Point(94, 81)
        Me.btnNuevaInstancia.Name = "btnNuevaInstancia"
        Me.btnNuevaInstancia.Size = New System.Drawing.Size(70, 58)
        Me.btnNuevaInstancia.TabIndex = 12
        Me.btnNuevaInstancia.UseVisualStyleBackColor = True
        '
        'btnCarpetaBuscar
        '
        Me.btnCarpetaBuscar.Image = Global.Seguimiento.My.Resources.Resources.Buscar_Carpeta
        Me.btnCarpetaBuscar.Location = New System.Drawing.Point(6, 81)
        Me.btnCarpetaBuscar.Name = "btnCarpetaBuscar"
        Me.btnCarpetaBuscar.Size = New System.Drawing.Size(76, 58)
        Me.btnCarpetaBuscar.TabIndex = 10
        Me.btnCarpetaBuscar.UseVisualStyleBackColor = True
        '
        'MenuEstado
        '
        Me.MenuEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.EditarToolStripMenuItem1})
        Me.MenuEstado.Name = "MenuEstado"
        Me.MenuEstado.Size = New System.Drawing.Size(117, 48)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'EditarToolStripMenuItem1
        '
        Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EditarToolStripMenuItem1.Text = "Editar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(1184, 697)
        Me.Controls.Add(Me.GBotonesInstancia)
        Me.Controls.Add(Me.GBotonesTema)
        Me.Controls.Add(Me.GTemas)
        Me.Controls.Add(Me.GpoParticipantes)
        Me.Controls.Add(Me.GInstancias)
        Me.Controls.Add(Me.GTareasPendientes)
        Me.Controls.Add(Me.GMensaje)
        Me.Controls.Add(Me.GEmail)
        Me.Controls.Add(Me.GEstado)
        Me.Controls.Add(Me.GComprobante)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento de Temas"
        Me.GpoParticipantes.ResumeLayout(False)
        Me.GpoParticipantes.PerformLayout()
        Me.MenuDatosParticipantes.ResumeLayout(False)
        Me.GComprobante.ResumeLayout(False)
        Me.GComprobante.PerformLayout()
        Me.GEstado.ResumeLayout(False)
        Me.GEmail.ResumeLayout(False)
        Me.GEmail.PerformLayout()
        Me.GMensaje.ResumeLayout(False)
        Me.GTareasPendientes.ResumeLayout(False)
        Me.GInstancias.ResumeLayout(False)
        CType(Me.DGV_Instancias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GTemas.ResumeLayout(False)
        CType(Me.dgv_Resultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBotonesTema.ResumeLayout(False)
        Me.GBotonesInstancia.ResumeLayout(False)
        Me.MenuEstado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GpoParticipantes As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txEmpleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txAsegurado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txProductor As TextBox
    Friend WithEvents GComprobante As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txCotizacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxPoliza As TextBox
    Friend WithEvents GEstado As GroupBox
    Friend WithEvents CboEstado As ComboBox
    Friend WithEvents GEmail As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxAsunto As TextBox
    Friend WithEvents GMensaje As GroupBox
    Friend WithEvents rtxMensaje As RichTextBox
    Friend WithEvents GTareasPendientes As GroupBox
    Friend WithEvents rtxTareasPendientes As RichTextBox
    Friend WithEvents GInstancias As GroupBox
    Friend WithEvents DGV_Instancias As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnAgregarInstancia As Button
    Friend WithEvents btnBuscarTema As Button
    Friend WithEvents btnInstanciaEditar As Button
    Friend WithEvents btnCarpetaBuscar As Button
    Friend WithEvents btnNuevaInstancia As Button
    Friend WithEvents GTemas As GroupBox
    Friend WithEvents dgv_Resultado As DataGridView
    Friend WithEvents List_Resultado As ListBox
    Friend WithEvents txGrupo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents C_Titulo As DataGridViewTextBoxColumn
    Friend WithEvents C_Estado As DataGridViewTextBoxColumn
    Friend WithEvents C_Poliza As DataGridViewTextBoxColumn
    Friend WithEvents C_Cotizacion As DataGridViewTextBoxColumn
    Friend WithEvents C_IdInstancia As DataGridViewTextBoxColumn
    Friend WithEvents C_Fecha As DataGridViewTextBoxColumn
    Friend WithEvents MenuDatosParticipantes As ContextMenuStrip
    Friend WithEvents ProductorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AseguradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditarDatosAseguradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarDatosEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarDatosEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GBotonesTema As GroupBox
    Friend WithEvents btnTemaNuevo As Button
    Friend WithEvents btnEditarTema As Button
    Friend WithEvents btnAgregarTema As Button
    Friend WithEvents GBotonesInstancia As GroupBox
    Friend WithEvents MenuEstado As ContextMenuStrip
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As ToolStripMenuItem
End Class
