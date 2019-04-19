<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
      Me.GrpYield = New System.Windows.Forms.GroupBox()
      Me.LblTotalkWh = New System.Windows.Forms.Label()
      Me.LblYearkWh = New System.Windows.Forms.Label()
      Me.LblMonthkWh = New System.Windows.Forms.Label()
      Me.LblDaykWh = New System.Windows.Forms.Label()
      Me.LblTotalValue = New System.Windows.Forms.Label()
      Me.LblYearValue = New System.Windows.Forms.Label()
      Me.LblMonthValue = New System.Windows.Forms.Label()
      Me.LblDayValue = New System.Windows.Forms.Label()
      Me.LblTotalYield = New System.Windows.Forms.Label()
      Me.LblYearYield = New System.Windows.Forms.Label()
      Me.LblMonthYield = New System.Windows.Forms.Label()
      Me.LblDayYield = New System.Windows.Forms.Label()
      Me.LblSunPowerVal = New System.Windows.Forms.Label()
      Me.LblSunPowerW = New System.Windows.Forms.Label()
      Me.TmrMain = New System.Windows.Forms.Timer(Me.components)
      Me.LblStatus = New System.Windows.Forms.Label()
      Me.CmsMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.MnuSettings = New System.Windows.Forms.ToolStripMenuItem()
      Me.MnuExit = New System.Windows.Forms.ToolStripMenuItem()
      Me.LblUsedPowerW = New System.Windows.Forms.Label()
      Me.LblUsedPowerVal = New System.Windows.Forms.Label()
      Me.LblPowerW = New System.Windows.Forms.Label()
      Me.LblUsedPowerTotalVal = New System.Windows.Forms.Label()
      Me.GrpYield.SuspendLayout()
      Me.CmsMain.SuspendLayout()
      Me.SuspendLayout()
      '
      'GrpYield
      '
      Me.GrpYield.Controls.Add(Me.LblTotalkWh)
      Me.GrpYield.Controls.Add(Me.LblYearkWh)
      Me.GrpYield.Controls.Add(Me.LblMonthkWh)
      Me.GrpYield.Controls.Add(Me.LblDaykWh)
      Me.GrpYield.Controls.Add(Me.LblTotalValue)
      Me.GrpYield.Controls.Add(Me.LblYearValue)
      Me.GrpYield.Controls.Add(Me.LblMonthValue)
      Me.GrpYield.Controls.Add(Me.LblDayValue)
      Me.GrpYield.Controls.Add(Me.LblTotalYield)
      Me.GrpYield.Controls.Add(Me.LblYearYield)
      Me.GrpYield.Controls.Add(Me.LblMonthYield)
      Me.GrpYield.Controls.Add(Me.LblDayYield)
      Me.GrpYield.Location = New System.Drawing.Point(2, 71)
      Me.GrpYield.Name = "GrpYield"
      Me.GrpYield.Size = New System.Drawing.Size(117, 103)
      Me.GrpYield.TabIndex = 0
      Me.GrpYield.TabStop = False
      Me.GrpYield.Text = "Opbrengst:"
      '
      'LblTotalkWh
      '
      Me.LblTotalkWh.AutoSize = True
      Me.LblTotalkWh.Location = New System.Drawing.Point(82, 83)
      Me.LblTotalkWh.Name = "LblTotalkWh"
      Me.LblTotalkWh.Size = New System.Drawing.Size(33, 13)
      Me.LblTotalkWh.TabIndex = 11
      Me.LblTotalkWh.Text = "MWh"
      '
      'LblYearkWh
      '
      Me.LblYearkWh.AutoSize = True
      Me.LblYearkWh.Location = New System.Drawing.Point(84, 62)
      Me.LblYearkWh.Name = "LblYearkWh"
      Me.LblYearkWh.Size = New System.Drawing.Size(30, 13)
      Me.LblYearkWh.TabIndex = 10
      Me.LblYearkWh.Text = "kWh"
      '
      'LblMonthkWh
      '
      Me.LblMonthkWh.AutoSize = True
      Me.LblMonthkWh.Location = New System.Drawing.Point(84, 39)
      Me.LblMonthkWh.Name = "LblMonthkWh"
      Me.LblMonthkWh.Size = New System.Drawing.Size(30, 13)
      Me.LblMonthkWh.TabIndex = 9
      Me.LblMonthkWh.Text = "kWh"
      '
      'LblDaykWh
      '
      Me.LblDaykWh.AutoSize = True
      Me.LblDaykWh.Location = New System.Drawing.Point(84, 17)
      Me.LblDaykWh.Name = "LblDaykWh"
      Me.LblDaykWh.Size = New System.Drawing.Size(30, 13)
      Me.LblDaykWh.TabIndex = 8
      Me.LblDaykWh.Text = "kWh"
      '
      'LblTotalValue
      '
      Me.LblTotalValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LblTotalValue.Location = New System.Drawing.Point(35, 83)
      Me.LblTotalValue.Name = "LblTotalValue"
      Me.LblTotalValue.Size = New System.Drawing.Size(50, 13)
      Me.LblTotalValue.TabIndex = 7
      Me.LblTotalValue.Text = "0.0"
      Me.LblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LblYearValue
      '
      Me.LblYearValue.Location = New System.Drawing.Point(31, 62)
      Me.LblYearValue.Name = "LblYearValue"
      Me.LblYearValue.Size = New System.Drawing.Size(54, 13)
      Me.LblYearValue.TabIndex = 6
      Me.LblYearValue.Text = "0.0"
      Me.LblYearValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LblMonthValue
      '
      Me.LblMonthValue.Location = New System.Drawing.Point(38, 39)
      Me.LblMonthValue.Name = "LblMonthValue"
      Me.LblMonthValue.Size = New System.Drawing.Size(47, 13)
      Me.LblMonthValue.TabIndex = 5
      Me.LblMonthValue.Text = "0.0"
      Me.LblMonthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LblDayValue
      '
      Me.LblDayValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LblDayValue.Location = New System.Drawing.Point(41, 17)
      Me.LblDayValue.Name = "LblDayValue"
      Me.LblDayValue.Size = New System.Drawing.Size(44, 13)
      Me.LblDayValue.TabIndex = 4
      Me.LblDayValue.Text = "0.0"
      Me.LblDayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LblTotalYield
      '
      Me.LblTotalYield.AutoSize = True
      Me.LblTotalYield.Location = New System.Drawing.Point(1, 84)
      Me.LblTotalYield.Name = "LblTotalYield"
      Me.LblTotalYield.Size = New System.Drawing.Size(40, 13)
      Me.LblTotalYield.TabIndex = 3
      Me.LblTotalYield.Text = "Totaal:"
      '
      'LblYearYield
      '
      Me.LblYearYield.AutoSize = True
      Me.LblYearYield.Location = New System.Drawing.Point(1, 62)
      Me.LblYearYield.Name = "LblYearYield"
      Me.LblYearYield.Size = New System.Drawing.Size(30, 13)
      Me.LblYearYield.TabIndex = 2
      Me.LblYearYield.Text = "Jaar:"
      '
      'LblMonthYield
      '
      Me.LblMonthYield.AutoSize = True
      Me.LblMonthYield.Location = New System.Drawing.Point(1, 39)
      Me.LblMonthYield.Name = "LblMonthYield"
      Me.LblMonthYield.Size = New System.Drawing.Size(43, 13)
      Me.LblMonthYield.TabIndex = 1
      Me.LblMonthYield.Text = "Maand:"
      '
      'LblDayYield
      '
      Me.LblDayYield.AutoSize = True
      Me.LblDayYield.Location = New System.Drawing.Point(1, 17)
      Me.LblDayYield.Name = "LblDayYield"
      Me.LblDayYield.Size = New System.Drawing.Size(30, 13)
      Me.LblDayYield.TabIndex = 0
      Me.LblDayYield.Text = "Dag:"
      '
      'LblSunPowerVal
      '
      Me.LblSunPowerVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LblSunPowerVal.Location = New System.Drawing.Point(29, 4)
      Me.LblSunPowerVal.Name = "LblSunPowerVal"
      Me.LblSunPowerVal.Size = New System.Drawing.Size(57, 13)
      Me.LblSunPowerVal.TabIndex = 1
      Me.LblSunPowerVal.Text = "0"
      Me.LblSunPowerVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LblSunPowerW
      '
      Me.LblSunPowerW.AutoSize = True
      Me.LblSunPowerW.Location = New System.Drawing.Point(89, 6)
      Me.LblSunPowerW.Name = "LblSunPowerW"
      Me.LblSunPowerW.Size = New System.Drawing.Size(18, 13)
      Me.LblSunPowerW.TabIndex = 2
      Me.LblSunPowerW.Text = "W"
      '
      'TmrMain
      '
      Me.TmrMain.Enabled = True
      Me.TmrMain.Interval = 10000
      '
      'LblStatus
      '
      Me.LblStatus.BackColor = System.Drawing.Color.Red
      Me.LblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LblStatus.Location = New System.Drawing.Point(0, 0)
      Me.LblStatus.Name = "LblStatus"
      Me.LblStatus.Size = New System.Drawing.Size(8, 8)
      Me.LblStatus.TabIndex = 3
      '
      'CmsMain
      '
      Me.CmsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuSettings, Me.MnuExit})
      Me.CmsMain.Name = "CsmMain"
      Me.CmsMain.Size = New System.Drawing.Size(136, 48)
      '
      'MnuSettings
      '
      Me.MnuSettings.Image = CType(resources.GetObject("MnuSettings.Image"), System.Drawing.Image)
      Me.MnuSettings.Name = "MnuSettings"
      Me.MnuSettings.Size = New System.Drawing.Size(135, 22)
      Me.MnuSettings.Text = "Instellingen"
      '
      'MnuExit
      '
      Me.MnuExit.Image = CType(resources.GetObject("MnuExit.Image"), System.Drawing.Image)
      Me.MnuExit.Name = "MnuExit"
      Me.MnuExit.Size = New System.Drawing.Size(135, 22)
      Me.MnuExit.Text = "Exit"
      '
      'LblUsedPowerW
      '
      Me.LblUsedPowerW.AutoSize = True
      Me.LblUsedPowerW.Location = New System.Drawing.Point(89, 28)
      Me.LblUsedPowerW.Name = "LblUsedPowerW"
      Me.LblUsedPowerW.Size = New System.Drawing.Size(18, 13)
      Me.LblUsedPowerW.TabIndex = 5
      Me.LblUsedPowerW.Text = "W"
      '
      'LblUsedPowerVal
      '
      Me.LblUsedPowerVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LblUsedPowerVal.Location = New System.Drawing.Point(29, 26)
      Me.LblUsedPowerVal.Name = "LblUsedPowerVal"
      Me.LblUsedPowerVal.Size = New System.Drawing.Size(57, 13)
      Me.LblUsedPowerVal.TabIndex = 4
      Me.LblUsedPowerVal.Text = "0"
      Me.LblUsedPowerVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LblPowerW
      '
      Me.LblPowerW.AutoSize = True
      Me.LblPowerW.Location = New System.Drawing.Point(89, 50)
      Me.LblPowerW.Name = "LblPowerW"
      Me.LblPowerW.Size = New System.Drawing.Size(18, 13)
      Me.LblPowerW.TabIndex = 7
      Me.LblPowerW.Text = "W"
      '
      'LblUsedPowerTotalVal
      '
      Me.LblUsedPowerTotalVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LblUsedPowerTotalVal.Location = New System.Drawing.Point(29, 48)
      Me.LblUsedPowerTotalVal.Name = "LblUsedPowerTotalVal"
      Me.LblUsedPowerTotalVal.Size = New System.Drawing.Size(57, 13)
      Me.LblUsedPowerTotalVal.TabIndex = 6
      Me.LblUsedPowerTotalVal.Text = "0"
      Me.LblUsedPowerTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'FrmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(121, 176)
      Me.ControlBox = False
      Me.Controls.Add(Me.LblPowerW)
      Me.Controls.Add(Me.LblUsedPowerTotalVal)
      Me.Controls.Add(Me.LblUsedPowerW)
      Me.Controls.Add(Me.LblUsedPowerVal)
      Me.Controls.Add(Me.LblStatus)
      Me.Controls.Add(Me.LblSunPowerW)
      Me.Controls.Add(Me.LblSunPowerVal)
      Me.Controls.Add(Me.GrpYield)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmMain"
      Me.Text = "SolarEdge Live"
      Me.GrpYield.ResumeLayout(False)
      Me.GrpYield.PerformLayout()
      Me.CmsMain.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents GrpYield As GroupBox
   Friend WithEvents LblTotalkWh As Label
   Friend WithEvents LblYearkWh As Label
   Friend WithEvents LblMonthkWh As Label
   Friend WithEvents LblDaykWh As Label
   Friend WithEvents LblTotalValue As Label
   Friend WithEvents LblYearValue As Label
   Friend WithEvents LblMonthValue As Label
   Friend WithEvents LblDayValue As Label
   Friend WithEvents LblTotalYield As Label
   Friend WithEvents LblYearYield As Label
   Friend WithEvents LblMonthYield As Label
   Friend WithEvents LblDayYield As Label
   Friend WithEvents LblSunPowerVal As Label
   Friend WithEvents LblSunPowerW As Label
   Friend WithEvents TmrMain As Timer
   Friend WithEvents LblStatus As Label
   Friend WithEvents CmsMain As ContextMenuStrip
   Friend WithEvents MnuSettings As ToolStripMenuItem
   Friend WithEvents MnuExit As ToolStripMenuItem
   Friend WithEvents LblUsedPowerW As Label
   Friend WithEvents LblUsedPowerVal As Label
   Friend WithEvents LblPowerW As Label
   Friend WithEvents LblUsedPowerTotalVal As Label
End Class
