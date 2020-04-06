<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FArchivos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.List_Archivos = New System.Windows.Forms.ListBox()
        Me.MenuArchivos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarArchivosSeleccionadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirDirectorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverArchivosAInstanciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuArchivos.SuspendLayout()
        Me.SuspendLayout()
        '
        'List_Archivos
        '
        Me.List_Archivos.BackColor = System.Drawing.Color.OldLace
        Me.List_Archivos.ContextMenuStrip = Me.MenuArchivos
        Me.List_Archivos.FormattingEnabled = True
        Me.List_Archivos.Location = New System.Drawing.Point(71, 27)
        Me.List_Archivos.Name = "List_Archivos"
        Me.List_Archivos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.List_Archivos.Size = New System.Drawing.Size(632, 251)
        Me.List_Archivos.TabIndex = 3
        '
        'MenuArchivos
        '
        Me.MenuArchivos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarArchivosSeleccionadosToolStripMenuItem, Me.AbrirDirectorioToolStripMenuItem, Me.MoverArchivosAInstanciaToolStripMenuItem})
        Me.MenuArchivos.Name = "MenuArchivos"
        Me.MenuArchivos.Size = New System.Drawing.Size(217, 70)
        '
        'EliminarArchivosSeleccionadosToolStripMenuItem
        '
        Me.EliminarArchivosSeleccionadosToolStripMenuItem.Name = "EliminarArchivosSeleccionadosToolStripMenuItem"
        Me.EliminarArchivosSeleccionadosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.EliminarArchivosSeleccionadosToolStripMenuItem.Text = "Eliminar del Listado"
        '
        'AbrirDirectorioToolStripMenuItem
        '
        Me.AbrirDirectorioToolStripMenuItem.Name = "AbrirDirectorioToolStripMenuItem"
        Me.AbrirDirectorioToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.AbrirDirectorioToolStripMenuItem.Text = "Abrir Directorio"
        '
        'MoverArchivosAInstanciaToolStripMenuItem
        '
        Me.MoverArchivosAInstanciaToolStripMenuItem.Name = "MoverArchivosAInstanciaToolStripMenuItem"
        Me.MoverArchivosAInstanciaToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.MoverArchivosAInstanciaToolStripMenuItem.Text = "Mover Archivos a Instancia"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'FArchivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.List_Archivos)
        Me.Name = "FArchivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion de Archivos"
        Me.MenuArchivos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents List_Archivos As ListBox
    Friend WithEvents MenuArchivos As ContextMenuStrip
    Friend WithEvents EliminarArchivosSeleccionadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirDirectorioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MoverArchivosAInstanciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
