﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntrepriseAjout
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.codePostalEntreprise = New System.Windows.Forms.TextBox()
        Me.telephoneEntreprise = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.villeEntreprise = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nomEntreprise = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adresseEntreprise = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mailEntreprise = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom Entreprise"
        '
        'codePostalEntreprise
        '
        Me.codePostalEntreprise.Location = New System.Drawing.Point(97, 59)
        Me.codePostalEntreprise.Name = "codePostalEntreprise"
        Me.codePostalEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.codePostalEntreprise.TabIndex = 1
        '
        'telephoneEntreprise
        '
        Me.telephoneEntreprise.Location = New System.Drawing.Point(97, 111)
        Me.telephoneEntreprise.Name = "telephoneEntreprise"
        Me.telephoneEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.telephoneEntreprise.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Téléphone"
        '
        'villeEntreprise
        '
        Me.villeEntreprise.Location = New System.Drawing.Point(97, 85)
        Me.villeEntreprise.Name = "villeEntreprise"
        Me.villeEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.villeEntreprise.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ville"
        '
        'nomEntreprise
        '
        Me.nomEntreprise.Location = New System.Drawing.Point(97, 7)
        Me.nomEntreprise.Name = "nomEntreprise"
        Me.nomEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.nomEntreprise.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Code Postal"
        '
        'adresseEntreprise
        '
        Me.adresseEntreprise.Location = New System.Drawing.Point(97, 33)
        Me.adresseEntreprise.Name = "adresseEntreprise"
        Me.adresseEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.adresseEntreprise.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Adresse"
        '
        'mailEntreprise
        '
        Me.mailEntreprise.Location = New System.Drawing.Point(97, 138)
        Me.mailEntreprise.Name = "mailEntreprise"
        Me.mailEntreprise.Size = New System.Drawing.Size(175, 20)
        Me.mailEntreprise.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Mail"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(97, 167)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(174, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Pays"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 24)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmEntrepriseAjout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 229)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.mailEntreprise)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.adresseEntreprise)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nomEntreprise)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.villeEntreprise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.telephoneEntreprise)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.codePostalEntreprise)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmEntrepriseAjout"
        Me.Text = "FrmEntrepriseAjout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents codePostalEntreprise As TextBox
    Friend WithEvents telephoneEntreprise As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents villeEntreprise As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nomEntreprise As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents adresseEntreprise As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mailEntreprise As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
