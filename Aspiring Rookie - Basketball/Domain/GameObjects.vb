Namespace Domain
    Public Class GameObjects
        Sub New()
            Teams = New List(Of Team)()
            Player = New Player()
            Fixtures = New List(Of List(Of Fixture))()
        End Sub

        Public Teams As List(Of Team)
        Public Player As Player
        Public Round As Integer
        Public Fixtures As List(Of List(Of Fixture))
    End Class
End Namespace