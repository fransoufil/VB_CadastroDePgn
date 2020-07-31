Public Class frmTIPOCORTADO

    Private Sub btnPESSOAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPESSOAL.Click

        formSALVAR.Show()
        tipodapartida = "PES"
        nome = "PESSOAL"
        siglatipo = "a"

        Me.Close()
    End Sub

    Private Sub btnPESPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPESPC.Click
        frmMESTRECORTADO.Show()
        tipodapartida = "PES/PC"
        siglatipo = "ac"
        'nome = "PES/PC"
        Me.Close()
    End Sub

    Private Sub btnPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPC.Click
        frmMESTRECORTADO.Show()
        tipodapartida = "PC"
        siglatipo = "c"
        'nome = "PC"
        Me.Close()
    End Sub

    Private Sub btnPCXPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPCXPC.Click
        frmBRANCASCORTADO.Show()
        tipodapartida = "PCXPC"
        siglatipo = "sc"
        'nome = "PC"
        Me.Close()
    End Sub

    Private Sub btnPESXPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPESXPC.Click
        frmBRANCASCORTADO.Show()
        tipodapartida = "PESXPC"
        siglatipo = "sa"
        'nome = "PC"
        Me.Close()
    End Sub
End Class