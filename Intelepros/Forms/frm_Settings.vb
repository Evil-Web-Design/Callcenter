Imports UniBase
Public Class frm_Settings
  Private ControlsActive As Boolean = False
  Dim TempCon() As ConnString = Nothing
  Dim Settingsopen As Boolean = True

  Private Sub frm_Settings_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
    Settingsopen = False
  End Sub

  Private Sub frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    Dim regKey As New RegEdit(AppName)
    Erase TempCon
    Dim DBID As Integer = InputVar(regKey.GetAppValue("DBID", 0), 0)
    Dim DBMAXID As Integer = InputVar(regKey.GetAppValue("DBMAXID", 0), 0)
    If DBMAXID > default_Int Then
      Dim Index As Integer = 0
      For Conn = 0 To DBMAXID
        ReDim Preserve TempCon(Index)
        TempCon(Index) = regKey.GetDatabase(Conn, New ConnString With {.DataSource = "Localhost",
                                                                .Database = "Callcenter",
                                                                .UserName = "sa",
                                                                .UserPassword = "ou812"})
        Index += 1
      Next
      FillConns(cbo_Server, TempCon)
      ControlsActive = True
      Me.Show()
      regKey.GetSavedFormLocation(Me)
      regKey.Close()


      Do While Settingsopen

        Application.DoEvents()
      Loop
      Me.Dispose()
    End If
    ControlsActive = TempControlsActive
  End Sub
  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    If ControlsActive Then
      Dim regKey As New RegEdit(AppName)
      regKey.SetSavedFormLocation(Me)
      regKey.Close()
    End If
  End Sub
  '      regKey.SetAppValue("DBID", DBID)
  '      regKey.SetAppValue("DBMAXID", DBMAXID)

  Private Sub cbo_Server_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Server.SelectedIndexChanged
    If ControlsActive Then
      Dim Obj_Combo As ComboBox = CType(sender, ComboBox)
      Dim Obj_Value As Integer = CInt(CType(Obj_Combo.SelectedItem, ValueDescriptionPair).Value)

      UpdateForm(Obj_Value)
    End If

  End Sub
  Private Sub UpdateForm(Index As Integer)
    Dim OldControlsActive = ControlsActive : ControlsActive = False
    txt_Login.Text = TempCon(Index).UserName
    txt_Password.Text = TempCon(Index).UserPassword


    ControlsActive = OldControlsActive
  End Sub
  Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
    Settingsopen = False
    Me.Dispose()
  End Sub
  Private Sub cmd_Connect_Click(sender As Object, e As EventArgs) Handles cmd_Connect.Click
    Dim regKey As New RegEdit(AppName)
    Dim FoundID As Integer = default_Int
    If cbo_Server.Text.Length > 0 Then
      If Not IsNothing(TempCon) Then
        For loopvar As Integer = 0 To TempCon.Length - 1
          With TempCon(loopvar)
            If cbo_Server.Text = .DataSource Then FoundID = loopvar
          End With
        Next
      End If

      If FoundID = default_Int Then
        Dim Index As Integer = 0
        If Not IsNothing(TempCon) Then Index = TempCon.Length
        ReDim TempCon(Index)
        FoundID = Index
        regKey.SetAppValue("DBMAXID", FoundID)
      Else



        regKey.SetAppValue("DBMAXID", TempCon.Length - 1)
      End If
      TempCon(FoundID) = New ConnString With {.DataSource = cbo_Server.Text,
                                                              .Database = "Callcenter",
                                                              .UserName = txt_Login.Text,
                                                              .UserPassword = txt_Password.Text}

      With TempCon(FoundID)
        regKey.SetDatabase(FoundID, .DataSource, .Database, .UserName, .UserPassword)
      End With

      regKey.SetAppValue("DBID", FoundID)

      '      regKey.SetAppValue("DBMAXID", DBMAXID)
      TempCon(FoundID).UserName = txt_Login.Text
      TempCon(FoundID).UserPassword = txt_Password.Text
      SetConntoString(TempCon(FoundID))
      ReDim Connection(0) : Connection(0) = TempCon(FoundID)
      Me.Hide()
      DatabaceConnected = False
      Settingsopen = False
    Else
      MsgBox("Please correct Server Information!", MsgBoxStyle.Critical, "Bad Information")
    End If

  End Sub
End Class