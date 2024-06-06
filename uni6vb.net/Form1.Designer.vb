<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ibtnCalculateAvarage = New FontAwesome.Sharp.IconButton()
        ibtnSave = New FontAwesome.Sharp.IconButton()
        ibtnSaveTxt = New FontAwesome.Sharp.IconButton()
        lsvContent = New ListView()
        Label1 = New Label()
        Label2 = New Label()
        txtName = New TextBox()
        txtAvarage = New TextBox()
        txtPhysics = New TextBox()
        txtScience = New TextBox()
        txtEnglish = New TextBox()
        txtMathematics = New TextBox()
        txtSpanish = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' ibtnCalculateAvarage
        ' 
        ibtnCalculateAvarage.IconChar = FontAwesome.Sharp.IconChar.Calculator
        ibtnCalculateAvarage.IconColor = Color.Black
        ibtnCalculateAvarage.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnCalculateAvarage.Location = New Point(269, 217)
        ibtnCalculateAvarage.Name = "ibtnCalculateAvarage"
        ibtnCalculateAvarage.Size = New Size(45, 63)
        ibtnCalculateAvarage.TabIndex = 0
        ibtnCalculateAvarage.UseVisualStyleBackColor = True
        ' 
        ' ibtnSave
        ' 
        ibtnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        ibtnSave.IconColor = Color.Black
        ibtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnSave.Location = New Point(320, 217)
        ibtnSave.Name = "ibtnSave"
        ibtnSave.Size = New Size(42, 63)
        ibtnSave.TabIndex = 1
        ibtnSave.UseVisualStyleBackColor = True
        ' 
        ' ibtnSaveTxt
        ' 
        ibtnSaveTxt.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ibtnSaveTxt.IconChar = FontAwesome.Sharp.IconChar.Save
        ibtnSaveTxt.IconColor = Color.Black
        ibtnSaveTxt.IconFont = FontAwesome.Sharp.IconFont.Auto
        ibtnSaveTxt.Location = New Point(368, 217)
        ibtnSaveTxt.Name = "ibtnSaveTxt"
        ibtnSaveTxt.Size = New Size(45, 63)
        ibtnSaveTxt.TabIndex = 2
        ibtnSaveTxt.Text = "txt"
        ibtnSaveTxt.TextAlign = ContentAlignment.BottomCenter
        ibtnSaveTxt.UseVisualStyleBackColor = True
        ' 
        ' lsvContent
        ' 
        lsvContent.Location = New Point(282, 38)
        lsvContent.Name = "lsvContent"
        lsvContent.Size = New Size(624, 152)
        lsvContent.TabIndex = 3
        lsvContent.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(148, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 4
        Label1.Text = "Qualification"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 5
        Label2.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(148, 39)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 6
        ' 
        ' txtAvarage
        ' 
        txtAvarage.Location = New Point(148, 233)
        txtAvarage.Name = "txtAvarage"
        txtAvarage.ReadOnly = True
        txtAvarage.Size = New Size(100, 23)
        txtAvarage.TabIndex = 7
        ' 
        ' txtPhysics
        ' 
        txtPhysics.Location = New Point(148, 204)
        txtPhysics.Name = "txtPhysics"
        txtPhysics.Size = New Size(100, 23)
        txtPhysics.TabIndex = 8
        ' 
        ' txtScience
        ' 
        txtScience.Location = New Point(148, 175)
        txtScience.Name = "txtScience"
        txtScience.Size = New Size(100, 23)
        txtScience.TabIndex = 9
        ' 
        ' txtEnglish
        ' 
        txtEnglish.Location = New Point(148, 146)
        txtEnglish.Name = "txtEnglish"
        txtEnglish.Size = New Size(100, 23)
        txtEnglish.TabIndex = 10
        ' 
        ' txtMathematics
        ' 
        txtMathematics.Location = New Point(148, 117)
        txtMathematics.Name = "txtMathematics"
        txtMathematics.Size = New Size(100, 23)
        txtMathematics.TabIndex = 11
        ' 
        ' txtSpanish
        ' 
        txtSpanish.Location = New Point(148, 88)
        txtSpanish.Name = "txtSpanish"
        txtSpanish.Size = New Size(100, 23)
        txtSpanish.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 13
        Label3.Text = "Subjects"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 14
        Label4.Text = "Science"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 146)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 15
        Label5.Text = "English"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 120)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 15)
        Label6.TabIndex = 16
        Label6.Text = "Mathematics"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 96)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 15)
        Label7.TabIndex = 17
        Label7.Text = "Spanish"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 204)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 15)
        Label8.TabIndex = 18
        Label8.Text = "Physics"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 233)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 15)
        Label9.TabIndex = 19
        Label9.Text = "Avarage"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 450)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtSpanish)
        Controls.Add(txtMathematics)
        Controls.Add(txtEnglish)
        Controls.Add(txtScience)
        Controls.Add(txtPhysics)
        Controls.Add(txtAvarage)
        Controls.Add(txtName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lsvContent)
        Controls.Add(ibtnSaveTxt)
        Controls.Add(ibtnSave)
        Controls.Add(ibtnCalculateAvarage)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ibtnCalculateAvarage As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtnSaveTxt As FontAwesome.Sharp.IconButton
    Friend WithEvents lsvContent As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAvarage As TextBox
    Friend WithEvents txtPhysics As TextBox
    Friend WithEvents txtScience As TextBox
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents txtMathematics As TextBox
    Friend WithEvents txtSpanish As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label

End Class
