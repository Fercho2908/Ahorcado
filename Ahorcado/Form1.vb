Public Class Form1
    Public Shared nombre, dificultad As String
    Dim borrar As Integer = 0

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        borrar = 0
        PictureBox1.Visible = False

        If (RadioButton1.Checked) Then
            dificultad = RadioButton1.Text
        Else
            dificultad = RadioButton2.Text
        End If

        If (Label1.Text.Equals("_")) Then
            MsgBox("Debes ingresar tu nombre")
        ElseIf (Label4.Text.Equals("_")) Then

            nombre = ""
            nombre += Label1.Text
            nombre += Label2.Text
            nombre += Label3.Text

            Dim respuesta
            respuesta = MsgBox("¿Tu nombre es " & nombre & "?", vbYesNo)

            If (respuesta = vbYes) Then
                Me.Hide()
                Form2.Show()
                Label1.Text = "_"
                Label2.Text = "_"
                Label3.Text = "_"
            Else
                MsgBox("Por favor, introduce tu nombre correctamente")
            End If

        Else
            nombre = ""

            If (Char.IsLetter(Label8.Text)) Then
                nombre += Label1.Text
                nombre += Label2.Text
                nombre += Label3.Text
                nombre += Label4.Text
                nombre += Label5.Text
                nombre += Label6.Text
                nombre += Label7.Text
                nombre += Label8.Text
            ElseIf (Char.IsLetter(Label7.Text)) Then
                nombre += Label1.Text
                nombre += Label2.Text
                nombre += Label3.Text
                nombre += Label4.Text
                nombre += Label5.Text
                nombre += Label6.Text
                nombre += Label7.Text
            ElseIf (Char.IsLetter(Label6.Text)) Then
                nombre += Label1.Text
                nombre += Label2.Text
                nombre += Label3.Text
                nombre += Label4.Text
                nombre += Label5.Text
                nombre += Label6.Text
            ElseIf (Char.IsLetter(Label5.Text)) Then
                nombre += Label1.Text
                nombre += Label2.Text
                nombre += Label3.Text
                nombre += Label4.Text
                nombre += Label5.Text
            ElseIf (Char.IsLetter(Label4.Text)) Then
                nombre += Label1.Text
                nombre += Label2.Text
                nombre += Label3.Text
                nombre += Label4.Text
            End If

            Form2.Show()
            Me.Hide()

            Label1.Text = "_"
            Label2.Text = "_"
            Label3.Text = "_"
            Label4.Text = "_"
            Label5.Text = "_"
            Label6.Text = "_"
            Label7.Text = "_"
            Label8.Text = "_"
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

            borrar_caracter()

        End If
    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Button1.KeyPress
        escribir(e)
    End Sub

    Private Sub RadioButton1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton1.KeyPress
        escribir(e)
    End Sub

    Private Sub RadioButton2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton2.KeyPress
        escribir(e)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MsgBox("Bienvenido, por favor ingresa tu nombre", MsgBoxStyle.OkOnly)
        Button1.Focus()
        RadioButton1.Select()
    End Sub
End Class