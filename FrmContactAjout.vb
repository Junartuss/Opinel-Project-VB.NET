Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports ProjetOpinelPPE.DatabaseConnexion

Public Class FrmContactAjout
    Dim DatabaseQuery As MySqlCommand
    Dim ContactEnregistrer As MySqlDataReader

    Private Sub FrmContactAjout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnexionDatabase()
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT RaisonSociale FROM ENTREPRISE"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()
        While ContactEnregistrer.Read()
            ComboBox2.Items.Add(ContactEnregistrer.GetValue(0))
        End While
        ContactEnregistrer.Close()
        VariableDatabaseConnexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" And nomContact.Text <> "" And prenomContact.Text <> "" And mailContact.Text <> "" And telInterneContact.Text <> "" And telPortableContact.Text <> "" And ComboBox2.Text <> "" Then
            Dim idEntrepriseAjout As Integer
            VariableDatabaseConnexion.Open()

            DatabaseQuery = New MySqlCommand()
            DatabaseQuery.Connection = VariableDatabaseConnexion
            DatabaseQuery.CommandText = "SELECT IdEntreprise FROM ENTREPRISE WHERE RaisonSociale='" & ComboBox2.Text & "'"
            ContactEnregistrer = DatabaseQuery.ExecuteReader()
            ContactEnregistrer.Read()
            idEntrepriseAjout = ContactEnregistrer.GetValue(0)
            ContactEnregistrer.Close()

            DatabaseQuery = New MySqlCommand()
            DatabaseQuery.Connection = VariableDatabaseConnexion
            DatabaseQuery.CommandText = "INSERT INTO CONTACT(Titre, NomContact, PrenomContact, MailContact, TelnterneContact, TelPortable, IdEntreprise) VALUES('" & ComboBox1.Text & "', '" & nomContact.Text & "', '" & prenomContact.Text & "', '" & mailContact.Text & "', '" & telInterneContact.Text & "', '" & telPortableContact.Text & "', '" & idEntrepriseAjout & "')"
            DatabaseQuery.ExecuteNonQuery()
            MsgBox("Le contact a bien été ajouté !", +vbInformation, "Ajout Contact")

            VariableDatabaseConnexion.Close()
            refreshContact()
            Me.Close()
        Else
            MsgBox("Veuillez remplir tous les champs !", +vbCritical, "Erreur")
        End If

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
End Class