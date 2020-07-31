<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCONSULTA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCONSULTA))
        Me.listARQUIVOS = New System.Windows.Forms.ListBox()
        Me.txtPGN = New System.Windows.Forms.TextBox()
        Me.btnAPLICARNOME = New System.Windows.Forms.Button()
        Me.txtQUANTIDADEDEPGN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDIRETORIO = New System.Windows.Forms.TextBox()
        Me.txtITEM = New System.Windows.Forms.TextBox()
        Me.txtEVENTO = New System.Windows.Forms.TextBox()
        Me.txtDATA = New System.Windows.Forms.TextBox()
        Me.txtRESULTADO = New System.Windows.Forms.TextBox()
        Me.txtNOMEDOPGN = New System.Windows.Forms.TextBox()
        Me.txtNUMCARPGN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTAMANHODOPGN = New System.Windows.Forms.TextBox()
        Me.btnCOPIAR = New System.Windows.Forms.Button()
        Me.btnSALVARCOMO = New System.Windows.Forms.Button()
        Me.btnTIRARMARCAS = New System.Windows.Forms.Button()
        Me.btnAPLICAR = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBRANCAS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPRETAS = New System.Windows.Forms.TextBox()
        Me.btnTRANSPOR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLIMPAR = New System.Windows.Forms.Button()
        Me.btnALTERARTAMANHO = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtABERTURA = New System.Windows.Forms.TextBox()
        Me.btnCOLAR = New System.Windows.Forms.Button()
        Me.txtCOMENTARIO = New System.Windows.Forms.TextBox()
        Me.btnCOMENTARIO = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnOBSERVACAO = New System.Windows.Forms.Button()
        Me.btnSALVARTUDO = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listARQUIVOS
        '
        Me.listARQUIVOS.BackColor = System.Drawing.Color.Black
        Me.listARQUIVOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listARQUIVOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listARQUIVOS.ForeColor = System.Drawing.Color.Yellow
        Me.listARQUIVOS.FormattingEnabled = True
        Me.listARQUIVOS.Location = New System.Drawing.Point(29, 108)
        Me.listARQUIVOS.Name = "listARQUIVOS"
        Me.listARQUIVOS.ScrollAlwaysVisible = True
        Me.listARQUIVOS.Size = New System.Drawing.Size(920, 522)
        Me.listARQUIVOS.TabIndex = 1
        '
        'txtPGN
        '
        Me.txtPGN.BackColor = System.Drawing.Color.White
        Me.txtPGN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPGN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPGN.Location = New System.Drawing.Point(967, 26)
        Me.txtPGN.Multiline = True
        Me.txtPGN.Name = "txtPGN"
        Me.txtPGN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPGN.Size = New System.Drawing.Size(861, 527)
        Me.txtPGN.TabIndex = 1
        '
        'btnAPLICARNOME
        '
        Me.btnAPLICARNOME.BackColor = System.Drawing.Color.White
        Me.btnAPLICARNOME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAPLICARNOME.Location = New System.Drawing.Point(29, 26)
        Me.btnAPLICARNOME.Name = "btnAPLICARNOME"
        Me.btnAPLICARNOME.Size = New System.Drawing.Size(148, 76)
        Me.btnAPLICARNOME.TabIndex = 0
        Me.btnAPLICARNOME.Text = "&BUSCAR DIRETÓRIO"
        Me.btnAPLICARNOME.UseVisualStyleBackColor = False
        '
        'txtQUANTIDADEDEPGN
        '
        Me.txtQUANTIDADEDEPGN.BackColor = System.Drawing.Color.White
        Me.txtQUANTIDADEDEPGN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQUANTIDADEDEPGN.ForeColor = System.Drawing.Color.Black
        Me.txtQUANTIDADEDEPGN.Location = New System.Drawing.Point(104, 640)
        Me.txtQUANTIDADEDEPGN.Name = "txtQUANTIDADEDEPGN"
        Me.txtQUANTIDADEDEPGN.Size = New System.Drawing.Size(78, 21)
        Me.txtQUANTIDADEDEPGN.TabIndex = 11
        Me.txtQUANTIDADEDEPGN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(188, 641)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ARQUIVOS NO DIRETÓRIO"
        '
        'txtDIRETORIO
        '
        Me.txtDIRETORIO.BackColor = System.Drawing.Color.White
        Me.txtDIRETORIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDIRETORIO.ForeColor = System.Drawing.Color.Black
        Me.txtDIRETORIO.Location = New System.Drawing.Point(373, 641)
        Me.txtDIRETORIO.Multiline = True
        Me.txtDIRETORIO.Name = "txtDIRETORIO"
        Me.txtDIRETORIO.Size = New System.Drawing.Size(494, 14)
        Me.txtDIRETORIO.TabIndex = 13
        '
        'txtITEM
        '
        Me.txtITEM.BackColor = System.Drawing.Color.White
        Me.txtITEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtITEM.Location = New System.Drawing.Point(970, 671)
        Me.txtITEM.Multiline = True
        Me.txtITEM.Name = "txtITEM"
        Me.txtITEM.Size = New System.Drawing.Size(65, 21)
        Me.txtITEM.TabIndex = 14
        Me.txtITEM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEVENTO
        '
        Me.txtEVENTO.BackColor = System.Drawing.Color.White
        Me.txtEVENTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEVENTO.Location = New System.Drawing.Point(970, 755)
        Me.txtEVENTO.Multiline = True
        Me.txtEVENTO.Name = "txtEVENTO"
        Me.txtEVENTO.Size = New System.Drawing.Size(296, 21)
        Me.txtEVENTO.TabIndex = 15
        Me.txtEVENTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDATA
        '
        Me.txtDATA.BackColor = System.Drawing.Color.White
        Me.txtDATA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDATA.Location = New System.Drawing.Point(970, 801)
        Me.txtDATA.Multiline = True
        Me.txtDATA.Name = "txtDATA"
        Me.txtDATA.Size = New System.Drawing.Size(135, 21)
        Me.txtDATA.TabIndex = 16
        Me.txtDATA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRESULTADO
        '
        Me.txtRESULTADO.BackColor = System.Drawing.Color.White
        Me.txtRESULTADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRESULTADO.Location = New System.Drawing.Point(970, 941)
        Me.txtRESULTADO.Multiline = True
        Me.txtRESULTADO.Name = "txtRESULTADO"
        Me.txtRESULTADO.Size = New System.Drawing.Size(65, 21)
        Me.txtRESULTADO.TabIndex = 17
        Me.txtRESULTADO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNOMEDOPGN
        '
        Me.txtNOMEDOPGN.BackColor = System.Drawing.Color.White
        Me.txtNOMEDOPGN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNOMEDOPGN.Location = New System.Drawing.Point(970, 713)
        Me.txtNOMEDOPGN.Multiline = True
        Me.txtNOMEDOPGN.Name = "txtNOMEDOPGN"
        Me.txtNOMEDOPGN.Size = New System.Drawing.Size(541, 21)
        Me.txtNOMEDOPGN.TabIndex = 18
        Me.txtNOMEDOPGN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNUMCARPGN
        '
        Me.txtNUMCARPGN.BackColor = System.Drawing.Color.White
        Me.txtNUMCARPGN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNUMCARPGN.Location = New System.Drawing.Point(1532, 713)
        Me.txtNUMCARPGN.Multiline = True
        Me.txtNUMCARPGN.Name = "txtNUMCARPGN"
        Me.txtNUMCARPGN.Size = New System.Drawing.Size(65, 21)
        Me.txtNUMCARPGN.TabIndex = 19
        Me.txtNUMCARPGN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 640)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "TOTAL DE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(967, 653)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "PGN Nº"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(967, 695)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "NOME DO ARQUIVO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(967, 737)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "EVENTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(967, 783)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "DATA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(967, 923)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "RESULTADO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1529, 695)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "TAMANHO DO NOME"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderBrowserDialog1.SelectedPath = "C:\Users\FRANZ\Documents\02_XADREZ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1054, 653)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "TAMANHO DO PGN"
        '
        'txtTAMANHODOPGN
        '
        Me.txtTAMANHODOPGN.BackColor = System.Drawing.Color.White
        Me.txtTAMANHODOPGN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTAMANHODOPGN.Location = New System.Drawing.Point(1057, 671)
        Me.txtTAMANHODOPGN.Multiline = True
        Me.txtTAMANHODOPGN.Name = "txtTAMANHODOPGN"
        Me.txtTAMANHODOPGN.Size = New System.Drawing.Size(127, 21)
        Me.txtTAMANHODOPGN.TabIndex = 27
        Me.txtTAMANHODOPGN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCOPIAR
        '
        Me.btnCOPIAR.BackColor = System.Drawing.Color.White
        Me.btnCOPIAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCOPIAR.Location = New System.Drawing.Point(967, 559)
        Me.btnCOPIAR.Name = "btnCOPIAR"
        Me.btnCOPIAR.Size = New System.Drawing.Size(148, 76)
        Me.btnCOPIAR.TabIndex = 29
        Me.btnCOPIAR.Text = "COPIAR"
        Me.btnCOPIAR.UseVisualStyleBackColor = False
        '
        'btnSALVARCOMO
        '
        Me.btnSALVARCOMO.BackColor = System.Drawing.Color.White
        Me.btnSALVARCOMO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALVARCOMO.Location = New System.Drawing.Point(1523, 559)
        Me.btnSALVARCOMO.Name = "btnSALVARCOMO"
        Me.btnSALVARCOMO.Size = New System.Drawing.Size(148, 76)
        Me.btnSALVARCOMO.TabIndex = 30
        Me.btnSALVARCOMO.Text = "SALVAR COMO"
        Me.btnSALVARCOMO.UseVisualStyleBackColor = False
        '
        'btnTIRARMARCAS
        '
        Me.btnTIRARMARCAS.BackColor = System.Drawing.Color.White
        Me.btnTIRARMARCAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTIRARMARCAS.Location = New System.Drawing.Point(1121, 559)
        Me.btnTIRARMARCAS.Name = "btnTIRARMARCAS"
        Me.btnTIRARMARCAS.Size = New System.Drawing.Size(148, 76)
        Me.btnTIRARMARCAS.TabIndex = 31
        Me.btnTIRARMARCAS.Text = "TIRAR MARCAS"
        Me.btnTIRARMARCAS.UseVisualStyleBackColor = False
        '
        'btnAPLICAR
        '
        Me.btnAPLICAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAPLICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAPLICAR.Location = New System.Drawing.Point(1369, 558)
        Me.btnAPLICAR.Name = "btnAPLICAR"
        Me.btnAPLICAR.Size = New System.Drawing.Size(148, 76)
        Me.btnAPLICAR.TabIndex = 32
        Me.btnAPLICAR.Text = "APLICAR NOME"
        Me.btnAPLICAR.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(967, 834)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 15)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "BRANCAS"
        '
        'txtBRANCAS
        '
        Me.txtBRANCAS.BackColor = System.Drawing.Color.White
        Me.txtBRANCAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBRANCAS.Location = New System.Drawing.Point(970, 852)
        Me.txtBRANCAS.Multiline = True
        Me.txtBRANCAS.Name = "txtBRANCAS"
        Me.txtBRANCAS.Size = New System.Drawing.Size(135, 21)
        Me.txtBRANCAS.TabIndex = 33
        Me.txtBRANCAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(967, 876)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 15)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "PRETAS"
        '
        'txtPRETAS
        '
        Me.txtPRETAS.BackColor = System.Drawing.Color.White
        Me.txtPRETAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPRETAS.Location = New System.Drawing.Point(970, 894)
        Me.txtPRETAS.Multiline = True
        Me.txtPRETAS.Name = "txtPRETAS"
        Me.txtPRETAS.Size = New System.Drawing.Size(135, 21)
        Me.txtPRETAS.TabIndex = 35
        Me.txtPRETAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTRANSPOR
        '
        Me.btnTRANSPOR.BackColor = System.Drawing.Color.White
        Me.btnTRANSPOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTRANSPOR.Location = New System.Drawing.Point(801, 26)
        Me.btnTRANSPOR.Name = "btnTRANSPOR"
        Me.btnTRANSPOR.Size = New System.Drawing.Size(148, 76)
        Me.btnTRANSPOR.TabIndex = 37
        Me.btnTRANSPOR.Text = "TRANSPOR"
        Me.btnTRANSPOR.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(1757, 964)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 62)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "VOLTAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnLIMPAR
        '
        Me.btnLIMPAR.BackColor = System.Drawing.Color.White
        Me.btnLIMPAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLIMPAR.Location = New System.Drawing.Point(431, 46)
        Me.btnLIMPAR.Name = "btnLIMPAR"
        Me.btnLIMPAR.Size = New System.Drawing.Size(88, 56)
        Me.btnLIMPAR.TabIndex = 39
        Me.btnLIMPAR.Text = "LIMPAR"
        Me.btnLIMPAR.UseVisualStyleBackColor = False
        '
        'btnALTERARTAMANHO
        '
        Me.btnALTERARTAMANHO.BackColor = System.Drawing.Color.White
        Me.btnALTERARTAMANHO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnALTERARTAMANHO.Location = New System.Drawing.Point(1275, 558)
        Me.btnALTERARTAMANHO.Name = "btnALTERARTAMANHO"
        Me.btnALTERARTAMANHO.Size = New System.Drawing.Size(88, 56)
        Me.btnALTERARTAMANHO.TabIndex = 40
        Me.btnALTERARTAMANHO.Text = "ALTERAR TAMANHO"
        Me.btnALTERARTAMANHO.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(967, 975)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 15)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "ABERTURA"
        '
        'txtABERTURA
        '
        Me.txtABERTURA.BackColor = System.Drawing.Color.White
        Me.txtABERTURA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtABERTURA.Location = New System.Drawing.Point(970, 993)
        Me.txtABERTURA.Multiline = True
        Me.txtABERTURA.Name = "txtABERTURA"
        Me.txtABERTURA.Size = New System.Drawing.Size(541, 21)
        Me.txtABERTURA.TabIndex = 41
        Me.txtABERTURA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCOLAR
        '
        Me.btnCOLAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCOLAR.Location = New System.Drawing.Point(1680, 558)
        Me.btnCOLAR.Name = "btnCOLAR"
        Me.btnCOLAR.Size = New System.Drawing.Size(148, 76)
        Me.btnCOLAR.TabIndex = 43
        Me.btnCOLAR.Text = "COLAR"
        Me.btnCOLAR.UseVisualStyleBackColor = True
        '
        'txtCOMENTARIO
        '
        Me.txtCOMENTARIO.BackColor = System.Drawing.Color.White
        Me.txtCOMENTARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOMENTARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOMENTARIO.Location = New System.Drawing.Point(29, 695)
        Me.txtCOMENTARIO.Multiline = True
        Me.txtCOMENTARIO.Name = "txtCOMENTARIO"
        Me.txtCOMENTARIO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCOMENTARIO.Size = New System.Drawing.Size(920, 228)
        Me.txtCOMENTARIO.TabIndex = 42
        '
        'btnCOMENTARIO
        '
        Me.btnCOMENTARIO.BackColor = System.Drawing.Color.White
        Me.btnCOMENTARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCOMENTARIO.Location = New System.Drawing.Point(402, 938)
        Me.btnCOMENTARIO.Name = "btnCOMENTARIO"
        Me.btnCOMENTARIO.Size = New System.Drawing.Size(148, 76)
        Me.btnCOMENTARIO.TabIndex = 43
        Me.btnCOMENTARIO.Text = "APLICAR"
        Me.btnCOMENTARIO.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(26, 677)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "COMENTÁRIO:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(1246, 857)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(271, 29)
        Me.LinkLabel1.TabIndex = 47
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ABRIR NO LICHESS..."
        '
        'btnOBSERVACAO
        '
        Me.btnOBSERVACAO.BackColor = System.Drawing.Color.White
        Me.btnOBSERVACAO.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOBSERVACAO.Location = New System.Drawing.Point(1275, 620)
        Me.btnOBSERVACAO.Name = "btnOBSERVACAO"
        Me.btnOBSERVACAO.Size = New System.Drawing.Size(88, 56)
        Me.btnOBSERVACAO.TabIndex = 48
        Me.btnOBSERVACAO.Text = "OBSERVAÇÃO"
        Me.btnOBSERVACAO.UseVisualStyleBackColor = False
        '
        'btnSALVARTUDO
        '
        Me.btnSALVARTUDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSALVARTUDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSALVARTUDO.ForeColor = System.Drawing.Color.White
        Me.btnSALVARTUDO.Location = New System.Drawing.Point(1680, 645)
        Me.btnSALVARTUDO.Name = "btnSALVARTUDO"
        Me.btnSALVARTUDO.Size = New System.Drawing.Size(148, 76)
        Me.btnSALVARTUDO.TabIndex = 49
        Me.btnSALVARTUDO.Text = "SALVAR TUDO NOVAMENTE"
        Me.btnSALVARTUDO.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1680, 727)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 76)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "CORTAR PGN"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1680, 810)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 76)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "CORTAR ABRINDO LICHESS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmCONSULTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1853, 1038)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSALVARTUDO)
        Me.Controls.Add(Me.btnOBSERVACAO)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCOMENTARIO)
        Me.Controls.Add(Me.txtCOMENTARIO)
        Me.Controls.Add(Me.btnCOLAR)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtABERTURA)
        Me.Controls.Add(Me.btnALTERARTAMANHO)
        Me.Controls.Add(Me.btnLIMPAR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTRANSPOR)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPRETAS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBRANCAS)
        Me.Controls.Add(Me.btnTIRARMARCAS)
        Me.Controls.Add(Me.btnAPLICAR)
        Me.Controls.Add(Me.btnSALVARCOMO)
        Me.Controls.Add(Me.btnCOPIAR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTAMANHODOPGN)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNUMCARPGN)
        Me.Controls.Add(Me.txtNOMEDOPGN)
        Me.Controls.Add(Me.txtRESULTADO)
        Me.Controls.Add(Me.txtDATA)
        Me.Controls.Add(Me.txtEVENTO)
        Me.Controls.Add(Me.txtITEM)
        Me.Controls.Add(Me.txtDIRETORIO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQUANTIDADEDEPGN)
        Me.Controls.Add(Me.btnAPLICARNOME)
        Me.Controls.Add(Me.txtPGN)
        Me.Controls.Add(Me.listARQUIVOS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmCONSULTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE PGN - SISTEMA DE CADASTRO E CONSULTA DE PGN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listARQUIVOS As System.Windows.Forms.ListBox
    Friend WithEvents txtPGN As System.Windows.Forms.TextBox
    Friend WithEvents btnAPLICARNOME As System.Windows.Forms.Button
    Friend WithEvents txtQUANTIDADEDEPGN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDIRETORIO As System.Windows.Forms.TextBox
    Friend WithEvents txtITEM As System.Windows.Forms.TextBox
    Friend WithEvents txtEVENTO As System.Windows.Forms.TextBox
    Friend WithEvents txtDATA As System.Windows.Forms.TextBox
    Friend WithEvents txtRESULTADO As System.Windows.Forms.TextBox
    Friend WithEvents txtNOMEDOPGN As System.Windows.Forms.TextBox
    Friend WithEvents txtNUMCARPGN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTAMANHODOPGN As System.Windows.Forms.TextBox
    Friend WithEvents btnCOPIAR As System.Windows.Forms.Button
    Friend WithEvents btnSALVARCOMO As System.Windows.Forms.Button
    Friend WithEvents btnTIRARMARCAS As System.Windows.Forms.Button
    Friend WithEvents btnAPLICAR As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBRANCAS As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPRETAS As System.Windows.Forms.TextBox
    Friend WithEvents btnTRANSPOR As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnLIMPAR As System.Windows.Forms.Button
    Friend WithEvents btnALTERARTAMANHO As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtABERTURA As System.Windows.Forms.TextBox
    Friend WithEvents btnCOLAR As System.Windows.Forms.Button
    Friend WithEvents txtCOMENTARIO As System.Windows.Forms.TextBox
    Friend WithEvents btnCOMENTARIO As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnOBSERVACAO As Button
    Friend WithEvents btnSALVARTUDO As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
