<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim Clear_btn As System.Windows.Forms.Button
        Me.Cek_btn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Load_btn = New System.Windows.Forms.Button()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Clear_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Clear_btn
        '
        Clear_btn.AutoSize = True
        Clear_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Clear_btn.Location = New System.Drawing.Point(930, 16)
        Clear_btn.Name = "Clear_btn"
        Clear_btn.Size = New System.Drawing.Size(89, 35)
        Clear_btn.TabIndex = 3
        Clear_btn.Text = "♻️ Reset"
        Clear_btn.UseVisualStyleBackColor = False
        AddHandler Clear_btn.Click, AddressOf Me.Clear_btn_Click
        '
        'Cek_btn
        '
        Me.Cek_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cek_btn.ForeColor = System.Drawing.Color.DarkGreen
        Me.Cek_btn.Location = New System.Drawing.Point(410, 16)
        Me.Cek_btn.Name = "Cek_btn"
        Me.Cek_btn.Size = New System.Drawing.Size(145, 35)
        Me.Cek_btn.TabIndex = 0
        Me.Cek_btn.Text = "MULAI CHECK"
        Me.Cek_btn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(12, 62)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1007, 508)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 2
        '
        'Load_btn
        '
        Me.Load_btn.AutoSize = True
        Me.Load_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Load_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Load_btn.FlatAppearance.BorderSize = 30
        Me.Load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Load_btn.Location = New System.Drawing.Point(561, 16)
        Me.Load_btn.Name = "Load_btn"
        Me.Load_btn.Size = New System.Drawing.Size(72, 35)
        Me.Load_btn.TabIndex = 4
        Me.Load_btn.Text = "Load..."
        Me.Load_btn.UseVisualStyleBackColor = False
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbTotal.Location = New System.Drawing.Point(124, 22)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(19, 20)
        Me.lbTotal.TabIndex = 5
        Me.lbTotal.Text = "0"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Resi :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Save_btn
        '
        Me.Save_btn.BackColor = System.Drawing.Color.Wheat
        Me.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_btn.ForeColor = System.Drawing.Color.Black
        Me.Save_btn.Location = New System.Drawing.Point(835, 16)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(89, 35)
        Me.Save_btn.TabIndex = 8
        Me.Save_btn.Text = "🛠 Save Hasil"
        Me.Save_btn.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(887, 576)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(132, 10)
        Me.ProgressBar1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 576)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 10
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(652, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(117, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Lihat Semua Proses"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1031, 593)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Save_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Load_btn)
        Me.Controls.Add(Clear_btn)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Cek_btn)
        Me.Controls.Add(Me.CheckBox1)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cek Resi JNT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cek_btn As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Load_btn As Button
    Friend WithEvents lbTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Save_btn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
