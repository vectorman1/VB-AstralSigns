Public Class Form1
    
    Dim sign As New AstralSign(0)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbSign.SelectedIndex = 0
        UpdateLabels(0)
    End Sub
    Private Sub cbSign_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSign.SelectedIndexChanged
        sign.Index = cbSign.SelectedIndex
        UpdateLabels(cbSign.SelectedIndex)
    End Sub
    Sub UpdateLabels(ByVal i)
        sign.Index = i
        labelSignDates.Text = sign.GetTime()
        labelSaying.Text = sign.GetSaying()
        labelColor.Text = sign.GetColor()
        labelPlanet.Text = sign.GetPlanet()
        labelElement.Text = sign.GetElement()
        pbSign.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", sign.GetImage()))
    End Sub

End Class
