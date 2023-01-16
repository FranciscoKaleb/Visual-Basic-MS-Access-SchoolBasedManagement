Imports System.Data.OleDb
Imports System.Data
Imports System.Data.DataTable
Public Class frmMain
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()
    Dim ds As DataSet = New DataSet
    Dim tables As DataTableCollection = ds.Tables
    Sub fill()
        Dim dt As New DataTable
        Dim str As String = "Select IDno as [ID No], Fname as [First Name],Mname as [Middle Name], Lname as [Last Name], address as [Address] from perinfo ORDER By IDno "
        Dim da As New OleDb.OleDbDataAdapter(str, con)
        da.Fill(dt)
        da.Dispose()
        source1.DataSource = dt
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.Columns(4).Width = 150
    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
    Public Sub clearitems()

        ListView1.Items.Clear()
    End Sub

    Public Sub delterminated()
        Try
            Dim str1 As String = "Delete * from perinfo where [perinfo.IDno]= '" & DataGridView1.SelectedCells(0).Value.ToString & "'"
            Dim cmd1 As New OleDbCommand(str1, con)
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            fill()
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fill()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        ListView1.Items.Add(TextBox1.Text.ToString)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(TextBox2.Text).ToString)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(TextBox3.Text).ToString)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(TextBox4.Text).ToString)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(TextBox5.Text).ToString)
        clear()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        For i As Integer = 0 To ListView1.Items.Count - 1
            If con.State = ConnectionState.Closed Then con.Open()
            Dim st As String = "INSERT INTO [perinfo](idno,fname,lname,mname,address) VALUES ('" & ListView1.Items(i).Text & "','" & ListView1.Items(i).SubItems(1).Text & "','" & ListView1.Items(i).SubItems(2).Text & "','" & ListView1.Items(i).SubItems(3).Text & "','" & ListView1.Items(i).SubItems(4).Text & "' )"
            MessageBox.Show("Process successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim cmdd As New OleDbCommand(st, con)
            cmdd.ExecuteNonQuery()
            con.Close()
            Me.fill()
            clearitems()
        Next
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = DataGridView1.SelectedCells(0).Value.ToString Then
            MsgBox("ID No. is already Exist!")
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        frmUpdate.TextBox1.Text = Me.DataGridView1.SelectedCells(0).Value.ToString
        frmUpdate.TextBox2.Text = Me.DataGridView1.SelectedCells(1).Value.ToString
        frmUpdate.TextBox3.Text = Me.DataGridView1.SelectedCells(3).Value.ToString
        frmUpdate.TextBox4.Text = Me.DataGridView1.SelectedCells(2).Value.ToString
        frmUpdate.TextBox5.Text = Me.DataGridView1.SelectedCells(4).Value.ToString
        frmUpdate.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Dim dr As New DialogResult
        dr = MessageBox.Show("Are you sure you want to permanently delete " & DataGridView1.SelectedCells(0).Value & "?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If dr = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("Action aborted!", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.ClearSelection()
            Exit Sub
        Else
            delterminated()
            fill()
        End If

    End Sub

    
  
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.Black
    End Sub

    Private Sub Label6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub Label9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.MouseEnter
        Label9.ForeColor = Color.Black
    End Sub

    Private Sub Label9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.MouseLeave
        Label9.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub Label10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.MouseEnter
        Label10.ForeColor = Color.Black

    End Sub

    Private Sub Label10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.MouseLeave
        Label10.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub Label7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseEnter
        Label7.ForeColor = Color.Black
    End Sub

    Private Sub Label7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub Label8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseEnter
        Label8.ForeColor = Color.Black
    End Sub

    Private Sub Label8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseLeave
        Label8.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Then
            source1.Filter = ""
            Me.DataGridView1.Refresh()
        Else
            source1.Filter = "[ID No] like  '%' + '" & TextBox6.Text & "' + '%' "
            Me.DataGridView1.Refresh()
        End If
    End Sub
End Class
