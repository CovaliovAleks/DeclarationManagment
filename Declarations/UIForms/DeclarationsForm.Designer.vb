<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeclarationsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbFilters = New System.Windows.Forms.GroupBox()
        Me.mtbDeclarationTo = New System.Windows.Forms.MaskedTextBox()
        Me.mtbDeclarationFrom = New System.Windows.Forms.MaskedTextBox()
        Me.btnSetFilter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAddDataFiltr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDeclarations = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbFilters.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDeclarations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Дата с "
        '
        'grbFilters
        '
        Me.grbFilters.Controls.Add(Me.mtbDeclarationTo)
        Me.grbFilters.Controls.Add(Me.mtbDeclarationFrom)
        Me.grbFilters.Controls.Add(Me.btnSetFilter)
        Me.grbFilters.Controls.Add(Me.Label3)
        Me.grbFilters.Controls.Add(Me.tbAddDataFiltr)
        Me.grbFilters.Controls.Add(Me.Label2)
        Me.grbFilters.Controls.Add(Me.Label1)
        Me.grbFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFilters.Location = New System.Drawing.Point(0, 0)
        Me.grbFilters.Name = "grbFilters"
        Me.grbFilters.Size = New System.Drawing.Size(982, 85)
        Me.grbFilters.TabIndex = 0
        Me.grbFilters.TabStop = False
        Me.grbFilters.Text = "Фильтры"
        '
        'mtbDeclarationTo
        '
        Me.mtbDeclarationTo.Location = New System.Drawing.Point(160, 50)
        Me.mtbDeclarationTo.Name = "mtbDeclarationTo"
        Me.mtbDeclarationTo.Size = New System.Drawing.Size(134, 28)
        Me.mtbDeclarationTo.TabIndex = 8
        '
        'mtbDeclarationFrom
        '
        Me.mtbDeclarationFrom.Location = New System.Drawing.Point(16, 51)
        Me.mtbDeclarationFrom.Name = "mtbDeclarationFrom"
        Me.mtbDeclarationFrom.Size = New System.Drawing.Size(134, 28)
        Me.mtbDeclarationFrom.TabIndex = 7
        '
        'btnSetFilter
        '
        Me.btnSetFilter.Location = New System.Drawing.Point(666, 37)
        Me.btnSetFilter.Name = "btnSetFilter"
        Me.btnSetFilter.Size = New System.Drawing.Size(151, 41)
        Me.btnSetFilter.TabIndex = 6
        Me.btnSetFilter.Text = "Фильтровать"
        Me.btnSetFilter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "доп данные"
        '
        'tbAddDataFiltr
        '
        Me.tbAddDataFiltr.Location = New System.Drawing.Point(300, 50)
        Me.tbAddDataFiltr.Name = "tbAddDataFiltr"
        Me.tbAddDataFiltr.Size = New System.Drawing.Size(333, 28)
        Me.tbAddDataFiltr.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "по"
        '
        'GroupBox1
        '
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 616)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(982, 17)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvDeclarations)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(982, 531)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'dgvDeclarations
        '
        Me.dgvDeclarations.AllowUserToAddRows = False
        Me.dgvDeclarations.AllowUserToDeleteRows = False
        Me.dgvDeclarations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeclarations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvDeclarations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDeclarations.Location = New System.Drawing.Point(3, 18)
        Me.dgvDeclarations.MultiSelect = False
        Me.dgvDeclarations.Name = "dgvDeclarations"
        Me.dgvDeclarations.ReadOnly = True
        Me.dgvDeclarations.RowHeadersWidth = 51
        Me.dgvDeclarations.RowTemplate.Height = 24
        Me.dgvDeclarations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDeclarations.Size = New System.Drawing.Size(976, 510)
        Me.dgvDeclarations.TabIndex = 0
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Id"
        Me.Column7.HeaderText = "Id"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        Me.Column7.Width = 125
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "NrDeclaration"
        Me.Column1.HeaderText = "№ Декларации"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "DateCreatedAt"
        Me.Column6.HeaderText = "Дата"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "PersonFio"
        Me.Column2.HeaderText = "Физ. лицо"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "CompanyName"
        Me.Column3.HeaderText = "Компания"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "SummaAll"
        Me.Column4.HeaderText = "Сумма"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "SummaTax"
        Me.Column5.HeaderText = "Налог"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'DeclarationsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 633)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grbFilters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DeclarationsForm"
        Me.Text = "DeclarationsForm"
        Me.grbFilters.ResumeLayout(False)
        Me.grbFilters.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDeclarations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents grbFilters As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvDeclarations As DataGridView
    Friend WithEvents btnSetFilter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAddDataFiltr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbDeclarationTo As MaskedTextBox
    Friend WithEvents mtbDeclarationFrom As MaskedTextBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
