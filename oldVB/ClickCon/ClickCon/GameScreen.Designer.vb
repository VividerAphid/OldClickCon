<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameScreen
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.nudPCount = New System.Windows.Forms.NumericUpDown()
        Me.lblPlayNum = New System.Windows.Forms.Label()
        Me.txtP1 = New System.Windows.Forms.TextBox()
        Me.txtP2 = New System.Windows.Forms.TextBox()
        Me.txtP3 = New System.Windows.Forms.TextBox()
        Me.txtP4 = New System.Windows.Forms.TextBox()
        Me.btnP1Col = New System.Windows.Forms.Button()
        Me.btnP2Col = New System.Windows.Forms.Button()
        Me.btnP3Col = New System.Windows.Forms.Button()
        Me.btnP4Col = New System.Windows.Forms.Button()
        Me.colDia = New System.Windows.Forms.ColorDialog()
        Me.gbStats = New System.Windows.Forms.GroupBox()
        Me.btnSurrender = New System.Windows.Forms.Button()
        Me.lblMoves = New System.Windows.Forms.Label()
        Me.lblRound = New System.Windows.Forms.Label()
        Me.lblCurrPlay = New System.Windows.Forms.Label()
        Me.btnEndTurn = New System.Windows.Forms.Button()
        Me.lblP4Sc = New System.Windows.Forms.Label()
        Me.lblP3Sc = New System.Windows.Forms.Label()
        Me.lblP2Sc = New System.Windows.Forms.Label()
        Me.lblP1Sc = New System.Windows.Forms.Label()
        Me.lblP4Ti = New System.Windows.Forms.Label()
        Me.lblP3Ti = New System.Windows.Forms.Label()
        Me.lblP2Ti = New System.Windows.Forms.Label()
        Me.lblP1Ti = New System.Windows.Forms.Label()
        Me.lblRounNum = New System.Windows.Forms.Label()
        Me.nudRounNum = New System.Windows.Forms.NumericUpDown()
        Me.cbMapPick = New System.Windows.Forms.ComboBox()
        Me.gbGameSets = New System.Windows.Forms.GroupBox()
        Me.gbAdvSets = New System.Windows.Forms.GroupBox()
        Me.chkRoadBlocks = New System.Windows.Forms.CheckBox()
        Me.chkStartShields = New System.Windows.Forms.CheckBox()
        Me.chkLockMode = New System.Windows.Forms.CheckBox()
        Me.btnAdvSetsDone = New System.Windows.Forms.Button()
        Me.chkHideScores = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbRanNum = New System.Windows.Forms.ComboBox()
        Me.rbRand = New System.Windows.Forms.RadioButton()
        Me.rbChosen = New System.Windows.Forms.RadioButton()
        Me.rbPreSet = New System.Windows.Forms.RadioButton()
        Me.btnAdvSets = New System.Windows.Forms.Button()
        Me.cbBot4 = New System.Windows.Forms.ComboBox()
        Me.cbBot3 = New System.Windows.Forms.ComboBox()
        Me.cbBot2 = New System.Windows.Forms.ComboBox()
        Me.cbBot1 = New System.Windows.Forms.ComboBox()
        Me.chkP4Bot = New System.Windows.Forms.CheckBox()
        Me.chkP3Bot = New System.Windows.Forms.CheckBox()
        Me.chkP2Bot = New System.Windows.Forms.CheckBox()
        Me.chkP1Bot = New System.Windows.Forms.CheckBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.gbGameOver = New System.Windows.Forms.GroupBox()
        Me.btnNope = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.lblEndGameText = New System.Windows.Forms.Label()
        Me.lblWinnerText = New System.Windows.Forms.Label()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnCloseGame = New System.Windows.Forms.Button()
        Me.gbPauseMenu = New System.Windows.Forms.GroupBox()
        Me.gbStartMenu = New System.Windows.Forms.GroupBox()
        Me.btnLeaveGame = New System.Windows.Forms.Button()
        Me.btnCreateMap = New System.Windows.Forms.Button()
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.btnTutorial = New System.Windows.Forms.Button()
        Me.OFUser = New System.Windows.Forms.OpenFileDialog()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.VSclBar = New System.Windows.Forms.VScrollBar()
        Me.HSclBar = New System.Windows.Forms.HScrollBar()
        CType(Me.nudPCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStats.SuspendLayout()
        CType(Me.nudRounNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGameSets.SuspendLayout()
        Me.gbAdvSets.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbGameOver.SuspendLayout()
        Me.gbPauseMenu.SuspendLayout()
        Me.gbStartMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.DimGray
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(139, 449)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(225, 79)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'nudPCount
        '
        Me.nudPCount.BackColor = System.Drawing.Color.DimGray
        Me.nudPCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPCount.Location = New System.Drawing.Point(314, 83)
        Me.nudPCount.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudPCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudPCount.Name = "nudPCount"
        Me.nudPCount.Size = New System.Drawing.Size(50, 26)
        Me.nudPCount.TabIndex = 15
        Me.nudPCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblPlayNum
        '
        Me.lblPlayNum.AutoSize = True
        Me.lblPlayNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayNum.ForeColor = System.Drawing.Color.White
        Me.lblPlayNum.Location = New System.Drawing.Point(135, 85)
        Me.lblPlayNum.Name = "lblPlayNum"
        Me.lblPlayNum.Size = New System.Drawing.Size(155, 20)
        Me.lblPlayNum.TabIndex = 2
        Me.lblPlayNum.Text = "Number of Players"
        '
        'txtP1
        '
        Me.txtP1.BackColor = System.Drawing.Color.DimGray
        Me.txtP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP1.ForeColor = System.Drawing.Color.DarkRed
        Me.txtP1.Location = New System.Drawing.Point(31, 240)
        Me.txtP1.MaxLength = 12
        Me.txtP1.Name = "txtP1"
        Me.txtP1.Size = New System.Drawing.Size(151, 20)
        Me.txtP1.TabIndex = 3
        Me.txtP1.Text = "Player 1"
        '
        'txtP2
        '
        Me.txtP2.BackColor = System.Drawing.Color.DimGray
        Me.txtP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtP2.Location = New System.Drawing.Point(31, 291)
        Me.txtP2.MaxLength = 12
        Me.txtP2.Name = "txtP2"
        Me.txtP2.Size = New System.Drawing.Size(151, 20)
        Me.txtP2.TabIndex = 4
        Me.txtP2.Text = "Player 2"
        '
        'txtP3
        '
        Me.txtP3.BackColor = System.Drawing.Color.DimGray
        Me.txtP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP3.ForeColor = System.Drawing.Color.Green
        Me.txtP3.Location = New System.Drawing.Point(31, 347)
        Me.txtP3.MaxLength = 12
        Me.txtP3.Name = "txtP3"
        Me.txtP3.Size = New System.Drawing.Size(151, 20)
        Me.txtP3.TabIndex = 5
        Me.txtP3.Text = "Player 3"
        '
        'txtP4
        '
        Me.txtP4.BackColor = System.Drawing.Color.DimGray
        Me.txtP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtP4.Location = New System.Drawing.Point(31, 402)
        Me.txtP4.MaxLength = 12
        Me.txtP4.Name = "txtP4"
        Me.txtP4.Size = New System.Drawing.Size(151, 20)
        Me.txtP4.TabIndex = 6
        Me.txtP4.Text = "Player 4"
        '
        'btnP1Col
        '
        Me.btnP1Col.BackColor = System.Drawing.Color.DarkRed
        Me.btnP1Col.Location = New System.Drawing.Point(206, 237)
        Me.btnP1Col.Name = "btnP1Col"
        Me.btnP1Col.Size = New System.Drawing.Size(50, 23)
        Me.btnP1Col.TabIndex = 7
        Me.btnP1Col.UseVisualStyleBackColor = False
        '
        'btnP2Col
        '
        Me.btnP2Col.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnP2Col.Location = New System.Drawing.Point(206, 291)
        Me.btnP2Col.Name = "btnP2Col"
        Me.btnP2Col.Size = New System.Drawing.Size(50, 23)
        Me.btnP2Col.TabIndex = 8
        Me.btnP2Col.UseVisualStyleBackColor = False
        '
        'btnP3Col
        '
        Me.btnP3Col.BackColor = System.Drawing.Color.Green
        Me.btnP3Col.Location = New System.Drawing.Point(206, 344)
        Me.btnP3Col.Name = "btnP3Col"
        Me.btnP3Col.Size = New System.Drawing.Size(50, 23)
        Me.btnP3Col.TabIndex = 9
        Me.btnP3Col.UseVisualStyleBackColor = False
        '
        'btnP4Col
        '
        Me.btnP4Col.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnP4Col.Location = New System.Drawing.Point(206, 399)
        Me.btnP4Col.Name = "btnP4Col"
        Me.btnP4Col.Size = New System.Drawing.Size(50, 23)
        Me.btnP4Col.TabIndex = 10
        Me.btnP4Col.UseVisualStyleBackColor = False
        '
        'gbStats
        '
        Me.gbStats.Controls.Add(Me.btnSurrender)
        Me.gbStats.Controls.Add(Me.lblMoves)
        Me.gbStats.Controls.Add(Me.lblRound)
        Me.gbStats.Controls.Add(Me.lblCurrPlay)
        Me.gbStats.Controls.Add(Me.btnEndTurn)
        Me.gbStats.Controls.Add(Me.lblP4Sc)
        Me.gbStats.Controls.Add(Me.lblP3Sc)
        Me.gbStats.Controls.Add(Me.lblP2Sc)
        Me.gbStats.Controls.Add(Me.lblP1Sc)
        Me.gbStats.Controls.Add(Me.lblP4Ti)
        Me.gbStats.Controls.Add(Me.lblP3Ti)
        Me.gbStats.Controls.Add(Me.lblP2Ti)
        Me.gbStats.Controls.Add(Me.lblP1Ti)
        Me.gbStats.Cursor = System.Windows.Forms.Cursors.Default
        Me.gbStats.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStats.ForeColor = System.Drawing.Color.White
        Me.gbStats.Location = New System.Drawing.Point(988, 0)
        Me.gbStats.Name = "gbStats"
        Me.gbStats.Size = New System.Drawing.Size(246, 711)
        Me.gbStats.TabIndex = 11
        Me.gbStats.TabStop = False
        Me.gbStats.Text = "Stats"
        Me.gbStats.Visible = False
        '
        'btnSurrender
        '
        Me.btnSurrender.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSurrender.ForeColor = System.Drawing.Color.Black
        Me.btnSurrender.Location = New System.Drawing.Point(22, 589)
        Me.btnSurrender.Name = "btnSurrender"
        Me.btnSurrender.Size = New System.Drawing.Size(201, 54)
        Me.btnSurrender.TabIndex = 18
        Me.btnSurrender.Text = "Surrender"
        Me.btnSurrender.UseVisualStyleBackColor = True
        '
        'lblMoves
        '
        Me.lblMoves.AutoSize = True
        Me.lblMoves.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoves.Location = New System.Drawing.Point(17, 351)
        Me.lblMoves.Name = "lblMoves"
        Me.lblMoves.Size = New System.Drawing.Size(148, 29)
        Me.lblMoves.TabIndex = 17
        Me.lblMoves.Text = "Moves Left-"
        Me.lblMoves.Visible = False
        '
        'lblRound
        '
        Me.lblRound.AutoSize = True
        Me.lblRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRound.Location = New System.Drawing.Point(16, 410)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(125, 31)
        Me.lblRound.TabIndex = 9
        Me.lblRound.Text = "Round - "
        '
        'lblCurrPlay
        '
        Me.lblCurrPlay.AutoSize = True
        Me.lblCurrPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrPlay.Location = New System.Drawing.Point(16, 305)
        Me.lblCurrPlay.Name = "lblCurrPlay"
        Me.lblCurrPlay.Size = New System.Drawing.Size(165, 31)
        Me.lblCurrPlay.TabIndex = 8
        Me.lblCurrPlay.Text = "Player Turn"
        '
        'btnEndTurn
        '
        Me.btnEndTurn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndTurn.ForeColor = System.Drawing.Color.Black
        Me.btnEndTurn.Location = New System.Drawing.Point(22, 500)
        Me.btnEndTurn.Name = "btnEndTurn"
        Me.btnEndTurn.Size = New System.Drawing.Size(201, 54)
        Me.btnEndTurn.TabIndex = 17
        Me.btnEndTurn.Text = "End Turn"
        Me.btnEndTurn.UseVisualStyleBackColor = True
        '
        'lblP4Sc
        '
        Me.lblP4Sc.AutoSize = True
        Me.lblP4Sc.Location = New System.Drawing.Point(198, 198)
        Me.lblP4Sc.Name = "lblP4Sc"
        Me.lblP4Sc.Size = New System.Drawing.Size(25, 25)
        Me.lblP4Sc.TabIndex = 7
        Me.lblP4Sc.Text = "0"
        Me.lblP4Sc.Visible = False
        '
        'lblP3Sc
        '
        Me.lblP3Sc.AutoSize = True
        Me.lblP3Sc.Location = New System.Drawing.Point(198, 145)
        Me.lblP3Sc.Name = "lblP3Sc"
        Me.lblP3Sc.Size = New System.Drawing.Size(25, 25)
        Me.lblP3Sc.TabIndex = 6
        Me.lblP3Sc.Text = "0"
        Me.lblP3Sc.Visible = False
        '
        'lblP2Sc
        '
        Me.lblP2Sc.AutoSize = True
        Me.lblP2Sc.Location = New System.Drawing.Point(198, 88)
        Me.lblP2Sc.Name = "lblP2Sc"
        Me.lblP2Sc.Size = New System.Drawing.Size(25, 25)
        Me.lblP2Sc.TabIndex = 5
        Me.lblP2Sc.Text = "0"
        Me.lblP2Sc.Visible = False
        '
        'lblP1Sc
        '
        Me.lblP1Sc.AutoSize = True
        Me.lblP1Sc.Location = New System.Drawing.Point(198, 39)
        Me.lblP1Sc.Name = "lblP1Sc"
        Me.lblP1Sc.Size = New System.Drawing.Size(25, 25)
        Me.lblP1Sc.TabIndex = 4
        Me.lblP1Sc.Text = "0"
        Me.lblP1Sc.Visible = False
        '
        'lblP4Ti
        '
        Me.lblP4Ti.AutoSize = True
        Me.lblP4Ti.Location = New System.Drawing.Point(17, 198)
        Me.lblP4Ti.Name = "lblP4Ti"
        Me.lblP4Ti.Size = New System.Drawing.Size(114, 25)
        Me.lblP4Ti.TabIndex = 3
        Me.lblP4Ti.Text = "Player4 - "
        Me.lblP4Ti.Visible = False
        '
        'lblP3Ti
        '
        Me.lblP3Ti.AutoSize = True
        Me.lblP3Ti.Location = New System.Drawing.Point(17, 144)
        Me.lblP3Ti.Name = "lblP3Ti"
        Me.lblP3Ti.Size = New System.Drawing.Size(114, 25)
        Me.lblP3Ti.TabIndex = 2
        Me.lblP3Ti.Text = "Player3 - "
        Me.lblP3Ti.Visible = False
        '
        'lblP2Ti
        '
        Me.lblP2Ti.AutoSize = True
        Me.lblP2Ti.Location = New System.Drawing.Point(17, 88)
        Me.lblP2Ti.Name = "lblP2Ti"
        Me.lblP2Ti.Size = New System.Drawing.Size(107, 25)
        Me.lblP2Ti.TabIndex = 1
        Me.lblP2Ti.Text = "Player2 -"
        Me.lblP2Ti.Visible = False
        '
        'lblP1Ti
        '
        Me.lblP1Ti.AutoSize = True
        Me.lblP1Ti.Location = New System.Drawing.Point(17, 39)
        Me.lblP1Ti.Name = "lblP1Ti"
        Me.lblP1Ti.Size = New System.Drawing.Size(107, 25)
        Me.lblP1Ti.TabIndex = 0
        Me.lblP1Ti.Text = "Player1 -"
        Me.lblP1Ti.Visible = False
        '
        'lblRounNum
        '
        Me.lblRounNum.AutoSize = True
        Me.lblRounNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRounNum.ForeColor = System.Drawing.Color.White
        Me.lblRounNum.Location = New System.Drawing.Point(135, 134)
        Me.lblRounNum.Name = "lblRounNum"
        Me.lblRounNum.Size = New System.Drawing.Size(159, 20)
        Me.lblRounNum.TabIndex = 13
        Me.lblRounNum.Text = "Number of Rounds"
        '
        'nudRounNum
        '
        Me.nudRounNum.BackColor = System.Drawing.Color.DimGray
        Me.nudRounNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRounNum.Location = New System.Drawing.Point(314, 132)
        Me.nudRounNum.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudRounNum.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudRounNum.Name = "nudRounNum"
        Me.nudRounNum.Size = New System.Drawing.Size(50, 26)
        Me.nudRounNum.TabIndex = 12
        Me.nudRounNum.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'cbMapPick
        '
        Me.cbMapPick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMapPick.FormattingEnabled = True
        Me.cbMapPick.Items.AddRange(New Object() {"Original Map (27 planetos)", "Test Map (12 planetos)", "Spiral Galaxy (82 planetos)", "Ring Of Death (89 planetos)", "GridLocked (117 planetos)", "Heart Break (83 planetos)", "Praise Jibbers (85 planetos)", "Clusters (71 planetos)", "Tri-Spiral (193 planetos)", "Super-Spiral (215 planetos)", "Random Gen Map", "Import Map"})
        Me.cbMapPick.Location = New System.Drawing.Point(94, 30)
        Me.cbMapPick.Name = "cbMapPick"
        Me.cbMapPick.Size = New System.Drawing.Size(314, 28)
        Me.cbMapPick.TabIndex = 1
        Me.cbMapPick.Text = "Select Map"
        '
        'gbGameSets
        '
        Me.gbGameSets.Controls.Add(Me.gbAdvSets)
        Me.gbGameSets.Controls.Add(Me.btnAdvSets)
        Me.gbGameSets.Controls.Add(Me.cbBot4)
        Me.gbGameSets.Controls.Add(Me.cbBot3)
        Me.gbGameSets.Controls.Add(Me.cbBot2)
        Me.gbGameSets.Controls.Add(Me.cbBot1)
        Me.gbGameSets.Controls.Add(Me.chkP4Bot)
        Me.gbGameSets.Controls.Add(Me.btnStart)
        Me.gbGameSets.Controls.Add(Me.chkP3Bot)
        Me.gbGameSets.Controls.Add(Me.chkP2Bot)
        Me.gbGameSets.Controls.Add(Me.chkP1Bot)
        Me.gbGameSets.Controls.Add(Me.cbMapPick)
        Me.gbGameSets.Controls.Add(Me.nudPCount)
        Me.gbGameSets.Controls.Add(Me.lblRounNum)
        Me.gbGameSets.Controls.Add(Me.lblPlayNum)
        Me.gbGameSets.Controls.Add(Me.nudRounNum)
        Me.gbGameSets.Controls.Add(Me.txtP1)
        Me.gbGameSets.Controls.Add(Me.txtP2)
        Me.gbGameSets.Controls.Add(Me.btnP4Col)
        Me.gbGameSets.Controls.Add(Me.txtP3)
        Me.gbGameSets.Controls.Add(Me.btnP3Col)
        Me.gbGameSets.Controls.Add(Me.txtP4)
        Me.gbGameSets.Controls.Add(Me.btnP2Col)
        Me.gbGameSets.Controls.Add(Me.btnP1Col)
        Me.gbGameSets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGameSets.ForeColor = System.Drawing.Color.White
        Me.gbGameSets.Location = New System.Drawing.Point(387, 51)
        Me.gbGameSets.Name = "gbGameSets"
        Me.gbGameSets.Size = New System.Drawing.Size(519, 542)
        Me.gbGameSets.TabIndex = 1
        Me.gbGameSets.TabStop = False
        Me.gbGameSets.Text = "Game Settings"
        Me.gbGameSets.Visible = False
        '
        'gbAdvSets
        '
        Me.gbAdvSets.Controls.Add(Me.chkRoadBlocks)
        Me.gbAdvSets.Controls.Add(Me.chkStartShields)
        Me.gbAdvSets.Controls.Add(Me.chkLockMode)
        Me.gbAdvSets.Controls.Add(Me.btnAdvSetsDone)
        Me.gbAdvSets.Controls.Add(Me.chkHideScores)
        Me.gbAdvSets.Controls.Add(Me.GroupBox1)
        Me.gbAdvSets.ForeColor = System.Drawing.Color.White
        Me.gbAdvSets.Location = New System.Drawing.Point(6, 173)
        Me.gbAdvSets.Name = "gbAdvSets"
        Me.gbAdvSets.Size = New System.Drawing.Size(507, 363)
        Me.gbAdvSets.TabIndex = 26
        Me.gbAdvSets.TabStop = False
        Me.gbAdvSets.Text = "Advanved Settings"
        Me.gbAdvSets.Visible = False
        '
        'chkRoadBlocks
        '
        Me.chkRoadBlocks.AutoSize = True
        Me.chkRoadBlocks.Location = New System.Drawing.Point(30, 112)
        Me.chkRoadBlocks.Name = "chkRoadBlocks"
        Me.chkRoadBlocks.Size = New System.Drawing.Size(247, 29)
        Me.chkRoadBlocks.TabIndex = 28
        Me.chkRoadBlocks.Text = "Random Roadblocks"
        Me.chkRoadBlocks.UseVisualStyleBackColor = True
        '
        'chkStartShields
        '
        Me.chkStartShields.AutoSize = True
        Me.chkStartShields.Location = New System.Drawing.Point(30, 74)
        Me.chkStartShields.Name = "chkStartShields"
        Me.chkStartShields.Size = New System.Drawing.Size(198, 29)
        Me.chkStartShields.TabIndex = 27
        Me.chkStartShields.Text = "Starting Shields"
        Me.chkStartShields.UseVisualStyleBackColor = True
        '
        'chkLockMode
        '
        Me.chkLockMode.AutoSize = True
        Me.chkLockMode.Location = New System.Drawing.Point(30, 39)
        Me.chkLockMode.Name = "chkLockMode"
        Me.chkLockMode.Size = New System.Drawing.Size(258, 29)
        Me.chkLockMode.TabIndex = 26
        Me.chkLockMode.Text = "Formation Lock Mode"
        Me.chkLockMode.UseVisualStyleBackColor = True
        '
        'btnAdvSetsDone
        '
        Me.btnAdvSetsDone.ForeColor = System.Drawing.Color.Black
        Me.btnAdvSetsDone.Location = New System.Drawing.Point(200, 322)
        Me.btnAdvSetsDone.Name = "btnAdvSetsDone"
        Me.btnAdvSetsDone.Size = New System.Drawing.Size(122, 42)
        Me.btnAdvSetsDone.TabIndex = 0
        Me.btnAdvSetsDone.Text = "Done"
        Me.btnAdvSetsDone.UseVisualStyleBackColor = True
        '
        'chkHideScores
        '
        Me.chkHideScores.AutoSize = True
        Me.chkHideScores.Location = New System.Drawing.Point(308, 171)
        Me.chkHideScores.Name = "chkHideScores"
        Me.chkHideScores.Size = New System.Drawing.Size(159, 29)
        Me.chkHideScores.TabIndex = 25
        Me.chkHideScores.Text = "Hide Scores"
        Me.chkHideScores.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbRanNum)
        Me.GroupBox1.Controls.Add(Me.rbRand)
        Me.GroupBox1.Controls.Add(Me.rbChosen)
        Me.GroupBox1.Controls.Add(Me.rbPreSet)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(302, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 123)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Spawn"
        '
        'cbRanNum
        '
        Me.cbRanNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRanNum.FormattingEnabled = True
        Me.cbRanNum.Items.AddRange(New Object() {"1", "3", "Fill"})
        Me.cbRanNum.Location = New System.Drawing.Point(106, 85)
        Me.cbRanNum.Name = "cbRanNum"
        Me.cbRanNum.Size = New System.Drawing.Size(69, 28)
        Me.cbRanNum.TabIndex = 3
        Me.cbRanNum.Text = "Num"
        Me.cbRanNum.Visible = False
        '
        'rbRand
        '
        Me.rbRand.AutoSize = True
        Me.rbRand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRand.Location = New System.Drawing.Point(6, 90)
        Me.rbRand.Name = "rbRand"
        Me.rbRand.Size = New System.Drawing.Size(94, 24)
        Me.rbRand.TabIndex = 2
        Me.rbRand.Text = "Random"
        Me.rbRand.UseVisualStyleBackColor = True
        '
        'rbChosen
        '
        Me.rbChosen.AutoSize = True
        Me.rbChosen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbChosen.Location = New System.Drawing.Point(6, 60)
        Me.rbChosen.Name = "rbChosen"
        Me.rbChosen.Size = New System.Drawing.Size(142, 24)
        Me.rbChosen.TabIndex = 1
        Me.rbChosen.Text = "Player Chosen"
        Me.rbChosen.UseVisualStyleBackColor = True
        '
        'rbPreSet
        '
        Me.rbPreSet.AutoSize = True
        Me.rbPreSet.Checked = True
        Me.rbPreSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPreSet.Location = New System.Drawing.Point(6, 30)
        Me.rbPreSet.Name = "rbPreSet"
        Me.rbPreSet.Size = New System.Drawing.Size(79, 24)
        Me.rbPreSet.TabIndex = 0
        Me.rbPreSet.TabStop = True
        Me.rbPreSet.Text = "Preset"
        Me.rbPreSet.UseVisualStyleBackColor = True
        '
        'btnAdvSets
        '
        Me.btnAdvSets.ForeColor = System.Drawing.Color.Black
        Me.btnAdvSets.Location = New System.Drawing.Point(155, 173)
        Me.btnAdvSets.Name = "btnAdvSets"
        Me.btnAdvSets.Size = New System.Drawing.Size(190, 42)
        Me.btnAdvSets.TabIndex = 27
        Me.btnAdvSets.Text = "Advanced ->"
        Me.btnAdvSets.UseVisualStyleBackColor = True
        '
        'cbBot4
        '
        Me.cbBot4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBot4.FormattingEnabled = True
        Me.cbBot4.Items.AddRange(New Object() {"WildStep", "WildExpand", "Turtle"})
        Me.cbBot4.Location = New System.Drawing.Point(334, 397)
        Me.cbBot4.Name = "cbBot4"
        Me.cbBot4.Size = New System.Drawing.Size(133, 28)
        Me.cbBot4.TabIndex = 24
        Me.cbBot4.Text = "Bot Type"
        Me.cbBot4.Visible = False
        '
        'cbBot3
        '
        Me.cbBot3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBot3.FormattingEnabled = True
        Me.cbBot3.Items.AddRange(New Object() {"WildStep", "WildExpand", "Turtle"})
        Me.cbBot3.Location = New System.Drawing.Point(334, 342)
        Me.cbBot3.Name = "cbBot3"
        Me.cbBot3.Size = New System.Drawing.Size(133, 28)
        Me.cbBot3.TabIndex = 23
        Me.cbBot3.Text = "Bot Type"
        Me.cbBot3.Visible = False
        '
        'cbBot2
        '
        Me.cbBot2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBot2.FormattingEnabled = True
        Me.cbBot2.Items.AddRange(New Object() {"WildStep", "WildExpand", "Turtle"})
        Me.cbBot2.Location = New System.Drawing.Point(334, 286)
        Me.cbBot2.Name = "cbBot2"
        Me.cbBot2.Size = New System.Drawing.Size(133, 28)
        Me.cbBot2.TabIndex = 22
        Me.cbBot2.Text = "Bot Type"
        Me.cbBot2.Visible = False
        '
        'cbBot1
        '
        Me.cbBot1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBot1.FormattingEnabled = True
        Me.cbBot1.Items.AddRange(New Object() {"WildStep", "WildExpand", "Turtle"})
        Me.cbBot1.Location = New System.Drawing.Point(334, 235)
        Me.cbBot1.Name = "cbBot1"
        Me.cbBot1.Size = New System.Drawing.Size(133, 28)
        Me.cbBot1.TabIndex = 4
        Me.cbBot1.Text = "Bot Type"
        Me.cbBot1.Visible = False
        '
        'chkP4Bot
        '
        Me.chkP4Bot.AutoSize = True
        Me.chkP4Bot.Location = New System.Drawing.Point(262, 397)
        Me.chkP4Bot.Name = "chkP4Bot"
        Me.chkP4Bot.Size = New System.Drawing.Size(66, 29)
        Me.chkP4Bot.TabIndex = 21
        Me.chkP4Bot.Text = "Bot"
        Me.chkP4Bot.UseVisualStyleBackColor = True
        '
        'chkP3Bot
        '
        Me.chkP3Bot.AutoSize = True
        Me.chkP3Bot.Location = New System.Drawing.Point(262, 342)
        Me.chkP3Bot.Name = "chkP3Bot"
        Me.chkP3Bot.Size = New System.Drawing.Size(66, 29)
        Me.chkP3Bot.TabIndex = 20
        Me.chkP3Bot.Text = "Bot"
        Me.chkP3Bot.UseVisualStyleBackColor = True
        '
        'chkP2Bot
        '
        Me.chkP2Bot.AutoSize = True
        Me.chkP2Bot.Location = New System.Drawing.Point(262, 291)
        Me.chkP2Bot.Name = "chkP2Bot"
        Me.chkP2Bot.Size = New System.Drawing.Size(66, 29)
        Me.chkP2Bot.TabIndex = 19
        Me.chkP2Bot.Text = "Bot"
        Me.chkP2Bot.UseVisualStyleBackColor = True
        '
        'chkP1Bot
        '
        Me.chkP1Bot.AutoSize = True
        Me.chkP1Bot.Location = New System.Drawing.Point(262, 235)
        Me.chkP1Bot.Name = "chkP1Bot"
        Me.chkP1Bot.Size = New System.Drawing.Size(66, 29)
        Me.chkP1Bot.TabIndex = 18
        Me.chkP1Bot.Text = "Bot"
        Me.chkP1Bot.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMenu.Location = New System.Drawing.Point(1, 1)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(26, 21)
        Me.btnMenu.TabIndex = 16
        Me.btnMenu.TabStop = False
        Me.btnMenu.Text = "X"
        Me.btnMenu.UseVisualStyleBackColor = True
        Me.btnMenu.Visible = False
        '
        'gbGameOver
        '
        Me.gbGameOver.Controls.Add(Me.btnNope)
        Me.gbGameOver.Controls.Add(Me.btnYes)
        Me.gbGameOver.Controls.Add(Me.lblEndGameText)
        Me.gbGameOver.Controls.Add(Me.lblWinnerText)
        Me.gbGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGameOver.ForeColor = System.Drawing.Color.White
        Me.gbGameOver.Location = New System.Drawing.Point(62, 60)
        Me.gbGameOver.Name = "gbGameOver"
        Me.gbGameOver.Size = New System.Drawing.Size(319, 509)
        Me.gbGameOver.TabIndex = 19
        Me.gbGameOver.TabStop = False
        Me.gbGameOver.Text = "Game Over!"
        Me.gbGameOver.Visible = False
        '
        'btnNope
        '
        Me.btnNope.ForeColor = System.Drawing.Color.Black
        Me.btnNope.Location = New System.Drawing.Point(180, 389)
        Me.btnNope.Name = "btnNope"
        Me.btnNope.Size = New System.Drawing.Size(99, 40)
        Me.btnNope.TabIndex = 3
        Me.btnNope.Text = "No"
        Me.btnNope.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.ForeColor = System.Drawing.Color.Black
        Me.btnYes.Location = New System.Drawing.Point(45, 389)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(99, 40)
        Me.btnYes.TabIndex = 2
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'lblEndGameText
        '
        Me.lblEndGameText.AutoSize = True
        Me.lblEndGameText.Location = New System.Drawing.Point(89, 282)
        Me.lblEndGameText.Name = "lblEndGameText"
        Me.lblEndGameText.Size = New System.Drawing.Size(138, 25)
        Me.lblEndGameText.TabIndex = 1
        Me.lblEndGameText.Text = "Play Again?"
        '
        'lblWinnerText
        '
        Me.lblWinnerText.AutoSize = True
        Me.lblWinnerText.Location = New System.Drawing.Point(91, 124)
        Me.lblWinnerText.Name = "lblWinnerText"
        Me.lblWinnerText.Size = New System.Drawing.Size(125, 25)
        Me.lblWinnerText.TabIndex = 0
        Me.lblWinnerText.Text = "Winner is: "
        '
        'btnResume
        '
        Me.btnResume.ForeColor = System.Drawing.Color.Black
        Me.btnResume.Location = New System.Drawing.Point(85, 52)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(148, 44)
        Me.btnResume.TabIndex = 0
        Me.btnResume.Text = "Resume"
        Me.btnResume.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.ForeColor = System.Drawing.Color.Black
        Me.btnNewGame.Location = New System.Drawing.Point(85, 216)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(148, 44)
        Me.btnNewGame.TabIndex = 1
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnCloseGame
        '
        Me.btnCloseGame.ForeColor = System.Drawing.Color.Black
        Me.btnCloseGame.Location = New System.Drawing.Point(85, 424)
        Me.btnCloseGame.Name = "btnCloseGame"
        Me.btnCloseGame.Size = New System.Drawing.Size(148, 44)
        Me.btnCloseGame.TabIndex = 2
        Me.btnCloseGame.Text = "Close Game"
        Me.btnCloseGame.UseVisualStyleBackColor = True
        '
        'gbPauseMenu
        '
        Me.gbPauseMenu.Controls.Add(Me.btnCloseGame)
        Me.gbPauseMenu.Controls.Add(Me.btnNewGame)
        Me.gbPauseMenu.Controls.Add(Me.btnResume)
        Me.gbPauseMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPauseMenu.ForeColor = System.Drawing.Color.White
        Me.gbPauseMenu.Location = New System.Drawing.Point(62, 30)
        Me.gbPauseMenu.Name = "gbPauseMenu"
        Me.gbPauseMenu.Size = New System.Drawing.Size(319, 509)
        Me.gbPauseMenu.TabIndex = 18
        Me.gbPauseMenu.TabStop = False
        Me.gbPauseMenu.Text = "Pause Menu"
        Me.gbPauseMenu.Visible = False
        '
        'gbStartMenu
        '
        Me.gbStartMenu.Controls.Add(Me.btnLeaveGame)
        Me.gbStartMenu.Controls.Add(Me.btnCreateMap)
        Me.gbStartMenu.Controls.Add(Me.btnPlayGame)
        Me.gbStartMenu.Controls.Add(Me.btnTutorial)
        Me.gbStartMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStartMenu.ForeColor = System.Drawing.Color.White
        Me.gbStartMenu.Location = New System.Drawing.Point(475, 30)
        Me.gbStartMenu.Name = "gbStartMenu"
        Me.gbStartMenu.Size = New System.Drawing.Size(319, 509)
        Me.gbStartMenu.TabIndex = 19
        Me.gbStartMenu.TabStop = False
        '
        'btnLeaveGame
        '
        Me.btnLeaveGame.ForeColor = System.Drawing.Color.Black
        Me.btnLeaveGame.Location = New System.Drawing.Point(85, 424)
        Me.btnLeaveGame.Name = "btnLeaveGame"
        Me.btnLeaveGame.Size = New System.Drawing.Size(148, 44)
        Me.btnLeaveGame.TabIndex = 2
        Me.btnLeaveGame.Text = "Close Game"
        Me.btnLeaveGame.UseVisualStyleBackColor = True
        '
        'btnCreateMap
        '
        Me.btnCreateMap.ForeColor = System.Drawing.Color.Black
        Me.btnCreateMap.Location = New System.Drawing.Point(85, 303)
        Me.btnCreateMap.Name = "btnCreateMap"
        Me.btnCreateMap.Size = New System.Drawing.Size(148, 44)
        Me.btnCreateMap.TabIndex = 1
        Me.btnCreateMap.Text = "Create Map"
        Me.btnCreateMap.UseVisualStyleBackColor = True
        '
        'btnPlayGame
        '
        Me.btnPlayGame.ForeColor = System.Drawing.Color.Black
        Me.btnPlayGame.Location = New System.Drawing.Point(85, 52)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(148, 44)
        Me.btnPlayGame.TabIndex = 0
        Me.btnPlayGame.Text = "Play Game"
        Me.btnPlayGame.UseVisualStyleBackColor = True
        '
        'btnTutorial
        '
        Me.btnTutorial.ForeColor = System.Drawing.Color.Black
        Me.btnTutorial.Location = New System.Drawing.Point(85, 170)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(148, 44)
        Me.btnTutorial.TabIndex = 3
        Me.btnTutorial.Text = "Tutorial"
        Me.btnTutorial.UseVisualStyleBackColor = True
        '
        'OFUser
        '
        Me.OFUser.Filter = "ClickCon Map Files|*.cmap"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(418, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(158, 25)
        Me.lblInstructions.TabIndex = 20
        Me.lblInstructions.Text = "Just a sample"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblInstructions.Visible = False
        '
        'VSclBar
        '
        Me.VSclBar.Dock = System.Windows.Forms.DockStyle.Right
        Me.VSclBar.Location = New System.Drawing.Point(971, 0)
        Me.VSclBar.Name = "VSclBar"
        Me.VSclBar.Size = New System.Drawing.Size(17, 711)
        Me.VSclBar.TabIndex = 21
        Me.VSclBar.Visible = False
        '
        'HSclBar
        '
        Me.HSclBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HSclBar.Location = New System.Drawing.Point(0, 694)
        Me.HSclBar.Name = "HSclBar"
        Me.HSclBar.Size = New System.Drawing.Size(971, 17)
        Me.HSclBar.TabIndex = 29
        Me.HSclBar.Visible = False
        '
        'GameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1234, 711)
        Me.Controls.Add(Me.HSclBar)
        Me.Controls.Add(Me.gbGameSets)
        Me.Controls.Add(Me.VSclBar)
        Me.Controls.Add(Me.gbGameOver)
        Me.Controls.Add(Me.gbPauseMenu)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.gbStats)
        Me.Controls.Add(Me.gbStartMenu)
        Me.Controls.Add(Me.lblInstructions)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "GameScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClickCon!"
        CType(Me.nudPCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStats.ResumeLayout(False)
        Me.gbStats.PerformLayout()
        CType(Me.nudRounNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGameSets.ResumeLayout(False)
        Me.gbGameSets.PerformLayout()
        Me.gbAdvSets.ResumeLayout(False)
        Me.gbAdvSets.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbGameOver.ResumeLayout(False)
        Me.gbGameOver.PerformLayout()
        Me.gbPauseMenu.ResumeLayout(False)
        Me.gbStartMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents nudPCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPlayNum As System.Windows.Forms.Label
    Friend WithEvents txtP1 As System.Windows.Forms.TextBox
    Friend WithEvents txtP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtP3 As System.Windows.Forms.TextBox
    Friend WithEvents txtP4 As System.Windows.Forms.TextBox
    Friend WithEvents btnP1Col As System.Windows.Forms.Button
    Friend WithEvents btnP2Col As System.Windows.Forms.Button
    Friend WithEvents btnP3Col As System.Windows.Forms.Button
    Friend WithEvents btnP4Col As System.Windows.Forms.Button
    Friend WithEvents colDia As System.Windows.Forms.ColorDialog
    Friend WithEvents gbStats As System.Windows.Forms.GroupBox
    Friend WithEvents lblP4Sc As System.Windows.Forms.Label
    Friend WithEvents lblP3Sc As System.Windows.Forms.Label
    Friend WithEvents lblP2Sc As System.Windows.Forms.Label
    Friend WithEvents lblP1Sc As System.Windows.Forms.Label
    Friend WithEvents lblP4Ti As System.Windows.Forms.Label
    Friend WithEvents lblP3Ti As System.Windows.Forms.Label
    Friend WithEvents lblP2Ti As System.Windows.Forms.Label
    Friend WithEvents lblP1Ti As System.Windows.Forms.Label
    Friend WithEvents lblCurrPlay As System.Windows.Forms.Label
    Friend WithEvents lblRound As System.Windows.Forms.Label
    Friend WithEvents lblRounNum As System.Windows.Forms.Label
    Friend WithEvents nudRounNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbMapPick As System.Windows.Forms.ComboBox
    Friend WithEvents gbGameSets As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPreSet As System.Windows.Forms.RadioButton
    Friend WithEvents rbRand As System.Windows.Forms.RadioButton
    Friend WithEvents rbChosen As System.Windows.Forms.RadioButton
    Friend WithEvents cbRanNum As System.Windows.Forms.ComboBox
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents lblMoves As System.Windows.Forms.Label
    Friend WithEvents btnEndTurn As System.Windows.Forms.Button
    Friend WithEvents chkP4Bot As System.Windows.Forms.CheckBox
    Friend WithEvents chkP3Bot As System.Windows.Forms.CheckBox
    Friend WithEvents chkP2Bot As System.Windows.Forms.CheckBox
    Friend WithEvents chkP1Bot As System.Windows.Forms.CheckBox
    Friend WithEvents gbGameOver As System.Windows.Forms.GroupBox
    Friend WithEvents lblWinnerText As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents lblEndGameText As System.Windows.Forms.Label
    Friend WithEvents btnNope As System.Windows.Forms.Button
    Friend WithEvents cbBot4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbBot3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbBot2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbBot1 As System.Windows.Forms.ComboBox
    Friend WithEvents chkHideScores As System.Windows.Forms.CheckBox
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnCloseGame As System.Windows.Forms.Button
    Friend WithEvents gbPauseMenu As System.Windows.Forms.GroupBox
    Friend WithEvents gbStartMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnLeaveGame As System.Windows.Forms.Button
    Friend WithEvents btnCreateMap As System.Windows.Forms.Button
    Friend WithEvents btnPlayGame As System.Windows.Forms.Button
    Friend WithEvents OFUser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gbAdvSets As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdvSetsDone As System.Windows.Forms.Button
    Friend WithEvents chkLockMode As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdvSets As System.Windows.Forms.Button
    Friend WithEvents chkStartShields As System.Windows.Forms.CheckBox
    Friend WithEvents chkRoadBlocks As System.Windows.Forms.CheckBox
    Friend WithEvents btnTutorial As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnSurrender As System.Windows.Forms.Button
    Friend WithEvents VSclBar As System.Windows.Forms.VScrollBar
    Friend WithEvents HSclBar As System.Windows.Forms.HScrollBar

End Class
