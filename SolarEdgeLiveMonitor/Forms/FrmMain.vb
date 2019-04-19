Imports System.ComponentModel

Public Class FrmMain
   Private solarEdge As SolarEdge
   Private iungo As IungoClient

   Private Sub FrmSolarEdgeLiveMonitor_Load(sender As Object, e As EventArgs) Handles Me.Load
      Location = New Point(My.Settings.LocationX, My.Settings.LocationY)
      TopMost = My.Settings.TopMost

      ContextMenuStrip = CmsMain

      Try
         Me.solarEdge = New SolarEdge(Date.Now, Date.Now)
         Me.iungo = New IungoClient(New Net.IPAddress({192, 168, 2, 122}))
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

      TmrMain.Interval = My.Settings.Interval * 1000
      TmrMain_Tick(Nothing, Nothing)
   End Sub

   Private Sub FrmSolarEdgeLiveMonitor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
      My.Settings.LocationX = Location.X
      My.Settings.LocationY = Location.Y
   End Sub

   Private Sub TmrMain_Tick(sender As Object, e As EventArgs) Handles TmrMain.Tick
      Try
         With Me.solarEdge.Overview().Overview
            LblSunPowerVal.Text = .CurrentPower.power.ToString
            LblUsedPowerVal.Text = Me.iungo.Electricity("usage").Energy.Current.ToString("0.0")

            Dim totalUsedPower = CInt(LblSunPowerVal.Text) - CDbl(LblUsedPowerVal.Text)

            LblUsedPowerTotalVal.BackColor = If(totalUsedPower > 0, Color.LightGreen, Color.Red)
            LblUsedPowerTotalVal.ForeColor = If(totalUsedPower > 0, Color.Black, Color.White)
            LblUsedPowerTotalVal.Text = totalUsedPower.ToString

            LblDayValue.Text = (.LastDayData.energy / 1000).ToString("#0.0")
            LblMonthValue.Text = (.LastMonthData.energy / 1000).ToString("#0.0")
            LblYearValue.Text = (.LastYearData.energy / 1000).ToString("#0.0")
            LblTotalValue.Text = (.LifeTimeData.energy / 1000000).ToString("#0.0")
         End With

         LblStatus.BackColor = Color.Green
      Catch ex As Exception
         LblStatus.BackColor = Color.Red
      End Try
   End Sub

   Private Sub MnuSettings_Click(sender As Object, e As EventArgs) Handles MnuSettings.Click
      Dim frmSettings = New FrmSettings(Me)
      frmSettings.Show(Me)
   End Sub

   Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles MnuExit.Click
      Close()
   End Sub
End Class
