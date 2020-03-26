Public Class Form2
    Dim diccionario = New String() {"aguja ", "alambre ", "arete ", "bolsa ", "bandera ", "bufanda ", "carpeta ", "caramelo ", "cascanueces ", "diamante ", "dibujo ", "diente ", "empaque ", "etiqueta ", "esfera ", "filtro ", "florero ", "fuente ", "guante ", "globo ", "galleta ", "helado ", "hiedra ", "harmonica ", "incienso ", "interruptor ", "impresora ", "jarron ", "jabon ", "jirafa ", "lingote ", "linterna ", "lonchera ", "mostaza ", "marioneta ", "malvavisco ", "nomenclatura ", "nispero ", "nebulosa ", "ornamento ", "ocarina ", "ordenador ", "platillo ", "pelicula ", "pulgada ", "regalo ", "radio ", "resorte ", "sujetador ", "servilleta ", "sierra ", "temporizador ", "terciopelo ", "trompeta ", "ukelele ", "unidad ", "vainilla ", "vinagre ", "violin ", "xilofono ", "yogurt ", "yacimiento ", "yunque ", "zafiro ", "zanahoria ", "zapato ", "cebra ", "tucan ", "rinoceronte ", "cangrejo ", "delfin ", "pantera ", "tigre ", "koala ", "tortuga ", "mueble ", "murcielago ", "mapache ", "colibri ", "orangutan ", "caballo ", "elefante ", "raton ", "gallina ", "conejo ", "ciervo ", "coyote ", "lagarto ", "serpiente ", "hipopotamo ", "oveja ", "ardilla ", "aguila ", "escorpion ", "armadillo ", "hiena ", "alcon ", "camello ", "cocodrilo ", "araña ", "abeja ", "hormiga ", "insecto ", "animal ", "guacamayo ", "caracol ", "ornitorrinco ", "ballena ", "tiburon ", "camaron ", "gorila ", "cisne ", "flamenco ", "mariposa ", "nutria ", "paloma ", "buitre ", "cable ", "televisor ", "bosque ", "leche ", "universidad ", "computadora ", "cocina ", "plato ", "telefono ", "cargador ", " teclado ", "papelera ", "camioneta ", "ceramica ", "estante ", "nevera ", "revista ", "deporte ", "pintura ", "musica ", "cancion ", "titulo ", "almohada ", "madera ", "jungla ", "montaña", "barranco ", "cascada ", "oceano ", "continente ", "naturaleza ", "cuchillo ", "tormenta "}
    'Nota: Cada palabra tiene un espacio al final ya que al realizar cualquier operación con la propiedad .Chars de un String, arroja el error System.IndexOutOfRangeException al llegar al limite de la longitud de la cadena de texto
    Dim num As Integer = Aleatorio(0, diccionario.length())
    Dim letra_repetida, errores, puntaje, aciertos As Integer
    Dim palabra As String = diccionario(num)
    Dim letras As String = ""
    Dim secuencia_alt_f4 As Boolean


    Private Function Aleatorio(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        boton_reiniciar.Focus()
        colocar_espacios(palabra.Length)
    End Sub

    Private Sub boton_reiniciar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles boton_reiniciar.KeyDown
        If (e.Alt And e.KeyCode = Keys.F4) Then
            secuencia_alt_f4 = True
        Else
            secuencia_alt_f4 = False
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = secuencia_alt_f4
        secuencia_alt_f4 = False
    End Sub

    Public Sub solo_letras(ByRef e As Windows.Forms.KeyPressEventArgs)
        'Esto solo permite que usuario ingrese letras
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puedes ingresar letras")
        End If
    End Sub

    Private Sub colocar_espacios(ByRef Longitud)
        'Dependiendo del la longitud de la palabra se mostrará cierta cantidad de "_" en una posición relativamente centrada
        If (palabra.Length = 6) Then
            Label1.Visible = True
            Label1.Location = New Point(200, 625)
            Label2.Visible = True
            Label2.Location = New Point(230, 625)
            Label3.Visible = True
            Label3.Location = New Point(260, 625)
            Label4.Visible = True
            Label4.Location = New Point(290, 625)
            Label5.Visible = True
            Label5.Location = New Point(320, 625)
        ElseIf (palabra.Length = 7) Then
            Label1.Visible = True
            Label1.Location = New Point(190, 625)
            Label2.Visible = True
            Label2.Location = New Point(220, 625)
            Label3.Visible = True
            Label3.Location = New Point(250, 625)
            Label4.Visible = True
            Label4.Location = New Point(280, 625)
            Label5.Visible = True
            Label5.Location = New Point(310, 625)
            Label6.Visible = True
            Label6.Location = New Point(340, 625)
        ElseIf (palabra.Length = 8) Then
            Label1.Visible = True
            Label1.Location = New Point(170, 625)
            Label2.Visible = True
            Label2.Location = New Point(200, 625)
            Label3.Visible = True
            Label3.Location = New Point(230, 625)
            Label4.Visible = True
            Label4.Location = New Point(260, 625)
            Label5.Visible = True
            Label5.Location = New Point(290, 625)
            Label6.Visible = True
            Label6.Location = New Point(320, 625)
            Label7.Visible = True
            Label7.Location = New Point(350, 625)
        ElseIf (palabra.Length = 9) Then
            Label1.Visible = True
            Label1.Location = New Point(150, 625)
            Label2.Visible = True
            Label2.Location = New Point(180, 625)
            Label3.Visible = True
            Label3.Location = New Point(210, 625)
            Label4.Visible = True
            Label4.Location = New Point(240, 625)
            Label5.Visible = True
            Label5.Location = New Point(270, 625)
            Label6.Visible = True
            Label6.Location = New Point(300, 625)
            Label7.Visible = True
            Label7.Location = New Point(330, 625)
            Label8.Visible = True
            Label8.Location = New Point(360, 625)
        ElseIf (palabra.Length = 10) Then
            Label1.Visible = True
            Label1.Location = New Point(130, 625)
            Label2.Visible = True
            Label2.Location = New Point(160, 625)
            Label3.Visible = True
            Label3.Location = New Point(190, 625)
            Label4.Visible = True
            Label4.Location = New Point(220, 625)
            Label5.Visible = True
            Label5.Location = New Point(250, 625)
            Label6.Visible = True
            Label6.Location = New Point(280, 625)
            Label7.Visible = True
            Label7.Location = New Point(310, 625)
            Label8.Visible = True
            Label8.Location = New Point(340, 625)
            Label9.Visible = True
            Label9.Location = New Point(370, 625)
        ElseIf (palabra.Length = 11) Then
            Label1.Visible = True
            Label1.Location = New Point(120, 625)
            Label2.Visible = True
            Label2.Location = New Point(150, 625)
            Label3.Visible = True
            Label3.Location = New Point(180, 625)
            Label4.Visible = True
            Label4.Location = New Point(210, 625)
            Label5.Visible = True
            Label5.Location = New Point(240, 625)
            Label6.Visible = True
            Label6.Location = New Point(270, 625)
            Label7.Visible = True
            Label7.Location = New Point(300, 625)
            Label8.Visible = True
            Label8.Location = New Point(330, 625)
            Label9.Visible = True
            Label9.Location = New Point(360, 625)
            Label10.Visible = True
            Label10.Location = New Point(390, 625)
        ElseIf (palabra.Length = 12) Then
            Label1.Visible = True
            Label1.Location = New Point(100, 625)
            Label2.Visible = True
            Label2.Location = New Point(130, 625)
            Label3.Visible = True
            Label3.Location = New Point(160, 625)
            Label4.Visible = True
            Label4.Location = New Point(190, 625)
            Label5.Visible = True
            Label5.Location = New Point(220, 625)
            Label6.Visible = True
            Label6.Location = New Point(250, 625)
            Label7.Visible = True
            Label7.Location = New Point(280, 625)
            Label8.Visible = True
            Label8.Location = New Point(310, 625)
            Label9.Visible = True
            Label9.Location = New Point(340, 625)
            Label10.Visible = True
            Label10.Location = New Point(370, 625)
            Label11.Visible = True
            Label11.Location = New Point(400, 625)
        ElseIf (palabra.Length = 13) Then
            Label1.Visible = True
            Label1.Location = New Point(90, 625)
            Label2.Visible = True
            Label2.Location = New Point(120, 625)
            Label3.Visible = True
            Label3.Location = New Point(150, 625)
            Label4.Visible = True
            Label4.Location = New Point(180, 625)
            Label5.Visible = True
            Label5.Location = New Point(210, 625)
            Label6.Visible = True
            Label6.Location = New Point(240, 625)
            Label7.Visible = True
            Label7.Location = New Point(270, 625)
            Label8.Visible = True
            Label8.Location = New Point(300, 625)
            Label9.Visible = True
            Label9.Location = New Point(330, 625)
            Label10.Visible = True
            Label10.Location = New Point(360, 625)
            Label11.Visible = True
            Label11.Location = New Point(390, 625)
            Label12.Visible = True
            Label12.Location = New Point(420, 625)
        End If
    End Sub

    Private Sub reiniciar_Click(sender As Object, e As System.EventArgs) Handles boton_reiniciar.Click
        Dim respuesta
        respuesta = MsgBox("Perderás tu progreso, ¿Deseas reiniciar la partida?", MsgBoxStyle.YesNo)

        If (respuesta = vbYes) Then
            letra_repetida = 0
            errores = 0
            puntaje = 0
            aciertos = 0
            letras = ""
            Label_score.Text = "Puntaje: " & puntaje
            num = Aleatorio(0, diccionario.length())
            palabra = diccionario(num)

            PictureBox1.Visible = False
            Label1.Visible = False
            Label1.Text = "_"
            Label2.Visible = False
            Label2.Text = "_"
            Label3.Visible = False
            Label3.Text = "_"
            Label4.Visible = False
            Label4.Text = "_"
            Label5.Visible = False
            Label5.Text = "_"
            Label6.Visible = False
            Label6.Text = "_"
            Label7.Visible = False
            Label7.Text = "_"
            Label8.Visible = False
            Label8.Text = "_"
            Label9.Visible = False
            Label9.Text = "_"
            Label10.Visible = False
            Label10.Text = "_"
            Label11.Visible = False
            Label11.Text = "_"
            Label12.Visible = False
            Label12.Text = "_"

            colocar_espacios(palabra.Length)

        End If
    End Sub

    Private Sub boton_siguiente_Click(sender As Object, e As System.EventArgs) Handles boton_siguiente.Click

        If (Form1.dificultad = "Normal") Then
            errores = 0
            PictureBox1.Visible = False

        Else

            errores -= 5

            If (errores <= 0) Then
                errores = 0
                PictureBox1.Visible = False
            ElseIf (errores = 1) Then
                PictureBox1.Image = My.Resources._1
            ElseIf (errores = 2) Then
                PictureBox1.Image = My.Resources._2
            ElseIf (errores = 3) Then
                PictureBox1.Image = My.Resources._3
            ElseIf (errores = 4) Then
                PictureBox1.Image = My.Resources._4
            End If

        End If

        num = Aleatorio(0, diccionario.length())
        palabra = diccionario(num)
        letras = ""
        aciertos = 0
        letra_repetida = 0

        Label1.Text = "_"
        Label1.Visible = False
        Label2.Text = "_"
        Label2.Visible = False
        Label3.Text = "_"
        Label3.Visible = False
        Label4.Text = "_"
        Label4.Visible = False
        Label5.Text = "_"
        Label5.Visible = False
        Label6.Text = "_"
        Label6.Visible = False
        Label7.Text = "_"
        Label7.Visible = False
        Label8.Text = "_"
        Label8.Visible = False
        Label9.Text = "_"
        Label9.Visible = False
        Label10.Text = "_"
        Label10.Visible = False
        Label11.Text = "_"
        Label11.Visible = False
        Label12.Text = "_"
        Label12.Visible = False

        boton_siguiente.Enabled = False
        boton_reiniciar.Enabled = True
        boton_reiniciar.Focus()
        colocar_espacios(palabra.Length)
    End Sub

    Private Sub boton_salir_Click(sender As Object, e As System.EventArgs) Handles boton_salir.Click
        Dim respuesta
        respuesta = MsgBox("Perderás tu progreso, ¿Deseas regresar al menú principal?", MsgBoxStyle.YesNo)

        If (respuesta = vbYes) Then
            Me.Close()
            Form1.Visible = True
        Else
            boton_reiniciar.Focus()
        End If
    End Sub

    Private Sub verificar_palabra()
        If (aciertos = palabra.Length - 1) Then
            puntaje += 10
            Label_score.Text = "Puntaje: " & puntaje
            MsgBox("¡Felicidades has adivinado la palabra, ahora puedes continuar al siguiente nivel!")
            boton_reiniciar.Enabled = False
            boton_siguiente.Enabled = True
            boton_siguiente.Focus()
        End If
    End Sub

    Private Sub verificar_errores(ByRef e As Windows.Forms.KeyPressEventArgs)

        If (Asc(e.KeyChar) = 32) Then
            'Evita que si el jugador ingresa un espacio el juego lo tome como un error 
        ElseIf (errores = 0) Then
            errores += 1
            PictureBox1.Show()
            PictureBox1.Image = My.Resources._1
        ElseIf (errores = 1) Then
            PictureBox1.Visible = True
            errores += 1
            PictureBox1.Show()
            PictureBox1.Image = My.Resources._2
        ElseIf (errores = 2) Then
            PictureBox1.Visible = True
            errores += 1
            PictureBox1.Show()
            PictureBox1.Image = My.Resources._3
        ElseIf (errores = 3) Then
            PictureBox1.Visible = True
            errores += 1
            PictureBox1.Image = My.Resources._4
        ElseIf (errores = 4) Then
            errores += 1
            PictureBox1.Image = My.Resources._5
        ElseIf (errores = 5) Then
            errores += 1
            PictureBox1.Image = My.Resources._6_1
        ElseIf (errores = 6) Then
            errores += 1
            PictureBox1.Image = My.Resources._7_1
        ElseIf (errores = 7) Then
            errores += 1
            PictureBox1.Image = My.Resources._8_1
        ElseIf (errores = 8) Then
            errores += 1
            PictureBox1.Image = My.Resources._9
        ElseIf (errores = 9) Then
            PictureBox1.Image = My.Resources._10

            Dim respuesta
            UCase(palabra.Chars(0))
            respuesta = MsgBox(Form1.nombre & " has perdido, tu puntaje es: " & puntaje & vbCrLf & "La palabra era " & palabra.Trim & ", ¿Quieres jugar otra vez?", MsgBoxStyle.YesNo)

            If (respuesta = vbYes) Then
                letra_repetida = 0
                errores = 0
                aciertos = 0
                puntaje = 0
                Label_score.Text = "Puntaje: " & puntaje
                letras = ""
                num = Aleatorio(0, diccionario.length())
                palabra = diccionario(num)

                PictureBox1.Visible = False
                Label1.Visible = False
                Label1.Text = "_"
                Label2.Visible = False
                Label2.Text = "_"
                Label3.Visible = False
                Label3.Text = "_"
                Label4.Visible = False
                Label4.Text = "_"
                Label5.Visible = False
                Label5.Text = "_"
                Label6.Visible = False
                Label6.Text = "_"
                Label7.Visible = False
                Label7.Text = "_"
                Label8.Visible = False
                Label8.Text = "_"
                Label9.Visible = False
                Label9.Text = "_"
                Label10.Visible = False
                Label10.Text = "_"
                Label11.Visible = False
                Label11.Text = "_"
                Label12.Visible = False
                Label12.Text = "_"

                colocar_espacios(palabra.Length)
            Else
                Me.Close()
                Form1.Visible = True
            End If
        End If

    End Sub

    Private Function verificar_repeticion(ByRef e As Windows.Forms.KeyPressEventArgs)
        'Verifica si el usuario ha ingresado una letra más de una vez
        letra_repetida = 0

        If (Asc(e.KeyChar) = 32) Then
            'Evita que el jugador ingrese espacios en blanco
        Else
            letras += e.KeyChar & " "

            For contador As Integer = 0 To letras.Length - 1

                If (e.KeyChar = letras.Chars(contador)) Then

                    letra_repetida += 1
                    verificar_palabra()

                    If (letra_repetida > 1) Then
                        Return True
                    End If

                End If

            Next contador

            letras.Trim(" ")

        End If
    End Function

    Private Sub boton_reiniciar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles boton_reiniciar.KeyPress
        solo_letras(e)

        'Esto verifica si la letra ingresada por el usuario coincide con alguna letra de la palabra secreta
        'Dentro de cada if verifica dos veces si la letra ingresada se repite en la palabra secreta para mostrarla en la interfaz
        If (verificar_repeticion(e) = True) Then
            MsgBox("Ya has ingresado la letra " & e.KeyChar)
        Else

            If (palabra.Length = 6) Then
                If (e.KeyChar = palabra.Chars(0)) Then
                    Label1.Text = UCase(e.KeyChar)
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(1)) Then
                        Label2.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(2)) Then
                            Label3.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(1)) Then
                    Label2.Text = e.KeyChar
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(2)) Then
                    Label3.Text = e.KeyChar
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(3)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(3)) Then
                    Label4.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(4)) Then
                    Label5.Text = e.KeyChar
                    aciertos += 1

                    verificar_palabra()

                Else
                    verificar_errores(e)
                End If

            ElseIf (palabra.Length = 7) Then
                If (e.KeyChar = palabra.Chars(0)) Then
                    Label1.Text = UCase(e.KeyChar)
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(1)) Then
                        Label2.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(2)) Then
                            Label3.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(1)) Then
                    Label2.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(2)) Then
                    Label3.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(3)) Then
                    Label4.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(4)) Then
                    Label5.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(5)) Then
                    Label6.Text = e.KeyChar
                    aciertos += 1

                    verificar_palabra()

                Else
                    verificar_errores(e)
                End If

            ElseIf (palabra.Length = 8) Then
                If (e.KeyChar = palabra.Chars(0)) Then
                    Label1.Text = UCase(e.KeyChar)
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(1)) Then
                        Label2.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(2)) Then
                            Label3.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(1)) Then
                    Label2.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(2)) Then
                    Label3.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(3)) Then
                    Label4.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(4)) Then
                    Label5.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(5)) Then
                    Label6.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(6)) Then
                    Label7.Text = e.KeyChar
                    aciertos += 1

                    verificar_palabra()

                Else
                    verificar_errores(e)
                End If

            ElseIf (palabra.Length = 9) Then
                If (e.KeyChar = palabra.Chars(0)) Then
                    Label1.Text = UCase(e.KeyChar)
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(1)) Then
                        Label2.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(2)) Then
                            Label3.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(1)) Then
                    Label2.Text = e.KeyChar
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(2)) Then
                    Label3.Text = e.KeyChar
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(3)) Then
                    Label4.Text = e.KeyChar
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(4)) Then
                    Label5.Text = e.KeyChar
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(5)) Then
                    Label6.Text = e.KeyChar
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(6)) Then
                    Label7.Text = e.KeyChar
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(7)) Then
                    Label8.Text = e.KeyChar
                    aciertos += 1

                    verificar_palabra()

                Else
                    verificar_errores(e)
                End If

            ElseIf (palabra.Length = 10) Then
                If (e.KeyChar = palabra.Chars(0)) Then
                    Label1.Text = UCase(e.KeyChar)
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(1)) Then
                        Label2.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(2)) Then
                            Label3.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(1)) Then
                    Label2.Text = e.KeyChar
                    aciertos += 1

                    If (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1

                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(2)) Then
                    Label3.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If

                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(3)) Then
                    Label4.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(4)) Then
                    Label5.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(5)) Then
                    Label6.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(6)) Then
                    Label7.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(7)) Then
                    Label8.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(8)) Then
                    Label9.Text = e.KeyChar
                    aciertos += 1

                    verificar_palabra()

                Else
                    verificar_errores(e)
                End If

            ElseIf (palabra.Length = 11) Then
                If (e.KeyChar = palabra.Chars(0)) Then
                    Label1.Text = UCase(e.KeyChar)
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(1)) Then
                        Label2.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(2)) Then
                            Label3.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(1)) Then
                    Label2.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(2)) Then
                    Label3.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(3)) Then
                    Label4.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(4)) Then
                    Label5.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(5)) Then
                    Label6.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(6)) Then
                    Label7.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(7)) Then
                    Label8.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(8)) Then
                    Label9.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(9)) Then
                    Label10.Text = e.KeyChar
                    aciertos += 1

                    verificar_palabra()

                Else
                    verificar_errores(e)
                End If

            ElseIf (palabra.Length = 12) Then
                If (e.KeyChar = palabra.Chars(0)) Then
                    Label1.Text = UCase(e.KeyChar)
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(1)) Then
                        Label2.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(2)) Then
                            Label3.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(1)) Then
                    Label2.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(2)) Then
                    Label3.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(3)) Then
                    Label4.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(4)) Then
                    Label5.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(5)) Then
                    Label6.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(6)) Then
                    Label7.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(7)) Then
                    Label8.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(8)) Then
                    Label9.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(9)) Then
                    Label10.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(10)) Then
                    Label11.Text = e.KeyChar
                    aciertos += 1

                    verificar_palabra()

                Else
                    verificar_errores(e)
                End If

            ElseIf (palabra.Length = 13) Then
                If (e.KeyChar = palabra.Chars(0)) Then
                    Label1.Text = UCase(e.KeyChar)
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(1)) Then
                        Label2.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(2)) Then
                            Label3.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(1)) Then
                    Label2.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(2)) Then
                        Label3.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(3)) Then
                            Label4.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(2)) Then
                    Label3.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(3)) Then
                        Label4.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(4)) Then
                            Label5.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(3)) Then
                    Label4.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(4)) Then
                        Label5.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(5)) Then
                            Label6.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(4)) Then
                    Label5.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(5)) Then
                        Label6.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(6)) Then
                            Label7.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(5)) Then
                    Label6.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(6)) Then
                        Label7.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(7)) Then
                            Label8.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(6)) Then
                    Label7.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(7)) Then
                        Label8.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(8)) Then
                            Label9.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(7)) Then
                    Label8.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(8)) Then
                        Label9.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(9)) Then
                            Label10.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(8)) Then
                    Label9.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(9)) Then
                        Label10.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(10)) Then
                            Label11.Text = e.KeyChar
                            aciertos += 1
                        ElseIf (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(9)) Then
                    Label10.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(10)) Then
                        Label11.Text = e.KeyChar
                        aciertos += 1
                        If (e.KeyChar = palabra.Chars(11)) Then
                            Label12.Text = e.KeyChar
                            aciertos += 1
                        End If
                    ElseIf (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(10)) Then
                    Label11.Text = e.KeyChar
                    aciertos += 1
                    If (e.KeyChar = palabra.Chars(11)) Then
                        Label12.Text = e.KeyChar
                        aciertos += 1
                    End If

                    verificar_palabra()

                ElseIf (e.KeyChar = palabra.Chars(11)) Then
                    Label12.Text = e.KeyChar
                    aciertos += 1

                    verificar_palabra()

                Else
                    verificar_errores(e)
                End If
            End If
        End If
    End Sub
End Class