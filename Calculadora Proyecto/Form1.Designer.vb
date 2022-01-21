<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SUMASIGNO = New System.Windows.Forms.Button()
        Me.MENOSSIGNO = New System.Windows.Forms.Button()
        Me.DIVISIONSIGNO = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RESULTADO = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MULTIPLICACIONSIGNO = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RESTA = New System.Windows.Forms.Label()
        Me.DIVISION = New System.Windows.Forms.Label()
        Me.SUMA = New System.Windows.Forms.Label()
        Me.MULTIPLICACION = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SUMASIGNO
        '
        Me.SUMASIGNO.BackColor = System.Drawing.SystemColors.Highlight
        Me.SUMASIGNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SUMASIGNO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SUMASIGNO.Location = New System.Drawing.Point(87, 137)
        Me.SUMASIGNO.Name = "SUMASIGNO"
        Me.SUMASIGNO.Size = New System.Drawing.Size(129, 50)
        Me.SUMASIGNO.TabIndex = 0
        Me.SUMASIGNO.Text = " +"
        Me.SUMASIGNO.UseVisualStyleBackColor = False
        '
        'MENOSSIGNO
        '
        Me.MENOSSIGNO.BackColor = System.Drawing.SystemColors.Highlight
        Me.MENOSSIGNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MENOSSIGNO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MENOSSIGNO.Location = New System.Drawing.Point(288, 137)
        Me.MENOSSIGNO.Name = "MENOSSIGNO"
        Me.MENOSSIGNO.Size = New System.Drawing.Size(129, 50)
        Me.MENOSSIGNO.TabIndex = 1
        Me.MENOSSIGNO.Text = "-"
        Me.MENOSSIGNO.UseVisualStyleBackColor = False
        '
        'DIVISIONSIGNO
        '
        Me.DIVISIONSIGNO.BackColor = System.Drawing.SystemColors.Highlight
        Me.DIVISIONSIGNO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DIVISIONSIGNO.Location = New System.Drawing.Point(288, 262)
        Me.DIVISIONSIGNO.Name = "DIVISIONSIGNO"
        Me.DIVISIONSIGNO.Size = New System.Drawing.Size(129, 53)
        Me.DIVISIONSIGNO.TabIndex = 2
        Me.DIVISIONSIGNO.Text = "/"
        Me.DIVISIONSIGNO.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(486, 189)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "4"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RESULTADO
        '
        Me.RESULTADO.AutoSize = True
        Me.RESULTADO.BackColor = System.Drawing.SystemColors.Desktop
        Me.RESULTADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RESULTADO.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESULTADO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RESULTADO.Location = New System.Drawing.Point(513, 282)
        Me.RESULTADO.Margin = New System.Windows.Forms.Padding(3)
        Me.RESULTADO.Name = "RESULTADO"
        Me.RESULTADO.Size = New System.Drawing.Size(2, 66)
        Me.RESULTADO.TabIndex = 8
        Me.RESULTADO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox2.Location = New System.Drawing.Point(486, 239)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "5"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MULTIPLICACIONSIGNO
        '
        Me.MULTIPLICACIONSIGNO.BackColor = System.Drawing.SystemColors.Highlight
        Me.MULTIPLICACIONSIGNO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MULTIPLICACIONSIGNO.Location = New System.Drawing.Point(87, 265)
        Me.MULTIPLICACIONSIGNO.Name = "MULTIPLICACIONSIGNO"
        Me.MULTIPLICACIONSIGNO.Size = New System.Drawing.Size(129, 50)
        Me.MULTIPLICACIONSIGNO.TabIndex = 6
        Me.MULTIPLICACIONSIGNO.Text = "*"
        Me.MULTIPLICACIONSIGNO.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(201, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(399, 64)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CALCULADORA"
        '
        'RESTA
        '
        Me.RESTA.AutoSize = True
        Me.RESTA.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESTA.Location = New System.Drawing.Point(321, 190)
        Me.RESTA.Name = "RESTA"
        Me.RESTA.Size = New System.Drawing.Size(58, 21)
        Me.RESTA.TabIndex = 9
        Me.RESTA.Text = "RESTA"
        '
        'DIVISION
        '
        Me.DIVISION.AutoSize = True
        Me.DIVISION.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIVISION.Location = New System.Drawing.Point(309, 318)
        Me.DIVISION.Name = "DIVISION"
        Me.DIVISION.Size = New System.Drawing.Size(82, 21)
        Me.DIVISION.TabIndex = 10
        Me.DIVISION.Text = "DIVISION"
        Me.DIVISION.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SUMA
        '
        Me.SUMA.AutoSize = True
        Me.SUMA.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUMA.Location = New System.Drawing.Point(119, 189)
        Me.SUMA.Name = "SUMA"
        Me.SUMA.Size = New System.Drawing.Size(57, 21)
        Me.SUMA.TabIndex = 11
        Me.SUMA.Text = "SUMA"
        '
        'MULTIPLICACION
        '
        Me.MULTIPLICACION.AutoSize = True
        Me.MULTIPLICACION.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MULTIPLICACION.Location = New System.Drawing.Point(83, 318)
        Me.MULTIPLICACION.Name = "MULTIPLICACION"
        Me.MULTIPLICACION.Size = New System.Drawing.Size(143, 21)
        Me.MULTIPLICACION.TabIndex = 12
        Me.MULTIPLICACION.Text = "MULTIPLICACIÓN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MULTIPLICACION)
        Me.Controls.Add(Me.SUMA)
        Me.Controls.Add(Me.DIVISION)
        Me.Controls.Add(Me.RESTA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MULTIPLICACIONSIGNO)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.RESULTADO)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DIVISIONSIGNO)
        Me.Controls.Add(Me.MENOSSIGNO)
        Me.Controls.Add(Me.SUMASIGNO)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SUMASIGNO As Button
    Friend WithEvents MENOSSIGNO As Button
    Friend WithEvents DIVISIONSIGNO As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RESULTADO As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MULTIPLICACIONSIGNO As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RESTA As Label
    Friend WithEvents DIVISION As Label
    Friend WithEvents SUMA As Label
    Friend WithEvents MULTIPLICACION As Label
End Class
