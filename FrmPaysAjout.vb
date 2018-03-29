Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports ProjetOpinelPPE.DatabaseConnexion
Public Class FrmPaysAjout
    Dim DatabaseQuery As MySqlCommand
    Dim ContactEnregistrer As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConnexionDatabase()
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "INSERT INTO PAYS VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "')"
        DatabaseQuery.ExecuteNonQuery()
        MsgBox("Le pays a bien été ajouté !", +vbInformation, "Pays : " & TextBox2.Text)


        VariableDatabaseConnexion.Close()
        refreshPaysAccueil()
        Me.Close()
    End Sub

    Private Sub refreshPaysAccueil()
        FrmContactAccueil.ListBox1.Items.Clear()
        VariableDatabaseConnexion.Open()

        DatabaseQuery = New MySqlCommand()
        DatabaseQuery.Connection = VariableDatabaseConnexion
        DatabaseQuery.CommandText = "SELECT CodePays, Libpays FROM PAYS"

        ContactEnregistrer = DatabaseQuery.ExecuteReader()

        While ContactEnregistrer.Read
            FrmContactAccueil.ListBox1.Items.Add(ContactEnregistrer.GetValue(1))
        End While

        ContactEnregistrer.Close()

        VariableDatabaseConnexion.Close()
    End Sub
End Class