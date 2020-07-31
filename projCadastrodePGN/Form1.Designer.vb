<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmINICIO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmINICIO))
        Me.btnCADASTRAR = New System.Windows.Forms.Button()
        Me.btnCONSULTAR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCADASTRAR
        '
        Me.btnCADASTRAR.BackColor = System.Drawing.Color.Gray
        Me.btnCADASTRAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCADASTRAR.Image = CType(resources.GetObject("btnCADASTRAR.Image"), System.Drawing.Image)
        Me.btnCADASTRAR.Location = New System.Drawing.Point(71, 15)
        Me.btnCADASTRAR.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCADASTRAR.Name = "btnCADASTRAR"
        Me.btnCADASTRAR.Size = New System.Drawing.Size(436, 261)
        Me.btnCADASTRAR.TabIndex = 0
        Me.btnCADASTRAR.Text = "CADASTRAR"
        Me.btnCADASTRAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCADASTRAR.UseVisualStyleBackColor = False
        '
        'btnCONSULTAR
        '
        Me.btnCONSULTAR.BackColor = System.Drawing.Color.White
        Me.btnCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCONSULTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCONSULTAR.ForeColor = System.Drawing.Color.Black
        Me.btnCONSULTAR.Image = CType(resources.GetObject("btnCONSULTAR.Image"), System.Drawing.Image)
        Me.btnCONSULTAR.Location = New System.Drawing.Point(535, 15)
        Me.btnCONSULTAR.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCONSULTAR.Name = "btnCONSULTAR"
        Me.btnCONSULTAR.Size = New System.Drawing.Size(436, 261)
        Me.btnCONSULTAR.TabIndex = 1
        Me.btnCONSULTAR.Text = "CONSULTAR"
        Me.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCONSULTAR.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(451, 334)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 73)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "FIM"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmINICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1039, 433)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCONSULTAR)
        Me.Controls.Add(Me.btnCADASTRAR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmINICIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISTEMA DE CADASTRO E CONSULTA DE PGNS 7.4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCADASTRAR As System.Windows.Forms.Button
    Friend WithEvents btnCONSULTAR As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
