Imports Aspiring_Rookie___Basketball.Data

Namespace Domain
    Public Module GameController
        Sub New()
            GameObjects = New GameObjects()
            GameObjects.Teams = DataManager.GetNewTeamData()
            GameObjects.Fixtures = CreateFixtures()
        End Sub

        Public GameObjects As GameObjects

        Public Function GetAllShopItems() As List(Of ShopItem)
            Return DataManager.GetAllShopItems()
        End Function

        Private Function CreateFixtures() As List(Of List(Of Fixture))
            Dim teamNames = gameObjects.Teams.Select(Function(team) team.Name).ToList()
            Dim fixtures = FixtureGenerator.CreateFixtures(teamNames, True)
            Dim teamDict = gameObjects.Teams.ToDictionary(Function(team) team.Name)

            Dim fullFixtures = New List(Of List(Of Fixture))
            For Each round In fixtures
                Dim fullRound = New List(Of Fixture)
                For Each fixture In round
                    Dim fullFixture = New Fixture With {.HomeTeam = teamDict.Item(fixture.Item1), .AwayTeam = teamDict.Item(fixture.Item2)}
                    fullRound.Add(fullFixture)
                Next
                fullFixtures.Add(fullRound)
            Next

            Return fullFixtures
        End Function

        'Probably belongs in the UI
        Public Function GetCurrentFixturesAsDataTable() As DataTable
            Dim data = gameObjects.Fixtures.Item(gameObjects.Round)
            Dim table As DataTable = New DataTable()
            table.Columns.Add("Home")
            table.Columns.Add("Versus")
            table.Columns.Add("Away")
            table.Columns.Add("Home Points")
            table.Columns.Add("Away Points")

            For Each fixture In data
                table.Rows.Add(New Object() {fixture.HomeTeam.Name, "vs", fixture.AwayTeam.Name})
            Next

            Return table
        End Function

        'Probably belongs in the UI
        Public Function GetCurrentLeagueTable() As DataTable
            Dim data = gameObjects.Teams
            data = data.OrderBy(Function(team) team.Name).ToList().OrderByDescending(Function(team) team.Wins).ToList()

            Dim table As DataTable = New DataTable()
            table.Columns.Add("Position")
            table.Columns.Add("Team Name")
            table.Columns.Add("Wins (W)")
            table.Columns.Add("Losses (L)")
            
            For i = 0 To data.Count - 1
                Dim team As Team = data.Item(i)
                table.Rows.Add(New Object() {GetPostition(i + 1), team.Name, team.Wins, team.Losses})
            Next
            
            Return table
        End Function

        'Probably belongs in the UI
        Private Function GetPostition(position As String) As String
            Dim suffix = "th"
            If position.Chars(position.Length - 1) = "1" Then
                suffix = "st"
            ElseIf position.Chars(position.Length - 1) = "2" Then
                suffix = "nd"
            ElseIf position.Chars(position.Length - 1) = "3" Then
                suffix = "rd"
            End If

            Return position + suffix
        End Function

    End Module
End Namespace