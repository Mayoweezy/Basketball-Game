Imports System.Data.OleDb
Public Class LeagueTable
    
    Private Sub LeagueTable_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GameController.GetCurrentLeagueTable()
    End Sub
    
    Private Sub LeagueTableTrialBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.LeagueTableTrialBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeagueDataSet)

    End Sub

    Private Sub LeagueTableTrialDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub LeagueTableTrialBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs)

    End Sub
End Class