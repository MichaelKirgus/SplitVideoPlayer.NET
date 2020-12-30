Imports PVS.MediaPlayer

Public Class Form1

    Public PrevPos As TimeSpan
    Public IsPauseMode As Boolean = False
    Public CurrentMasterPlaybackInstance As Player
    Public ResizeMode As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetMasterPlaybackInstance(VideoPlayerCtl1.VideoInstance)
    End Sub

    Public Sub Set2FilesCompareMode()
        SplitContainer3.Panel2Collapsed = True
        SplitContainer4.Panel2Collapsed = True
    End Sub

    Public Sub Set4FilesCompareMode()
        SplitContainer3.Panel2Collapsed = False
        SplitContainer4.Panel2Collapsed = False
    End Sub

    Public Sub SetMasterPlaybackInstance(ByVal PlayerInstance As Player)
        PlayerInstance.Sliders.Position.TrackBar = TrackBar1
        PlayerInstance.Sliders.Position.LiveUpdate = True
        PlayerInstance.Sliders.AudioVolume = TrackBar2
        PlayerInstance.TimerInterval = 10
        CurrentMasterPlaybackInstance = PlayerInstance
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsPauseMode Then
            IsPauseMode = False
            Button1.Image = My.Resources.media_playback_start_7
            If VideoPlayerCtl1.VideoInstance.Playing Then
                VideoPlayerCtl1.VideoInstance.Pause()
            End If
            If VideoPlayerCtl2.VideoInstance.Playing Then
                VideoPlayerCtl2.VideoInstance.Pause()
            End If
            If VideoPlayerCtl3.VideoInstance.Playing Then
                VideoPlayerCtl3.VideoInstance.Pause()
            End If
            If VideoPlayerCtl4.VideoInstance.Playing Then
                VideoPlayerCtl4.VideoInstance.Pause()
            End If
        Else
            IsPauseMode = True
            Button1.Image = My.Resources.media_playback_pause_7
            If VideoPlayerCtl1.VideoInstance.Playing Then
                VideoPlayerCtl1.VideoInstance.Mute = VideoPlayerCtl1.MuteToolStripMenuItem.Checked
                VideoPlayerCtl1.VideoInstance.Resume()
            End If
            If VideoPlayerCtl2.VideoInstance.Playing Then
                VideoPlayerCtl2.VideoInstance.Mute = VideoPlayerCtl2.MuteToolStripMenuItem.Checked
                VideoPlayerCtl2.VideoInstance.Resume()
            End If
            If VideoPlayerCtl3.VideoInstance.Playing Then
                VideoPlayerCtl3.VideoInstance.Mute = VideoPlayerCtl3.MuteToolStripMenuItem.Checked
                VideoPlayerCtl3.VideoInstance.Resume()
            End If
            If VideoPlayerCtl4.VideoInstance.Playing Then
                VideoPlayerCtl4.VideoInstance.Mute = VideoPlayerCtl4.MuteToolStripMenuItem.Checked
                VideoPlayerCtl4.VideoInstance.Resume()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If VideoPlayerCtl1.VideoInstance.Playing Then
            VideoPlayerCtl1.VideoInstance.Stop()
        End If
        If VideoPlayerCtl2.VideoInstance.Playing Then
            VideoPlayerCtl2.VideoInstance.Stop()
        End If
        If VideoPlayerCtl3.VideoInstance.Playing Then
            VideoPlayerCtl3.VideoInstance.Stop()
        End If
        If VideoPlayerCtl4.VideoInstance.Playing Then
            VideoPlayerCtl4.VideoInstance.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If (VideoPlayerCtl1.VideoInstance.Playing Or VideoPlayerCtl2.VideoInstance.Playing Or VideoPlayerCtl3.VideoInstance.Playing Or VideoPlayerCtl4.VideoInstance.Playing) Then
            Dim currframe As TimeSpan
            currframe = CurrentMasterPlaybackInstance.Position.FromBegin
            If SyncPlaybackPositionToolStripMenuItem.Checked Then
                If Not PrevPos.TotalMilliseconds = currframe.TotalMilliseconds Then
                    PrevPos = currframe
                    If Not Equals(CurrentMasterPlaybackInstance, VideoPlayerCtl1.VideoInstance) Then
                        VideoPlayerCtl1.VideoInstance.Position.FromStart = currframe
                    End If
                    If Not Equals(CurrentMasterPlaybackInstance, VideoPlayerCtl2.VideoInstance) Then
                        VideoPlayerCtl2.VideoInstance.Position.FromStart = currframe
                    End If
                    If Not Equals(CurrentMasterPlaybackInstance, VideoPlayerCtl3.VideoInstance) Then
                        VideoPlayerCtl3.VideoInstance.Position.FromStart = currframe
                    End If
                    If Not Equals(CurrentMasterPlaybackInstance, VideoPlayerCtl4.VideoInstance) Then
                        VideoPlayerCtl4.VideoInstance.Position.FromStart = currframe
                    End If
                End If
            End If
        End If
        If SyncZoomFactorToolStripMenuItem.Checked Then
            SyncVideoPanelZoom()
        End If
        If SyncPositionsToolStripMenuItem.Checked = True Or SyncPositionsinvertedToolStripMenuItem.Checked = True Then
            SyncVideoPanelPositions(SyncPositionsinvertedToolStripMenuItem.Checked)
        End If
        Timer1.Start()
    End Sub

    Public Sub SyncVideoPanelZoom()
        If TopLeftToolStripMenuItem.Checked Then
            If Not VideoPlayerCtl1.CurrentZoom = VideoPlayerCtl2.CurrentZoom Then
                VideoPlayerCtl2.VideoInstance.Video.Zoom(VideoPlayerCtl1.CurrentZoom)
                VideoPlayerCtl3.VideoInstance.Video.Zoom(VideoPlayerCtl1.CurrentZoom)
                VideoPlayerCtl4.VideoInstance.Video.Zoom(VideoPlayerCtl1.CurrentZoom)
            End If
        End If
        If TopRightToolStripMenuItem.Checked Then
            If Not VideoPlayerCtl2.CurrentZoom = VideoPlayerCtl1.CurrentZoom Then
                VideoPlayerCtl1.VideoInstance.Video.Zoom(VideoPlayerCtl2.CurrentZoom)
                VideoPlayerCtl3.VideoInstance.Video.Zoom(VideoPlayerCtl2.CurrentZoom)
                VideoPlayerCtl4.VideoInstance.Video.Zoom(VideoPlayerCtl2.CurrentZoom)
            End If
        End If
        If BottomLeftToolStripMenuItem.Checked Then
            If Not VideoPlayerCtl3.CurrentZoom = VideoPlayerCtl1.CurrentZoom Then
                VideoPlayerCtl1.VideoInstance.Video.Zoom(VideoPlayerCtl3.CurrentZoom)
                VideoPlayerCtl2.VideoInstance.Video.Zoom(VideoPlayerCtl3.CurrentZoom)
                VideoPlayerCtl4.VideoInstance.Video.Zoom(VideoPlayerCtl3.CurrentZoom)
            End If
        End If
        If BottomRightToolStripMenuItem.Checked Then
            If Not VideoPlayerCtl4.CurrentZoom = VideoPlayerCtl1.CurrentZoom Then
                VideoPlayerCtl1.VideoInstance.Video.Zoom(VideoPlayerCtl4.CurrentZoom)
                VideoPlayerCtl2.VideoInstance.Video.Zoom(VideoPlayerCtl4.CurrentZoom)
                VideoPlayerCtl3.VideoInstance.Video.Zoom(VideoPlayerCtl4.CurrentZoom)
            End If
        End If
    End Sub

    Public Sub SyncVideoPanelPositions(ByVal Inverted As Boolean)
        If Inverted Then
            If TopLeftToolStripMenuItem.Checked Then
                If VideoPlayerCtl1.PositionWasChanged Then
                    VideoPlayerCtl2.VideoPanel.Location = New Point(-VideoPlayerCtl1.VideoPanel.Location.X, VideoPlayerCtl1.VideoPanel.Location.Y)
                    VideoPlayerCtl3.VideoPanel.Location = New Point(VideoPlayerCtl1.VideoPanel.Location.X, -VideoPlayerCtl1.VideoPanel.Location.Y)
                    VideoPlayerCtl4.VideoPanel.Location = New Point(-VideoPlayerCtl1.VideoPanel.Location.X, -VideoPlayerCtl1.VideoPanel.Location.Y)
                End If
            End If
            If TopRightToolStripMenuItem.Checked Then
                If VideoPlayerCtl2.PositionWasChanged Then
                    VideoPlayerCtl1.VideoPanel.Location = New Point(-VideoPlayerCtl2.VideoPanel.Location.X, VideoPlayerCtl2.VideoPanel.Location.Y)
                    VideoPlayerCtl3.VideoPanel.Location = New Point(-VideoPlayerCtl2.VideoPanel.Location.X, VideoPlayerCtl2.VideoPanel.Location.Y)
                    VideoPlayerCtl4.VideoPanel.Location = New Point(VideoPlayerCtl2.VideoPanel.Location.X, -VideoPlayerCtl2.VideoPanel.Location.Y)
                End If
            End If
            If BottomLeftToolStripMenuItem.Checked Then
                If VideoPlayerCtl3.PositionWasChanged Then
                    VideoPlayerCtl1.VideoPanel.Location = New Point(VideoPlayerCtl3.VideoPanel.Location.X, -VideoPlayerCtl3.VideoPanel.Location.Y)
                    VideoPlayerCtl2.VideoPanel.Location = New Point(-VideoPlayerCtl3.VideoPanel.Location.X, -VideoPlayerCtl3.VideoPanel.Location.Y)
                    VideoPlayerCtl4.VideoPanel.Location = New Point(-VideoPlayerCtl3.VideoPanel.Location.X, VideoPlayerCtl3.VideoPanel.Location.Y)
                End If
            End If
            If BottomRightToolStripMenuItem.Checked Then
                If VideoPlayerCtl4.PositionWasChanged Then
                    VideoPlayerCtl1.VideoPanel.Location = New Point(-VideoPlayerCtl4.VideoPanel.Location.X, -VideoPlayerCtl4.VideoPanel.Location.Y)
                    VideoPlayerCtl2.VideoPanel.Location = New Point(VideoPlayerCtl4.VideoPanel.Location.X, -VideoPlayerCtl4.VideoPanel.Location.Y)
                    VideoPlayerCtl3.VideoPanel.Location = New Point(-VideoPlayerCtl4.VideoPanel.Location.X, VideoPlayerCtl4.VideoPanel.Location.Y)
                End If
            End If
        Else
            If TopLeftToolStripMenuItem.Checked Then
                If VideoPlayerCtl1.PositionWasChanged Then
                    VideoPlayerCtl2.VideoPanel.Location = VideoPlayerCtl1.VideoPanel.Location
                    VideoPlayerCtl3.VideoPanel.Location = VideoPlayerCtl1.VideoPanel.Location
                    VideoPlayerCtl4.VideoPanel.Location = VideoPlayerCtl1.VideoPanel.Location
                End If
            End If
            If TopRightToolStripMenuItem.Checked Then
                If VideoPlayerCtl2.PositionWasChanged Then
                    VideoPlayerCtl1.VideoPanel.Location = VideoPlayerCtl2.VideoPanel.Location
                    VideoPlayerCtl3.VideoPanel.Location = VideoPlayerCtl2.VideoPanel.Location
                    VideoPlayerCtl4.VideoPanel.Location = VideoPlayerCtl2.VideoPanel.Location
                End If
            End If
            If BottomLeftToolStripMenuItem.Checked Then
                If VideoPlayerCtl3.PositionWasChanged Then
                    VideoPlayerCtl1.VideoPanel.Location = VideoPlayerCtl3.VideoPanel.Location
                    VideoPlayerCtl2.VideoPanel.Location = VideoPlayerCtl3.VideoPanel.Location
                    VideoPlayerCtl4.VideoPanel.Location = VideoPlayerCtl3.VideoPanel.Location
                End If
            End If
            If BottomRightToolStripMenuItem.Checked Then
                If VideoPlayerCtl4.PositionWasChanged Then
                    VideoPlayerCtl1.VideoPanel.Location = VideoPlayerCtl4.VideoPanel.Location
                    VideoPlayerCtl2.VideoPanel.Location = VideoPlayerCtl4.VideoPanel.Location
                    VideoPlayerCtl3.VideoPanel.Location = VideoPlayerCtl4.VideoPanel.Location
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ContextMenuStrip1.Show(MousePosition)
    End Sub

    Private Sub TopLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopLeftToolStripMenuItem.Click
        BottomLeftToolStripMenuItem.Checked = False
        BottomRightToolStripMenuItem.Checked = False
        TopRightToolStripMenuItem.Checked = False
        SetMasterPlaybackInstance(VideoPlayerCtl1.VideoInstance)
    End Sub

    Private Sub TopRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopRightToolStripMenuItem.Click
        BottomLeftToolStripMenuItem.Checked = False
        BottomRightToolStripMenuItem.Checked = False
        TopLeftToolStripMenuItem.Checked = False
        SetMasterPlaybackInstance(VideoPlayerCtl2.VideoInstance)
    End Sub

    Private Sub BottomLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottomLeftToolStripMenuItem.Click
        TopRightToolStripMenuItem.Checked = False
        BottomRightToolStripMenuItem.Checked = False
        TopLeftToolStripMenuItem.Checked = False
        SetMasterPlaybackInstance(VideoPlayerCtl3.VideoInstance)
    End Sub

    Private Sub BottomRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottomRightToolStripMenuItem.Click
        BottomLeftToolStripMenuItem.Checked = False
        TopRightToolStripMenuItem.Checked = False
        TopLeftToolStripMenuItem.Checked = False
        SetMasterPlaybackInstance(VideoPlayerCtl4.VideoInstance)
    End Sub

    Private Sub X2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles X2ToolStripMenuItem1.Click
        X2ToolStripMenuItem.Checked = False
        X2ToolStripMenuItem1.Checked = True
        Set2FilesCompareMode()
    End Sub

    Private Sub X2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X2ToolStripMenuItem.Click
        X2ToolStripMenuItem1.Checked = False
        X2ToolStripMenuItem.Checked = True
        Set4FilesCompareMode()
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        If TrackBar2.Value = 0 Then
            Button5.Image = My.Resources.audio_volume_muted_4
        Else
            Button5.Image = My.Resources.audio_volume_high_4
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If CurrentMasterPlaybackInstance.Mute Then
            Button5.Image = My.Resources.audio_volume_high_4
            CurrentMasterPlaybackInstance.Mute = False
        Else
            Button5.Image = My.Resources.audio_volume_muted_4
            CurrentMasterPlaybackInstance.Mute = True
        End If
    End Sub

    Private Sub SplitContainer3_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer3.SplitterMoved
        If Not ResizeMode Then
            If SyncSizesToolStripMenuItem.Checked Then
                SplitContainer4.SplitterDistance = SplitContainer3.SplitterDistance
            End If
            If SyncSizesToolStripMenuItem.Checked Then
                ReAlignZoom()
            End If
        End If
    End Sub

    Private Sub SplitContainer4_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer4.SplitterMoved
        If Not ResizeMode Then
            If SyncSizesToolStripMenuItem.Checked Then
                SplitContainer3.SplitterDistance = SplitContainer4.SplitterDistance
            End If
            If SyncSizesToolStripMenuItem.Checked Then
                ReAlignZoom()
            End If
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Maximum <= NumericUpDown1.Maximum Then
            NumericUpDown1.Value = 0
        End If
        NumericUpDown1.Maximum = TrackBar1.Maximum
        NumericUpDown1.Value = TrackBar1.Value
    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        If TrackBar1.Maximum <= NumericUpDown1.Maximum Then
            NumericUpDown1.Value = 0
        End If
        NumericUpDown1.Maximum = TrackBar1.Maximum
        NumericUpDown1.Value = TrackBar1.Value
    End Sub

    Private Sub NumericUpDown1_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim newtime As New TimeSpan(NumericUpDown1.Value)
            CurrentMasterPlaybackInstance.Position.FromStart = newtime
            e.Handled = True
        End If
    End Sub

    Public Sub ReAlignZoom()
        VideoPlayerCtl1.VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoPlayerCtl2.VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoPlayerCtl3.VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoPlayerCtl4.VideoInstance.Display.Mode = DisplayMode.ZoomCenter
    End Sub

    Private Sub SplitContainer2_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer2.SplitterMoved
        If SyncSizesToolStripMenuItem.Checked Then
            ReAlignZoom()
        End If
    End Sub

    Private Sub Form1_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeBegin
        ResizeMode = True
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        ResizeMode = False
    End Sub

    Private Sub Form1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating
        ResizeMode = True
    End Sub

    Private Sub Form1_Validated(sender As Object, e As EventArgs) Handles MyBase.Validated
        ResizeMode = False
    End Sub

    Private Sub ShowAlignmentLinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAlignmentLinesToolStripMenuItem.Click
        If ShowAlignmentLinesToolStripMenuItem.Checked Then
            SetCompareMode(False)
        Else
            SetCompareMode(True)
        End If
    End Sub

    Public Sub SetCompareMode(ByVal Enabled As Boolean)
        If Enabled Then
            SplitContainer2.SplitterWidth = 1
            SplitContainer3.SplitterWidth = 1
            SplitContainer4.SplitterWidth = 1
            SplitContainer2.BackColor = Color.Black
            SplitContainer3.BackColor = Color.Black
            SplitContainer4.BackColor = Color.Black
        Else
            SplitContainer2.SplitterWidth = 4
            SplitContainer3.SplitterWidth = 4
            SplitContainer4.SplitterWidth = 4
            SplitContainer2.BackColor = Color.FromKnownColor(KnownColor.Control)
            SplitContainer3.BackColor = Color.FromKnownColor(KnownColor.Control)
            SplitContainer4.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        If X2ToolStripMenuItem.Checked Then
            If OpenFileDialog1.FileNames.Count = 1 Then
                VideoPlayerCtl1.LoadFileAndPause(OpenFileDialog1.FileNames(0))

                Dim result As MsgBoxResult
                result = MsgBox("Only 1 file was selected. Do you want to load the same file in all video panels?", MsgBoxStyle.YesNo)
                If result = MsgBoxResult.Yes Then
                    VideoPlayerCtl2.LoadFileAndPause(OpenFileDialog1.FileNames(0))
                    VideoPlayerCtl3.LoadFileAndPause(OpenFileDialog1.FileNames(0))
                    VideoPlayerCtl4.LoadFileAndPause(OpenFileDialog1.FileNames(0))
                End If
            End If
            If OpenFileDialog1.FileNames.Count = 2 Then
                VideoPlayerCtl1.LoadFileAndPause(OpenFileDialog1.FileNames(0))
                VideoPlayerCtl2.LoadFileAndPause(OpenFileDialog1.FileNames(1))
            End If
            If OpenFileDialog1.FileNames.Count = 3 Then
                VideoPlayerCtl1.LoadFileAndPause(OpenFileDialog1.FileNames(0))
                VideoPlayerCtl2.LoadFileAndPause(OpenFileDialog1.FileNames(1))
                VideoPlayerCtl3.LoadFileAndPause(OpenFileDialog1.FileNames(2))
            End If
            If OpenFileDialog1.FileNames.Count = 4 Then
                VideoPlayerCtl1.LoadFileAndPause(OpenFileDialog1.FileNames(0))
                VideoPlayerCtl2.LoadFileAndPause(OpenFileDialog1.FileNames(1))
                VideoPlayerCtl3.LoadFileAndPause(OpenFileDialog1.FileNames(2))
                VideoPlayerCtl4.LoadFileAndPause(OpenFileDialog1.FileNames(3))
            End If
            If OpenFileDialog1.FileNames.Count > 4 Then
                MsgBox("Too much video files selected, please select max. 4 files!", MsgBoxStyle.Exclamation)
            End If
        Else
            If OpenFileDialog1.FileNames.Count = 1 Then
                VideoPlayerCtl1.LoadFileAndPause(OpenFileDialog1.FileNames(0))

                Dim result As MsgBoxResult
                result = MsgBox("Only 1 file was selected. Do you want to load the same file in the 2nd panel?", MsgBoxStyle.YesNo)
                If result = MsgBoxResult.Yes Then
                    VideoPlayerCtl2.LoadFileAndPause(OpenFileDialog1.FileNames(0))
                End If
            End If
            If OpenFileDialog1.FileNames.Count = 2 Then
                VideoPlayerCtl1.LoadFileAndPause(OpenFileDialog1.FileNames(0))
                VideoPlayerCtl2.LoadFileAndPause(OpenFileDialog1.FileNames(1))
            End If
            If OpenFileDialog1.FileNames.Count > 2 Then
                MsgBox("Too much video files selected, please select max. 2 files!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AboutBox1.ShowDialog()
    End Sub

    Sub ReSizeVideoPanels()
        SplitContainer3.SplitterDistance = Math.Round(SplitContainer3.Height / 2, 0)
        SplitContainer4.SplitterDistance = Math.Round(SplitContainer4.Height / 2, 0)
        SplitContainer2.SplitterDistance = Math.Round(SplitContainer2.Width / 2, 0)

        VideoPlayerCtl1.UpdatePanelSize()
        VideoPlayerCtl2.UpdatePanelSize()
        VideoPlayerCtl3.UpdatePanelSize()
        VideoPlayerCtl4.UpdatePanelSize()
    End Sub

    Private Sub ReSizeVideoPanelsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReSizeVideoPanelsToolStripMenuItem.Click
        ReSizeVideoPanels()
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If Me.WindowState = FormWindowState.Maximized Or Me.WindowState = FormWindowState.Normal Then
            If AlwaysResizeVideoPanelsToolStripMenuItem.Checked Then
                ReSizeVideoPanels()
            End If
        End If
    End Sub

    Public Sub Merge2VideoView(ByVal ZoomRatio As Double)
        VideoPlayerCtl1.VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoPlayerCtl2.VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoPlayerCtl1.VideoInstance.Display.Mode = DisplayMode.Manual
        VideoPlayerCtl2.VideoInstance.Display.Mode = DisplayMode.Manual

        VideoPlayerCtl1.VideoInstance.Video.Zoom(ZoomRatio * ZoomRatio)
        VideoPlayerCtl2.VideoInstance.Video.Zoom(ZoomRatio * ZoomRatio)

        Dim divider As Double
        divider = 2 / ZoomRatio

        Dim newpos1 As New Point(Math.Round((VideoPlayerCtl1.VideoPanel.Width / divider) / ZoomRatio, 0), 0)
        Dim newpos2 As New Point(-Math.Round((VideoPlayerCtl2.VideoPanel.Width / divider) / ZoomRatio, 0), 0)

        VideoPlayerCtl1.VideoPanel.Location = newpos1
        VideoPlayerCtl2.VideoPanel.Location = newpos2
    End Sub

    Public Sub Merge4VideoView(ByVal ZoomRatio As Double)
        VideoPlayerCtl1.VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoPlayerCtl2.VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoPlayerCtl3.VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoPlayerCtl4.VideoInstance.Display.Mode = DisplayMode.ZoomCenter
        VideoPlayerCtl1.VideoInstance.Display.Mode = DisplayMode.Manual
        VideoPlayerCtl2.VideoInstance.Display.Mode = DisplayMode.Manual
        VideoPlayerCtl3.VideoInstance.Display.Mode = DisplayMode.Manual
        VideoPlayerCtl4.VideoInstance.Display.Mode = DisplayMode.Manual

        VideoPlayerCtl1.VideoInstance.Video.Zoom(ZoomRatio * ZoomRatio)
        VideoPlayerCtl2.VideoInstance.Video.Zoom(ZoomRatio * ZoomRatio)
        VideoPlayerCtl3.VideoInstance.Video.Zoom(ZoomRatio * ZoomRatio)
        VideoPlayerCtl4.VideoInstance.Video.Zoom(ZoomRatio * ZoomRatio)

        Dim newpos1 As New Point(Math.Round(VideoPlayerCtl1.VideoPanel.Width * 0.5, 0), Math.Round(VideoPlayerCtl1.VideoPanel.Height * 0.5, 0))
        Dim newpos2 As New Point(Math.Round(-VideoPlayerCtl2.VideoPanel.Width * 0.5, 0), Math.Round(VideoPlayerCtl2.VideoPanel.Height * 0.5, 0))
        Dim newpos3 As New Point(Math.Round(VideoPlayerCtl2.VideoPanel.Width * 0.5, 0), -Math.Round(VideoPlayerCtl2.VideoPanel.Height * 0.5, 0))
        Dim newpos4 As New Point(-Math.Round(VideoPlayerCtl2.VideoPanel.Width * 0.5, 0), -Math.Round(VideoPlayerCtl2.VideoPanel.Height * 0.5, 0))

        VideoPlayerCtl1.VideoPanel.Location = newpos1
        VideoPlayerCtl2.VideoPanel.Location = newpos2
        VideoPlayerCtl3.VideoPanel.Location = newpos3
        VideoPlayerCtl4.VideoPanel.Location = newpos4
    End Sub

    Private Sub SyncPositionsinvertedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SyncPositionsinvertedToolStripMenuItem.Click
        If SyncPositionsinvertedToolStripMenuItem.Checked Then
            SyncPositionsToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub SyncPositionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SyncPositionsToolStripMenuItem.Click
        If SyncPositionsToolStripMenuItem.Checked Then
            SyncPositionsinvertedToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub AutoSplitAlignment100ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoSplitAlignment100ToolStripMenuItem.Click
        SyncSizesToolStripMenuItem.Checked = False
        SyncZoomFactorToolStripMenuItem.Checked = False
        ShowAlignmentLinesToolStripMenuItem.Checked = False
        SetCompareMode(True)
        If X2ToolStripMenuItem1.Checked Then
            Merge2VideoView(1)
        Else
            Merge4VideoView(1)
        End If
    End Sub

    Private Sub AutoSplitAlignment150ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoSplitAlignment150ToolStripMenuItem.Click
        SyncSizesToolStripMenuItem.Checked = False
        SyncZoomFactorToolStripMenuItem.Checked = False
        ShowAlignmentLinesToolStripMenuItem.Checked = False
        SetCompareMode(True)
        If X2ToolStripMenuItem1.Checked Then
            Merge2VideoView(1)
            Merge2VideoView(1.5)
        Else
            Merge4VideoView(1)
            Merge4VideoView(1.5)
        End If
    End Sub
End Class
