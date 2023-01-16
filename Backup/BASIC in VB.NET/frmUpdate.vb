Imports System.Data.OleDb
Public Class frmUpdate
    

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Dim dr As New DialogResult
        dr = MessageBox.Show("Are you sure you want to Update?", "Change Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If dr = Windows.Forms.DialogResult.OK Then
            If con.State = ConnectionState.Closed Then con.Open()
            Dim st As String = "UPDATE [perinfo] SET IDno = '" & TextBox1.Text & _
                                "', fname = '" & TextBox2.Text & "', lname = '" & TextBox3.Text & _
                                "', mname = '" & TextBox4.Text & "', address = '" & TextBox5.Text & _
                                "'  WHERE IDno = '" & frmMain.DataGridView1.SelectedCells(0).Value & "'"
            MessageBox.Show("Process Successful!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim cmd As New OleDbCommand(st, con)
            cmd.ExecuteNonQuery()
            con.Close()
            frmMain.fill()
            Me.Close()
        End If
    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.Black
    End Sub

    Private Sub Label6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub Label8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseEnter
        Label8.ForeColor = Color.Black
    End Sub

    Private Sub Label8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseLeave
        Label8.ForeColor = Color.WhiteSmoke
    End Sub
End Class