Public Class Form1
    Public Shared nombre, dificultad As String
    Dim borrar, posicion_x, posicion_y As Integer
    Dim arrastre As Boolean

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        posicion_x = e.X
        posicion_y = e.Y
        arrastre = True
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        arrastre = False
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If (arrastre) Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - posicion_x, Me.MousePosition.Y - Me.Location.Y - posicion_y))
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        borrar = 0
        nombre = ""
        PictureBox1.Visible = False

        If (RadioButton1.Checked) Then
            dificultad = RadioButton1.Text
        Else
            dificultad = RadioButton2.Text
        End If

        If (Label1.Text.Equals("_")) Then
            MsgBox("Debes ingresar tu nombre")
        Else

            nombre = Label1.Text
            nombre += Label2.Text
            nombre += Label3.Text
            nombre += Label4.Text
            nombre += Label5.Text
            nombre += Label6.Text
            nombre += Label7.Text
            nombre += Label8.Text

            For i As Integer = 0 To nombre.Length
                If (nombre.EndsWith("_")) Then
                    nombre = nombre.TrimEnd("_")
                End If
            Next

            Label1.Text = "_"
            Label2.Text = "_"
            Label3.Text = "_"
            Label4.Text = "_"
            Label5.Text = "_"
            Label6.Text = "_"
            Label7.Text = "_"
            Label8.Text = "_"

            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Public Sub solo_letras(ByRef e As Windows.Forms.KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo puedes ingresar letras")
        End If
    End Sub

    Public Sub borrar_caracter()

        If (Char.IsLetter(Label8.Text)) Then
            Label8.Text = "_"
        ElseIf (Char.IsLetter(Label7.Text)) Then
            Label7.Text = "_"
        ElseIf (Char.IsLetter(Label6.Text)) Then
            Label6.Text = "_"
        ElseIf (Char.IsLetter(Label5.Text)) Then
            Label5.Text = "_"
        ElseIf (Char.IsLetter(Label4.Text)) Then
            Label4.Text = "_"
        ElseIf (Char.IsLetter(Label3.Text)) Then
            Label3.Text = "_"
        ElseIf (Char.IsLetter(Label2.Text)) Then
            Label2.Text = "_"
        ElseIf (Char.IsLetter(Label1.Text)) Then
            Label1.Text = "_"
        End If

        If (borrar = 0) Then
            borrar += 1
            PictureBox1.Image = My.Resources._1
            PictureBox1.Visible = True
        ElseIf (borrar = 1) Then
            borrar += 1
            PictureBox1.Image = My.Resources._2
        ElseIf (borrar = 2) Then
            borrar += 1
            PictureBox1.Image = My.Resources._3
        ElseIf (borrar = 3) Then
            borrar += 1
            PictureBox1.Image = My.Resources._4
        ElseIf (borrar = 4) Then
            borrar += 1
            PictureBox1.Image = My.Resources._5
        ElseIf (borrar = 5) Then
            borrar += 1
            PictureBox1.Image = My.Resources._6_1
        ElseIf (borrar = 6) Then
            borrar += 1
            PictureBox1.Image = My.Resources._7_1
        ElseIf (borrar = 7) Then
            borrar += 1
            PictureBox1.Image = My.Resources._8_1
        ElseIf (borrar = 8) Then
            borrar += 1
            PictureBox1.Image = My.Resources._9
        ElseIf (borrar = 9) Then
            PictureBox1.Image = My.Resources._10

            Dim respuesta = MsgBox("No has empezado la partida y ya andas perdiendo, ¿Seguro que quieres jugar?", MsgBoxStyle.YesNo)

            If (respuesta = vbYes) Then
                MsgBox("Dele campeón", MsgBoxStyle.OkOnly)
            Else
                Me.Close()
            End If
        End If
    End Sub

    Public Sub Escribir(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        solo_letras(e)

        If (Label1.Text.Equals("_") And Char.IsLetter(e.KeyChar)) Then
            Label1.Text = UCase(e.KeyChar)
        ElseIf (Label2.Text.Equals("_") And Char.IsLetter(e.KeyChar)) Then
            Label2.Text = e.KeyChar
        ElseIf (Label3.Text.Equals("_") And Char.IsLetter(e.KeyChar)) Then
            Label3.Text = e.KeyChar
        ElseIf (Label4.Text.Equals("_") And Char.IsLetter(e.KeyChar)) Then
            Label4.Text = e.KeyChar
        ElseIf (Label5.Text.Equals("_") And Char.IsLetter(e.KeyChar)) Then
            Label5.Text = e.KeyChar
        ElseIf (Label6.Text.Equals("_") And Char.IsLetter(e.KeyChar)) Then
            Label6.Text = e.KeyChar
        ElseIf (Label7.Text.Equals("_") And Char.IsLetter(e.KeyChar)) Then
            Label7.Text = e.KeyChar
        ElseIf (Label8.Text.Equals("_") And Char.IsLetter(e.KeyChar)) Then
            Label8.Text = e.KeyChar
        ElseIf (Asc(e.KeyChar) = 8) Then

            If (Char.IsLetter(Label1.Text)) Then
                borrar_caracter()
            End If
        End If
    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Button1.KeyPress
        escribir(e)
    End Sub

    Private Sub RadioButton1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton1.KeyPress
        escribir(e)
    End Sub

    Private Sub RadioButton2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton2.KeyPress
        Escribir(e)
    End Sub

    Private Sub boton_cerrar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles boton_cerrar.KeyPress
        Escribir(e)
    End Sub

    Private Sub boton_min_KeyPress(sender As Object, e As KeyPressEventArgs) Handles boton_min.KeyPress
        Escribir(e)
    End Sub

    Private Sub boton_cerrar_Click(sender As Object, e As EventArgs) Handles boton_cerrar.Click
        Application.Exit()
    End Sub

    Private Sub boton_min_Click(sender As Object, e As EventArgs) Handles boton_min.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MsgBox("                                           ¡Bienvenido!" & vbCrLf & "Presiona 'Aceptar' e ingresa tu nombre para iniciar el juego.", MsgBoxStyle.OkOnly)
        Button1.Focus()
        RadioButton1.Select()
    End Sub
End Class