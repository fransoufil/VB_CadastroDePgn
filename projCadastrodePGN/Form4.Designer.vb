<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTIPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTIPO))
        Me.btnPESPC = New System.Windows.Forms.Button()
        Me.btnPESSOAL = New System.Windows.Forms.Button()
        Me.btnPC = New System.Windows.Forms.Button()
        Me.btnPESXPC = New System.Windows.Forms.Button()
        Me.btnPCXPC = New System.Windows.Forms.Button()
        Me.btnLICHESS = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPESPC
        '
        Me.btnPESPC.BackColor = System.Drawing.Color.Gray
        Me.btnPESPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPESPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPESPC.ForeColor = System.Drawing.Color.White
        Me.btnPESPC.Image = CType(resources.GetObject("btnPESPC.Image"), System.Drawing.Image)
        Me.btnPESPC.Location = New System.Drawing.Point(293, 46)
        Me.btnPESPC.Name = "btnPESPC"
        Me.btnPESPC.Size = New System.Drawing.Size(212, 190)
        Me.btnPESPC.TabIndex = 1
        Me.btnPESPC.Text = "PES/PC"
        Me.btnPESPC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPESPC.UseVisualStyleBackColor = False
        '
        'btnPESSOAL
        '
        Me.btnPESSOAL.BackColor = System.Drawing.Color.Silver
        Me.btnPESSOAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPESSOAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPESSOAL.Image = CType(resources.GetObject("btnPESSOAL.Image"), System.Drawing.Image)
        Me.btnPESSOAL.Location = New System.Drawing.Point(53, 261)
        Me.btnPESSOAL.Name = "btnPESSOAL"
        Me.btnPESSOAL.Size = New System.Drawing.Size(212, 190)
        Me.btnPESSOAL.TabIndex = 0
        Me.btnPESSOAL.Text = "PESSOAL"
        Me.btnPESSOAL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPESSOAL.UseVisualStyleBackColor = False
        '
        'btnPC
        '
        Me.btnPC.BackColor = System.Drawing.Color.Navy
        Me.btnPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPC.ForeColor = System.Drawing.Color.White
        Me.btnPC.Image = CType(resources.GetObject("btnPC.Image"), System.Drawing.Image)
        Me.btnPC.Location = New System.Drawing.Point(540, 46)
        Me.btnPC.Name = "btnPC"
        Me.btnPC.Size = New System.Drawing.Size(212, 190)
        Me.btnPC.TabIndex = 2
        Me.btnPC.Text = "PC"
        Me.btnPC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPC.UseVisualStyleBackColor = False
        '
        'btnPESXPC
        '
        Me.btnPESXPC.BackColor = System.Drawing.Color.White
        Me.btnPESXPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPESXPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPESXPC.Image = CType(resources.GetObject("btnPESXPC.Image"), System.Drawing.Image)
        Me.btnPESXPC.Location = New System.Drawing.Point(297, 261)
        Me.btnPESXPC.Name = "btnPESXPC"
        Me.btnPESXPC.Size = New System.Drawing.Size(208, 190)
        Me.btnPESXPC.TabIndex = 4
        Me.btnPESXPC.Text = "PES vs PC"
        Me.btnPESXPC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPESXPC.UseVisualStyleBackColor = False
        '
        'btnPCXPC
        '
        Me.btnPCXPC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPCXPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPCXPC.ForeColor = System.Drawing.Color.Black
        Me.btnPCXPC.Image = CType(resources.GetObject("btnPCXPC.Image"), System.Drawing.Image)
        Me.btnPCXPC.Location = New System.Drawing.Point(540, 261)
        Me.btnPCXPC.Name = "btnPCXPC"
        Me.btnPCXPC.Size = New System.Drawing.Size(212, 191)
        Me.btnPCXPC.TabIndex = 3
        Me.btnPCXPC.Text = "PC vs PC"
        Me.btnPCXPC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPCXPC.UseVisualStyleBackColor = False
        '
        'btnLICHESS
        '
        Me.btnLICHESS.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLICHESS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLICHESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLICHESS.ForeColor = System.Drawing.Color.White
        Me.btnLICHESS.Image = CType(resources.GetObject("btnLICHESS.Image"), System.Drawing.Image)
        Me.btnLICHESS.Location = New System.Drawing.Point(53, 46)
        Me.btnLICHESS.Name = "btnLICHESS"
        Me.btnLICHESS.Size = New System.Drawing.Size(212, 190)
        Me.btnLICHESS.TabIndex = 5
        Me.btnLICHESS.Text = "LICHESS"
        Me.btnLICHESS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLICHESS.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(738, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 37)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "VOLTAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmTIPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(827, 533)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLICHESS)
        Me.Controls.Add(Me.btnPCXPC)
        Me.Controls.Add(Me.btnPESXPC)
        Me.Controls.Add(Me.btnPC)
        Me.Controls.Add(Me.btnPESPC)
        Me.Controls.Add(Me.btnPESSOAL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTIPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIPO DE PARTIDA"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPESPC As System.Windows.Forms.Button
    Friend WithEvents btnPESSOAL As System.Windows.Forms.Button
    Friend WithEvents btnPC As System.Windows.Forms.Button
    Friend WithEvents btnPESXPC As System.Windows.Forms.Button
    Friend WithEvents btnPCXPC As System.Windows.Forms.Button
    Friend WithEvents btnLICHESS As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
