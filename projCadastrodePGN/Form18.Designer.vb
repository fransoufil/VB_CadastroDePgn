<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBACKUP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formBACKUP))
        Me.txtPGN = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnCOLAR = New System.Windows.Forms.Button()
        Me.btnCOPIAR = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPGN
        '
        Me.txtPGN.BackColor = System.Drawing.Color.White
        Me.txtPGN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPGN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPGN.Location = New System.Drawing.Point(20, 46)
        Me.txtPGN.Multiline = True
        Me.txtPGN.Name = "txtPGN"
        Me.txtPGN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPGN.Size = New System.Drawing.Size(861, 527)
        Me.txtPGN.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(788, 583)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 44)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "FECHAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 583)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(271, 29)
        Me.LinkLabel1.TabIndex = 74
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ABRIR NO LICHESS..."
        '
        'btnCOLAR
        '
        Me.btnCOLAR.BackColor = System.Drawing.Color.Blue
        Me.btnCOLAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCOLAR.ForeColor = System.Drawing.Color.White
        Me.btnCOLAR.Location = New System.Drawing.Point(514, 583)
        Me.btnCOLAR.Name = "btnCOLAR"
        Me.btnCOLAR.Size = New System.Drawing.Size(89, 44)
        Me.btnCOLAR.TabIndex = 101
        Me.btnCOLAR.Text = "COLAR"
        Me.btnCOLAR.UseVisualStyleBackColor = False
        '
        'btnCOPIAR
        '
        Me.btnCOPIAR.BackColor = System.Drawing.Color.Yellow
        Me.btnCOPIAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCOPIAR.ForeColor = System.Drawing.Color.Black
        Me.btnCOPIAR.Location = New System.Drawing.Point(399, 583)
        Me.btnCOPIAR.Name = "btnCOPIAR"
        Me.btnCOPIAR.Size = New System.Drawing.Size(89, 44)
        Me.btnCOPIAR.TabIndex = 100
        Me.btnCOPIAR.Text = "COPIAR"
        Me.btnCOPIAR.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(628, 583)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 44)
        Me.Button2.TabIndex = 102
        Me.Button2.Text = "SALVAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'formBACKUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(901, 634)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCOLAR)
        Me.Controls.Add(Me.btnCOPIAR)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPGN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formBACKUP"
        Me.Text = "PGN CARREGADO:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPGN As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnCOLAR As System.Windows.Forms.Button
    Friend WithEvents btnCOPIAR As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
