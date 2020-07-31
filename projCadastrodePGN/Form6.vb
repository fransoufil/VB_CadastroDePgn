Public Class frmMESTRE

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label1.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/ALEKHINE"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = "ALEKHINE"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(1)
                
        End Select

        'Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label2.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(2)

        End Select

        'Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label3.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(3)

        End Select

        'Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label4.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(5)

        End Select

        'Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label5.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(6)

        End Select

        'Me.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label6.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(4)

        End Select

        'Me.Close()
        
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/TABLET"
                frmCADASTRAR.lblTIPO.Text = "PES/TABLET"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
                mestre = "at"
            Case "PC"
                nome = "TABLET"
                mestre = "tab"
                frmCADASTRAR.lblTIPO.Text = "TABLET"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(7)
                

        End Select

        'Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label8.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.lblTIPO.Location = New Point(878, 654)
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(8)

        End Select

       

        
        'Me.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label9.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(9)

        End Select

        'Me.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/PC"
                frmCADASTRAR.lblTIPO.Text = "PES/PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
                mestre = "ac"
            Case "PC"
                nome = "PC"
                mestre = ""
                frmCADASTRAR.lblTIPO.Text = "PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
               

        End Select

        ' Me.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/STOCKFISH"
                frmCADASTRAR.lblTIPO.Text = "PES/STOCKFISH"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
                mestre = "ast"
            Case "PC"
                nome = "STOCKFISH"
                mestre = "sto"
                frmCADASTRAR.lblTIPO.Text = "STOCKFISH"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(11)
                

        End Select

        'Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "ANA/STOCKFISH8"
                frmCADASTRAR.lblTIPO.Text = "ANA/STOCKFISH8"
                mestre = "ana"
            Case "PC"
                nome = "STOCKFISH8"
                mestre = "sf8"
                frmCADASTRAR.lblTIPO.Text = "STOCKFISH8"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(11)
                'frmCADASTRAR.picboxTIPO.Visible = False
                'frmCADASTRAR.picboxTABLET.Visible = True

        End Select

        'Me.Close()
    End Sub

    Private Sub frmMESTRE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click

        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label9.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(12)

        End Select

        'Me.Close()

       
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label14.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(13)

        End Select

        'Me.Close()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label18.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(22)

        End Select

        'Me.Close()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label3.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Location = New Point(878, 654)
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(15)

        End Select

        'Me.Close()

    End Sub


    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label16.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(16)

        End Select

        'Me.Close()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label15.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(27)

        End Select

        'Me.Close()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label3.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.lblTIPO.Location = New Point(878, 654)
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(18)

        End Select

        'Me.Close()

       
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label11.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(19)

        End Select

        'Me.Close()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/CHESSMASTER"
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/CHESSMASTER"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = "CHESSMASTER"
                mestre = "cm"
                frmCADASTRAR.lblTIPO.Text = "CHESSMASTER"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(20)
                

        End Select

        'Me.Close()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        frmCADASTRAR.Show()

        Dim nomedomestre As String = Label21.Text()

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(21)

        End Select

        ' Me.Close()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click


        Dim nomedomestre As String =  InputBox("INSIRA UM NOME VÁLIDO!", "NOVO MESTRE", "PC", vbOKOnly)

        Select Case tipodapartida

            Case "PES/PC"
                nome = "PES/" & nomedomestre.ToUpper
                mestre = "ac"
                frmCADASTRAR.lblTIPO.Text = "PES/" & nomedomestre.ToUpper
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)
            Case "PC"
                nome = nomedomestre.ToUpper
                mestre = nomedomestre.Substring(0, 3).ToLower
                frmCADASTRAR.lblTIPO.Text = nomedomestre.ToUpper
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(10)

        End Select

        frmCADASTRAR.Show()

        'Me.Close()

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Me.Close()
    End Sub
End Class