Class SafetyDepositBox
    Dim Code, state As String
    Public Sub New()
        Code = " "
        state = "Open No-Code."
    End Sub
    Public Sub Reset()
        Code = " "
    End Sub
    Public Sub SetState(ByVal Newstate As String)
        State = Newstate
        Console.WriteLine(Newstate)
    End Sub
    Public Sub Setnewcode(NewCode)
        Code = NewCode
        Console.WriteLine("The new code is : " & Code)
    End Sub
    Public Function Valid(ByVal S As String) As Boolean
        If Len(S) = 4 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub ChangeInState()
        Dim Characters As String
        Characters = Console.ReadLine()
        If Characters = " R " Then
            If state = "Open Code-Set." Then
                Reset()
                SetState("Open No-Code.")
            End If
        ElseIf Characters = Code Then
            If state = "Locked." Then
                SetState("Open Code-Set.")
            ElseIf state = "Closed." Then
                SetState("Locked.")
            End If
        ElseIf (Characters = " ") And (state = "Open Code-Set.") Then
            SetState("Closed.")
        ElseIf Valid(Characters) Then
            If state = "Open No-Code." Then
                Setnewcode(Characters)
                SetState("Open Code-Set.")
            Else
                Console.WriteLine("ERROR - The code entered does not match the preset code.")
            End If
        Else
            Console.WriteLine("ERROR - Code format is incorrect.")
        End If
    End Sub

End Class
Module Module1
    Sub Main()
        Dim ThisSafe As New SafetyDepositBox()
        Do
            ThisSafe.ChangeInState()
        Loop
        Console.ReadKey()
    End Sub
End Module