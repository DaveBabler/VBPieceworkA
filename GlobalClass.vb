Public Class GlobalClass
    'This class will contain subs, functions and properties that may be used by any other class.
    'Most of this code would be called "static" methods in other languages.
    'This class exists to organize custom code chunks that could be called by other classes but don't quite need their own class

    Public Shared Sub UserErrorMessage(ByVal strMessage As String, ByVal strTitle As String)
        ' a quick way of sending a popup error box instead of recoding the thing the whole time I am tired of it.
        MsgBox(strMessage, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, strTitle)

    End Sub


    Public Shared Function CheckWorkerInt(ByVal strIncWorkerName As String, ByRef strPrevWorkerName As String) As Integer
        'If the stored user name matches the same name entered it asks the user
        'if they are the same person, if they are it returns a 1 or a 0 for tabulating the number 
        'of users! This allows us to get actual averages
        'at the end it sets the current worker as the stored worker for later comparison 
        Dim msgNameResponse As MsgBoxResult

        Dim intDiffUser As Integer

        If String.Equals(strIncWorkerName, strPrevWorkerName) Then

            msgNameResponse = MsgBox("It appears that the same name from the last user is still in the user box, are you the same person?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Same User")
            If msgNameResponse = vbYes Then
                'if the person is the same then we shan't update the person counter
                intDiffUser = 0
            Else
                intDiffUser = 1
            End If
        Else
            'if they don't equal they shouldn't be the same person so we increment 
            'this includes if the value before was null! Because then by default they won't equal.
            intDiffUser = 1

        End If


        'Set the class variable
        strPrevWorkerName = strIncWorkerName
        Return intDiffUser
    End Function

    Public Shared Function CheckWorkerBool(ByVal strIncWorkerName As String, ByRef strPrevWorkerName As String) As Boolean
        'If the stored user name matches the same name entered it asks the user
        'if they are the same person, if they are it returns a True or a False for tabulating the number 
        'of users! This allows us to get actual averages
        'at the end it sets the current worker as the stored worker for later comparison 
        Dim msgNameResponse As MsgBoxResult

        Dim boolDiffUser As Boolean

        If String.Equals(strIncWorkerName, strPrevWorkerName) Then

            msgNameResponse = MsgBox("It appears that the same name from the last user is still in the user box, are you the same person?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Same User")
            If msgNameResponse = vbYes Then
                'if the person is the same then we shan't update the person counter
                boolDiffUser = False
            Else
                boolDiffUser = True
            End If
        Else
            'if they don't equal they shouldn't be the same person so we increment 
            'this includes if the value before was null! Because then by default they won't equal.
            boolDiffUser = True

        End If


        'Set the class variable
        strPrevWorkerName = strIncWorkerName
        Return boolDiffUser
    End Function



End Class
