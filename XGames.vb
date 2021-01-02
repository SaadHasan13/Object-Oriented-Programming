Module Module1
    Sub Main()
        Dim BMXJudge As New Official("Omar", "Ellaboudy", "Male", #8/13/2002#, "Judge", True)
        BMXJudge.DisplayJobTitle()
        Console.ReadKey()
    End Sub
End Module
Class Member
    Private FirstName, LastName, Gender As String
    Private DateOfBirth As Date
    Public Sub New(ByVal FName As String, ByVal LName As String, ByVal GenderVal As String, ByVal DOB As Date)
        FirstName = FName
        LastName = LName
        Gender = GenderVal
        DateOfBirth = DOB
    End Sub
    Public Function Introduction() As String
        Dim Message As String
        Message = (" Hello, I am " + FirstName + " " + LastName + " " + DateOfBirth)
        Return Message
    End Function
    Public Function DisplayFullNameAndDateOfBirth() As String
        DisplayFullNameAndDateOfBirth = FirstName + " " + LastName + " " + DateOfBirth
    End Function
End Class
Class Competitor : Inherits Member
    Private Sport As String
    Public Sub New(ByVal FName As String, ByVal LName As String, ByVal GenderVal As String, ByVal DOB As Date, ByVal SportVal As String)
        MyBase.New(FName, LName, DOB, GenderVal)
        Sport = SportVal
    End Sub
    Public Overloads Function Introduction() As String
        Dim Message As String
        Dim FName As String
        Dim LName As String
        Message = (" Hello, I am " + FName + " " + LName + " and my sport is " + Sport)
        Return Message
    End Function
End Class
Class Official : Inherits Member
    Private JobTitle As String
    Private FirstAidTrained As Boolean
    Public Sub New(ByVal FName As String, ByVal LName As String, ByVal GenderVal As String, ByVal DOB As Date, ByVal Job As String, ByVal FAT As Boolean)
        MyBase.New(FName, LName, GenderVal, DOB)
        JobTitle = Job
        FirstAidTrained = FAT
    End Sub
    Public Function DisplayJobTitle() As String
        Dim FName As String = "Omar"
        Dim LName As String = "Ellaboudy"
        Dim Gender As String = "Male"
        Dim DOB As Date = #8/13/2002#
        JobTitle = "Judge"
        FirstAidTrained = True
        Console.WriteLine("Display the official's position.")
        DisplayJobTitle = (FName + " " + LName + " " + Gender + " " + DOB + JobTitle + " " + FirstAidTrained)
        Return DisplayJobTitle
    End Function
End Class