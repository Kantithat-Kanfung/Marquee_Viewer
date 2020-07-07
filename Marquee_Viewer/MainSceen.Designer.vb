<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainSceen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainSceen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCloseApp = New System.Windows.Forms.Button()
        Me.lbFileName = New System.Windows.Forms.Label()
        Me.lbAppName = New System.Windows.Forms.Label()
        Me.pixBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStrpZoom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStrpSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStrpPath = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnRotate = New System.Windows.Forms.Button()
        Me.btnZoomIn = New System.Windows.Forms.Button()
        Me.btnZoomOut = New System.Windows.Forms.Button()
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pixBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCloseApp)
        Me.Panel1.Controls.Add(Me.lbFileName)
        Me.Panel1.Controls.Add(Me.lbAppName)
        Me.Panel1.Controls.Add(Me.pixBoxLogo)
        Me.Panel1.Location = New System.Drawing.Point(-4, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1210, 44)
        Me.Panel1.TabIndex = 0
        '
        'btnCloseApp
        '
        Me.btnCloseApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCloseApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseApp.ForeColor = System.Drawing.Color.White
        Me.btnCloseApp.Location = New System.Drawing.Point(1162, 3)
        Me.btnCloseApp.Name = "btnCloseApp"
        Me.btnCloseApp.Size = New System.Drawing.Size(45, 49)
        Me.btnCloseApp.TabIndex = 6
        Me.btnCloseApp.Text = "×"
        Me.btnCloseApp.UseVisualStyleBackColor = False
        '
        'lbFileName
        '
        Me.lbFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFileName.ForeColor = System.Drawing.Color.White
        Me.lbFileName.Location = New System.Drawing.Point(227, 14)
        Me.lbFileName.Name = "lbFileName"
        Me.lbFileName.Size = New System.Drawing.Size(815, 24)
        Me.lbFileName.TabIndex = 1
        Me.lbFileName.Text = "pictrue-1.png"
        Me.lbFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbAppName
        '
        Me.lbAppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAppName.ForeColor = System.Drawing.Color.White
        Me.lbAppName.Location = New System.Drawing.Point(47, 14)
        Me.lbAppName.Name = "lbAppName"
        Me.lbAppName.Size = New System.Drawing.Size(126, 24)
        Me.lbAppName.TabIndex = 0
        Me.lbAppName.Text = "Marquee Viewer"
        '
        'pixBoxLogo
        '
        Me.pixBoxLogo.Image = CType(resources.GetObject("pixBoxLogo.Image"), System.Drawing.Image)
        Me.pixBoxLogo.Location = New System.Drawing.Point(16, 10)
        Me.pixBoxLogo.Name = "pixBoxLogo"
        Me.pixBoxLogo.Size = New System.Drawing.Size(25, 28)
        Me.pixBoxLogo.TabIndex = 0
        Me.pixBoxLogo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.StatusStrip)
        Me.Panel3.Location = New System.Drawing.Point(90, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1080, 595)
        Me.Panel3.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.toolStrpZoom, Me.toolStrpSize, Me.toolStrpPath})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 573)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1080, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "Zoom : "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'toolStrpZoom
        '
        Me.toolStrpZoom.AutoSize = False
        Me.toolStrpZoom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.toolStrpZoom.Name = "toolStrpZoom"
        Me.toolStrpZoom.Size = New System.Drawing.Size(150, 17)
        Me.toolStrpZoom.Text = "Zoom :"
        '
        'toolStrpSize
        '
        Me.toolStrpSize.AutoSize = False
        Me.toolStrpSize.BackColor = System.Drawing.Color.WhiteSmoke
        Me.toolStrpSize.Name = "toolStrpSize"
        Me.toolStrpSize.Size = New System.Drawing.Size(150, 17)
        Me.toolStrpSize.Text = "Size :"
        '
        'toolStrpPath
        '
        Me.toolStrpPath.AutoSize = False
        Me.toolStrpPath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.toolStrpPath.Name = "toolStrpPath"
        Me.toolStrpPath.Size = New System.Drawing.Size(700, 17)
        Me.toolStrpPath.Text = "Path : "
        Me.toolStrpPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRotate
        '
        Me.btnRotate.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnRotate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRotate.Image = CType(resources.GetObject("btnRotate.Image"), System.Drawing.Image)
        Me.btnRotate.Location = New System.Drawing.Point(-3, 104)
        Me.btnRotate.Name = "btnRotate"
        Me.btnRotate.Size = New System.Drawing.Size(72, 48)
        Me.btnRotate.TabIndex = 3
        Me.btnRotate.UseVisualStyleBackColor = False
        '
        'btnZoomIn
        '
        Me.btnZoomIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoomIn.Image = CType(resources.GetObject("btnZoomIn.Image"), System.Drawing.Image)
        Me.btnZoomIn.Location = New System.Drawing.Point(-3, 194)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(72, 46)
        Me.btnZoomIn.TabIndex = 3
        Me.btnZoomIn.UseVisualStyleBackColor = False
        '
        'btnZoomOut
        '
        Me.btnZoomOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoomOut.Image = CType(resources.GetObject("btnZoomOut.Image"), System.Drawing.Image)
        Me.btnZoomOut.Location = New System.Drawing.Point(0, 284)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(69, 47)
        Me.btnZoomOut.TabIndex = 3
        Me.btnZoomOut.UseVisualStyleBackColor = False
        '
        'btnSaveFile
        '
        Me.btnSaveFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnSaveFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveFile.Image = CType(resources.GetObject("btnSaveFile.Image"), System.Drawing.Image)
        Me.btnSaveFile.Location = New System.Drawing.Point(-3, 379)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(72, 50)
        Me.btnSaveFile.TabIndex = 3
        Me.btnSaveFile.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(-3, 470)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 50)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.Image = CType(resources.GetObject("btnOpenFile.Image"), System.Drawing.Image)
        Me.btnOpenFile.Location = New System.Drawing.Point(-3, 26)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(72, 48)
        Me.btnOpenFile.TabIndex = 3
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.Location = New System.Drawing.Point(-3, 569)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 51)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnHelp)
        Me.Panel2.Controls.Add(Me.btnSaveFile)
        Me.Panel2.Controls.Add(Me.btnOpenFile)
        Me.Panel2.Controls.Add(Me.btnZoomIn)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnRotate)
        Me.Panel2.Controls.Add(Me.btnZoomOut)
        Me.Panel2.Location = New System.Drawing.Point(-1, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(66, 650)
        Me.Panel2.TabIndex = 1
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'PrintDocument
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'MainSceen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1200, 685)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "MainSceen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.pixBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnRotate As Button
    Friend WithEvents btnZoomIn As Button
    Friend WithEvents btnZoomOut As Button
    Friend WithEvents btnSaveFile As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbAppName As Label
    Friend WithEvents pixBoxLogo As PictureBox
    Friend WithEvents lbFileName As Label
    Friend WithEvents btnCloseApp As Button
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents toolStrpZoom As ToolStripStatusLabel
    Friend WithEvents toolStrpSize As ToolStripStatusLabel
    Friend WithEvents toolStrpPath As ToolStripStatusLabel
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip As ToolTip
End Class
