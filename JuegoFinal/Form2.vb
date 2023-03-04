Public Class Form2
#Region "Boton"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese nombre del personaje")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Ingrese una contraseña")
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then
            MsgBox("Elige un tipo de personaje")
        End If
        If TextBox1.Text <> "" And TextBox2.Text <> "" And RadioButton1.Checked = True Or RadioButton2.Checked = True Or RadioButton3.Checked = True Or RadioButton4.Checked = True Then
            Call Form1.activar()
            Close()
        End If
    End Sub
#End Region

#Region "Inicio"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub
#End Region

#Region "Text Box"
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call Form1.Nombre_Caracteres(TextBox1.Text)
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
#End Region

#Region "Radio Buttons"

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Call Form1.imagen(4)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Call Form1.imagen(2)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Call Form1.imagen(3)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Call Form1.imagen(1)
    End Sub

#End Region


End Class