Namespace Domain
    Public Class Player
        Sub New()
            Positions = New List(Of Positions)()
            Statitics = New Stats()
            Team = New Team()
            Skill = New Skills()
            ItemsOwned = New Dictionary(Of ShopItem, Integer)()
            EnergyLevel = 100
            BankBalance = 100
            SkillsCredit = 100
        End Sub

        Public FirstName As String
        Public LastName As String
        Public DateOfBirth As Date
        Public Positions As List(Of Positions)
        Public HasAskedForATrade As Boolean
        Public QualityOfLife As Integer
        Public EnergyLevel As Integer
        Public BankBalance As Integer
        Public SkillsCredit As Integer
        Public Statitics As Stats 'Needs more fine tuning (by seasons)
        Public Skill As Skills
        Public Team As Team
        Public ItemsOwned As Dictionary(Of ShopItem, Integer)
    End Class
End Namespace