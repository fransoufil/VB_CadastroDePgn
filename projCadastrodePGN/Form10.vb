Public Class frmPRETAS

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "ALEKHINE"
                mestrepretas = "ale"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "ALEKHINE"
                mestrepretas = "ale"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)
                'frmCADASTRAR.picboxTIPO.Visible = False
                'frmCADASTRAR.picboxALEKHINE.Visible = True

        End Select

        Me.Close()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "ANAND"
                mestrepretas = "ana"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "ANAND"
                mestrepretas = "ana"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)
                
        End Select

        Me.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error Resume Next

        Dim novo As String

        novo = InputBox("INSIRA UM NOME VÁLIDO!", "NOVO MESTRE", "PC", vbOKOnly)

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = novo.ToUpper
                mestrepretas = novo.Substring(0, 3).ToLower

            Case "PESXPC"
                nomepretas = novo.ToUpper
                mestrepretas = novo.Substring(0, 3).ToLower

        End Select

        frmCADASTRAR.Show()

        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "BIRD"
                mestrepretas = "bir"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "BIRD"
                mestrepretas = "bir"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "BOTVINNIK"
                mestrepretas = "bot"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "BOTVINNIK"
                mestrepretas = "bit"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "CHIGORIN"
                mestrepretas = "chi"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "CHIGORIN"
                mestrepretas = "chi"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "EUWE"
                mestrepretas = "euw"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "EUWE"
                mestrepretas = "euw"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "EVANS"
                mestrepretas = "eva"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "EVANS"
                mestrepretas = "eva"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "FINE"
                mestrepretas = "fin"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "FINE"
                mestrepretas = "fin"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "FISCHER"
                mestrepretas = "fis"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "FISCHER"
                mestrepretas = "fis"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "GELLER"
                mestrepretas = "gel"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "GELLER"
                mestrepretas = "gel"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "KORCHNOI"
                mestrepretas = "kor"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "KORCHNOI"
                mestrepretas = "kor"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "KRAMNIK"
                mestrepretas = "kra"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "KRAMNIK"
                mestrepretas = "kra"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "NAJDORF"
                mestrepretas = "naj"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "NAJDORF"
                mestrepretas = "naj"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "POLGAR"
                mestrepretas = "pol"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "POLGAR"
                mestrepretas = "pol"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "RETI"
                mestrepretas = "ret"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "RETI"
                mestrepretas = "ret"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "SPASSKY"
                mestrepretas = "spa"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "SPASSKY"
                mestrepretas = "spa"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(27)

        End Select

        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "TIMMAN"
                mestrepretas = "tim"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "TIMMAN"
                mestrepretas = "tim"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "TABLET"
                mestrepretas = "tab"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "TABLET"
                mestrepretas = "tab"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "STOCKFISH"
                mestrepretas = "sto"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "STOCKFISH"
                mestrepretas = "sto"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        frmCADASTRAR.Show()

        Select Case tipodapartida

            Case "PCXPC"
                nomepretas = "CHESSMASTER"
                mestrepretas = "cm"
                frmCADASTRAR.lblTIPO.Text = "PC x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(26)
            Case "PESXPC"
                nomepretas = "CHESSMASTER"
                mestrepretas = "cm"
                frmCADASTRAR.lblTIPO.Text = "PES x PC"
                frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        End Select

        Me.Close()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click

        frmCADASTRAR.Show()
        tipodapartida = "PESXPC"
        nomepretas = "PESSOAL"
        siglatipo = "sa"
        frmCADASTRAR.picIMAGEM.Image = frmCADASTRAR.listIMAGEM.Images(25)

        Me.Close()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Me.Close()
    End Sub
End Class