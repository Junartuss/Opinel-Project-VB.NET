Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports ProjetOpinelPPE.DatabaseConnexion

Public Class FrmContactEditionProfil
    Dim DatabaseQuery As MySqlCommand
    Dim ContactEnregistrer As MySqlDataReader
    Dim idAction As Integer

    Private Sub FrmContactEditionProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnexionDatabase()
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT Titre, NomContact, PrenomContact, MailContact, TelnterneContact, TelPortable, RaisonSociale FROM CONTACT C, ENTREPRISE E WHERE C.IdEntreprise = E.IdEntreprise AND C.IdContact=" & idContact

        ContactEnregistrer = DatabaseQuery.ExecuteReader()
        ContactEnregistrer.Read()

        TextBoxTitreContact.Text = ContactEnregistrer.GetValue(0)
        TextBoxNomContact.Text = ContactEnregistrer.GetValue(1)
        TextBoxPrenomContact.Text = ContactEnregistrer.GetValue(2)
        TextBoxMailContact.Text = ContactEnregistrer.GetValue(3)
        TextBoxTelnterneContact.Text = ContactEnregistrer.GetValue(4)
        TextBoxTelPortableContact.Text = ContactEnregistrer.GetValue(5)
        TextBoxEntrepriseContact.Text = ContactEnregistrer.GetValue(6)

        ContactEnregistrer.Close()

        Me.Text = "Contact : " & TextBoxNomContact.Text & " " & TextBoxPrenomContact.Text

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT LibTypeAction FROM TYPE_ACTION"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read
            ComboBox2.Items.Add(ContactEnregistrer.GetValue(0))
        End While

        ContactEnregistrer.Close()

        Try
            DatabaseQuery = New MySqlCommand()
            DatabaseQuery.Connection = VariableDatabaseConnexion
            DatabaseQuery.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, LibTypeAction FROM ACTION A, TYPE_ACTION TA WHERE A.IdTypeAction = TA.IdTypeAction AND IdContact=" & idContact

            ContactEnregistrer = DatabaseQuery.ExecuteReader()

            'Style DataGridView
            DataGridView1.ColumnCount = 6
            DataGridView1.ColumnHeadersVisible = True
            DataGridView1.Columns(5).Visible = False

            DataGridView1.Columns(0).Name = "Date Action"
            DataGridView1.Columns(1).Name = "Commentaire"
            DataGridView1.Columns(2).Name = "A Relancer"
            DataGridView1.Columns(3).Name = "Date de Relance"
            DataGridView1.Columns(4).Name = "Type D'action"
            'Fin Style DataGridView

            While ContactEnregistrer.Read()
                DataGridView1.Rows.Add(ContactEnregistrer.GetValue(1), ContactEnregistrer.GetValue(2), ContactEnregistrer.GetValue(3), ContactEnregistrer.GetValue(4), ContactEnregistrer.GetValue(5), ContactEnregistrer.GetValue(0))
            End While

            DataGridView1.AutoResizeColumns()

            idAction = DataGridView1.SelectedCells.Item(5).Value

            ContactEnregistrer.Close()
        Catch ex As Exception

        End Try

        VariableDatabaseConnexion.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "UPDATE CONTACT SET NomContact = '" & TextBoxNomContact.Text & "', PrenomContact = '" & TextBoxPrenomContact.Text & "', MailContact = '" & TextBoxMailContact.Text & "', TelnterneContact = '" & TextBoxTelnterneContact.Text & "', TelPortable = '" & TextBoxTelPortableContact.Text & "' WHERE IdContact =" & idContact
        DatabaseQuery.ExecuteNonQuery()
        MsgBox("Les modifications ont bien été effectué !", +vbInformation, "Modification : " & TextBoxNomContact.Text & " " & TextBoxPrenomContact.Text)
        VariableDatabaseConnexion.Close()
        refreshContact()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nowDate As Date
        Dim typeAction As String
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT TA.IdTypeAction FROM TYPE_ACTION TA WHERE TA.LibTypeAction='" & ComboBox2.Text & "'"
        ContactEnregistrer = DatabaseQuery.ExecuteReader()
        ContactEnregistrer.Read()

        typeAction = ContactEnregistrer.GetValue(0)

        ContactEnregistrer.Close()

        nowDate = DateTime.Today

        If ComboBox1.Text = "Oui" Then
            If TextBox1.Text <> "" Then
                If ComboBox2.Text <> "Choisir une action" Then
                    DatabaseQuery = New MySqlCommand
                    DatabaseQuery.Connection = VariableDatabaseConnexion
                    DatabaseQuery.CommandText = "INSERT INTO ACTION (DateAction, Commentaire, ARelancer, DateRelance, IdContact, IdTypeAction) VALUES ('" & nowDate & "', '" & TextBox1.Text & "', '" & ComboBox1.Text & "', '" & DateTimePicker1.Value.Date & "', '" & idContact & "', '" & typeAction & "')"
                    DatabaseQuery.ExecuteNonQuery()
                    MsgBox("Action bien ajouté au contact : " & TextBoxNomContact.Text & " " & TextBoxPrenomContact.Text, +vbInformation, "Action")
                Else
                    MsgBox("Veuillez choisir un type d'action !", +vbCritical, "Erreur")
                End If
            Else
                MsgBox("Veuillez remplir le commentaire !", +vbCritical, "Erreur")
            End If
        End If

        If ComboBox1.Text = "Non" Then
            Dim aucuneRelance As String
            aucuneRelance = "Aucune"
            If TextBox1.Text <> "" Then
                If ComboBox2.Text <> "Choisir une action" Then
                    DatabaseQuery = New MySqlCommand
                    DatabaseQuery.Connection = VariableDatabaseConnexion
                    DatabaseQuery.CommandText = "INSERT INTO ACTION (DateAction, Commentaire, ARelancer, DateRelance, IdContact, IdTypeAction) VALUES ('" & nowDate & "', '" & TextBox1.Text & "', '" & ComboBox1.Text & "', '" & aucuneRelance & "', '" & idContact & "', '" & typeAction & "')"
                    DatabaseQuery.ExecuteNonQuery()
                    MsgBox("Action bien ajouté au contact : " & TextBoxNomContact.Text & " " & TextBoxPrenomContact.Text, +vbInformation, "Action")
                Else
                    MsgBox("Veuillez choisir un type d'action !", +vbCritical, "Erreur")
                End If
            Else
                MsgBox("Veuillez remplir le commentaire !", +vbCritical, "Erreur")
            End If
        End If
        VariableDatabaseConnexion.Close()
        refreshAction()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Non" Then
            DateTimePicker1.Enabled = False
        End If
        If ComboBox1.Text = "Oui" Then
            DateTimePicker1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub refreshAction()
        DataGridView1.Rows.Clear()
        VariableDatabaseConnexion.Open()
        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, LibTypeAction FROM ACTION A, TYPE_ACTION TA WHERE A.IdTypeAction = TA.IdTypeAction AND IdContact=" & idContact

        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read()
            DataGridView1.Rows.Add(ContactEnregistrer.GetValue(1), ContactEnregistrer.GetValue(2), ContactEnregistrer.GetValue(3), ContactEnregistrer.GetValue(4), ContactEnregistrer.GetValue(5), ContactEnregistrer.GetValue(0))
        End While

        DataGridView1.AutoResizeColumns()

        ContactEnregistrer.Close()

        VariableDatabaseConnexion.Close()
    End Sub

    Private Sub refreshContact()
        FrmContactAccueil.DataGridView1.Rows.Clear()
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT IdContact, NomContact, PrenomContact, RaisonSociale FROM CONTACT C, ENTREPRISE E WHERE C.IdEntreprise = E.IdEntreprise"


        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read
            FrmContactAccueil.DataGridView1.Rows.Add(ContactEnregistrer.GetValue(0), ContactEnregistrer.GetValue(1), ContactEnregistrer.GetValue(2), ContactEnregistrer.GetValue(3))
        End While

        FrmContactAccueil.DataGridView1.AutoResizeColumns()

        ContactEnregistrer.Close()

        VariableDatabaseConnexion.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "DELETE FROM ACTION WHERE IdAction=" & idAction
        DatabaseQuery.ExecuteNonQuery()
        MsgBox("L'action a bien été supprimé !", +vbInformation, "Action Supprimer")

        VariableDatabaseConnexion.Close()
        refreshAction()
    End Sub
End Class