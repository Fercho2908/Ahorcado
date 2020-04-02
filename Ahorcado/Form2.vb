﻿Public Class Form2

    Public diccionario = New String() {"aguja ", "alambre ", "arete ", "bolsa ", "bandera ", "bufanda ", "carpeta ", "caramelo ", "cascanueces ", "diamante ", "dibujo ", "diente ", "empaque ", "etiqueta ", "esfera ", "filtro ", "florero ", "fuente ", "guante ", "globo ", "galleta ", "helado ", "hiedra ", "harmonica ", "incienso ", "interruptor ", "impresora ", "jarron ", "jabon ", "jirafa ", "lingote ", "linterna ", "lonchera ", "mostaza ", "marioneta ", "malvavisco ", "nomenclatura ", "nispero ", "nebulosa ", "ornamento ", "ocarina ", "ordenador ", "platillo ", "pelicula ", "pulgada ", "regalo ", "radio ", "resorte ", "sujetador ", "servilleta ", "sierra ", "temporizador ", "terciopelo ", "trompeta ", "ukelele ", "unidad ", "vainilla ", "vinagre ", "violin ", "xilofono ", "yogurt ", "yacimiento ", "yunque ", "zafiro ", "zanahoria ", "zapato ", "cebra ", "tucan ", "rinoceronte ", "cangrejo ", "delfin ", "pantera ", "tigre ", "koala ", "tortuga ", "mueble ", "murcielago ", "mapache ", "colibri ", "orangutan ", "caballo ", "elefante ", "raton ", "gallina ", "conejo ", "ciervo ", "coyote ", "lagarto ", "serpiente ", "hipopotamo ", "oveja ", "ardilla ", "aguila ", "escorpion ", "armadillo ", "hiena ", "alcon ", "camello ", "cocodrilo ", "araña ", "abeja ", "hormiga ", "insecto ", "animal ", "guacamayo ", "caracol ", "ornitorrinco ", "ballena ", "tiburon ", "camaron ", "gorila ", "cisne ", "flamenco ", "mariposa ", "nutria ", "paloma ", "buitre ", "cable ", "televisor ", "bosque ", "leche ", "universidad ", "computadora ", "cocina ", "plato ", "telefono ", "cargador ", "teclado ", "papelera ", "camioneta ", "ceramica ", "estante ", "nevera ", "revista ", "deporte ", "pintura ", "musica ", "cancion ", "titulo ", "almohada ", "madera ", "jungla ", "montaña ", "barranco ", "cascada ", "oceano ", "continente ", "naturaleza ", "cuchillo ", "tormenta ", "perro ", "burro ", "zorro "}
    'Nota: Cada palabra tiene un espacio al final ya que al realizar cualquier operación con la propiedad .Chars de un String, arroja el error System.IndexOutOfRangeException al llegar al limite de la longitud de la cadena de texto
    Public num As Integer = Aleatorio(0, diccionario.length())
    Public letra_repetida, errores, puntaje, aciertos As Integer
    Public palabra As String = diccionario(num)
    Public letras As String = ""
    Dim secuencia_alt_f4 As Boolean

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        boton_reiniciar.Focus()
        Colocar_espacios(palabra.Length)
        MsgBox(palabra)
    End Sub

    Private Sub Boton_reiniciar_KeyDown(sender As Object, e As KeyEventArgs) Handles boton_reiniciar.KeyDown
        'Detecta la combinación de teclas Alt + F4
        If (e.Alt And e.KeyCode = Keys.F4) Then
            secuencia_alt_f4 = True
            MsgBox("Para cerrar el programa debes volver al menú principal")
        Else
            secuencia_alt_f4 = False
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Evita que el programa se cierre con Alt + F4
        e.Cancel = secuencia_alt_f4
        secuencia_alt_f4 = False
    End Sub

    Private Sub Reiniciar_Click(sender As Object, e As EventArgs) Handles boton_reiniciar.Click
        Dim respuesta
        respuesta = MsgBox("Perderás tu progreso, ¿Deseas reiniciar la partida?", MsgBoxStyle.YesNo)

        If (respuesta = vbYes) Then
            Reiniciar_juego()
        End If
    End Sub

    Private Sub Boton_siguiente_Click(sender As Object, e As EventArgs) Handles boton_siguiente.Click
        Siguiente_nivel()
    End Sub

    Private Sub Boton_salir_Click(sender As Object, e As EventArgs) Handles boton_salir.Click
        Dim respuesta
        respuesta = MsgBox("Perderás tu progreso, ¿Deseas regresar al menú principal?", MsgBoxStyle.YesNo)

        If (respuesta = vbYes) Then
            Me.Close()
            Form1.Visible = True
        Else
            boton_reiniciar.Focus()
        End If
    End Sub

    Private Sub Boton_reiniciar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles boton_reiniciar.KeyPress
        Solo_letras(e)

        'Esto verifica si la letra ingresada por el usuario coincide con alguna letra de la palabra secreta
        If funciones.Verificar_repeticion(e) And Char.IsLetter(e.KeyChar) Then
            MsgBox("Ya has ingresado la letra " & e.KeyChar)
        Else

            Ingresar_letra(e)

            If (letra_correcta = True) Then
                funciones.Verificar_palabra()
            Else
                Verificar_errores(e)
            End If

        End If
    End Sub
End Class