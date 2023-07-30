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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtnum1 = New TextBox()
        txtnum2 = New TextBox()
        btnmin = New Button()
        btnmult = New Button()
        btndiv = New Button()
        btnmod = New Button()
        btnresult = New Button()
        btnadd = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(174, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(484, 33)
        Label1.TabIndex = 0
        Label1.Text = "SIMPLE  CALCULATOR ASSIGNMENT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(179, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 33)
        Label2.TabIndex = 1
        Label2.Text = "NUMBER 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(179, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 33)
        Label3.TabIndex = 2
        Label3.Text = "NUMBER 2"
        ' 
        ' txtnum1
        ' 
        txtnum1.Location = New Point(360, 123)
        txtnum1.Name = "txtnum1"
        txtnum1.Size = New Size(100, 23)
        txtnum1.TabIndex = 3
        ' 
        ' txtnum2
        ' 
        txtnum2.Location = New Point(360, 203)
        txtnum2.Name = "txtnum2"
        txtnum2.Size = New Size(100, 23)
        txtnum2.TabIndex = 4
        ' 
        ' btnmin
        ' 
        btnmin.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnmin.ForeColor = SystemColors.MenuHighlight
        btnmin.Location = New Point(235, 297)
        btnmin.Name = "btnmin"
        btnmin.Size = New Size(75, 46)
        btnmin.TabIndex = 6
        btnmin.Text = "-"
        btnmin.UseVisualStyleBackColor = True
        ' 
        ' btnmult
        ' 
        btnmult.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnmult.ForeColor = SystemColors.MenuHighlight
        btnmult.Location = New Point(385, 297)
        btnmult.Name = "btnmult"
        btnmult.Size = New Size(75, 46)
        btnmult.TabIndex = 7
        btnmult.Text = "*"
        btnmult.UseVisualStyleBackColor = True
        ' 
        ' btndiv
        ' 
        btndiv.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btndiv.ForeColor = SystemColors.MenuHighlight
        btndiv.Location = New Point(511, 297)
        btndiv.Name = "btndiv"
        btndiv.Size = New Size(75, 46)
        btndiv.TabIndex = 8
        btndiv.Text = "/"
        btndiv.UseVisualStyleBackColor = True
        ' 
        ' btnmod
        ' 
        btnmod.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnmod.ForeColor = SystemColors.MenuHighlight
        btnmod.Location = New Point(649, 297)
        btnmod.Name = "btnmod"
        btnmod.Size = New Size(75, 46)
        btnmod.TabIndex = 9
        btnmod.Text = "mod"
        btnmod.UseVisualStyleBackColor = True
        ' 
        ' btnresult
        ' 
        btnresult.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnresult.ForeColor = SystemColors.HotTrack
        btnresult.Location = New Point(585, 123)
        btnresult.Name = "btnresult"
        btnresult.Size = New Size(139, 103)
        btnresult.TabIndex = 10
        btnresult.UseVisualStyleBackColor = True
        ' 
        ' btnadd
        ' 
        btnadd.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnadd.ForeColor = SystemColors.MenuHighlight
        btnadd.Location = New Point(112, 297)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(75, 46)
        btnadd.TabIndex = 5
        btnadd.Text = "+"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(btnresult)
        Controls.Add(btnmod)
        Controls.Add(btndiv)
        Controls.Add(btnmult)
        Controls.Add(btnmin)
        Controls.Add(btnadd)
        Controls.Add(txtnum2)
        Controls.Add(txtnum1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = SystemColors.ControlText
        Name = "Form1"
        Text = "BASIC CALCULATOR"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents btnmin As Button
    Friend WithEvents btnmult As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnmod As Button
    Friend WithEvents btnresult As Button
    Friend WithEvents btnadd As Button
End Class
