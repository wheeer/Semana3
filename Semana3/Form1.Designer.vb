<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btCalcular = New Button()
        cbOperaciones = New ComboBox()
        tbNum2 = New TextBox()
        tbNum1 = New TextBox()
        Label1 = New Label()
        lbResul = New Label()
        SuspendLayout()
        ' 
        ' btCalcular
        ' 
        btCalcular.Location = New Point(463, 188)
        btCalcular.Name = "btCalcular"
        btCalcular.Size = New Size(75, 23)
        btCalcular.TabIndex = 0
        btCalcular.Text = "Calcular"
        btCalcular.UseVisualStyleBackColor = True
        ' 
        ' cbOperaciones
        ' 
        cbOperaciones.FormattingEnabled = True
        cbOperaciones.Location = New Point(336, 189)
        cbOperaciones.Name = "cbOperaciones"
        cbOperaciones.Size = New Size(121, 23)
        cbOperaciones.TabIndex = 1
        ' 
        ' tbNum2
        ' 
        tbNum2.Location = New Point(230, 188)
        tbNum2.Name = "tbNum2"
        tbNum2.Size = New Size(100, 23)
        tbNum2.TabIndex = 2
        ' 
        ' tbNum1
        ' 
        tbNum1.Location = New Point(230, 159)
        tbNum1.Name = "tbNum1"
        tbNum1.Size = New Size(100, 23)
        tbNum1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(151, 167)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 4
        Label1.Text = " 1er Numero"
        ' 
        ' lbResul
        ' 
        lbResul.AutoSize = True
        lbResul.Location = New Point(233, 225)
        lbResul.Name = "lbResul"
        lbResul.Size = New Size(0, 15)
        lbResul.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbResul)
        Controls.Add(Label1)
        Controls.Add(tbNum1)
        Controls.Add(tbNum2)
        Controls.Add(cbOperaciones)
        Controls.Add(btCalcular)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btCalcular As Button
    Friend WithEvents cbOperaciones As ComboBox
    Friend WithEvents tbNum2 As TextBox
    Friend WithEvents tbNum1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbResul As Label

End Class
