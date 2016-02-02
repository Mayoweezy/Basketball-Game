Imports System.IO
Imports Aspiring_Rookie___Basketball.Domain

Public Class Skills
    Private Const MinValue = 0
    Private Const MaxValue = 10
    Dim playerSkill As Domain.Skills
    Dim skillCredit As Integer
    Dim player As Domain.Player

    Private Sub Skills_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        player = GameController.GameObjects.Player
        playerSkill = GameController.GameObjects.Player.Skill
        SetUI()
    End Sub

    'Note should be called before individual validation
    Private Sub SetUI()
        skillCredit = player.SkillsCredit
        TxtCredits.Text = skillCredit
        SetProgressBarAndValidateButtonPair(ButAddLayUp, ButSubtractLayUp, ProgressBar1, playerSkill.LayUp)
        SetProgressBarAndValidateButtonPair(ButAddDunk, ButSubtractDunk, ProgressBar2, playerSkill.Dunk)
        SetProgressBarAndValidateButtonPair(ButAddMids, ButSubtractMids, ProgressBar3, playerSkill.Mids)
        SetProgressBarAndValidateButtonPair(ButAddShotRelease, ButSubtractShotRelease, ProgressBar4, playerSkill.ShotRelease)
        SetProgressBarAndValidateButtonPair(ButAddInScoreAcc, ButSubtractInShotAcc, ProgressBar5, playerSkill.InsideScoringAccuracy)
        SetProgressBarAndValidateButtonPair(ButAdd3ptAcc, ButSubtract3ptAcc, ProgressBar6, playerSkill.OutsideScoringAccuracy)
        SetProgressBarAndValidateButtonPair(ButAddPass, ButSubtractPassing, ProgressBar7, playerSkill.Passing)
        SetProgressBarAndValidateButtonPair(ButAddVision, ButSubtractVision, ProgressBar8, playerSkill.Vision)
        SetProgressBarAndValidateButtonPair(ButAddPassAcc, ButSubtractPassAcc, ProgressBar9, playerSkill.PassingAccuracy)
        SetProgressBarAndValidateButtonPair(ButAddPace, ButSubtractPace, ProgressBar11, playerSkill.Pace)
        SetProgressBarAndValidateButtonPair(ButAddAccelerate, ButSubtractAccelerate, ProgressBar12, playerSkill.Acceleration)
        SetProgressBarAndValidateButtonPair(ButAddStrength, ButSubtractStrength, ProgressBar13, playerSkill.Strength)
        SetProgressBarAndValidateButtonPair(ButAddJumpReach, ButSubtractJumpReach, ProgressBar14, playerSkill.JumpingReach)
        SetProgressBarAndValidateButtonPair(ButAddJumpAbility, ButSubtractJumpAbil, ProgressBar15, playerSkill.JumpingAbility)
        SetProgressBarAndValidateButtonPair(ButAddHands, ButSubtractHands, ProgressBar16, playerSkill.Handling)
        SetProgressBarAndValidateButtonPair(ButAddAnticiptate, ButSubtractAnticiptate, ProgressBar17, playerSkill.Anticipation)
        SetProgressBarAndValidateButtonPair(ButAddReact, ButSubtractReact, ProgressBar18, playerSkill.Reactions)
        SetProgressBarAndValidateButtonPair(ButAddDef, ButSubtractDefence, ProgressBar19, playerSkill.Defence)
        SetProgressBarAndValidateButtonPair(ButAddWork, ButSubtractWork, ProgressBar20, playerSkill.WorkRate)
        SetProgressBarAndValidateButtonPair(ButAddBlock, ButSubtractBlock, ProgressBar21, playerSkill.Blocking)
    End Sub

    Private Sub SetProgressBarAndValidateButtonPair(addButton As Button, subtractButton As Button, progressBar As ProgressBar, skillValue As Integer)
        progressBar.Value = skillValue
        ValidateButtonPair(addButton, subtractButton, skillValue)
    End Sub

    Private Sub ValidateButtonPair(addButton As Button, subtractButton As Button, skillValue As Integer)
        If skillValue >= MaxValue Or skillCredit <= 0 Then
            addButton.Enabled = False
        Else
            addButton.Enabled = True
        End If

        If skillValue <= MinValue Then
            subtractButton.Enabled = False
        Else
            subtractButton.Enabled = True
        End If
    End Sub

    Private Sub ButAddMids_Click(sender As System.Object, e As System.EventArgs) Handles ButAddMids.Click
        playerSkill.Mids += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractMids.Click
        playerSkill.Mids -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddLayUp_Click(sender As System.Object, e As System.EventArgs) Handles ButAddLayUp.Click
        playerSkill.LayUp += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractLayUp_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractLayUp.Click
        playerSkill.LayUp -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddDunk_Click(sender As System.Object, e As System.EventArgs) Handles ButAddDunk.Click
        playerSkill.Dunk += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractDunk_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractDunk.Click
        playerSkill.Dunk -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddShotRelease_Click(sender As System.Object, e As System.EventArgs) Handles ButAddShotRelease.Click
        playerSkill.ShotRelease += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractShotRelease_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractShotRelease.Click
        playerSkill.ShotRelease -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddInScoreAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButAddInScoreAcc.Click
        playerSkill.InsideScoringAccuracy += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractInShotAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractInShotAcc.Click
        playerSkill.InsideScoringAccuracy -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAdd3ptAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButAdd3ptAcc.Click
        playerSkill.OutsideScoringAccuracy += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtract3ptAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtract3ptAcc.Click
        playerSkill.OutsideScoringAccuracy -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddPass_Click(sender As System.Object, e As System.EventArgs) Handles ButAddPass.Click
        playerSkill.Passing += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractPassing_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractPassing.Click
        playerSkill.Passing -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddVision_Click(sender As System.Object, e As System.EventArgs) Handles ButAddVision.Click
        playerSkill.Vision += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractVision_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractVision.Click
        playerSkill.Vision -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddPassAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButAddPassAcc.Click
        playerSkill.PassingAccuracy += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractPassAcc_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractPassAcc.Click
        playerSkill.PassingAccuracy -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddPace_Click(sender As System.Object, e As System.EventArgs) Handles ButAddPace.Click
        playerSkill.Pace += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractPace_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractPace.Click
        playerSkill.Pace -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddAccelerate_Click(sender As System.Object, e As System.EventArgs) Handles ButAddAccelerate.Click
        playerSkill.Acceleration += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractAccelerate_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractAccelerate.Click
        playerSkill.Acceleration -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddStrength_Click(sender As System.Object, e As System.EventArgs) Handles ButAddStrength.Click
        playerSkill.Strength += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractStrength_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractStrength.Click
        playerSkill.Strength -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles ButAddJumpReach.Click
        playerSkill.JumpingReach += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractJumpReach_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractJumpReach.Click
        playerSkill.JumpingReach -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddJumpAbility_Click(sender As System.Object, e As System.EventArgs) Handles ButAddJumpAbility.Click
        playerSkill.JumpingAbility += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractJumpAbil_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractJumpAbil.Click
        playerSkill.JumpingAbility -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddHands_Click(sender As System.Object, e As System.EventArgs) Handles ButAddHands.Click
        playerSkill.Handling += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractHands_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractHands.Click
        playerSkill.Handling -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddAnticiptate_Click(sender As System.Object, e As System.EventArgs) Handles ButAddAnticiptate.Click
        playerSkill.Anticipation += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractAnticiptate_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractAnticiptate.Click
        playerSkill.Anticipation -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddReact_Click(sender As System.Object, e As System.EventArgs) Handles ButAddReact.Click
        playerSkill.Reactions += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractReact_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractReact.Click
        playerSkill.Reactions -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddDef_Click(sender As System.Object, e As System.EventArgs) Handles ButAddDef.Click
        playerSkill.Defence += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractDefence_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractDefence.Click
        playerSkill.Defence -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddWork_Click(sender As System.Object, e As System.EventArgs) Handles ButAddWork.Click
        playerSkill.WorkRate += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractWork_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractWork.Click
        playerSkill.WorkRate -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub

    Private Sub ButAddBlock_Click(sender As System.Object, e As System.EventArgs) Handles ButAddBlock.Click
        playerSkill.Blocking += 1
        player.SkillsCredit -= 1
        SetUI()
    End Sub

    Private Sub ButSubtractBlock_Click(sender As System.Object, e As System.EventArgs) Handles ButSubtractBlock.Click
        playerSkill.Blocking -= 1
        player.SkillsCredit += 1
        SetUI()
    End Sub
End Class