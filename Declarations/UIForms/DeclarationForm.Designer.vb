<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeclarationForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtbDateDeclaration = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbSumPens = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClearPerson = New System.Windows.Forms.Button()
        Me.btnSelectPerson = New System.Windows.Forms.Button()
        Me.tbPerson = New System.Windows.Forms.TextBox()
        Me.tbSumAll = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNrDeclaration = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddDeclaration = New System.Windows.Forms.Button()
        Me.tbTaxNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTaxDistrict = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbExemptType = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbSumExempt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbComments = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbSumFinal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbSumTax = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbSumTax)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.tbSumFinal)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.tbComments)
        Me.GroupBox1.Controls.Add(Me.tbSumExempt)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.tbExemptType)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.tbTaxDistrict)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tbTaxNumber)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.mtbDateDeclaration)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbSumPens)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnClearPerson)
        Me.GroupBox1.Controls.Add(Me.btnSelectPerson)
        Me.GroupBox1.Controls.Add(Me.tbPerson)
        Me.GroupBox1.Controls.Add(Me.tbSumAll)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbNrDeclaration)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1084, 297)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Данные налоговой декларации"
        '
        'mtbDateDeclaration
        '
        Me.mtbDateDeclaration.Location = New System.Drawing.Point(511, 61)
        Me.mtbDateDeclaration.Mask = "00/00/0000"
        Me.mtbDateDeclaration.Name = "mtbDateDeclaration"
        Me.mtbDateDeclaration.Size = New System.Drawing.Size(267, 28)
        Me.mtbDateDeclaration.TabIndex = 17
        Me.mtbDateDeclaration.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(222, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(267, 22)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Величина подоходного налога"
        '
        'tbSumPens
        '
        Me.tbSumPens.Location = New System.Drawing.Point(496, 201)
        Me.tbSumPens.MaxLength = 10
        Me.tbSumPens.Name = "tbSumPens"
        Me.tbSumPens.Size = New System.Drawing.Size(282, 28)
        Me.tbSumPens.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(495, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 22)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Отчисления в пенсионный фонд"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Физ лицо"
        '
        'btnClearPerson
        '
        Me.btnClearPerson.Location = New System.Drawing.Point(281, 60)
        Me.btnClearPerson.Name = "btnClearPerson"
        Me.btnClearPerson.Size = New System.Drawing.Size(36, 29)
        Me.btnClearPerson.TabIndex = 7
        Me.btnClearPerson.Text = "x"
        Me.btnClearPerson.UseVisualStyleBackColor = True
        '
        'btnSelectPerson
        '
        Me.btnSelectPerson.Location = New System.Drawing.Point(248, 60)
        Me.btnSelectPerson.Name = "btnSelectPerson"
        Me.btnSelectPerson.Size = New System.Drawing.Size(36, 29)
        Me.btnSelectPerson.TabIndex = 2
        Me.btnSelectPerson.Text = "...."
        Me.btnSelectPerson.UseVisualStyleBackColor = True
        '
        'tbPerson
        '
        Me.tbPerson.Location = New System.Drawing.Point(12, 60)
        Me.tbPerson.Name = "tbPerson"
        Me.tbPerson.Size = New System.Drawing.Size(237, 28)
        Me.tbPerson.TabIndex = 6
        '
        'tbSumAll
        '
        Me.tbSumAll.Location = New System.Drawing.Point(14, 201)
        Me.tbSumAll.MaxLength = 10
        Me.tbSumAll.Name = "tbSumAll"
        Me.tbSumAll.Size = New System.Drawing.Size(202, 28)
        Me.tbSumAll.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Полученная сумма"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(507, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Дата подачи(составления)"
        '
        'tbNrDeclaration
        '
        Me.tbNrDeclaration.Location = New System.Drawing.Point(332, 62)
        Me.tbNrDeclaration.MaxLength = 20
        Me.tbNrDeclaration.Name = "tbNrDeclaration"
        Me.tbNrDeclaration.Size = New System.Drawing.Size(157, 28)
        Me.tbNrDeclaration.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "№ Декларации"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1084, 278)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Данные компании"
        '
        'GroupBox5
        '
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 238)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1078, 37)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox11)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.TextBox12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1078, 214)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(366, 102)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(363, 28)
        Me.TextBox11.TabIndex = 9
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(9, 170)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(321, 28)
        Me.TextBox9.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(362, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 22)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Адрес"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(248, 22)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "ФИО Директора/Бухгалтера"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(9, 102)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(321, 28)
        Me.TextBox8.TabIndex = 9
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(362, 45)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(367, 28)
        Me.TextBox12.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(362, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 22)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Телефон"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "ИНН"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(9, 45)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(321, 28)
        Me.TextBox4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Название"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCancel)
        Me.GroupBox4.Controls.Add(Me.btnAddDeclaration)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(0, 527)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1084, 100)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(900, 33)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(172, 55)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddDeclaration
        '
        Me.btnAddDeclaration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDeclaration.Location = New System.Drawing.Point(16, 33)
        Me.btnAddDeclaration.Name = "btnAddDeclaration"
        Me.btnAddDeclaration.Size = New System.Drawing.Size(157, 55)
        Me.btnAddDeclaration.TabIndex = 0
        Me.btnAddDeclaration.Text = "Add declaration"
        Me.btnAddDeclaration.UseVisualStyleBackColor = True
        '
        'tbTaxNumber
        '
        Me.tbTaxNumber.Location = New System.Drawing.Point(12, 127)
        Me.tbTaxNumber.MaxLength = 4
        Me.tbTaxNumber.Name = "tbTaxNumber"
        Me.tbTaxNumber.Size = New System.Drawing.Size(305, 28)
        Me.tbTaxNumber.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(252, 22)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Номер налоговой инспекции"
        '
        'tbTaxDistrict
        '
        Me.tbTaxDistrict.Location = New System.Drawing.Point(332, 127)
        Me.tbTaxDistrict.MaxLength = 100
        Me.tbTaxDistrict.Name = "tbTaxDistrict"
        Me.tbTaxDistrict.Size = New System.Drawing.Size(305, 28)
        Me.tbTaxDistrict.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(332, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(267, 22)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Инспекция, где стоит на учете"
        '
        'tbExemptType
        '
        Me.tbExemptType.Location = New System.Drawing.Point(222, 262)
        Me.tbExemptType.MaxLength = 150
        Me.tbExemptType.Name = "tbExemptType"
        Me.tbExemptType.Size = New System.Drawing.Size(267, 28)
        Me.tbExemptType.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(221, 236)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 22)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Название льготы"
        '
        'tbSumExempt
        '
        Me.tbSumExempt.Location = New System.Drawing.Point(495, 262)
        Me.tbSumExempt.MaxLength = 10
        Me.tbSumExempt.Name = "tbSumExempt"
        Me.tbSumExempt.Size = New System.Drawing.Size(283, 28)
        Me.tbSumExempt.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(494, 236)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 22)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Сумма льготы"
        '
        'tbComments
        '
        Me.tbComments.Location = New System.Drawing.Point(818, 62)
        Me.tbComments.MaxLength = 1000
        Me.tbComments.Multiline = True
        Me.tbComments.Name = "tbComments"
        Me.tbComments.Size = New System.Drawing.Size(254, 224)
        Me.tbComments.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(814, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 22)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Примечания"
        '
        'tbSumFinal
        '
        Me.tbSumFinal.Location = New System.Drawing.Point(14, 262)
        Me.tbSumFinal.MaxLength = 10
        Me.tbSumFinal.Name = "tbSumFinal"
        Me.tbSumFinal.Size = New System.Drawing.Size(201, 28)
        Me.tbSumFinal.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 235)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 22)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Сумма на руки"
        '
        'tbSumTax
        '
        Me.tbSumTax.Location = New System.Drawing.Point(222, 201)
        Me.tbSumTax.MaxLength = 10
        Me.tbSumTax.Name = "tbSumTax"
        Me.tbSumTax.Size = New System.Drawing.Size(267, 28)
        Me.tbSumTax.TabIndex = 29
        '
        'DeclarationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 627)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DeclarationForm"
        Me.Text = "DeclarationForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbSumAll As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNrDeclaration As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbSumPens As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClearPerson As Button
    Friend WithEvents btnSelectPerson As Button
    Friend WithEvents tbPerson As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddDeclaration As Button
    Friend WithEvents mtbDateDeclaration As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tbComments As TextBox
    Friend WithEvents tbSumExempt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbExemptType As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbTaxDistrict As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbTaxNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents tbSumFinal As TextBox
    Friend WithEvents tbSumTax As TextBox
End Class
