Imports PVS.MediaPlayer

Public Class VideoPlayerCtl
    Public VideoInstance As New Player
    Public Property InitMute As Boolean = True
    Public Property InitFileNameAlignmentBottom As Boolean = False
    Public Property InitFilenameTagCaption As String = "Load video file via context menu..."
    Public PositionWasChanged As Boolean = False
    Public CurrentZoom As Double = 1.0
    Private Pos As Point

    Private Sub LoadVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadVideoToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Public Sub LoadFileAndPause(ByVal Filename As String)
        Dim fileinf As New IO.FileInfo(Filename)
        VideoFileName.Text = fileinf.Name
        VideoInstance.CursorHide.CursorHidden = False
        VideoInstance.Play(Filename, VideoPanel, False)
        VideoInstance.Pause()
        VideoInstance.Mute = MuteToolStripMenuItem.Checked
        VideoInstance.Video.MaxZoomSize = New Size(10000, 10000)
        VideoInstance.Repeat = True
        VideoFileName.Text += " (" & VideoInstance.Media.VideoSourceSize.Width & "X" & VideoInstance.Media.VideoSourceSize.Height & " @ " & VideoInstance.Media.VideoFrameRate & ") [" & VideoInstance.Media.Length.ToString() & "]"
        SetPlaybackGUIState(True)
    End Sub

    Public Sub SetPlaybackGUIState(ByVal Ready As Boolean)
        UnloadVideoToolStripMenuItem.Enabled = Ready
        PlayToolStripMenuItem.Enabled = Ready
        PauseToolStripMenuItem.Enabled = Ready
        StopToolStripMenuItem.Enabled = Ready
        ToolStripMenuItem2.Enabled = Ready
        ToolStripMenuItem3.Enabled = Ready
        ToolStripMenuItem4.Enabled = Ready
        ToolStripMenuItem5.Enabled = Ready
        ToolStripMenuItem6.Enabled = Ready
        ToolStripMenuItem7.Enabled = Ready
        ToolStripMenuItem8.Enabled = Ready
        ToolStripMenuItem9.Enabled = Ready
        ToolStripMenuItem10.Enabled = Ready
        ToolStripMenuItem11.Enabled = Ready
        ToolStripMenuItem12.Enabled = Ready
        ToolStripMenuItem13.Enabled = Ready
        CopyPictureToClipboardToolStripMenuItem.Enabled = Ready
        SavePictureToolStripMenuItem.Enabled = Ready
        LoadVideoToolStripMenuItem.Enabled = Not Ready
        If Ready = False Then
            VideoFileName.Text = InitFilenameTagCaption
        End If
    End Sub

    Private Sub UnloadVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnloadVideoToolStripMenuItem.Click
        VideoInstance.Reset()
        SetPlaybackGUIState(False)
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

        SetPlaybackGUIState(False)
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

    Private Sub VideoPanel_MouseWheel(ByVal sender As Object, ByVal e As _
      MouseEventArgs) Handles VideoPanel.MouseWheel
        If Not e.Delta = 0 And VideoInstance.Playing Then
            If e.Delta > 0 Then
                CurrentZoom += 0.1
                VideoInstance.Video.Zoom(1.1)
            Else
                If CurrentZoom > 0.1 Then
                    CurrentZoom -= 0.1
                    VideoInstance.Video.Zoom(0.9)
                End If
            End If
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

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        VideoInstance.Copy.Mode = CopyMode.Video

        If SaveFileDialog1.FilterIndex = 1 Then
            VideoInstance.Copy.ToFile(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
        End If
        If SaveFileDialog1.FilterIndex = 2 Then
            VideoInstance.Copy.ToFile(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
        End If
        If SaveFileDialog1.FilterIndex = 3 Then
            VideoInstance.Copy.ToFile(SaveFileDialog1.FileName, Imaging.ImageFormat.Bmp)
        End If
    End Sub

    Private Sub CopyPictureToClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyPictureToClipboardToolStripMenuItem.Click
        VideoInstance.Copy.Mode = CopyMode.Video
        VideoInstance.Copy.ToClipboard()
    End Sub

    Private Sub SavePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavePictureToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim filename As String
        filename = OpenFileDialog1.FileName
        LoadFileAndPause(filename)
    End Sub
End Class
