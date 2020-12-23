Public Class Form1
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim seleccionado As String = ""
        Dim seleccionado2 As String = ""
        If RadioButtonHombre.Checked = True Then
            seleccionado = seleccionado + " Hombre "
        ElseIf RadioButtonMujer.Checked = True Then
            seleccionado = seleccionado + " Mujer "
        End If
        If RadioButtonMayor.Checked = True Then
            seleccionado2 = seleccionado2 + " Mayor "
        ElseIf RadioButtonMenor.Checked = True Then
            seleccionado2 = seleccionado2 + " Menor "
        End If
        MessageBox.Show(seleccionado + seleccionado2, "Hola")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RadioButtonHombre.Checked = True
        Me.RadioButtonMayor.Checked = True

    End Sub
End Class
