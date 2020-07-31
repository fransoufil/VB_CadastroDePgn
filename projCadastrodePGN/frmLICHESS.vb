Public Class frmLICHESS

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tipodapartida = "PES"
        nome = lblAARONPETROSIAN.Text
        siglatipo = "aap a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(28)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        tipodapartida = "PES"
        nome = lblCAROLCRISMARSOU.Text
        siglatipo = "ccms a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(29)


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        tipodapartida = "PES"
        nome = lblEUSOUKANN.Text
        siglatipo = "esk a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(30)


    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        tipodapartida = "PES"
        nome = lblFRANXSOUZA.Text
        siglatipo = "fxsou a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(31)


    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        tipodapartida = "PES"
        nome = lblFRANZKARPOV.Text
        siglatipo = "fkar a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(32)


    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        tipodapartida = "PES"
        nome = lblPARTIDASDEUM.Text
        siglatipo = "pdum a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(35)


    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        tipodapartida = "PES"
        nome = lblPARTIDASDETRES.Text
        siglatipo = "ptres a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(36)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tipodapartida = "PES"
        nome = lblSOUZA_XADREZ.Text
        siglatipo = "soux a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(33)


    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        tipodapartida = "PES"
        nome = lblSOPRATORNEIO.Text
        siglatipo = "spt a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(34)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tipodapartida = "PES"
        nome = lblPARTIDASDECINCO.Text
        siglatipo = "pcin a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(37)



    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        On Error Resume Next

        Dim novo As String

        novo = InputBox("INSIRA UM NOME VÁLIDO!", "NOVO USUÁRIO", "lichess", vbOKOnly)


        tipodapartida = "PES"
        nome = novo.ToUpper
        siglatipo = novo.Substring(0, 3).ToLower + " a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(38)



    End Sub

    
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        tipodapartida = "PES"
        nome = lblPARTIDASDEDEZ.Text
        siglatipo = "pdez a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(39)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        tipodapartida = "PES"
        nome = lblPARTIDASDEDOIS.Text
        siglatipo = "pde2 a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(40)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        tipodapartida = "PES"
        nome = lblANATOLYPATOV.Text
        siglatipo = "pat a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(41)
    End Sub

    Private Sub btnAPRENDIZOVISKY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAPRENDIZOVISKY.Click
        tipodapartida = "PES"
        nome = lblAPRENDIZOVISKY.Text
        siglatipo = "apr a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(42)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        tipodapartida = "PES"
        nome = lblZECAZOVSK.Text
        siglatipo = "zec a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(43)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        tipodapartida = "PES"
        nome = lblUMMAISUMBOY.Text
        siglatipo = "u+u a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(44)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        tipodapartida = "PES"
        nome = lbl3m2.Text
        siglatipo = "3m2 a"
        lblPERFIL.Text = nome
        frmCADASTRAR.Show()
        frmCADASTRAR.lblTIPO.Text = nome.ToUpper
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(45)
    End Sub
End Class