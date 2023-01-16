Imports System.Data.OleDb
Imports System.Data
Imports System.Data.DataTable
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        SBM.Show()
        Hide()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill_School_list()
        TextBox1.Text = System.DateTime.Now.Year
    End Sub

    Private Sub Fill_School_list()
        Dim cmd As New OleDbCommand("SELECT ID, school_id,school_name,school_address,district,school_head, 
                        contact_no, email, teaching_personnel, non_teaching_personnel FROM school_list ORDER BY id DESC", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Dim adaptr As New OleDbDataAdapter
        Dim data_table As New DataTable
        adaptr.SelectCommand = cmd
        adaptr.Fill(data_table)
        adaptr.Dispose()
        DataGridView1.DataSource = data_table

    End Sub

    Private Sub Load_checklist()
        Dim cmd As New OleDbCommand("SELECT year,AIP,GAD FROM check_list WHERE school_control_no = '" & t1.Text & "' AND year <= '" & TextBox1.Text & "'ORDER BY year DESC", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Dim adaptr As New OleDbDataAdapter
        Dim data_table As New DataTable
        adaptr.SelectCommand = cmd
        adaptr.Fill(data_table)
        adaptr.Dispose()
        DataGridView2.DataSource = data_table
    End Sub
    Dim row_count As Integer
    Private Sub G_to_TB()
        row_count = DataGridView2.Rows.Count
        Label5.Text = row_count
        t1.Text = DataGridView1.CurrentRow.Cells(0).Value
        t2.Text = DataGridView1.CurrentRow.Cells(1).Value
        t3.Text = DataGridView1.CurrentRow.Cells(2).Value
        t4.Text = DataGridView1.CurrentRow.Cells(3).Value
        t5.Text = DataGridView1.CurrentRow.Cells(4).Value
        t6.Text = DataGridView1.CurrentRow.Cells(5).Value
        t7.Text = DataGridView1.CurrentRow.Cells(6).Value
        t8.Text = DataGridView1.CurrentRow.Cells(7).Value
        t9.Text = DataGridView1.CurrentRow.Cells(8).Value
        t10.Text = DataGridView1.CurrentRow.Cells(9).Value
    End Sub



    Dim cra As Integer = 0
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then
            Dim roww As New DataGridViewRow
            roww = DataGridView1.Rows(e.RowIndex)
            G_to_TB()
            Load_checklist()
            cra = 0
        ElseIf e.RowIndex = -1 Then
            cra = 1
        End If


    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        active_tb()
        empty_textBox()
        set_control_number()
        Button2.Visible = False
        DataGridView2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button8.Visible = True

        DataGridView1.Enabled = False
        Button9.Visible = False

    End Sub

    Private Sub insert_into_school_list()
        Dim cmd As New OleDbCommand("INSERT INTO school_list([id],[school_id],[school_name],[school_address],[district],
                            [school_head],[contact_no],[email],[teaching_personnel],[non_teaching_personnel]) 
                            VALUES('" & t1.Text & "','" & t2.Text & "','" & t3.Text & "','" & t4.Text & "','" & t5.Text & "','" & t6.Text & "',
                            '" & t7.Text & "','" & t8.Text & "','" & t9.Text & "','" & t10.Text & "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub set_control_number()
        con.Open()
        Dim cmd As New OleDbCommand("SELECT MAX(ID+1) FROM school_list", con)
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        If reader.Read Then

            t1.Text = reader.GetValue(0).ToString
            If t1.Text.Length = 0 Then
                t1.Text = "0"
            End If
        End If
        con.Close()
    End Sub
    Private Sub insert_into_checklist()

        con.Open()
        For a = 13 To 30
            Dim cmd2 As New OleDbCommand("INSERT INTO check_list([school_control_no],[school_id],[year]) VALUES('" & t1.Text & "','" & t2.Text & "','20" & a & "')", con)
            cmd2.ExecuteNonQuery()
        Next
        con.Close()

    End Sub

    Private Sub update_school_list_and_check_list()
        con.Open()

        Dim cmd As New OleDbCommand("UPDATE school_list SET school_id='" & t2.Text & "',school_name='" & t3.Text & "',
                            district='" & t5.Text & "',school_head='" & t6.Text & "',school_address='" & t4.Text & "',
                            contact_no='" & t7.Text & "',email='" & t8.Text & "',teaching_personnel='" & t9.Text & "',
                            non_teaching_personnel='" & t10.Text & "' WHERE ID = '" & t1.Text & "'", con)
        cmd.ExecuteNonQuery()

        Dim b As Integer = 0
        Dim d As Integer = 13
        For a = 0 To row_count - 1
            Dim cmd3 As New OleDbCommand("UPDATE check_list SET 
                            AIP='" & Convert.ToInt64(DataGridView2.Rows(b).Cells(1).Value) & "',
                            GAD='" & Convert.ToInt64(DataGridView2.Rows(b).Cells(2).Value) & "'
                            WHERE school_control_no = '" & t1.Text & "' AND
                            year = '" & Convert.ToInt64(DataGridView2.Rows(b).Cells(0).Value) & "'", con)
            cmd3.ExecuteNonQuery()
            b = b + 1
            d = d + 1
        Next
        con.Close()

        MessageBox.Show("updated successfully")
        Load_checklist()
    End Sub




    Private Sub active_tb()
        t1.ReadOnly = True
        t2.ReadOnly = False
        t3.ReadOnly = False
        t4.ReadOnly = False
        t5.ReadOnly = False
        t6.ReadOnly = False
        t7.ReadOnly = False
        t8.ReadOnly = False
        t9.ReadOnly = False
        t10.ReadOnly = False
        t1.BackColor = Color.White
        t2.BackColor = Color.White
        t3.BackColor = Color.White
        t4.BackColor = Color.White
        t5.BackColor = Color.White
        t6.BackColor = Color.White
        t7.BackColor = Color.White
        t8.BackColor = Color.White
        t9.BackColor = Color.White
        t10.BackColor = Color.White
        t1.Cursor = Cursors.Arrow
        t2.Cursor = Cursors.Arrow
        t3.Cursor = Cursors.Arrow
        t4.Cursor = Cursors.Arrow
        t5.Cursor = Cursors.Arrow
        t6.Cursor = Cursors.Arrow
        t7.Cursor = Cursors.Arrow
        t8.Cursor = Cursors.Arrow
        t9.Cursor = Cursors.Arrow
        t10.Cursor = Cursors.Arrow
        t1.ForeColor = Color.Black
        t2.ForeColor = Color.Black
        t3.ForeColor = Color.Black
        t4.ForeColor = Color.Black
        t5.ForeColor = Color.Black
        t6.ForeColor = Color.Black
        t7.ForeColor = Color.Black
        t8.ForeColor = Color.Black
        t9.ForeColor = Color.Black
        t10.ForeColor = Color.Black
    End Sub

    Private Sub inactive_tb()
        t1.ReadOnly = True
        t2.ReadOnly = True
        t3.ReadOnly = True
        t4.ReadOnly = True
        t5.ReadOnly = True
        t6.ReadOnly = True
        t7.ReadOnly = True
        t8.ReadOnly = True
        t9.ReadOnly = True
        t10.ReadOnly = True
        t1.BackColor = Color.Black
        t2.BackColor = Color.Black
        t3.BackColor = Color.Black
        t4.BackColor = Color.Black
        t5.BackColor = Color.Black
        t6.BackColor = Color.Black
        t7.BackColor = Color.Black
        t8.BackColor = Color.Black
        t9.BackColor = Color.Black
        t10.BackColor = Color.Black
        t1.Cursor = Cursors.IBeam
        t2.Cursor = Cursors.IBeam
        t3.Cursor = Cursors.IBeam
        t4.Cursor = Cursors.IBeam
        t5.Cursor = Cursors.IBeam
        t6.Cursor = Cursors.IBeam
        t7.Cursor = Cursors.IBeam
        t8.Cursor = Cursors.IBeam
        t9.Cursor = Cursors.IBeam
        t10.Cursor = Cursors.IBeam
        t1.ForeColor = Color.White
        t2.ForeColor = Color.White
        t3.ForeColor = Color.White
        t4.ForeColor = Color.White
        t5.ForeColor = Color.White
        t6.ForeColor = Color.White
        t7.ForeColor = Color.White
        t8.ForeColor = Color.White
        t9.ForeColor = Color.White
        t10.ForeColor = Color.White
    End Sub

    Private Sub empty_textBox()
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        t5.Text = ""
        t6.Text = ""
        t7.Text = ""
        t8.Text = ""
        t9.Text = ""
        t10.Text = ""


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        insert_into_school_list()
        insert_into_checklist()
        Fill_School_list()
        inactive_tb()
        MessageBox.Show("successfully added")
        DataGridView2.Visible = True
        Button8.Visible = False
        Button5.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button2.PerformClick()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Load_checklist()
        row_count = DataGridView2.Rows.Count
        Label5.Text = row_count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        row_count = DataGridView2.Rows.Count
        Label5.Text = row_count
        active_tb()
        DataGridView2.ReadOnly = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button8.Visible = False
        Button5.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        update_school_list_and_check_list()
        Fill_School_list()
        inactive_tb()
        Button5.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True

    End Sub




    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dr As New DialogResult
        dr = MessageBox.Show("Are you sure you want to permanently delete selected data?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If dr = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("Action aborted!", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim cmd As New OleDbCommand("DELETE * FROM school_list WHERE ID = '" & t1.Text & "'", con)
            Dim cmd2 As New OleDbCommand("DELETE * FROM check_list WHERE school_control_no = '" & t1.Text & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            con.Close()
            Fill_School_list()
            MessageBox.Show("deleted")
        End If
    End Sub


    Private Sub generate_school_control()
        Dim x As New Integer
        Dim cmd As New OleDbCommand("SELECT MAX(ID+1) FROM school_list", con)
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        If reader.Read Then
            x = reader.GetValue(0)
        End If
        t1.Text = x.ToString()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        inactive_tb()
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = False
        Button8.Visible = False
        DataGridView2.Visible = True
        Fill_School_list()
        DataGridView1.Enabled = True
        Button9.Visible = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "School ID" Then
            Label7.Text = "school_id"
        End If
        If ComboBox1.Text = "School Name" Then
            Label7.Text = "school_name"
        End If
        If ComboBox1.Text = "Address" Then
            Label7.Text = "school_address"
        End If
        If ComboBox1.Text = "District" Then
            Label7.Text = "district"
        End If
        If ComboBox1.Text = "School Head" Then
            Label7.Text = "school_head"
        End If
        If ComboBox1.Text = "Email" Then
            Label7.Text = "email"
        End If
        If ComboBox1.Text = "Teaching personnel" Then
            Label7.Text = "teaching_personnel"
        End If
        If ComboBox1.Text = "Non-Teaching personnel" Then
            Label7.Text = "non_teaching_personnel"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ComboBox1.Text.Length = 0 Then
            MessageBox.Show("select an option")
        Else
            searchh()
        End If


    End Sub

    Private Sub searchh()
        Dim cmd As New OleDbCommand("SELECT * FROM school_list WHERE " & Label7.Text & " LIKE '%" & TextBox10.Text & "%'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Dim d_adapt As New OleDbDataAdapter
        Dim d_table As New DataTable
        d_adapt.SelectCommand = cmd
        d_adapt.Fill(d_table)
        d_adapt.Dispose()
        DataGridView1.DataSource = d_table

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Fill_School_list()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If cra = 0 Then
            G_to_TB()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class