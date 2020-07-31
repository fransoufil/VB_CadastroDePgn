Public Class frmFINALCORTADO

    Private Sub btnVITORIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVITORIA.Click
        frmPECASCORTADO.Show()
        finaldapartida = "VITÓRIA"
        siglafinal = "v"
        Me.Close()
    End Sub

    Private Sub btnEMPATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEMPATE.Click
        frmPECASCORTADO.Show()
        finaldapartida = "EMPATE"
        siglafinal = "e"
        Me.Close()
    End Sub

    Private Sub btnDERROTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDERROTA.Click
        frmPECASCORTADO.Show()
        finaldapartida = "DERROTA"
        siglafinal = "d"
        Me.Close()
    End Sub
End Class