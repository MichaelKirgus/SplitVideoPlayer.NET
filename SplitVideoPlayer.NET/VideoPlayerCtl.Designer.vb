<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VideoPlayerCtl
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.PanelVideoContext1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowFilenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.StretchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.VideoFileName = New System.Windows.Forms.Label()
        Me.LoadVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnloadVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoPanel = New System.Windows.Forms.Panel()
        Me.PanelVideoContext1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelVideoContext1
        '
        Me.PanelVideoContext1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadVideoToolStripMenuItem, Me.UnloadVideoToolStripMenuItem, Me.ToolStripSeparator1, Me.PlayToolStripMenuItem, Me.PauseToolStripMenuItem, Me.StopToolStripMenuItem, Me.ToolStripSeparator2, Me.MuteToolStripMenuItem, Me.ShowFilenameToolStripMenuItem, Me.ToolStripSeparator3, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem2, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12, Me.ToolStripMenuItem13, Me.ToolStripSeparator4, Me.StretchToolStripMenuItem, Me.ResetViewToolStripMenuItem})
        Me.PanelVideoContext1.Name = "PanelVideoContext1"
        Me.PanelVideoContext1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.PanelVideoContext1.Size = New System.Drawing.Size(153, 490)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'MuteToolStripMenuItem
        '
        Me.MuteToolStripMenuItem.Checked = True
        Me.MuteToolStripMenuItem.CheckOnClick = True
        Me.MuteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MuteToolStripMenuItem.Name = "MuteToolStripMenuItem"
        Me.MuteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MuteToolStripMenuItem.Text = "Mute"
        '
        'ShowFilenameToolStripMenuItem
        '
        Me.ShowFilenameToolStripMenuItem.Checked = True
        Me.ShowFilenameToolStripMenuItem.CheckOnClick = True
        Me.ShowFilenameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowFilenameToolStripMenuItem.Name = "ShowFilenameToolStripMenuItem"
        Me.ShowFilenameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShowFilenameToolStripMenuItem.Text = "Show filename"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "25%"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem4.Text = "50%"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem5.Text = "75%"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "100%"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem6.Text = "125%"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem7.Text = "150%"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem8.Text = "175%"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem9.Text = "200%"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem10.Text = "250%"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem11.Text = "300%"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem12.Text = "350%"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem13.Text = "400%"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'StretchToolStripMenuItem
        '
        Me.StretchToolStripMenuItem.Name = "StretchToolStripMenuItem"
        Me.StretchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StretchToolStripMenuItem.Text = "Stretch"
        '
        'ResetViewToolStripMenuItem
        '
        Me.ResetViewToolStripMenuItem.Name = "ResetViewToolStripMenuItem"
        Me.ResetViewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetViewToolStripMenuItem.Text = "Reset view"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All files|*.*"
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.SupportMultiDottedExtensions = True
        '
        'VideoFileName
        '
        Me.VideoFileName.AutoEllipsis = True
        Me.VideoFileName.AutoSize = True
        Me.VideoFileName.BackColor = System.Drawing.SystemColors.Info
        Me.VideoFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VideoFileName.ContextMenuStrip = Me.PanelVideoContext1
        Me.VideoFileName.Dock = System.Windows.Forms.DockStyle.Top
        Me.VideoFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoFileName.Location = New System.Drawing.Point(0, 0)
        Me.VideoFileName.Name = "VideoFileName"
        Me.VideoFileName.Size = New System.Drawing.Size(209, 18)
        Me.VideoFileName.TabIndex = 0
        Me.VideoFileName.Text = "Load video file via context menu..."
        '
        'LoadVideoToolStripMenuItem
        '
        Me.LoadVideoToolStripMenuItem.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.document_open_folder
        Me.LoadVideoToolStripMenuItem.Name = "LoadVideoToolStripMenuItem"
        Me.LoadVideoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadVideoToolStripMenuItem.Text = "Load video..."
        '
        'UnloadVideoToolStripMenuItem
        '
        Me.UnloadVideoToolStripMenuItem.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.transform_rotate_2
        Me.UnloadVideoToolStripMenuItem.Name = "UnloadVideoToolStripMenuItem"
        Me.UnloadVideoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UnloadVideoToolStripMenuItem.Text = "Unload video"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.media_playback_start_71
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.media_playback_pause_71
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Image = Global.SplitVideoPlayer.NET.My.Resources.Resources.media_playback_stop_71
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'VideoPanel
        '
        Me.VideoPanel.BackColor = System.Drawing.Color.Black
        Me.VideoPanel.BackgroundImage = Global.SplitVideoPlayer.NET.My.Resources.Resources.folder_video
        Me.VideoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VideoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VideoPanel.ContextMenuStrip = Me.PanelVideoContext1
        Me.VideoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoPanel.Location = New System.Drawing.Point(0, 0)
        Me.VideoPanel.Name = "VideoPanel"
        Me.VideoPanel.Size = New System.Drawing.Size(413, 256)
        Me.VideoPanel.TabIndex = 0
        '
        'VideoPlayerCtl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ContextMenuStrip = Me.PanelVideoContext1
        Me.Controls.Add(Me.VideoFileName)
        Me.Controls.Add(Me.VideoPanel)
        Me.Name = "VideoPlayerCtl"
        Me.Size = New System.Drawing.Size(413, 256)
        Me.PanelVideoContext1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VideoPanel As Panel
    Friend WithEvents PanelVideoContext1 As ContextMenuStrip
    Friend WithEvents LoadVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnloadVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MuteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideoFileName As Label
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents StretchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ResetViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowFilenameToolStripMenuItem As ToolStripMenuItem
End Class
