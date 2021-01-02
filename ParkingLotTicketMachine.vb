Module Module1
    Sub Main()
        Dim ParkingMeter As New TicketMachine()
        While True
            ParkingMeter.ChangeinState()
        End While
        Console.ReadKey()
    End Sub
End Module
Class TicketMachine
    Dim Amount As Integer
    Dim State As String
    Public Sub New()
        Dim Amount As Integer = 0
        Dim State As String = "Idle"
    End Sub
    Public Sub SetState(NewState As String)
        Me.State = NewState
        Console.WriteLine(State)
    End Sub
    Public Sub ReturnCoins()
        Console.WriteLine(Me.Amount)
        Me.Amount = 0
    End Sub
    Public Sub PrintTicket()
        Dim NameOfPerson As String
        Dim TimeOfArrival As Date
        If ValidCoin(Amount = "10" Or Amount = "20" Or Amount = "50" Or Amount = "100") Then
            Me.Amount = 0
        End If
    End Sub
    Public Function ValidCoin(ByVal s As String) As Boolean
        If s = "10" Or s = "20" Or s = "50" Or s = "100" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub CoinInserted(ByVal S As String)
        Dim CoinValue As Integer
        CoinValue = Int(S)
        Me.Amount = Me.Amount + CoinValue
    End Sub
    Public Sub ChangeinState()
        Dim ButtonPressed As String
        ButtonPressed = Console.ReadLine()
        If ButtonPressed = "C" Then
            If State = "Counting" Then
                SetState("Cancelled")
                ReturnCoins()
            End If
            SetState("Idle")
        ElseIf ButtonPressed = "A" Then
            Amount = Console.ReadLine()
            If Amount = 0 Then
                Console.WriteLine("No coins inserted")
            Else
                SetState("Accepted")
                PrintTicket()
            End If
            SetState("Ticket Printed.")
        ElseIf ValidCoin(ButtonPressed) Then
            CoinInserted(ButtonPressed)
            SetState("Counting")
        Else
            Console.WriteLine("Error-invalid coin.")
        End If
    End Sub
End Class
