Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports ProjetOpinelPPE.DatabaseConnexion

Public Class FrmContactAccueil

    Dim DatabaseQuery As MySqlCommand
    Dim ContactEnregistrer As MySqlDataReader

    Private Sub FrmContactAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnexionDatabase()
        VariableDatabaseConnexion.Open()

        'Afficher 

        'Début Afficher tous les contacts

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT IdContact, NomContact, PrenomContact, RaisonSociale FROM CONTACT C, ENTREPRISE E WHERE C.IdEntreprise = E.IdEntreprise"


        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        'Style DataGridView
        DataGridView1.ColumnCount = 4
        DataGridView1.ColumnHeadersVisible = True
        DataGridView1.Columns(0).Visible = False

        DataGridView1.Columns(1).Name = "Nom"
        DataGridView1.Columns(2).Name = "Prénom"
        DataGridView1.Columns(3).Name = "Entreprise"
        'Fin Style DataGridView

        While ContactEnregistrer.Read
            DataGridView1.Rows.Add(ContactEnregistrer.GetValue(0), ContactEnregistrer.GetValue(1), ContactEnregistrer.GetValue(2), ContactEnregistrer.GetValue(3))
        End While

        DataGridView1.AutoResizeColumns()

        ContactEnregistrer.Close()

        'Fin Afficher tous les contacts

        'Début Afficher tous les pays

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT CodePays, Libpays FROM PAYS"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read
            ListBox1.Items.Add(ContactEnregistrer.GetValue(1))
        End While

        ContactEnregistrer.Close()

        'Fin Afficher tous les pays

        'Début Afficher toutes les entreprises

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT RaisonSociale FROM ENTREPRISE"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read
            ComboBox1.Items.Add(ContactEnregistrer.GetValue(0))
            ComboBox2.Items.Add(ContactEnregistrer.GetValue(0))
        End While

        ContactEnregistrer.Close()

        'Fin Afficher toutes les entreprises

        VariableDatabaseConnexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idContact = DataGridView1.SelectedCells.Item(0).Value
        FrmContactEditionProfil.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        DataGridView1.ClearSelection()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text <> "" Then
            'Récupérer Id Entreprise
            nomEntreprise = ComboBox1.Text
            FrmEntrepriseEdition.Show()
        Else
            MsgBox("Veuillez sélectionner une entreprise", +vbCritical, "Entreprise")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmEntrepriseAjout.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim resMsgBox = MsgBox("Voulez vous vraiment supprimer l'entreprise : " & vbCrLf & ComboBox1.Text, +vbCritical + vbYesNo, "Supprimer")
        If (resMsgBox = vbYes) Then
            VariableDatabaseConnexion.Open()

            DatabaseQuery = New MySqlCommand()
            DatabaseQuery.Connection = VariableDatabaseConnexion
            DatabaseQuery.CommandText = "DELETE FROM ENTREPRISE WHERE RaisonSociale='" & ComboBox1.Text & "'"
            DatabaseQuery.ExecuteNonQuery()
            MsgBox("L'entreprise a bien été supprimé !", +vbInformation, "Supression Entreprise")

            VariableDatabaseConnexion.Close()
            refreshEntreprise()
        End If
    End Sub

    Private Sub refreshEntreprise()
        DataGridView1.Rows.Clear()
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT IdContact, NomContact, PrenomContact, RaisonSociale FROM CONTACT C, ENTREPRISE E WHERE C.IdEntreprise = E.IdEntreprise"


        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read
            DataGridView1.Rows.Add(ContactEnregistrer.GetValue(0), ContactEnregistrer.GetValue(1), ContactEnregistrer.GetValue(2), ContactEnregistrer.GetValue(3))
        End While

        DataGridView1.AutoResizeColumns()

        ContactEnregistrer.Close()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT RaisonSociale FROM ENTREPRISE"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read
            ComboBox1.Items.Add(ContactEnregistrer.GetValue(0))
            ComboBox2.Items.Add(ContactEnregistrer.GetValue(0))
        End While

        ContactEnregistrer.Close()
        VariableDatabaseConnexion.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmPaysAjout.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim resContactMsgBox = MsgBox("Voulez vous vraiment supprimer le contact : " & vbCrLf & DataGridView1.SelectedCells.Item(1).Value & " " & DataGridView1.SelectedCells.Item(2).Value, +vbCritical + +vbYesNo, "Suppression")
        If (resContactMsgBox = vbYes) Then
            idContact = DataGridView1.SelectedCells.Item(0).Value
            VariableDatabaseConnexion.Open()

            DatabaseQuery = New MySqlCommand()
            DatabaseQuery.Connection = VariableDatabaseConnexion
            DatabaseQuery.CommandText = "DELETE FROM CONTACT WHERE IdContact=" & idContact
            DatabaseQuery.ExecuteNonQuery()
            MsgBox("Le contact a bien été supprimé !", +vbInformation, "Suppression Contact")

            VariableDatabaseConnexion.Close()
            refreshEntreprise()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim filtreIdEntreprise As Integer
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT IdEntreprise FROM ENTREPRISE WHERE RaisonSociale='" & ComboBox2.Text & "'"
        ContactEnregistrer = DatabaseQuery.ExecuteReader()
        ContactEnregistrer.Read()
        filtreIdEntreprise = ContactEnregistrer.GetValue(0)
        ContactEnregistrer.Close()

        DataGridView1.Rows.Clear()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT IdContact, NomContact, PrenomContact, RaisonSociale FROM CONTACT C, ENTREPRISE E WHERE C.IdEntreprise = E.IdEntreprise AND C.IdEntreprise='" & filtreIdEntreprise & "'"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read
            DataGridView1.Rows.Add(ContactEnregistrer.GetValue(0), ContactEnregistrer.GetValue(1), ContactEnregistrer.GetValue(2), ContactEnregistrer.GetValue(3))
        End While

        DataGridView1.AutoResizeColumns()

        VariableDatabaseConnexion.Close()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        FrmContactAjout.Show()
    End Sub
End Class
