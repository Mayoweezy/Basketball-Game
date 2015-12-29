Imports System.IO
Imports Aspiring_Rookie___Basketball.Domain

Public Class Skills

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Const MinValue = 0
    Private Const MaxValue = 10

    Private Sub Skills_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim playerSkill = GameController.GameObjects.Player.Skill
        TxtCredits.Text = GameController.GameObjects.Player.SkillsCredit
        ProgressBar1.Value = playerSkill.LayUp
        ProgressBar2.Value = playerSkill.Dunk
        ProgressBar3.Value = playerSkill.Mids
        ProgressBar4.Value = playerSkill.ShotRelease
        ProgressBar5.Value = playerSkill.InsideScoringAccuracy
        ProgressBar6.Value = playerSkill.OutsideScoringAccuracy
        ProgressBar7.Value = playerSkill.Passing
        ProgressBar8.Value = playerSkill.Vision
        ProgressBar9.Value = playerSkill.PassingAccuracy
        ProgressBar11.Value = playerSkill.Pace
        ProgressBar12.Value = playerSkill.Acceleration
        ProgressBar13.Value = playerSkill.Strength
        ProgressBar14.Value = playerSkill.JumpingReach
        ProgressBar15.Value = playerSkill.JumpingAbility
        ProgressBar16.Value = playerSkill.Handling
        ProgressBar17.Value = playerSkill.Anticipation
        ProgressBar18.Value = playerSkill.Reactions
        ProgressBar19.Value = playerSkill.Defence
        ProgressBar20.Value = playerSkill.WorkRate
        ProgressBar21.Value = playerSkill.Blocking

        ValidateTaxCredit()

        'For Each pair In AllIncrementButtons()
        '    ValidateUpperBoundSkillLevel(pair.Value.Value, pair.Key)
        'Next

        'For Each pair In AllDecrementButtons()
        '    ValidateUpperBoundSkillLevel(pair.Item2.Value, pair.Item1)
        'Next

    End Sub

    Private Function AllIncrementButtons() As Dictionary(Of Button, ProgressBar)

    End Function

    Private Function AllDecrementButtons() As List(Of Tuple(Of Button, ProgressBar))

    End Function

    Private Sub OutsideScoringToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub ValidateTaxCredit()
        If GameController.GameObjects.Player.SkillsCredit = 0 Then
            'Disable all positive buttons

        End If
    End Sub

    Private Sub IncrementSkill(progressBar As ProgressBar, action As Action, incrementButton As Button, decrementButton As Button)
        If progressBar.Value >= MaxValue Then
            incrementButton.Enabled = False
            Return
        End If

        progressBar.Value += 1
        action()
        GameController.GameObjects.Player.SkillsCredit -= 1
        TxtCredits.Text = GameController.GameObjects.Player.SkillsCredit

        decrementButton.Enabled = progressBar.Value > MinValue
        ValidateTaxCredit()
    End Sub

    Private Sub DecrementSkill(progressBar As ProgressBar, action As Action, incrementButton As Button, decrementButton As Button)
        If progressBar.Value <= MinValue Then
            decrementButton.Enabled = False
            Return
        End If

        progressBar.Value -= 1
        action()
        GameController.GameObjects.Player.SkillsCredit += 1
        TxtCredits.Text = GameController.GameObjects.Player.SkillsCredit

        incrementButton.Enabled = progressBar.Value < MaxValue
        ValidateTaxCredit()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractMids.Click
        Dim action = Sub() GameController.GameObjects.Player.Skill.Mids -= 1
        DecrementSkill(ProgressBar3, action, ButAddMids, ButSubtractMids)
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles ButAddJumpReach.Click
        Dim action = Sub() GameController.GameObjects.Player.Skill.JumpingReach += 1
        IncrementSkill(ProgressBar14, action, ButAddLayUp, ButSubtractLayUp)
    End Sub
    
    Private Sub ButAddLayUp_Click(sender As System.Object, e As System.EventArgs) Handles ButAddLayUp.Click
        Dim x As Integer = ProgressBar1.Value
        Dim a As Integer = ProgressBar1.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double

        x += 1
        ProgressBar1.Value = x

        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddLayUp.Enabled = False

        End If
        If x = 100 Then
            ButAddLayUp.Enabled = False
        End If
    End Sub

    Private Sub ButAddDunk_Click(sender As System.Object, e As System.EventArgs) Handles ButAddDunk.Click
        Dim x As Integer = ProgressBar2.Value
        Dim a As Integer = ProgressBar2.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double

        x += 1
        ProgressBar2.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddDunk.Enabled = False
        End If
        If x = 100 Then
            ButAddDunk.Enabled = False
        End If
    End Sub

    Private Sub ButAddMids_Click(sender As System.Object, e As System.EventArgs) Handles ButAddMids.Click
        Dim action = Sub() GameController.GameObjects.Player.Skill.Mids += 1
        IncrementSkill(ProgressBar3, action, ButAddMids, ButSubtractMids)
    End Sub

    Private Sub ButAddShotRelease_Click(sender As System.Object, e As System.EventArgs) Handles ButAddShotRelease.Click
        Dim x As Integer = ProgressBar4.Value
        Dim a As Integer = ProgressBar4.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar4.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddShotRelease.Enabled = False
        End If
        If x = 100 Then
            ButAddShotRelease.Enabled = False
        End If
    End Sub

    Private Sub ButAddInScoreAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButAddInScoreAcc.Click
        Dim x As Integer = ProgressBar5.Value
        Dim a As Integer = ProgressBar5.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar5.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddInScoreAcc.Enabled = False
        End If
        If x = 100 Then
            ButAddInScoreAcc.Enabled = False
        End If
    End Sub

    Private Sub ButAdd3ptAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButAdd3ptAcc.Click
        Dim x As Integer = ProgressBar6.Value
        Dim a As Integer = ProgressBar6.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar6.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAdd3ptAcc.Enabled = False
        End If
        If x = 100 Then
            ButAdd3ptAcc.Enabled = False
        End If
    End Sub

    Private Sub ButAddPass_Click(sender As System.Object, e As System.EventArgs) Handles ButAddPass.Click
        Dim x As Integer = ProgressBar7.Value
        Dim a As Integer = ProgressBar7.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar7.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddPass.Enabled = False
        End If
        If x = 100 Then
            ButAddPass.Enabled = False
        End If
    End Sub

    Private Sub ButAddVision_Click(sender As System.Object, e As System.EventArgs) Handles ButAddVision.Click
        Dim x As Integer = ProgressBar8.Value
        Dim a As Integer = ProgressBar8.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar8.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddVision.Enabled = False
        End If
        If x = 100 Then
            ButAddVision.Enabled = False
        End If
    End Sub

    Private Sub ButAddPassAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButAddPassAcc.Click
        Dim x As Integer = ProgressBar9.Value
        Dim a As Integer = ProgressBar9.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar9.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddPassAcc.Enabled = False
        End If
        If x = 100 Then
            ButAddPassAcc.Enabled = False
        End If
    End Sub

    Private Sub ButAddPace_Click(sender As System.Object, e As System.EventArgs) Handles ButAddPace.Click
        Dim x As Integer = ProgressBar11.Value
        Dim a As Integer = ProgressBar11.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar11.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddPace.Enabled = False
        End If
        If x = 100 Then
            ButAddPace.Enabled = False
        End If
    End Sub

    Private Sub ButAddAccelerate_Click(sender As System.Object, e As System.EventArgs) Handles ButAddAccelerate.Click
        Dim x As Integer = ProgressBar12.Value
        Dim a As Integer = ProgressBar12.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar12.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddAccelerate.Enabled = False
        End If
        If x = 100 Then
            ButAddAccelerate.Enabled = False
        End If
    End Sub

    Private Sub ButAddStrength_Click(sender As System.Object, e As System.EventArgs) Handles ButAddStrength.Click
        Dim x As Integer = ProgressBar13.Value
        Dim a As Integer = ProgressBar13.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar13.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddStrength.Enabled = False
        End If
        If x = 100 Then
            ButAddStrength.Enabled = False
        End If
    End Sub

    Private Sub ButAddJumpAbility_Click(sender As System.Object, e As System.EventArgs) Handles ButAddJumpAbility.Click
        Dim x As Integer = ProgressBar15.Value
        Dim a As Integer = ProgressBar15.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar15.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddJumpAbility.Enabled = False
        End If
        If x = 100 Then
            ButAddJumpAbility.Enabled = False
        End If
    End Sub

    Private Sub ButAddHands_Click(sender As System.Object, e As System.EventArgs) Handles ButAddHands.Click
        Dim x As Integer = ProgressBar16.Value
        Dim a As Integer = ProgressBar16.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar16.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddHands.Enabled = False
        End If
        If x = 100 Then
            ButAddHands.Enabled = False
        End If
    End Sub

    Private Sub ButAddAnticiptate_Click(sender As System.Object, e As System.EventArgs) Handles ButAddAnticiptate.Click
        Dim x As Integer = ProgressBar17.Value
        Dim a As Integer = ProgressBar17.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar17.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddAnticiptate.Enabled = False
        End If
        If x = 100 Then
            ButAddAnticiptate.Enabled = False
        End If
    End Sub

    Private Sub ButAddReact_Click(sender As System.Object, e As System.EventArgs) Handles ButAddReact.Click
        Dim x As Integer = ProgressBar18.Value
        Dim a As Integer = ProgressBar18.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar18.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddReact.Enabled = False
        End If
        If x = 100 Then
            ButAddReact.Enabled = False
        End If
    End Sub

    Private Sub ButAddDef_Click(sender As System.Object, e As System.EventArgs) Handles ButAddDef.Click
        Dim x As Integer = ProgressBar19.Value
        Dim a As Integer = ProgressBar19.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar19.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddDef.Enabled = False
        End If
        If x = 100 Then
            ButAddDef.Enabled = False
        End If
    End Sub

    Private Sub ButAddWork_Click(sender As System.Object, e As System.EventArgs) Handles ButAddWork.Click
        Dim x As Integer = ProgressBar20.Value
        Dim a As Integer = ProgressBar20.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar20.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddWork.Enabled = False
        End If
        If x = 100 Then
            ButAddWork.Enabled = False
        End If
    End Sub

    Private Sub ButAddBlock_Click(sender As System.Object, e As System.EventArgs) Handles ButAddBlock.Click
        Dim x As Integer = ProgressBar21.Value
        Dim a As Integer = ProgressBar21.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += 1
        ProgressBar21.Value = x
        a += -1
        c = b - 1

        TxtCredits.Text = c

        If c = 0 Then
            ButAddLayUp.Enabled = False
        End If

        If x = 100 Then
            ButAddBlock.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractLayUp_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractLayUp.Click
        Dim x As Integer = ProgressBar1.Value
        Dim a As Integer = ProgressBar1.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar1.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractLayUp.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractDunk_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractDunk.Click
        Dim x As Integer = ProgressBar2.Value
        Dim a As Integer = ProgressBar2.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar2.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractDunk.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractShotRelease_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractShotRelease.Click
        Dim x As Integer = ProgressBar4.Value
        Dim a As Integer = ProgressBar4.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar4.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractShotRelease.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractInShotAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractInShotAcc.Click
        Dim x As Integer = ProgressBar5.Value
        Dim a As Integer = ProgressBar5.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar5.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractInShotAcc.Enabled = False
        End If
    End Sub

    Private Sub ButSubtract3ptAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtract3ptAcc.Click
        Dim x As Integer = ProgressBar6.Value
        Dim a As Integer = ProgressBar6.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar6.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtract3ptAcc.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractPassing_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractPassing.Click
        Dim x As Integer = ProgressBar7.Value
        Dim a As Integer = ProgressBar7.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar7.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractPassing.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractVision_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractVision.Click
        Dim x As Integer = ProgressBar8.Value
        Dim a As Integer = ProgressBar8.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar8.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractVision.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractPassAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractPassAcc.Click
        Dim x As Integer = ProgressBar9.Value
        Dim a As Integer = ProgressBar9.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar9.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractPassAcc.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractPace_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractPace.Click
        Dim x As Integer = ProgressBar11.Value
        Dim a As Integer = ProgressBar11.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar11.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractPace.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractAccelerate_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractAccelerate.Click
        Dim x As Integer = ProgressBar12.Value
        Dim a As Integer = ProgressBar12.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar12.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractAccelerate.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractStrength_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractStrength.Click
        Dim x As Integer = ProgressBar13.Value
        Dim a As Integer = ProgressBar13.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar13.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c


        If x = 0 Then
            ButSubtractStrength.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractJumpReach_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractJumpReach.Click
        Dim x As Integer = ProgressBar14.Value
        Dim a As Integer = ProgressBar14.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar14.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c


        If x = 0 Then
            ButSubtractJumpReach.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractJumpAbil_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractJumpAbil.Click
        Dim x As Integer = ProgressBar15.Value
        Dim a As Integer = ProgressBar15.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar15.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractJumpAbil.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractHands_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractHands.Click
        Dim x As Integer = ProgressBar16.Value
        Dim a As Integer = ProgressBar16.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar16.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractHands.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractAnticiptate_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractAnticiptate.Click
        Dim x As Integer = ProgressBar17.Value
        Dim a As Integer = ProgressBar17.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar17.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractAnticiptate.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractReact_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractReact.Click
        Dim x As Integer = ProgressBar18.Value
        Dim a As Integer = ProgressBar18.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar18.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractReact.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractDefence_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractDefence.Click
        Dim x As Integer = ProgressBar19.Value
        Dim a As Integer = ProgressBar19.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar19.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractDefence.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractWork_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractWork.Click
        Dim x As Integer = ProgressBar20.Value
        Dim a As Integer = ProgressBar20.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar20.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractWork.Enabled = False
        End If
    End Sub

    Private Sub ButSubtractBlock_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractBlock.Click
        Dim x As Integer = ProgressBar21.Value
        Dim a As Integer = ProgressBar21.Value
        Dim b As Integer = Val(TxtCredits.Text)
        Dim c As Double
        x += -1
        ProgressBar21.Value = x
        a += 1
        c = b + 1

        TxtCredits.Text = c

        If x = 0 Then
            ButSubtractBlock.Enabled = False
        End If
    End Sub

    Private Sub butSave_Click(sender As System.Object, e As System.EventArgs)

        'For a As Integer = 1 To 21
        '    CType(Me.Controls("ProgressBar" & a), ProgressBar).Value
        'Next



        Dim document As XDocument
        If File.Exists("DataBankSkillsSet.xml") Then
            document = XDocument.Load("DataBankSkillsSet.xml")
        Else
            MessageBox.Show("No such file Exists'")
        End If

        'Dim root = New XElement("Data")
        'Dim progressbarval1 = New XElement("ProgressBar", ProgressBar1.Value)
        'Dim progressbarval2 = New XElement("ProgressBar", ProgressBar2.Value)
        'Dim progressbarval3 = New XElement("ProgressBar", ProgressBar3.Value)
        'Dim progressbarval4 = New XElement("ProgressBar", ProgressBar4.Value)
        'Dim progressbarval5 = New XElement("ProgressBar", ProgressBar5.Value)
        'Dim progressbarval6 = New XElement("ProgressBar", ProgressBar6.Value)
        'Dim progressbarval7 = New XElement("ProgressBar", ProgressBar7.Value)
        'Dim progressbarval8 = New XElement("ProgressBar", ProgressBar8.Value)
        'Dim progressbarval9 = New XElement("ProgressBar", ProgressBar9.Value)
        'Dim progressbarval10 = New XElement("ProgressBar", ProgressBar11.Value)
        'Dim progressbarval11 = New XElement("ProgressBar", ProgressBar12.Value)
        'Dim progressbarval12 = New XElement("ProgressBar", ProgressBar13.Value)
        'Dim progressbarval13 = New XElement("ProgressBar", ProgressBar14.Value)
        'Dim progressbarval14 = New XElement("ProgressBar", ProgressBar15.Value)
        'Dim progressbarval15 = New XElement("ProgressBar", ProgressBar16.Value)
        'Dim progressbarval16 = New XElement("ProgressBar", ProgressBar17.Value)
        'Dim progressbarval17 = New XElement("ProgressBar", ProgressBar18.Value)
        'Dim progressbarval18 = New XElement("ProgressBar", ProgressBar19.Value)
        'Dim progressbarval19 = New XElement("ProgressBar", ProgressBar20.Value)
        'Dim progressbarval20 = New XElement("ProgressBar", ProgressBar21.Value)


    End Sub

    Private Sub ProgressBar9_Click(sender As Object, e As EventArgs) Handles ProgressBar9.Click

    End Sub
End Class