<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.control_no_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.school_id_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.school_name_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.district_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.school_head_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Teaching_Personnel_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Non_teaching_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.YEAR_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AIP_ = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GAD_ = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t4 = New System.Windows.Forms.TextBox()
        Me.t10 = New System.Windows.Forms.TextBox()
        Me.t9 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.t7 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.t5 = New System.Windows.Forms.TextBox()
        Me.t6 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.control_no_, Me.school_id_, Me.school_name_, Me.address_, Me.district_, Me.school_head_, Me.contact_no, Me.email_, Me.Teaching_Personnel_, Me.Non_teaching_})
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(32, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(436, 674)
        Me.DataGridView1.TabIndex = 0
        '
        'control_no_
        '
        Me.control_no_.DataPropertyName = "ID"
        Me.control_no_.HeaderText = "Control No"
        Me.control_no_.MinimumWidth = 6
        Me.control_no_.Name = "control_no_"
        Me.control_no_.ReadOnly = True
        Me.control_no_.Visible = False
        Me.control_no_.Width = 125
        '
        'school_id_
        '
        Me.school_id_.DataPropertyName = "school_id"
        Me.school_id_.HeaderText = "School ID"
        Me.school_id_.MinimumWidth = 6
        Me.school_id_.Name = "school_id_"
        Me.school_id_.ReadOnly = True
        Me.school_id_.Width = 125
        '
        'school_name_
        '
        Me.school_name_.DataPropertyName = "school_name"
        Me.school_name_.HeaderText = "School Name"
        Me.school_name_.MinimumWidth = 6
        Me.school_name_.Name = "school_name_"
        Me.school_name_.ReadOnly = True
        Me.school_name_.Width = 125
        '
        'address_
        '
        Me.address_.DataPropertyName = "school_address"
        Me.address_.HeaderText = "Address"
        Me.address_.MinimumWidth = 6
        Me.address_.Name = "address_"
        Me.address_.ReadOnly = True
        Me.address_.Width = 125
        '
        'district_
        '
        Me.district_.DataPropertyName = "district"
        Me.district_.HeaderText = "District"
        Me.district_.MinimumWidth = 6
        Me.district_.Name = "district_"
        Me.district_.ReadOnly = True
        Me.district_.Width = 125
        '
        'school_head_
        '
        Me.school_head_.DataPropertyName = "school_head"
        Me.school_head_.HeaderText = "School Head"
        Me.school_head_.MinimumWidth = 6
        Me.school_head_.Name = "school_head_"
        Me.school_head_.ReadOnly = True
        Me.school_head_.Width = 125
        '
        'contact_no
        '
        Me.contact_no.DataPropertyName = "contact_no"
        Me.contact_no.HeaderText = "Contact no"
        Me.contact_no.MinimumWidth = 6
        Me.contact_no.Name = "contact_no"
        Me.contact_no.ReadOnly = True
        Me.contact_no.Width = 125
        '
        'email_
        '
        Me.email_.DataPropertyName = "email"
        Me.email_.HeaderText = "Email"
        Me.email_.MinimumWidth = 6
        Me.email_.Name = "email_"
        Me.email_.ReadOnly = True
        Me.email_.Width = 125
        '
        'Teaching_Personnel_
        '
        Me.Teaching_Personnel_.DataPropertyName = "teaching_personnel"
        Me.Teaching_Personnel_.HeaderText = "Teaching Personnel"
        Me.Teaching_Personnel_.MinimumWidth = 6
        Me.Teaching_Personnel_.Name = "Teaching_Personnel_"
        Me.Teaching_Personnel_.ReadOnly = True
        Me.Teaching_Personnel_.Width = 125
        '
        'Non_teaching_
        '
        Me.Non_teaching_.DataPropertyName = "non_teaching_personnel"
        Me.Non_teaching_.HeaderText = "Non Teaching Personnel"
        Me.Non_teaching_.MinimumWidth = 6
        Me.Non_teaching_.Name = "Non_teaching_"
        Me.Non_teaching_.ReadOnly = True
        Me.Non_teaching_.Width = 125
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.YEAR_, Me.AIP_, Me.GAD_})
        Me.DataGridView2.GridColor = System.Drawing.Color.White
        Me.DataGridView2.Location = New System.Drawing.Point(1085, 42)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(303, 444)
        Me.DataGridView2.TabIndex = 13
        '
        'YEAR_
        '
        Me.YEAR_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.YEAR_.DataPropertyName = "year"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Snow
        Me.YEAR_.DefaultCellStyle = DataGridViewCellStyle1
        Me.YEAR_.HeaderText = "YEAR"
        Me.YEAR_.MinimumWidth = 6
        Me.YEAR_.Name = "YEAR_"
        Me.YEAR_.ReadOnly = True
        Me.YEAR_.Width = 75
        '
        'AIP_
        '
        Me.AIP_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AIP_.DataPropertyName = "AIP"
        Me.AIP_.HeaderText = "AIP"
        Me.AIP_.MinimumWidth = 6
        Me.AIP_.Name = "AIP_"
        Me.AIP_.ReadOnly = True
        Me.AIP_.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AIP_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GAD_
        '
        Me.GAD_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GAD_.DataPropertyName = "GAD"
        Me.GAD_.HeaderText = "GAD"
        Me.GAD_.MinimumWidth = 6
        Me.GAD_.Name = "GAD_"
        Me.GAD_.ReadOnly = True
        Me.GAD_.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GAD_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(16, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Address"
        '
        't4
        '
        Me.t4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.t4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.t4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t4.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.t4.Location = New System.Drawing.Point(218, 167)
        Me.t4.Margin = New System.Windows.Forms.Padding(4)
        Me.t4.Multiline = True
        Me.t4.Name = "t4"
        Me.t4.ReadOnly = True
        Me.t4.Size = New System.Drawing.Size(298, 64)
        Me.t4.TabIndex = 3
        '
        't10
        '
        Me.t10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.t10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.t10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t10.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.t10.Location = New System.Drawing.Point(218, 437)
        Me.t10.Margin = New System.Windows.Forms.Padding(4)
        Me.t10.Multiline = True
        Me.t10.Name = "t10"
        Me.t10.ReadOnly = True
        Me.t10.Size = New System.Drawing.Size(298, 29)
        Me.t10.TabIndex = 9
        '
        't9
        '
        Me.t9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.t9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.t9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t9.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.t9.Location = New System.Drawing.Point(218, 400)
        Me.t9.Margin = New System.Windows.Forms.Padding(4)
        Me.t9.Multiline = True
        Me.t9.Name = "t9"
        Me.t9.ReadOnly = True
        Me.t9.Size = New System.Drawing.Size(298, 29)
        Me.t9.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(16, 449)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Non-Teaching personel"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Snow
        Me.Button6.Location = New System.Drawing.Point(396, 505)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 49)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Snow
        Me.Button5.Location = New System.Drawing.Point(279, 505)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 49)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Update"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Snow
        Me.Button8.Location = New System.Drawing.Point(278, 505)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 49)
        Me.Button8.TabIndex = 22
        Me.Button8.Text = "Save"
        Me.Button8.UseVisualStyleBackColor = False
        Me.Button8.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Snow
        Me.Button4.Location = New System.Drawing.Point(278, 505)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 49)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Snow
        Me.Button3.Location = New System.Drawing.Point(162, 505)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 49)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(16, 406)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Teaching personel"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Snow
        Me.Button2.Location = New System.Drawing.Point(44, 505)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 49)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(16, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Control No:"
        '
        't8
        '
        Me.t8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.t8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.t8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t8.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.t8.Location = New System.Drawing.Point(218, 359)
        Me.t8.Margin = New System.Windows.Forms.Padding(4)
        Me.t8.Multiline = True
        Me.t8.Name = "t8"
        Me.t8.ReadOnly = True
        Me.t8.Size = New System.Drawing.Size(298, 29)
        Me.t8.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(16, 359)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Email"
        '
        't7
        '
        Me.t7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.t7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.t7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t7.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.t7.Location = New System.Drawing.Point(218, 321)
        Me.t7.Margin = New System.Windows.Forms.Padding(4)
        Me.t7.Multiline = True
        Me.t7.Name = "t7"
        Me.t7.ReadOnly = True
        Me.t7.Size = New System.Drawing.Size(298, 29)
        Me.t7.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(16, 322)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 18)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Contact no."
        '
        't2
        '
        Me.t2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.t2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.t2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.t2.Location = New System.Drawing.Point(218, 54)
        Me.t2.Margin = New System.Windows.Forms.Padding(4)
        Me.t2.Multiline = True
        Me.t2.Name = "t2"
        Me.t2.ReadOnly = True
        Me.t2.Size = New System.Drawing.Size(298, 29)
        Me.t2.TabIndex = 1
        Me.t2.Text = " "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Window
        Me.Label13.Location = New System.Drawing.Point(16, 279)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 18)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "School Head"
        '
        't1
        '
        Me.t1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.t1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.t1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.t1.Location = New System.Drawing.Point(218, 17)
        Me.t1.Margin = New System.Windows.Forms.Padding(4)
        Me.t1.Multiline = True
        Me.t1.Name = "t1"
        Me.t1.ReadOnly = True
        Me.t1.Size = New System.Drawing.Size(298, 29)
        Me.t1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Window
        Me.Label14.Location = New System.Drawing.Point(16, 240)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 18)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "District"
        '
        't3
        '
        Me.t3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.t3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.t3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.t3.Location = New System.Drawing.Point(218, 96)
        Me.t3.Margin = New System.Windows.Forms.Padding(4)
        Me.t3.Multiline = True
        Me.t3.Name = "t3"
        Me.t3.ReadOnly = True
        Me.t3.Size = New System.Drawing.Size(298, 64)
        Me.t3.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Window
        Me.Label15.Location = New System.Drawing.Point(18, 97)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 18)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "School Name:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Window
        Me.Label16.Location = New System.Drawing.Point(16, 55)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 18)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "School ID:"
        '
        't5
        '
        Me.t5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.t5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.t5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t5.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.t5.Location = New System.Drawing.Point(218, 239)
        Me.t5.Margin = New System.Windows.Forms.Padding(4)
        Me.t5.Multiline = True
        Me.t5.Name = "t5"
        Me.t5.ReadOnly = True
        Me.t5.Size = New System.Drawing.Size(298, 29)
        Me.t5.TabIndex = 4
        '
        't6
        '
        Me.t6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.t6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.t6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.t6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t6.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.t6.Location = New System.Drawing.Point(218, 278)
        Me.t6.Margin = New System.Windows.Forms.Padding(4)
        Me.t6.Multiline = True
        Me.t6.Name = "t6"
        Me.t6.ReadOnly = True
        Me.t6.Size = New System.Drawing.Size(298, 29)
        Me.t6.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(373, -30)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 22)
        Me.TextBox1.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(904, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(847, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(29, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "school_name"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(496, 655)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 53)
        Me.Button1.TabIndex = 28
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1400, 36)
        Me.Panel1.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Button9)
        Me.Panel3.Controls.Add(Me.TextBox10)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(521, 36)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(557, 713)
        Me.Panel3.TabIndex = 31
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.t2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.t6)
        Me.Panel4.Controls.Add(Me.t4)
        Me.Panel4.Controls.Add(Me.t5)
        Me.Panel4.Controls.Add(Me.t10)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.t9)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.t3)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.t1)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.t7)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.t8)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(25, 73)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(520, 577)
        Me.Panel4.TabIndex = 29
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Snow
        Me.Button7.Location = New System.Drawing.Point(400, 23)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(121, 39)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Search"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Snow
        Me.Button9.Location = New System.Drawing.Point(35, 663)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(120, 36)
        Me.Button9.TabIndex = 27
        Me.Button9.Text = "Refresh"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(229, 30)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(153, 25)
        Me.TextBox10.TabIndex = 19
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"School ID", "School Name", "Address", "District", "School Head", "Contact", "Email", "Teaching personnel", "Non-Teaching personnel"})
        Me.ComboBox1.Location = New System.Drawing.Point(44, 22)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 31)
        Me.ComboBox1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 36)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 735)
        Me.Panel2.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 771)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents t8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents t7 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents t2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents t1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents t3 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents t5 As TextBox
    Friend WithEvents t6 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents t10 As TextBox
    Friend WithEvents t9 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents t4 As TextBox
    Friend WithEvents control_no_ As DataGridViewTextBoxColumn
    Friend WithEvents school_id_ As DataGridViewTextBoxColumn
    Friend WithEvents school_name_ As DataGridViewTextBoxColumn
    Friend WithEvents address_ As DataGridViewTextBoxColumn
    Friend WithEvents district_ As DataGridViewTextBoxColumn
    Friend WithEvents school_head_ As DataGridViewTextBoxColumn
    Friend WithEvents contact_no As DataGridViewTextBoxColumn
    Friend WithEvents email_ As DataGridViewTextBoxColumn
    Friend WithEvents Teaching_Personnel_ As DataGridViewTextBoxColumn
    Friend WithEvents Non_teaching_ As DataGridViewTextBoxColumn
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents YEAR_ As DataGridViewTextBoxColumn
    Friend WithEvents AIP_ As DataGridViewCheckBoxColumn
    Friend WithEvents GAD_ As DataGridViewCheckBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
End Class
