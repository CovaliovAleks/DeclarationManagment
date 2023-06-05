<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonsForm
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
        Me.grbFilters = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grbInfo = New System.Windows.Forms.GroupBox()
        Me.grbData = New System.Windows.Forms.GroupBox()
        Me.dgvPerson = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grbFilters.SuspendLayout()
        Me.grbInfo.SuspendLayout()
        Me.grbData.SuspendLayout()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbFilters
        '
        Me.grbFilters.Controls.Add(Me.Button1)
        Me.grbFilters.Controls.Add(Me.TextBox1)
        Me.grbFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFilters.Location = New System.Drawing.Point(0, 0)
        Me.grbFilters.Name = "grbFilters"
        Me.grbFilters.Size = New System.Drawing.Size(1021, 82)
        Me.grbFilters.TabIndex = 1
        Me.grbFilters.TabStop = False
        Me.grbFilters.Text = "Фильтры"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(577, 30)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(603, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grbInfo
        '
        Me.grbInfo.Controls.Add(Me.GroupBox2)
        Me.grbInfo.Controls.Add(Me.GroupBox1)
        Me.grbInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.grbInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbInfo.Location = New System.Drawing.Point(678, 82)
        Me.grbInfo.Name = "grbInfo"
        Me.grbInfo.Size = New System.Drawing.Size(343, 550)
        Me.grbInfo.TabIndex = 2
        Me.grbInfo.TabStop = False
        Me.grbInfo.Text = "Дополнительно"
        '
        'grbData
        '
        Me.grbData.Controls.Add(Me.dgvPerson)
        Me.grbData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbData.Location = New System.Drawing.Point(0, 82)
        Me.grbData.Name = "grbData"
        Me.grbData.Size = New System.Drawing.Size(678, 550)
        Me.grbData.TabIndex = 3
        Me.grbData.TabStop = False
        '
        'dgvPerson
        '
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPerson.Location = New System.Drawing.Point(3, 23)
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.RowHeadersWidth = 51
        Me.dgvPerson.RowTemplate.Height = 24
        Me.dgvPerson.Size = New System.Drawing.Size(672, 524)
        Me.dgvPerson.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ИНН"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "ФИО"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 180
        '
        'Column3
        '
        Me.Column3.HeaderText = "Дата рождения"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Адрес"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.tbAddress)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbPhone)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 268)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Декларации"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(331, 242)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "№"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Дата"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Сумма"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Налог"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Телефон"
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(94, 173)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(234, 27)
        Me.tbPhone.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Адрес"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(94, 217)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(234, 27)
        Me.tbAddress.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(94, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 144)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Фото"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PersonsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 632)
        Me.Controls.Add(Me.grbData)
        Me.Controls.Add(Me.grbInfo)
        Me.Controls.Add(Me.grbFilters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PersonsForm"
        Me.Text = "PersonsForm"
        Me.grbFilters.ResumeLayout(False)
        Me.grbFilters.PerformLayout()
        Me.grbInfo.ResumeLayout(False)
        Me.grbData.ResumeLayout(False)
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbFilters As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents grbInfo As GroupBox
    Friend WithEvents grbData As GroupBox
    Friend WithEvents dgvPerson As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPhone As TextBox
End Class
