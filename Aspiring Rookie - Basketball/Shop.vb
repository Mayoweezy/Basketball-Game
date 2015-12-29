Imports System.IO
Imports Aspiring_Rookie___Basketball.Domain

Public Class Shop
    Private shopItems As List(Of ShopItem)
 
    Private Sub Shop_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        shopItems = GameController.GetAllShopItems()
        shopItems.ForEach(Function(item) {CheckedListBox1.Items.Add(item.Name)})
        TxtBankShop.Text = GameController.GameObjects.Player.BankBalance
        ProgressBar1.Value = GameController.GameObjects.Player.QualityOfLife
    End Sub
    
    Private Sub ProcessItem(item As String)
        Dim fullItem = shopItems.First(Function(shopItem) shopItem.Name = item)

        'Process price
        GameController.GameObjects.Player.BankBalance -= fullItem.Price
        TxtBankShop.Text = GameController.GameObjects.Player.BankBalance

        'Process lifestyle progress bar
        GameController.GameObjects.Player.QualityOfLife += fullItem.LifeStyleValue
    End Sub

    Private Sub ButBuy_Click(sender As System.Object, e As System.EventArgs) Handles ButBuy.Click
        If CheckedListBox1.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select a product that you want to buy", "Buy A Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If
        
        For Each checkedItem In CheckedListBox1.CheckedItems
            ProcessItem(checkedItem)
        Next

        TxtBankShop.Text = GameController.GameObjects.Player.BankBalance
        ProgressBar1.Value = GameController.GameObjects.Player.QualityOfLife
    End Sub

    Private Sub ButItems_Click(sender As System.Object, e As System.EventArgs) Handles ButItems.Click
        ItemsOwned.Show()
    End Sub
End Class