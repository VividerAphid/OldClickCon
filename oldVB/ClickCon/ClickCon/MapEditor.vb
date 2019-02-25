Imports System.IO

Public Class MapEditor
    Public reader As StreamReader
    Dim writer As StreamWriter

    Dim map As New List(Of Planeto)
    Dim fileData As New List(Of String)
    Dim currentInd As Integer = 0
    Dim editMode As Integer = 0 ' 0 = planeto, 1 = connections, 2 = shields, 3 = spawns
    Dim selTarg As Integer = -1
    Dim loaded As Boolean = False
    Dim VScrollPoint = 0, HScrollPoint = 0
    Dim VOGMax = 0, HOGMax = 0
    Private Sub MapEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ads() As String = {"Slippery", "Moist", "Soggy", "Salty", "Deadly", "Plump", "Obese", "Spiky", "Fizzy", "Fuzzy", "Hairy", "Bald", "Thicc", "Fluorescent", "Feeble", "Evil", "Juicy", "Monstrous", "Dead", "Loud", "Silent", "Swift", "Sly", "Cylindrical", "Tubular", "Giant", "Invisible", "Infected", "Annoyed", "Gassy", "Intoxicated", "Toxic", "Blind", "Bloated", "Explosive", "Stinky", "Crispy", "Roasted", "Baked", "Flying", "Lumpy", "Fluffy", "Sleepy", "Special", "Drowsy", "Iridescent", "Musical", "Deformed", "Cheeky", "Impregnated", "Fossilised", "Bleached", "Moldy", "Decaying", "Burnt", "Evaporated", "Folded", "Murderous", "Spicy", "Windy", "Flooded", "Moly", "Eager", "Fried", "Tight", "Seared", "Drowned", "Spacious", "Steamy", "Sexy", "Flappy", "Cute", "Whimsical", "", "Warped", "Dull", "Smug", "Brave", "Crazy", "Hungry", "Foul", "Bent", "Crooked", "Curly", "Sinister", "Broken", "Barking", "Yellow", "Blue", "Green", "Orange", "Red", "Purple", "Scorched", "Exuberant", "Excited", "Happy", "Jovial"}
        Me.Text = "The " & ads(GameScreen.rander.Next(ads.Length)) & " Map Editor!"
    End Sub
    Private Sub MapEditor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        GameScreen.Show()
    End Sub
    Private Sub StartMenu(sender As Object, e As EventArgs) Handles btnNewMap.Click, btnOpen.Click, btnClose.Click
        If sender.Equals(btnNewMap) Then
            gbStart.Visible = False
            gbTools.Enabled = True
            If map.Count > 0 Then
                map.RemoveRange(0, map.Count)
                currentInd = 0
                Refresh()
            End If
            loaded = True
        ElseIf sender.Equals(btnOpen) Then
            If (OFUser.ShowDialog() = DialogResult.OK) Then
                reader = New StreamReader(OFUser.FileName)
                loadData(reader)
                gbStart.Visible = False
                gbTools.Enabled = True
            End If
        Else
            Me.Close()
        End If
        For x = 0 To map.Count - 1
            If map(x).getLocation().X > HOGMax Then
                HOGMax = map(x).getLocation().X
            End If
            If map(x).getLocation().Y > VOGMax Then
                VOGMax = map(x).getLocation().Y
            End If
        Next
        btnMenu.Visible = True
        gbTools.Text = "Tools - Planeto Edit Mode"
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If gbStart.Visible Then
            gbStart.Visible = False
        Else
            gbStart.Visible = True
        End If
    End Sub
    Private Sub ToolsMenu(sender As Object, e As EventArgs) Handles btnPlanetos.Click, btnConnections.Click, btnShields.Click, btnSpawns.Click, btnSave.Click
        If sender.Equals(btnSpawns) Then
            gbPlayerSpawns.Enabled = True
            editMode = 3
            gbTools.Text = "Tools - Spawn Edit Mode"
            selTarg = -1
        Else
            gbPlayerSpawns.Enabled = False
            If sender.Equals(btnPlanetos) Then
                editMode = 0
                gbTools.Text = "Tools - Planeto Edit Mode"
                selTarg = -1
            ElseIf sender.Equals(btnConnections) Then
                editMode = 1
                gbTools.Text = "Tools - Cons Edit Mode"
            ElseIf sender.Equals(btnShields) Then
                editMode = 2
                gbTools.Text = "Tools - Shields Edit Mode"
                selTarg = -1
            ElseIf sender.Equals(btnSave) Then
                selTarg = -1
                If SFUser.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim strm As Stream = SFUser.OpenFile()
                    Dim tempPath As String = SFUser.FileName
                    strm.Close()
                    writer = My.Computer.FileSystem.OpenTextFileWriter(tempPath, False)
                    For x = 0 To map.Count - 1
                        Dim temp() As Integer = map(x).getConnections()
                        Dim consStr As String = ""
                        For y = 0 To temp.Length - 1
                            consStr += temp(y).ToString()
                            If y < temp.Length - 1 Then
                                consStr += ","
                            End If
                        Next
                        Dim shieldInt As Integer
                        If map(x).getShield() Then
                            shieldInt = 1
                        Else
                            shieldInt = 0
                        End If
                        Dim tempStr = map(x).getOwner & ControlChars.Tab & "(" & map(x).getLocation().X & "," & map(x).getLocation().Y & ")" &
                                    ControlChars.Tab & "{" & consStr & "}" & ControlChars.Tab & shieldInt & ControlChars.Tab & map(x).getDiameter()
                        writer.WriteLine(tempStr)
                    Next
                    writer.Close()
                End If
            End If
        End If
        If editMode = 0 And cbSymSelect.Visible = False Then
            cbSymSelect.Visible = True
            lblPlaWidText.Visible = True
            nudRad.Visible = True
            btnConnections.Location = New Point(btnConnections.Location.X, btnConnections.Location.Y + 83)
            btnShields.Location = New Point(btnShields.Location.X, btnShields.Location.Y + 83)
            btnSpawns.Location = New Point(btnSpawns.Location.X, btnSpawns.Location.Y + 83)
            gbPlayerSpawns.Location = New Point(gbPlayerSpawns.Location.X, gbPlayerSpawns.Location.Y + 83)
            lblPlaCount.Location = New Point(lblPlaCount.Location.X, lblPlaCount.Location.Y + 83)
            btnChangeBackground.Location = New Point(btnChangeBackground.Location.X, btnChangeBackground.Location.Y + 83)
            btnSave.Location = New Point(btnSave.Location.X, btnSave.Location.Y + 83)
        ElseIf editMode <> 0 Then
            If cbSymSelect.Visible = True Then
                cbSymSelect.Visible = False
                lblPlaWidText.Visible = False
                nudRad.Visible = False
                btnConnections.Location = New Point(btnConnections.Location.X, btnConnections.Location.Y - 83)
                btnShields.Location = New Point(btnShields.Location.X, btnShields.Location.Y - 83)
                btnSpawns.Location = New Point(btnSpawns.Location.X, btnSpawns.Location.Y - 83)
                gbPlayerSpawns.Location = New Point(gbPlayerSpawns.Location.X, gbPlayerSpawns.Location.Y - 83)
                lblPlaCount.Location = New Point(lblPlaCount.Location.X, lblPlaCount.Location.Y - 83)
                btnChangeBackground.Location = New Point(btnChangeBackground.Location.X, btnChangeBackground.Location.Y - 83)
                btnSave.Location = New Point(btnSave.Location.X, btnSave.Location.Y - 83)
            End If
        End If
        Refresh()
    End Sub
    Private Sub MapEditor_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim brush As Graphics = e.Graphics
        If loaded Then
            'Debug.Print("New Pass")
            For x = 0 To map.Count - 1
                Dim temp() As Integer = map(x).getConnections()
                'Debug.Print("Planeto " & x & " connection count is " & temp.Length)
                If temp.Length > 0 Then
                    map(x).DrawCons(brush, map.ToArray())
                    'Debug.Print("Planeto " & x & " has: ")
                    For q = 0 To temp.Length - 1
                        temp(q) = temp(q)
                        'Debug.Print(temp(q))
                    Next
                End If
            Next

            For x = 0 To map.Count - 1
                map(x).DrawPlaneto(brush)
            Next
            If selTarg <> -1 Then
                Dim tempPoint As Point = map(selTarg).getLocation()
                brush.DrawEllipse(New Pen(Brushes.Red, 3), tempPoint.X - 5, tempPoint.Y - 5, map(selTarg).getDiameter() + 10, map(selTarg).getDiameter() + 10)
            End If
            lblPlaCount.Text = "Planeto Count - " & map.Count
        End If
    End Sub
    Sub loadData(read As StreamReader)
        map.RemoveRange(0, map.Count)
        While read.EndOfStream = False
            fileData.Add(read.ReadLine())
        End While
        For s = 0 To fileData.Count - 1
            Dim splitString() As String = fileData(s).Split(ControlChars.Tab)
            Dim tempOwner As Integer = splitString(0)
            Dim tempLocation As Point
            Dim tempShield As Integer = splitString(3)
            Dim tempRad As Integer = splitString(4)

            splitString(1) = splitString(1).Substring(1, splitString(1).Length - 2)
            Dim tempLoc() As String = splitString(1).Split(",")
            tempLocation = New Point(Int(tempLoc(0)), Int(tempLoc(1)))

            Debug.Print(splitString(2))
            splitString(2) = splitString(2).Substring(1, splitString(2).Length - 2)
            Debug.Print(splitString(2))
            Dim temp() As String = splitString(2).Split(",")
            Dim tempCons(temp.Length - 1) As Integer
            If temp(0) <> "" Then
                For q = 0 To temp.Length - 1
                    tempCons(q) = temp(q)
                Next
            End If
            map.Add(New Planeto)
            map(s).setID(s)
            Dim tempColour As Color
            Select Case tempOwner
                Case 0
                    tempColour = Color.White
                Case 1
                    tempColour = Color.Red
                Case 2
                    tempColour = Color.Blue
                Case 3
                    tempColour = Color.Lime
                Case 4
                    tempColour = Color.Yellow
            End Select
            If temp(0) <> Nothing Then
                map(s).LoadUp(tempOwner, tempColour, tempLocation, tempCons)
            Else
                map(s).LoadUp(tempOwner, tempColour, tempLocation, {})
            End If
            map(s).setShield(tempShield)
            map(s).setDiameter(tempRad)
        Next
        currentInd = fileData.Count
        reader.Close()
        loaded = True
        Refresh()
    End Sub
    Private Sub MapEditor_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Dim clickLoc As New Point(e.X, e.Y)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Select Case editMode
                Case 0
                    Dim reps As Integer = 0
                    Dim temPonts As Point()
                    If cbSymSelect.SelectedIndex = -1 Or cbSymSelect.SelectedIndex = 0 Then
                        reps = 1
                        ReDim temPonts(0)
                        temPonts(0) = New Point(clickLoc.X - nudRad.Value / 2, clickLoc.Y - nudRad.Value / 2)
                    ElseIf cbSymSelect.SelectedIndex = 1 Then
                        reps = 2
                        ReDim temPonts(1)
                        temPonts = {New Point(clickLoc.X - nudRad.Value / 2, clickLoc.Y - nudRad.Value / 2), New Point(((Me.Width - 246) - clickLoc.X) - nudRad.Value / 2, clickLoc.Y - nudRad.Value / 2)}
                    ElseIf cbSymSelect.SelectedIndex = 2 Then
                        reps = 2
                        ReDim temPonts(1)
                        temPonts = {New Point(clickLoc.X - nudRad.Value / 2, clickLoc.Y - nudRad.Value / 2), New Point(clickLoc.X - nudRad.Value / 2, Me.Height - 10 - clickLoc.Y - nudRad.Value / 2)}
                    ElseIf cbSymSelect.SelectedIndex = 3 Then
                        reps = 2
                        ReDim temPonts(1)
                        temPonts = {New Point(clickLoc.X - nudRad.Value / 2, clickLoc.Y - nudRad.Value / 2), New Point(((Me.Width - 246) - clickLoc.X) - nudRad.Value / 2, Me.Height - clickLoc.Y - 10 - nudRad.Value / 2)}
                    ElseIf cbSymSelect.SelectedIndex = 4 Then
                        reps = 4
                        ReDim temPonts(3)
                        temPonts = {New Point(clickLoc.X - nudRad.Value / 2, clickLoc.Y - nudRad.Value / 2), New Point(((Me.Width - 246) - clickLoc.X) - nudRad.Value / 2, Me.Height - clickLoc.Y - 10 - nudRad.Value / 2), New Point(clickLoc.X - nudRad.Value / 2, Me.Height - clickLoc.Y - 10 - nudRad.Value / 2), New Point(((Me.Width - 246) - clickLoc.X) - nudRad.Value / 2, clickLoc.Y - nudRad.Value / 2)}
                    End If
                    If map.Count = 0 Then
                        For x = 0 To reps - 1
                            map.Add(New Planeto)
                            map(currentInd).setDiameter(nudRad.Value)
                            map(currentInd).LoadUp(0, Color.White, temPonts(x), {})
                            currentInd += 1
                        Next
                    Else
                        Dim found As Boolean = False
                        For x = 0 To map.Count - 1
                            found = CheckHit(map(x), clickLoc)
                            If found Then
                                Exit For
                            End If
                        Next
                        If found = False Then
                            For x = 0 To reps - 1
                                map.Add(New Planeto)
                                map(currentInd).setDiameter(nudRad.Value)
                                map(currentInd).LoadUp(0, Color.White, temPonts(x), {})
                                currentInd += 1
                            Next
                        End If
                    End If
                Case 1
                    Dim found As Boolean
                        For x = 0 To map.Count - 1
                            found = CheckHit(map(x), clickLoc)
                            If found Then
                                If selTarg = x Then
                                    selTarg = -1
                                Else
                                    selTarg = x
                                End If
                                Exit For
                            End If
                        Next
                Case 2
                    Dim found As Boolean = False
                        For x = 0 To map.Count - 1
                            found = CheckHit(map(x), clickLoc)
                            If found Then
                                map(x).setShield(True)
                                Exit For
                            End If
                        Next
                Case 3
                    For x = 0 To map.Count - 1
                        If CheckHit(map(x), clickLoc) Then
                            If rbP1S.Checked Then
                                map(x).setOwner(1)
                                map(x).setColour(Color.Red)
                            ElseIf rbP2S.Checked Then
                                map(x).setOwner(2)
                                map(x).setColour(Color.Blue)
                            ElseIf rbP3S.Checked Then
                                map(x).setOwner(3)
                                map(x).setColour(Color.Lime)
                            ElseIf rbP4S.Checked Then
                                map(x).setOwner(4)
                                map(x).setColour(Color.Yellow)
                            End If
                            Exit For
                        End If
                    Next
            End Select
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            Select Case editMode
                Case 0
                    If map.Count > 0 Then
                        Dim foundInd As Integer
                        For x = 0 To map.Count - 1
                            If CheckHit(map(x), clickLoc) Then
                                foundInd = x
                                Dim temp() As Integer = map(x).getConnections()
                                For r = 0 To temp.Length - 1
                                    map(temp(r)).removeConnection(x)
                                Next
                                map.RemoveAt(x)
                                currentInd -= 1
                                For y = 0 To map.Count - 1
                                    Dim cons() As Integer = map(y).getConnections()
                                    For r = 0 To cons.Length - 1
                                        If cons(r) > foundInd Then
                                            cons(r) = cons(r) - 1
                                        End If
                                    Next
                                    map(y).setConnections(cons)
                                Next
                                Exit For
                            End If
                        Next
                    End If
                Case 1
                    If selTarg <> -1 Then
                        For x = 0 To map.Count - 1
                            If CheckHit(map(x), clickLoc) Then
                                Dim temp() As Integer = map(x).getConnections()
                                Dim found As Boolean = False
                                For w = 0 To temp.Length - 1
                                    If temp(w) = selTarg Then
                                        map(selTarg).removeConnection(x)
                                        map(x).removeConnection(selTarg)
                                        found = True
                                        Exit For
                                    End If
                                Next
                                If found = False Then
                                    map(selTarg).addConnection(x)
                                    map(x).addConnection(selTarg)
                                End If
                                Exit For
                            End If
                        Next
                    End If
                Case 2
                    For x = 0 To map.Count - 1
                        If CheckHit(map(x), clickLoc) Then
                            map(x).setShield(False)
                            Exit For
                        End If
                    Next
                Case 3
                    For x = 0 To map.Count - 1
                        If CheckHit(map(x), clickLoc) Then
                            map(x).setOwner(0)
                            map(x).setColour(Color.White)
                            Exit For
                        End If
                    Next
            End Select
        End If
        Refresh()
    End Sub
    Function CheckHit(targ As Planeto, loc As Point)
        If loc.X > targ.getLocation().X And loc.X < targ.getLocation().X + targ.getDiameter() Then
            If loc.Y > targ.getLocation().Y And loc.Y < targ.getLocation().Y + targ.getDiameter() Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Private Sub btnChangeBackground_Click(sender As Object, e As EventArgs) Handles btnChangeBackground.Click
        If OFPic.ShowDialog() = Windows.Forms.DialogResult.OK Then
            gbImageStyle.Visible = True
            Me.BackgroundImage = Image.FromFile(OFPic.FileName)
        End If
    End Sub
    Private Sub formatButtons_Click(sender As Object, e As EventArgs) Handles btnStretch.Click, btnCenter.Click, btnZoom.Click, btnNone.Click, btnTile.Click

        If sender.Equals(btnStretch) Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Debug.Print("Stretch!")
        ElseIf sender.Equals(btnTile) Then
            Me.BackgroundImageLayout = ImageLayout.Tile
            Debug.Print("Tile!")
        ElseIf sender.Equals(btnCenter) Then
            Me.BackgroundImageLayout = ImageLayout.Center
            Debug.Print("Center!")
        ElseIf sender.Equals(btnZoom) Then
            Me.BackgroundImageLayout = ImageLayout.Zoom
            Debug.Print("Zoom!")
        ElseIf sender.Equals(btnNone) Then
            Me.BackgroundImageLayout = ImageLayout.None
            Debug.Print("None!")
        End If
        gbImageStyle.Visible = False
    End Sub
    Private Sub btnRanGen_Click(sender As Object, e As EventArgs) Handles btnRanGen.Click
        Dim chunker As New Chunks
        Dim temp As New List(Of Point)
        temp = chunker.makeChunk(GameScreen.rander.Next(60, 150), 25)
        If map.Count > 0 Then
            map.RemoveRange(0, map.Count)
            currentInd = 0
            Refresh()
        End If
        For x = 0 To temp.Count - 1
            map.Add(New Planeto)
            map(x).setDiameter(25)
            map(x).LoadUp(0, Color.White, temp(x), {})
            currentInd += 1
        Next
        loaded = True
        gbStart.Visible = False
        gbTools.Enabled = True
        btnMenu.Visible = True
        nudRad.Value = 25
        gbTools.Text = "Tools - Planeto Edit Mode"
        Refresh()
    End Sub
    Private Sub SclBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VSclBar.Scroll, HSclBar.Scroll
        If sender.Equals(VSclBar) Then
            If VSclBar.Value <> VScrollPoint Then
                For x = 0 To map.Count - 1
                    map(x).setLocation(New Point(map(x).getLocation().X, map(x).getLocation().Y + (VScrollPoint - VSclBar.Value)))
                Next
                VScrollPoint = VSclBar.Value
                Refresh()
            End If
        Else
            If HSclBar.Value <> HScrollPoint Then
                For x = 0 To map.Count - 1
                    map(x).setLocation(New Point(map(x).getLocation().X + (HScrollPoint - HSclBar.Value), map(x).getLocation().Y))
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
        For x = 0 To map.Count - 1
            If map(x).getLocation().X > highestH Then
                highestH = map(x).getLocation().X
            End If
            If map(x).getLocation().X < lowestH Then
                lowestH = map(x).getLocation().X
            End If
            If map(x).getLocation().Y > highestV Then
                highestV = map(x).getLocation().Y
                Debug.Print("Found planeto " & x & " at " & map(x).getLocation().Y)
            End If
            If map(x).getLocation().Y < lowestV Then
                lowestV = map(x).getLocation().Y
            End If
        Next
        If Me.Height < VOGMax Then
            Debug.Print("Window height is: " & Me.Height)
            VSclBar.Visible = True
            VSclBar.Maximum = 2 * (VOGMax - Me.Height) + 50
            Debug.Print("Setting sclbar to:" & 2 * (VOGMax - Me.Height))
        End If
        If lowestV < 0 Then
            VSclBar.Visible = True
            VSclBar.Minimum = lowestV - 50
            VSclBar.Maximum = (lowestV * -1) + 100
            VSclBar.Value = VSclBar.Maximum
        End If
    End Sub
    Private Sub MapEditor_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        scaleSclBars()
    End Sub
End Class