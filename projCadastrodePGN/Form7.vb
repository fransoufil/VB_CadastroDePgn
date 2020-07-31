Imports System.IO
Imports System.IO.FileAccess
Imports System.Text
Imports System.Linq

Public Class frmCONSULTA

    Private Sub btnAPLICARNOME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAPLICARNOME.Click

        'Dim path As String = FolderBrowserDialog1.SelectedPath
        Dim diretorio As String = ""
        Dim nomearq As String

        txtPGN.Text = ""
        txtNOMEDOPGN.Text = ""
        txtITEM.Text = ""
        txtEVENTO.Text = ""
        txtDATA.Text = ""
        txtBRANCAS.Text = ""
        txtPRETAS.Text = ""
        txtRESULTADO.Text = ""
        txtQUANTIDADEDEPGN.Text = ""
        txtDIRETORIO.Text = ""

        listARQUIVOS.Items.Clear()



        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            ' get the selected path value
            Dim path As String = FolderBrowserDialog1.SelectedPath

            ' set the

            txtDIRETORIO.Text = path

            ' ToDo: call the method that populates the Files listview
        End If

       
        diretorio = txtDIRETORIO.Text


        If diretorio <> "" Then

            Dim msg, titulo, valor As String
            Dim objValor As Object

            msg = "Serão listados arquivos .pgn ou escolha outro formato..."
            titulo = "Listar arquivos..."
            valor = "*.pgn"

            objValor = InputBox(msg, titulo, valor, 200, 200)

            Me.listARQUIVOS.Items.Clear()
            'Me.listArquivos.Items.Add(New String(txtDIRETORIO.Text))

            For Each nomearq In Directory.GetFiles(diretorio, objValor)

                Me.listARQUIVOS.Items.Add(New String(nomearq))

            Next

            txtDIRETORIO.Text = diretorio.ToString

        Else
            MessageBox.Show("Informe o caminho/nome do diretório para listar!", "LISTANDO PGNS",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        txtQUANTIDADEDEPGN.Text = listARQUIVOS.Items.Count.ToString
        txtDIRETORIO.Text = diretorio



    End Sub

    Private Sub listARQUIVOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listARQUIVOS.SelectedIndexChanged

        Dim tamanhopgn As Integer
        Dim caminhocompleto As String = ""
        Dim fluxotexto As IO.StreamReader
        Dim arquivo As String


        If (listARQUIVOS.Items.Count = 0) = False Then

            If (listARQUIVOS.SelectedItem Is Nothing) = False Then
                caminhocompleto = listARQUIVOS.SelectedItem.ToString

            Else

                MsgBox("Selecione um PGN válido!", vbOKOnly, "Seleção de PGN")
                Exit Sub
            End If

            tamanhopgn = Len(txtDIRETORIO.Text) + 1

            txtNOMEDOPGN.Text = caminhocompleto.Substring(tamanhopgn)

        End If

        arquivo = caminhocompleto

        If arquivo = Nothing Then

            MessageBox.Show("Arquivo inválido!", "LENDO PGNS",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            fluxotexto = New IO.StreamReader(arquivo)
            txtPGN.Text = fluxotexto.ReadToEnd
            fluxotexto.Close()

        End If

        txtNUMCARPGN.Text = Len(txtNOMEDOPGN.Text)

        txtITEM.Text = listARQUIVOS.SelectedIndex.ToString + 1



        Dim SearchString As String = txtPGN.Text
        Dim posicaoevent As Integer
        Dim posicaobarradoevent As Integer
        Dim posicaobarra2doevent As Integer


        posicaoevent = SearchString.IndexOf("[Event")
        posicaobarradoevent = SearchString.IndexOf("""", posicaoevent)
        posicaobarra2doevent = SearchString.IndexOf("]", posicaobarradoevent)


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

            txtEvento.Text = iniciodoevent

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

            txtData.Text = iniciododate

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

            txtResultado.Text = iniciodoresult

        End If

        'INDENTIFICAÇÃO DO BRANCAS

        Dim posicaowhite As Integer
        Dim posicaobarradowhite As Integer
        Dim posicaobarra2dowhite As Integer


        posicaowhite = SearchString.IndexOf("[White")
        posicaobarradowhite = SearchString.IndexOf("""", posicaowhite)
        posicaobarra2dowhite = SearchString.IndexOf("]", posicaobarradowhite)



        ' txtwhiteado.Text = posicaowhite.ToString + "/" + posicaobarradowhite.ToString + "/" + posicaobarra2dowhite.ToString

        'CODIGO PARA CORTAR white

        Dim Poswhite As Integer
        Dim Poswhite2 As Integer
        Dim iniciodowhite As String
        Dim tamanhodowhite As Integer

        'Poswhite = "valor de inicio da string white
        'Poswhite2 = "valor da posicao final

        Poswhite = posicaobarradowhite + 2
        Poswhite2 = posicaobarra2dowhite

        If Poswhite > Poswhite2 Then
            Exit Sub
        Else

            tamanhodowhite = Poswhite2 - Poswhite



            iniciodowhite = SearchString.Substring(Poswhite - 1, tamanhodowhite)

            txtBRANCAS.Text = iniciodowhite

        End If

        'INDENTIFICAÇÃO DO PRETAS

        Dim posicaoblack As Integer
        Dim posicaobarradoblack As Integer
        Dim posicaobarra2doblack As Integer


        posicaoblack = SearchString.IndexOf("[Black")
        posicaobarradoblack = SearchString.IndexOf("""", posicaoblack)
        posicaobarra2doblack = SearchString.IndexOf("]", posicaobarradoblack)



        ' txtblackado.Text = posicaoblack.ToString + "/" + posicaobarradoblack.ToString + "/" + posicaobarra2doblack.ToString

        'CODIGO PARA CORTAR black

        Dim Posblack As Integer
        Dim Posblack2 As Integer
        Dim iniciodoblack As String
        Dim tamanhodoblack As Integer

        'Posblack = "valor de inicio da string black
        'Posblack2 = "valor da posicao final

        Posblack = posicaobarradoblack + 2
        Posblack2 = posicaobarra2doblack

        If Posblack > Posblack2 Then
            Exit Sub
        Else

            tamanhodoblack = Posblack2 - Posblack



            iniciodoblack = SearchString.Substring(Posblack - 1, tamanhodoblack)

            txtPRETAS.Text = iniciodoblack

        End If

        txtTAMANHODOPGN.Text = Len(txtPGN.Text)

        Dim pgncompleto As String = txtPGN.Text
        Dim SearchChar As String = "1."
        Dim SearchChar2 As String = " 7."
        Dim SearchChar3 As String = " 6."
        Dim posicao1 As Integer
        Dim posicao7 As Integer
        Dim iniciodopgn As String
        Dim tamanhodaabertura As Integer


        posicao1 = InStr(1, pgncompleto, SearchChar, CompareMethod.Text)
        posicao7 = InStr(1, pgncompleto, SearchChar2, CompareMethod.Text)

        tamanhodaabertura = posicao7 - posicao1

        If tamanhodaabertura < 0 Then

            MsgBox("PGN COM MENOS DE 7 MOVIMENTOS!", vbOKOnly, "ATENÇÃO")
            Exit Sub

        End If

        iniciodopgn = pgncompleto.Substring(posicao1 - 1, tamanhodaabertura)

        txtABERTURA.Text = iniciodopgn

        sequenciatemovimentoseis = iniciodopgn



    End Sub

    Private Sub frmCONSULTA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCOPIAR.Click
        If txtPGN.Text = "" Then

            MessageBox.Show("NENHUM PGN NA CAIXA!", "Copiar PGN", MessageBoxButtons.OK)
            txtPGN.Focus()

        Else
            Clipboard.SetDataObject(txtPGN.Text, True)
        End If
    End Sub

    Private Sub btnTRANSPOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTRANSPOR.Click

        Dim diretorio As String
        Dim numerodopgn As Integer

        If listARQUIVOS.Items.Count = 0 Then

            MsgBox("SELECIONE UM DIRETÓRIO COM PGNS", vbOKOnly, "NÃO HÁ PGNS")

        Else

            txtITEM.Text = ""
            txtNOMEDOPGN.Text = "conjunto"
            txtEVENTO.Text = ""
            txtDATA.Text = ""
            txtBRANCAS.Text = ""
            txtPRETAS.Text = ""
            txtRESULTADO.Text = ""
            txtNUMCARPGN.Text = ""
            txtPGN.Text = ""

            If txtDIRETORIO.Text = "" Then

                MsgBox("VERIFICAR DIRETORIO", vbOKOnly, "DIRETORIO INVALIDO")

            Else

                diretorio = txtDIRETORIO.Text

                Dim x As New DirectoryInfo(diretorio)
                Dim y = x.GetFiles

                'numerodopgn = 0
                numerodopgn = InputBox("Qual o número do pgn inicial?", "Contagem de pgns", "1")
                numerodopgn = Int32.Parse(numerodopgn)



                For Each z In y

                    'numerodopgn = numerodopgn + 1

                    If Path.GetExtension(z.FullName).ToLower.Contains(".pgn") Then
                        Dim f = IO.File.ReadAllText(z.FullName)

                        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ ATÉ AQUI ELE LÊ PGN POR PGN, NA LINHA ABAIXO ACRESCENTA NO TXTPGN.TEXT

                        txtPGN.Text += f.ToString() + "  " + "{" + numerodopgn.ToString + "}" + Environment.NewLine + Environment.NewLine
                    End If

                    numerodopgn = numerodopgn + 1
                Next
            End If

            txtTAMANHODOPGN.Text = Len(txtPGN.Text)

        End If

        

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()
    End Sub

    Private Sub txtPGN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPGN.TextChanged

        Dim pgnantigo As String = txtPGN.Text
        Dim pgncorrigido As String

        pgncorrigido = pgnantigo.Replace("EventDate", "")
        txtPGN.Text = pgncorrigido


        If Len(txtPGN.Text) > 660 Then


            txtPGN.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)

        End If

        If Len(txtPGN.Text) > 1100 Then


            txtPGN.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)

        End If
    End Sub

    Private Sub txtTAMANHODOPGN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTAMANHODOPGN.TextChanged
        If Len(txtPGN.Text) > 660 Then


            txtPGN.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)

        End If

        If Len(txtPGN.Text) > 1100 Then


            txtPGN.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)

        End If
    End Sub

    Private Sub btnLIMPAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLIMPAR.Click

        txtPGN.Text = ""
        txtNOMEDOPGN.Text = ""
        txtITEM.Text = ""
        txtEVENTO.Text = ""
        txtDATA.Text = ""
        txtBRANCAS.Text = ""
        txtPRETAS.Text = ""
        txtRESULTADO.Text = ""
        txtQUANTIDADEDEPGN.Text = ""
        txtDIRETORIO.Text = ""

        listARQUIVOS.Items.Clear()
        btnAPLICARNOME.Focus()

    End Sub

    Private Sub btnALTERARTAMANHO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnALTERARTAMANHO.Click

        On Error Resume Next

        Dim tamanho As Single

        Dim sizeatual As String

        sizeatual = txtPGN.Font.Size

        tamanho = InputBox("TAMANHO DA FONTE", "ALTERAR TAMANHO DA FONTE", sizeatual)


        txtPGN.Font = New Font("Microsoft Sans Serif", tamanho, FontStyle.Bold)



    End Sub

    Private Sub btnSALVARCOMO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALVARCOMO.Click

        On Error Resume Next
        Dim pgncompleto As String = txtPGN.Text
        Dim SearchChar As String = "1."
        Dim SearchChar2 As String = " 7."
        Dim posicao1 As Integer
        Dim posicao7 As Integer
        Dim iniciodopgn As String
        Dim tamanhodaabertura As Integer

        Dim vardata As String = txtDATA.Text
        Dim dt As DateTime = Convert.ToDateTime(vardata)
        Dim vardia, varmes, varano As String
        Dim datacompleta As String

        vardia = dt.Day.ToString()

        varmes = dt.Month.ToString()

        varano = dt.Year.ToString()

        datacompleta = vardia + "/" + varmes + "/" + varano

        'MsgBox(datacompleta)

        posicao1 = InStr(1, pgncompleto, SearchChar, CompareMethod.Text)
        posicao7 = InStr(1, pgncompleto, SearchChar2, CompareMethod.Text)

        tamanhodaabertura = posicao7 - posicao1

        iniciodopgn = pgncompleto.Substring(posicao1 - 1, tamanhodaabertura)

        txtABERTURA.Text = iniciodopgn

        sequenciatemovimentoseis = iniciodopgn

        Dim salvarComo As SaveFileDialog = New SaveFileDialog()
        Dim caminho As DialogResult
        Dim fluxoTexto As IO.StreamWriter
        Dim Arquivo As String
        Dim nomearquivo As String
        'Dim novonome As String

        salvarComo.CheckFileExists = False
        salvarComo.Title = "Arquivos PGNS |*.pgn|"

        If txtDIRETORIO.Text = "" Then

            salvarComo.InitialDirectory = "C:\Users\FRANZ\Documents\02_XADREZ"

        Else

            salvarComo.InitialDirectory = txtDIRETORIO.Text

        End If



        nomearquivo = txtNOMEDOPGN.Text
        salvarComo.Filter = ".pgn|*.pgn"
        salvarComo.FileName = nomearquivo
        caminho = salvarComo.ShowDialog
        Arquivo = salvarComo.FileName

       
            fluxoTexto = New IO.StreamWriter(Arquivo)
            fluxoTexto.Write(txtPGN.Text)
            fluxoTexto.Close()

        Clipboard.SetDataObject(txtABERTURA.Text, True)

    End Sub

    Private Sub btnAPLICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAPLICAR.Click
        If txtNOMEDOPGN.Text = "conjunto" Then
            MsgBox("NÃO PODE APLICAR NOME EM CONJUNTOS!", vbOKOnly, "NÃO DISPONÍVEL")
        Else
            frmMESTRE2.Show()
        End If


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

            SearchString2 = SearchString2.Replace(abertura, " ")

            txtPGN.Text = SearchString2

            


            

        End If

        Dim pgncompleto As String = txtPGN.Text
        Dim SearchChar As String = "1."
        Dim SearchChar2 As String = " 7."
        Dim posicao1 As Integer
        Dim posicao7 As Integer
        Dim iniciodopgn As String
        Dim tamanhodaabertura As Integer

        posicao1 = InStr(1, pgncompleto, SearchChar, CompareMethod.Text)
        posicao7 = InStr(1, pgncompleto, SearchChar2, CompareMethod.Text)

        tamanhodaabertura = posicao7 - posicao1

        iniciodopgn = pgncompleto.Substring(posicao1 - 1, tamanhodaabertura)

        txtABERTURA.Text = iniciodopgn

        sequenciatemovimentoseis = iniciodopgn
        

        'txtABERTURA.Text = abertura
    End Sub

    Private Sub btnCOLAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCOLAR.Click
        Dim Texto As String
        Texto = Clipboard.GetText
        txtPGN.Text = Texto
        'Clipboard.SetDataObject(txtPGN.Text, True)
    End Sub

    Private Sub btnCOMENTARIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCOMENTARIO.Click
        Dim comentario As String
        Dim texto As String

        If txtCOMENTARIO.Text = "" Then
            MsgBox("INSIRA UM COMENTÁRIO!", vbOKOnly, "COMENTÁRIO")
        Else

            If txtPGN.Text = "" Then
                MsgBox("INSIRA UM PGN!", vbOKOnly, "COMENTÁRIO")
            Else
                comentario = txtCOMENTARIO.Text

                texto = txtPGN.Text
                texto = texto + Environment.NewLine + "{" + comentario + "}"
                txtPGN.Text = texto
            End If
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Clipboard.SetDataObject(txtPGN.Text, True)
        Process.Start("https://lichess.org/paste")
    End Sub

    Private Sub btnOBSERVACAO_Click(sender As Object, e As EventArgs) Handles btnOBSERVACAO.Click
        Dim comentario As String
        Dim texto As String

        comentario = InputBox("INSIRA UM COMENTÁRIO!", "COMENTÁRIO")

        texto = txtPGN.Text
        texto = texto + Environment.NewLine + "{" + comentario + "}"
        txtPGN.Text = texto
    End Sub

    Private Sub btnSALVARTUDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSALVARTUDO.Click

        Dim diretorio As String
        Dim numerodopgn As Integer

        If listARQUIVOS.Items.Count = 0 Then

            MsgBox("SELECIONE UM DIRETÓRIO COM PGNS", vbOKOnly, "NÃO HÁ PGNS")

        Else

            If txtDIRETORIO.Text = "" Then

                MsgBox("VERIFICAR DIRETORIO", vbOKOnly, "DIRETORIO INVALIDO")

            Else

                diretorio = txtDIRETORIO.Text

                Dim x As New DirectoryInfo(diretorio)
                Dim y = x.GetFiles


                For Each z In y

                    txtPGN.Text = ""

                    If Path.GetExtension(z.FullName).ToLower.Contains(".pgn") Then
                        Dim f = IO.File.ReadAllText(z.FullName)
                        txtPGN.Text += f.ToString()

                        'txtDIRETORIO.Text = z.FullName.ToString

                        'INICIO DA ROTINA DE IDENTIFICAÇÃO

                        Dim SearchString As String = txtPGN.Text
                        Dim posicaoevent As Integer
                        Dim posicaobarradoevent As Integer
                        Dim posicaobarra2doevent As Integer


                        posicaoevent = SearchString.IndexOf("[Event")
                        posicaobarradoevent = SearchString.IndexOf("""", posicaoevent)
                        posicaobarra2doevent = SearchString.IndexOf("]", posicaobarradoevent)


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

                        'INDENTIFICAÇÃO DO BRANCAS

                        Dim posicaowhite As Integer
                        Dim posicaobarradowhite As Integer
                        Dim posicaobarra2dowhite As Integer


                        posicaowhite = SearchString.IndexOf("[White")
                        posicaobarradowhite = SearchString.IndexOf("""", posicaowhite)
                        posicaobarra2dowhite = SearchString.IndexOf("]", posicaobarradowhite)



                        ' txtwhiteado.Text = posicaowhite.ToString + "/" + posicaobarradowhite.ToString + "/" + posicaobarra2dowhite.ToString

                        'CODIGO PARA CORTAR white

                        Dim Poswhite As Integer
                        Dim Poswhite2 As Integer
                        Dim iniciodowhite As String
                        Dim tamanhodowhite As Integer

                        'Poswhite = "valor de inicio da string white
                        'Poswhite2 = "valor da posicao final

                        Poswhite = posicaobarradowhite + 2
                        Poswhite2 = posicaobarra2dowhite

                        If Poswhite > Poswhite2 Then
                            Exit Sub
                        Else

                            tamanhodowhite = Poswhite2 - Poswhite



                            iniciodowhite = SearchString.Substring(Poswhite - 1, tamanhodowhite)

                            txtBRANCAS.Text = iniciodowhite

                        End If

                        'INDENTIFICAÇÃO DO PRETAS

                        Dim posicaoblack As Integer
                        Dim posicaobarradoblack As Integer
                        Dim posicaobarra2doblack As Integer


                        posicaoblack = SearchString.IndexOf("[Black")
                        posicaobarradoblack = SearchString.IndexOf("""", posicaoblack)
                        posicaobarra2doblack = SearchString.IndexOf("]", posicaobarradoblack)



                        ' txtblackado.Text = posicaoblack.ToString + "/" + posicaobarradoblack.ToString + "/" + posicaobarra2doblack.ToString

                        'CODIGO PARA CORTAR black

                        Dim Posblack As Integer
                        Dim Posblack2 As Integer
                        Dim iniciodoblack As String
                        Dim tamanhodoblack As Integer

                        'Posblack = "valor de inicio da string black
                        'Posblack2 = "valor da posicao final

                        Posblack = posicaobarradoblack + 2
                        Posblack2 = posicaobarra2doblack

                        If Posblack > Posblack2 Then
                            Exit Sub
                        Else

                            tamanhodoblack = Posblack2 - Posblack

                            iniciodoblack = SearchString.Substring(Posblack - 1, tamanhodoblack)

                            txtPRETAS.Text = iniciodoblack

                        End If

                        'FIM DA ROTINA DE IDENTIFICAÇÃO

                        'INICIO DA ROTINA DE SALVAMENTO

                        Dim pgncompleto As String = txtPGN.Text
                        Dim SearchChar As String = "1."
                        Dim SearchChar2 As String = " 7."
                        Dim posicao1 As Integer
                        Dim posicao7 As Integer
                        Dim iniciodopgn As String
                        Dim tamanhodaabertura As Integer

                        Dim vardata As String = txtDATA.Text
                        Dim dt As DateTime = Convert.ToDateTime(vardata)
                        Dim vardia, varmes, varano As String
                        Dim datacompleta As String

                        vardia = dt.Day.ToString()

                        varmes = dt.Month.ToString()

                        varano = dt.Year.ToString()

                        datacompleta = vardia + "/" + varmes + "/" + varano

                        'MsgBox(datacompleta)

                        posicao1 = InStr(1, pgncompleto, SearchChar, CompareMethod.Text)
                        posicao7 = InStr(1, pgncompleto, SearchChar2, CompareMethod.Text)

                        tamanhodaabertura = posicao7 - posicao1

                        iniciodopgn = pgncompleto.Substring(posicao1 - 1, tamanhodaabertura)

                        txtABERTURA.Text = iniciodopgn

                        sequenciatemovimentoseis = iniciodopgn

                        Dim salvarComo As SaveFileDialog = New SaveFileDialog()
                        Dim caminho As DialogResult
                        Dim fluxoTexto As IO.StreamWriter
                        Dim Arquivo As String
                        Dim nomearquivo As String
                        'Dim novonome As String

                        salvarComo.CheckFileExists = False
                        salvarComo.Title = "Arquivos PGNS |*.pgn|"

                        If txtDIRETORIO.Text = "" Then

                            salvarComo.InitialDirectory = "C:\Users\FRANZ\Documents\02_XADREZ"

                        Else

                            'salvarComo.InitialDirectory = txtDIRETORIO.Text
                            salvarComo.InitialDirectory = "C:\Users\FRANZ\Documents\02_XADREZ"

                        End If
                        Dim tamanhopgn As Integer

                        tamanhopgn = Len(txtDIRETORIO.Text) + 1

                        nomearquivo = z.FullName.Substring(tamanhopgn)
                        salvarComo.Filter = ".pgn|*.pgn"
                        salvarComo.FileName = nomearquivo
                        caminho = salvarComo.ShowDialog
                        Arquivo = salvarComo.FileName


                        fluxoTexto = New IO.StreamWriter(Arquivo)
                        fluxoTexto.Write(txtPGN.Text)
                        fluxoTexto.Close()

                        Clipboard.SetDataObject(txtABERTURA.Text, True)

                        'FIM DA ROTINA DE SALVAMENTO

                    End If

                    numerodopgn = numerodopgn + 1
                Next
            End If

            txtTAMANHODOPGN.Text = Len(txtPGN.Text)

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim StringdoPGN As String = txtPGN.Text
        Dim pgnoriginal As String = txtPGN.Text
        Dim tamanho As Integer = Len(txtPGN.Text)
        Dim tamanhoprimeiramarca As Integer
        Dim iniciodoproximopgn As Integer

        Dim tamanhocortado As Integer

        'IDENTIFICAÇÃO DO EVENT
        'Dim StringdoPGN As String = txtPGN.Text
        Dim posicaoevent As Integer
        Dim posicaobarradoevent As Integer
        Dim posicaobarra2doevent As Integer
        Dim texto As String

        On Error Resume Next


        texto = txtPGN.Text


        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        Dim palavraAlvo As String = "Event"

       
        Dim fonteDados As String() = texto.Split(New Char() {" ", ",", ".", ";", ":", "-", ", ", "(", ")", "[", "]"}, StringSplitOptions.RemoveEmptyEntries)
        ' Cria e executa a consulta
        ' Ela é executada imediatamente porque um único valor é produzido
        ' Usamos ToLower para encontrar "xxx" e "XXX" 
        Dim resultado = From palavra In fonteDados
                                    Where palavra.ToLowerInvariant() = palavraAlvo.ToLowerInvariant()
                                    Select palavra
        'conta as ocorrências
        Dim valor As Integer = resultado.Count()
        'exibe o resultlado o listbox
        'MsgBox(valor & " ocorrência da palavra """ & palavraAlvo & """ foram encontradas.")



        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        If valor = 0 Then

            MsgBox("PGN inválido!", vbOKOnly)
            Exit Sub

        Else

            If valor > 1 Then

                posicaoevent = StringdoPGN.IndexOf("[Event")
                posicaobarradoevent = StringdoPGN.IndexOf("""", posicaoevent)
                posicaobarra2doevent = StringdoPGN.IndexOf("]", posicaobarradoevent)

                tamanhocortado = tamanho - posicaobarra2doevent

                tamanhoprimeiramarca = posicaobarra2doevent

                txtPGN.Text = Mid(txtPGN.Text, posicaobarra2doevent + 3, tamanhocortado)



                If txtPGN.Text = "" Then

                    MsgBox("FINAL DO PGN!")

                Else

                    StringdoPGN = txtPGN.Text
                    posicaoevent = StringdoPGN.IndexOf("[Event")
                    posicaobarradoevent = StringdoPGN.IndexOf("""", posicaoevent)
                    posicaobarra2doevent = StringdoPGN.IndexOf("]", posicaobarradoevent)

                    'MsgBox(posicaoevent)

                    iniciodoproximopgn = posicaoevent
                    'tamanhocortado = tamanho - posicaobarra2doevent

                    'txtPGN.Text = Mid(txtPGN.Text, posicaobarra2doevent + 3, tamanhocortado)

                End If

                Dim tamanhopgnasersalvo As Integer
                Dim pgnasersalvo As String

                tamanhopgnasersalvo = iniciodoproximopgn + tamanhoprimeiramarca

                pgnasersalvo = pgnoriginal.Substring(0, tamanhopgnasersalvo)
                'pgnasersalvo = Mid(pgnoriginal, 0, tamanhopgnasersalvo)

                formBACKUP.txtPGN.Text = pgnasersalvo

                formBACKUP.Show()


                formSALVAR.txtPGN.Text = pgnasersalvo

                frmFINALCORTADO.Show()

                formSALVAR.txtDIRETORIO.Text = txtDIRETORIO.Text

                txtPGN.Text = pgnoriginal.Substring(tamanhopgnasersalvo, (tamanho - tamanhopgnasersalvo))

            Else


                Dim pgnasersalvo As String

                pgnasersalvo = txtPGN.Text

                formBACKUP.txtPGN.Text = pgnasersalvo

                formBACKUP.Show()

                formSALVAR.txtPGN.Text = pgnasersalvo

                frmFINALCORTADO.Show()

                formSALVAR.txtDIRETORIO.Text = txtDIRETORIO.Text

                txtPGN.Text = ""

            End If

        End If
        


       

    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim StringdoPGN As String = txtPGN.Text
        Dim pgnoriginal As String = txtPGN.Text
        Dim tamanho As Integer = Len(txtPGN.Text)
        Dim tamanhoprimeiramarca As Integer
        Dim iniciodoproximopgn As Integer

        Dim tamanhocortado As Integer

        'IDENTIFICAÇÃO DO EVENT
        'Dim StringdoPGN As String = txtPGN.Text
        Dim posicaoevent As Integer
        Dim posicaobarradoevent As Integer
        Dim posicaobarra2doevent As Integer
        Dim texto As String

        On Error Resume Next


        texto = txtPGN.Text


        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        Dim palavraAlvo As String = "Event"


        Dim fonteDados As String() = texto.Split(New Char() {" ", ",", ".", ";", ":", "-", ", ", "(", ")", "[", "]"}, StringSplitOptions.RemoveEmptyEntries)
        ' Cria e executa a consulta
        ' Ela é executada imediatamente porque um único valor é produzido
        ' Usamos ToLower para encontrar "xxx" e "XXX" 
        Dim resultado = From palavra In fonteDados
                                    Where palavra.ToLowerInvariant() = palavraAlvo.ToLowerInvariant()
                                    Select palavra
        'conta as ocorrências
        Dim valor As Integer = resultado.Count()
        'exibe o resultlado o listbox
        'MsgBox(valor & " ocorrência da palavra """ & palavraAlvo & """ foram encontradas.")



        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        If valor = 0 Then

            MsgBox("PGN inválido!", vbOKOnly)
            Exit Sub

        Else

            If valor > 1 Then

                posicaoevent = StringdoPGN.IndexOf("[Event")
                posicaobarradoevent = StringdoPGN.IndexOf("""", posicaoevent)
                posicaobarra2doevent = StringdoPGN.IndexOf("]", posicaobarradoevent)

                tamanhocortado = tamanho - posicaobarra2doevent

                tamanhoprimeiramarca = posicaobarra2doevent

                txtPGN.Text = Mid(txtPGN.Text, posicaobarra2doevent + 3, tamanhocortado)



                If txtPGN.Text = "" Then

                    MsgBox("FINAL DO PGN!")

                Else

                    StringdoPGN = txtPGN.Text
                    posicaoevent = StringdoPGN.IndexOf("[Event")
                    posicaobarradoevent = StringdoPGN.IndexOf("""", posicaoevent)
                    posicaobarra2doevent = StringdoPGN.IndexOf("]", posicaobarradoevent)

                    'MsgBox(posicaoevent)

                    iniciodoproximopgn = posicaoevent
                    'tamanhocortado = tamanho - posicaobarra2doevent

                    'txtPGN.Text = Mid(txtPGN.Text, posicaobarra2doevent + 3, tamanhocortado)

                End If

                Dim tamanhopgnasersalvo As Integer
                Dim pgnasersalvo As String

                tamanhopgnasersalvo = iniciodoproximopgn + tamanhoprimeiramarca

                pgnasersalvo = pgnoriginal.Substring(0, tamanhopgnasersalvo)
                'pgnasersalvo = Mid(pgnoriginal, 0, tamanhopgnasersalvo)

                formBACKUP.txtPGN.Text = pgnasersalvo

                formBACKUP.Show()


                formSALVAR.txtPGN.Text = pgnasersalvo

                'frmFINALCORTADO.Show()

                formSALVAR.txtDIRETORIO.Text = txtDIRETORIO.Text

                txtPGN.Text = pgnoriginal.Substring(tamanhopgnasersalvo, (tamanho - tamanhopgnasersalvo))

                Clipboard.SetDataObject(pgnasersalvo, True)
                Process.Start("https://lichess.org/paste")

            Else


                Dim pgnasersalvo As String

                pgnasersalvo = txtPGN.Text

                formBACKUP.txtPGN.Text = pgnasersalvo

                formBACKUP.Show()

                formSALVAR.txtPGN.Text = pgnasersalvo

                'frmFINALCORTADO.Show()

                formSALVAR.txtDIRETORIO.Text = txtDIRETORIO.Text

                txtPGN.Text = ""

                Clipboard.SetDataObject(pgnasersalvo, True)
                Process.Start("https://lichess.org/paste")

            End If

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim pgnantigo As String = txtPGN.Text
        Dim pgncorrigido As String

        pgncorrigido = pgnantigo.Replace("EventDate", "")
        txtPGN.Text = pgncorrigido
    End Sub
End Class