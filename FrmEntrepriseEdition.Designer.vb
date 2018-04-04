<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntrepriseEdition
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mailEntreprise = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.adresseEntreprise = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomEntreprise = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.villeEntreprise = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.telephoneEntreprise = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.codePostalEntreprise = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.codePaysEntreprise = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 24)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Modifier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Code Pays"
        '
        'mailEntreprise
        '
        Me.mailEntreprise.Location = New System.Drawing.Point(93, 150)
        Me.mailEntreprise.Name = "mailEntreprise"
        Me.mailEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.mailEntreprise.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Mail"
        '
        'adresseEntreprise
        '
        Me.adresseEntreprise.Location = New System.Drawing.Point(93, 45)
        Me.adresseEntreprise.Name = "adresseEntreprise"
        Me.adresseEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.adresseEntreprise.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Adresse"
        '
        'nomEntreprise
        '
        Me.nomEntreprise.Location = New System.Drawing.Point(93, 19)
        Me.nomEntreprise.Name = "nomEntreprise"
        Me.nomEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.nomEntreprise.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Code Postal"
        '
        'villeEntreprise
        '
        Me.villeEntreprise.Location = New System.Drawing.Point(93, 97)
        Me.villeEntreprise.Name = "villeEntreprise"
        Me.villeEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.villeEntreprise.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Ville"
        '
        'telephoneEntreprise
        '
        Me.telephoneEntreprise.Location = New System.Drawing.Point(93, 123)
        Me.telephoneEntreprise.Name = "telephoneEntreprise"
        Me.telephoneEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.telephoneEntreprise.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Téléphone"
        '
        'codePostalEntreprise
        '
        Me.codePostalEntreprise.Location = New System.Drawing.Point(93, 71)
        Me.codePostalEntreprise.Name = "codePostalEntreprise"
        Me.codePostalEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.codePostalEntreprise.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nom Entreprise"
        '
        'codePaysEntreprise
        '
        Me.codePaysEntreprise.Enabled = False
        Me.codePaysEntreprise.Location = New System.Drawing.Point(93, 179)
        Me.codePaysEntreprise.Name = "codePaysEntreprise"
        Me.codePaysEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.codePaysEntreprise.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nomEntreprise)
        Me.GroupBox1.Controls.Add(Me.codePaysEntreprise)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.codePostalEntreprise)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mailEntreprise)
        Me.GroupBox1.Controls.Add(Me.telephoneEntreprise)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.adresseEntreprise)
        Me.GroupBox1.Controls.Add(Me.villeEntreprise)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 242)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edition de l'entreprise"
        '
        'FrmEntrepriseEdition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmEntrepriseEdition"
        Me.Text = "FrmEntrepriseEdition"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents mailEntreprise As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents adresseEntreprise As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nomEntreprise As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents villeEntreprise As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents telephoneEntreprise As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents codePostalEntreprise As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents codePaysEntreprise As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
