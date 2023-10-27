Imports System.ComponentModel

Public Class FrmLoguin
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PasswTxt.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UserTxt.TextChanged

    End Sub

    Private Sub BtnAccess_Click(sender As Object, e As EventArgs) Handles BtnAccess.Click
        If UserTxt.Text = "izo" And PasswTxt.Text = "123" Then
            FrmMain.Show()
            Me.Close()
        Else
            MsgBox("Contraseña incorrecta, vuelve a intentar")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub FrmLoguin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
