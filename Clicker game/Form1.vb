Public Class form1
    Dim r As New Random
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub pbTarget_Click(sender As Object, e As EventArgs) Handles pbTarget.Click
        If pbTarget.Width >= 10 Then
            pbTarget.Width -= 5
        End If

        If pbTarget.Height >= 10 Then
            pbTarget.Height -= 5
        End If
        pbTarget.Left = r.Next(pbPlayingField.Left, pbPlayingField.Right - pbTarget.Width)
        pbTarget.Top = r.Next(pbPlayingField.Top, pbPlayingField.Bottom - pbTarget.Height)
    End Sub
End Class

