Imports System.Data.OleDb
Imports System.Data
Imports System.Data.DataTable
Imports System.Runtime.CompilerServices

Public Class SBM
    Dim source1 As New BindingSource()

    Dim ds As DataSet = New DataSet
    Dim tables As DataTableCollection = ds.Tables
    Sub fill()
        Dim dt As New DataTable
        Dim str As String = "Select * FROM perinfo ORDER BY control_no DESC"
        Dim da As New OleDb.OleDbDataAdapter(str, con)
        da.Fill(dt)
        da.Dispose()
        source1.DataSource = dt
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub


    Public Sub delterminated(ByRef id As String)
        Try
            Dim str1 As String = "Delete * from perinfo where [perinfo.controlno]= '" & id & "'"
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
        Button6.Visible = False
        Button5.Visible = False
        Button8.PerformClick()

    End Sub





    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Button1.Visible = False
        Button7.Visible = False
        Button5.Visible = False
        Button5.TextAlign = ContentAlignment.MiddleCenter
        Button3.Visible = False
        Button6.Visible = True

        active_textBox_edit()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim dr As New DialogResult
        dr = MessageBox.Show("Are you sure you want to permanently delete selected data?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If dr = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("Action aborted!", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            con.Open()
            Dim cmd1 As New OleDbCommand("DELETE * FROM perinfo WHERE control_no = '" & TextBox1.Text & "'", con)
            cmd1.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Deleted")
            fill()
        End If
    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button3.Visible = True
        Button1.Visible = True
        Button7.Visible = True
        Button5.Visible = False
        Button6.Visible = False
        disable_textBox()
        fill()
        DataGridView1.Enabled = True
        Button2.Visible = True
    End Sub


    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.Black
        Button1.BackColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.White
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.ForeColor = Color.Black
        Button3.BackColor = Color.White
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.White
        Button3.BackColor = Color.Black
    End Sub

    Private Sub Button7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseEnter
        Button7.ForeColor = Color.Black
        Button7.BackColor = Color.White

    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.White
        Button7.BackColor = Color.Black
    End Sub

    Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.Black
        Button5.BackColor = Color.White
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.White
        Button5.BackColor = Color.Black
    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        Button6.ForeColor = Color.Black
        Button6.BackColor = Color.White
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.ForeColor = Color.White
        Button6.BackColor = Color.Black
    End Sub

    Private Sub Button8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseEnter
        Button8.ForeColor = Color.Black
        Button8.BackColor = Color.White
    End Sub

    Private Sub Button8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        Button8.ForeColor = Color.White
        Button8.BackColor = Color.Black
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Enabled = False
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
        Button7.Visible = False
        Button5.Visible = True
        Set_control_no()
        active_textBox()
        TextBox2.Select()
    End Sub

    Private Sub Set_control_no()
        con.Open()
        Dim str1 As String = "SELECT MAX(control_no)+1 FROM perinfo"
        Dim cmd1 As New OleDbCommand(str1, con)
        Dim reader As OleDbDataReader = cmd1.ExecuteReader
        If reader.Read Then
            TextBox1.Text = reader.GetValue(0).ToString
        End If
        con.Close()
    End Sub
    Private Sub active_textBox()


        TextBox1.BackColor = Color.White
        TextBox1.Cursor = Cursors.Arrow
        TextBox1.ReadOnly = True
        TextBox1.ForeColor = Color.Black

        TextBox2.Clear()
        TextBox2.BackColor = Color.White
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.ReadOnly = False
        TextBox2.ForeColor = Color.Black

        TextBox3.Clear()
        TextBox3.BackColor = Color.White
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.ReadOnly = False
        TextBox3.ForeColor = Color.Black

        TextBox4.Clear()
        TextBox4.BackColor = Color.White
        TextBox4.Cursor = Cursors.IBeam
        TextBox4.ReadOnly = False
        TextBox4.ForeColor = Color.Black

        TextBox5.Clear()
        TextBox5.BackColor = Color.White
        TextBox5.Cursor = Cursors.IBeam
        TextBox5.ReadOnly = False
        TextBox5.ForeColor = Color.Black

        TextBox6.Clear()
        TextBox6.BackColor = Color.White
        TextBox6.Cursor = Cursors.IBeam
        TextBox6.ReadOnly = False
        TextBox6.ForeColor = Color.Black

        TextBox7.Clear()
        TextBox7.BackColor = Color.White
        TextBox7.Cursor = Cursors.IBeam
        TextBox7.ReadOnly = False
        TextBox7.ForeColor = Color.Black
    End Sub

    Private Sub active_textBox_edit()


        TextBox1.BackColor = Color.White
        TextBox1.Cursor = Cursors.Arrow
        TextBox1.ReadOnly = True
        TextBox1.ForeColor = Color.Black


        TextBox2.BackColor = Color.White
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.ReadOnly = False
        TextBox2.ForeColor = Color.Black


        TextBox3.BackColor = Color.White
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.ReadOnly = False
        TextBox3.ForeColor = Color.Black


        TextBox4.BackColor = Color.White
        TextBox4.Cursor = Cursors.IBeam
        TextBox4.ReadOnly = False
        TextBox4.ForeColor = Color.Black


        TextBox5.BackColor = Color.White
        TextBox5.Cursor = Cursors.IBeam
        TextBox5.ReadOnly = False
        TextBox5.ForeColor = Color.Black


        TextBox6.BackColor = Color.White
        TextBox6.Cursor = Cursors.IBeam
        TextBox6.ReadOnly = False
        TextBox6.ForeColor = Color.Black


        TextBox7.BackColor = Color.White
        TextBox7.Cursor = Cursors.IBeam
        TextBox7.ReadOnly = False
        TextBox7.ForeColor = Color.Black
    End Sub

    Private Sub disable_textBox()
        TextBox1.Clear()
        TextBox1.BackColor = Color.Black
        TextBox1.Cursor = Cursors.Arrow
        TextBox1.ReadOnly = True
        TextBox1.ForeColor = Color.White

        TextBox2.Clear()
        TextBox2.BackColor = Color.Black
        TextBox2.Cursor = Cursors.Arrow
        TextBox2.ReadOnly = True
        TextBox2.ForeColor = Color.White

        TextBox3.Clear()
        TextBox3.BackColor = Color.Black
        TextBox3.Cursor = Cursors.Arrow
        TextBox3.ReadOnly = True
        TextBox3.ForeColor = Color.White

        TextBox4.Clear()
        TextBox4.BackColor = Color.Black
        TextBox4.Cursor = Cursors.Arrow
        TextBox4.ReadOnly = True
        TextBox4.ForeColor = Color.White

        TextBox5.Clear()
        TextBox5.BackColor = Color.Black
        TextBox5.Cursor = Cursors.Arrow
        TextBox5.ReadOnly = True
        TextBox5.ForeColor = Color.White

        TextBox6.Clear()
        TextBox6.BackColor = Color.Black
        TextBox6.Cursor = Cursors.Arrow
        TextBox6.ReadOnly = True
        TextBox6.ForeColor = Color.White

        TextBox7.Clear()
        TextBox7.BackColor = Color.Black
        TextBox7.Cursor = Cursors.Arrow
        TextBox7.ReadOnly = True
        TextBox7.ForeColor = Color.White
    End Sub
    Private Sub DG_to_TB()


        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        TextBox7.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString



    End Sub

    Dim cra As Integer = 0
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then
            Dim roww As New DataGridViewRow
            roww = DataGridView1.Rows(e.RowIndex)
            DG_to_TB()
            cra = 0
        ElseIf e.RowIndex = -1 Then
            cra = 1
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        con.Open()
        Dim cmd1 As New OleDbCommand("INSERT INTO perinfo([control_no],[school_id],[school_name],[yearr],
                                    [SBM_lvl],[remarks],[district]) 
                                    VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "',
                                    '" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "');", con)
        cmd1.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Added!")
        fill()
        Button3.Visible = True
        Button1.Visible = True
        Button7.Visible = True
        disable_textBox()
        Button5.Visible = False

        Button3.Visible = False
        Button1.Visible = False
        Button7.Visible = False
        Button5.Visible = True
        Set_control_no()
        active_textBox()
        TextBox2.Select()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        con.Open()
        Dim cmd1 As New OleDbCommand("UPDATE [perinfo] SET school_id =  '" & TextBox2.Text & "',school_name =  '" & TextBox3.Text & "',yearr = '" & TextBox4.Text & "', SBM_lvl = '" & TextBox5.Text & "',remarks = '" & TextBox6.Text & "',district = '" & TextBox7.Text & "' WHERE control_no =  '" & TextBox1.Text & "' ", con)
        cmd1.ExecuteNonQuery()
        con.Close()
        fill()
        DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        MessageBox.Show("Updated")
        Button3.Visible = True
        Button1.Visible = True
        Button7.Visible = True
        Button5.Visible = False
        Button6.Visible = False
        disable_textBox()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If ComboBox1.Text.Length = 0 Then
            MessageBox.Show("select an option")
        Else
            searchh()
        End If

    End Sub

    Private Sub searchh()
        Dim cmd As New OleDbCommand("SELECT * FROM perinfo WHERE " & Label18.Text & " LIKE '%" & TextBox8.Text & "%'", con)
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
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged


    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If cra = 0 Then
            DG_to_TB()
        End If
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.Black
        Label5.BackColor = Color.White
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.White
        Label5.BackColor = Color.Black
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "School id" Then
            Label18.Text = "school_id"
        End If
        If ComboBox1.Text = "School name" Then
            Label18.Text = "school_name"
        End If
        If ComboBox1.Text = "SBM level" Then
            Label18.Text = "SBM_lvl"
        End If
        If ComboBox1.Text = "Year" Then
            Label18.Text = "yearr"
        End If
        If ComboBox1.Text = "District" Then
            Label18.Text = "district"
        End If
        If ComboBox1.Text = "Remarks" Then
            Label18.Text = "remarks"
        End If
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fill()
    End Sub

    Private Sub SBM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
