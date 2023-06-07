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
        Me.btnFiltrRun = New System.Windows.Forms.Button()
        Me.tbFilter = New System.Windows.Forms.TextBox()
        Me.grbInfo = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbDocument = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbINN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbData = New System.Windows.Forms.GroupBox()
        Me.dgvPerson = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbFilters.SuspendLayout()
        Me.grbInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grbData.SuspendLayout()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbFilters
        '
        Me.grbFilters.Controls.Add(Me.btnFiltrRun)
        Me.grbFilters.Controls.Add(Me.tbFilter)
        Me.grbFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFilters.Location = New System.Drawing.Point(0, 0)
        Me.grbFilters.Name = "grbFilters"
        Me.grbFilters.Size = New System.Drawing.Size(1021, 82)
        Me.grbFilters.TabIndex = 1
        Me.grbFilters.TabStop = False
        Me.grbFilters.Text = "Фильтр"
        '
        'btnFiltrRun
        '
        Me.btnFiltrRun.Location = New System.Drawing.Point(603, 24)
        Me.btnFiltrRun.Name = "btnFiltrRun"
        Me.btnFiltrRun.Size = New System.Drawing.Size(155, 34)
        Me.btnFiltrRun.TabIndex = 1
        Me.btnFiltrRun.Text = "Фильтровать"
        Me.btnFiltrRun.UseVisualStyleBackColor = True
        '
        'tbFilter
        '
        Me.tbFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFilter.Location = New System.Drawing.Point(6, 27)
        Me.tbFilter.MaxLength = 20
        Me.tbFilter.Name = "tbFilter"
        Me.tbFilter.Size = New System.Drawing.Size(577, 30)
        Me.tbFilter.TabIndex = 0
        '
        'grbInfo
        '
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbDocument)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbINN)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbAddress)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbPhone)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 524)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tbDocument
        '
        Me.tbDocument.Location = New System.Drawing.Point(94, 143)
        Me.tbDocument.Name = "tbDocument"
        Me.tbDocument.Size = New System.Drawing.Size(234, 27)
        Me.tbDocument.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Документ"
        '
        'tbINN
        '
        Me.tbINN.Location = New System.Drawing.Point(94, 22)
        Me.tbINN.Name = "tbINN"
        Me.tbINN.Size = New System.Drawing.Size(234, 27)
        Me.tbINN.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ИНН"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(94, 101)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(234, 27)
        Me.tbAddress.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Адрес"
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(94, 57)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(234, 27)
        Me.tbPhone.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Телефон"
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
        Me.dgvPerson.AllowUserToAddRows = False
        Me.dgvPerson.AllowUserToDeleteRows = False
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3})
        Me.dgvPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPerson.Location = New System.Drawing.Point(3, 23)
        Me.dgvPerson.MultiSelect = False
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.ReadOnly = True
        Me.dgvPerson.RowHeadersWidth = 51
        Me.dgvPerson.RowTemplate.Height = 24
        Me.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPerson.Size = New System.Drawing.Size(672, 524)
        Me.dgvPerson.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ID"
        Me.Column5.HeaderText = "ID"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        Me.Column5.Width = 125
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "INN"
        Me.Column1.HeaderText = "ИНН"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "FIO"
        Me.Column2.HeaderText = "ФИО"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 210
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "BornDate"
        Me.Column3.HeaderText = "Дата рождения"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 170
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbData.ResumeLayout(False)
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbFilters As GroupBox
    Friend WithEvents tbFilter As TextBox
    Friend WithEvents btnFiltrRun As Button
    Friend WithEvents grbInfo As GroupBox
    Friend WithEvents grbData As GroupBox
    Friend WithEvents dgvPerson As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents tbDocument As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbINN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
