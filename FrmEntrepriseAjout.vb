Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports ProjetOpinelPPE.DatabaseConnexion
Public Class FrmEntrepriseAjout
    Dim DatabaseQuery As MySqlCommand
    Dim ContactEnregistrer As MySqlDataReader
    Private Sub FrmEntrepriseAjout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnexionDatabase()
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT Libpays FROM PAYS"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()
        While ContactEnregistrer.Read
            ComboBox1.Items.Add(ContactEnregistrer.GetValue(0))
        End While
        ContactEnregistrer.Close()

        VariableDatabaseConnexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If nomEntreprise.Text <> "" And adresseEntreprise.Text <> "" And codePostalEntreprise.Text <> "" And villeEntreprise.Text <> "" And telephoneEntreprise.Text <> "" And mailEntreprise.Text <> "" And ComboBox1.Text <> "" Then
            Dim codePays As String
            VariableDatabaseConnexion.Open()

            'Récupérer Code Pays

            DatabaseQuery = New MySqlCommand()
            DatabaseQuery.Connection = VariableDatabaseConnexion
            DatabaseQuery.CommandText = "SELECT CodePays FROM PAYS WHERE Libpays='" & ComboBox1.Text & "'"
            ContactEnregistrer = DatabaseQuery.ExecuteReader()
            ContactEnregistrer.Read()
            codePays = ContactEnregistrer.GetValue(0)
            ContactEnregistrer.Close()

            'Insertion Nouvelle Entreprise

            DatabaseQuery = New MySqlCommand()
            DatabaseQuery.Connection = VariableDatabaseConnexion
            DatabaseQuery.CommandText = "INSERT INTO ENTREPRISE (RaisonSociale, AdresseRue, CodePostal, Ville, TelStandard, Mail, CodePays) VALUES('" & nomEntreprise.Text & "', '" & adresseEntreprise.Text & "', '" & codePostalEntreprise.Text & "', '" & villeEntreprise.Text & "', '" & telephoneEntreprise.Text & "', '" & mailEntreprise.Text & "', '" & codePays & "')"
            DatabaseQuery.ExecuteNonQuery()
            MsgBox("L'entreprise a bien été ajouter !", +vbInformation, "Entreprise : " & nomEntreprise.Text)

            VariableDatabaseConnexion.Close()
            refreshEntreprise()
            Me.Close()
        Else
            MsgBox("Veuillez remplir tous les champs !", +vbCritical, "Erreur")
        End If

    End Sub

    Private Sub refreshEntreprise()
        VariableDatabaseConnexion.Open()

        FrmContactAccueil.ComboBox1.Items.Clear()
        FrmContactAccueil.ComboBox2.Items.Clear()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT RaisonSociale FROM ENTREPRISE"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read
            FrmContactAccueil.ComboBox1.Items.Add(ContactEnregistrer.GetValue(0))
            FrmContactAccueil.ComboBox2.Items.Add(ContactEnregistrer.GetValue(0))
        End While

        ContactEnregistrer.Close()
        VariableDatabaseConnexion.Close()
    End Sub
End Class