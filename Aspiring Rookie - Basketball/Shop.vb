Imports System.IO
Imports Aspiring_Rookie___Basketball.Domain

Public Class Shop
    Private shopItems As List(Of ShopItem)
 
    Private Sub Shop_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        shopItems = GameController.GetAllShopItems()
        shopItems.ForEach(Function(item) {CheckedListBox1.Items.Add(item.Name)})
        TxtBankShop.Text = GameController.GameObjects.Player.BankBalance
    End Sub
    
    Private Sub ProcessItem(item As String)
        Dim fullItem = shopItems.First(Function(shopItem) shopItem.Name = item)

        'Process price
        Dim bankBalance As Decimal = TxtBankShop.Text
        bankBalance -= fullItem.Price
        TxtBankShop.Text = bankBalance

        'Process lifestyle progress bar
        ProgressBar1.Value += fullItem.LifeStyleValue
    End Sub

    Private Sub ButBuy_Click(sender As System.Object, e As System.EventArgs) Handles ButBuy.Click
        If CheckedListBox1.CheckedItems.Count = 0 Then
            MessageBox.Show("Please select a product that you want to buy", "Buy A Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If
        
        For Each checkedItem In CheckedListBox1.CheckedItems
            ProcessItem(checkedItem)
        Next
   
        Dim document As XDocument
        If File.Exists("DataBankSkills.xml") Then
            document = XDocument.Load("DataBankSkills.xml")
        Else
            MessageBox.Show("No such file Exists'")
        End If

        Dim root = New XElement("Data")
        Dim banknum = New XElement("BankNumber", TxtBankShop.Text)
        Dim ShoppingList = New XElement("ShoppingList", CheckedListBox1.Text)
        Dim lifebar = New XElement("Lifestyle", ProgressBar1.Value)
        
        root.Add(banknum, ShoppingList, lifebar)
        document.Root.ReplaceWith(root)

        If File.Exists("DataBankSkills.xml") Then
            document = XDocument.Load("DataBankSkills.xml")
            root.Add(banknum, ShoppingList, lifebar)
            document.Root.ReplaceWith(root)
            'document.Save("databankskills.xml")
        End If

    End Sub

    Private Sub ButItems_Click(sender As System.Object, e As System.EventArgs) Handles ButItems.Click
        ItemsOwned.Show()
    End Sub
End Class