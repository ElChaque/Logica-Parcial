Public Class FrmLote
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmMain.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FrmLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextMtAncho.TextChanged
        If Not IsNumeric(TextMtAncho.Text) Then
            TextMtAncho.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim LoteAncho As Decimal, LoteLargo As Decimal, Mt2Lote As Decimal
        LoteAncho = Val(TextMtAncho.Text)
        LoteLargo = Val(TextMtLargo.Text)
        Mt2Lote = LoteAncho * LoteLargo
        TextResultadoLote.Text = Mt2Lote.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextMtAncho.Text = ""
        TextMtLargo.Text = ""
        TextResultadoLote.Text = ""
    End Sub

    Private Sub TextMtLargo_TextChanged(sender As Object, e As EventArgs) Handles TextMtLargo.TextChanged
        If Not IsNumeric(TextMtLargo.Text) Then
            TextMtLargo.Text = ""
        End If
    End Sub

    Private Sub TextResultadoLote_TextChanged(sender As Object, e As EventArgs) Handles TextResultadoLote.TextChanged
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class