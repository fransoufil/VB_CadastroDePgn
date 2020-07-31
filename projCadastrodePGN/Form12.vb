Public Class frmPECASCORTADO

    Private Sub btnBRANCAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBRANCAS.Click
        frmTIPOCORTADO.Show()
        cordaspecas = "BRANCAS"
        siglacor = "b"
        Me.Close()
    End Sub

    Private Sub btnPRETAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRETAS.Click
        frmTIPOCORTADO.Show()
        cordaspecas = "PRETAS"
        siglacor = ""
        Me.Close()
    End Sub
End Class