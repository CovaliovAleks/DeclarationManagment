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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsAppExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsCreateDeclaration = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsCreatePerson = New System.Windows.Forms.ToolStripMenuItem()
        Me.WToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsmDeclarations = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsPersons = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pnlDesktop = New System.Windows.Forms.Panel()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripButton2, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripLabel3, Me.ToolStripButton4, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 36)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1222, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "tlsTopMenu"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(94, 24)
        Me.ToolStripLabel1.Text = "Декларации"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(77, 24)
        Me.ToolStripLabel2.Text = "Физ. лица"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(166, 24)
        Me.ToolStripLabel3.Text = "Добавить декларацию"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(144, 24)
        Me.ToolStripLabel4.Text = "Добавить физ.лицо"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.WToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ОПрограммеToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1222, 36)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "mnsApp"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsAppExit})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(75, 32)
        Me.FileToolStripMenuItem.Text = "Файл"
        '
        'tlsAppExit
        '
        Me.tlsAppExit.Name = "tlsAppExit"
        Me.tlsAppExit.Size = New System.Drawing.Size(224, 32)
        Me.tlsAppExit.Text = "Выход"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsCreateDeclaration, Me.tlsCreatePerson})
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(118, 32)
        Me.SettingsToolStripMenuItem.Text = "Добавить"
        '
        'tlsCreateDeclaration
        '
        Me.tlsCreateDeclaration.Name = "tlsCreateDeclaration"
        Me.tlsCreateDeclaration.Size = New System.Drawing.Size(462, 32)
        Me.tlsCreateDeclaration.Text = "Создать новую налоговая декларация"
        '
        'tlsCreatePerson
        '
        Me.tlsCreatePerson.Name = "tlsCreatePerson"
        Me.tlsCreatePerson.Size = New System.Drawing.Size(462, 32)
        Me.tlsCreatePerson.Text = "Добавить физическое лицо"
        '
        'WToolStripMenuItem
        '
        Me.WToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsmDeclarations, Me.tlsPersons})
        Me.WToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WToolStripMenuItem.Name = "WToolStripMenuItem"
        Me.WToolStripMenuItem.Size = New System.Drawing.Size(113, 32)
        Me.WToolStripMenuItem.Text = "Показать"
        '
        'tlsmDeclarations
        '
        Me.tlsmDeclarations.Name = "tlsmDeclarations"
        Me.tlsmDeclarations.Size = New System.Drawing.Size(322, 32)
        Me.tlsmDeclarations.Text = "Налоговые декларации"
        '
        'tlsPersons
        '
        Me.tlsPersons.Name = "tlsPersons"
        Me.tlsPersons.Size = New System.Drawing.Size(322, 32)
        Me.tlsPersons.Text = "Физические лица"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(98, 32)
        Me.AboutToolStripMenuItem.Text = "Настройки"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(118, 32)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 651)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1222, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pnlDesktop
        '
        Me.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDesktop.Location = New System.Drawing.Point(0, 67)
        Me.pnlDesktop.Name = "pnlDesktop"
        Me.pnlDesktop.Size = New System.Drawing.Size(1222, 584)
        Me.pnlDesktop.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 673)
        Me.Controls.Add(Me.pnlDesktop)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents pnlDesktop As Panel
    Friend WithEvents tlsAppExit As ToolStripMenuItem
    Friend WithEvents tlsCreateDeclaration As ToolStripMenuItem
    Friend WithEvents tlsCreatePerson As ToolStripMenuItem
    Friend WithEvents tlsmDeclarations As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents tlsPersons As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
End Class
