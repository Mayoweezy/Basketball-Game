Imports System.Data.OleDb

Public Class Game_Box

    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click
        Dim InScoreAbil As Integer = ProgressBar1.Value
        Dim a As Integer = Skills.ProgressBar1.Value
        Dim b As Integer = Skills.ProgressBar2.Value
        Dim c As Integer = Skills.ProgressBar3.Value
        Dim d As Integer = Skills.ProgressBar4.Value
        Dim f As Integer = Skills.ProgressBar5.Value

        InScoreAbil = (a + b + c + d + f) / 5

        ProgressBar1.Value = InScoreAbil

    End Sub
    Private Sub ProgressBar2_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar2.Click
        Dim OutScoreAbil As Integer = ProgressBar2.Value
        Dim a As Integer = Skills.ProgressBar6.Value
        Dim d As Integer = Skills.ProgressBar4.Value
      
        OutScoreAbil = (a + d) / 2

        ProgressBar2.Value = OutScoreAbil
    End Sub
    Private Sub ProgressBar4_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar4.Click
        Dim PassAbil As Integer = ProgressBar4.Value
        Dim a As Integer = Skills.ProgressBar7.Value
        Dim b As Integer = Skills.ProgressBar8.Value
        Dim c As Integer = Skills.ProgressBar9.Value

        PassAbil = (a + b + c) / 3

        ProgressBar4.Value = PassAbil
    End Sub
    Private Sub ProgressBar3_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar3.Click
        Dim AthAbil As Integer = ProgressBar3.Value
        Dim a As Integer = Skills.ProgressBar11.Value
        Dim b As Integer = Skills.ProgressBar12.Value
        Dim c As Integer = Skills.ProgressBar13.Value
        Dim d As Integer = Skills.ProgressBar14.Value
        Dim f As Integer = Skills.ProgressBar15.Value

        AthAbil = (a + b + c + d + f) / 5

        ProgressBar3.Value = AthAbil
    End Sub
    Private Sub ProgressBar5_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar5.Click
        Dim defendabil As Integer = ProgressBar5.Value
        Dim a As Integer = Skills.ProgressBar18.Value
        Dim b As Integer = Skills.ProgressBar19.Value
        Dim c As Integer = Skills.ProgressBar20.Value
        defendabil = (a + b + c) / 3
        Math.Ceiling(defendabil)

        ProgressBar6.Value = defendabil
    End Sub
    Private Sub ProgressBar6_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar6.Click
        Dim ReboundAbil As Integer = ProgressBar6.Value
        Dim a As Integer = Skills.ProgressBar14.Value
        Dim b As Integer = Skills.ProgressBar15.Value
        Dim c As Integer = Skills.ProgressBar16.Value
        Dim d As Integer = Skills.ProgressBar17.Value
        Dim f As Integer = Skills.ProgressBar18.Value

        ReboundAbil = (a + b + c + d + f) / 5

        ProgressBar6.Value = ReboundAbil
    End Sub
    Private Sub ProgressBar7_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar7.Click
        Dim StealAbil As Integer = ProgressBar7.Value
        Dim a As Integer = Skills.ProgressBar17.Value
        Dim b As Integer = Skills.ProgressBar18.Value
        Dim c As Integer = Skills.ProgressBar20.Value


        StealAbil = (a + b + c) / 3

        ProgressBar7.Value = StealAbil
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles ButShoot2pt.Click
        Dim randoms(100) As Integer
        Dim z As Double
        Dim x As Integer = TextBox3.Text
        Dim v As Integer = 2



        If ProgressBar1.Value <= 10 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 65)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a Two And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If




        If ProgressBar1.Value <= 20 > 10 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 75)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a Two And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If



        If ProgressBar1.Value <= 30 > 20 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 90)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a Two And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If

        Dim y As Integer = -1
        Dim m As Integer = TextBox1.Text
        Dim d As Double
        d = m + y

        TextBox1.Text = d


        If ProgressBar1.Value <= 40 > 30 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a Two And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If

        If ProgressBar1.Value <= 50 > 40 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a Two And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If

        If ProgressBar1.Value <= 60 > 50 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(20, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a Two And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If

        If ProgressBar1.Value <= 70 > 60 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(30, 105)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a Two And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next


            If ProgressBar1.Value <= 80 > 70 Then
                For i As Integer = 0 To randoms.Length - 1
                    randoms(i) = GetRandom(35, 100)
                    If i <= 50 Then
                        TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                        z = x + v
                        TextBox3.Text = z
                    Else
                        TextBox11.Text = TextBox11.Text + "Shoots a Two And Misses"
                        For k As Integer = 0 To randoms.Length - 1
                            randoms(k) = GetRandom(55, 100)
                            If k <= 70 Then
                                TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                                z = x + v
                                TextBox3.Text = z
                            Else
                                TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                            End If
                        Next
                    End If
                Next

                If ProgressBar1.Value <= 90 > 80 Then
                    For i As Integer = 0 To randoms.Length - 1
                        randoms(i) = GetRandom(40, 100)
                        If i <= 50 Then
                            TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Shoots a Two And Misses"
                            For k As Integer = 0 To randoms.Length - 1
                                randoms(k) = GetRandom(55, 100)
                                If k <= 70 Then
                                    TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                                    z = x + v
                                    TextBox3.Text = z
                                Else
                                    TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                                End If
                            Next
                        End If
                    Next

                    If ProgressBar1.Value <= 99 > 90 Then
                        For i As Integer = 0 To randoms.Length - 1
                            randoms(i) = GetRandom(45, 100)
                            If i <= 50 Then
                                TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                                z = x + v
                                TextBox3.Text = z
                            Else
                                TextBox11.Text = TextBox11.Text + "Shoots a Two And Misses"
                                For k As Integer = 0 To randoms.Length - 1
                                    randoms(k) = GetRandom(55, 100)
                                    If k <= 70 Then
                                        TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                                        z = x + v
                                        TextBox3.Text = z
                                    Else
                                        TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                                    End If
                                Next
                            End If
                        Next

                        If ProgressBar1.Value = 100 Then
                            For i As Integer = 0 To randoms.Length - 1
                                randoms(i) = GetRandom(51, 100)
                                If i <= 50 Then
                                    TextBox11.Text = TextBox11.Text + "KOBE!!! Nets a beautiful 2 pointer"
                                    z = x + v
                                    TextBox3.Text = z
                                End If
                            Next
                        End If
                    End If
                End If
        End If
        End If
    End Sub

    Private Sub Game_Box_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=League.accdb"
        Dim MyConn As OleDbConnection
        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        Dim tables As DataTableCollection
        Dim source1 As New BindingSource

        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [FixtureTable1] ", MyConn)
        da.Fill(ds, "FixtureTable1")
        'Dim view As New DataView(tables(0))
        'source1.DataSource = view
        'DataGridView1.DataSource = view
        If ds.Tables(0).Rows.Count = 1 Then
            'Label18.Text = ds.Tables(0).Rows(0)
        End If

        Dim txtDef As String = "defending.txt"
        Dim txtDefRebound As String = "Defensive Rebound.txt"
        Dim txtDunkAO As String = "DunkAlleyOop.txt"
        Dim txtAttack As String = "Offence.txt"
        Dim txtOffReb As String = "OffRebound.txt"
        Dim txtthreepoint As String = "threepointtxt.txt"
        Dim threepoint As String = "3ptOrDribble.txt"

        txtAttack = 0
        txtDef = 1

    End Sub

    Private Sub Label18_Click(sender As System.Object, e As System.EventArgs) Handles Label18.Click

    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub ButPass_Click(sender As System.Object, e As System.EventArgs) Handles ButPass.Click
        Dim randoms(100) As Integer
        Dim z As Double
        Dim x As Integer = TextBox3.Text
        Dim c As Integer = 3
        Dim v As Integer = 2



        If ProgressBar4.Value <= 10 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 70)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Precise and Quality Pass to his teammate"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                            z = x + c
                            TextBox3.Text = z
                        End If
                        If k <= 50 > 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a mid range"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                        End If
                    Next
                Else
                    TextBox11.Text = TextBox11.Text + "Lost Possession by passing to the opposition"
                End If
            Next

        End If


        If ProgressBar4.Value <= 20 > 10 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 80)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Precise and Quality Pass to his teammate"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(45, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                            z = x + c
                            TextBox3.Text = z
                        End If
                        If k <= 50 > 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and DUNKS IT"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                        End If
                    Next
                Else
                    TextBox11.Text = TextBox11.Text + "Lost Possession by passing to the opposition"
                End If
            Next

        End If

        If ProgressBar4.Value <= 30 > 20 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 90)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Precise and Quality Pass to his teammate"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(35, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                            z = x + c
                            TextBox3.Text = z
                        End If
                        If k <= 50 > 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a mid range"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                        End If
                    Next
                Else
                    TextBox11.Text = TextBox11.Text + "Lost Possession by passing to the opposition"
                End If
            Next

            Dim y As Integer = -1
            Dim m As Integer = TextBox1.Text
            Dim d As Double
            d = m + y

            TextBox1.Text = d


        End If

        If ProgressBar4.Value <= 40 > 30 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Precise and Quality Pass to his teammate"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(25, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                            z = x + c
                            TextBox3.Text = z
                        End If
                        If k <= 50 > 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a mid range"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                        End If
                    Next
                Else
                    TextBox11.Text = TextBox11.Text + "Lost Possession by passing to the opposition"
                End If
            Next

        End If

        If ProgressBar4.Value <= 50 > 40 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Precise and Quality Pass to his teammate"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(15, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                            z = x + c
                            TextBox3.Text = z
                        End If
                        If k <= 50 > 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores from close range"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                        End If
                    Next
                Else
                    TextBox11.Text = TextBox11.Text + "Lost Possession by passing to the opposition"
                End If
            Next

        End If

        If ProgressBar4.Value <= 60 > 50 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(20, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Precise and Quality Pass to his teammate"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(5, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                            z = x + c
                            TextBox3.Text = z
                        End If
                        If k <= 50 > 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a mid range"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                        End If
                    Next
                Else
                    TextBox11.Text = TextBox11.Text + "Lost Possession by passing to the opposition"
                End If
            Next

            If ProgressBar4.Value <= 70 > 60 Then
                For i As Integer = 0 To randoms.Length - 1
                    randoms(i) = GetRandom(30, 100)
                    If i <= 50 Then
                        TextBox11.Text = TextBox11.Text + "Precise and Quality Pass to his teammate"
                        For k As Integer = 0 To randoms.Length - 1
                            randoms(k) = GetRandom(5, 90)
                            If k <= 70 Then
                                TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                                z = x + c
                                TextBox3.Text = z
                            End If
                            If k <= 50 > 70 Then
                                TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a mid range"
                                z = x + v
                                TextBox3.Text = z
                            Else
                                TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                            End If
                        Next
                    Else
                        TextBox11.Text = TextBox11.Text + "Lost Possession by passing to the opposition"
                    End If
                Next


                If ProgressBar4.Value <= 80 > 70 Then
                    For i As Integer = 0 To randoms.Length - 1
                        randoms(i) = GetRandom(35, 100)
                        If i <= 50 Then
                            TextBox11.Text = TextBox11.Text + "Precise and Quality Pass to his teammate"
                            For k As Integer = 0 To randoms.Length - 1
                                randoms(k) = GetRandom(5, 80)
                                If k <= 70 Then
                                    TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                                    z = x + c
                                    TextBox3.Text = z
                                End If
                                If k <= 50 > 70 Then
                                    TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a mid range"
                                    z = x + v
                                    TextBox3.Text = z
                                Else
                                    TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                                End If
                            Next
                        Else
                            TextBox11.Text = TextBox11.Text + "Lost Possession by passing to the opposition"
                        End If
                    Next

                    If ProgressBar4.Value <= 90 > 80 Then
                        For i As Integer = 0 To randoms.Length - 1
                            randoms(i) = GetRandom(40, 100)
                            If i <= 50 Then
                                TextBox11.Text = TextBox11.Text + "Precise and Quality Pass to his teammate"
                                For k As Integer = 0 To randoms.Length - 1
                                    randoms(k) = GetRandom(5, 70)
                                    If k <= 70 Then
                                        TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                                        z = x + c
                                        TextBox3.Text = z
                                    End If
                                    If k <= 50 > 70 Then
                                        TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a mid range"
                                        z = x + v
                                        TextBox3.Text = z
                                    Else
                                        TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                                    End If
                                Next
                            Else
                                TextBox11.Text = TextBox11.Text + "Lost Possession by passing to the opposition"
                            End If
                        Next

                        If ProgressBar4.Value <= 99 > 90 Then
                            For i As Integer = 0 To randoms.Length - 1
                                randoms(i) = GetRandom(45, 100)
                                If i <= 50 Then
                                    TextBox11.Text = TextBox11.Text + vbNewLine + "Precise and Quality Pass to his teammate"
                                    For k As Integer = 0 To randoms.Length - 1
                                        randoms(k) = GetRandom(5, 60)
                                        If k <= 70 Then
                                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                                            z = x + c
                                            TextBox3.Text = z
                                        End If
                                        If k <= 50 > 70 Then
                                            TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a mid range"
                                            z = x + v
                                            TextBox3.Text = z
                                        Else
                                            TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                                        End If
                                    Next
                                Else
                                    TextBox11.Text = TextBox11.Text + "Lost Possession by passing to the opposition"
                                End If
                            Next

                            If ProgressBar4.Value = 100 Then
                                TextBox11.Text = TextBox11.Text + vbNewLine + "Precise and Quality Pass to his teammate"
                                For k As Integer = 0 To randoms.Length - 1
                                    randoms(k) = GetRandom(5, 55)
                                    If k <= 70 Then
                                        TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a three point from Range"
                                        z = x + c
                                        TextBox3.Text = z
                                    End If
                                    If k <= 50 > 70 Then
                                        TextBox11.Text = TextBox11.Text + "Teammate Receives the ball and scores a mid range"
                                        z = x + v
                                        TextBox3.Text = z
                                    Else
                                        TextBox11.Text = TextBox11.Text + "Teammate Shoots a Poor Shot and Misses"
                                    End If
                                Next
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ButShoot3pt_Click(sender As System.Object, e As System.EventArgs) Handles ButShoot3pt.Click
        Dim randoms(100) As Integer
        Dim z As Double
        Dim x As Integer = TextBox3.Text
        Dim c As Integer = 3
        Dim v As Integer = 2
        Dim totalpoints As Integer = TextBox5.Text



        If ProgressBar2.Value <= 10 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 55)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                    z = x + c
                    TextBox3.Text = z
                    totalpoints += c
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a three And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
                End If




        If ProgressBar2.Value <= 20 > 10 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                    z = x + c
                    TextBox3.Text = z
                    totalpoints += c
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a three And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If



        If ProgressBar2.Value <= 30 > 20 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 70)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                    z = x + c
                    TextBox3.Text = z
                    totalpoints += c
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a three And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If

        Dim y As Integer = -1
        Dim m As Integer = TextBox1.Text
        Dim d As Double
        d = m + y

        TextBox1.Text = d


        If ProgressBar2.Value <= 40 > 30 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(2, 70)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                    z = x + c
                    TextBox3.Text = z
                    totalpoints += c
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a three And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If

        If ProgressBar2.Value <= 50 > 40 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(5, 70)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                    z = x + c
                    TextBox3.Text = z
                    totalpoints += c
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a three And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If

        If ProgressBar2.Value <= 60 > 50 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 70)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                    z = x + c
                    TextBox3.Text = z
                    totalpoints += c
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a three And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next
        End If

        If ProgressBar2.Value <= 70 > 60 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(20, 70)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                    z = x + c
                    TextBox3.Text = z
                    totalpoints += c
                Else
                    TextBox11.Text = TextBox11.Text + "Shoots a three And Misses"
                    For k As Integer = 0 To randoms.Length - 1
                        randoms(k) = GetRandom(55, 100)
                        If k <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                            z = x + v
                            TextBox3.Text = z
                        Else
                            TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                        End If
                    Next
                End If
            Next


            If ProgressBar2.Value <= 80 > 70 Then
                For i As Integer = 0 To randoms.Length - 1
                    randoms(i) = GetRandom(30, 70)
                    If i <= 50 Then
                        TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                        z = x + c
                        TextBox3.Text = z
                        totalpoints += c
                    Else
                        TextBox11.Text = TextBox11.Text + "Shoots a three And Misses"
                        For k As Integer = 0 To randoms.Length - 1
                            randoms(k) = GetRandom(55, 100)
                            If k <= 70 Then
                                TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                                z = x + v
                                TextBox3.Text = z
                            Else
                                TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                            End If
                        Next
                    End If
                Next

                If ProgressBar2.Value <= 90 > 80 Then
      For i As Integer = 0 To randoms.Length - 1
                        randoms(i) = GetRandom(35, 70)
                        If i <= 50 Then
                            TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                            z = x + c
                            TextBox3.Text = z
                            totalpoints += c
                        Else
                            TextBox11.Text = TextBox11.Text + "Shoots a three And Misses"
                            For k As Integer = 0 To randoms.Length - 1
                                randoms(k) = GetRandom(55, 100)
                                If k <= 70 Then
                                    TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                                    z = x + v
                                    TextBox3.Text = z
                                Else
                                    TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                                End If
                            Next
                        End If
                    Next

                    If ProgressBar2.Value <= 99 > 90 Then
           For i As Integer = 0 To randoms.Length - 1
                            randoms(i) = GetRandom(40, 70)
                            If i <= 50 Then
                                TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                                z = x + c
                                TextBox3.Text = z
                                totalpoints += c
                            Else
                                TextBox11.Text = TextBox11.Text + "Shoots a three And Misses"
                                For k As Integer = 0 To randoms.Length - 1
                                    randoms(k) = GetRandom(55, 100)
                                    If k <= 70 Then
                                        TextBox11.Text = TextBox11.Text + "Teammate claims the rebound and get the immediate easy lay-up"
                                        z = x + v
                                        TextBox3.Text = z
                                    Else
                                        TextBox11.Text = TextBox11.Text + "Opposing Team claims the rebound"
                                    End If
                                Next
                            End If
                        Next

                        If ProgressBar2.Value = 100 Then
                            For i As Integer = 0 To randoms.Length - 1
                                randoms(i) = GetRandom(50, 100)
                                If i <= 50 Then
                                    TextBox11.Text = TextBox11.Text + "Splash Like Stephen Curry! Nothing but Net!"
                                    z = x + c
                                    TextBox3.Text = z
                                    totalpoints += c
                                End If

                            Next
                        End If
                End If
            End If
        End If
        End If
    End Sub

    Private Sub ButDribble_Click(sender As System.Object, e As System.EventArgs) Handles ButDribble.Click
        Dim randoms(100) As Integer
        Dim z As Double
        Dim c As Integer = TextBox2.Text
        Dim x As Integer = TextBox3.Text
        Dim v As Integer = 2 


        If ProgressBar3.Value <= 10 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If


        If ProgressBar3.Value <= 20 > 10 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks it in"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If



        If ProgressBar3.Value <= 30 > 20 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If

        Dim y As Integer = -1
        Dim m As Integer = TextBox1.Text
        Dim d As Double
        d = m + y

        TextBox1.Text = d


        If ProgressBar3.Value <= 40 > 30 Then
 For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If

        If ProgressBar3.Value <= 50 > 40 Then
             For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If

        If ProgressBar3.Value <= 60 > 50 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If

        If ProgressBar3.Value <= 70 > 60 Then

 For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If

        If ProgressBar3.Value <= 80 > 70 Then
             For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If

        If ProgressBar3.Value <= 90 > 80 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If

        If ProgressBar3.Value <= 99 > 90 Then
           For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If

        If ProgressBar3.Value = 100 Then
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 60)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What a Crossover! Broke the Opponent's Ankles with skill"
                    z = x + v
                    TextBox3.Text = z
                Else
                    TextBox11.Text = TextBox11.Text + "The ball is Stolen and the Opponent goes in the opposite direction and Dunks"
                    z = x + c
                    TextBox2.Text = z
                End If
            Next
        End If
    End Sub

    Private Sub ProgressBar8_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar8.Click
    End Sub

    Private Sub ButRebound_Click(sender As System.Object, e As System.EventArgs) Handles ButRebound.Click
        Dim randoms(100) As Integer
        Dim z As Double
        Dim x As Integer = TextBox2.Text
        Dim v As Integer = 2



        If ProgressBar6.Value <= 10 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 80)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                Else
                    TextBox11.Text = TextBox11.Text + "The Opposing Team's centre gets the putback Dunk"
                    x += v
                End If
            Next
        End If
        If ProgressBar6.Value <= 20 > 10 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 90)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                Else
                    TextBox11.Text = TextBox11.Text + "The Opposing Team's centre gets the putback Dunk"
                    x += v
                End If
            Next
        End If
        If ProgressBar6.Value <= 30 > 20 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                Else
                    TextBox11.Text = TextBox11.Text + "The Opposing Team's centre gets the putback Dunk"
                    x += v
                End If
            Next
        End If
        If ProgressBar6.Value <= 40 > 30 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(15, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                Else
                    TextBox11.Text = TextBox11.Text + "The Opposing Team's centre gets the putback Dunk"
                    x += v
                End If
            Next
        End If
        If ProgressBar6.Value <= 50 > 40 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(20, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                Else
                    TextBox11.Text = TextBox11.Text + "The Opposing Team's centre gets the putback Dunk"
                    x += v
                End If
            Next
        End If
        If ProgressBar6.Value <= 60 > 50 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(25, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                Else
                    TextBox11.Text = TextBox11.Text + "The Opposing Team's centre gets the putback Dunk"
                    x += v
                End If
            Next
        End If
        If ProgressBar6.Value <= 70 > 60 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(30, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                Else
                    TextBox11.Text = TextBox11.Text + "The Opposing Team's centre gets the putback Dunk"
                    x += v
                End If
            Next
        End If
        If ProgressBar6.Value <= 80 > 70 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(35, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                Else
                    TextBox11.Text = TextBox11.Text + "The Opposing Team's centre gets the putback Dunk"
                    x += v
                End If
            Next
        End If
        If ProgressBar6.Value <= 90 > 80 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(40, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                Else
                    TextBox11.Text = TextBox11.Text + "The Opposing Team's centre gets the putback Dunk"
                    x += v
                End If
            Next
        End If
        If ProgressBar6.Value <= 99 > 90 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(45, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                Else
                    TextBox11.Text = TextBox11.Text + "The Opposing Team's centre gets the putback Dunk"
                    x += v
                End If
            Next
        End If
        If ProgressBar6.Value = 100 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(50, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name rises to claim the rebound"
                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim randoms(100) As Integer
        Dim z As Double
        Dim c As Integer = TextBox2.Text
        Dim x As Integer = TextBox3.Text
        Dim v As Integer = 2

        If ProgressBar7.Value <= 10 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 80)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name steals the ball with skill" + vbNewLine + "Goes Coast to Coast to get the Lay Up"
                    x += v
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If ProgressBar7.Value <= 20 > 10 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 90)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name steals the ball with skill" + vbNewLine + "Goes Coast to Coast to get the Lay Up"
                    x += v
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If ProgressBar7.Value <= 30 > 20 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name steals the ball with skill" + vbNewLine + "Goes Coast to Coast to get the Lay Up"
                    x += v
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If ProgressBar7.Value <= 40 > 30 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(15, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name steals the ball with skill" + vbNewLine + "Goes Coast to Coast to get the Lay Up"
                    x += v
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If ProgressBar7.Value <= 50 > 40 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(15, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name steals the ball with skill" + vbNewLine + "Goes Coast to Coast to get the Lay Up"
                    x += v
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If ProgressBar7.Value <= 60 > 50 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(20, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name steals the ball with skill" + vbNewLine + "Goes Coast to Coast to get the Lay Up"
                    x += v
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If ProgressBar7.Value <= 70 > 60 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(25, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name steals the ball with skill" + vbNewLine + "Goes Coast to Coast to get the Lay Up"
                    x += v
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If ProgressBar7.Value <= 80 > 70 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(30, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name steals the ball with skill" + vbNewLine + "Goes Coast to Coast to get the Lay Up"
                    x += v
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If ProgressBar7.Value <= 90 > 80 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(35, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name steals the ball with skill" + vbNewLine + "Goes Coast to Coast to get the Lay Up"
                    x += v
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If ProgressBar7.Value <= 99 > 90 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(45, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "Player Name steals the ball with skill" + vbNewLine + "Goes Coast to Coast to get the Lay Up"
                    x += v
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If ProgressBar7.Value = 100 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(60, 100)
                If i <= 50 Then
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy reached in and fouled the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim randoms(100) As Integer
        Dim z As Double
        Dim c As Integer = TextBox2.Text
        Dim x As Integer = TextBox3.Text
        Dim v As Integer = 2
        Dim TotBlocks As Integer = TextBox6.Text
        Dim a As Integer = 1


        If Skills.ProgressBar21.Value <= 10 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 80)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy fouls the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If Skills.ProgressBar21.Value <= 20 > 10 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 90)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy fouls the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If Skills.ProgressBar21.Value <= 30 > 20 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(10, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy fouls the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If Skills.ProgressBar21.Value <= 40 > 30 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(15, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy fouls the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If Skills.ProgressBar21.Value <= 50 > 40 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(20, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy fouls the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If Skills.ProgressBar21.Value <= 60 > 50 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(25, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy fouls the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If Skills.ProgressBar21.Value <= 70 > 60 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(30, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a

                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy fouls the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If Skills.ProgressBar21.Value <= 80 > 70 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(35, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy fouls the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If Skills.ProgressBar21.Value <= 90 > 80 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(40, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy fouls the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If Skills.ProgressBar21.Value <= 99 > 90 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(45, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a
                Else
                    For foul As Integer = 0 To randoms.Length - 1
                        randoms(foul) = GetRandom(55, 100)
                        If foul <= 70 Then
                            TextBox11.Text = TextBox11.Text + "Player Name carelessy fouls the opponent" + vbNewLine + "The Opposing Player Gets both free throws"
                            c += v
                        Else
                            TextBox11.Text = TextBox11.Text + "The opposing player gets by Player Name and gets an easy basket"
                            c += v
                        End If
                    Next
                End If
            Next
        End If
        If Skills.ProgressBar21.Value = 100 Then

            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(50, 100)
                If i <= 50 Then
                    TextBox11.Text = TextBox11.Text + "What A Block by Player Name! Crowd Goes Wild"
                    x += v
                    TotBlocks += a
                End If
            Next

        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub ButPlayPause_Click(sender As System.Object, e As System.EventArgs) Handles ButPlayPause.Click
        'Dim gametext() As String = {string1, string2, string3, string4, string5, string6, string7}
        Dim randoms(10) As Integer
        'Dim i As Integer = 0 To randoms.Length - 1
    End Sub
End Class