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
        Label5 = New Label()
        tnim = New TextBox()
        tnama = New TextBox()
        rpria = New RadioButton()
        rwanita = New RadioButton()
        cprodi = New ComboBox()
        talamat = New TextBox()
        bkosongkan = New Button()
        bsimpan = New Button()
        bhapus = New Button()
        bkeluar = New Button()
        DGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ImageAlign = ContentAlignment.TopLeft
        Label1.Location = New Point(109, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nim :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ImageAlign = ContentAlignment.TopLeft
        Label2.Location = New Point(95, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nama :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ImageAlign = ContentAlignment.TopLeft
        Label3.Location = New Point(38, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 25)
        Label3.TabIndex = 2
        Label3.Text = "Jenis Kelamin :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ImageAlign = ContentAlignment.TopLeft
        Label4.Location = New Point(28, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 25)
        Label4.TabIndex = 3
        Label4.Text = "Program Studi :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ImageAlign = ContentAlignment.TopLeft
        Label5.Location = New Point(86, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 25)
        Label5.TabIndex = 4
        Label5.Text = "Alamat :"
        ' 
        ' tnim
        ' 
        tnim.Location = New Point(187, 31)
        tnim.Name = "tnim"
        tnim.Size = New Size(317, 31)
        tnim.TabIndex = 5
        ' 
        ' tnama
        ' 
        tnama.Location = New Point(187, 80)
        tnama.Name = "tnama"
        tnama.Size = New Size(317, 31)
        tnama.TabIndex = 6
        ' 
        ' rpria
        ' 
        rpria.AutoSize = True
        rpria.Location = New Point(189, 130)
        rpria.Name = "rpria"
        rpria.Size = New Size(66, 29)
        rpria.TabIndex = 7
        rpria.TabStop = True
        rpria.Text = "Pria"
        rpria.UseVisualStyleBackColor = True
        ' 
        ' rwanita
        ' 
        rwanita.AutoSize = True
        rwanita.Location = New Point(274, 130)
        rwanita.Name = "rwanita"
        rwanita.Size = New Size(91, 29)
        rwanita.TabIndex = 8
        rwanita.TabStop = True
        rwanita.Text = "Wanita"
        rwanita.UseVisualStyleBackColor = True
        ' 
        ' cprodi
        ' 
        cprodi.FormattingEnabled = True
        cprodi.Items.AddRange(New Object() {"S1-Pendidikan Teknik Informatika", "S1-Teknologi Informasi", "S1-Pendidikan Teknik Elektronika"})
        cprodi.Location = New Point(189, 182)
        cprodi.Name = "cprodi"
        cprodi.Size = New Size(315, 33)
        cprodi.TabIndex = 9
        ' 
        ' talamat
        ' 
        talamat.Location = New Point(189, 231)
        talamat.Multiline = True
        talamat.Name = "talamat"
        talamat.Size = New Size(315, 131)
        talamat.TabIndex = 10
        ' 
        ' bkosongkan
        ' 
        bkosongkan.Location = New Point(38, 390)
        bkosongkan.Name = "bkosongkan"
        bkosongkan.Size = New Size(112, 34)
        bkosongkan.TabIndex = 11
        bkosongkan.Text = "Kosongkan"
        bkosongkan.UseVisualStyleBackColor = True
        ' 
        ' bsimpan
        ' 
        bsimpan.Location = New Point(156, 390)
        bsimpan.Name = "bsimpan"
        bsimpan.Size = New Size(112, 34)
        bsimpan.TabIndex = 12
        bsimpan.Text = "Simpan"
        bsimpan.UseVisualStyleBackColor = True
        ' 
        ' bhapus
        ' 
        bhapus.Location = New Point(274, 390)
        bhapus.Name = "bhapus"
        bhapus.Size = New Size(112, 34)
        bhapus.TabIndex = 13
        bhapus.Text = "Hapus"
        bhapus.UseVisualStyleBackColor = True
        ' 
        ' bkeluar
        ' 
        bkeluar.Location = New Point(392, 390)
        bkeluar.Name = "bkeluar"
        bkeluar.Size = New Size(112, 34)
        bkeluar.TabIndex = 14
        bkeluar.Text = "Keluar"
        bkeluar.UseVisualStyleBackColor = True
        ' 
        ' DGV
        ' 
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DGV.Location = New Point(38, 442)
        DGV.Name = "DGV"
        DGV.RowHeadersWidth = 62
        DGV.Size = New Size(466, 203)
        DGV.TabIndex = 15
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "NIM"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Jekel"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Prodi"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Alamat"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(535, 657)
        Controls.Add(DGV)
        Controls.Add(bkeluar)
        Controls.Add(bhapus)
        Controls.Add(bsimpan)
        Controls.Add(bkosongkan)
        Controls.Add(talamat)
        Controls.Add(cprodi)
        Controls.Add(rwanita)
        Controls.Add(rpria)
        Controls.Add(tnama)
        Controls.Add(tnim)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form Data Mahasiswa"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tnim As TextBox
    Friend WithEvents tnama As TextBox
    Friend WithEvents rpria As RadioButton
    Friend WithEvents rwanita As RadioButton
    Friend WithEvents cprodi As ComboBox
    Friend WithEvents talamat As TextBox
    Friend WithEvents bkosongkan As Button
    Friend WithEvents bsimpan As Button
    Friend WithEvents bhapus As Button
    Friend WithEvents bkeluar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn

End Class
