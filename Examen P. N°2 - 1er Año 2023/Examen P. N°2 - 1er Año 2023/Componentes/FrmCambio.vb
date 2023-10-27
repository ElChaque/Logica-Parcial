Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmCambio
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMain.Show()
        Me.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles BoxTotalCalculado.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtCotizacion.TextChanged
        If Not IsNumeric(TxtCotizacion.Text) Then
            TxtCotizacion.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDolarCompra.Click
        Dim CotizacionDolar As Double
        Dim CompraDolar As Double
        Dim ResultadoTotal As Double
        CotizacionDolar = Val(TxtCotizacion.Text)
        CompraDolar = Val(TxtDolarCompra.Text)
        ResultadoTotal = CotizacionDolar * CompraDolar
        BoxTotalCalculado.Text = ResultadoTotal.ToString("0.00")

        Dim operacion As String = $"Cotizacion del dolar a: $ {CotizacionDolar} Pesos Arg.| Dolar a comprar: $ {CompraDolar} Dolar.| con un importe total de: $ {ResultadoTotal} Pesos Arg.|"
        Dim filePath As String = "C:\Users\AlanA\source\repos\Examen P. N°2 - 1er Año 2023\Examen P. N°2 - 1er Año 2023\HISTORIAL.txt"
        Using sw As New System.IO.StreamWriter(filePath, True)
            sw.WriteLine(operacion)
        End Using

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPesoCom_Click(sender As Object, e As EventArgs)
        Dim CotizacionDolar As Decimal, CompraPesoArg As Decimal, ResultadoTotal As Decimal
        CotizacionDolar = Val(TxtCotizacion.Text)
        ResultadoTotal = CompraPesoArg / CotizacionDolar
        BoxTotalCalculado.Text = ResultadoTotal.ToString("0.00")
    End Sub

    Private Sub BtnLimpia_Click(sender As Object, e As EventArgs) Handles BtnLimpia.Click
        TxtDolarCompra.Text = ""
        BoxTotalCalculado.Text = ""
    End Sub

    Private Sub FrmCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtDolarCompra_TextChanged(sender As Object, e As EventArgs) Handles TxtDolarCompra.TextChanged
        If Not IsNumeric(TxtDolarCompra.Text) Then
            TxtDolarCompra.Text = ""
        End If
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class