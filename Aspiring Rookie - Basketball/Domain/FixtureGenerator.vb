Namespace Domain
    Public Module FixtureGenerator
        Public Function CreateFixtures(teamNames As List(Of String), Optional isDoubleRoundRobin As Boolean = False) As List(Of List(Of Tuple(Of String, String)))
            Const bye = "BYE"
            Dim oddTeams = teamNames.Count() Mod 2 = 1
            If oddTeams Then
                teamNames.Add(bye)
            End If

            Dim result = New List(Of List(Of Tuple(Of String, String)))
            GetRoundRobin(teamNames, result)

            'If odd teams filter out the bye
            If oddTeams Then
                FilterOutByes(bye, result)
            End If

            If isDoubleRoundRobin Then
                DoubleRoundRobin(result)
            End If

            Return result
        End Function

        Private Sub DoubleRoundRobin(result As List(Of List(Of Tuple(Of String, String))))

            Dim roundToBeAdded = New List(Of List(Of Tuple(Of String, String)))
            For Each round In result
                Dim reverseRound = New List(Of Tuple(Of String, String))
                For Each fixture In round
                    reverseRound.Add(System.Tuple.Create(fixture.Item2, fixture.Item1))
                Next
                roundToBeAdded.Add(reverseRound)
            Next
            result.AddRange(roundToBeAdded)
        End Sub

        Private Sub GetRoundRobin(teamNames As List(Of String), result As List(Of List(Of Tuple(Of String, String))))

            For i = 0 To teamNames.Count() - 2
                Dim middle = teamNames.Count() / 2
                Dim firstPart = teamNames.GetRange(0, middle)
                Dim rest = teamNames.GetRange(middle, middle)
                rest.Reverse()

                If i Mod 2 = 1 Then
                    Dim zipResult = Zip(firstPart, rest)
                    result.Add(zipResult)
                Else
                    Dim zipResult = Zip(rest, firstPart)
                    result.Add(zipResult)
                End If

                teamNames.Insert(1, teamNames.Item(teamNames.Count() - 1))
                teamNames.RemoveAt(teamNames.Count() - 1)
            Next
        End Sub

        Private Sub FilterOutByes(bye As String, result As List(Of List(Of Tuple(Of String, String))))

            For Each round In result
                Dim toBeRemoved = New List(Of Tuple(Of String, String))
                For Each fixture In round
                    If fixture.Item1 = Bye Or fixture.Item2 = Bye Then
                        toBeRemoved.Add(fixture)
                    End If
                Next
                toBeRemoved.ForEach(Function(item) round.Remove(item))
            Next
        End Sub

        Private Function Zip(listA As List(Of String), listB As List(Of String)) As List(Of Tuple(Of String, String))
            Dim result = New List(Of Tuple(Of String, String))
            For i = 0 To listA.Count - 1
                result.Add(System.Tuple.Create(listA.Item(i), listB.Item(i)))
            Next
            Return result
        End Function
    End Module
End Namespace