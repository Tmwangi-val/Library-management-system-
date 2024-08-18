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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTitle = New TextBox()
        txtAuthor = New TextBox()
        txtYearPublished = New TextBox()
        txtGenre = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        dgvBooks = New DataGridView()
        Label5 = New Label()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 15)
        Label1.TabIndex = 0
        Label1.Text = "Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 1
        Label2.Text = "Author"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 2
        Label3.Text = "Year Publisher"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(14, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 15)
        Label4.TabIndex = 3
        Label4.Text = "Genre"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(111, 28)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(159, 23)
        txtTitle.TabIndex = 4
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(111, 78)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(159, 23)
        txtAuthor.TabIndex = 5
        ' 
        ' txtYearPublished
        ' 
        txtYearPublished.Location = New Point(111, 129)
        txtYearPublished.Name = "txtYearPublished"
        txtYearPublished.Size = New Size(159, 23)
        txtYearPublished.TabIndex = 6
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(111, 178)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(159, 23)
        txtGenre.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(403, 276)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(87, 35)
        btnAdd.TabIndex = 8
        btnAdd.Text = "btnAdd"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(541, 276)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(96, 35)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "btnUpdate"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(403, 322)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(87, 33)
        btnDelete.TabIndex = 10
        btnDelete.Text = "btnDelete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(541, 321)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(96, 34)
        btnClear.TabIndex = 11
        btnClear.Text = "btnClear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvBooks
        ' 
        dgvBooks.BackgroundColor = SystemColors.ControlLight
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Location = New Point(319, 33)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.Size = New Size(480, 241)
        dgvBooks.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(274, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(252, 24)
        Label5.TabIndex = 13
        Label5.Text = "LIBRARY DATA SYSTEM"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(dgvBooks)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtGenre)
        Controls.Add(txtYearPublished)
        Controls.Add(txtAuthor)
        Controls.Add(txtTitle)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents Label5 As Label

End Class
