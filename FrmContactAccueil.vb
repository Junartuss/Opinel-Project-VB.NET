Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports ProjetOpinelPPE.DatabaseConnexion

Public Class FrmContactAccueil

    Dim DatabaseQuery As MySqlCommand
    Dim ContactEnregistrer As MySqlDataReader

    Private Sub FrmContactAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnexionDatabase()
        VariableDatabaseConnexion.Open()

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
End Class
