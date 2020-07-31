<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPECAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPECAS))
        Me.btnPRETAS = New System.Windows.Forms.Button()
        Me.btnBRANCAS = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPRETAS
        '
        Me.btnPRETAS.BackColor = System.Drawing.Color.White
        Me.btnPRETAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPRETAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPRETAS.ForeColor = System.Drawing.Color.Black
        Me.btnPRETAS.Image = CType(resources.GetObject("btnPRETAS.Image"), System.Drawing.Image)
        Me.btnPRETAS.Location = New System.Drawing.Point(396, 12)
        Me.btnPRETAS.Name = "btnPRETAS"
        Me.btnPRETAS.Size = New System.Drawing.Size(353, 234)
        Me.btnPRETAS.TabIndex = 1
        Me.btnPRETAS.Text = "PEÇAS PRETAS"
        Me.btnPRETAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPRETAS.UseVisualStyleBackColor = False
        '
        'btnBRANCAS
        '
        Me.btnBRANCAS.BackColor = System.Drawing.Color.Black
        Me.btnBRANCAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBRANCAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBRANCAS.ForeColor = System.Drawing.Color.White
        Me.btnBRANCAS.Image = CType(resources.GetObject("btnBRANCAS.Image"), System.Drawing.Image)
        Me.btnBRANCAS.Location = New System.Drawing.Point(25, 12)
        Me.btnBRANCAS.Name = "btnBRANCAS"
        Me.btnBRANCAS.Size = New System.Drawing.Size(353, 234)
        Me.btnBRANCAS.TabIndex = 0
        Me.btnBRANCAS.Text = "PEÇAS BRANCAS"
        Me.btnBRANCAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBRANCAS.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(694, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 37)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "VOLTAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmPECAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(783, 316)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPRETAS)
        Me.Controls.Add(Me.btnBRANCAS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPECAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESCOLHA DAS PEÇAS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPRETAS As System.Windows.Forms.Button
    Friend WithEvents btnBRANCAS As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
