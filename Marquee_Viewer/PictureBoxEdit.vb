Public Class PictureBoxEdit

    Private _img As Image
    Private _picBox As PictureBox

    Public Sub New(ByVal picBox As PictureBox)
        If picBox.Image Is Nothing Then
            MessageBox.Show("PictureBox Must Contain Image")
            Exit Sub
        End If

        _img = picBox.Image
        _picBox = picBox
    End Sub

    Public Sub Resize(ByVal percent As Short)
        If Not Short.TryParse(percent, percent) OrElse (percent <= 0) Then
            MessageBox.Show("Incorrect Zoom Level")
            Exit Sub
        End If

        Dim w_src, h_src, w, h As Short
        Dim img_src, img_new As Bitmap
        w_src = _img.Width
        h_src = _img.Height
        w = w_src - (w_src * (1 - percent / 100))
        h = h_src - (h_src * (1 - percent / 100))
        img_src = New Bitmap(_img)
        img_new = New Bitmap(w, h)
        Dim g As Graphics = Graphics.FromImage(img_new)
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(img_src, 0, 0, w, h)
        _picBox.Image = img_new
    End Sub

    Public Sub Mirror()
        Flip(RotateFlipType.RotateNoneFlipX)
    End Sub

    Public Sub Invert()
        Flip(RotateFlipType.RotateNoneFlipY)
    End Sub

    Public Sub InvertMirror()
        Flip(RotateFlipType.RotateNoneFlipXY)
    End Sub

    Private Sub Flip(ByVal f As RotateFlipType)
        Dim img As Bitmap = _picBox.Image
        img.RotateFlip(f)
        _picBox.Image = img
    End Sub

End Class
