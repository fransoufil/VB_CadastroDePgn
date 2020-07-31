Public Class frmTIPO

    Private Sub btnPESSOAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPESSOAL.Click

        frmCADASTRAR.Show()
        tipodapartida = "PES"
        nome = "PESSOAL"
        siglatipo = "a"
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(0)


        'Me.Close()
    End Sub

    Private Sub btnPESPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPESPC.Click
        frmMESTRE.Show()
        tipodapartida = "PES/PC"
        siglatipo = "ac"
        'nome = "PES/PC"
        'Me.Close()
    End Sub

    Private Sub btnPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPC.Click
        frmMESTRE.Show()
        tipodapartida = "PC"
        siglatipo = "c"
        'nome = "PC"
        ' Me.Close()
    End Sub

    Private Sub btnPCXPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPCXPC.Click

        frmBRANCAS.Show()
        tipodapartida = "PCXPC"
        siglatipo = "sc"
        'nome = "PC"
        ' Me.Close()

    End Sub

    Private Sub btnPESXPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPESXPC.Click

        frmBRANCAS.Show()
        tipodapartida = "PESXPC"
        siglatipo = "sa"
        'nome = "PC"
        ' Me.Close()

    End Sub

    Private Sub btnLICHESS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLICHESS.Click
        frmLICHESS.Show()
        'tipodapartida = "PES"
        'nome = "PESSOAL"
        'siglatipo = "a"
        'frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class