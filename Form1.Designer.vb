<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Disks = New System.Windows.Forms.ComboBox()
        Me.Open = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.R4 = New System.Windows.Forms.RadioButton()
        Me.R3 = New System.Windows.Forms.RadioButton()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.vOS = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CFW = New System.Windows.Forms.Button()
        Me.OFW = New System.Windows.Forms.Button()
        Me.Log1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OFW_61 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Disks
        '
        Me.Disks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Disks.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Disks.FormattingEnabled = True
        Me.Disks.Location = New System.Drawing.Point(12, 12)
        Me.Disks.Name = "Disks"
        Me.Disks.Size = New System.Drawing.Size(230, 21)
        Me.Disks.TabIndex = 0
        '
        'Open
        '
        Me.Open.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Open.Location = New System.Drawing.Point(248, 12)
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(75, 23)
        Me.Open.TabIndex = 1
        Me.Open.Text = "Open"
        Me.Open.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.R4)
        Me.GroupBox1.Controls.Add(Me.R3)
        Me.GroupBox1.Controls.Add(Me.R2)
        Me.GroupBox1.Controls.Add(Me.R1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 42)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'R4
        '
        Me.R4.AutoSize = True
        Me.R4.Location = New System.Drawing.Point(260, 15)
        Me.R4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(39, 17)
        Me.R4.TabIndex = 3
        Me.R4.TabStop = True
        Me.R4.Text = "Go"
        Me.R4.UseVisualStyleBackColor = True
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.R3.Location = New System.Drawing.Point(146, 14)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(101, 17)
        Me.R3.TabIndex = 2
        Me.R3.Text = "3000 / Street"
        Me.R3.UseVisualStyleBackColor = True
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.R2.Location = New System.Drawing.Point(79, 14)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(53, 17)
        Me.R2.TabIndex = 1
        Me.R2.Text = "2000"
        Me.R2.UseVisualStyleBackColor = True
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Checked = True
        Me.R1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.Location = New System.Drawing.Point(12, 14)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(53, 17)
        Me.R1.TabIndex = 0
        Me.R1.TabStop = True
        Me.R1.Text = "1000"
        Me.R1.UseVisualStyleBackColor = True
        '
        'vOS
        '
        Me.vOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vOS.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.vOS.FormattingEnabled = True
        Me.vOS.Items.AddRange(New Object() {"6.60", "6.61"})
        Me.vOS.Location = New System.Drawing.Point(248, 87)
        Me.vOS.Name = "vOS"
        Me.vOS.Size = New System.Drawing.Size(75, 21)
        Me.vOS.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(141, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "System version:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CFW)
        Me.GroupBox2.Controls.Add(Me.OFW)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 331)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'CFW
        '
        Me.CFW.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.CFW.Location = New System.Drawing.Point(160, 19)
        Me.CFW.Name = "CFW"
        Me.CFW.Size = New System.Drawing.Size(147, 35)
        Me.CFW.TabIndex = 1
        Me.CFW.Text = "Copy CFW 6.60 to SD"
        Me.CFW.UseVisualStyleBackColor = True
        '
        'OFW
        '
        Me.OFW.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.OFW.Location = New System.Drawing.Point(6, 19)
        Me.OFW.Name = "OFW"
        Me.OFW.Size = New System.Drawing.Size(148, 35)
        Me.OFW.TabIndex = 0
        Me.OFW.Text = "Copy OFW 6.60 to SD"
        Me.OFW.UseVisualStyleBackColor = True
        '
        'Log1
        '
        Me.Log1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Log1.Location = New System.Drawing.Point(17, 186)
        Me.Log1.Name = "Log1"
        Me.Log1.ReadOnly = True
        Me.Log1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.Log1.Size = New System.Drawing.Size(299, 250)
        Me.Log1.TabIndex = 3
        Me.Log1.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OFW_61)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 114)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(313, 331)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'OFW_61
        '
        Me.OFW_61.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.OFW_61.Location = New System.Drawing.Point(6, 19)
        Me.OFW_61.Name = "OFW_61"
        Me.OFW_61.Size = New System.Drawing.Size(148, 35)
        Me.OFW_61.TabIndex = 0
        Me.OFW_61.Text = "Copy OFW 6.61 to SD"
        Me.OFW_61.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 450)
        Me.Controls.Add(Me.Log1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vOS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Open)
        Me.Controls.Add(Me.Disks)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PSP_Mod v2.2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Open As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Disks As ComboBox
    Friend WithEvents R3 As RadioButton
    Friend WithEvents R2 As RadioButton
    Friend WithEvents R1 As RadioButton
    Friend WithEvents vOS As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CFW As Button
    Friend WithEvents OFW As Button
    Friend WithEvents Log1 As RichTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents OFW_61 As Button
    Friend WithEvents R4 As RadioButton
End Class
