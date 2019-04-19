<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
      Me.NudInverval = New System.Windows.Forms.NumericUpDown()
      Me.LblIntervalSeconds = New System.Windows.Forms.Label()
      Me.LblInterval = New System.Windows.Forms.Label()
      Me.ChkTopMost = New System.Windows.Forms.CheckBox()
      Me.BtnOK = New System.Windows.Forms.Button()
      Me.LblIungoIP = New System.Windows.Forms.Label()
      Me.LblDataBaseIP = New System.Windows.Forms.Label()
      Me.IpbIungoIP = New GWIPBox.IPBox()
      Me.IpbDatabaseIP = New GWIPBox.IPBox()
      CType(Me.NudInverval, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'NudInverval
      '
      Me.NudInverval.Location = New System.Drawing.Point(69, 55)
      Me.NudInverval.Maximum = New Decimal(New Integer() {900, 0, 0, 0})
      Me.NudInverval.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
      Me.NudInverval.Name = "NudInverval"
      Me.NudInverval.Size = New System.Drawing.Size(45, 20)
      Me.NudInverval.TabIndex = 11
      Me.NudInverval.Value = New Decimal(New Integer() {300, 0, 0, 0})
      '
      'LblIntervalSeconds
      '
      Me.LblIntervalSeconds.AutoSize = True
      Me.LblIntervalSeconds.Location = New System.Drawing.Point(120, 57)
      Me.LblIntervalSeconds.Name = "LblIntervalSeconds"
      Me.LblIntervalSeconds.Size = New System.Drawing.Size(49, 13)
      Me.LblIntervalSeconds.TabIndex = 10
      Me.LblIntervalSeconds.Text = "Seconds"
      '
      'LblInterval
      '
      Me.LblInterval.AutoSize = True
      Me.LblInterval.Location = New System.Drawing.Point(2, 58)
      Me.LblInterval.Name = "LblInterval"
      Me.LblInterval.Size = New System.Drawing.Size(45, 13)
      Me.LblInterval.TabIndex = 9
      Me.LblInterval.Text = "Interval:"
      '
      'ChkTopMost
      '
      Me.ChkTopMost.AutoSize = True
      Me.ChkTopMost.Location = New System.Drawing.Point(5, 83)
      Me.ChkTopMost.Name = "ChkTopMost"
      Me.ChkTopMost.Size = New System.Drawing.Size(70, 17)
      Me.ChkTopMost.TabIndex = 8
      Me.ChkTopMost.Text = "Top most"
      Me.ChkTopMost.UseVisualStyleBackColor = True
      '
      'BtnOK
      '
      Me.BtnOK.Location = New System.Drawing.Point(123, 83)
      Me.BtnOK.Name = "BtnOK"
      Me.BtnOK.Size = New System.Drawing.Size(62, 23)
      Me.BtnOK.TabIndex = 7
      Me.BtnOK.Text = "OK"
      Me.BtnOK.UseVisualStyleBackColor = True
      '
      'LblIungoIP
      '
      Me.LblIungoIP.AutoSize = True
      Me.LblIungoIP.Location = New System.Drawing.Point(2, 3)
      Me.LblIungoIP.Name = "LblIungoIP"
      Me.LblIungoIP.Size = New System.Drawing.Size(47, 13)
      Me.LblIungoIP.TabIndex = 12
      Me.LblIungoIP.Text = "IungoIP:"
      '
      'LblDataBaseIP
      '
      Me.LblDataBaseIP.AutoSize = True
      Me.LblDataBaseIP.Location = New System.Drawing.Point(0, 27)
      Me.LblDataBaseIP.Name = "LblDataBaseIP"
      Me.LblDataBaseIP.Size = New System.Drawing.Size(67, 13)
      Me.LblDataBaseIP.TabIndex = 13
      Me.LblDataBaseIP.Text = "DataBaseIP:"
      '
      'IpbIungoIP
      '
      Me.IpbIungoIP.Borderstyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.IpbIungoIP.IPAdress = CType(resources.GetObject("IpbIungoIP.IPAdress"), System.Net.IPAddress)
      Me.IpbIungoIP.Location = New System.Drawing.Point(69, -2)
      Me.IpbIungoIP.Name = "IpbIungoIP"
      Me.IpbIungoIP.Size = New System.Drawing.Size(116, 27)
      Me.IpbIungoIP.TabIndex = 14
      '
      'IpbDatabaseIP
      '
      Me.IpbDatabaseIP.Borderstyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.IpbDatabaseIP.IPAdress = CType(resources.GetObject("IpbDatabaseIP.IPAdress"), System.Net.IPAddress)
      Me.IpbDatabaseIP.Location = New System.Drawing.Point(69, 22)
      Me.IpbDatabaseIP.Name = "IpbDatabaseIP"
      Me.IpbDatabaseIP.Size = New System.Drawing.Size(116, 27)
      Me.IpbDatabaseIP.TabIndex = 15
      '
      'FrmSettings
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(186, 107)
      Me.ControlBox = False
      Me.Controls.Add(Me.IpbDatabaseIP)
      Me.Controls.Add(Me.IpbIungoIP)
      Me.Controls.Add(Me.LblDataBaseIP)
      Me.Controls.Add(Me.LblIungoIP)
      Me.Controls.Add(Me.NudInverval)
      Me.Controls.Add(Me.LblIntervalSeconds)
      Me.Controls.Add(Me.LblInterval)
      Me.Controls.Add(Me.ChkTopMost)
      Me.Controls.Add(Me.BtnOK)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmSettings"
      Me.Text = "Instellingen"
      CType(Me.NudInverval, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents NudInverval As NumericUpDown
   Friend WithEvents LblIntervalSeconds As Label
   Friend WithEvents LblInterval As Label
   Friend WithEvents ChkTopMost As CheckBox
   Friend WithEvents BtnOK As Button
   Friend WithEvents LblIungoIP As Label
   Friend WithEvents LblDataBaseIP As Label
   Friend WithEvents IpbIungoIP As GWIPBox.IPBox
   Friend WithEvents IpbDatabaseIP As GWIPBox.IPBox
End Class
