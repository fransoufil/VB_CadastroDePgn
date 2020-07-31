Public Class frmFINAL

    Private Sub btnVITORIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVITORIA.Click
        frmPECAS.Show()
        finaldapartida = "VITÓRIA"
        siglafinal = "v"
        'Me.Close()
    End Sub

    Private Sub btnEMPATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEMPATE.Click
        frmPECAS.Show()
        finaldapartida = "EMPATE"
        siglafinal = "e"
        'Me.Close()
    End Sub

    Private Sub btnDERROTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDERROTA.Click
        frmPECAS.Show()
        finaldapartida = "DERROTA"
        siglafinal = "d"
        'Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class