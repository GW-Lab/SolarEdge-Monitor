Public Class FrmSettings
   Private frm As FrmMain

   Public Sub New(frm As Frmmain)
      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Me.frm = frm
   End Sub

   Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
      Location = Me.frm.Location

      IpbDatabaseIP.Text = My.Settings.DatabaseIP
      IpbIungoIP.Text = My.Settings.IungoIP

      NudInverval.Value = My.Settings.Interval
      ChkTopMost.Checked = My.Settings.TopMost
   End Sub

   Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
      My.Settings.Interval = CInt(NudInverval.Value)
      My.Settings.TopMost = ChkTopMost.Checked

      My.Settings.DatabaseIP = IpbDatabaseIP.Text
      My.Settings.IungoIP = IpbIungoIP.Text

      Me.frm.TmrMain.Interval = My.Settings.Interval * 1000
      Me.frm.TopMost = ChkTopMost.Checked
      Close()
   End Sub
End Class