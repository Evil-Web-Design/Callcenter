Imports System.Threading
Public Class Class_Background
  Private WithEvents BW As System.ComponentModel.BackgroundWorker
  Public Enum EnumStatus
    Init
    Working
    Done
  End Enum
  Public Structure SQLQuery
    Dim SQL As String
    Dim Datatable As DataTable
    Dim Status As EnumStatus
  End Structure


  Public Sub Init()
    If Not IsNothing(BW) Then
      BW.CancelAsync()
      BW = Nothing
    End If
    BW = New System.ComponentModel.BackgroundWorker
    AddHandler BW.DoWork, AddressOf DoWork
    AddHandler BW.ProgressChanged, AddressOf ProgressChanged
    AddHandler BW.RunWorkerCompleted, AddressOf WorkerCompleted
    BW.WorkerReportsProgress = True
    BW.WorkerSupportsCancellation = True
    BW.RunWorkerAsync()
  End Sub
  Private Sub DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    BW.ReportProgress(default_Int, "BW Start Thread")
    ' CC.SendMessage(CC..Contact.Email, CC.Record.Contact.PF_Name & " " & CC.Record.Contact.PF_Name)

    Dim ListText As String
    For Value As Integer = 0 To 1000
      If BW.CancellationPending Then
        Exit For
      End If
      ListText = String.Concat("Item #", Value)
      BW.ReportProgress(Value, ListText)
      Threading.Thread.Sleep(100)
    Next

    BW.ReportProgress(default_Int, "BW End Thread")
  End Sub
  Private Sub ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs)
    Dim UserState As String = Nothing, Message As String = Nothing
    UserState = CStr(e.UserState)
    Select Case e.ProgressPercentage
      Case Is > 0
        If UserState = "MAX" Then
          'prgThread.Minimum = 0
          'prgThread.Value = 0
          'prgThread.Maximum = e.ProgressPercentage
          log("MAX Percentage:" & e.ProgressPercentage)
        Else
          'prgThread.Value = e.ProgressPercentage
          log("VAL Percentage:" & e.ProgressPercentage)
        End If
      Case default_Int
        Message = UserState
      Case Else
    End Select
    If Not IsNothing(Message) Then log(Message)
  End Sub
  Private Sub WorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
    'cmd_SearchClaim.Enabled = True
    'btnCancel.Enabled = False
    'UpdateClaimCheck()
    'cmd_SearchClaim.Enabled = True
    log("WorkerCompleted")
  End Sub
  Public Sub log(Message As String)
    'If Not IsNothing(FormLog) Then FormLog.Logit(Message)
    Console.Write(Message & vbCrLf)
  End Sub
End Class
