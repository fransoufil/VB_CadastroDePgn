<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFINAL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFINAL))
        Me.btnEMPATE = New System.Windows.Forms.Button()
        Me.btnVITORIA = New System.Windows.Forms.Button()
        Me.btnDERROTA = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEMPATE
        '
        Me.btnEMPATE.BackColor = System.Drawing.Color.Silver
        Me.btnEMPATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEMPATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEMPATE.ForeColor = System.Drawing.Color.Black
        Me.btnEMPATE.Image = CType(resources.GetObject("btnEMPATE.Image"), System.Drawing.Image)
        Me.btnEMPATE.Location = New System.Drawing.Point(272, 35)
        Me.btnEMPATE.Name = "btnEMPATE"
        Me.btnEMPATE.Size = New System.Drawing.Size(230, 234)
        Me.btnEMPATE.TabIndex = 1
        Me.btnEMPATE.Text = "EMPATE"
        Me.btnEMPATE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEMPATE.UseVisualStyleBackColor = False
        '
        'btnVITORIA
        '
        Me.btnVITORIA.BackColor = System.Drawing.Color.White
        Me.btnVITORIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVITORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVITORIA.Image = CType(resources.GetObject("btnVITORIA.Image"), System.Drawing.Image)
        Me.btnVITORIA.Location = New System.Drawing.Point(36, 35)
        Me.btnVITORIA.Name = "btnVITORIA"
        Me.btnVITORIA.Size = New System.Drawing.Size(230, 234)
        Me.btnVITORIA.TabIndex = 0
        Me.btnVITORIA.Text = "VITÓRIA"
        Me.btnVITORIA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVITORIA.UseVisualStyleBackColor = False
        '
        'btnDERROTA
        '
        Me.btnDERROTA.BackColor = System.Drawing.Color.White
        Me.btnDERROTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDERROTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDERROTA.ForeColor = System.Drawing.Color.Black
        Me.btnDERROTA.Image = CType(resources.GetObject("btnDERROTA.Image"), System.Drawing.Image)
        Me.btnDERROTA.Location = New System.Drawing.Point(508, 35)
        Me.btnDERROTA.Name = "btnDERROTA"
        Me.btnDERROTA.Size = New System.Drawing.Size(230, 234)
        Me.btnDERROTA.TabIndex = 2
        Me.btnDERROTA.Text = "DERROTA"
        Me.btnDERROTA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDERROTA.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(698, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 37)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "VOLTAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmFINAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(787, 345)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDERROTA)
        Me.Controls.Add(Me.btnEMPATE)
        Me.Controls.Add(Me.btnVITORIA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFINAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUAL O FINAL?"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEMPATE As System.Windows.Forms.Button
    Friend WithEvents btnVITORIA As System.Windows.Forms.Button
    Friend WithEvents btnDERROTA As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
