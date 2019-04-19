'*************************************************************
'*  Class........: SitesJSON.vb                              *
'*  Auteur.......: Gijs Wassink                              *
'*  Datum........: 18-05-2018 Last revised: 24/08/2018       *
'*  Notice.......: Copyright 2014, All Rights Reserved       *
'*  Notes........: VB.NET Make SolarEdge Sites object        *
'*  Reserved.....: Type Work Application                     *
'*************************************************************
Public Class SitesJSON
   Public Sites As SolarEdgeSites

   Public Class SolarEdgeSites
      Public Count As Integer
      Public Site() As SolarEdgeSite
   End Class

   Public Class SolarEdgeSite
      Public Id As Integer
      Public Name As String
      Public AccountId As Integer
      Public Stutus As String
      Public PeakPower As Single
      Public LastUpdateTime As New DateTime
      Public Currency As String
      Public InstallationDate As New DateTime
      Public Ptodate As New DateTime
      Public Notes As String
      Public Type As String

      Public Location As New Location
      Public Uris As Uris
      Public PublicSettings As PublicSettings = New PublicSettings
      Public PrimaryModule As PrimaryModule = New PrimaryModule
   End Class

   Public Class Location
      Public Country As String
      Public CountryCode As String
      Public City As String
      Public Address As String
      Public Address2 As String
      Public TimeZone As String
      Public Zip As String
   End Class

   Public Class PrimaryModule
      Public ManufacturerName As String
      Public ModelName As String
      Public MaximumPower As Single
   End Class

   Public Class Uris
      Public DETAILS As String
      Public DATA_PERIOD As String
      Public OVERVIEW As String
   End Class

   Public Class PublicSettings
      Public isPublic As Boolean
   End Class
End Class

'{"sites"{"count":1,
'"site":[{"id":63969,"name":"F. Cieremans","accountId":17333,"status":"Active","peakPower":2.25,"lastUpdateTime":"2018-05-18","currency":"EUR","installationDate":"2014-07-16","ptoDate":null, "notes": "","type":"Optimizers & Inverters","location":{"country":"Netherlands","city":"Ede","address":"Linnaeushof 15","address2":"","zip":"6715 LE","timeZone":"Europe/Amsterdam","countryCode":"NL"},"primaryModule":{"manufacturerName":"ZNSHINE PV-Tech","modelName":"ZXM-250M Black","maximumPower":250.0},"uris":{"DETAILS":"/site/63969/details","DATA_PERIOD":"/site/63969/dataPeriod","OVERVIEW":"/site/63969/overview"},"publicSettings":{"isPublic":false}}]}}


