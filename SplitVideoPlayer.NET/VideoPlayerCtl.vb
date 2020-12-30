Imports PVS.MediaPlayer

Public Class VideoPlayerCtl
    Public VideoInstance As New Player
    Public Property InitMute As Boolean = True
    Public Property InitFileNameAlignmentBottom As Boolean = False
    Public PositionWasChanged As Boolean = False
    Public CurrentZoom As Double = 1.0
    Private Pos As Point

    Private Sub LoadVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadVideoToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        Dim filename As String
        filename = OpenFileDialog1.FileName
        LoadFileAndPause(filename)
    End Sub

    Public Sub LoadFileAndPause(ByVal Filename As String)
        Dim fileinf As New IO.FileInfo(Filename)
        VideoFileName.Text = fileinf.Name
        VideoInstance.CursorHide.CursorHidden = False
        VideoInstance.Play(Filename, VideoPanel, False)
        VideoInstance.Pause()
        VideoInstance.Repeat = True
        VideoFileName.Text += " (" & VideoInstance.Media.VideoSourceSize.Width & "X" & VideoInstance.Media.VideoSourceSize.Height & " @ " & VideoInstance.Media.VideoFrameRate & ") [" & VideoInstance.Media.Length.ToString() & "]"
    End Sub

    Private Sub UnloadVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnloadVideoToolStripMenuItem.Click
        VideoInstance.Reset()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        VideoInstance.Mute = MuteToolStripMenuItem.Checked
        VideoInstance.Resume()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        VideoInstance.Pause()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        VideoInstance.Stop()
    End Sub
    Private Sub MuteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MuteToolStripMenuItem.Click
        VideoInstance.Mute = MuteToolStripMenuItem.Checked
    End Sub

    Private Sub VideoPlayerCtl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VideoInstance.Mute = InitMute
        MuteToolStripMenuItem.Checked = InitMute

        Dim oldsize As Size
        oldsize = VideoPanel.Size
        VideoPanel.Dock = DockStyle.None
        VideoPanel.Size = oldsize

        If InitFileNameAlignmentBottom Then
            VideoFileName.Dock = DockStyle.Bottom
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 1.0
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 0.25
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 0.5
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 0.75
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 1.25
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 1.5
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 1.75
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 2
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 2.5
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 3
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub StretchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StretchToolStripMenuItem.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Stretch
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 3.5
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoInstance.Display.Mode = DisplayMode.Manual
        CurrentZoom = 4
        VideoInstance.Video.Zoom(CurrentZoom)
    End Sub

    Private Sub VideoPanel_MouseDown(ByVal sender As Object, ByVal e As _
      System.Windows.Forms.MouseEventArgs) Handles VideoPanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            PositionWasChanged = True
            Pos = New Point(e.Location)
        End If
    End Sub

    Private Sub VideoPanel_MouseMove(ByVal sender As Object, ByVal e As _
      System.Windows.Forms.MouseEventArgs) Handles VideoPanel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            PositionWasChanged = True
            VideoPanel.Location = New Point(VideoPanel.Location + (e.Location - Pos))
            VideoInstance.Display.Update()
        End If
    End Sub

    Public Sub UpdatePanelSize()
        VideoPanel.Dock = DockStyle.Fill
        Dim oldsize As Size
        oldsize = VideoPanel.Size
        VideoPanel.Dock = DockStyle.None
        VideoPanel.Size = oldsize
        PositionWasChanged = False
    End Sub

    Private Sub VideoPlayerCtl_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        UpdatePanelSize()
    End Sub

    Private Sub ResetViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetViewToolStripMenuItem.Click
        VideoPanel.Dock = DockStyle.Fill
    End Sub

    Private Sub ShowFilenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowFilenameToolStripMenuItem.Click
        If ShowFilenameToolStripMenuItem.Checked Then
            VideoFileName.Visible = True
        Else
            VideoFileName.Visible = False
        End If
    End Sub

    Private Sub VideoPanel_Validated(sender As Object, e As EventArgs) Handles VideoPanel.Validated
        VideoInstance.Display.Update()
    End Sub
End Class
