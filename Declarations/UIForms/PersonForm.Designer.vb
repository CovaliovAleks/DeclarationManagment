﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonForm
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddPerson = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtbBornDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtbDocIssued = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbInn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbIssued = New System.Windows.Forms.TextBox()
        Me.tbSeriaNum = New System.Windows.Forms.TextBox()
        Me.tbTypeDoc = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbStreet = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbCity = New System.Windows.Forms.TextBox()
        Me.tbPatronimyc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbSurname = New System.Windows.Forms.TextBox()
        Me.tbRegion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnAddPerson)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 371)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(781, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(607, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(157, 55)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddPerson
        '
        Me.btnAddPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPerson.Location = New System.Drawing.Point(6, 15)
        Me.btnAddPerson.Name = "btnAddPerson"
        Me.btnAddPerson.Size = New System.Drawing.Size(191, 55)
        Me.btnAddPerson.TabIndex = 1
        Me.btnAddPerson.Text = "Добавить"
        Me.btnAddPerson.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(781, 371)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Данные физ лица                   "
        '
        'GroupBox5
        '
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 362)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(775, 6)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbPhone)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.mtbBornDate)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.mtbDocIssued)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.tbInn)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbIssued)
        Me.GroupBox3.Controls.Add(Me.tbSeriaNum)
        Me.GroupBox3.Controls.Add(Me.tbTypeDoc)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.tbStreet)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.tbCity)
        Me.GroupBox3.Controls.Add(Me.tbPatronimyc)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.tbSurname)
        Me.GroupBox3.Controls.Add(Me.tbRegion)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.tbName)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(775, 338)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(324, 285)
        Me.tbPhone.MaxLength = 100
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(190, 28)
        Me.tbPhone.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 22)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Телефон"
        '
        'mtbBornDate
        '
        Me.mtbBornDate.Location = New System.Drawing.Point(9, 285)
        Me.mtbBornDate.Mask = "00/00/0000"
        Me.mtbBornDate.Name = "mtbBornDate"
        Me.mtbBornDate.Size = New System.Drawing.Size(289, 28)
        Me.mtbBornDate.TabIndex = 25
        Me.mtbBornDate.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 22)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Дата рождения *"
        '
        'mtbDocIssued
        '
        Me.mtbDocIssued.Location = New System.Drawing.Point(541, 242)
        Me.mtbDocIssued.Mask = "00/00/0000"
        Me.mtbDocIssued.Name = "mtbDocIssued"
        Me.mtbDocIssued.Size = New System.Drawing.Size(220, 28)
        Me.mtbDocIssued.TabIndex = 23
        Me.mtbDocIssued.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(545, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 22)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Дата выдачи *"
        '
        'tbInn
        '
        Me.tbInn.Location = New System.Drawing.Point(13, 44)
        Me.tbInn.MaxLength = 13
        Me.tbInn.Name = "tbInn"
        Me.tbInn.Size = New System.Drawing.Size(289, 28)
        Me.tbInn.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ИНН *"
        '
        'tbIssued
        '
        Me.tbIssued.Location = New System.Drawing.Point(539, 178)
        Me.tbIssued.MaxLength = 100
        Me.tbIssued.Name = "tbIssued"
        Me.tbIssued.Size = New System.Drawing.Size(222, 28)
        Me.tbIssued.TabIndex = 19
        '
        'tbSeriaNum
        '
        Me.tbSeriaNum.Location = New System.Drawing.Point(539, 117)
        Me.tbSeriaNum.MaxLength = 50
        Me.tbSeriaNum.Name = "tbSeriaNum"
        Me.tbSeriaNum.Size = New System.Drawing.Size(222, 28)
        Me.tbSeriaNum.TabIndex = 18
        '
        'tbTypeDoc
        '
        Me.tbTypeDoc.Location = New System.Drawing.Point(539, 53)
        Me.tbTypeDoc.MaxLength = 50
        Me.tbTypeDoc.Name = "tbTypeDoc"
        Me.tbTypeDoc.Size = New System.Drawing.Size(222, 28)
        Me.tbTypeDoc.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(547, 151)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 22)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Кем выдан *"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(547, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 22)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Серия и номер *"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(537, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 22)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Тип документа *"
        '
        'tbStreet
        '
        Me.tbStreet.Location = New System.Drawing.Point(326, 178)
        Me.tbStreet.MaxLength = 100
        Me.tbStreet.Name = "tbStreet"
        Me.tbStreet.Size = New System.Drawing.Size(190, 28)
        Me.tbStreet.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(328, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 22)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Улица, дом, кв"
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(324, 117)
        Me.tbCity.MaxLength = 100
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Size = New System.Drawing.Size(190, 28)
        Me.tbCity.TabIndex = 9
        '
        'tbPatronimyc
        '
        Me.tbPatronimyc.Location = New System.Drawing.Point(9, 223)
        Me.tbPatronimyc.MaxLength = 50
        Me.tbPatronimyc.Name = "tbPatronimyc"
        Me.tbPatronimyc.Size = New System.Drawing.Size(289, 28)
        Me.tbPatronimyc.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(324, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 22)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Населенный пункт"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 22)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Отчество"
        '
        'tbSurname
        '
        Me.tbSurname.Location = New System.Drawing.Point(9, 158)
        Me.tbSurname.MaxLength = 50
        Me.tbSurname.Name = "tbSurname"
        Me.tbSurname.Size = New System.Drawing.Size(289, 28)
        Me.tbSurname.TabIndex = 9
        '
        'tbRegion
        '
        Me.tbRegion.Location = New System.Drawing.Point(325, 53)
        Me.tbRegion.MaxLength = 100
        Me.tbRegion.Name = "tbRegion"
        Me.tbRegion.Size = New System.Drawing.Size(190, 28)
        Me.tbRegion.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(324, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 22)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Регион"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Фамилия *"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(9, 100)
        Me.tbName.MaxLength = 50
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(289, 28)
        Me.tbName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Имя *"
        '
        'PersonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 447)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PersonForm"
        Me.Text = "PersonForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbStreet As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbCity As TextBox
    Friend WithEvents tbPatronimyc As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbSurname As TextBox
    Friend WithEvents tbRegion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddPerson As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tbIssued As TextBox
    Friend WithEvents tbSeriaNum As TextBox
    Friend WithEvents tbTypeDoc As TextBox
    Friend WithEvents tbInn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbBornDate As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mtbDocIssued As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents Label5 As Label
End Class
