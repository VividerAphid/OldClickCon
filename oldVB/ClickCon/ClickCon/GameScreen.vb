Public Class GameScreen
    Public debugMode As Boolean = False

    'Map handling vars
    Public mapHandler As New Mapos
    Public gameMap() As Planeto
    Public cleanLoad As Boolean = True
    'Current turn vars
    Public ClickCode As Integer
    Public turnColour As Color
    Public turnOwner As Integer
    Public roundCurr As Integer
    Dim hasCycled As Boolean = False
    'Player info vars
    Public Structure Player
        Dim colour As Color
        Dim ID As Integer
        Dim name As String
        Dim moves As Integer
        Dim isBot As Boolean
        Dim isDead As Boolean
        Dim hasMoved As Boolean
        Dim score As Integer
        Dim owned As List(Of Integer)
        Dim bot As Bot
    End Structure
    Public players() As Player
    'Game Settings vars
    Dim mode As Integer = 0
    Dim startPlayer As Integer
    Public gameStarted As Boolean = False
    Public playerCount As Integer
    Public roundMax As Integer
    Public spawnType As String
    Public pickingSpawns As Boolean = False
    Public rander As New Random
    Dim EndGame As Boolean = False
    'Graphical vars
    Public ClickLoc As Point
    Dim fShowing() As Boolean
    Dim VScrollPoint = 0, HScrollPoint = 0
    Dim VOGMax = 0, HOGMax = 0
    Dim colButs(3) As Button
    Dim incomScs(3) As Label
    Dim incomLbls(3) As Label
    Dim incomTxt(3) As TextBox
    Dim incomChk(3) As CheckBox
    Dim incomCB(3) As ComboBox
    Private Sub GameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colButs = {btnP1Col, btnP2Col, btnP3Col, btnP4Col}
        incomScs = {lblP1Sc, lblP2Sc, lblP3Sc, lblP4Sc}
        incomLbls = {lblP1Ti, lblP2Ti, lblP3Ti, lblP4Ti}
        incomTxt = {txtP1, txtP2, txtP3, txtP4}
        incomChk = {chkP1Bot, chkP2Bot, chkP3Bot, chkP4Bot}
        incomCB = {cbBot1, cbBot2, cbBot3, cbBot4}
        Dim ads() As String = {"Slippery", "Moist", "Soggy", "Salty", "Deadly", "Plump", "Obese", "Spiky", "Fizzy", "Fuzzy", "Hairy", "Bald", "Thicc", "Fluorescent", "Feeble", "Evil", "Juicy", "Monstrous", "Dead", "Loud", "Silent", "Swift", "Sly", "Cylindrical", "Tubular", "Giant", "Invisible", "Infected", "Annoyed", "Gassy", "Intoxicated", "Toxic", "Blind", "Bloated", "Explosive", "Stinky", "Crispy", "Roasted", "Baked", "Flying", "Lumpy", "Fluffy", "Sleepy", "Special", "Drowsy", "Iridescent", "Musical", "Deformed", "Cheeky", "Impregnated", "Fossilised", "Bleached", "Moldy", "Decaying", "Burnt", "Evaporated", "Folded", "Murderous", "Spicy", "Windy", "Flooded", "Moly", "Eager", "Fried", "Tight", "Seared", "Drowned", "Spacious", "Steamy", "Sexy", "Flappy", "Cute", "Whimsical", "", "Warped", "Dull", "Smug", "Brave", "Crazy", "Hungry", "Foul", "Bent", "Crooked", "Curly", "Sinister", "Broken", "Barking", "Yellow", "Blue", "Green", "Orange", "Red", "Purple", "Scorched", "Exuberant", "Excited", "Happy", "Jovial"}
        Me.Text = ads(rander.Next(ads.Length)) & " ClickCon!"
    End Sub
    Private Sub GameScreen_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If gameStarted = True Then
            Dim button As System.Windows.Forms.MouseEventArgs = e
            If button.Button = MouseButtons.Left Then ClickCode = 0
            If button.Button = MouseButtons.Right Then ClickCode = 1
            If mode = 1 And roundCurr = 0 Then
                tutorialScript()
            Else
                If players(turnOwner - 1).isBot = False Then
                    ClickLoc = New Point(e.X, e.Y)
                    If mode = 1 Then
                        tutorialScript()
                    End If
                    For x = 0 To gameMap.Length - 1
                        checkHit(gameMap(x))
                    Next
                End If
            End If
        End If
    End Sub
    Sub drawMap()
        If gameStarted = True Then
            Dim brush As Graphics = Me.CreateGraphics()
            For x = 0 To gameMap.Length - 1
                If gameMap(x).getShield() = False And gameMap(x).changed And gameMap(x).recentShield Then
                    brush.DrawEllipse(New Pen(Brushes.Black, 2), gameMap(x).getLocation().X - 5, gameMap(x).getLocation().Y - 5, gameMap(x).getDiameter() + 10, gameMap(x).getDiameter() + 10)
                    gameMap(x).recentShield = False
                End If
            Next
            For x = 0 To gameMap.Length - 1
                If gameMap(x).changed = True Then
                    gameMap(x).DrawCons(brush, gameMap)
                End If
            Next
            If debugMode = False Then
                checkBonersShowing(brush)
            End If
            For x = 0 To gameMap.Length - 1
                If gameMap(x).changed = True Then
                    gameMap(x).DrawPlaneto(brush)
                    Dim temp() As Integer = gameMap(x).getConnections()
                    For y = 0 To temp.Length - 1
                        gameMap(temp(y)).DrawPlaneto(brush)
                    Next
                End If
            Next
            gbStats.Refresh()
        End If
    End Sub
    Private Sub GameScreen_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If gameStarted = True Then
            Dim brush As Graphics = e.Graphics
            For x = 0 To gameMap.Length - 1
                gameMap(x).DrawCons(brush, gameMap)
            Next
            For x = 0 To fShowing.Length - 1
                fShowing(x) = False
            Next
            If debugMode = False Then
                checkBonersShowing(brush)
            End If
            For x = 0 To gameMap.Length - 1
                gameMap(x).DrawPlaneto(brush)
            Next
        End If
    End Sub
    Sub checkBonersShowing(brush As Graphics)
        If cleanLoad Then
            Dim tempArr = mapHandler.boners
            Dim isShowing = False
            For w = 0 To Int(tempArr.Length / tempArr.GetLength(tempArr.Rank - 1)) - 1
                Dim justBroke = False
                Dim tempOwner = gameMap(tempArr(w, 0)).getOwner()
                For q = 0 To tempArr.GetLength(tempArr.Rank - 1) - 1
                    If gameMap(tempArr(w, q)).getOwner() = tempOwner And tempOwner <> 0 Or roundCurr > roundMax Then '
                        isShowing = True
                    Else
                        isShowing = False
                        If fShowing(w) Then
                            justBroke = True
                        End If
                        Exit For
                    End If
                Next
                If justBroke Then
                    For x = 0 To tempArr.GetLength(tempArr.Rank - 1) - 1
                        Dim tempCons = gameMap(tempArr(w, x)).getConnections()
                        If chkLockMode.Checked = True And roundCurr <= roundMax Then
                            gameMap(tempArr(w, x)).setLockLife(1001)
                        End If
                        For t = 0 To tempCons.length - 1
                            For y = 0 To tempArr.GetLength(tempArr.Rank - 1) - 1
                                If tempArr(w, y) = tempCons(t) Then                                   
                                    Dim pointA As Point = New Point(gameMap(tempArr(w, x)).getLocation().X + (gameMap(tempArr(w, x)).getDiameter() / 2), gameMap(tempArr(w, x)).getLocation().Y + (gameMap(tempArr(w, x)).getDiameter() / 2))
                                    Dim pointB As Point = New Point(gameMap(tempCons(t)).getLocation().X + (gameMap(tempCons(t)).getDiameter() / 2), gameMap(tempCons(t)).getLocation().Y + (gameMap(tempCons(t)).getDiameter() / 2))
                                    brush.DrawLine(New Pen(Color.Black, 7), pointA, pointB)
                                    If gameMap(tempArr(w, x)).getOwner() <> gameMap(tempCons(t)).getOwner() Then
                                        brush.DrawLine(New Pen(Color.Gray, 3), pointA, pointB)
                                    Else
                                        Dim tempCol As Color = gameMap(tempArr(w, x)).getColour()
                                        brush.DrawLine(New Pen(tempCol, 3), pointA, pointB)
                                    End If
                                    For q = 0 To fShowing.Length - 1
                                        fShowing(q) = False
                                    Next
                                    fShowing(w) = False
                                End If
                            Next
                        Next
                    Next
                    For f = 0 To tempArr.GetLength(tempArr.Rank - 1) - 1
                        gameMap(tempArr(w, f)).changed = True
                    Next
                End If
            Next
            For w = 0 To Int(tempArr.Length / tempArr.GetLength(tempArr.Rank - 1)) - 1
                Dim tempOwner = gameMap(tempArr(w, 0)).getOwner()
                For q = 0 To tempArr.GetLength(tempArr.Rank - 1) - 1
                    If gameMap(tempArr(w, q)).getOwner() = tempOwner And tempOwner <> 0 Or roundCurr > roundMax Then '
                        isShowing = True
                    Else
                        isShowing = False
                        Exit For
                    End If
                Next
                If isShowing And fShowing(w) = False Then
                    For x = 0 To tempArr.GetLength(tempArr.Rank - 1) - 1
                        Dim tempCons = gameMap(tempArr(w, x)).getConnections()
                        If chkLockMode.Checked = True And roundCurr <= roundMax Then
                            gameMap(tempArr(w, x)).setLockLife(1001)
                        End If
                        For t = 0 To tempCons.length - 1
                            For y = 0 To tempArr.GetLength(tempArr.Rank - 1) - 1
                                If tempArr(w, y) = tempCons(t) Then
                                    Dim pointA As Point = New Point(gameMap(tempArr(w, x)).getLocation().X + (gameMap(tempArr(w, x)).getDiameter() / 2), gameMap(tempArr(w, x)).getLocation().Y + (gameMap(tempArr(w, x)).getDiameter() / 2))
                                    Dim pointB As Point = New Point(gameMap(tempCons(t)).getLocation().X + (gameMap(tempCons(t)).getDiameter() / 2), gameMap(tempCons(t)).getLocation().Y + (gameMap(tempCons(t)).getDiameter() / 2))
                                    If roundCurr <= roundMax Then
                                        brush.DrawLine(New Pen(Color.White, 7), pointA, pointB)
                                    Else
                                        brush.DrawLine(New Pen(Color.Gray, 7), pointA, pointB)
                                    End If
                                    fShowing(w) = True                                    
                                End If
                            Next
                        Next
                    Next
                    For f = 0 To tempArr.GetLength(tempArr.Rank - 1) - 1
                        gameMap(tempArr(w, f)).changed = True
                    Next
                End If
            Next
        End If
    End Sub
    Sub checkHit(targ As Planeto)
        If ClickLoc.X > targ.getLocation().X And ClickLoc.X < targ.getLocation().X + targ.getDiameter() Then
            If ClickLoc.Y > targ.getLocation().Y And ClickLoc.Y < targ.getLocation().Y + targ.getDiameter() Then
                'If chkProd.Checked = True Then
                '    makeMove(targ)
                '    If pickingSpawns = False Then
                '        playerMoves(turnOwner - 1) -= 1
                '    Else
                '        changePlayer()
                '    End If
                '    lblMoves.Text = "Moves - " & playerMoves(turnOwner - 1)
                '    drawMap()
                '    If playerMoves(turnOwner - 1) < 1 Then
                '        changePlayer()
                '    End If
                'ElseIf chkProd.Checked = False Then
                makeMove(targ)
                'End If
            End If
        End If
    End Sub
    Public Sub makeMove(targ As Planeto)
        If pickingSpawns And targ.getOwner() = 0 Then
            targ.setColour(turnColour)
            targ.setOwner(turnOwner)
            drawMap()
            changePlayer()
        Else
            If targ.getLockLife = 0 Then
                If targ.getOwner() = turnOwner And targ.getShield() = False Then
                    If players(turnOwner - 1).isBot = True Or ClickCode = 1 Then
                        targ.setShield(True)
                        If mode = 0 Then
                            drawMap()
                            changePlayer()
                        ElseIf mode = 1 Then
                            drawMap()
                        End If
                    End If
                ElseIf targ.getOwner() <> turnOwner And targ.getShield() = True And checkConnected(targ) Then
                    If players(turnOwner - 1).isBot = True Or ClickCode = 0 Then
                        targ.setShield(False)
                        If mode = 0 Then
                            drawMap()
                            changePlayer()
                        End If
                    End If
                Else
                    If checkConnected(targ) = True Then
                        If players(turnOwner - 1).isBot = True Or ClickCode = 0 Then
                            If mode = 0 Then
                                If playerCount = 2 Then
                                    If turnOwner = 2 Then
                                        targ.setLockLife(2)
                                    Else
                                        targ.setLockLife(2)
                                    End If
                                End If
                                targ.setColour(turnColour)
                                targ.setOwner(turnOwner)
                                drawMap()
                                changePlayer()
                            ElseIf mode = 1 Then
                                targ.setColour(turnColour)
                                targ.setOwner(turnOwner)
                                drawMap()
                            End If
                        ElseIf ClickCode = 1 And targ.getShield() = False Then
                            targ.setShield(True)
                            drawMap()
                            changePlayer()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Sub changePlayer()
        calcScores()
        If pickingSpawns Then
            Dim allPicked = True
            For w = 0 To players.Length - 1
                If players(w).score = 0 Then
                    allPicked = False
                End If
            Next
            If allPicked Then
                pickingSpawns = False
            End If
        End If
        If turnOwner < playerCount Then
            turnOwner += 1
        Else
            turnOwner = 1
            updateLockLife()
        End If
        Dim dead = 0
        While players(turnOwner - 1).score = 0 And pickingSpawns = False
            players(turnOwner - 1).isDead = True
            dead += 1
            If dead < playerCount Then
                If turnOwner < playerCount Then
                    turnOwner += 1
                Else
                    turnOwner = 1
                    updateLockLife()
                End If
            Else
                checkOver()
                Exit While
            End If
        End While
        players(turnOwner - 1).hasMoved = True
        Dim tempcount = 0, deadcount = 0
        For q = 0 To playerCount - 1
            If players(q).isDead = False Then
                If players(q).hasMoved = True Then
                    tempcount += 1
                End If
            Else
                deadcount += 1
            End If
        Next
        If tempcount = playerCount Or (tempcount = playerCount - deadcount) Then
            If tempcount <= 1 Then
                roundCurr = roundMax
                checkOver()
            End If
            roundCurr += 1
            For a = 0 To players.Length - 1
                players(a).hasMoved = False
            Next
        End If
        checkOver()
        turnColour = players(turnOwner - 1).colour
        updateStatsBox()
        If players(turnOwner - 1).isBot Then
            If pickingSpawns Then
                Dim found As Boolean = False
                While found = False
                    Dim pick = rander.Next(gameMap.Length)
                    If gameMap(pick).getOwner() = 0 Then
                        gameMap(pick).setOwner(turnOwner)
                        gameMap(pick).setColour(players(turnOwner - 1).colour)
                        found = True
                    End If
                End While
                drawMap()
                changePlayer()
            Else
                players(turnOwner - 1).bot.move()
            End If
        End If
    End Sub
    Sub surrender()
        For x = 0 To players(turnOwner - 1).owned.Count - 1
            gameMap(players(turnOwner - 1).owned(x)).setOwner(0)
            gameMap(players(turnOwner - 1).owned(x)).setColour(Color.White)
            gameMap(players(turnOwner - 1).owned(x)).setLockLife(rander.Next(1, 4))
        Next
        drawMap()
        changePlayer()
    End Sub
    Sub updateStatsBox()
        calcScores()
        lblCurrPlay.Text = players(turnOwner - 1).name & "'s " & vbNewLine & "Turn!"
        lblRound.Text = "Round - " & roundCurr & "/" & roundMax
        gbStats.ForeColor = turnColour
        gbStats.Refresh()
    End Sub
    Sub checkOver()
        If roundCurr > roundMax Then
            drawMap()
            If chkHideScores.Checked = True Then
                For e = 0 To playerCount - 1
                    incomScs(e).Visible = True
                Next
            End If
            gameStarted = False
            calcScores()
            Dim max = 0
            Dim isTie = False
            For w = 0 To players.Length - 1
                If players(w).score > players(max).score Then
                    max = w
                    isTie = False
                ElseIf players(w).score = players(max).score And w > 0 Then
                    isTie = True
                End If
            Next
            If isTie Then
                lblWinnerText.Text = "It's a Tie!"
                lblWinnerText.ForeColor = Color.White
            Else
                lblWinnerText.Text = players(max).name & vbNewLine & "is the winner!"
                lblWinnerText.ForeColor = players(max).colour
            End If
            System.Threading.Thread.Sleep(4000)
            gbGameOver.Location = New Point(460, 38)
            gbGameOver.Visible = True
        End If
    End Sub
    Function checkConnected(targ As Planeto)
        Dim connects() As Integer = targ.getConnections()
        For C = 0 To targ.getConnections().Length - 1
            If gameMap(connects(C)).getOwner = turnOwner And targ.getOwner <> turnOwner Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub nudPCount_ValueChanged(sender As Object, e As EventArgs) Handles nudPCount.ValueChanged
        If nudPCount.Value = 2 Then
            txtP3.Visible = False
            txtP4.Visible = False
            btnP3Col.Visible = False
            btnP4Col.Visible = False
            chkP3Bot.Visible = False
            chkP4Bot.Visible = False
            cbBot3.Visible = False
            cbBot4.Visible = False
        ElseIf nudPCount.Value = 3 Then
            txtP3.Visible = True
            txtP4.Visible = False
            btnP3Col.Visible = True
            btnP4Col.Visible = False
            chkP3Bot.Visible = True
            chkP4Bot.Visible = False
            If chkP3Bot.Checked Then
                cbBot3.Visible = True
            End If
            cbBot4.Visible = False
        ElseIf nudPCount.Value = 4 Then
            txtP3.Visible = True
            txtP4.Visible = True
            btnP3Col.Visible = True
            btnP4Col.Visible = True
            chkP3Bot.Visible = True
            chkP4Bot.Visible = True
            If chkP3Bot.Checked Then
                cbBot3.Visible = True
            End If
            If chkP4Bot.Checked Then
                cbBot4.Visible = True
            End If
        End If
    End Sub
    Private Sub Startbtn_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        gbGameSets.Visible = False
        btnStart.Visible = False
        btnMenu.Visible = True
        playerCount = nudPCount.Value
        roundMax = nudRounNum.Value
        initPlayers(playerCount - 1)
        If rbPreSet.Checked = True Then
            spawnType = "preset"
        ElseIf rbChosen.Checked = True Then
            spawnType = "chosen"
        ElseIf rbRand.Checked = True Then
            If cbRanNum.SelectedIndex = -1 Or cbRanNum.SelectedIndex = 0 Then
                spawnType = "ran1"
            ElseIf cbRanNum.SelectedIndex = 1 Then
                spawnType = "ran3"
            ElseIf cbRanNum.SelectedIndex = 2 Then
                spawnType = "ranF"
            End If
        End If
        pickMap()
        ReDim fShowing(mapHandler.boners.GetLength(0))
        gameStarted = True
        For x = 0 To gameMap.Length - 1
            If gameMap(x).getLocation().X > HOGMax Then
                HOGMax = gameMap(x).getLocation().X
            End If
            If gameMap(x).getLocation().Y > VOGMax Then
                VOGMax = gameMap(x).getLocation().Y
            End If
        Next
        scaleSclBars()
        If pickingSpawns Then
            roundCurr = 0
        Else
            roundCurr = 1
        End If
        turnOwner = rander.Next(1, playerCount + 1)
        startPlayer = turnOwner
        turnColour = players(turnOwner - 1).colour
        calcScores()
        loadStatsBox()
        Refresh()
        If players(turnOwner - 1).isBot Then
            If pickingSpawns Then
                Dim found As Boolean = False
                While found = False
                    Debug.Print("Hit in startbtn!")
                    Dim pick = rander.Next(gameMap.Length)
                    If gameMap(pick).getOwner() = 0 Then
                        gameMap(pick).setOwner(turnOwner)
                        gameMap(pick).setColour(players(turnOwner - 1).colour)
                        found = True
                    End If
                End While
                drawMap()
                changePlayer()
            Else
                players(turnOwner - 1).bot.move()
            End If
        End If
    End Sub '***** START BTN
    Sub initPlayers(cnt As Integer)
        ReDim players(cnt)
        Dim premades() As String = {"Godzilla", "Chickenlips", "Hound", "Canal", "Bladder", "Fogbag", "ArsenicSulfide", "VeggieMonster", "BleachSoda", "OohAh", "BrickBurrito", "Yardbird", "Treebranch", "Cowbag", "BloodyEye", "Diablo", "UncircumcisedBook", "GasBag", "FartHammer", "SpellcastingSaltlick", "Whisker", "NosePicker", "PoopSlogga", "PeaKnuckle", "WindyBologna", "BlisteredSealion", "RupturedWenis", "RoastedGuineaPig", "GenbelNublis", "Sh**Drawers", "DrownedFish", "HumiliatedBellpepper", "DeerMouse", "Fleabag", "BoulderHolder", "MeatCarcass", "UrBootieHole", "PwnBag", "BagBag", "BagSack", "Winnifred", "HarvestMoon", "Bonebag", "CreeperPerro", "Prober", "Furbag", "Foghorn", "McProbe", "ThatOneBot", "ScaryTerry", "Maste", "ProbablyBad", "TurtleBob", "CrayCray", "Daishar", "thedudette", "MrsWayTooClose", "BumbleBee", "Zimmittens", "WeLive", "ButterTits", "TylerNubcs", "BunBun", "WagWag", "cOrncOb"}
        Dim ads() As String = {"Slippery", "Moist", "Soggy", "Salty", "Deadly", "Plump", "Obese", "Spiky", "Fizzy", "Fuzzy", "Hairy", "Bald", "Thicc", "Fluorescent", "Feeble", "Evil", "Juicy", "Monstrous", "Dead", "Loud", "Silent", "Swift", "Sly", "Cylindrical", "Tubular", "Giant", "Invisible", "Infected", "Annoyed", "Gassy", "Intoxicated", "Toxic", "Blind", "Bloated", "Explosive", "Stinky", "Crispy", "Roasted", "Baked", "Flying", "Lumpy", "Fluffy", "Sleepy", "Special", "Drowsy", "Iridescent", "Musical", "Deformed", "Cheeky", "Impregnated", "Fossilised", "Bleached", "Moldy", "Decaying", "Burnt", "Evaporated", "Folded", "Murderous", "Spicy", "Windy", "Flooded", "Moly", "Eager", "Fried", "Tight", "Seared", "Drowned", "Spacious", "Steamy", "Sexy", "Flappy", "Cute", "Whimsical", "", "Warped", "Dull", "Smug", "Brave", "Crazy", "Hungry", "Foul", "Bent", "Crooked", "Curly", "Sinister", "Broken", "Barking", "Yellow", "Blue", "Green", "Orange", "Red", "Purple", "Scorched", "Exuberant", "Excited", "Happy", "Jovial"}
        Dim nouns() As String = {"Bird", "Walrus", "Platypus", "Cactus", "LightBulb", "Table", "Chair", "Hotdog", "Fish", "Eyeball", "Balloon", "Couch", "Guts", "Belly", "Nipple", "Foot", "Donkey", "Pillow", "Brick", "Bucket", "Head", "Sock", "Shirt", "Toe", "Toilet", "Water", "Flower", "Bee", "Egg", "Dinosaur", "UFO", "Skeleton", "Alien", "Bottle", "Cloud", "Insect", "Toenail", "Beetle", "Rug", "Soda", "Bell", "Broom", "Door", "Noose", "Nose", "Button", "Earlobe", "Tongue", "Whisker", "Mower", "Umbrella", "Eyelash", "Bladder", "Pencil", "Lamb", "Lung", "Eyesocket", "Paper", "Chickpea", "Hen", "Bologna", "Desert", "Tick", "Feather", "Eyelid", "Retina", "Bullet", "Key", "Box", "Plant", "Gums", "Bag", "Bowl", "Knife", "Fork", "Spoon", "Desk", "Socket", "Wrench", "Bolt", "Mug", "Spade", "Shovel", "Beluga", "Whale", "Square", "Oval", "Triangle", "Rectangle", "Dodecagon", "Polyhedron", "Parchment", "Shoe", "Tile", "Kidney", "Liver", "Nugget"}
        For x = 0 To playerCount - 1
            players(x).ID = x + 1
            players(x).name = incomTxt(x).Text
            players(x).colour = colButs(x).BackColor
            If incomChk(x).Checked Then
                Dim type As Integer
                players(x).isBot = True
                players(x).bot = New Bot
                If incomCB(x).SelectedIndex = -1 Then
                    Randomize()
                    type = rander.Next(3)
                    'type = 1
                Else
                    type = incomCB(x).SelectedIndex
                End If
                players(x).bot.setType(Type)
                Dim gen = rander.Next(2)
                Select Case gen
                    Case 0
                        players(x).name = premades(rander.Next(premades.Length)) & rander.Next(10) & rander.Next(10)
                    Case 1
                        players(x).name = ads(rander.Next(ads.Length)) & nouns(rander.Next(nouns.Length)) & rander.Next(10) & rander.Next(10)
                End Select
            End If
            If players(x).name.Length > 12 Then
                incomLbls(x).Font = New Font("Microsoft Sans Serif", 9.0, FontStyle.Bold)
            Else
                incomLbls(x).Font = New Font("Microsoft Sans Serif", 15.75, FontStyle.Bold)
            End If
            players(x).hasMoved = False
        Next
    End Sub
    Sub loadStatsBox()
        gbStats.Visible = True
        gbStats.ForeColor = players(turnOwner - 1).colour
        For x = 0 To playerCount - 1
            incomLbls(x).ForeColor = players(x).colour
            incomLbls(x).Text = players(x).name & "-"
            incomScs(x).ForeColor = players(x).colour
            incomLbls(x).Visible = True
            If chkHideScores.Checked = False Then
                incomScs(x).Visible = True
            End If
        Next
        lblCurrPlay.Text = players(turnOwner - 1).name & "'s" & vbNewLine & "Turn!"
        lblRound.Text = "Round - " & roundCurr & "/" & roundMax
    End Sub
    Sub calcScores()
        For x = 0 To players.Length - 1
            players(x).score = 0
            players(x).owned = New List(Of Integer)
            For h = 0 To gameMap.Length - 1
                If gameMap(h).getOwner() = x + 1 Then
                    players(x).score += 1
                    players(x).owned.Add(gameMap(h).getID())
                End If
            Next
        Next
        If debugMode = False And cleanLoad Then
            Dim tempArr = mapHandler.boners
            Dim isShowing = False
            For w = 0 To Int(tempArr.Length / tempArr.GetLength(tempArr.Rank - 1)) - 1
                Dim tempOwner = gameMap(tempArr(w, 0)).getOwner()
                For q = 0 To tempArr.GetLength(tempArr.Rank - 1) - 1
                    If gameMap(tempArr(w, q)).getOwner() = tempOwner And tempOwner <> 0 Then
                        isShowing = True
                    Else
                        isShowing = False
                        Exit For
                    End If
                Next
                If isShowing Then
                    players(tempOwner - 1).score += tempArr.GetLength(tempArr.Rank - 1)
                End If
            Next
        End If
        For V = 0 To playerCount - 1
            incomScs(V).Text = players(V).score
        Next
        lblCurrPlay.Text = players(turnOwner - 1).name & "'s " & vbNewLine & "Turn!"
        lblRound.Text = "Round - " & roundCurr & "/" & roundMax
        gbStats.ForeColor = turnColour
    End Sub
    Private Sub btnCol_Click(sender As Object, e As EventArgs) Handles btnP1Col.Click, btnP2Col.Click, btnP3Col.Click, btnP4Col.Click
        colDia.ShowDialog()
        If sender.Equals(btnP1Col) Then
            btnP1Col.BackColor = colDia.Color
            txtP1.ForeColor = colDia.Color
        ElseIf sender.Equals(btnP2Col) Then
            btnP2Col.BackColor = colDia.Color
            txtP2.ForeColor = colDia.Color
        ElseIf sender.Equals(btnP3Col) Then
            btnP3Col.BackColor = colDia.Color
            txtP3.ForeColor = colDia.Color
        ElseIf sender.Equals(btnP4Col) Then
            btnP4Col.BackColor = colDia.Color
            txtP4.ForeColor = colDia.Color
        End If
    End Sub
    Sub resetGame()
        gbGameSets.Visible = True
        btnStart.Visible = True
        gbStats.Visible = False
        btnMenu.Visible = False
        For r = 0 To players.Length - 1
            incomScs(r).Visible = False
            incomLbls(r).Visible = False
            players(r).score = 0
        Next
    End Sub
    Sub pickMap()
        If cbMapPick.SelectedIndex = -1 Then
            cbMapPick.SelectedIndex = rander.Next(cbMapPick.Items.Count - 1)
        End If
        If cbMapPick.SelectedIndex <> 10 Then
            cleanLoad = True
            Me.BackgroundImage = Nothing
        End If
        Select Case cbMapPick.SelectedIndex
            Case 0
                gameMap = mapHandler.StandardMap(50)
            Case 1
                gameMap = mapHandler.Tester(50)
            Case 2
                gameMap = mapHandler.spiralGal(30)
            Case 3
                gameMap = mapHandler.ringODeth(30)
            Case 4
                gameMap = mapHandler.gridLocked(40)
            Case 5
                gameMap = mapHandler.heartBreak(30)
            Case 6
                gameMap = mapHandler.jibbers(30)
            Case 7
                gameMap = mapHandler.clusters(30)
            Case 8
                gameMap = mapHandler.triSpiral(15)
            Case 9
                gameMap = mapHandler.superSpiral(20)
            Case 10
                gameMap = mapHandler.randMap()
            Case 11
                gameMap = mapHandler.loadCustom()
        End Select
    End Sub
    Private Sub cbMapPick_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMapPick.SelectedIndexChanged
        If cbMapPick.SelectedIndex = 11 Then
            OFUser.ShowDialog()
        End If
    End Sub
    Private Sub rbRand_CheckedChanged(sender As Object, e As EventArgs) Handles rbRand.CheckedChanged
        If rbRand.Checked = True Then
            cbRanNum.Visible = True
        Else
            cbRanNum.Visible = False
        End If
    End Sub
    Private Sub PauseMenu(sender As Object, e As EventArgs) Handles btnMenu.Click, btnResume.Click, btnCloseGame.Click, btnNewGame.Click, btnYes.Click, btnNope.Click
        If sender.Equals(btnMenu) Or sender.Equals(btnResume) Then
            If gameStarted Then
                gameStarted = False
                gbPauseMenu.Location = New Point(460, 38)
                gbPauseMenu.Visible = True
                Debug.Print("Paused!")
            Else
                gameStarted = True
                gbPauseMenu.Visible = False
                Debug.Print("Play!")
            End If
        ElseIf sender.Equals(btnCloseGame) Then
            Me.Close()
        ElseIf sender.Equals(btnNewGame) Then
            gameStarted = False
            gbPauseMenu.Visible = False
            btnMenu.Visible = False
            resetGame()
        ElseIf sender.Equals(btnYes) Or sender.Equals(btnNope) Then
            If EndGame Then
                If sender.Equals(btnYes) Then
                    Me.Close()
                Else
                    EndGame = False
                    gbGameOver.Visible = False
                    lblEndGameText.Text = "Play Again?"
                    lblEndGameText.Location = New Point(lblEndGameText.Location.X + 30, lblEndGameText.Location.Y)
                    resetGame()
                End If
            Else
                If sender.Equals(btnYes) Then
                    EndGame = False
                    gbGameOver.Visible = False
                    resetGame()
                Else
                    EndGame = True
                    lblEndGameText.Text = "Close Game Now?"
                    lblEndGameText.Location = New Point(lblEndGameText.Location.X - 30, lblEndGameText.Location.Y)
                End If
            End If
        End If
    End Sub
    Private Sub btnEndTurn_Click(sender As Object, e As EventArgs) Handles btnEndTurn.Click, btnSurrender.Click
        If sender.Equals(btnEndTurn) Then
            changePlayer()
        Else
            surrender()
        End If
    End Sub
    Private Sub chkBot_CheckedChanged(sender As Object, e As EventArgs) Handles chkP4Bot.CheckedChanged, chkP2Bot.CheckedChanged, chkP1Bot.CheckedChanged, chkP3Bot.CheckedChanged
        If sender.Equals(chkP1Bot) Then
            If chkP1Bot.Checked Then
                cbBot1.Visible = True
            Else
                cbBot1.Visible = False
            End If
        ElseIf sender.Equals(chkP2Bot) Then
            If chkP2Bot.Checked Then
                cbBot2.Visible = True
            Else
                cbBot2.Visible = False
            End If
        ElseIf sender.Equals(chkP3Bot) Then
            If chkP3Bot.Checked Then
                cbBot3.Visible = True
            Else
                cbBot3.Visible = False
            End If
        ElseIf sender.Equals(chkP4Bot) Then
            If chkP4Bot.Checked Then
                cbBot4.Visible = True
            Else
                cbBot4.Visible = False
            End If
        End If
    End Sub
    Private Sub StartMenu(sender As Object, e As EventArgs) Handles btnPlayGame.Click, btnCreateMap.Click, btnLeaveGame.Click
        If sender.Equals(btnPlayGame) Then
            gbStartMenu.Visible = False
            gbGameSets.Visible = True
        ElseIf sender.Equals(btnCreateMap) Then
            MapEditor.Show()
            Me.Hide()
        ElseIf sender.Equals(btnLeaveGame) Then
            Me.Close()
        End If
    End Sub
    Private Sub btnAdvSetsDone_Click(sender As Object, e As EventArgs) Handles btnAdvSetsDone.Click, btnAdvSets.Click
        If sender.Equals(btnAdvSets) Then
            gbAdvSets.Visible = True
        Else
            gbAdvSets.Visible = False
        End If
    End Sub
    Sub updateLockLife()
        For v = 0 To gameMap.Length - 1
            gameMap(v).decayLockLife()
        Next
    End Sub
    Private Sub btnTutorial_Click(sender As Object, e As EventArgs) Handles btnTutorial.Click
        mode = 1
        gameMap = mapHandler.tutorial()
        ReDim fShowing(1)
        playerCount = 2
        roundMax = 15
        ReDim players(1)
        players(0).isBot = False
        players(0).colour = Color.Red
        players(0).ID = 1
        players(0).name = "Player"
        players(1).isBot = True
        players(1).bot = New Bot
        players(1).bot.setType(1)
        players(1).colour = Color.Blue
        players(1).ID = 2
        players(1).name = "Derp Bot"
        turnOwner = 1
        turnColour = Color.Red
        loadStatsBox()
        gameMap = mapHandler.tutorial()
        gbStartMenu.Visible = False
        btnMenu.Visible = True
        lblInstructions.Visible = True
        lblInstructions.Text = "Welcome to ClickCon! " & vbNewLine &
            "This is a game that involves trying" & vbNewLine &
            "to take as much of the map as possible," & vbNewLine &
            "or have the highest score before" & vbNewLine &
            "the round limit is reached." & vbNewLine &
            "Click to continue."
        gameStarted = True
        drawMap()
    End Sub
    Sub tutorialScript()
        Select Case roundCurr
            Case 0
                lblInstructions.Text = "On the right, we have our" & vbNewLine & "stats box, which shows all of the player" & vbNewLine & "scores, as well as who's turn it is." & vbNewLine & "We can also see how many rounds we have" & vbNewLine & "left until the game is over." & vbNewLine & "A round is just a complete cycle of all living players." & vbNewLine & "Click to continue."
                lblInstructions.Location = New Point(lblInstructions.Location.X - 50, lblInstructions.Location.Y)
                roundCurr += 1
                drawMap()
            Case 1
                lblInstructions.Text = "To play, simply left click on" & vbNewLine & "any planeto that is connected to one you own." & vbNewLine & "In this case, you are the red player."
                roundCurr += 1
                drawMap()
            Case 2
                lblInstructions.Location = New Point(lblInstructions.Location.X - 50, lblInstructions.Location.Y)
                lblInstructions.Text = "As you can see, you now own this" & vbNewLine & "second planeto. Let's learn how to put up some protection." & vbNewLine & "By right clicking on any planeto, you can put up a" & vbNewLine & "shield, meaning it will take two hits to capture." & vbNewLine & "Go ahead and do so."
                roundCurr += 1
                drawMap()
            Case 3
                lblInstructions.Location = New Point(lblInstructions.Location.X - 50, lblInstructions.Location.Y)
                lblInstructions.Text = "Hollow planetos, like the one near blue" & vbNewLine & "cannot be taken. If a player owns" & vbNewLine & "one, they can still attack from it" & vbNewLine & "however. In some cases, the locked effect" & vbNewLine & "will decay and disappear after a few turns." & vbNewLine & "Click to continue."
                roundCurr += 1
                drawMap()
            Case 4
                lblInstructions.Location = New Point(lblInstructions.Location.X - 50, lblInstructions.Location.Y)
                lblInstructions.Text = "Lastly, before the game begins properly," & vbNewLine & "there are things called 'formations'," & vbNewLine & "which display as thicker white lines between" & vbNewLine & "planetos. They give double points for all of the planetos in them." & vbNewLine & "They vary in size and location depending on the map." & vbNewLine & "Click to begin the game."
                roundCurr += 1
                drawMap()
            Case 5
                mode = 0
                lblInstructions.Visible = False
                roundCurr += 1
                drawMap()
        End Select
        updateStatsBox()
    End Sub
    Private Sub SclBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VSclBar.Scroll, HSclBar.Scroll
        If sender.Equals(VSclBar) Then
            If VSclBar.Value <> VScrollPoint Then
                For x = 0 To gameMap.Length - 1
                    gameMap(x).setLocation(New Point(gameMap(x).getLocation().X, gameMap(x).getLocation().Y + (VScrollPoint - VSclBar.Value)))
                Next
                VScrollPoint = VSclBar.Value
                Refresh()
            End If
        Else
            If HSclBar.Value <> HScrollPoint Then
                For x = 0 To gameMap.Length - 1
                    gameMap(x).setLocation(New Point(gameMap(x).getLocation().X + (HScrollPoint - HSclBar.Value), gameMap(x).getLocation().Y))
                Next
                HScrollPoint = HSclBar.Value
                Refresh()
            End If
        End If
    End Sub
    Sub scaleSclBars()
        HSclBar.Value = 0
        VSclBar.Value = 0
        Dim highestH = 0, lowestH = 0
        Dim highestV = 0, lowestV = 0
        For x = 0 To gameMap.Length - 1
            If gameMap(x).getLocation().X > highestH Then
                highestH = gameMap(x).getLocation().X
            End If
            If gameMap(x).getLocation().X < lowestH Then
                lowestH = gameMap(x).getLocation().X
            End If
            If gameMap(x).getLocation().Y > highestV Then
                highestV = gameMap(x).getLocation().Y
                Debug.Print("Found planeto " & x & " at " & gameMap(x).getLocation().Y)
            End If
            If gameMap(x).getLocation().Y < lowestV Then
                lowestV = gameMap(x).getLocation().Y
            End If
        Next
        If Me.Height < VOGMax Then
            Debug.Print("Window height is: " & Me.Height)
            VSclBar.Visible = True
            VSclBar.Maximum = 2 * (VOGMax - Me.Height) + 50
            Debug.Print("Setting sclbar to:" & 2 * (VOGMax - Me.Height))
        End If
    End Sub
    Private Sub GameScreen_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If gameStarted Then
            scaleSclBars()
        End If
    End Sub
End Class