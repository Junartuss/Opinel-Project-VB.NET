Imports MySql.Data.MySqlClient
Module DatabaseConnexion
    Public VariableDatabaseConnexion As MySqlConnection
    Public idContact As Integer
    Public nomEntreprise As String
    Dim DataConnection As String

    Public Sub ConnexionDatabase()
        'Connexion BDD "projetppevb" WampServer
        DataConnection = "Server=localhost;Port=3306;User Id=root;Password=;DataBase=projetppevb"
        VariableDatabaseConnexion = New MySqlConnection(DataConnection)
    End Sub
End Module
