'*************************************************************
'*  Class........: OverviewJSON.vb                           *
'*  Auteur.......: Gijs Wassink                              *
'*  Datum........: 09-09-2018 Last revised: 09/09/2018       *
'*  Notice.......: Copyright 2014, All Rights Reserved       *
'*  Notes........: VB.NET Make JSON overview object          *
'*  Reserved.....: Type Work Application                     *
'*************************************************************
Public Class OverviewJSON
   Public Lastupdatetime As Date
   Public Overview As New Data

   Public Class Data
      Public CurrentPower As New CurrentPower_Data
      Public LastDayData As New LastDay_Data
      Public LastYearData As New LastYear_Data
      Public LastMonthData As New LastMonth_Data
      Public LifeTimeData As New LifeTime_Data
   End Class

   Public Class CurrentPower_Data
      Public power As Single           ' Watt
   End Class

   Public Class LastDay_Data
      Public energy As Single          ' Wh
      Public revenue As Single         ' ?
   End Class

   Public Class LastMonth_Data
      Public energy As Single          ' Wh
      Public revenue As Single         ' ?
   End Class

   Public Class LastYear_Data
      Public energy As Single          ' Wh
      Public revenue As Single         ' ?
   End Class

   Public Class LifeTime_Data
      Public energy As Single          ' Wh
      Public revenue As Single         ' ?
   End Class
End Class
