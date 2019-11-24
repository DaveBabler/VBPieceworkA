Public Class GlobalClass
    'This class will contain subs, functions and properties that may be used by any other class.
    'Most of this code would be called "static" methods in other languages.
    'This class exists to organize custom code chunks that could be called by other classes but don't quite need their own class

    Public Shared Sub UserErrorMessage(ByVal strMessage As String, ByVal strTitle As String)
        ' a quick way of sending a popup error box instead of recoding the thing the whole time I am tired of it.
        MsgBox(strMessage, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, strTitle)

    End Sub

End Class
