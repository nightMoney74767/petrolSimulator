Public Class fr_help
    Private Sub bt_exit_Click(sender As Object, e As EventArgs) Handles bt_exit.Click
        fr_main.Show() 'opens main form'
        Me.Hide() 'Hides help form
    End Sub

    'ControlBox enabled (3/6/2021) - allows access to system close button
    Private Sub fr_help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class