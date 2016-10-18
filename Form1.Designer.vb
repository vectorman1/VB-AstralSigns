<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbSign = New System.Windows.Forms.ComboBox()
        Me.labelAstralSign = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelSignDates = New System.Windows.Forms.Label()
        Me.labelSaying = New System.Windows.Forms.Label()
        Me.labelColor = New System.Windows.Forms.Label()
        Me.labelPlanet = New System.Windows.Forms.Label()
        Me.labelElement = New System.Windows.Forms.Label()
        Me.pbSign = New System.Windows.Forms.PictureBox()
        CType(Me.pbSign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbSign
        '
        Me.cbSign.FormattingEnabled = True
        Me.cbSign.Items.AddRange(New Object() {"Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces"})
        Me.cbSign.Location = New System.Drawing.Point(79, 10)
        Me.cbSign.Name = "cbSign"
        Me.cbSign.Size = New System.Drawing.Size(121, 21)
        Me.cbSign.TabIndex = 0
        '
        'labelAstralSign
        '
        Me.labelAstralSign.AutoSize = True
        Me.labelAstralSign.Location = New System.Drawing.Point(13, 13)
        Me.labelAstralSign.Name = "labelAstralSign"
        Me.labelAstralSign.Size = New System.Drawing.Size(60, 13)
        Me.labelAstralSign.TabIndex = 1
        Me.labelAstralSign.Text = "Astral Sign:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sign Dates:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Saying:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Color:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Planet:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Element:"
        '
        'labelSignDates
        '
        Me.labelSignDates.AutoSize = True
        Me.labelSignDates.Location = New System.Drawing.Point(100, 54)
        Me.labelSignDates.Name = "labelSignDates"
        Me.labelSignDates.Size = New System.Drawing.Size(0, 13)
        Me.labelSignDates.TabIndex = 7
        '
        'labelSaying
        '
        Me.labelSaying.AutoSize = True
        Me.labelSaying.Location = New System.Drawing.Point(100, 84)
        Me.labelSaying.Name = "labelSaying"
        Me.labelSaying.Size = New System.Drawing.Size(0, 13)
        Me.labelSaying.TabIndex = 8
        '
        'labelColor
        '
        Me.labelColor.AutoSize = True
        Me.labelColor.Location = New System.Drawing.Point(100, 111)
        Me.labelColor.Name = "labelColor"
        Me.labelColor.Size = New System.Drawing.Size(0, 13)
        Me.labelColor.TabIndex = 9
        '
        'labelPlanet
        '
        Me.labelPlanet.AutoSize = True
        Me.labelPlanet.Location = New System.Drawing.Point(100, 141)
        Me.labelPlanet.Name = "labelPlanet"
        Me.labelPlanet.Size = New System.Drawing.Size(0, 13)
        Me.labelPlanet.TabIndex = 10
        '
        'labelElement
        '
        Me.labelElement.AutoSize = True
        Me.labelElement.Location = New System.Drawing.Point(100, 170)
        Me.labelElement.Name = "labelElement"
        Me.labelElement.Size = New System.Drawing.Size(0, 13)
        Me.labelElement.TabIndex = 11
        '
        'pbSign
        '
        Me.pbSign.Location = New System.Drawing.Point(224, 13)
        Me.pbSign.Name = "pbSign"
        Me.pbSign.Size = New System.Drawing.Size(90, 87)
        Me.pbSign.TabIndex = 12
        Me.pbSign.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 220)
        Me.Controls.Add(Me.pbSign)
        Me.Controls.Add(Me.labelElement)
        Me.Controls.Add(Me.labelPlanet)
        Me.Controls.Add(Me.labelColor)
        Me.Controls.Add(Me.labelSaying)
        Me.Controls.Add(Me.labelSignDates)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelAstralSign)
        Me.Controls.Add(Me.cbSign)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Astral Signs"
        CType(Me.pbSign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbSign As System.Windows.Forms.ComboBox
    Friend WithEvents labelAstralSign As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labelSignDates As System.Windows.Forms.Label
    Friend WithEvents labelSaying As System.Windows.Forms.Label
    Friend WithEvents labelColor As System.Windows.Forms.Label
    Friend WithEvents labelPlanet As System.Windows.Forms.Label
    Friend WithEvents labelElement As System.Windows.Forms.Label
    Friend WithEvents pbSign As System.Windows.Forms.PictureBox

End Class
