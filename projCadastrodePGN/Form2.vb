Public Class frmPECAS

    Private Sub btnBRANCAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBRANCAS.Click
        frmTIPO.Show()
        cordaspecas = "BRANCAS"
        siglacor = "b"
        'Me.Close()
    End Sub

    Private Sub btnPRETAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRETAS.Click
        frmTIPO.Show()
        cordaspecas = "PRETAS"
        siglacor = ""
        'Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class