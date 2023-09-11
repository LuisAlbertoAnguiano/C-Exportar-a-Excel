<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DGV_Depositos = New System.Windows.Forms.DataGridView()
        Me.BT_Exportar = New System.Windows.Forms.Button()
        CType(Me.DGV_Depositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Depositos
        '
        Me.DGV_Depositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Depositos.Location = New System.Drawing.Point(97, 73)
        Me.DGV_Depositos.Name = "DGV_Depositos"
        Me.DGV_Depositos.Size = New System.Drawing.Size(615, 180)
        Me.DGV_Depositos.TabIndex = 0
        '
        'BT_Exportar
        '
        Me.BT_Exportar.BackColor = System.Drawing.Color.Green
        Me.BT_Exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Exportar.ForeColor = System.Drawing.Color.White
        Me.BT_Exportar.Location = New System.Drawing.Point(292, 292)
        Me.BT_Exportar.Name = "BT_Exportar"
        Me.BT_Exportar.Size = New System.Drawing.Size(234, 69)
        Me.BT_Exportar.TabIndex = 1
        Me.BT_Exportar.Text = "Exportar a Excel"
        Me.BT_Exportar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BT_Exportar)
        Me.Controls.Add(Me.DGV_Depositos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV_Depositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Depositos As DataGridView
    Friend WithEvents BT_Exportar As Button
End Class
