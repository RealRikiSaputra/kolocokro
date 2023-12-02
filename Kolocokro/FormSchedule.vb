Public Class FormSchedule

    Private Sub btnScheduleBack_Click(sender As Object, e As EventArgs) Handles btnScheduleBack.Click
        Dim form1 As FormMenu = DirectCast(Application.OpenForms("FormMenu"), FormMenu)
        form1.Show()
        Close()
    End Sub
    Private Sub btnScheduleAdd_Click(sender As Object, e As EventArgs) Handles btnScheduleAdd.Click

    End Sub

    Private Sub btnScheduleEdit_Click(sender As Object, e As EventArgs) Handles btnScheduleEdit.Click

    End Sub

    Private Sub btnScheduleReschedule_Click(sender As Object, e As EventArgs) Handles btnScheduleReschedule.Click

    End Sub

    Private Sub btnScheduleDelete_Click(sender As Object, e As EventArgs) Handles btnScheduleDelete.Click

    End Sub

    Private Sub CategorySchedule_SelectedChanged(sender As Object, e As EventArgs) Handles CategorySchedule.SelectedIndexChanged, rbScheduleCurrent.CheckedChanged

    End Sub

    Private Sub rbScheduleLoop_CheckedChanged(sender As Object, e As EventArgs) Handles rbScheduleLoop.CheckedChanged

    End Sub

    Private Sub numericScheduleLoop_ValueChanged(sender As Object, e As EventArgs) Handles numericScheduleLoop.ValueChanged

    End Sub

    Private Sub btnScheduleStartLoop_Click(sender As Object, e As EventArgs) Handles btnScheduleStartLoop.Click

    End Sub
End Class