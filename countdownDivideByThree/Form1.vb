Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim startNumber As Integer = Convert.ToInt32(txtStartingNumber.Text)

        Dim connectionString As String = "Server=localhost; Database=dbuser; Uid=root; Pwd=12Yellow34!"

        Using conn As New MySqlConnection(connectionString)

            conn.Open()

            Using cmd As New MySqlCommand("sp_countdown", conn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@startNumber", startNumber)

                ' Add output parameter for the result message
                Dim resultParam As New MySqlParameter("@result_message", MySqlDbType.VarChar)
                resultParam.Direction = ParameterDirection.Output
                resultParam.Size = 1000
                cmd.Parameters.Add(resultParam)

                cmd.ExecuteNonQuery()

                ' Retrieve and display the result message
                Dim resultMessage As String = cmd.Parameters("@result_message").Value.ToString()


                lstResults.Items.Clear()

                ' Split the result message and add each part to the ListBox
                Dim results() As String = resultMessage.Split(New Char() {"."c}, StringSplitOptions.RemoveEmptyEntries)

                For Each result As String In results
                    lstResults.Items.Add(result.Trim() & ".")
                Next
            End Using
        End Using

    End Sub
End Class
