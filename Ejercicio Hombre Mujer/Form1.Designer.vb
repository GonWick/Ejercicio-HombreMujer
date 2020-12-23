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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBoxGenero = New System.Windows.Forms.GroupBox()
        Me.GroupBoxEdad = New System.Windows.Forms.GroupBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.RadioButtonHombre = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMujer = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMayor = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMenor = New System.Windows.Forms.RadioButton()
        Me.GroupBoxGenero.SuspendLayout()
        Me.GroupBoxEdad.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxGenero
        '
        Me.GroupBoxGenero.Controls.Add(Me.RadioButtonMujer)
        Me.GroupBoxGenero.Controls.Add(Me.RadioButtonHombre)
        Me.GroupBoxGenero.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxGenero.Name = "GroupBoxGenero"
        Me.GroupBoxGenero.Size = New System.Drawing.Size(137, 118)
        Me.GroupBoxGenero.TabIndex = 0
        Me.GroupBoxGenero.TabStop = False
        Me.GroupBoxGenero.Text = "Género"
        '
        'GroupBoxEdad
        '
        Me.GroupBoxEdad.Controls.Add(Me.RadioButtonMenor)
        Me.GroupBoxEdad.Controls.Add(Me.RadioButtonMayor)
        Me.GroupBoxEdad.Location = New System.Drawing.Point(155, 12)
        Me.GroupBoxEdad.Name = "GroupBoxEdad"
        Me.GroupBoxEdad.Size = New System.Drawing.Size(137, 118)
        Me.GroupBoxEdad.TabIndex = 1
        Me.GroupBoxEdad.TabStop = False
        Me.GroupBoxEdad.Text = "Edad"
        '
        'ButtonOK
        '
        Me.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonOK.Image = CType(resources.GetObject("ButtonOK.Image"), System.Drawing.Image)
        Me.ButtonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOK.Location = New System.Drawing.Point(12, 144)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(279, 28)
        Me.ButtonOK.TabIndex = 2
        Me.ButtonOK.Text = "CONFIRMAR"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'RadioButtonHombre
        '
        Me.RadioButtonHombre.AutoSize = True
        Me.RadioButtonHombre.Location = New System.Drawing.Point(21, 35)
        Me.RadioButtonHombre.Name = "RadioButtonHombre"
        Me.RadioButtonHombre.Size = New System.Drawing.Size(62, 17)
        Me.RadioButtonHombre.TabIndex = 0
        Me.RadioButtonHombre.TabStop = True
        Me.RadioButtonHombre.Text = "Hombre"
        Me.RadioButtonHombre.UseVisualStyleBackColor = True
        '
        'RadioButtonMujer
        '
        Me.RadioButtonMujer.AutoSize = True
        Me.RadioButtonMujer.Location = New System.Drawing.Point(21, 76)
        Me.RadioButtonMujer.Name = "RadioButtonMujer"
        Me.RadioButtonMujer.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonMujer.TabIndex = 1
        Me.RadioButtonMujer.TabStop = True
        Me.RadioButtonMujer.Text = "Mujer"
        Me.RadioButtonMujer.UseVisualStyleBackColor = True
        '
        'RadioButtonMayor
        '
        Me.RadioButtonMayor.AutoSize = True
        Me.RadioButtonMayor.Location = New System.Drawing.Point(23, 35)
        Me.RadioButtonMayor.Name = "RadioButtonMayor"
        Me.RadioButtonMayor.Size = New System.Drawing.Size(54, 17)
        Me.RadioButtonMayor.TabIndex = 0
        Me.RadioButtonMayor.TabStop = True
        Me.RadioButtonMayor.Text = "Mayor"
        Me.RadioButtonMayor.UseVisualStyleBackColor = True
        '
        'RadioButtonMenor
        '
        Me.RadioButtonMenor.AutoSize = True
        Me.RadioButtonMenor.Location = New System.Drawing.Point(23, 76)
        Me.RadioButtonMenor.Name = "RadioButtonMenor"
        Me.RadioButtonMenor.Size = New System.Drawing.Size(55, 17)
        Me.RadioButtonMenor.TabIndex = 1
        Me.RadioButtonMenor.TabStop = True
        Me.RadioButtonMenor.Text = "Menor"
        Me.RadioButtonMenor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 192)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.GroupBoxEdad)
        Me.Controls.Add(Me.GroupBoxGenero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio Hombre - Mujer"
        Me.GroupBoxGenero.ResumeLayout(False)
        Me.GroupBoxGenero.PerformLayout()
        Me.GroupBoxEdad.ResumeLayout(False)
        Me.GroupBoxEdad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxGenero As GroupBox
    Friend WithEvents RadioButtonMujer As RadioButton
    Friend WithEvents RadioButtonHombre As RadioButton
    Friend WithEvents GroupBoxEdad As GroupBox
    Friend WithEvents RadioButtonMenor As RadioButton
    Friend WithEvents RadioButtonMayor As RadioButton
    Friend WithEvents ButtonOK As Button
End Class
