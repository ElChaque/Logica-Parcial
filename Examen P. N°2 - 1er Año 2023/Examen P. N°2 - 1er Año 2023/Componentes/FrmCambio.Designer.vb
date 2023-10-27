<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambio))
        Me.TxtCotizacion = New System.Windows.Forms.TextBox()
        Me.BoxTotalCalculado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnDolarCompra = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDolarCompra = New System.Windows.Forms.TextBox()
        Me.BtnLimpia = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtCotizacion
        '
        Me.TxtCotizacion.Location = New System.Drawing.Point(150, 106)
        Me.TxtCotizacion.Name = "TxtCotizacion"
        Me.TxtCotizacion.Size = New System.Drawing.Size(90, 20)
        Me.TxtCotizacion.TabIndex = 0
        '
        'BoxTotalCalculado
        '
        Me.BoxTotalCalculado.Location = New System.Drawing.Point(150, 196)
        Me.BoxTotalCalculado.Name = "BoxTotalCalculado"
        Me.BoxTotalCalculado.ReadOnly = True
        Me.BoxTotalCalculado.Size = New System.Drawing.Size(125, 20)
        Me.BoxTotalCalculado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cotizacion Dolar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Calculado"
        '
        'BtnDolarCompra
        '
        Me.BtnDolarCompra.Location = New System.Drawing.Point(150, 248)
        Me.BtnDolarCompra.Name = "BtnDolarCompra"
        Me.BtnDolarCompra.Size = New System.Drawing.Size(75, 23)
        Me.BtnDolarCompra.TabIndex = 6
        Me.BtnDolarCompra.Text = "Calcular"
        Me.BtnDolarCompra.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(12, 12)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 7
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(122, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CASA DE CAMBIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dolar a comprar"
        '
        'TxtDolarCompra
        '
        Me.TxtDolarCompra.Location = New System.Drawing.Point(150, 150)
        Me.TxtDolarCompra.Name = "TxtDolarCompra"
        Me.TxtDolarCompra.Size = New System.Drawing.Size(125, 20)
        Me.TxtDolarCompra.TabIndex = 10
        '
        'BtnLimpia
        '
        Me.BtnLimpia.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLimpia.BackgroundImage = CType(resources.GetObject("BtnLimpia.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLimpia.Location = New System.Drawing.Point(26, 103)
        Me.BtnLimpia.Name = "BtnLimpia"
        Me.BtnLimpia.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpia.TabIndex = 11
        Me.BtnLimpia.Text = "Limpiar"
        Me.BtnLimpia.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(131, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(281, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ingrese la cotizacion del dolar y el dolar a comprar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(281, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Peso Arg."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(281, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Dolar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(246, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Peso Arg."
        '
        'FrmCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(357, 294)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLimpia)
        Me.Controls.Add(Me.TxtDolarCompra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnDolarCompra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BoxTotalCalculado)
        Me.Controls.Add(Me.TxtCotizacion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CASA DE CAMBIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCotizacion As TextBox
    Friend WithEvents BoxTotalCalculado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDolarCompra As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDolarCompra As TextBox
    Friend WithEvents BtnLimpia As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
