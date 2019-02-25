<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OFUser = New System.Windows.Forms.OpenFileDialog()
        Me.SFUser = New System.Windows.Forms.SaveFileDialog()
        Me.gbStart = New System.Windows.Forms.GroupBox()
        Me.btnRanGen = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNewMap = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.gbTools = New System.Windows.Forms.GroupBox()
        Me.btnChangeBackground = New System.Windows.Forms.Button()
        Me.lblPlaCount = New System.Windows.Forms.Label()
        Me.lblPlaWidText = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.nudRad = New System.Windows.Forms.NumericUpDown()
        Me.btnSpawns = New System.Windows.Forms.Button()
        Me.gbPlayerSpawns = New System.Windows.Forms.GroupBox()
        Me.rbP4S = New System.Windows.Forms.RadioButton()
        Me.rbP3S = New System.Windows.Forms.RadioButton()
        Me.rbP2S = New System.Windows.Forms.RadioButton()
        Me.rbP1S = New System.Windows.Forms.RadioButton()
        Me.btnShields = New System.Windows.Forms.Button()
        Me.btnConnections = New System.Windows.Forms.Button()
        Me.btnPlanetos = New System.Windows.Forms.Button()
        Me.cbSymSelect = New System.Windows.Forms.ComboBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.OFPic = New System.Windows.Forms.OpenFileDialog()
        Me.gbImageStyle = New System.Windows.Forms.GroupBox()
        Me.btnNone = New System.Windows.Forms.Button()
        Me.btnZoom = New System.Windows.Forms.Button()
        Me.btnCenter = New System.Windows.Forms.Button()
        Me.btnStretch = New System.Windows.Forms.Button()
        Me.btnTile = New System.Windows.Forms.Button()
        Me.VSclBar = New System.Windows.Forms.VScrollBar()
        Me.HSclBar = New System.Windows.Forms.HScrollBar()
        Me.gbStart.SuspendLayout()
        Me.gbTools.SuspendLayout()
        CType(Me.nudRad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPlayerSpawns.SuspendLayout()
        Me.gbImageStyle.SuspendLayout()
        Me.SuspendLayout()
        '
        'OFUser
        '
        Me.OFUser.Filter = "ClickCon Map File|*.cmap"
        '
        'SFUser
        '
        Me.SFUser.DefaultExt = "cmap"
        Me.SFUser.Filter = "ClickCon Map File|*.cmap"
        '
        'gbStart
        '
        Me.gbStart.Controls.Add(Me.btnRanGen)
        Me.gbStart.Controls.Add(Me.btnClose)
        Me.gbStart.Controls.Add(Me.btnNewMap)
        Me.gbStart.Controls.Add(Me.btnOpen)
        Me.gbStart.Location = New System.Drawing.Point(500, 111)
        Me.gbStart.Name = "gbStart"
        Me.gbStart.Size = New System.Drawing.Size(244, 350)
        Me.gbStart.TabIndex = 0
        Me.gbStart.TabStop = False
        '
        'btnRanGen
        '
        Me.btnRanGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRanGen.Location = New System.Drawing.Point(37, 107)
        Me.btnRanGen.Name = "btnRanGen"
        Me.btnRanGen.Size = New System.Drawing.Size(174, 56)
        Me.btnRanGen.TabIndex = 3
        Me.btnRanGen.Text = "Create Random Gen Map"
        Me.btnRanGen.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(37, 270)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(174, 42)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close Editor"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNewMap
        '
        Me.btnNewMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMap.Location = New System.Drawing.Point(37, 36)
        Me.btnNewMap.Name = "btnNewMap"
        Me.btnNewMap.Size = New System.Drawing.Size(174, 42)
        Me.btnNewMap.TabIndex = 1
        Me.btnNewMap.Text = "Create New Map"
        Me.btnNewMap.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.Location = New System.Drawing.Point(37, 193)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(174, 42)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Import Map"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'gbTools
        '
        Me.gbTools.Controls.Add(Me.btnChangeBackground)
        Me.gbTools.Controls.Add(Me.lblPlaCount)
        Me.gbTools.Controls.Add(Me.lblPlaWidText)
        Me.gbTools.Controls.Add(Me.btnSave)
        Me.gbTools.Controls.Add(Me.nudRad)
        Me.gbTools.Controls.Add(Me.btnSpawns)
        Me.gbTools.Controls.Add(Me.gbPlayerSpawns)
        Me.gbTools.Controls.Add(Me.btnShields)
        Me.gbTools.Controls.Add(Me.btnConnections)
        Me.gbTools.Controls.Add(Me.btnPlanetos)
        Me.gbTools.Controls.Add(Me.cbSymSelect)
        Me.gbTools.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbTools.Enabled = False
        Me.gbTools.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTools.ForeColor = System.Drawing.Color.White
        Me.gbTools.Location = New System.Drawing.Point(988, 0)
        Me.gbTools.Name = "gbTools"
        Me.gbTools.Size = New System.Drawing.Size(246, 711)
        Me.gbTools.TabIndex = 1
        Me.gbTools.TabStop = False
        Me.gbTools.Text = "Tools"
        '
        'btnChangeBackground
        '
        Me.btnChangeBackground.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeBackground.ForeColor = System.Drawing.Color.Black
        Me.btnChangeBackground.Location = New System.Drawing.Point(20, 547)
        Me.btnChangeBackground.Name = "btnChangeBackground"
        Me.btnChangeBackground.Size = New System.Drawing.Size(206, 42)
        Me.btnChangeBackground.TabIndex = 12
        Me.btnChangeBackground.Text = "Add Background"
        Me.btnChangeBackground.UseVisualStyleBackColor = True
        '
        'lblPlaCount
        '
        Me.lblPlaCount.AutoSize = True
        Me.lblPlaCount.Location = New System.Drawing.Point(16, 509)
        Me.lblPlaCount.Name = "lblPlaCount"
        Me.lblPlaCount.Size = New System.Drawing.Size(154, 20)
        Me.lblPlaCount.TabIndex = 11
        Me.lblPlaCount.Text = "Planeto Count - 0 "
        '
        'lblPlaWidText
        '
        Me.lblPlaWidText.AutoSize = True
        Me.lblPlaWidText.Location = New System.Drawing.Point(24, 134)
        Me.lblPlaWidText.Name = "lblPlaWidText"
        Me.lblPlaWidText.Size = New System.Drawing.Size(121, 20)
        Me.lblPlaWidText.TabIndex = 10
        Me.lblPlaWidText.Text = "Planeto Width"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(20, 612)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(206, 42)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'nudRad
        '
        Me.nudRad.Location = New System.Drawing.Point(163, 132)
        Me.nudRad.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudRad.Name = "nudRad"
        Me.nudRad.Size = New System.Drawing.Size(54, 26)
        Me.nudRad.TabIndex = 9
        Me.nudRad.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'btnSpawns
        '
        Me.btnSpawns.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpawns.ForeColor = System.Drawing.Color.Black
        Me.btnSpawns.Location = New System.Drawing.Point(20, 311)
        Me.btnSpawns.Name = "btnSpawns"
        Me.btnSpawns.Size = New System.Drawing.Size(206, 42)
        Me.btnSpawns.TabIndex = 7
        Me.btnSpawns.Text = "Edit Spawns"
        Me.btnSpawns.UseVisualStyleBackColor = True
        '
        'gbPlayerSpawns
        '
        Me.gbPlayerSpawns.Controls.Add(Me.rbP4S)
        Me.gbPlayerSpawns.Controls.Add(Me.rbP3S)
        Me.gbPlayerSpawns.Controls.Add(Me.rbP2S)
        Me.gbPlayerSpawns.Controls.Add(Me.rbP1S)
        Me.gbPlayerSpawns.Enabled = False
        Me.gbPlayerSpawns.ForeColor = System.Drawing.Color.White
        Me.gbPlayerSpawns.Location = New System.Drawing.Point(20, 373)
        Me.gbPlayerSpawns.Name = "gbPlayerSpawns"
        Me.gbPlayerSpawns.Size = New System.Drawing.Size(206, 112)
        Me.gbPlayerSpawns.TabIndex = 6
        Me.gbPlayerSpawns.TabStop = False
        Me.gbPlayerSpawns.Text = "Spawns"
        '
        'rbP4S
        '
        Me.rbP4S.AutoSize = True
        Me.rbP4S.BackColor = System.Drawing.Color.Transparent
        Me.rbP4S.ForeColor = System.Drawing.Color.Yellow
        Me.rbP4S.Location = New System.Drawing.Point(125, 64)
        Me.rbP4S.Name = "rbP4S"
        Me.rbP4S.Size = New System.Drawing.Size(48, 24)
        Me.rbP4S.TabIndex = 3
        Me.rbP4S.Text = "P4"
        Me.rbP4S.UseVisualStyleBackColor = False
        '
        'rbP3S
        '
        Me.rbP3S.AutoSize = True
        Me.rbP3S.BackColor = System.Drawing.Color.Transparent
        Me.rbP3S.ForeColor = System.Drawing.Color.Lime
        Me.rbP3S.Location = New System.Drawing.Point(17, 64)
        Me.rbP3S.Name = "rbP3S"
        Me.rbP3S.Size = New System.Drawing.Size(48, 24)
        Me.rbP3S.TabIndex = 2
        Me.rbP3S.Text = "P3"
        Me.rbP3S.UseVisualStyleBackColor = False
        '
        'rbP2S
        '
        Me.rbP2S.AutoSize = True
        Me.rbP2S.BackColor = System.Drawing.Color.Transparent
        Me.rbP2S.ForeColor = System.Drawing.Color.Blue
        Me.rbP2S.Location = New System.Drawing.Point(125, 33)
        Me.rbP2S.Name = "rbP2S"
        Me.rbP2S.Size = New System.Drawing.Size(48, 24)
        Me.rbP2S.TabIndex = 1
        Me.rbP2S.Text = "P2"
        Me.rbP2S.UseVisualStyleBackColor = False
        '
        'rbP1S
        '
        Me.rbP1S.AutoSize = True
        Me.rbP1S.BackColor = System.Drawing.Color.Transparent
        Me.rbP1S.Checked = True
        Me.rbP1S.ForeColor = System.Drawing.Color.Red
        Me.rbP1S.Location = New System.Drawing.Point(17, 33)
        Me.rbP1S.Name = "rbP1S"
        Me.rbP1S.Size = New System.Drawing.Size(48, 24)
        Me.rbP1S.TabIndex = 0
        Me.rbP1S.TabStop = True
        Me.rbP1S.Text = "P1"
        Me.rbP1S.UseVisualStyleBackColor = False
        '
        'btnShields
        '
        Me.btnShields.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShields.ForeColor = System.Drawing.Color.Black
        Me.btnShields.Location = New System.Drawing.Point(20, 241)
        Me.btnShields.Name = "btnShields"
        Me.btnShields.Size = New System.Drawing.Size(206, 42)
        Me.btnShields.TabIndex = 5
        Me.btnShields.Text = "Edit Shields"
        Me.btnShields.UseVisualStyleBackColor = True
        '
        'btnConnections
        '
        Me.btnConnections.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnections.ForeColor = System.Drawing.Color.Black
        Me.btnConnections.Location = New System.Drawing.Point(20, 173)
        Me.btnConnections.Name = "btnConnections"
        Me.btnConnections.Size = New System.Drawing.Size(206, 42)
        Me.btnConnections.TabIndex = 4
        Me.btnConnections.Text = "Edit Connections"
        Me.btnConnections.UseVisualStyleBackColor = True
        '
        'btnPlanetos
        '
        Me.btnPlanetos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlanetos.ForeColor = System.Drawing.Color.Black
        Me.btnPlanetos.Location = New System.Drawing.Point(20, 30)
        Me.btnPlanetos.Name = "btnPlanetos"
        Me.btnPlanetos.Size = New System.Drawing.Size(206, 42)
        Me.btnPlanetos.TabIndex = 3
        Me.btnPlanetos.Text = "Edit Planetos"
        Me.btnPlanetos.UseVisualStyleBackColor = True
        '
        'cbSymSelect
        '
        Me.cbSymSelect.FormattingEnabled = True
        Me.cbSymSelect.Items.AddRange(New Object() {"None", "Two-way Mirrored (Horizontal)", "Two-way Mirrored (Vertical)", "Two-way Mirrored (Diagonal)", "Four-way Mirrored"})
        Me.cbSymSelect.Location = New System.Drawing.Point(20, 89)
        Me.cbSymSelect.Name = "cbSymSelect"
        Me.cbSymSelect.Size = New System.Drawing.Size(206, 28)
        Me.cbSymSelect.TabIndex = 13
        Me.cbSymSelect.Text = "None"
        '
        'btnMenu
        '
        Me.btnMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMenu.Location = New System.Drawing.Point(1, 1)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(26, 21)
        Me.btnMenu.TabIndex = 17
        Me.btnMenu.Text = "X"
        Me.btnMenu.UseVisualStyleBackColor = True
        Me.btnMenu.Visible = False
        '
        'OFPic
        '
        Me.OFPic.Filter = "png files|*.png|jpeg files|*.jpg|gif files|*.gif|tif files|*.tif"
        '
        'gbImageStyle
        '
        Me.gbImageStyle.Controls.Add(Me.btnNone)
        Me.gbImageStyle.Controls.Add(Me.btnZoom)
        Me.gbImageStyle.Controls.Add(Me.btnCenter)
        Me.gbImageStyle.Controls.Add(Me.btnStretch)
        Me.gbImageStyle.Controls.Add(Me.btnTile)
        Me.gbImageStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbImageStyle.ForeColor = System.Drawing.Color.White
        Me.gbImageStyle.Location = New System.Drawing.Point(500, 80)
        Me.gbImageStyle.Name = "gbImageStyle"
        Me.gbImageStyle.Size = New System.Drawing.Size(244, 381)
        Me.gbImageStyle.TabIndex = 3
        Me.gbImageStyle.TabStop = False
        Me.gbImageStyle.Text = "Image Layout"
        Me.gbImageStyle.Visible = False
        '
        'btnNone
        '
        Me.btnNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNone.ForeColor = System.Drawing.Color.Black
        Me.btnNone.Location = New System.Drawing.Point(37, 302)
        Me.btnNone.Name = "btnNone"
        Me.btnNone.Size = New System.Drawing.Size(174, 42)
        Me.btnNone.TabIndex = 4
        Me.btnNone.Text = "None"
        Me.btnNone.UseVisualStyleBackColor = True
        '
        'btnZoom
        '
        Me.btnZoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoom.ForeColor = System.Drawing.Color.Black
        Me.btnZoom.Location = New System.Drawing.Point(37, 233)
        Me.btnZoom.Name = "btnZoom"
        Me.btnZoom.Size = New System.Drawing.Size(174, 42)
        Me.btnZoom.TabIndex = 3
        Me.btnZoom.Text = "Zoom"
        Me.btnZoom.UseVisualStyleBackColor = True
        '
        'btnCenter
        '
        Me.btnCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCenter.ForeColor = System.Drawing.Color.Black
        Me.btnCenter.Location = New System.Drawing.Point(37, 167)
        Me.btnCenter.Name = "btnCenter"
        Me.btnCenter.Size = New System.Drawing.Size(174, 42)
        Me.btnCenter.TabIndex = 2
        Me.btnCenter.Text = "Center"
        Me.btnCenter.UseVisualStyleBackColor = True
        '
        'btnStretch
        '
        Me.btnStretch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStretch.ForeColor = System.Drawing.Color.Black
        Me.btnStretch.Location = New System.Drawing.Point(37, 36)
        Me.btnStretch.Name = "btnStretch"
        Me.btnStretch.Size = New System.Drawing.Size(174, 42)
        Me.btnStretch.TabIndex = 1
        Me.btnStretch.Text = "Stretch"
        Me.btnStretch.UseVisualStyleBackColor = True
        '
        'btnTile
        '
        Me.btnTile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTile.ForeColor = System.Drawing.Color.Black
        Me.btnTile.Location = New System.Drawing.Point(37, 102)
        Me.btnTile.Name = "btnTile"
        Me.btnTile.Size = New System.Drawing.Size(174, 42)
        Me.btnTile.TabIndex = 0
        Me.btnTile.Text = "Tile"
        Me.btnTile.UseVisualStyleBackColor = True
        '
        'VSclBar
        '
        Me.VSclBar.Dock = System.Windows.Forms.DockStyle.Right
        Me.VSclBar.Location = New System.Drawing.Point(971, 0)
        Me.VSclBar.Name = "VSclBar"
        Me.VSclBar.Size = New System.Drawing.Size(17, 711)
        Me.VSclBar.TabIndex = 18
        Me.VSclBar.Visible = False
        '
        'HSclBar
        '
        Me.HSclBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HSclBar.Location = New System.Drawing.Point(0, 694)
        Me.HSclBar.Name = "HSclBar"
        Me.HSclBar.Size = New System.Drawing.Size(971, 17)
        Me.HSclBar.TabIndex = 19
        Me.HSclBar.Visible = False
        '
        'MapEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1234, 711)
        Me.Controls.Add(Me.HSclBar)
        Me.Controls.Add(Me.VSclBar)
        Me.Controls.Add(Me.gbImageStyle)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.gbTools)
        Me.Controls.Add(Me.gbStart)
        Me.Name = "MapEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Map Editor"
        Me.gbStart.ResumeLayout(False)
        Me.gbTools.ResumeLayout(False)
        Me.gbTools.PerformLayout()
        CType(Me.nudRad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPlayerSpawns.ResumeLayout(False)
        Me.gbPlayerSpawns.PerformLayout()
        Me.gbImageStyle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OFUser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFUser As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gbStart As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNewMap As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents gbTools As System.Windows.Forms.GroupBox
    Friend WithEvents btnPlanetos As System.Windows.Forms.Button
    Friend WithEvents btnConnections As System.Windows.Forms.Button
    Friend WithEvents btnShields As System.Windows.Forms.Button
    Friend WithEvents gbPlayerSpawns As System.Windows.Forms.GroupBox
    Friend WithEvents rbP4S As System.Windows.Forms.RadioButton
    Friend WithEvents rbP3S As System.Windows.Forms.RadioButton
    Friend WithEvents rbP2S As System.Windows.Forms.RadioButton
    Friend WithEvents rbP1S As System.Windows.Forms.RadioButton
    Friend WithEvents btnSpawns As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblPlaWidText As System.Windows.Forms.Label
    Friend WithEvents nudRad As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPlaCount As System.Windows.Forms.Label
    Friend WithEvents btnChangeBackground As System.Windows.Forms.Button
    Friend WithEvents OFPic As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbImageStyle As System.Windows.Forms.GroupBox
    Friend WithEvents btnCenter As System.Windows.Forms.Button
    Friend WithEvents btnStretch As System.Windows.Forms.Button
    Friend WithEvents btnTile As System.Windows.Forms.Button
    Friend WithEvents btnNone As System.Windows.Forms.Button
    Friend WithEvents btnZoom As System.Windows.Forms.Button
    Friend WithEvents cbSymSelect As System.Windows.Forms.ComboBox
    Friend WithEvents btnRanGen As System.Windows.Forms.Button
    Friend WithEvents VSclBar As System.Windows.Forms.VScrollBar
    Friend WithEvents HSclBar As System.Windows.Forms.HScrollBar
End Class
