Module funciones

    Public Function Aleatorio(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function

    Public Sub Solo_letras(ByRef e As KeyPressEventArgs)
        'Esto solo permite que usuario ingrese letras
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puedes ingresar letras")
        End If
    End Sub

    Public Function Verificar_repeticion(ByRef e As KeyPressEventArgs)
        'Verifica si el usuario ha ingresado una letra más de una vez
        Form2.letra_repetida = 0

        If (Asc(e.KeyChar) = 32) Then
            'Evita que el jugador ingrese espacios en blanco
        Else
            Form2.letras += e.KeyChar & " "

            For contador As Integer = 0 To Form2.letras.Length - 1

                If (e.KeyChar = Form2.letras.Chars(contador)) Then

                    Form2.letra_repetida += 1
                    Verificar_palabra()

                    If (Form2.letra_repetida > 1) Then
                        Return True
                    End If

                End If

            Next contador

            Form2.letras.Trim(" ")

        End If
    End Function

    Public Sub Verificar_palabra()
        If (Form2.aciertos = Form2.palabra.Length - 1) Then

            If (Form1.dificultad = "Normal") Then
                Form2.puntaje += 10
            Else
                Form2.puntaje += 20
            End If

            Form2.Label_score.Text = "Puntaje: " & Form2.puntaje
            MsgBox("¡Felicidades has adivinado la palabra, ahora puedes continuar al siguiente nivel!")
            Form2.boton_reiniciar.Enabled = False
            Form2.boton_siguiente.Enabled = True
            Form2.boton_siguiente.Focus()
        End If
    End Sub

    Public Sub Verificar_errores(ByRef e As Windows.Forms.KeyPressEventArgs)

        If (Asc(e.KeyChar) = 32 Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsNumber(e.KeyChar)) Then
            'Evita que si el jugador ingresa un espacio, un signo o un número el juego lo tome como un error 
        ElseIf (Form2.errores = 0) Then
            Form2.errores += 1
            Form2.PictureBox1.Visible = True
            Form2.PictureBox1.Image = My.Resources._1

        ElseIf (Form2.errores = 1) Then
            Form2.PictureBox1.Visible = True
            Form2.errores += 1
            Form2.PictureBox1.Image = My.Resources._2

        ElseIf (Form2.errores = 2) Then
            Form2.errores += 1
            Form2.PictureBox1.Image = My.Resources._3

        ElseIf (Form2.errores = 3) Then
            Form2.errores += 1
            Form2.PictureBox1.Image = My.Resources._4

        ElseIf (Form2.errores = 4) Then
            Form2.errores += 1
            Form2.PictureBox1.Image = My.Resources._5

        ElseIf (Form2.errores = 5) Then
            Form2.errores += 1
            Form2.PictureBox1.Image = My.Resources._6_1

        ElseIf (Form2.errores = 6) Then
            Form2.errores += 1
            Form2.PictureBox1.Image = My.Resources._7_1

        ElseIf (Form2.errores = 7) Then
            Form2.errores += 1
            Form2.PictureBox1.Image = My.Resources._8_1

        ElseIf (Form2.errores = 8) Then
            Form2.errores += 1
            Form2.PictureBox1.Image = My.Resources._9

        ElseIf (Form2.errores = 9) Then
            Form2.PictureBox1.Image = My.Resources._10

            Dim respuesta
            UCase(Form2.palabra.Chars(0))
            respuesta = MsgBox(Form1.nombre & " has perdido, tu puntaje es: " & Form2.puntaje & vbCrLf & "La palabra era " & Form2.palabra.Trim & ", ¿Quieres jugar otra vez?", MsgBoxStyle.YesNo)

            If (respuesta = vbYes) Then
                Reiniciar_juego()
                Limpiar_espacios()
                Colocar_espacios(Form2.palabra.Length)
            Else
                Form2.Close()
                Form1.Visible = True
            End If
        End If

    End Sub

    Public letra_correcta As Boolean
    Public Function Ingresar_letra(ByRef e As KeyPressEventArgs)
        letra_correcta = False

        For contador As Integer = 0 To Form2.palabra.Length - 1
            If (LCase(e.KeyChar) = Form2.palabra.Chars(contador) And Char.IsLetter(e.KeyChar)) Then
                letra_correcta = True
                Select Case contador
                    Case 0
                        Form2.Label1.Text = UCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 1
                        Form2.Label2.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 2
                        Form2.Label3.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 3
                        Form2.Label4.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 4
                        Form2.Label5.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 5
                        Form2.Label6.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 6
                        Form2.Label7.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 7
                        Form2.Label8.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 8
                        Form2.Label9.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 9
                        Form2.Label10.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 10
                        Form2.Label11.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                    Case 11
                        Form2.Label12.Text = LCase(e.KeyChar)
                        Form2.aciertos += 1
                End Select
            End If
        Next contador
    End Function

    Public Sub Colocar_espacios(ByRef longitud)
        'Dependiendo del la longitud de la palabra se mostrará cierta cantidad de "_" en una posición relativamente centrada
        If (longitud = 6) Then
            Form2.Label1.Visible = True
            Form2.Label1.Location = New Point(200, 625)
            Form2.Label2.Visible = True
            Form2.Label2.Location = New Point(230, 625)
            Form2.Label3.Visible = True
            Form2.Label3.Location = New Point(260, 625)
            Form2.Label4.Visible = True
            Form2.Label4.Location = New Point(290, 625)
            Form2.Label5.Visible = True
            Form2.Label5.Location = New Point(320, 625)
        ElseIf (longitud = 7) Then
            Form2.Label1.Visible = True
            Form2.Label1.Location = New Point(190, 625)
            Form2.Label2.Visible = True
            Form2.Label2.Location = New Point(220, 625)
            Form2.Label3.Visible = True
            Form2.Label3.Location = New Point(250, 625)
            Form2.Label4.Visible = True
            Form2.Label4.Location = New Point(280, 625)
            Form2.Label5.Visible = True
            Form2.Label5.Location = New Point(310, 625)
            Form2.Label6.Visible = True
            Form2.Label6.Location = New Point(340, 625)
        ElseIf (longitud = 8) Then
            Form2.Label1.Visible = True
            Form2.Label1.Location = New Point(170, 625)
            Form2.Label2.Visible = True
            Form2.Label2.Location = New Point(200, 625)
            Form2.Label3.Visible = True
            Form2.Label3.Location = New Point(230, 625)
            Form2.Label4.Visible = True
            Form2.Label4.Location = New Point(260, 625)
            Form2.Label5.Visible = True
            Form2.Label5.Location = New Point(290, 625)
            Form2.Label6.Visible = True
            Form2.Label6.Location = New Point(320, 625)
            Form2.Label7.Visible = True
            Form2.Label7.Location = New Point(350, 625)
        ElseIf (longitud = 9) Then
            Form2.Label1.Visible = True
            Form2.Label1.Location = New Point(150, 625)
            Form2.Label2.Visible = True
            Form2.Label2.Location = New Point(180, 625)
            Form2.Label3.Visible = True
            Form2.Label3.Location = New Point(210, 625)
            Form2.Label4.Visible = True
            Form2.Label4.Location = New Point(240, 625)
            Form2.Label5.Visible = True
            Form2.Label5.Location = New Point(270, 625)
            Form2.Label6.Visible = True
            Form2.Label6.Location = New Point(300, 625)
            Form2.Label7.Visible = True
            Form2.Label7.Location = New Point(330, 625)
            Form2.Label8.Visible = True
            Form2.Label8.Location = New Point(360, 625)
        ElseIf (longitud = 10) Then
            Form2.Label1.Visible = True
            Form2.Label1.Location = New Point(130, 625)
            Form2.Label2.Visible = True
            Form2.Label2.Location = New Point(160, 625)
            Form2.Label3.Visible = True
            Form2.Label3.Location = New Point(190, 625)
            Form2.Label4.Visible = True
            Form2.Label4.Location = New Point(220, 625)
            Form2.Label5.Visible = True
            Form2.Label5.Location = New Point(250, 625)
            Form2.Label6.Visible = True
            Form2.Label6.Location = New Point(280, 625)
            Form2.Label7.Visible = True
            Form2.Label7.Location = New Point(310, 625)
            Form2.Label8.Visible = True
            Form2.Label8.Location = New Point(340, 625)
            Form2.Label9.Visible = True
            Form2.Label9.Location = New Point(370, 625)
        ElseIf (longitud = 11) Then
            Form2.Label1.Visible = True
            Form2.Label1.Location = New Point(120, 625)
            Form2.Label2.Visible = True
            Form2.Label2.Location = New Point(150, 625)
            Form2.Label3.Visible = True
            Form2.Label3.Location = New Point(180, 625)
            Form2.Label4.Visible = True
            Form2.Label4.Location = New Point(210, 625)
            Form2.Label5.Visible = True
            Form2.Label5.Location = New Point(240, 625)
            Form2.Label6.Visible = True
            Form2.Label6.Location = New Point(270, 625)
            Form2.Label7.Visible = True
            Form2.Label7.Location = New Point(300, 625)
            Form2.Label8.Visible = True
            Form2.Label8.Location = New Point(330, 625)
            Form2.Label9.Visible = True
            Form2.Label9.Location = New Point(360, 625)
            Form2.Label10.Visible = True
            Form2.Label10.Location = New Point(390, 625)
        ElseIf (longitud = 12) Then
            Form2.Label1.Visible = True
            Form2.Label1.Location = New Point(100, 625)
            Form2.Label2.Visible = True
            Form2.Label2.Location = New Point(130, 625)
            Form2.Label3.Visible = True
            Form2.Label3.Location = New Point(160, 625)
            Form2.Label4.Visible = True
            Form2.Label4.Location = New Point(190, 625)
            Form2.Label5.Visible = True
            Form2.Label5.Location = New Point(220, 625)
            Form2.Label6.Visible = True
            Form2.Label6.Location = New Point(250, 625)
            Form2.Label7.Visible = True
            Form2.Label7.Location = New Point(280, 625)
            Form2.Label8.Visible = True
            Form2.Label8.Location = New Point(310, 625)
            Form2.Label9.Visible = True
            Form2.Label9.Location = New Point(340, 625)
            Form2.Label10.Visible = True
            Form2.Label10.Location = New Point(370, 625)
            Form2.Label11.Visible = True
            Form2.Label11.Location = New Point(400, 625)
        ElseIf (longitud = 13) Then
            Form2.Label1.Visible = True
            Form2.Label1.Location = New Point(90, 625)
            Form2.Label2.Visible = True
            Form2.Label2.Location = New Point(120, 625)
            Form2.Label3.Visible = True
            Form2.Label3.Location = New Point(150, 625)
            Form2.Label4.Visible = True
            Form2.Label4.Location = New Point(180, 625)
            Form2.Label5.Visible = True
            Form2.Label5.Location = New Point(210, 625)
            Form2.Label6.Visible = True
            Form2.Label6.Location = New Point(240, 625)
            Form2.Label7.Visible = True
            Form2.Label7.Location = New Point(270, 625)
            Form2.Label8.Visible = True
            Form2.Label8.Location = New Point(300, 625)
            Form2.Label9.Visible = True
            Form2.Label9.Location = New Point(330, 625)
            Form2.Label10.Visible = True
            Form2.Label10.Location = New Point(360, 625)
            Form2.Label11.Visible = True
            Form2.Label11.Location = New Point(390, 625)
            Form2.Label12.Visible = True
            Form2.Label12.Location = New Point(420, 625)
        End If
    End Sub

    Public Sub Limpiar_espacios()
        Form2.Label1.Visible = False
        Form2.Label1.Text = "_"
        Form2.Label2.Visible = False
        Form2.Label2.Text = "_"
        Form2.Label3.Visible = False
        Form2.Label3.Text = "_"
        Form2.Label4.Visible = False
        Form2.Label4.Text = "_"
        Form2.Label5.Visible = False
        Form2.Label5.Text = "_"
        Form2.Label6.Visible = False
        Form2.Label6.Text = "_"
        Form2.Label7.Visible = False
        Form2.Label7.Text = "_"
        Form2.Label8.Visible = False
        Form2.Label8.Text = "_"
        Form2.Label9.Visible = False
        Form2.Label9.Text = "_"
        Form2.Label10.Visible = False
        Form2.Label10.Text = "_"
        Form2.Label11.Visible = False
        Form2.Label11.Text = "_"
        Form2.Label12.Visible = False
        Form2.Label12.Text = "_"
    End Sub

    Public Sub Reiniciar_juego()
        Form2.letra_repetida = 0
        Form2.errores = 0
        Form2.puntaje = 0
        Form2.aciertos = 0
        Form2.letras = ""
        Form2.Label_score.Text = "Puntaje: " & Form2.puntaje
        Form2.num = Aleatorio(0, Form2.diccionario.length())
        Form2.palabra = Form2.diccionario(Form2.num)

        Limpiar_espacios()
        Colocar_espacios(Form2.palabra.Length)
    End Sub

    Public Sub Siguiente_nivel()

        If (Form1.dificultad = "Normal") Then
            Form2.errores = 0
            Form2.PictureBox1.Visible = False

        Else

            Form2.errores -= 5

            If (Form2.errores <= 0) Then
                Form2.errores = 0
                Form2.PictureBox1.Visible = False
            ElseIf (Form2.errores = 1) Then
                Form2.PictureBox1.Image = My.Resources._1
            ElseIf (Form2.errores = 2) Then
                Form2.PictureBox1.Image = My.Resources._2
            ElseIf (Form2.errores = 3) Then
                Form2.PictureBox1.Image = My.Resources._3
            ElseIf (Form2.errores = 4) Then
                Form2.PictureBox1.Image = My.Resources._4
            End If

        End If

        Form2.num = Aleatorio(0, Form2.diccionario.length())
        Form2.palabra = Form2.diccionario(Form2.num)
        Form2.letras = ""
        Form2.aciertos = 0
        Form2.letra_repetida = 0

        Form2.boton_siguiente.Enabled = False
        Form2.boton_reiniciar.Enabled = True
        Form2.boton_reiniciar.Focus()
        Limpiar_espacios()
        Colocar_espacios(Form2.palabra.Length)
        MsgBox(Form2.palabra)
    End Sub
End Module

