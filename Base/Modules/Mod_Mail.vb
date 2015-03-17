Imports System.IO
Imports System.Net.Mail
'Get Main
Imports System.Net.Sockets
'Imports System.Net.Security
Imports System.Text
Imports System.Collections.Specialized
Imports System.Net.Mime
Imports System.Runtime.InteropServices
Module Mod_Init
  Public CDO As New Class_CDO
End Module
Public Class Class_CDO

  Event MsgEvent(p1 As String)

  Public Property ServerAddr As String = ""
  Public Property ServerUser As String = ""
  Public Property ServerPass As String = ""
  Public Property POPPort As Integer = 110


  Public Property myNetworkStream As NetworkStream

#Region "Enum And Structure"
  Public Enum EmailReturnTypes
    Names = 0
    Emails = 1
    EmailField = 2
  End Enum
  Public Enum MessageFormat
    HTML_Format = 0
    TEXT_Format = 1
    MultiPart_Format = 2
  End Enum
  Public Structure MessageAddrs
    Dim UserName As String
    Dim EmailAddr As String
    Dim EmailReplyTo As String
    Dim NotificationTo As String
  End Structure

  Public FromAddr As MessageAddrs ': Erase ToAddrs
  Public ToAddrs() As MessageAddrs ': Erase ToAddrs
  Public ccAddrs() As MessageAddrs ': Erase ccAddrs
  Public bccAddrs() As MessageAddrs ' : Erase bccAddrs

  Public Structure Type_CampaignLocations
    Public Index As Integer
    Public ID As Long
    Public pk_LocationGrouping As Long
    Public Display As String
    Public Code As String
  End Structure
  Public Structure Type_Attachment
    Public Index As Integer
    Public ID As Long
    Public FriendlyName As String
    Public FileName As String
    Public FilePath As String
    Public MediaType As String
    'Public Doc As WebSupergoo.ABCpdf7.Doc
    Public FileStream As IO.MemoryStream
    Public OutStream As IO.MemoryStream
  End Structure
#End Region
#Region "Add Address"
  Public Sub ClearAddr(ByRef Addrs() As MessageAddrs)
    Erase Addrs
  End Sub
  Public Sub AddMessageAddr(ByRef Addrs() As MessageAddrs, ByVal Address As String, Optional ByVal Name As String = "", Optional ByVal EmailReplyTo As String = "")
    If IsNothing(Addrs) Then
      ReDim Addrs(0)
    Else
      ReDim Preserve Addrs(Addrs.Length)
    End If
    If Len(Name) = 0 Then Name = Address
    If Len(EmailReplyTo) = 0 Then EmailReplyTo = Address
    Addrs(Addrs.Length - 1).UserName = Name
    Addrs(Addrs.Length - 1).EmailAddr = Address
    Addrs(Addrs.Length - 1).EmailReplyTo = EmailReplyTo
  End Sub
  Public Sub AddMessageAddr(ByRef Addrs() As MessageAddrs, ByVal Addr As MessageAddrs)
    If IsNothing(Addrs) Then
      ReDim Addrs(0)
    Else
      ReDim Preserve Addrs(Addrs.Length)
    End If
    Addrs(Addrs.Length - 1) = Addr
  End Sub
#End Region
#Region "Send mail (SMTP)"

  Public Function SendMail(ByVal ToAddrs() As MessageAddrs, _
          ByVal FromAddr As MessageAddrs, _
          ByVal ccAddr() As MessageAddrs, _
          ByVal bccAddr() As MessageAddrs, _
          ByVal Subject As String, _
          ByVal htmlbody As String, _
          ByVal plainbody As String, _
          ByVal AttachmentStream As Type_Attachment(), _
          Optional ByVal IsBodyHtml As Boolean = False, Optional RequestNotification As Boolean = True) As Boolean
    '----------------------------------------------------------------------
    On Error Resume Next
    '-- Setup Email Address To & From. --
    Dim Msg As New MailMessage
    Dim To_Addr As MailAddressCollection = Msg.To
    Dim cc_Addr As MailAddressCollection = Msg.CC
    Dim bcc_Addr As MailAddressCollection = Msg.Bcc
    Dim Item As MessageAddrs
    Dim ToDebug As String = ""
    If Not IsNothing(ToAddrs) Then
      For Each Item In ToAddrs
        If Not IsDBNull(Item.EmailAddr) Then
          To_Addr.Add(New MailAddress(Item.EmailAddr, Item.UserName))
          ToDebug &= Item.EmailAddr & " "
        End If
      Next
    End If
    If Not IsNothing(ccAddr) Then
      For Each Item In ccAddr
        If Not IsDBNull(Item.EmailAddr) Then
          cc_Addr.Add(New MailAddress(Item.EmailAddr, Item.UserName))
          ToDebug &= Item.EmailAddr & " "
        End If
      Next
    End If
    If Not IsNothing(bccAddr) Then
      For Each Item In bccAddr
        If Not IsDBNull(Item.EmailAddr) Then
          bcc_Addr.Add(New MailAddress(Item.EmailAddr, Item.UserName))
          ToDebug &= Item.EmailAddr & " "
        End If
      Next
    End If



    'To_Addr.Add(New System.Net.Mail.MailAddress("to@company.com", "Some Person"))
    Msg.From = New MailAddress(FromAddr.EmailAddr, FromAddr.UserName)
    'Msg.From = New System.Net.Mail.MailAddress("support@cipcourses.com", "Support")
    'Msg.From = New System.Net.Mail.MailAddress(SupportEmail, SupportEmailName)

    Dim ReplyTo_Addr As New MailAddressCollection '  = Msg.ReplyToList
    ReplyTo_Addr.Add(New MailAddress(FromAddr.EmailReplyTo, FromAddr.UserName))

    '----------------------------------------------------------------------
    '-- Setup Email Subject & Body. --
    Msg.Subject = Subject
    Msg.IsBodyHtml = IsBodyHtml
    'Msg.Body = htmlbody

    If Len(htmlbody) > 0 Then
      Msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(htmlbody, New ContentType("text/html; charset=us-ascii")))
      'Msg.AlternateViews[0].TransferEncoding = TransferEncoding.QuotedPrintable
    End If
    '//also add the plain-text alternative (to help us pass spam checks)
    If Len(plainbody) > 0 Then
      Msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(plainbody, New ContentType("text/plain; charset=us-ascii")))
      'Msg.AlternateViews[1].TransferEncoding = TransferEncoding.QuotedPrintable
    End If


    If RequestNotification Then
      Msg.Headers.Add("Disposition-Notification-To", FromAddr.NotificationTo)
      Msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess And DeliveryNotificationOptions.OnFailure And DeliveryNotificationOptions.Delay
    End If


    '----------------------------------------------------------------------
    '-- Setup Email Attachment. --
    If Not IsNothing(AttachmentStream) Then
      For Each FileAttach As Type_Attachment In AttachmentStream
        If Len(FileAttach.FileName) > 0 Then
          FileAttach.OutStream.Seek(0, SeekOrigin.Begin)
          Msg.Attachments.Add(New Attachment(FileAttach.OutStream, FileAttach.FileName, FileAttach.MediaType))
        End If
      Next
    End If

    '----------------------------------------------------------------------
    '-- Send Email. --
    Dim mailObj As New System.Net.Mail.SmtpClient
    mailObj.Port = 25
    mailObj.Host = ServerAddr
    mailObj.Credentials = New Net.NetworkCredential(ServerUser, ServerPass)
    mailObj.Send(Msg)

    '----------------------------------------------------------------------
    '-- Return Success/Failure. --
    If Err.Number = 0 Then
      Return True
    Else
      'WriteToLog("SendMail Failed on:" & ToDebug)
      'WriteToLog(Err.Description, False)
      'If Not IsNothing(OutputListbox) Then log("SendMail ERROR: " & Err.Description)
      Return False
    End If
  End Function
#End Region

#Region "Get Mail (POP3)"
  Dim myTcpClient As New TcpClient()
  Public Function ConnectToMailServer(ByRef strReturnMessage As String) As Boolean
    Dim didit As Boolean = False
    Try

      If myTcpClient.Connected = True Then
        CloseServer()
        myTcpClient = New TcpClient()
      End If

      myTcpClient.Connect(ServerAddr, POPPort)
      myNetworkStream = myTcpClient.GetStream()
      Dim myStreamReader As New StreamReader(myNetworkStream)

      strReturnMessage = myStreamReader.ReadLine() + vbCrLf
      strReturnMessage += SendCommand(myNetworkStream, "USER " + ServerUser) + vbCrLf
      strReturnMessage += SendCommand(myNetworkStream, "PASS " + ServerPass) + vbCrLf
      didit = True
      'MessageBox.Show(strReturnMessage)
    Catch ex As Exception
      didit = False
      'MessageBox.Show(ex.Message)
      strReturnMessage = ex.Message
    End Try
    Return didit
  End Function
  Sub CloseServer()
    SendCommand(myNetworkStream, "QUIT ")
    myTcpClient.Close()
  End Sub
  Public Function SendCommand(ByRef pNetStream As NetworkStream, ByVal pstrCommand As String) As String
    Try
      Dim strCommand = pstrCommand + vbCrLf
      Dim bteCommand() As Byte = Encoding.ASCII.GetBytes(strCommand)
      Dim myStreamReader As StreamReader
      Dim strLine As String
      pNetStream.Write(bteCommand, 0, bteCommand.Length)
      myStreamReader = New StreamReader(pNetStream)
      strLine = myStreamReader.ReadLine()
      Return strLine
    Catch ex As Exception
      Return ex.Message
    End Try
  End Function
  Public Sub GetMailWaiting()
    'Dim strMessage(2) As String
    'Dim strMessageLine As String
    'MessageListBox.Items.Clear()
    'strMessageLine = CDO.SendCommand(CDO.myNetworkStream, "STAT")
    'strMessage = strMessageLine.Split(CChar(" "))
    'Dim lngNumber As Integer = CInt(strMessage(1))
    ''ListBox1.Items.Add(strMessage(1))
    ''ListBox1.Items.Add(Long.Parse(strMessage(2)) / 1000)
    'If lngNumber > 0 Then
    '  Dim strReturnMessage As String
    '  Dim lngIndex As Integer
    '  Try
    '    For lngLoop As Integer = 0 To lngNumber - 1
    '      lngIndex = lngLoop + 1
    '      strReturnMessage = "[" + lngIndex.ToString + "]" + CDO.SendCommand(myNetworkStream, "LIST " + lngIndex.ToString)
    '      If Not IsNothing(MessageListBox) Then MessageListBox.Items.Add(strReturnMessage)
    '    Next
    '  Catch ex As Exception
    '    log(ex.Message)
    '  End Try
    'End If
  End Sub

  Public MessageBodytext As String
  Public Sub GetMessage(index As Integer)
    Dim strMessageContent As String = ""


    Dim strCommand = "RETR " + (index).ToString + vbCrLf
    Dim bteCommand() As Byte = Encoding.ASCII.GetBytes(strCommand)
    Dim myStreamReader As StreamReader


    MessageBodytext = ""
    Try
      CDO.myNetworkStream.Write(bteCommand, 0, bteCommand.Length)
      myStreamReader = New StreamReader(CDO.myNetworkStream)
      AnalyMessage(myStreamReader)
    Catch ex As Exception
      RaiseEvent MsgEvent(ex.Message)
    End Try


  End Sub

  Private _headers As NameValueCollection
  ''' <summary>
  ''' Gets the headers.
  ''' </summary>
  ''' <value>The headers.</value>
  Public ReadOnly Property Headers() As NameValueCollection
    Get
      Return _headers
    End Get
  End Property


  Private Sub AnalyMessage(ByVal pStreamReader As StreamReader)
    Dim strReadLine As String = ""
    Dim sstrReadLine As String = ""

    Do While (sstrReadLine = Nothing Or sstrReadLine.Length = 0)
      sstrReadLine = pStreamReader.ReadLine
    Loop

    MessageBodytext += vbCrLf + "------------------------------ Header ------------------------------" + vbCrLf
    '------------------------------------------------
    Dim lastHeader As String = String.Empty


    Do While sstrReadLine.Trim.Length <> 0
      sstrReadLine = pStreamReader.ReadLine



      MessageBodytext += vbCrLf + sstrReadLine
    Loop

    MessageBodytext += vbCrLf + "------------------------------ Body ------------------------------" + vbCrLf

    Do
      sstrReadLine = pStreamReader.ReadLine
      If sstrReadLine.Trim() = "." Then Exit Do
      If sstrReadLine <> Nothing Then MessageBodytext += vbCrLf + sstrReadLine
    Loop

  End Sub

#End Region
End Class
Public Class MimeEntity
  Private _encodedMessage As StringBuilder
  ''' <summary>
  ''' Gets the encoded message.
  ''' </summary>
  ''' <value>The encoded message.</value>
  Public ReadOnly Property EncodedMessage() As StringBuilder
    Get
      Return _encodedMessage
    End Get
  End Property
  Private _children As List(Of MimeEntity)
  ''' <summary>
  ''' Gets the children.
  ''' </summary>
  ''' <value>The children.</value>
  Public ReadOnly Property Children() As List(Of MimeEntity)
    Get
      Return _children
    End Get
  End Property
  Private _contentType As ContentType
  ''' <summary>
  ''' Gets the type of the content.
  ''' </summary>
  ''' <value>The type of the content.</value>
  Public ReadOnly Property ContentType() As ContentType
    Get
      Return _contentType
    End Get
  End Property
  Private _mediaSubType As String
  ''' <summary>
  ''' Gets the type of the media sub.
  ''' </summary>
  ''' <value>The type of the media sub.</value>
  Public ReadOnly Property MediaSubType() As String
    Get
      Return _mediaSubType
    End Get
  End Property
  Private _mediaMainType As String
  ''' <summary>
  ''' Gets the type of the media main.
  ''' </summary>
  ''' <value>The type of the media main.</value>
  Public ReadOnly Property MediaMainType() As String
    Get
      Return _mediaMainType
    End Get
  End Property
  Private _headers As NameValueCollection
  ''' <summary>
  ''' Gets the headers.
  ''' </summary>
  ''' <value>The headers.</value>
  Public ReadOnly Property Headers() As NameValueCollection
    Get
      Return _headers
    End Get
  End Property
  Private _mimeVersion As String
  ''' <summary>
  ''' Gets or sets the MIME version.
  ''' </summary>
  ''' <value>The MIME version.</value>
  Public Property MimeVersion() As String
    Get
      Return _mimeVersion
    End Get
    Set(value As String)
      _mimeVersion = value
    End Set
  End Property
  Private _contentId As String
  ''' <summary>
  ''' Gets or sets the content id.
  ''' </summary>
  ''' <value>The content id.</value>
  Public Property ContentId() As String
    Get
      Return _contentId
    End Get
    Set(value As String)
      _contentId = value
    End Set
  End Property
  Private _contentDescription As String
  ''' <summary>
  ''' Gets or sets the content description.
  ''' </summary>
  ''' <value>The content description.</value>
  Public Property ContentDescription() As String
    Get
      Return _contentDescription
    End Get
    Set(value As String)
      _contentDescription = value
    End Set
  End Property
  Private _contentDisposition As ContentDisposition
  ''' <summary>
  ''' Gets or sets the content disposition.
  ''' </summary>
  ''' <value>The content disposition.</value>
  Public Property ContentDisposition() As ContentDisposition
    Get
      Return _contentDisposition
    End Get
    Set(value As ContentDisposition)
      _contentDisposition = value
    End Set
  End Property
  Private _transferEncoding As String
  ''' <summary>
  ''' Gets or sets the transfer encoding.
  ''' </summary>
  ''' <value>The transfer encoding.</value>
  Public Property TransferEncoding() As String
    Get
      Return _transferEncoding
    End Get
    Set(value As String)
      _transferEncoding = value
    End Set
  End Property
  Private _contentTransferEncoding As TransferEncoding
  ''' <summary>
  ''' Gets or sets the content transfer encoding.
  ''' </summary>
  ''' <value>The content transfer encoding.</value>
  Public Property ContentTransferEncoding() As TransferEncoding
    Get
      Return _contentTransferEncoding
    End Get
    Set(value As TransferEncoding)
      _contentTransferEncoding = value
    End Set
  End Property
  ''' <summary>
  ''' Gets a value indicating whether this instance has boundary.
  ''' </summary>
  ''' <value>
  ''' 	<c>true</c> if this instance has boundary; otherwise, <c>false</c>.
  ''' </value>
  Friend ReadOnly Property HasBoundary() As Boolean
    Get
      Return (Not String.IsNullOrEmpty(_contentType.Boundary)) OrElse (Not String.IsNullOrEmpty(_startBoundary))
    End Get
  End Property
  Private _startBoundary As String
  ''' <summary>
  ''' Gets the start boundary.
  ''' </summary>
  ''' <value>The start boundary.</value>
  Public ReadOnly Property StartBoundary() As String
    Get
      If String.IsNullOrEmpty(_startBoundary) OrElse Not String.IsNullOrEmpty(_contentType.Boundary) Then
        Return String.Concat("--", _contentType.Boundary)
      End If

      Return _startBoundary
    End Get
  End Property
  ''' <summary>
  ''' Gets the end boundary.
  ''' </summary>
  ''' <value>The end boundary.</value>
  Public ReadOnly Property EndBoundary() As String
    Get
      Return String.Concat(StartBoundary, "--")
    End Get
  End Property
  Private _parent As MimeEntity
  ''' <summary>
  ''' Gets or sets the parent.
  ''' </summary>
  ''' <value>The parent.</value>
  Public Property Parent() As MimeEntity
    Get
      Return _parent
    End Get
    Set(value As MimeEntity)
      _parent = value
    End Set
  End Property
  Private _content As MemoryStream
  ''' <summary>
  ''' Gets or sets the content.
  ''' </summary>
  ''' <value>The content.</value>
  Public Property Content() As MemoryStream
    Get
      Return _content
    End Get
    Friend Set(value As MemoryStream)
      _content = value
    End Set
  End Property
  ''' <summary>
  ''' Initializes a new instance of the <see cref="MimeEntity"/> class.
  ''' </summary>
  Public Sub New()
    _children = New List(Of MimeEntity)()
    _headers = New NameValueCollection()
    _contentType = MimeReader.GetContentType(String.Empty)
    _parent = Nothing
    _encodedMessage = New StringBuilder()
  End Sub
  ''' <summary>
  ''' Initializes a new instance of the <see cref="MimeEntity"/> class.
  ''' </summary>
  ''' <param name="parent">The parent.</param>
  Public Sub New(parent As MimeEntity)
    Me.New()
    If parent Is Nothing Then
      Throw New ArgumentNullException("parent")
    End If

    _parent = parent
    _startBoundary = parent.StartBoundary
  End Sub
  ''' <summary>
  ''' Sets the type of the content.
  ''' </summary>
  ''' <param name="contentType">Type of the content.</param>
  Friend Sub SetContentType(contentType As ContentType)
    _contentType = contentType
    _contentType.MediaType = MimeReader.GetMediaType(contentType.MediaType)
    _mediaMainType = MimeReader.GetMediaMainType(contentType.MediaType)
    _mediaSubType = MimeReader.GetMediaSubType(contentType.MediaType)
  End Sub

  ' ''' <summary>
  ' ''' Toes the mail message ex.
  ' ''' </summary>
  ' ''' <returns></returns>
  'Public Function ToMailMessageEx() As MailMessageEx
  '  Return ToMailMessageEx(Me)
  'End Function

  ' ''' <summary>
  ' ''' Toes the mail message ex.
  ' ''' </summary>
  ' ''' <param name="entity">The entity.</param>
  ' ''' <returns></returns>
  'Private Function ToMailMessageEx(entity As MimeEntity) As MailMessageEx
  '  If entity Is Nothing Then
  '    Throw New ArgumentNullException("entity")
  '  End If

  '  'parse standard headers and create base email.
  '  Dim message As MailMessageEx = MailMessageEx.CreateMailMessageFromEntity(entity)

  '  If Not String.IsNullOrEmpty(entity.ContentType.Boundary) Then
  '    message = MailMessageEx.CreateMailMessageFromEntity(entity)
  '    BuildMultiPartMessage(entity, message)
  '    'parse multipart message into sub parts.
  '  ElseIf String.Equals(entity.ContentType.MediaType, MediaTypes.MessageRfc822, StringComparison.InvariantCultureIgnoreCase) Then
  '    'use the first child to create the multipart message.
  '    If entity.Children.Count < 0 Then
  '      Throw New Pop3Exception("Invalid child count on message/rfc822 entity.")
  '    End If

  '    'create the mail message from the first child because it will
  '    'contain all of the mail headers.  The entity in this state
  '    'only contains simple content type headers indicating, disposition, type and description.
  '    'This means we can't create the mail message from this type as there is no 
  '    'internet mail headers attached to this entity.
  '    message = MailMessageEx.CreateMailMessageFromEntity(entity.Children(0))
  '    BuildMultiPartMessage(entity, message)
  '  Else
  '    'parse nested message.
  '    message = MailMessageEx.CreateMailMessageFromEntity(entity)
  '    BuildSinglePartMessage(entity, message)
  '  End If
  '  'Create single part message.
  '  Return message
  'End Function

  ' ''' <summary>
  ' ''' Builds the single part message.
  ' ''' </summary>
  ' ''' <param name="entity">The entity.</param>
  ' ''' <param name="message">The message.</param>
  'Private Sub BuildSinglePartMessage(entity As MimeEntity, message As MailMessageEx)
  '  SetMessageBody(message, entity)
  'End Sub


  Public Function GetEncoding() As Encoding
    If String.IsNullOrEmpty(Me.ContentType.CharSet) Then
      Return Encoding.ASCII
    Else
      Try
        Return Encoding.GetEncoding(Me.ContentType.CharSet)
      Catch generatedExceptionName As ArgumentException
        Return Encoding.ASCII
      End Try
    End If
  End Function

  ' ''' <summary>
  ' ''' Builds the multi part message.
  ' ''' </summary>
  ' ''' <param name="entity">The entity.</param>
  ' ''' <param name="message">The message.</param>
  'Private Sub BuildMultiPartMessage(entity As MimeEntity, message As MailMessageEx)
  '  For Each child As MimeEntity In entity.Children
  '    If String.Equals(child.ContentType.MediaType, MediaTypes.MultipartAlternative, StringComparison.InvariantCultureIgnoreCase) OrElse String.Equals(child.ContentType.MediaType, MediaTypes.MultipartMixed, StringComparison.InvariantCultureIgnoreCase) Then
  '      BuildMultiPartMessage(child, message)
  '      'if the message is mulitpart/alternative or multipart/mixed then the entity will have children needing parsed.
  '    ElseIf Not IsAttachment(child) AndAlso (String.Equals(child.ContentType.MediaType, MediaTypes.TextPlain) OrElse String.Equals(child.ContentType.MediaType, MediaTypes.TextHtml)) Then
  '      message.AlternateViews.Add(CreateAlternateView(child))

  '      SetMessageBody(message, child)
  '      'add the alternative views.
  '    ElseIf String.Equals(child.ContentType.MediaType, MediaTypes.MessageRfc822, StringComparison.InvariantCultureIgnoreCase) AndAlso String.Equals(child.ContentDisposition.DispositionType, DispositionTypeNames.Attachment, StringComparison.InvariantCultureIgnoreCase) Then
  '      message.Children.Add(ToMailMessageEx(child))
  '      'create a child message and 
  '    ElseIf IsAttachment(child) Then

  '      message.Attachments.Add(CreateAttachment(child))
  '    End If
  '  Next
  'End Sub

  Private Shared Function IsAttachment(child As MimeEntity) As Boolean
    Return (child.ContentDisposition IsNot Nothing) AndAlso (String.Equals(child.ContentDisposition.DispositionType, DispositionTypeNames.Attachment, StringComparison.InvariantCultureIgnoreCase))
  End Function

  ' ''' <summary>
  ' ''' Sets the message body.
  ' ''' </summary>
  ' ''' <param name="message">The message.</param>
  ' ''' <param name="child">The child.</param>
  'Private Sub SetMessageBody(message As MailMessageEx, child As MimeEntity)
  '  Dim encoding As Encoding = child.GetEncoding()
  '  message.Body = DecodeBytes(child.Content.ToArray(), encoding)
  '  message.BodyEncoding = encoding
  '  message.IsBodyHtml = String.Equals(MediaTypes.TextHtml, child.ContentType.MediaType, StringComparison.InvariantCultureIgnoreCase)
  'End Sub


  Private Function DecodeBytes(buffer As Byte(), encoding__1 As Encoding) As String
    If buffer Is Nothing Then
      Return Nothing
    End If

    If encoding__1 Is Nothing Then
      encoding__1 = Encoding.UTF7
    End If
    'email defaults to 7bit.  
    Return encoding__1.GetString(buffer)
  End Function

  ''' <summary>
  ''' Creates the alternate view.
  ''' </summary>
  ''' <param name="view">The view.</param>
  ''' <returns></returns>
  Private Function CreateAlternateView(view As MimeEntity) As AlternateView
    Dim alternateView As New AlternateView(view.Content, view.ContentType)
    alternateView.TransferEncoding = view.ContentTransferEncoding
    alternateView.ContentId = TrimBrackets(view.ContentId)
    Return alternateView
  End Function

  ''' <summary>
  ''' Trims the brackets.
  ''' </summary>
  ''' <param name="value">The value.</param>
  ''' <returns></returns>
  Public Shared Function TrimBrackets(value As String) As String
    If value Is Nothing Then
      Return value
    End If

    If value.StartsWith("<") AndAlso value.EndsWith(">") Then
      Return value.Trim("<"c, ">"c)
    End If

    Return value
  End Function

  ''' <summary>
  ''' Creates the attachment.
  ''' </summary>
  ''' <param name="entity">The entity.</param>
  ''' <returns></returns>
  Private Function CreateAttachment(entity As MimeEntity) As Attachment
    Dim attachment As New Attachment(entity.Content, entity.ContentType)

    If entity.ContentDisposition IsNot Nothing Then
      attachment.ContentDisposition.Parameters.Clear()
      For Each key As String In entity.ContentDisposition.Parameters.Keys
        attachment.ContentDisposition.Parameters.Add(key, entity.ContentDisposition.Parameters(key))
      Next

      attachment.ContentDisposition.CreationDate = entity.ContentDisposition.CreationDate
      attachment.ContentDisposition.DispositionType = entity.ContentDisposition.DispositionType
      attachment.ContentDisposition.FileName = entity.ContentDisposition.FileName
      attachment.ContentDisposition.Inline = entity.ContentDisposition.Inline
      attachment.ContentDisposition.ModificationDate = entity.ContentDisposition.ModificationDate
      attachment.ContentDisposition.ReadDate = entity.ContentDisposition.ReadDate
      attachment.ContentDisposition.Size = entity.ContentDisposition.Size
    End If

    If Not String.IsNullOrEmpty(entity.ContentId) Then
      attachment.ContentId = TrimBrackets(entity.ContentId)
    End If

    attachment.TransferEncoding = entity.ContentTransferEncoding

    Return attachment
  End Function
End Class
Public Class MimeReader
  Private Shared ReadOnly HeaderWhitespaceChars As Char() = New Char() {" "c, ControlChars.Tab}

  Private _lines As Queue(Of String)
  ''' <summary>
  ''' Gets the lines.
  ''' </summary>
  ''' <value>The lines.</value>
  Public ReadOnly Property Lines() As Queue(Of String)
    Get
      Return _lines
    End Get
  End Property

  Private _entity As MimeEntity

  ''' <summary>
  ''' Initializes a new instance of the <see cref="MimeReader"/> class.
  ''' </summary>
  Private Sub New()
    _entity = New MimeEntity()
  End Sub

  ''' <summary>
  ''' Initializes a new instance of the <see cref="MimeReader"/> class.
  ''' </summary>
  ''' <param name="entity">The entity.</param>
  ''' <param name="lines">The lines.</param>
  Private Sub New(entity As MimeEntity, lines As Queue(Of String))
    Me.New()
    If entity Is Nothing Then
      Throw New ArgumentNullException("entity")
    End If

    If lines Is Nothing Then
      Throw New ArgumentNullException("lines")
    End If

    _lines = lines
    _entity = New MimeEntity(entity)
  End Sub

  ''' <summary>
  ''' Initializes a new instance of the <see cref="MimeReader"/> class.
  ''' </summary>
  ''' <param name="lines">The lines.</param>
  Public Sub New(lines As String())
    Me.New()
    If lines Is Nothing Then
      Throw New ArgumentNullException("lines")
    End If

    _lines = New Queue(Of String)(lines)
  End Sub

  ''' <summary>
  ''' Parse headers into _entity.Headers NameValueCollection.
  ''' </summary>
  Private Function ParseHeaders() As Integer
    Dim lastHeader As String = String.Empty
    Dim line As String = String.Empty
    ' the first empty line is the end of the headers.
    While _lines.Count > 0 AndAlso Not String.IsNullOrEmpty(_lines.Peek())
      line = _lines.Dequeue()

      'if a header line starts with a space or tab then it is a continuation of the
      'previous line.
      If line.StartsWith(" ") OrElse line.StartsWith(Convert.ToString(ControlChars.Tab)) Then
        _entity.Headers(lastHeader) = String.Concat(_entity.Headers(lastHeader), line)
        Continue While
      End If

      Dim separatorIndex As Integer = line.IndexOf(":"c)

      If separatorIndex < 0 Then
        System.Diagnostics.Debug.WriteLine("Invalid header:{0}", line)
        Continue While
      End If
      'This is an invalid header field.  Ignore this line.
      Dim headerName As String = line.Substring(0, separatorIndex)
      Dim headerValue As String = line.Substring(separatorIndex + 1).Trim(HeaderWhitespaceChars)

      _entity.Headers.Add(headerName.ToLower(), headerValue)
      lastHeader = headerName
    End While

    If _lines.Count > 0 Then
      _lines.Dequeue()
    End If
    'remove closing header CRLF.
    Return _entity.Headers.Count
  End Function


  Private Sub ProcessHeaders()
    For Each key As String In _entity.Headers.AllKeys
      Select Case key
        Case "content-description"
          _entity.ContentDescription = _entity.Headers(key)
          Exit Select
        Case "content-disposition"
          _entity.ContentDisposition = New ContentDisposition(_entity.Headers(key))
          Exit Select
        Case "content-id"
          _entity.ContentId = _entity.Headers(key)
          Exit Select
        Case "content-transfer-encoding"
          _entity.TransferEncoding = _entity.Headers(key)
          _entity.ContentTransferEncoding = MimeReader.GetTransferEncoding(_entity.Headers(key))
          Exit Select
        Case "content-type"
          _entity.SetContentType(MimeReader.GetContentType(_entity.Headers(key)))
          Exit Select
        Case "mime-version"
          _entity.MimeVersion = _entity.Headers(key)
          Exit Select
      End Select
    Next
  End Sub

  ' ''' <summary>
  ' ''' Creates the MIME entity.
  ' ''' </summary>
  ' ''' <returns>A mime entity containing 0 or more children representing the mime message.</returns>
  'Public Function CreateMimeEntity() As MimeEntity
  '  ParseHeaders()

  '  ProcessHeaders()

  '  ParseBody()

  '  SetDecodedContentStream()

  '  Return _entity
  'End Function



  'Private Sub SetDecodedContentStream()
  '  Select Case _entity.ContentTransferEncoding
  '    Case System.Net.Mime.TransferEncoding.Base64
  '      _entity.Content = New MemoryStream(Convert.FromBase64String(_entity.EncodedMessage.ToString()), False)
  '      Exit Select

  '    Case System.Net.Mime.TransferEncoding.QuotedPrintable
  '      _entity.Content = New MemoryStream(GetBytes(QuotedPrintableEncoding.Decode(_entity.EncodedMessage.ToString())), False)
  '      Exit Select

  '			Case System.Net.Mime.TransferEncoding.SevenBit, Else
  '      _entity.Content = New MemoryStream(GetBytes(_entity.EncodedMessage.ToString()), False)
  '      Exit Select
  '  End Select
  'End Sub

  Private Function GetBytes(content As String) As Byte()
    Using stream As New MemoryStream()
      Using writer As New StreamWriter(stream)
        writer.Write(content)
      End Using
      Return stream.ToArray()
    End Using
  End Function

  ' ''' <summary>
  ' ''' Parses the body.
  ' ''' </summary>
  'Private Sub ParseBody()
  '  If _entity.HasBoundary Then
  '    While _lines.Count > 0 AndAlso Not String.Equals(_lines.Peek(), _entity.EndBoundary)
  '      'Check to verify the current line is not the same as the parent starting boundary.  
  '      '                       If it is the same as the parent starting boundary this indicates existence of a 
  '      '                       new child entity. Return and process the next child.

  '      If _entity.Parent IsNot Nothing AndAlso String.Equals(_entity.Parent.StartBoundary, _lines.Peek()) Then
  '        Return
  '      End If

  '      If String.Equals(_lines.Peek(), _entity.StartBoundary) Then
  '        AddChildEntity(_entity, _lines)
  '        'Parse a new child mime part.
  '      ElseIf String.Equals(_entity.ContentType.MediaType, MediaTypes.MessageRfc822, StringComparison.InvariantCultureIgnoreCase) AndAlso String.Equals(_entity.ContentDisposition.DispositionType, DispositionTypeNames.Attachment, StringComparison.InvariantCultureIgnoreCase) Then
  '        'If the content type is message/rfc822 the stop condition to parse headers has already been encountered.
  '        '                         But, a content type of message/rfc822 would have the message headers immediately following the mime
  '        '                         headers so we need to parse the headers for the attached message now.  This is done by creating
  '        '                         a new child entity.

  '        AddChildEntity(_entity, _lines)

  '        Exit While
  '      Else
  '        _entity.EncodedMessage.Append(String.Concat(_lines.Dequeue(), Pop3Commands.Crlf))
  '        'Append the message content.
  '      End If
  '    End While
  '  Else
  '    'Parse a multipart message.
  '    While _lines.Count > 0
  '      _entity.EncodedMessage.Append(String.Concat(_lines.Dequeue(), Pop3Commands.Crlf))
  '    End While
  '  End If
  '  'Parse a single part message.
  'End Sub

  ' ''' <summary>
  ' ''' Adds the child entity.
  ' ''' </summary>
  ' ''' <param name="entity">The entity.</param>
  'Private Sub AddChildEntity(entity As MimeEntity, lines As Queue(Of String))
  '  'if (entity == null)
  '  '            {
  '  '                return;
  '  '            }
  '  '
  '  '            if (lines == null)
  '  '            {
  '  '                return;
  '  '            }


  '  Dim reader As New MimeReader(entity, lines)
  '  entity.Children.Add(reader.CreateMimeEntity())
  'End Sub

  '  ''' <summary>
  '  ''' Gets the type of the content.
  '  ''' </summary>
  '  ''' <param name="contentType">Type of the content.</param>
  '  ''' <returns></returns>
  Public Shared Function GetContentType(contentType As String) As ContentType
    If String.IsNullOrEmpty(contentType) Then
      contentType = "text/plain; charset=us-ascii"
    End If
    Return New ContentType(contentType)

  End Function

  ''' <summary>
  ''' Gets the type of the media.
  ''' </summary>
  ''' <param name="mediaType">Type of the media.</param>
  ''' <returns></returns>
  Public Shared Function GetMediaType(mediaType As String) As String
    If String.IsNullOrEmpty(mediaType) Then
      Return "text/plain"
    End If
    Return mediaType.Trim()
  End Function

  ''' <summary>
  ''' Gets the type of the media main.
  ''' </summary>
  ''' <param name="mediaType">Type of the media.</param>
  ''' <returns></returns>
  Public Shared Function GetMediaMainType(mediaType As String) As String
    Dim separatorIndex As Integer = mediaType.IndexOf("/"c)
    If separatorIndex < 0 Then
      Return mediaType
    Else
      Return mediaType.Substring(0, separatorIndex)
    End If
  End Function

  ''' <summary>
  ''' Gets the type of the media sub.
  ''' </summary>
  ''' <param name="mediaType">Type of the media.</param>
  ''' <returns></returns>
  Public Shared Function GetMediaSubType(mediaType As String) As String
    Dim separatorIndex As Integer = mediaType.IndexOf("/"c)
    If separatorIndex < 0 Then
      If mediaType.Equals("text") Then
        Return "plain"
      End If
      Return String.Empty
    Else
      If mediaType.Length > separatorIndex Then
        Return mediaType.Substring(separatorIndex + 1)
      Else
        Dim mainType As String = GetMediaMainType(mediaType)
        If mainType.Equals("text") Then
          Return "plain"
        End If
        Return String.Empty
      End If
    End If
  End Function

  '  ''' <summary>
  '  ''' Gets the transfer encoding.
  '  ''' </summary>
  '  ''' <param name="transferEncoding">The transfer encoding.</param>
  '  ''' <returns></returns>
  '  ''' <remarks>
  '  ''' The transfer encoding determination follows the same rules as 
  '  ''' Peter Huber's article w/ the exception of not throwing exceptions 
  '  ''' when binary is provided as a transferEncoding.  Instead it is left
  '  ''' to the calling code to check for binary.
  '  ''' </remarks>
  Public Shared Function GetTransferEncoding(transferEncoding As String) As TransferEncoding
    Select Case transferEncoding.Trim().ToLowerInvariant()
      Case "7bit", "8bit"
        Return System.Net.Mime.TransferEncoding.SevenBit
      Case "quoted-printable"
        Return System.Net.Mime.TransferEncoding.QuotedPrintable
      Case "base64"
        Return System.Net.Mime.TransferEncoding.Base64
      Case Else
        Return System.Net.Mime.TransferEncoding.Unknown

    End Select
  End Function
End Class