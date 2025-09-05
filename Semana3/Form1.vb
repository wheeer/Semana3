Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbOperaciones.Items.Add("Sumar")
        cbOperaciones.Items.Add("Restar")
        cbOperaciones.Items.Add("Multiplicar")
        cbOperaciones.Items.Add("Dividir")
        cbOperaciones.SelectedIndex = 0
    End Sub
    Private Sub btCalcular_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        EjecutarOperacion()
    End Sub

    Private Sub EjecutarOperacion()
        Dim num1, num2, resultado As Double
        num1 = Convert.ToDouble(tbNum1.Text)
        num2 = Convert.ToDouble(tbNum2.Text)
        Select Case cbOperaciones.SelectedItem.ToString()
            Case "Sumar"
                resultado = num1 + num2
            Case "Restar"
                resultado = num1 - num2
            Case "Multiplicar"
                resultado = num1 * num2
            Case "Dividir"
                If num2 <> 0 Then
                    resultado = num1 / num2
                Else
                    MessageBox.Show("No se puede dividir por cero.")
                    Return
                End If
            Case Else
                MessageBox.Show("Operación no válida.")
                Return
        End Select
        lbResul.Text = "Resultado: " & resultado.ToString()
    End Sub
End Class
