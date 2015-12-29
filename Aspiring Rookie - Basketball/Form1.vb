Imports System.IO
Imports Aspiring_Rookie___Basketball.Domain
Imports Newtonsoft.Json

Public Class Form1

    Private Sub ButAwards_Click(sender As System.Object, e As System.EventArgs) Handles ButAwards.Click

    End Sub

    Private Sub ButLeague_Click(sender As System.Object, e As System.EventArgs) Handles ButLeague.Click
        LeagueTable.Show()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetCurrentFixturesAsDataTable()
        TxtBank.Text = GameController.GameObjects.Player.BankBalance
        TxtAge.Text = Date.Now.Year - GameController.GameObjects.Player.DateOfBirth.Year
        TxtEnergy.Text = GameController.GameObjects.Player.EnergyLevel
        txtTrade.Text = If(GameController.GameObjects.Player.HasAskedForATrade, "Yes", "No")
        TxtPlayerName.Text = GameController.GameObjects.Player.FirstName + " " + GameController.GameObjects.Player.LastName
    End Sub

    Private Sub ButSkills_Click(sender As System.Object, e As System.EventArgs) Handles ButSkills.Click
        Skills.Show()
    End Sub

    Private Sub ButShop_Click(sender As System.Object, e As System.EventArgs) Handles ButShop.Click
        Shop.Show()
    End Sub

    Private Sub ButSave_Click(sender As System.Object, e As System.EventArgs) Handles ButSave.Click
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*"
        
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sw = New StreamWriter(saveFileDialog1.OpenFile())
            If (sw IsNot Nothing) Then
                Dim data As String = JsonConvert.SerializeObject(GameController.GameObjects)
                sw.WriteLine(data)
                sw.Close()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ButPlayMatch_Click(sender As System.Object, e As System.EventArgs) Handles ButPlayMatch.Click
        Game_Box.Show()
    End Sub

    Private Sub ButLoad_Click(sender As System.Object, e As System.EventArgs) Handles ButLoad.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*"

        Dim data = ""
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sr = New StreamReader(openFileDialog1.OpenFile())
            If (sr IsNot Nothing) Then
                data = sr.ReadToEnd
                sr.Close()
            End If

            Dim result = JsonConvert.DeserializeObject(Of GameObjects)(data)
            GameController.GameObjects = result
        End If
    End Sub

    Private Sub ButStats_Click(sender As System.Object, e As System.EventArgs) Handles ButStats.Click
        Stats.Show()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class
