Public Class Main
	Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
		Dim openFileDialog As New OpenFileDialog() With
{
	.Title = "File",
	.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
	.FileName = "*.*",
	.Filter = "all file |*.*;*.* ",
	.FilterIndex = 2,
	.RestoreDirectory = True
}
		If openFileDialog.ShowDialog() = DialogResult.OK Then
			txtfile.Text = openFileDialog.FileName
		End If
	End Sub

	Private Sub btn_replace_Click(sender As Object, e As EventArgs) Handles btn_replace.Click
		HexOperation.HexPatch(txtfile.Text, txtvalue.Text, txtreplace.Text)
	End Sub
End Class
