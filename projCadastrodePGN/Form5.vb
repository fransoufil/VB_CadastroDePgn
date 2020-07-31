Public Class frmCADASTRAR

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btnSALVARCOMO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALVARCOMO.Click

        On Error Resume Next

        Dim SearchString As String = txtPGN.Text
        Dim salvarComo As SaveFileDialog = New SaveFileDialog()
        Dim caminho As DialogResult
        Dim fluxoTexto As IO.StreamWriter
        Dim Arquivo As String = ""
        Dim nomearquivo As String

        If SearchString = "" Then
            MsgBox("NENHUM CARACTER NA CAIXA!", MessageBoxButtons.OK, "AVISO!")
            Exit Sub
        Else

            Dim SearchChar As String = "1."
            Dim SearchChar2 As String = " 7."
            Dim TestPos5 As Integer
            Dim TestPos6 As Integer
            '

            TestPos5 = InStr(1, SearchString, SearchChar, CompareMethod.Text)
            TestPos6 = InStr(1, SearchString, SearchChar2, CompareMethod.Text)

            txtTAMANHODOPGN.Text = Len(SearchString)

            Dim iniciodopgn As String
            Dim tamanhodopgn As Integer

            If TestPos5 > TestPos6 Then
                Exit Sub
            Else

                tamanhodopgn = TestPos6 - TestPos5

                iniciodopgn = SearchString.Substring(TestPos5 - 1, tamanhodopgn)

                txtNOMEDOPGN.Text = iniciodopgn

            End If


            If txtNOMEDOPGN.Text <> "" Or txtNOMEDOPGN.Text <> "SEQUENCIA ATÉ O 6º MOVIMENTO" Then


                Select Case tipodapartida

                    Case "PES"

                        Select Case finaldapartida

                            Case "VITÓRIA"

                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                txtPGN.Text = SearchString

                            Case "EMPATE"

                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                txtPGN.Text = SearchString

                            Case "DERROTA"

                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                txtPGN.Text = SearchString

                        End Select

                        nomearquivo = siglatipo + siglacor + siglafinal + " " + txtNOMEDOPGN.Text
                        salvarComo.Filter = ".pgn|*.pgn"
                        salvarComo.FileName = nomearquivo
                        caminho = salvarComo.ShowDialog
                        Arquivo = salvarComo.FileName

                    Case "PES/PC"

                        Select Case finaldapartida

                            Case "VITÓRIA"

                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                txtPGN.Text = SearchString

                            Case "EMPATE"

                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                txtPGN.Text = SearchString

                            Case "DERROTA"

                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                txtPGN.Text = SearchString

                        End Select

                        nomearquivo = siglatipo + siglacor + " " + txtNOMEDOPGN.Text
                        salvarComo.Filter = ".pgn|*.pgn"
                        salvarComo.FileName = mestre + " " + nomearquivo
                        caminho = salvarComo.ShowDialog
                        Arquivo = salvarComo.FileName

                    Case "PC"

                        Select Case finaldapartida

                            Case "VITÓRIA"

                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                txtPGN.Text = SearchString

                            Case "EMPATE"

                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                txtPGN.Text = SearchString

                            Case "DERROTA"

                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                txtPGN.Text = SearchString

                        End Select

                        nomearquivo = siglatipo + siglacor + " " + txtNOMEDOPGN.Text
                        salvarComo.Filter = ".pgn|*.pgn"
                        salvarComo.FileName = mestre + " " + nomearquivo
                        caminho = salvarComo.ShowDialog
                        Arquivo = salvarComo.FileName



                End Select

            Else

                'nomearquivo = txtNOMEDOPGN.Text
                salvarComo.Filter = ".pgn|*.pgn"
                salvarComo.FileName = mestre + " "
                caminho = salvarComo.ShowDialog
                Arquivo = salvarComo.FileName

            End If

        End If

        If Arquivo = Nothing Then
            MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
        Else

            salvarComo.FileName = txtNOMEDOPGN.Text
            fluxoTexto = New IO.StreamWriter(Arquivo)
            fluxoTexto.Write(txtPGN.Text)
            fluxoTexto.Close()
        End If



    End Sub

    Private Sub btnSALVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALVO.Click


        Dim SearchString As String = txtPGN.Text
        Dim salvarComo As SaveFileDialog = New SaveFileDialog()
        Dim caminho As DialogResult
        Dim fluxoTexto As IO.StreamWriter
        Dim Arquivo As String = ""
        Dim nomearquivo As String
        Dim nomedaabertura As String

        Dim CONTROLE As Boolean = 0

        Dim vardata As String = txtDATA.Text
        Dim dt As DateTime = Convert.ToDateTime(vardata)
        Dim vardia, varmes, varano As String
        Dim datacompleta As String

        vardia = dt.Day.ToString()

        varmes = dt.Month.ToString()

        varano = dt.Year.ToString()

        datacompleta = vardia + "/" + varmes + "/" + varano

        'MsgBox(datacompleta)


        On Error Resume Next

        If SearchString = "" Then

            MsgBox("NENHUM CARACTER NA CAIXA!", MessageBoxButtons.OK, "AVISO!")

            Exit Sub

        Else

            Dim iniciodoclock As String = " { [%clk"
            Dim finaldoclock As String = "] } "
            Dim TestPos As Integer
            Dim TestPos2 As Integer
            Dim diferenca As Integer


            TestPos = InStr(1, SearchString, iniciodoclock, CompareMethod.Text)
            TestPos2 = InStr(1, SearchString, finaldoclock, CompareMethod.Text)

            diferenca = TestPos2 - TestPos

            Do While diferenca > 0

                TestPos = InStr(1, SearchString, iniciodoclock, CompareMethod.Text)
                TestPos2 = InStr(1, SearchString, finaldoclock, CompareMethod.Text)
                txtPGN.Text = SearchString

                txtTAMANHODOPGN.Text = Len(SearchString)

                Dim marcadoclock As String
                Dim tamanhodoclock As Integer

                tamanhodoclock = TestPos2 - TestPos + 4

                marcadoclock = SearchString.Substring(TestPos - 1, tamanhodoclock)

                SearchString = SearchString.Replace(marcadoclock, " ")

                diferenca = TestPos2 - TestPos

                txtPGN.Text = SearchString

            Loop

            Dim SearchString2 As String = txtPGN.Text
            Dim chaveinicioabertura As String = " { "
            Dim chavefinalabertura As String = " } "
            Dim TestPos3 As Integer
            Dim TestPos4 As Integer


            TestPos3 = InStr(1, SearchString2, chaveinicioabertura, CompareMethod.Text)
            TestPos4 = InStr(1, SearchString2, chavefinalabertura, CompareMethod.Text)

            txtTAMANHODOPGN.Text = Len(SearchString2)

            Dim abertura As String
            Dim tamanhodaabertura As Integer

            tamanhodaabertura = TestPos4 - TestPos3 + 3

            abertura = SearchString2.Substring(TestPos3 - 1, tamanhodaabertura)

            txtABERTURA.Text = abertura


            SearchString2 = SearchString2.Replace(abertura, " ")

            txtPGN.Text = SearchString2

            Dim SearchString3 As String = txtPGN.Text
            Dim SearchChar As String = "1."
            Dim SearchChar2 As String = " 7."
            Dim TestPos5 As Integer
            Dim TestPos6 As Integer

            TestPos5 = InStr(1, SearchString3, SearchChar, CompareMethod.Text)
            TestPos6 = InStr(1, SearchString3, SearchChar2, CompareMethod.Text)

            txtTAMANHODOPGN.Text = Len(SearchString3)

            Dim iniciodopgn As String
            Dim tamanhodopgn As Integer

            If TestPos5 > TestPos6 Then

                MsgBox("PARTIDA COM MENOS DE 7 MOVIMENTOS!", MessageBoxButtons.OK, "AVISO!")

                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                Dim primeirosmovimentos As String
                Dim tamanhototal As Integer
                Dim stringdeempate As String = "1/2-1/2"
                Dim resultado As String
                Dim stringsemresultado As String


                tamanhototal = Len(txtPGN.Text)

                stringsemresultado = SearchString2.Substring(tamanhototal - 7, 7)

                If stringsemresultado = stringdeempate Then

                    tamanhototal = tamanhototal - TestPos5

                    primeirosmovimentos = SearchString2.Substring(TestPos5 - 1, tamanhototal - 7)

                    nomearquivo = siglatipo + siglacor + siglafinal + " " + primeirosmovimentos
                    salvarComo.Filter = ".pgn|*.pgn"
                    salvarComo.FileName = nomearquivo
                    'salvarComo.InitialDirectory = destino
                    caminho = salvarComo.ShowDialog
                    Arquivo = salvarComo.FileName
                    CONTROLE = 1

                    fluxoTexto = New IO.StreamWriter(Arquivo)
                    fluxoTexto.Write(txtPGN.Text)
                    fluxoTexto.Close()

                Else



                    tamanhototal = tamanhototal - TestPos5

                    primeirosmovimentos = SearchString2.Substring(TestPos5 - 1, tamanhototal - 3)

                    nomearquivo = siglatipo + siglacor + siglafinal + " " + primeirosmovimentos
                    salvarComo.Filter = ".pgn|*.pgn"
                    salvarComo.FileName = nomearquivo
                    'salvarComo.InitialDirectory = destino
                    caminho = salvarComo.ShowDialog
                    Arquivo = salvarComo.FileName
                    CONTROLE = 1

                    fluxoTexto = New IO.StreamWriter(Arquivo)
                    fluxoTexto.Write(txtPGN.Text)
                    fluxoTexto.Close()
                End If

                Exit Sub

                'Else

                'tamanhodopgn = TestPos6 - TestPos5

                'iniciodopgn = SearchString3.Substring(TestPos5 - 1, tamanhodopgn)

                'txtNOMEDOPGN.Text = iniciodopgn

            End If

                If txtNOMEDOPGN.Text <> "" Or txtNOMEDOPGN.Text <> "SEQUENCIA ATÉ O 6º MOVIMENTO" Then

                    Clipboard.SetDataObject(txtNOMEDOPGN.Text, False)

                Else

                    MsgBox("NENHUM CARACTER NA CAIXA!", MessageBoxButtons.OK, "AVISO!")

                End If

                salvarComo.CheckFileExists = False
                salvarComo.Title = "SALVAR PARTIDA"

                Select Case cordaspecas

                    'AQUI COMEÇAM OS CASOS DE BRANCAS***********************************************************************************

                    Case Is = "BRANCAS"

                        Select Case txtSIGLADAABERTURA.Text

                            Case Is = "1. d4 "

                                nomedaabertura = "pd"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1


                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'CASO DE BRANCAS ESPECIAL 1. e4 *******************************************************************************************************


                            Case Is = "1. e4 "

                                'INÍCIO DA SUBROTINA PARA ABERTURAS e4
                                'PRIMEIRO DEVE APANHAR A SEQUENCIA SEM SIGLA NUMA VARIÁVEL

                                Dim nomedopgn As String = txtNOMEDOPGN.Text

                                'AGORA PEGA OS DOIS PRIMEIRO CARACTERES

                                nomedopgn = nomedopgn.Substring(0, 3)

                                'AGORA A PARTIR DO CAPTURADO SELECT CASE

                                Select Case nomedopgn

                                    Case Is = " b6"

                                        nomedaabertura = "fbd"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4


                                    Case Is = "b6 "

                                        nomedaabertura = "fbd"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1
                                        End Select

                                        'NOVO CASO PARA ABERTURA e4
                                    Case Is = "b5 "

                                        nomedaabertura = "pcd"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = "c6 "

                                        nomedaabertura = "ck"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = "c5 "

                                        nomedaabertura = "sic"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = " c5"

                                        nomedaabertura = "sic"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = "d6 "

                                        nomedaabertura = "pi"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = "d5 "

                                        nomedaabertura = "cjc"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = "e6 "

                                        nomedaabertura = "fra"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(9, Len(txtNOMEDOPGN.Text) - 9)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(9, Len(txtNOMEDOPGN.Text) - 9)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(9, Len(txtNOMEDOPGN.Text) - 9)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = " e6"

                                        nomedaabertura = "fra"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(9, Len(txtNOMEDOPGN.Text) - 9)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(9, Len(txtNOMEDOPGN.Text) - 9)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(9, Len(txtNOMEDOPGN.Text) - 9)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'CASO ESPECIAL PARA ABERTURA e4 RESPOSTA e5*************************************************************************************

                                    Case Is = "e5 "


                                        Dim aberturacompleta As String = txtSIGLADAABERTURA.Text + txtNOMEDOPGN.Text
                                        Dim doisprimeirosmovimentos As String

                                        doisprimeirosmovimentos = aberturacompleta.Substring(0, 20)


                                        nomedaabertura = "kpg"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = "g6 "

                                        nomedaabertura = "fbr"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = "g5 "

                                        nomedaabertura = "pcr"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = "Nc6"

                                        nomedaabertura = "nim"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                    Case Is = "Nf6"

                                        nomedaabertura = "ale"

                                        Select Case tipodapartida

                                            Case "PES"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PES/PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                aberturasemsequencia = aberturasemsequencia.Substring(10, Len(txtNOMEDOPGN.Text) - 10)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = mestre + " " + nomearquivo
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PCXPC"

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                            Case "PESXPC"

                                                Select Case finaldapartida

                                                    Case "VITÓRIA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                        txtPGN.Text = SearchString

                                                    Case "EMPATE"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                        txtPGN.Text = SearchString

                                                    Case "DERROTA"

                                                        SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                        txtPGN.Text = SearchString

                                                End Select

                                                Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                                Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                                'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                                'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                                aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                                nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                                salvarComo.Filter = ".pgn|*.pgn"
                                                salvarComo.FileName = nomearquivo
                                                'salvarComo.InitialDirectory = destino
                                                caminho = salvarComo.ShowDialog
                                                Arquivo = salvarComo.FileName
                                                CONTROLE = 1

                                        End Select

                                        'NOVO CASO PARA ABERTURA e4

                                End Select

                                'NOVO CASO DE BRANCAS

                            Case Is = "1. Nf3"

                                nomedaabertura = "cr"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE BRANCAS
                            Case Is = "1. c4 "

                                nomedaabertura = "ing"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE BRANCAS

                            Case Is = "1. f4 "

                                nomedaabertura = "bi"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select
                                'NOVO CASO DE BRANCAS


                        End Select

                        'CASO DE BRANCAS GENERICO

                        If CONTROLE = 0 Then


                            Select Case tipodapartida

                                Case "PES"

                                    Select Case finaldapartida

                                        Case "VITÓRIA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                            txtPGN.Text = SearchString

                                        Case "EMPATE"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                            txtPGN.Text = SearchString

                                        Case "DERROTA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                            txtPGN.Text = SearchString

                                    End Select

                                    nomearquivo = siglatipo + siglacor + siglafinal + " " + sequenciatemovimentoseis
                                    salvarComo.Filter = ".pgn|*.pgn"
                                    salvarComo.FileName = nomearquivo
                                    caminho = salvarComo.ShowDialog
                                    Arquivo = salvarComo.FileName
                                    CONTROLE = 1

                                Case "PES/PC"

                                    Select Case finaldapartida

                                        Case "VITÓRIA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                            txtPGN.Text = SearchString

                                        Case "EMPATE"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                            txtPGN.Text = SearchString

                                        Case "DERROTA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                            txtPGN.Text = SearchString

                                    End Select

                                    nomearquivo = siglatipo + siglacor + " " + sequenciatemovimentoseis
                                    salvarComo.Filter = ".pgn|*.pgn"
                                    salvarComo.FileName = nomearquivo
                                    caminho = salvarComo.ShowDialog
                                    Arquivo = salvarComo.FileName
                                    CONTROLE = 1

                                Case "PC"

                                    Select Case finaldapartida

                                        Case "VITÓRIA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                            txtPGN.Text = SearchString

                                        Case "EMPATE"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                            txtPGN.Text = SearchString

                                        Case "DERROTA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                            txtPGN.Text = SearchString

                                    End Select

                                    nomearquivo = siglatipo + siglacor + " " + sequenciatemovimentoseis
                                    salvarComo.Filter = ".pgn|*.pgn"
                                    salvarComo.FileName = mestre + " " + nomearquivo
                                    caminho = salvarComo.ShowDialog
                                    Arquivo = salvarComo.FileName
                                    CONTROLE = 1



                            End Select


                        End If



                        'AQUI COMEÇAM OS CASOS DE PRETAS*****************************************************************************************

                    Case Is = "PRETAS"

                        Select Case txtSIGLADAABERTURA.Text

                            Case Is = "1. e4 b6"

                                nomedaabertura = "fbd"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. e4 c6"

                                nomedaabertura = "ck"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. e4 c5"

                                nomedaabertura = "sic"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS
                            Case Is = "1. e4 d6"

                                nomedaabertura = "pi"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. e4 d5"

                                nomedaabertura = "cjc"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. e4 e6"

                                nomedaabertura = "fra"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. e4 e5"

                                nomedaabertura = "kpg"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. e4 g6"

                                nomedaabertura = "fbr"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. e4 Nc6"

                                nomedaabertura = "nim"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1
                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. e4 Nf6"

                                nomedaabertura = "ale"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. f4 d5"

                                nomedaabertura = "bi"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. b3 d5"

                                nomedaabertura = "fbd"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. b3 e5"

                                nomedaabertura = "fbd"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. b4 e5"

                                nomedaabertura = "pcd"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. c3 e5"

                                nomedaabertura = "sar"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. c3 d5"

                                nomedaabertura = "sar"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. c4 e5"

                                nomedaabertura = "ing"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. d3 d5"

                                nomedaabertura = "mie"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. d4 Nf6"

                                nomedaabertura = "ind"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. d4 d5"

                                nomedaabertura = "pd"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. d4 e6"

                                nomedaabertura = "horw"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. g3 d5"

                                nomedaabertura = "fbr"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. g3 e5"

                                nomedaabertura = "fbr"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. g4 d5"

                                nomedaabertura = "pcr"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. Nc3 d5"

                                nomedaabertura = "cd"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. Nf3 Nf6"

                                nomedaabertura = "cr"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                            Case Is = "1. e3 e5"

                                nomedaabertura = "vk"

                                Select Case tipodapartida

                                    Case "PES"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PES/PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = mestre + " " + nomearquivo
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PCXPC"

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura

                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo + " " + mestrebrancas + " x " + mestrepretas
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                    Case "PESXPC"

                                        Select Case finaldapartida

                                            Case "VITÓRIA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                                txtPGN.Text = SearchString

                                            Case "EMPATE"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                                txtPGN.Text = SearchString

                                            Case "DERROTA"

                                                SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                                txtPGN.Text = SearchString

                                        End Select

                                        Dim aberturasemsequencia As String = txtNOMEDOPGN.Text
                                        Dim inputabertura As String = "ABERTURA: " + nomedaabertura
                                        'Dim destino As String = "C:\Users\FRANZ\Documents\02_XADREZ" + "\" + vardia + varmes + varano + "\"
                                        'aberturasemsequencia = aberturasemsequencia.Substring(6, Len(txtNOMEDOPGN.Text) - 6)

                                        aberturasemsequencia = InputBox(inputabertura, "CONFIRA A SEQUENCIA!", aberturasemsequencia)

                                        nomearquivo = siglatipo + siglacor + siglafinal + " " + nomedaabertura + " " + aberturasemsequencia
                                        salvarComo.Filter = ".pgn|*.pgn"
                                        salvarComo.FileName = nomearquivo
                                        'salvarComo.InitialDirectory = destino
                                        caminho = salvarComo.ShowDialog
                                        Arquivo = salvarComo.FileName
                                        CONTROLE = 1

                                End Select

                                'NOVO CASO DE PRETAS

                        End Select

                        'CASO GENERICO DE PRETAS

                        If CONTROLE = 0 Then


                            Select Case tipodapartida

                                Case "PES"

                                    Select Case finaldapartida

                                        Case "VITÓRIA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                            txtPGN.Text = SearchString

                                        Case "EMPATE"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                            txtPGN.Text = SearchString

                                        Case "DERROTA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                            txtPGN.Text = SearchString

                                    End Select

                                    'nomearquivo = siglatipo + siglacor + siglafinal + " " + txtSIGLADAABERTURA.Text + " " + txtNOMEDOPGN.Text
                                    nomearquivo = siglatipo + siglacor + siglafinal + " " + sequenciatemovimentoseis
                                    salvarComo.Filter = ".pgn|*.pgn"
                                    salvarComo.FileName = nomearquivo
                                    caminho = salvarComo.ShowDialog
                                    Arquivo = salvarComo.FileName
                                    CONTROLE = 1

                                Case "PES/PC"

                                    Select Case finaldapartida

                                        Case "VITÓRIA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                            txtPGN.Text = SearchString

                                        Case "EMPATE"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                            txtPGN.Text = SearchString

                                        Case "DERROTA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                            txtPGN.Text = SearchString

                                    End Select

                                    nomearquivo = siglatipo + siglacor + " " + sequenciatemovimentoseis
                                    salvarComo.Filter = ".pgn|*.pgn"
                                    salvarComo.FileName = mestre + " " + nomearquivo
                                    caminho = salvarComo.ShowDialog
                                    Arquivo = salvarComo.FileName
                                    CONTROLE = 1

                                Case "PC"

                                    Select Case finaldapartida

                                        Case "VITÓRIA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{VITÓRIA}"
                                            txtPGN.Text = SearchString

                                        Case "EMPATE"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + " {EMPATE}"
                                            txtPGN.Text = SearchString

                                        Case "DERROTA"

                                            SearchString = SearchString + Environment.NewLine + Environment.NewLine + "{DERROTA}"
                                            txtPGN.Text = SearchString

                                    End Select

                                    nomearquivo = siglatipo + siglacor + " " + sequenciatemovimentoseis
                                    salvarComo.Filter = ".pgn|*.pgn"
                                    salvarComo.FileName = mestre + " " + nomearquivo
                                    caminho = salvarComo.ShowDialog
                                    Arquivo = salvarComo.FileName
                                    CONTROLE = 1

                            End Select


                        End If


                End Select

        End If

        fluxoTexto = New IO.StreamWriter(Arquivo)
        fluxoTexto.Write(txtPGN.Text)
        fluxoTexto.Close()




    End Sub

    Private Sub txtPGN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPGN.TextChanged
        'ROTINA DE IDENTIFICAÇÃO

        Dim StringdoPGN As String = txtPGN.Text

        'IDENTIFICAÇÃO DO EVENT
        'Dim StringdoPGN As String = txtPGN.Text
        Dim posicaoevent As Integer
        Dim posicaobarradoevent As Integer
        Dim posicaobarra2doevent As Integer

        On Error Resume Next

        posicaoevent = StringdoPGN.IndexOf("[Event")
        posicaobarradoevent = StringdoPGN.IndexOf("""", posicaoevent)
        posicaobarra2doevent = StringdoPGN.IndexOf("]", posicaobarradoevent)

        ' txtEvento.Text = posicaoevent.ToString + "/" + posicaobarradoevent.ToString + "/" + posicaobarra2doevent.ToString

        'CODIGO PARA CORTAR EVENT

        Dim PosEvent As Integer
        Dim PosEvent2 As Integer
        Dim iniciodoevent As String
        Dim tamanhodoevent As Integer

        'PosEvent = "valor de inicio da string event
        'PosEvent2 = "valor da posicao final

        PosEvent = posicaobarradoevent + 2
        PosEvent2 = posicaobarra2doevent

        If PosEvent > PosEvent2 Then
            Exit Sub
        Else

            tamanhodoevent = PosEvent2 - PosEvent

            iniciodoevent = StringdoPGN.Substring(PosEvent - 1, tamanhodoevent)

            txtEVENTO.Text = iniciodoevent

        End If

        'INDENTIFICAÇÃO DA DATA

        Dim posicaodate As Integer
        Dim posicaobarradodate As Integer
        Dim posicaobarra2dodate As Integer


        posicaodate = StringdoPGN.IndexOf("[Date")
        posicaobarradodate = StringdoPGN.IndexOf("""", posicaodate)
        posicaobarra2dodate = StringdoPGN.IndexOf("]", posicaobarradodate)



        'txtData.Text = posicaodate.ToString + "/" + posicaobarradodate.ToString + "/" + posicaobarra2dodate.ToString


        'CODIGO PARA CORTAR date

        Dim Posdate As Integer
        Dim Posdate2 As Integer
        Dim iniciododate As String
        Dim tamanhododate As Integer

        'Posdate = "valor de inicio da string date
        'Posdate2 = "valor da posicao final

        Posdate = posicaobarradodate + 2
        Posdate2 = posicaobarra2dodate

        If Posdate > Posdate2 Then
            Exit Sub
        Else

            tamanhododate = Posdate2 - Posdate

            iniciododate = StringdoPGN.Substring(Posdate - 1, tamanhododate)

            txtPGN.Text = StringdoPGN.Replace(iniciododate, iniciododate.Replace(".", "/"))

            iniciododate = iniciododate.Replace(".", "/")

            txtDATA.Text = iniciododate

        End If


        'INDENTIFICAÇÃO DO RESULT

        Dim posicaoresult As Integer
        Dim posicaobarradoresult As Integer
        Dim posicaobarra2doresult As Integer


        posicaoresult = StringdoPGN.IndexOf("[Result")
        posicaobarradoresult = StringdoPGN.IndexOf("""", posicaoresult)
        posicaobarra2doresult = StringdoPGN.IndexOf("]", posicaobarradoresult)



        ' txtResultado.Text = posicaoresult.ToString + "/" + posicaobarradoresult.ToString + "/" + posicaobarra2doresult.ToString

        'CODIGO PARA CORTAR result

        Dim Posresult As Integer
        Dim Posresult2 As Integer
        Dim iniciodoresult As String
        Dim tamanhodoresult As Integer

        'Posresult = "valor de inicio da string result
        'Posresult2 = "valor da posicao final

        Posresult = posicaobarradoresult + 2
        Posresult2 = posicaobarra2doresult

        If Posresult > Posresult2 Then
            Exit Sub
        Else

            tamanhodoresult = Posresult2 - Posresult

            iniciodoresult = StringdoPGN.Substring(Posresult - 1, tamanhodoresult)

            txtRESULTADO.Text = iniciodoresult

        End If

        'INDENTIFICAÇÃO DAS BRANCAS

        Dim posicaoWhite As Integer
        Dim posicaobarradoWhite As Integer
        Dim posicaobarra2doWhite As Integer


        posicaoWhite = StringdoPGN.IndexOf("[White")
        posicaobarradoWhite = StringdoPGN.IndexOf("""", posicaoWhite)
        posicaobarra2doWhite = StringdoPGN.IndexOf("]", posicaobarradoWhite)



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

        If PosWhite > PosWhite2 Then
            Exit Sub
        Else

            tamanhodoWhite = PosWhite2 - PosWhite

            iniciodoWhite = StringdoPGN.Substring(PosWhite - 1, tamanhodoWhite)

            txtBRANCAS.Text = iniciodoWhite

        End If
        'INDENTIFICAÇÃO DAS pretas

        Dim posicaoBlack As Integer
        Dim posicaobarradoBlack As Integer
        Dim posicaobarra2doBlack As Integer


        posicaoBlack = StringdoPGN.IndexOf("[Black")
        posicaobarradoBlack = StringdoPGN.IndexOf("""", posicaoBlack)
        posicaobarra2doBlack = StringdoPGN.IndexOf("]", posicaobarradoBlack)



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

        If PosBlack > PosBlack2 Then
            Exit Sub
        Else

            tamanhodoBlack = PosBlack2 - PosBlack

            iniciodoBlack = StringdoPGN.Substring(PosBlack - 1, tamanhodoBlack)

            txtPRETAS.Text = iniciodoBlack

        End If

        'IDENTIFICAÇÃO DA ABERTURA


        Dim posicaoopening As Integer
        Dim posicaobarradoopening As Integer
        Dim posicaobarra2doopening As Integer


        posicaoopening = StringdoPGN.IndexOf("[Opening")
        posicaobarradoopening = StringdoPGN.IndexOf("""", posicaoopening)
        posicaobarra2doopening = StringdoPGN.IndexOf("]", posicaobarradoopening)



        ' txtopeningado.Text = posicaoopening.ToString + "/" + posicaobarradoopening.ToString + "/" + posicaobarra2doopening.ToString

        'CODIGO PARA CORTAR ABERTURA

        Dim Posopening As Integer
        Dim Posopening2 As Integer
        Dim iniciodoopening As String
        Dim tamanhodoopening As Integer

        'Posopening = "valor de inicio da string opening
        'Posopening2 = "valor da posicao final

        Posopening = posicaobarradoopening + 2
        Posopening2 = posicaobarra2doopening

        If Posopening > Posopening2 Then
            Exit Sub
        Else

            tamanhodoopening = Posopening2 - Posopening

            iniciodoopening = StringdoPGN.Substring(Posopening - 1, tamanhodoopening)

            txtABERTURA.Text = iniciodoopening

        End If

        txtTAMANHODOPGN.Text = Len(txtPGN.Text)


        'FIM ROTINA IDENTIFICAÇÃO
        Dim SearchString As String = txtPGN.Text
        Dim SearchChar As String = "1."
        Dim SearchChar2 As String = " 7."
        Dim TestPos As Integer
        Dim TestPos2 As Integer
        Dim iniciodopgn As String
        Dim tamanhodopgn As Integer

        txtTAMANHODOPGN.Text = Len(SearchString)

        If Len(txtPGN.Text) > 980 Then


            txtPGN.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)

        End If

        If Len(txtPGN.Text) > 1200 Then


            txtPGN.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)

        End If



        TestPos = InStr(1, SearchString, SearchChar, CompareMethod.Text)
        TestPos2 = InStr(1, SearchString, SearchChar2, CompareMethod.Text)

        If TestPos = 0 Then

            Exit Sub

        Else



            If TestPos > TestPos2 Then
                Exit Sub
            Else

                tamanhodopgn = TestPos2 - TestPos

                iniciodopgn = SearchString.Substring(TestPos - 1, tamanhodopgn)

                txtNOMEDOPGN.Text = iniciodopgn

                sequenciatemovimentoseis = iniciodopgn

            End If


        End If

        Select Case cordaspecas

            Case Is = "BRANCAS"

                Dim texto As String = txtPGN.Text
                Dim marca1dasigla As String = "1."
                Dim marca2dasigla As String = " 2."
                Dim textomaior As Integer
                Dim textomenor As Integer

                textomaior = InStr(1, texto, marca1dasigla, CompareMethod.Text)
                textomenor = InStr(1, texto, marca2dasigla, CompareMethod.Text)

                If textomaior = 0 Then

                    Exit Sub

                Else

                    Dim iniciodasigla As String
                    Dim tamanhodasigla As Integer

                    If textomaior > textomenor Then

                        Exit Sub

                    Else

                        tamanhodasigla = textomenor - textomaior

                        iniciodasigla = texto.Substring(textomaior - 1, tamanhodasigla)

                        iniciodasigla = iniciodasigla.Substring(0, 6)

                        txtSIGLADAABERTURA.Text = iniciodasigla

                        txtTAMANHODASIGLA.Text = Len(iniciodasigla)

                    End If

                End If

                Dim aberturacompleta As String = txtNOMEDOPGN.Text
                Dim sequenciasemsigla As String
                Dim tamanhodasigla2 As Integer = Len(txtNOMEDOPGN.Text)

                sequenciasemsigla = aberturacompleta.Substring(6, tamanhodasigla2 - 6)

                txtNOMEDOPGN.Text = sequenciasemsigla

            Case Is = "PRETAS"

                Dim texto As String = txtPGN.Text
                Dim marca1dasigla As String = "1."
                Dim marca2dasigla As String = " 2."
                Dim textomaior As Integer
                Dim textomenor As Integer

                textomaior = InStr(1, texto, marca1dasigla, CompareMethod.Text)
                textomenor = InStr(1, texto, marca2dasigla, CompareMethod.Text)

                If textomaior = 0 Then

                    Exit Sub

                Else

                    Dim iniciodasigla As String
                    Dim tamanhodasigla As Integer

                    If textomaior > textomenor Then

                        Exit Sub

                    Else

                        tamanhodasigla = textomenor - textomaior

                        iniciodasigla = texto.Substring(textomaior - 1, tamanhodasigla)

                        txtSIGLADAABERTURA.Text = iniciodasigla

                        txtTAMANHODASIGLA.Text = Len(iniciodasigla)

                    End If

                End If

                Dim iniciodasigla2 As String = txtSIGLADAABERTURA.Text
                Dim aberturacompleta As String = txtNOMEDOPGN.Text
                Dim sequenciasemsigla As String
                Dim tamanhodasigla2 As Integer = Len(txtNOMEDOPGN.Text)
                Dim tamanhodocorte As Integer = Len(iniciodasigla2) + 1


                sequenciasemsigla = aberturacompleta.Substring(tamanhodocorte, tamanhodasigla2 - tamanhodocorte)

                txtNOMEDOPGN.Text = sequenciasemsigla


        End Select

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnIDENTIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIDENTIFICAR.Click

        Dim SearchString As String = txtPGN.Text

        'IDENTIFICAÇÃO DO EVENT
        'Dim SearchString As String = txtPGN.Text
        Dim posicaoevent As Integer
        Dim posicaobarradoevent As Integer
        Dim posicaobarra2doevent As Integer

        On Error Resume Next

        posicaoevent = SearchString.IndexOf("[Event")
        posicaobarradoevent = SearchString.IndexOf("""", posicaoevent)
        posicaobarra2doevent = SearchString.IndexOf("]", posicaobarradoevent)

        ' txtEvento.Text = posicaoevent.ToString + "/" + posicaobarradoevent.ToString + "/" + posicaobarra2doevent.ToString

        'CODIGO PARA CORTAR EVENT

        Dim PosEvent As Integer
        Dim PosEvent2 As Integer
        Dim iniciodoevent As String
        Dim tamanhodoevent As Integer

        'PosEvent = "valor de inicio da string event
        'PosEvent2 = "valor da posicao final

        PosEvent = posicaobarradoevent + 2
        PosEvent2 = posicaobarra2doevent

        If PosEvent > PosEvent2 Then
            Exit Sub
        Else

            tamanhodoevent = PosEvent2 - PosEvent

            iniciodoevent = SearchString.Substring(PosEvent - 1, tamanhodoevent)

            txtEVENTO.Text = iniciodoevent

        End If

        'INDENTIFICAÇÃO DA DATA

        Dim posicaodate As Integer
        Dim posicaobarradodate As Integer
        Dim posicaobarra2dodate As Integer


        posicaodate = SearchString.IndexOf("[Date")
        posicaobarradodate = SearchString.IndexOf("""", posicaodate)
        posicaobarra2dodate = SearchString.IndexOf("]", posicaobarradodate)



        'txtData.Text = posicaodate.ToString + "/" + posicaobarradodate.ToString + "/" + posicaobarra2dodate.ToString


        'CODIGO PARA CORTAR date

        Dim Posdate As Integer
        Dim Posdate2 As Integer
        Dim iniciododate As String
        Dim tamanhododate As Integer

        'Posdate = "valor de inicio da string date
        'Posdate2 = "valor da posicao final

        Posdate = posicaobarradodate + 2
        Posdate2 = posicaobarra2dodate

        If Posdate > Posdate2 Then
            Exit Sub
        Else

            tamanhododate = Posdate2 - Posdate

            iniciododate = SearchString.Substring(Posdate - 1, tamanhododate)

            txtDATA.Text = iniciododate

        End If


        'INDENTIFICAÇÃO DO RESULT

        Dim posicaoresult As Integer
        Dim posicaobarradoresult As Integer
        Dim posicaobarra2doresult As Integer


        posicaoresult = SearchString.IndexOf("[Result")
        posicaobarradoresult = SearchString.IndexOf("""", posicaoresult)
        posicaobarra2doresult = SearchString.IndexOf("]", posicaobarradoresult)



        ' txtResultado.Text = posicaoresult.ToString + "/" + posicaobarradoresult.ToString + "/" + posicaobarra2doresult.ToString

        'CODIGO PARA CORTAR result

        Dim Posresult As Integer
        Dim Posresult2 As Integer
        Dim iniciodoresult As String
        Dim tamanhodoresult As Integer

        'Posresult = "valor de inicio da string result
        'Posresult2 = "valor da posicao final

        Posresult = posicaobarradoresult + 2
        Posresult2 = posicaobarra2doresult

        If Posresult > Posresult2 Then
            Exit Sub
        Else

            tamanhodoresult = Posresult2 - Posresult

            iniciodoresult = SearchString.Substring(Posresult - 1, tamanhodoresult)

            txtRESULTADO.Text = iniciodoresult

        End If

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

        If PosWhite > PosWhite2 Then
            Exit Sub
        Else

            tamanhodoWhite = PosWhite2 - PosWhite

            iniciodoWhite = SearchString.Substring(PosWhite - 1, tamanhodoWhite)

            txtBRANCAS.Text = iniciodoWhite

        End If
        'INDENTIFICAÇÃO DAS pretas

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

        If PosBlack > PosBlack2 Then
            Exit Sub
        Else

            tamanhodoBlack = PosBlack2 - PosBlack

            iniciodoBlack = SearchString.Substring(PosBlack - 1, tamanhodoBlack)

            txtPRETAS.Text = iniciodoBlack

        End If

        'IDENTIFICAÇÃO DA ABERTURA


        Dim posicaoopening As Integer
        Dim posicaobarradoopening As Integer
        Dim posicaobarra2doopening As Integer


        posicaoopening = SearchString.IndexOf("[Opening")
        posicaobarradoopening = SearchString.IndexOf("""", posicaoopening)
        posicaobarra2doopening = SearchString.IndexOf("]", posicaobarradoopening)



        ' txtopeningado.Text = posicaoopening.ToString + "/" + posicaobarradoopening.ToString + "/" + posicaobarra2doopening.ToString

        'CODIGO PARA CORTAR ABERTURA

        Dim Posopening As Integer
        Dim Posopening2 As Integer
        Dim iniciodoopening As String
        Dim tamanhodoopening As Integer

        'Posopening = "valor de inicio da string opening
        'Posopening2 = "valor da posicao final

        Posopening = posicaobarradoopening + 2
        Posopening2 = posicaobarra2doopening

        If Posopening > Posopening2 Then
            Exit Sub
        Else

            tamanhodoopening = Posopening2 - Posopening

            iniciodoopening = SearchString.Substring(Posopening - 1, tamanhodoopening)

            txtABERTURA.Text = iniciodoopening

        End If

        txtTAMANHODOPGN.Text = Len(txtPGN.Text)

    End Sub



    Private Sub btnTIRARMARCAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTIRARMARCAS.Click

        Dim SearchString As String = txtPGN.Text
        Dim iniciodoclock As String = " { [%clk"
        Dim finaldoclock As String = "] } "
        Dim TestPos As Integer
        Dim TestPos2 As Integer
        Dim diferenca As Integer


        TestPos = InStr(1, SearchString, iniciodoclock, CompareMethod.Text)
        TestPos2 = InStr(1, SearchString, finaldoclock, CompareMethod.Text)

        diferenca = TestPos2 - TestPos

        On Error Resume Next


        Do While diferenca > 0

            TestPos = InStr(1, SearchString, iniciodoclock, CompareMethod.Text)
            TestPos2 = InStr(1, SearchString, finaldoclock, CompareMethod.Text)



            txtPGN.Text = SearchString

            'txtPosicaoinicioclock.Text = TestPos.ToString

            'txtPosicaofimclock.Text = TestPos2.ToString

            txtTAMANHODOPGN.Text = Len(SearchString)

            'Dim pgn As String
            'Dim substring As String
            Dim marcadoclock As String
            Dim tamanhodopgn As Integer

            tamanhodopgn = TestPos2 - TestPos + 4

            marcadoclock = SearchString.Substring(TestPos - 1, tamanhodopgn)

            SearchString = SearchString.Replace(marcadoclock, " ")



            diferenca = TestPos2 - TestPos

            txtPGN.Text = SearchString

        Loop


        Dim SearchString2 As String = txtPGN.Text

        Dim chaveinicioabertura As String = " { "
        Dim chavefinalabertura As String = " } "

        Dim TestPos3 As Integer
        Dim TestPos4 As Integer


        TestPos3 = InStr(1, SearchString2, chaveinicioabertura, CompareMethod.Text)
        TestPos4 = InStr(1, SearchString2, chavefinalabertura, CompareMethod.Text)


        If TestPos3 = 0 Then

            Exit Sub

        Else

            'txtPosicaoinicioclock.Text = TestPos.ToString

            'txtPosicaofimclock.Text = TestPos2.ToString

            txtTAMANHODOPGN.Text = Len(SearchString2)

            'Dim pgn As String
            'Dim substring As String
            Dim abertura As String
            Dim tamanhodopgn As Integer

            tamanhodopgn = TestPos4 - TestPos3 + 3

            abertura = SearchString2.Substring(TestPos3 - 1, tamanhodopgn)

            txtABERTURA.Text = abertura


            SearchString2 = SearchString2.Replace(abertura, " ")

            txtPGN.Text = SearchString2

        End If


    End Sub


    Private Sub btnLIMPAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLIMPAR.Click

        txtPGN.Clear()
        txtNOMEDOPGN.Clear()
        txtEVENTO.Clear()
        txtDATA.Clear()
        'txtOBSERVACAO.Clear()
        txtBRANCAS.Clear()
        txtPRETAS.Clear()
        txtABERTURA.Clear()
        txtRESULTADO.Clear()
        txtTAMANHODOPGN.Clear()
        txtPGN.Focus()


    End Sub

    Private Sub btnAPLICARNOME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAPLICARNOME.Click

        On Error Resume Next

        If tipodapartida = "PES" Or tipodapartida = "PC" Or tipodapartida = "PES/PC" Then

            If cordaspecas = "BRANCAS" Then


                Dim SearchString As String = txtPGN.Text

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


                txtBRANCAS.Text = iniciodoWhite

                iniciodoWhite = "[White " + """" + iniciodoWhite

                'AQUI SUBSTITUI PELA VARIANTE PUBLICA NOME

                nome = "[White " + """" + nome

                SearchString = SearchString.Replace(iniciodoWhite, nome)

                txtPGN.Text = SearchString

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

                    txtBRANCAS.Text = iniciodoWhite2

                End If

            End If


            If cordaspecas = "PRETAS" Then


                Dim SearchString As String = txtPGN.Text

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


                txtPRETAS.Text = iniciodoBlack

                iniciodoBlack = "[Black " + """" + iniciodoBlack

                'AQUI SUBSTITUI PELA VARIANTE PUBLICA NOME

                nome = "[Black " + """" + nome

                SearchString = SearchString.Replace(iniciodoBlack, nome)

                txtPGN.Text = SearchString

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

                    txtPRETAS.Text = iniciodoBlack2

                End If

            End If

        Else

            'AQUI VÃO OS CASOS DE PARTIDA TIPO PCXPC E PESXPC*****************************************************************************************************



            Dim SearchString As String = txtPGN.Text

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


            txtBRANCAS.Text = iniciodoWhite

            iniciodoWhite = "[White " + """" + iniciodoWhite

            'AQUI SUBSTITUI PELA VARIANTE PUBLICA NOME

            nomebrancas = "[White " + """" + nomebrancas

            SearchString = SearchString.Replace(iniciodoWhite, nomebrancas)

            txtPGN.Text = SearchString

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

                txtBRANCAS.Text = iniciodoWhite2

            End If



            Dim SearchString2 As String = txtPGN.Text

            'INDENTIFICAÇÃO DAS PRETAS

            Dim posicaoBlack As Integer
            Dim posicaobarradoBlack As Integer
            Dim posicaobarra2doBlack As Integer


            posicaoBlack = SearchString2.IndexOf("[Black")
            posicaobarradoBlack = SearchString2.IndexOf("""", posicaoBlack)
            posicaobarra2doBlack = SearchString2.IndexOf("]", posicaobarradoBlack)



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



            iniciodoBlack = SearchString2.Substring(PosBlack - 1, tamanhodoBlack)


            txtPRETAS.Text = iniciodoBlack

            iniciodoBlack = "[Black " + """" + iniciodoBlack

            'AQUI SUBSTITUI PELA VARIANTE PUBLICA NOME

            nome = "[Black " + """" + nomepretas

            SearchString2 = SearchString2.Replace(iniciodoBlack, nome)

            txtPGN.Text = SearchString2

            'INDENTIFICAÇÃO DAS PRETAS

            Dim posicaoBlack2 As Integer
            Dim posicaobarradoBlack2 As Integer
            Dim posicaobarra2doBlack2 As Integer


            posicaoBlack2 = SearchString2.IndexOf("[Black")
            posicaobarradoBlack2 = SearchString2.IndexOf("""", posicaoBlack2)
            posicaobarra2doBlack2 = SearchString2.IndexOf("]", posicaobarradoBlack2)



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



                iniciodoBlack2 = SearchString2.Substring(PosBlack3 - 1, tamanhodoBlack2)

                txtPRETAS.Text = iniciodoBlack2

            End If

       

        '*****************************************************************************************************************************************************

        End If

        btnAPLICARNOME.Enabled = False




    End Sub

    Private Sub btnNOVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNOVO.Click
        Me.Close()
        frmPECAS.Show()

    End Sub

    Private Sub frmCADASTRAR_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'If e.KeyCode = Keys.Control OrElse e.KeyCode = Keys.S Then
        'Call btnSALVO.PerformClick()
        'End If
    End Sub

    Private Sub btnOBSERVACAO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOBSERVACAO.Click

        Dim comentario As String
        Dim texto As String

        comentario = InputBox("INSIRA UM COMENTÁRIO!", "COMENTÁRIO")

        texto = txtPGN.Text
        texto = texto + Environment.NewLine + "{" + comentario + "}"
        txtPGN.Text = texto




    End Sub

   
    Private Sub btnCOPIAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCOPIAR.Click

        If txtPGN.Text = "" Then

            MessageBox.Show("NENHUM PGN NA CAIXA!", "Copiar PGN", MessageBoxButtons.OK)
            txtPGN.Focus()

        Else
            Clipboard.SetDataObject(txtPGN.Text, True)
        End If

    End Sub

    Private Sub btnDIMINUIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDIMINUIR.Click
        Dim tamanho As Single

        Dim sizeatual As String

        sizeatual = txtPGN.Font.Size

        tamanho = InputBox("TAMANHO DA FONTE", "ALTERAR TAMANHO DA FONTE", sizeatual)


        txtPGN.Font = New Font("Microsoft Sans Serif", tamanho, FontStyle.Bold)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Clipboard.SetDataObject(txtPGN.Text, True)
        Process.Start("https://lichess.org/paste")
    End Sub

    Private Sub btnCOLAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCOLAR.Click
        Dim Texto As String
        Texto = Clipboard.GetText
        txtPGN.Text = Texto
    End Sub

    Private Sub btnADVERSARIO_Click(sender As Object, e As EventArgs) Handles btnADVERSARIO.Click
        frmADVERSARIO.Show()
    End Sub

    Private Sub btnBARRA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBARRA.Click

        Dim textocompleto As String = txtPGN.Text
        Dim ponto As String = "1."
        Dim textoantes As String
        Dim textodepois As String
        Dim posicao As Integer

        posicao = InStr(1, textocompleto, ponto, 1)



        textoantes = Mid(textocompleto, 1, posicao - 1)
        textodepois = Mid(textocompleto, posicao + 2, Len(textocompleto))

        txtPGN.Text = textoantes + "1/" + textodepois

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next

        frmFINAL.Close()
        frmPECAS.Close()
        frmTIPO.Close()
        frmLICHESS.Close()
        frmMESTRE.Close()
        Me.Close()


    End Sub
End Class