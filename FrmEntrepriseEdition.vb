Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports ProjetOpinelPPE.DatabaseConnexion
Public Class FrmEntrepriseEdition

    Dim DatabaseQuery As MySqlCommand
    Dim ContactEnregistrer As MySqlDataReader

    Private Sub FrmEntrepriseEdition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnexionDatabase()
        VariableDatabaseConnexion.Open()

        'Récuperer Informations Entreprise

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT RaisonSociale, AdresseRue, CodePostal, Ville, TelStandard, Mail, CodePays FROM ENTREPRISE E WHERE RaisonSociale='" & DatabaseConnexion.nomEntreprise & "'"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()
        ContactEnregistrer.Read()

        nomEntreprise.Text = ContactEnregistrer.GetValue(0)
        adresseEntreprise.Text = ContactEnregistrer.GetValue(1)
        codePostalEntreprise.Text = ContactEnregistrer.GetValue(2)
        villeEntreprise.Text = ContactEnregistrer.GetValue(3)
        telephoneEntreprise.Text = ContactEnregistrer.GetValue(4)
        mailEntreprise.Text = ContactEnregistrer.GetValue(5)
        codePaysEntreprise.Text = ContactEnregistrer.GetValue(6)

        ContactEnregistrer.Close()

        Me.Text = nomEntreprise.Text

        VariableDatabaseConnexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "UPDATE ENTREPRISE SET RaisonSociale='" & nomEntreprise.Text & "', AdresseRue='" & adresseEntreprise.Text & "', CodePostal='" & codePostalEntreprise.Text & "', Ville='" & villeEntreprise.Text & "', TelStandard='" & telephoneEntreprise.Text & "', Mail='" & mailEntreprise.Text & "', CodePays='" & codePaysEntreprise.Text & "' WHERE RaisonSociale='" & DatabaseConnexion.nomEntreprise & "'"
        DatabaseQuery.ExecuteNonQuery()
        MsgBox("Les informations de l'entreprise ont bien été modifier !", +vbInformation, "Entreprise : " & nomEntreprise.Text)

        VariableDatabaseConnexion.Close()
        refreshEntrepriseAccueilContact()
        Me.Close()
    End Sub

    Private Sub refreshEntrepriseAccueilContact()
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

        FrmContactAccueil.ComboBox1.Items.Clear()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT RaisonSociale FROM ENTREPRISE"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read
            FrmContactAccueil.ComboBox1.Items.Add(ContactEnregistrer.GetValue(0))
        End While

        ContactEnregistrer.Close()
        VariableDatabaseConnexion.Close()

        Me.Text = nomEntreprise.Text
    End Sub
End Class