<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmContactEditionProfil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBoxTitreContact = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxEntrepriseContact = New System.Windows.Forms.TextBox()
        Me.TextBoxTelPortableContact = New System.Windows.Forms.TextBox()
        Me.TextBoxTelnterneContact = New System.Windows.Forms.TextBox()
        Me.TextBoxMailContact = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenomContact = New System.Windows.Forms.TextBox()
        Me.TextBoxNomContact = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxTitreContact
        '
        Me.TextBoxTitreContact.Enabled = False
        Me.TextBoxTitreContact.Location = New System.Drawing.Point(75, 19)
        Me.TextBoxTitreContact.Name = "TextBoxTitreContact"
        Me.TextBoxTitreContact.Size = New System.Drawing.Size(263, 20)
        Me.TextBoxTitreContact.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxEntrepriseContact)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelPortableContact)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelnterneContact)
        Me.GroupBox1.Controls.Add(Me.TextBoxMailContact)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrenomContact)
        Me.GroupBox1.Controls.Add(Me.TextBoxNomContact)
        Me.GroupBox1.Controls.Add(Me.TextBoxTitreContact)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 242)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(263, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Editer les informations du contact"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Entreprise"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tel Portable"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tel Interne"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Prénom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Titre"
        '
        'TextBoxEntrepriseContact
        '
        Me.TextBoxEntrepriseContact.Enabled = False
        Me.TextBoxEntrepriseContact.Location = New System.Drawing.Point(75, 175)
        Me.TextBoxEntrepriseContact.Name = "TextBoxEntrepriseContact"
        Me.TextBoxEntrepriseContact.Size = New System.Drawing.Size(263, 20)
        Me.TextBoxEntrepriseContact.TabIndex = 6
        '
        'TextBoxTelPortableContact
        '
        Me.TextBoxTelPortableContact.Location = New System.Drawing.Point(75, 149)
        Me.TextBoxTelPortableContact.Name = "TextBoxTelPortableContact"
        Me.TextBoxTelPortableContact.Size = New System.Drawing.Size(263, 20)
        Me.TextBoxTelPortableContact.TabIndex = 5
        '
        'TextBoxTelnterneContact
        '
        Me.TextBoxTelnterneContact.Location = New System.Drawing.Point(75, 123)
        Me.TextBoxTelnterneContact.Name = "TextBoxTelnterneContact"
        Me.TextBoxTelnterneContact.Size = New System.Drawing.Size(263, 20)
        Me.TextBoxTelnterneContact.TabIndex = 4
        '
        'TextBoxMailContact
        '
        Me.TextBoxMailContact.Location = New System.Drawing.Point(75, 97)
        Me.TextBoxMailContact.Name = "TextBoxMailContact"
        Me.TextBoxMailContact.Size = New System.Drawing.Size(263, 20)
        Me.TextBoxMailContact.TabIndex = 3
        '
        'TextBoxPrenomContact
        '
        Me.TextBoxPrenomContact.Location = New System.Drawing.Point(75, 71)
        Me.TextBoxPrenomContact.Name = "TextBoxPrenomContact"
        Me.TextBoxPrenomContact.Size = New System.Drawing.Size(263, 20)
        Me.TextBoxPrenomContact.TabIndex = 2
        '
        'TextBoxNomContact
        '
        Me.TextBoxNomContact.Location = New System.Drawing.Point(75, 45)
        Me.TextBoxNomContact.Name = "TextBoxNomContact"
        Me.TextBoxNomContact.Size = New System.Drawing.Size(263, 20)
        Me.TextBoxNomContact.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(391, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 229)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Enregistrer l'action"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Type d'action"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Date de relance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "A Relancer"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Commentaire"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(155, 159)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(214, 21)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.Text = "Choisir une action"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(155, 133)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Oui", "Non"})
        Me.ComboBox1.Location = New System.Drawing.Point(155, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "Oui"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(155, 22)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 78)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(754, 186)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Action Finaliser"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(715, 144)
        Me.DataGridView1.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(583, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(150, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Supprimer l'action sélectionner"
        '
        'FrmContactEditionProfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 461)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmContactEditionProfil"
        Me.Text = "FrmContactEditionProfil"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxTitreContact As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxTelnterneContact As TextBox
    Friend WithEvents TextBoxMailContact As TextBox
    Friend WithEvents TextBoxPrenomContact As TextBox
    Friend WithEvents TextBoxNomContact As TextBox
    Friend WithEvents TextBoxEntrepriseContact As TextBox
    Friend WithEvents TextBoxTelPortableContact As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
