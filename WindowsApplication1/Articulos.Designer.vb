﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articulos
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
        Me.ComboBoxArticulos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMas = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonCalculo = New System.Windows.Forms.Button()
        Me.ButtonContinuar = New System.Windows.Forms.Button()
        Me.NumericUpDownOtra = New System.Windows.Forms.NumericUpDown()
        Me.LabelPrecioEfectivo = New System.Windows.Forms.Label()
        Me.LabelPrecioCuotas = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownOtra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxArticulos
        '
        Me.ComboBoxArticulos.FormattingEnabled = True
        Me.ComboBoxArticulos.Items.AddRange(New Object() {"BLOCK LISO", "BLOCK RAYADO", "CARPETA", "CUADERNO", "LAPICERA", "LAPIZ HB"})
        Me.ComboBoxArticulos.Location = New System.Drawing.Point(26, 55)
        Me.ComboBoxArticulos.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxArticulos.Name = "ComboBoxArticulos"
        Me.ComboBoxArticulos.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxArticulos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UNIDADES"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(234, 76)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(35, 20)
        Me.RadioButton5.TabIndex = 2
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Tag = ""
        Me.RadioButton5.Text = "5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(234, 113)
        Me.RadioButton10.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(42, 20)
        Me.RadioButton10.TabIndex = 3
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "10"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButtonMas
        '
        Me.RadioButtonMas.AutoSize = True
        Me.RadioButtonMas.Location = New System.Drawing.Point(234, 150)
        Me.RadioButtonMas.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonMas.Name = "RadioButtonMas"
        Me.RadioButtonMas.Size = New System.Drawing.Size(57, 20)
        Me.RadioButtonMas.TabIndex = 4
        Me.RadioButtonMas.TabStop = True
        Me.RadioButtonMas.Text = "MAS"
        Me.RadioButtonMas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ARTICULOS"
        '
        'NumericUpDownPrecio
        '
        Me.NumericUpDownPrecio.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownPrecio.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownPrecio.InterceptArrowKeys = False
        Me.NumericUpDownPrecio.Location = New System.Drawing.Point(210, 227)
        Me.NumericUpDownPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDownPrecio.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDownPrecio.Name = "NumericUpDownPrecio"
        Me.NumericUpDownPrecio.Size = New System.Drawing.Size(147, 27)
        Me.NumericUpDownPrecio.TabIndex = 6
        Me.NumericUpDownPrecio.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 199)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PRECIO (por unidad)"
        '
        'ButtonCalculo
        '
        Me.ButtonCalculo.Location = New System.Drawing.Point(26, 270)
        Me.ButtonCalculo.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCalculo.Name = "ButtonCalculo"
        Me.ButtonCalculo.Size = New System.Drawing.Size(113, 43)
        Me.ButtonCalculo.TabIndex = 8
        Me.ButtonCalculo.Text = "CALCULO"
        Me.ButtonCalculo.UseVisualStyleBackColor = True
        '
        'ButtonContinuar
        '
        Me.ButtonContinuar.Location = New System.Drawing.Point(222, 270)
        Me.ButtonContinuar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonContinuar.Name = "ButtonContinuar"
        Me.ButtonContinuar.Size = New System.Drawing.Size(113, 43)
        Me.ButtonContinuar.TabIndex = 9
        Me.ButtonContinuar.Text = "CONTINUAR"
        Me.ButtonContinuar.UseVisualStyleBackColor = True
        '
        'NumericUpDownOtra
        '
        Me.NumericUpDownOtra.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownOtra.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownOtra.InterceptArrowKeys = False
        Me.NumericUpDownOtra.Location = New System.Drawing.Point(166, 149)
        Me.NumericUpDownOtra.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDownOtra.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDownOtra.Name = "NumericUpDownOtra"
        Me.NumericUpDownOtra.Size = New System.Drawing.Size(60, 27)
        Me.NumericUpDownOtra.TabIndex = 10
        Me.NumericUpDownOtra.ThousandsSeparator = True
        Me.NumericUpDownOtra.Visible = False
        '
        'LabelPrecioEfectivo
        '
        Me.LabelPrecioEfectivo.AutoSize = True
        Me.LabelPrecioEfectivo.Location = New System.Drawing.Point(23, 199)
        Me.LabelPrecioEfectivo.Name = "LabelPrecioEfectivo"
        Me.LabelPrecioEfectivo.Size = New System.Drawing.Size(120, 16)
        Me.LabelPrecioEfectivo.TabIndex = 11
        Me.LabelPrecioEfectivo.Text = "Precio en efectivo: "
        Me.LabelPrecioEfectivo.Visible = False
        '
        'LabelPrecioCuotas
        '
        Me.LabelPrecioCuotas.AutoSize = True
        Me.LabelPrecioCuotas.Location = New System.Drawing.Point(23, 227)
        Me.LabelPrecioCuotas.Name = "LabelPrecioCuotas"
        Me.LabelPrecioCuotas.Size = New System.Drawing.Size(113, 16)
        Me.LabelPrecioCuotas.TabIndex = 12
        Me.LabelPrecioCuotas.Text = "Precio en cuotas: "
        Me.LabelPrecioCuotas.Visible = False
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 353)
        Me.Controls.Add(Me.LabelPrecioCuotas)
        Me.Controls.Add(Me.LabelPrecioEfectivo)
        Me.Controls.Add(Me.NumericUpDownOtra)
        Me.Controls.Add(Me.ButtonContinuar)
        Me.Controls.Add(Me.ButtonCalculo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDownPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButtonMas)
        Me.Controls.Add(Me.RadioButton10)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxArticulos)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Articulos"
        Me.Text = "ARTICULOS"
        CType(Me.NumericUpDownPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownOtra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxArticulos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMas As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonCalculo As System.Windows.Forms.Button
    Friend WithEvents ButtonContinuar As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownOtra As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelPrecioEfectivo As Label
    Friend WithEvents LabelPrecioCuotas As Label
End Class
