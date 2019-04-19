'*************************************************************
'*  Class........: PowerJSON.vb                              *
'*  Auteur.......: Gijs Wassink                              *
'*  Datum........: 17-05-2018 Last revised: 24/08/2018       *
'*  Notice.......: Copyright 2014, All Rights Reserved       *
'*  Notes........: VB.NET Make JSON Power object             *
'*  Reserved.....: Type Work Application                     *
'*************************************************************

Public Class PowerJSON
   Public Power As New Data

   Public Class Data
      Public TimeUnit As String
      Public Unit As String
      Public MeasuredBy As String
      Public Values As New List(Of Value)
   End Class

   Public Class Value
      Public [Date] As Date
      Public Value As Single
   End Class
End Class

