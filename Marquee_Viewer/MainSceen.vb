Public Class MainSceen
    Private Const _appName As String = "Marquee Viewer"
    Private _zoom As Integer = 100
    Private _picBoxEdit As PictureBoxEdit
    Private _file As String
    Private _cntRotate As Byte = 0

    Private Sub MainSceen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbAppName.Text = _appName
    End Sub

    Private Sub MainSceen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And (e.KeyCode = Keys.O) Then
            btnOpenFile_Click(sender, e)
        ElseIf e.Control And (e.KeyCode = Keys.R) Then
            If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
                btnRotate_Click(sender, e)
            Else
                Exit Sub
            End If
        ElseIf e.Control AndAlso (e.KeyCode = Keys.Up) Then
            If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
                btnZoomIn_Click(sender, e)
            Else
                Exit Sub
            End If
        ElseIf e.Control AndAlso (e.KeyCode = Keys.Down) Then
            If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
                btnZoomOut_Click(sender, e)
            Else
                Exit Sub
            End If
        ElseIf e.Control And (e.KeyCode = Keys.S) Then
            If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
                btnSaveFile_Click(sender, e)
            Else
                Exit Sub
            End If
        ElseIf e.Control And (e.KeyCode = Keys.P) Then
            If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
                btnPrint_Click(sender, e)
            Else
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnCloseApp_Click(sender As Object, e As EventArgs) Handles btnCloseApp.Click
        Application.Exit()
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        OpenFileDialog.InitialDirectory = Environment.SpecialFolder.MyPictures
        OpenFileDialog.FileName = ""
        OpenFileDialog.ShowDialog()

        If My.Computer.FileSystem.FileExists(OpenFileDialog.FileName) Then
            OpenFile(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub OpenFile(ByVal file As String)
        PictureBox1.Load(file)
        _picBoxEdit = New PictureBoxEdit(PictureBox1)
        _file = file
        UpdateStatus()
        UpdateFileName()
    End Sub

    Private Sub UpdateStatus()
        toolStrpZoom.Text = $"Zoom : {_zoom}%"
        toolStrpSize.Text = $"Size : {PictureBox1.Width} x {PictureBox1.Height}"
    End Sub

    Private Sub UpdateFileName()
        Dim fileName As String = _file

        If Not String.IsNullOrEmpty(fileName) Then
            lbFileName.Text = My.Computer.FileSystem.GetName(fileName)
            toolStrpPath.Text = $"File : {My.Computer.FileSystem.GetName(fileName)}"
        Else
            toolStrpPath.Text = $"File : {fileName}"
        End If
    End Sub

    Private Sub btnRotate_Click(sender As Object, e As EventArgs) Handles btnRotate.Click
        If _cntRotate = 0 Then
            _picBoxEdit.Invert()
            _cntRotate += 1
        ElseIf _cntRotate = 1 Then
            _picBoxEdit.Mirror()
            _cntRotate += 1
        ElseIf _cntRotate = 2 Then
            _picBoxEdit.InvertMirror()
            _cntRotate = 0
        End If
    End Sub

    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        Dim oldName As String = My.Computer.FileSystem.GetName(OpenFileDialog.FileName)

        Dim ext As String = My.Computer.FileSystem.GetFileInfo(oldName).Extension
        SaveFileDialog.OverwritePrompt = True
        SaveFileDialog.AddExtension = True
        SaveFileDialog.DefaultExt = ext
        SaveFileDialog.Filter = $"{ext}|*{ext}"

        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            Try
                PictureBox1.Image.Save(SaveFileDialog.FileName)
                OpenFile(SaveFileDialog.FileName)
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        End If
    End Sub

    Private Sub btnZoomIn_Click(sender As Object, e As EventArgs) Handles btnZoomIn.Click
        ResizePictureBox(10)
    End Sub

    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) Handles btnZoomOut.Click
        ResizePictureBox(-10)
    End Sub

    Private Sub ResizePictureBox(ByVal zm As Integer)
        If zm = 0 Then
            _zoom = 100
        Else
            If (_zoom + zm) <= 0 Then
                MsgBox("Incorrect Zoom Lavel")
                Exit Sub
            End If
            _zoom += zm
        End If

        _picBoxEdit.Resize(_zoom)
        UpdateStatus()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim test As Graphics = e.Graphics
        Dim img As Image = Image.FromFile(OpenFileDialog.FileName)
        test.DrawImage(img, 50, 50)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog.Document = PrintDocument
        PrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub btnOpenFile_MouseHover(sender As Object, e As EventArgs) Handles btnOpenFile.MouseHover
        ToolTip.SetToolTip(btnOpenFile, "Open File (Ctrl + O)")
    End Sub

    Private Sub btnRotate_MouseHover(sender As Object, e As EventArgs) Handles btnRotate.MouseHover
        ToolTip.SetToolTip(btnRotate, "Rotate (Ctrl + R)")
    End Sub

    Private Sub btnZoomIn_MouseHover(sender As Object, e As EventArgs) Handles btnZoomIn.MouseHover
        ToolTip.SetToolTip(btnZoomIn, "Zoom In (Ctrl + Up)")
    End Sub

    Private Sub btnZoomOut_MouseHover(sender As Object, e As EventArgs) Handles btnZoomOut.MouseHover
        ToolTip.SetToolTip(btnZoomOut, "Zoom In (Ctrl + Down)")
    End Sub

    Private Sub btnSaveFile_MouseHover(sender As Object, e As EventArgs) Handles btnSaveFile.MouseHover
        ToolTip.SetToolTip(btnSaveFile, "Save (Ctrl + S)")
    End Sub

    Private Sub btnPrint_MouseHover(sender As Object, e As EventArgs) Handles btnPrint.MouseHover
        ToolTip.SetToolTip(btnPrint, "Print Document (Ctrl + P)")
    End Sub

    Private Sub btnHelp_MouseHover(sender As Object, e As EventArgs) Handles btnHelp.MouseHover
        ToolTip.SetToolTip(btnHelp, "Help")
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        ' How to Use Application
    End Sub
End Class
