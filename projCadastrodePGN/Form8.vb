Public Class frmMESTRE2

    Private Sub frmMESTRE2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tipodapartida = ""
        nome = ""
        cordaspecas = ""
        mestre = ""

    End Sub

    
    Private Sub chkPRETAS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPRETAS.CheckedChanged
        chkBRANCAS.Checked = False
    End Sub

    Private Sub chkBRANCAS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBRANCAS.CheckedChanged
        chkPRETAS.Checked = False
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Me.Close()

    End Sub

    Private Sub chkBRANCAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBRANCAS.Click
        chkBRANCAS.Checked = True
        chkPRETAS.Checked = False
        cordaspecas = "BRANCAS"
    End Sub

    Private Sub chkPRETAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPRETAS.Click
        chkBRANCAS.Checked = False
        chkPRETAS.Checked = True
        cordaspecas = "PRETAS"
    End Sub

    Private Sub chkPESSOAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPESSOAL.Click

        chkPESSOAL.Checked = True
        chkPESPC.Checked = False
        chkPC.Checked = False
        tipodapartida = "PESSOAL"
        nome = "PESSOAL"

    End Sub

    Private Sub chkPESPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPESPC.Click
        chkPESPC.Checked = True
        chkPESSOAL.Checked = False
        chkPC.Checked = False
        tipodapartida = "PES/PC"
    End Sub

    Private Sub chkPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPC.Click
        chkPC.Checked = True
        chkPESPC.Checked = False
        chkPESSOAL.Checked = False
        tipodapartida = "PC"
    End Sub

    Private Sub chkALEKHINE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkALEKHINE.Click
        chkALEKHINE.Checked = True
        chkBIRD.Checked = False
        chkBOTVINNIK.Checked = False
        chkFINE.Checked = False
        chkFISCHER.Checked = False
        chkNAJDORF.Checked = False
        chkPOLGAR.Checked = False
        chkTIMMAN.Checked = False
        chkTABLET.Checked = False
        nome = "ALEKHINE"
        mestre = "ale"

        If tipodapartida = "PES/PC" Then

            nome = "PES/" + nome

        End If

    End Sub

    Private Sub chkBIRD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBIRD.Click
        chkALEKHINE.Checked = False
        chkBIRD.Checked = True
        chkBOTVINNIK.Checked = False
        chkFINE.Checked = False
        chkFISCHER.Checked = False
        chkNAJDORF.Checked = False
        chkPOLGAR.Checked = False
        chkTIMMAN.Checked = False
        chkTABLET.Checked = False
        nome = "BIRD"
        mestre = "bir"

        If tipodapartida = "PES/PC" Then

            nome = "PES/" + nome

        End If
    End Sub

    Private Sub chkBOTVINNIK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBOTVINNIK.Click
        chkALEKHINE.Checked = False
        chkBIRD.Checked = False
        chkBOTVINNIK.Checked = True
        chkFINE.Checked = False
        chkFISCHER.Checked = False
        chkNAJDORF.Checked = False
        chkPOLGAR.Checked = False
        chkTIMMAN.Checked = False
        chkTABLET.Checked = False
        nome = "BOTVINNIK"
        mestre = "bot"

        If tipodapartida = "PES/PC" Then

            nome = "PES/" + nome

        End If
    End Sub

    Private Sub chkFISCHER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFISCHER.Click
        chkALEKHINE.Checked = False
        chkBIRD.Checked = False
        chkBOTVINNIK.Checked = False
        chkFINE.Checked = False
        chkFISCHER.Checked = True
        chkNAJDORF.Checked = False
        chkPOLGAR.Checked = False
        chkTIMMAN.Checked = False
        chkTABLET.Checked = False
        nome = "FISCHER"
        mestre = "fis"

        If tipodapartida = "PES/PC" Then

            nome = "PES/" + nome

        End If
    End Sub

    Private Sub chkPOLGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPOLGAR.Click
        chkALEKHINE.Checked = False
        chkBIRD.Checked = False
        chkBOTVINNIK.Checked = False
        chkFINE.Checked = False
        chkFISCHER.Checked = False
        chkNAJDORF.Checked = False
        chkPOLGAR.Checked = True
        chkTIMMAN.Checked = False
        chkTABLET.Checked = False
        nome = "POLGAR"
        mestre = "pol"

        If tipodapartida = "PES/PC" Then

            nome = "PES/" + nome

        End If
    End Sub

    Private Sub chkTIMMAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTIMMAN.Click
        chkALEKHINE.Checked = False
        chkBIRD.Checked = False
        chkBOTVINNIK.Checked = False
        chkFINE.Checked = False
        chkFISCHER.Checked = False
        chkNAJDORF.Checked = False
        chkPOLGAR.Checked = False
        chkTIMMAN.Checked = True
        chkTABLET.Checked = False
        nome = "TIMMAN"
        mestre = "tim"

        If tipodapartida = "PES/PC" Then

            nome = "PES/" + nome

        End If
    End Sub

    Private Sub chkFINE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFINE.Click
        chkALEKHINE.Checked = False
        chkBIRD.Checked = False
        chkBOTVINNIK.Checked = False
        chkFINE.Checked = True
        chkFISCHER.Checked = False
        chkNAJDORF.Checked = False
        chkPOLGAR.Checked = False
        chkTIMMAN.Checked = False
        chkTABLET.Checked = False
        nome = "FINE"
        mestre = "fin"

        If tipodapartida = "PES/PC" Then

            nome = "PES/" + nome

        End If
    End Sub

    Private Sub chkNAJDORF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNAJDORF.Click

        chkALEKHINE.Checked = False
        chkBIRD.Checked = False
        chkBOTVINNIK.Checked = False
        chkFINE.Checked = False
        chkFISCHER.Checked = False
        chkNAJDORF.Checked = True
        chkPOLGAR.Checked = False
        chkTIMMAN.Checked = False
        chkTABLET.Checked = False
        nome = "NAJDORF"
        mestre = "naj"

        If tipodapartida = "PES/PC" Then

            nome = "PES/" + nome

        End If
    End Sub

    Private Sub chkTABLET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTABLET.Click

        chkALEKHINE.Checked = False
        chkBIRD.Checked = False
        chkBOTVINNIK.Checked = False
        chkFINE.Checked = False
        chkFISCHER.Checked = False
        chkNAJDORF.Checked = False
        chkPOLGAR.Checked = False
        chkTIMMAN.Checked = False
        chkTABLET.Checked = True
        nome = "TABLET"
        mestre = "tab"

        If tipodapartida = "PES/PC" Then

            nome = "PES/" + nome

        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        On Error Resume Next

        If cordaspecas = "BRANCAS" Then


            Dim SearchString As String = frmCONSULTA.txtPGN.Text

            'INDENTIFICAÇÃO DAS BRANCAS

            Dim posicaoWhite As Integer
            Dim posicaobarradoWhite As Integer
            Dim posicaobarra2doWhite As Integer


            posicaoWhite = SearchString.IndexOf("[White")
            posicaobarradoWhite = SearchString.IndexOf("""", posicaoWhite)
            posicaobarra2doWhite = SearchString.IndexOf("]", posicaobarradoWhite)



            ' txtWhiteado.Text = posicaoWhite.ToString + "/" + posicaobarradoWhite.ToString + "/" + posicaobarra2doWhite.ToString

            'CODIGO PARA CORTAR White

            Dim PosWhite As Integer
            Dim PosWhite2 As Integer
            Dim iniciodoWhite As String
            Dim tamanhodoWhite As Integer

            'PosWhite = "valor de inicio da string White
            'PosWhite2 = "valor da posicao final

            PosWhite = posicaobarradoWhite + 2
            PosWhite2 = posicaobarra2doWhite

            tamanhodoWhite = PosWhite2 - PosWhite



            iniciodoWhite = SearchString.Substring(PosWhite - 1, tamanhodoWhite)


            frmCONSULTA.txtBRANCAS.Text = iniciodoWhite

            iniciodoWhite = "[White " + """" + iniciodoWhite

            'AQUI SUBSTITUI PELA VARIANTE PUBLICA NOME

            nome = "[White " + """" + nome

            SearchString = SearchString.Replace(iniciodoWhite, nome)

            frmCONSULTA.txtPGN.Text = SearchString

            'INDENTIFICAÇÃO DAS BRANCAS

            Dim posicaoWhite2 As Integer
            Dim posicaobarradoWhite2 As Integer
            Dim posicaobarra2doWhite2 As Integer


            posicaoWhite2 = SearchString.IndexOf("[White")
            posicaobarradoWhite2 = SearchString.IndexOf("""", posicaoWhite2)
            posicaobarra2doWhite2 = SearchString.IndexOf("]", posicaobarradoWhite2)



            ' txtWhiteado.Text = posicaoWhite.ToString + "/" + posicaobarradoWhite.ToString + "/" + posicaobarra2doWhite.ToString

            'CODIGO PARA CORTAR White

            Dim PosWhite3 As Integer
            Dim PosWhite4 As Integer
            Dim iniciodoWhite2 As String
            Dim tamanhodoWhite2 As Integer

            'PosWhite = "valor de inicio da string White
            'PosWhite2 = "valor da posicao final

            PosWhite3 = posicaobarradoWhite2 + 2
            PosWhite4 = posicaobarra2doWhite2

            If PosWhite3 > PosWhite4 Then
                Exit Sub
            Else

                tamanhodoWhite2 = PosWhite4 - PosWhite3



                iniciodoWhite2 = SearchString.Substring(PosWhite3 - 1, tamanhodoWhite2)

                frmCONSULTA.txtBRANCAS.Text = iniciodoWhite2

            End If

        End If


        If cordaspecas = "PRETAS" Then


            Dim SearchString As String = frmCONSULTA.txtPGN.Text

            'INDENTIFICAÇÃO DAS PRETAS

            Dim posicaoBlack As Integer
            Dim posicaobarradoBlack As Integer
            Dim posicaobarra2doBlack As Integer


            posicaoBlack = SearchString.IndexOf("[Black")
            posicaobarradoBlack = SearchString.IndexOf("""", posicaoBlack)
            posicaobarra2doBlack = SearchString.IndexOf("]", posicaobarradoBlack)



            ' txtBlackado.Text = posicaoBlack.ToString + "/" + posicaobarradoBlack.ToString + "/" + posicaobarra2doBlack.ToString

            'CODIGO PARA CORTAR Black

            Dim PosBlack As Integer
            Dim PosBlack2 As Integer
            Dim iniciodoBlack As String
            Dim tamanhodoBlack As Integer

            'PosBlack = "valor de inicio da string Black
            'PosBlack2 = "valor da posicao final

            PosBlack = posicaobarradoBlack + 2
            PosBlack2 = posicaobarra2doBlack

            tamanhodoBlack = PosBlack2 - PosBlack



            iniciodoBlack = SearchString.Substring(PosBlack - 1, tamanhodoBlack)


            frmCONSULTA.txtPRETAS.Text = iniciodoBlack

            iniciodoBlack = "[Black " + """" + iniciodoBlack

            'AQUI SUBSTITUI PELA VARIANTE PUBLICA NOME

            nome = "[Black " + """" + nome

            SearchString = SearchString.Replace(iniciodoBlack, nome)

            frmCONSULTA.txtPGN.Text = SearchString

            'INDENTIFICAÇÃO DAS PRETAS

            Dim posicaoBlack2 As Integer
            Dim posicaobarradoBlack2 As Integer
            Dim posicaobarra2doBlack2 As Integer


            posicaoBlack2 = SearchString.IndexOf("[Black")
            posicaobarradoBlack2 = SearchString.IndexOf("""", posicaoBlack2)
            posicaobarra2doBlack2 = SearchString.IndexOf("]", posicaobarradoBlack2)



            ' txtBlackado.Text = posicaoBlack.ToString + "/" + posicaobarradoBlack.ToString + "/" + posicaobarra2doBlack.ToString

            'CODIGO PARA CORTAR Black

            Dim PosBlack3 As Integer
            Dim PosBlack4 As Integer
            Dim iniciodoBlack2 As String
            Dim tamanhodoBlack2 As Integer

            'PosBlack = "valor de inicio da string Black
            'PosBlack2 = "valor da posicao final

            PosBlack3 = posicaobarradoBlack2 + 2
            PosBlack4 = posicaobarra2doBlack2

            If PosBlack3 > PosBlack4 Then
                Exit Sub
            Else

                tamanhodoBlack2 = PosBlack4 - PosBlack3



                iniciodoBlack2 = SearchString.Substring(PosBlack3 - 1, tamanhodoBlack2)

                frmCONSULTA.txtPRETAS.Text = iniciodoBlack2

            End If

        End If

        'btnAPLICARNOME.Enabled = False

        Me.Close()


    End Sub

    Private Sub chkPESSOAL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPESSOAL.CheckedChanged

        If chkPESSOAL.Checked = True Then

            chkALEKHINE.Enabled = False
            chkBIRD.Enabled = False
            chkBOTVINNIK.Enabled = False
            chkFISCHER.Enabled = False
            chkFINE.Enabled = False
            chkPOLGAR.Enabled = False
            chkNAJDORF.Enabled = False
            chkTIMMAN.Enabled = False
            chkTABLET.Enabled = False

            chkALEKHINE.Checked = False
            chkBIRD.Checked = False
            chkBOTVINNIK.Checked = False
            chkFISCHER.Checked = False
            chkFINE.Checked = False
            chkPOLGAR.Checked = False
            chkNAJDORF.Checked = False
            chkTIMMAN.Checked = False
            chkTABLET.Checked = False

        Else

            chkALEKHINE.Enabled = True
            chkBIRD.Enabled = True
            chkBOTVINNIK.Enabled = True
            chkFISCHER.Enabled = True
            chkFINE.Enabled = True
            chkPOLGAR.Enabled = True
            chkNAJDORF.Enabled = True
            chkTIMMAN.Enabled = True
            chkTABLET.Enabled = True


        End If

    End Sub

   
End Class