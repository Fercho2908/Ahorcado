Public Class Form3
    Dim posicion_x, posicion_y As Integer
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

    Private Sub boton_volver_KeyDown(sender As Object, e As KeyEventArgs) Handles boton_volver.KeyDown
        'Detecta la combinación de teclas Alt + F4
        If (e.Alt And e.KeyCode = Keys.F4) Then
            Application.Exit()
        End If
    End Sub

    Private Sub boton_cerrar_KeyDown(sender As Object, e As KeyEventArgs) Handles boton_cerrar.KeyDown
        'Detecta la combinación de teclas Alt + F4
        If (e.Alt And e.KeyCode = Keys.F4) Then
            Application.Exit()
        End If
    End Sub

    Private Sub boton_min_KeyDown(sender As Object, e As KeyEventArgs) Handles boton_min.KeyDown
        'Detecta la combinación de teclas Alt + F4
        If (e.Alt And e.KeyCode = Keys.F4) Then
            Application.Exit()
        End If
    End Sub

    Private Sub boton_cerrar_Click(sender As Object, e As EventArgs) Handles boton_cerrar.Click
        Application.Exit()
    End Sub

    Private Sub boton_volver_Click(sender As Object, e As EventArgs) Handles boton_volver.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub boton_min_Click(sender As Object, e As EventArgs) Handles boton_min.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Public Sub Cargar_puntajes()
        Dim da As New OleDb.OleDbDataAdapter("select * form ", db_funciones.Conexion)
        Dim ds As New DataSet
        da.Fill(ds)

        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        db_funciones.Conectar()
        Cargar_puntajes()
    End Sub
End Class