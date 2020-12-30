<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.X2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MasterPlaybackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SyncPlaybackPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SyncSizesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SyncZoomFactorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SyncPositionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SyncPositionsinvertedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReZoomAfterChangeSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAlignmentLinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysResizeVideoPanelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReSizeVideoPanelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AutoSplitAlignment100ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoSplitAlignment150ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.VideoPlayerCtl1 = New SplitVideoPlayer.NET.VideoPlayerCtl()
        Me.VideoPlayerCtl3 = New SplitVideoPlayer.NET.VideoPlayerCtl()
        Me.VideoPlayerCtl2 = New SplitVideoPlayer.NET.VideoPlayerCtl()
        Me.VideoPlayerCtl4 = New SplitVideoPlayer.NET.VideoPlayerCtl()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TrackBar1)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 661)
        Me.SplitContainer1.SplitterDistance = 572
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(984, 572)
        Me.SplitContainer2.SplitterDistance = 492
        Me.SplitContainer2.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewModeToolStripMenuItem, Me.X2ToolStripMenuItem1, Me.X2ToolStripMenuItem, Me.ToolStripSeparator1, Me.MasterPlaybackToolStripMenuItem, Me.TopLeftToolStripMenuItem, Me.TopRightToolStripMenuItem, Me.BottomLeftToolStripMenuItem, Me.BottomRightToolStripMenuItem, Me.ToolStripSeparator2, Me.SyncPlaybackPositionToolStripMenuItem, Me.SyncSizesToolStripMenuItem, Me.SyncZoomFactorToolStripMenuItem, Me.ToolStripSeparator4, Me.SyncPositionsToolStripMenuItem, Me.SyncPositionsinvertedToolStripMenuItem, Me.ToolStripSeparator5, Me.ReZoomAfterChangeSizeToolStripMenuItem, Me.ShowAlignmentLinesToolStripMenuItem, Me.AlwaysResizeVideoPanelsToolStripMenuItem, Me.ReSizeVideoPanelsToolStripMenuItem, Me.ToolStripSeparator3, Me.AutoSplitAlignment100ToolStripMenuItem, Me.AutoSplitAlignment150ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(225, 452)
        '
        'ViewModeToolStripMenuItem
        '
        Me.ViewModeToolStripMenuItem.Enabled = False
        Me.ViewModeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewModeToolStripMenuItem.Name = "ViewModeToolStripMenuItem"
        Me.ViewModeToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ViewModeToolStripMenuItem.Text = "View mode"
        '
        'X2ToolStripMenuItem1
        '
        Me.X2ToolStripMenuItem1.Name = "X2ToolStripMenuItem1"
        Me.X2ToolStripMenuItem1.Size = New System.Drawing.Size(224, 22)
        Me.X2ToolStripMenuItem1.Text = "1x2 (Dual)"
        '
        'X2ToolStripMenuItem
        '
        Me.X2ToolStripMenuItem.Checked = True
        Me.X2ToolStripMenuItem.CheckOnClick = True
        Me.X2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.X2ToolStripMenuItem.Name = "X2ToolStripMenuItem"
        Me.X2ToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.X2ToolStripMenuItem.Text = "2x2 (Quad)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        'MasterPlaybackToolStripMenuItem
        '
        Me.MasterPlaybackToolStripMenuItem.Enabled = False
        Me.MasterPlaybackToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterPlaybackToolStripMenuItem.Name = "MasterPlaybackToolStripMenuItem"
        Me.MasterPlaybackToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.MasterPlaybackToolStripMenuItem.Text = "Master playback"
        '
        'TopLeftToolStripMenuItem
        '
        Me.TopLeftToolStripMenuItem.Checked = True
        Me.TopLeftToolStripMenuItem.CheckOnClick = True
        Me.TopLeftToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TopLeftToolStripMenuItem.Name = "TopLeftToolStripMenuItem"
        Me.TopLeftToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.TopLeftToolStripMenuItem.Text = "Top left"
        '
        'TopRightToolStripMenuItem
        '
        Me.TopRightToolStripMenuItem.CheckOnClick = True
        Me.TopRightToolStripMenuItem.Name = "TopRightToolStripMenuItem"
        Me.TopRightToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.TopRightToolStripMenuItem.Text = "Top right"
        '
        'BottomLeftToolStripMenuItem
        '
        Me.BottomLeftToolStripMenuItem.CheckOnClick = True
        Me.BottomLeftToolStripMenuItem.Name = "BottomLeftToolStripMenuItem"
        Me.BottomLeftToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.BottomLeftToolStripMenuItem.Text = "Bottom left"
        '
        'BottomRightToolStripMenuItem
        '
        Me.BottomRightToolStripMenuItem.CheckOnClick = True
        Me.BottomRightToolStripMenuItem.Name = "BottomRightToolStripMenuItem"
        Me.BottomRightToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.BottomRightToolStripMenuItem.Text = "Bottom right"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(221, 6)
        '
        'SyncPlaybackPositionToolStripMenuItem
        '
        Me.SyncPlaybackPositionToolStripMenuItem.Checked = True
        Me.SyncPlaybackPositionToolStripMenuItem.CheckOnClick = True
        Me.SyncPlaybackPositionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SyncPlaybackPositionToolStripMenuItem.Name = "SyncPlaybackPositionToolStripMenuItem"
        Me.SyncPlaybackPositionToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SyncPlaybackPositionToolStripMenuItem.Text = "Sync playback position"
        '
        'SyncSizesToolStripMenuItem
        '
        Me.SyncSizesToolStripMenuItem.Checked = True
        Me.SyncSizesToolStripMenuItem.CheckOnClick = True
        Me.SyncSizesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SyncSizesToolStripMenuItem.Name = "SyncSizesToolStripMenuItem"
        Me.SyncSizesToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SyncSizesToolStripMenuItem.Text = "Sync sizes"
        '
        'SyncZoomFactorToolStripMenuItem
        '
        Me.SyncZoomFactorToolStripMenuItem.Checked = True
        Me.SyncZoomFactorToolStripMenuItem.CheckOnClick = True
        Me.SyncZoomFactorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SyncZoomFactorToolStripMenuItem.Name = "SyncZoomFactorToolStripMenuItem"
        Me.SyncZoomFactorToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SyncZoomFactorToolStripMenuItem.Text = "Sync zoom factor"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(221, 6)
        '
        'SyncPositionsToolStripMenuItem
        '
        Me.SyncPositionsToolStripMenuItem.CheckOnClick = True
        Me.SyncPositionsToolStripMenuItem.Name = "SyncPositionsToolStripMenuItem"
        Me.SyncPositionsToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SyncPositionsToolStripMenuItem.Text = "Sync positions"
        '
        'SyncPositionsinvertedToolStripMenuItem
        '
        Me.SyncPositionsinvertedToolStripMenuItem.Checked = True
        Me.SyncPositionsinvertedToolStripMenuItem.CheckOnClick = True
        Me.SyncPositionsinvertedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SyncPositionsinvertedToolStripMenuItem.Name = "SyncPositionsinvertedToolStripMenuItem"
        Me.SyncPositionsinvertedToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SyncPositionsinvertedToolStripMenuItem.Text = "Sync positions (inverted)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(221, 6)
        '
        'ReZoomAfterChangeSizeToolStripMenuItem
        '
        Me.ReZoomAfterChangeSizeToolStripMenuItem.Checked = True
        Me.ReZoomAfterChangeSizeToolStripMenuItem.CheckOnClick = True
        Me.ReZoomAfterChangeSizeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ReZoomAfterChangeSizeToolStripMenuItem.Name = "ReZoomAfterChangeSizeToolStripMenuItem"
        Me.ReZoomAfterChangeSizeToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ReZoomAfterChangeSizeToolStripMenuItem.Text = "Re-Zoom after change size"
        '
        'ShowAlignmentLinesToolStripMenuItem
        '
        Me.ShowAlignmentLinesToolStripMenuItem.Checked = True
        Me.ShowAlignmentLinesToolStripMenuItem.CheckOnClick = True
        Me.ShowAlignmentLinesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowAlignmentLinesToolStripMenuItem.Name = "ShowAlignmentLinesToolStripMenuItem"
        Me.ShowAlignmentLinesToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ShowAlignmentLinesToolStripMenuItem.Text = "Show alignment lines"
        '
        'AlwaysResizeVideoPanelsToolStripMenuItem
        '
        Me.AlwaysResizeVideoPanelsToolStripMenuItem.Checked = True
        Me.AlwaysResizeVideoPanelsToolStripMenuItem.CheckOnClick = True
        Me.AlwaysResizeVideoPanelsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AlwaysResizeVideoPanelsToolStripMenuItem.Name = "AlwaysResizeVideoPanelsToolStripMenuItem"
        Me.AlwaysResizeVideoPanelsToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.AlwaysResizeVideoPanelsToolStripMenuItem.Text = "Always re-size video panels"
        '
        'ReSizeVideoPanelsToolStripMenuItem
        '
        Me.ReSizeVideoPanelsToolStripMenuItem.Name = "ReSizeVideoPanelsToolStripMenuItem"
        Me.ReSizeVideoPanelsToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ReSizeVideoPanelsToolStripMenuItem.Text = "Re-Size video panels"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(221, 6)
        '
        'AutoSplitAlignment100ToolStripMenuItem
        '
        Me.AutoSplitAlignment100ToolStripMenuItem.Name = "AutoSplitAlignment100ToolStripMenuItem"
        Me.AutoSplitAlignment100ToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.AutoSplitAlignment100ToolStripMenuItem.Text = "Auto-Split alignment (100%)"
        '
        'AutoSplitAlignment150ToolStripMenuItem
        '
        Me.AutoSplitAlignment150ToolStripMenuItem.Name = "AutoSplitAlignment150ToolStripMenuItem"
        Me.AutoSplitAlignment150ToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.AutoSplitAlignment150ToolStripMenuItem.Text = "Auto-Split alignment (150%)"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.VideoPlayerCtl1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.VideoPlayerCtl3)
        Me.SplitContainer3.Size = New System.Drawing.Size(492, 572)
        Me.SplitContainer3.SplitterDistance = 286
        Me.SplitContainer3.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.VideoPlayerCtl2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.VideoPlayerCtl4)
        Me.SplitContainer4.Size = New System.Drawing.Size(488, 572)
        Me.SplitContainer4.SplitterDistance = 286
        Me.SplitContainer4.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.TrackBar2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 38)
        Me.Panel1.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.dialog_information_3
        Me.Button6.Location = New System.Drawing.Point(822, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 32)
        Me.Button6.TabIndex = 10
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.folder_video1
        Me.Button3.Location = New System.Drawing.Point(3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 9
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ms"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(155, 9)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(101, 20)
        Me.NumericUpDown1.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.audio_volume_high_4
        Me.Button5.Location = New System.Drawing.Point(860, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 32)
        Me.Button5.TabIndex = 6
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TrackBar2
        '
        Me.TrackBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar2.Location = New System.Drawing.Point(898, 0)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(86, 45)
        Me.TrackBar2.TabIndex = 5
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar2.Value = 50
        '
        'Button4
        '
        Me.Button4.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.view_list_icon
        Me.Button4.Location = New System.Drawing.Point(41, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 32)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.media_playback_stop_7
        Me.Button2.Location = New System.Drawing.Point(117, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.media_playback_start_7
        Me.Button1.Location = New System.Drawing.Point(79, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TrackBar1.Location = New System.Drawing.Point(0, 40)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(984, 45)
        Me.TrackBar1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All video files|*.*"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.SupportMultiDottedExtensions = True
        '
        'VideoPlayerCtl1
        '
        Me.VideoPlayerCtl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.VideoPlayerCtl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoPlayerCtl1.InitFileNameAlignmentBottom = False
        Me.VideoPlayerCtl1.InitMute = False
        Me.VideoPlayerCtl1.Location = New System.Drawing.Point(0, 0)
        Me.VideoPlayerCtl1.Name = "VideoPlayerCtl1"
        Me.VideoPlayerCtl1.Size = New System.Drawing.Size(492, 286)
        Me.VideoPlayerCtl1.TabIndex = 0
        '
        'VideoPlayerCtl3
        '
        Me.VideoPlayerCtl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoPlayerCtl3.InitFileNameAlignmentBottom = True
        Me.VideoPlayerCtl3.InitMute = True
        Me.VideoPlayerCtl3.Location = New System.Drawing.Point(0, 0)
        Me.VideoPlayerCtl3.Name = "VideoPlayerCtl3"
        Me.VideoPlayerCtl3.Size = New System.Drawing.Size(492, 282)
        Me.VideoPlayerCtl3.TabIndex = 1
        '
        'VideoPlayerCtl2
        '
        Me.VideoPlayerCtl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoPlayerCtl2.InitFileNameAlignmentBottom = False
        Me.VideoPlayerCtl2.InitMute = True
        Me.VideoPlayerCtl2.Location = New System.Drawing.Point(0, 0)
        Me.VideoPlayerCtl2.Name = "VideoPlayerCtl2"
        Me.VideoPlayerCtl2.Size = New System.Drawing.Size(488, 286)
        Me.VideoPlayerCtl2.TabIndex = 1
        '
        'VideoPlayerCtl4
        '
        Me.VideoPlayerCtl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoPlayerCtl4.InitFileNameAlignmentBottom = True
        Me.VideoPlayerCtl4.InitMute = True
        Me.VideoPlayerCtl4.Location = New System.Drawing.Point(0, 0)
        Me.VideoPlayerCtl4.Name = "VideoPlayerCtl4"
        Me.VideoPlayerCtl4.Size = New System.Drawing.Size(488, 282)
        Me.VideoPlayerCtl4.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplitVideoPlayer.NET"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents VideoPlayerCtl1 As VideoPlayerCtl
    Friend WithEvents VideoPlayerCtl3 As VideoPlayerCtl
    Friend WithEvents VideoPlayerCtl2 As VideoPlayerCtl
    Friend WithEvents VideoPlayerCtl4 As VideoPlayerCtl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TopLeftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TopRightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BottomLeftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BottomRightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents X2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Button5 As Button
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SyncSizesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterPlaybackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents ReZoomAfterChangeSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowAlignmentLinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button6 As Button
    Friend WithEvents ReSizeVideoPanelsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlwaysResizeVideoPanelsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SyncPositionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SyncPositionsinvertedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents SyncZoomFactorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SyncPlaybackPositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoSplitAlignment100ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoSplitAlignment150ToolStripMenuItem As ToolStripMenuItem
End Class
