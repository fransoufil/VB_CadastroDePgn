Imports System.IO
Imports System.IO.FileAccess
Imports System.Text
Imports System.Linq


Public Class frmINICIO

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCADASTRAR.Click
        frmFINAL.Show()
    End Sub

    Private Sub btnCONSULTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCONSULTAR.Click
        frmCONSULTA.Show()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
