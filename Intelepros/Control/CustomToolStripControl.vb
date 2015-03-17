Imports System.Windows.Forms
Namespace Custom_ToolStrip

  Public Class MyCustomToolStripControlHost
    Inherits ToolStripControlHost
    Public Sub New()
      MyBase.New(New Control())
    End Sub
    Public Sub New(c As Control)
      MyBase.New(c)
    End Sub
    Public Sub New(c As Control, name As String)
      MyBase.New(c, name)
    End Sub
  End Class
End Namespace