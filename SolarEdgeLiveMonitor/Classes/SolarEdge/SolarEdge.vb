'*************************************************************
'*  Programma....: SolarEdge.vb                              *
'*  Auteur.......: Gijs Wassink                              *
'*  Datum........: 05-09-2014 Last revised: 24/08/2018       *
'*  Notice.......: Copyright 2014, All Rights Reserved       *
'*  Notes........: VB.NET Retrieve SolarEdge data            *
'*  Reserved.....: Type Work Application                     *
'*************************************************************
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class SolarEdge : Inherits SolarEdgeBase
   Public Sub New(startDate As Date, endDate As Date)
      MyBase.New(startDate, endDate)
   End Sub
End Class

Public Class SolarEdgeBase
   ReadOnly siteKey As String = "SolarEdgeKey" ' SolarEdge generated access Key
   ReadOnly siteId As Integer
   ReadOnly siteUrl As String = "https://monitoringapi.solaredge.com"
   ReadOnly endDate As Date
   ReadOnly startDate As Date

#Region "Constructor"
   Public Sub New(startDate As Date, endDate As Date)
      Me.startDate = startDate
      Me.endDate = endDate

      Try
         Me.siteId = SolarEdge.Sites.Site(0).Id
      Catch ex As Exception
         Throw New Exception($"Site:{ex.Message}")
      End Try
   End Sub
#End Region

   Function SolarEdge() As SitesJSON
      Dim webReq = WebRequest.Create($"{Me.siteUrl}/sites/list?api_key={Me.siteKey}")                 ' Create a request for the URL.
      Dim jsonSettings = New JsonSerializerSettings With {.NullValueHandling = NullValueHandling.Ignore}

      Try
         Using response = webReq.GetResponse                                                          ' Get the response (JSon data).  
            Using rd = New StreamReader(response.GetResponseStream)                                   ' Open the stream using a StreamReader for easy access. 
               Return JsonConvert.DeserializeObject(Of SitesJSON)(rd.ReadToEnd, jsonSettings)         ' Read the content and return Site-ID  
            End Using
         End Using
      Catch ex As Exception
         Return New SitesJSON
      End Try
   End Function

   Public Function Energy() As EnergyJSON
      Dim webReq = WebRequest.Create($"{Me.siteUrl}/site/{Me.siteId}/energy?api_key={Me.siteKey}&timeUnit=QUARTER_OF_AN_HOUR&endDate={Me.endDate.ToString("yyyy-MM-dd")}&startDate={Me.startDate.ToString("yyyy-MM-dd")}") ' Create a request for the URL.
      Dim jsonSettings = New JsonSerializerSettings With {.NullValueHandling = NullValueHandling.Ignore}

      Try
         Using response = webReq.GetResponse                                                          ' Get the response (JSon-data).  
            Using rd = New StreamReader(response.GetResponseStream)                                   ' Open the stream using a StreamReader. 
               Return JsonConvert.DeserializeObject(Of EnergyJSON)(rd.ReadToEnd, jsonSettings)        ' Read the content and return energy values 
            End Using
         End Using
      Catch ex As Exception
         Return New EnergyJSON
      End Try
   End Function

   Public Function Power() As PowerJSON
      Dim webReq = WebRequest.Create($"{Me.siteUrl}/site/{Me.siteId}/power?api_key={Me.siteKey}&timeUnit=QUARTER_OF_AN_HOUR&startTime={Me.startDate.ToString("yyyy-MM-dd HH:mm:ss")}&endTime={Me.endDate.ToString("yyyy-MM-dd HH:mm:ss")}") ' Create a request for the URL.
      Dim jsonSettings = New JsonSerializerSettings With {.NullValueHandling = NullValueHandling.Ignore}

      Try
         Using response = webReq.GetResponse                                                          ' Get the response (JSon-data).  
            Using rd = New StreamReader(response.GetResponseStream)                                   ' Open the stream using a StreamReader. 
               Return JsonConvert.DeserializeObject(Of PowerJSON)(rd.ReadToEnd, jsonSettings)         ' Read the content and return power values 
            End Using
         End Using
      Catch ex As Exception
         Return New PowerJSON
      End Try
   End Function

   Public Function Overview() As OverviewJSON
      Dim webReq = WebRequest.Create($"{Me.siteUrl}/site/{Me.siteId}/overview?api_key={Me.siteKey}")  ' Create a request for the URL.
      Dim jsonSettings = New JsonSerializerSettings With {.NullValueHandling = NullValueHandling.Ignore}

      Try
         Using response = webReq.GetResponse                                                          ' Get the response (JSon-data).  
            Using rd = New StreamReader(response.GetResponseStream)                                   ' Open the stream using a StreamReader. 
               Return JsonConvert.DeserializeObject(Of OverviewJSON)(rd.ReadToEnd, jsonSettings)      ' Read the content and return power values 
            End Using
         End Using
      Catch ex As Exception
         Return New OverviewJSON
      End Try
   End Function
End Class