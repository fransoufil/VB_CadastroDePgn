Public Class formBACKUP

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Clipboard.SetDataObject(txtPGN.Text, True)
        Process.Start("https://lichess.org/paste")
    End Sub

    Private Sub btnCOPIAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCOPIAR.Click
        If txtPGN.Text = "" Then

            MessageBox.Show("NENHUM PGN NA CAIXA!", "Copiar PGN", MessageBoxButtons.OK)
            txtPGN.Focus()

        Else
            Clipboard.SetDataObject(txtPGN.Text, True)
        End If
    End Sub

    Private Sub btnCOLAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCOLAR.Click
        Dim Texto As String
        Texto = Clipboard.GetText
        txtPGN.Text = Texto
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmFINALCORTADO.Show()
    End Sub
End Class