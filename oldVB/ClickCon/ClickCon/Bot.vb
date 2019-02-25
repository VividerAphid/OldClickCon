Public Class Bot
    Dim type As Integer
    Dim fails As Integer
    Dim skippedTurns As Integer
    Dim sleepTime As Integer = 200
    Dim failMax As Integer = 59
    Public Sub move()
        fails = 0
        If GameScreen.gameStarted Then
            System.Threading.Thread.Sleep(sleepTime)
            Select Case type
                Case 0
                    WildStep(GameScreen.turnOwner)
                Case 1
                    WildExpand(GameScreen.turnOwner)
                Case 2
                    Turtle(GameScreen.turnOwner)
                Case 3
                    Bully(GameScreen.turnOwner)
                Case 4
                    Dethroner(GameScreen.turnOwner)
            End Select
        End If
    End Sub
    'Bot behaviours
    Public Sub WildStep(play As Integer)
        'BEHAVIOUR TYPE: Picks a random connection off of a planeto it owns, and moves there. Potential to put up shields on its own planets
        Dim allOcc As Boolean = True
        Dim botStep As Integer = GameScreen.rander.Next(GameScreen.players(play - 1).owned.Count)
        Dim tempCons() As Integer = GameScreen.gameMap(GameScreen.players(play - 1).owned(botStep)).getConnections()
        Dim pick As Integer
        While allOcc
            For x = 0 To tempCons.Length - 1
                If GameScreen.gameMap(tempCons(pick)).getShield() Or GameScreen.gameMap(tempCons(pick)).getLockLife() > 0 Then
                    fails += 1
                    If fails > failMax Then
                        skippedTurns += 1
                        If skippedTurns = 10 Then
                            GameScreen.surrender()
                            Exit Sub
                        Else
                            GameScreen.changePlayer()
                            Exit Sub
                        End If
                    Else
                        pick = GameScreen.rander.Next(tempCons.Length)
                    End If
                Else
                    allOcc = False
                End If
            Next
            If allOcc Then
                botStep = GameScreen.rander.Next(GameScreen.players(play - 1).owned.Count)
                Dim templength As Integer = GameScreen.gameMap(GameScreen.players(play - 1).owned(botStep)).getConnections().Length
                ReDim tempCons(templength - 1)
                tempCons = GameScreen.gameMap(GameScreen.players(play - 1).owned(botStep)).getConnections()
                pick = GameScreen.rander.Next(tempCons.Length)
            End If
        End While
        GameScreen.makeMove(GameScreen.gameMap(tempCons(pick)))
        skippedTurns = 0
    End Sub
    Public Sub WildExpand(play As Integer)
        'BEHAVIOUR TYPE: Picks a random connection off a planeto it owns, and moves there ONLY if it isn't own by the bot. No shields
        Dim allOcc As Boolean = True
        Dim botStep As Integer = GameScreen.rander.Next(GameScreen.players(play - 1).owned.Count)
        Dim tempCons() As Integer = GameScreen.gameMap(GameScreen.players(play - 1).owned(botStep)).getConnections()
        Dim pick As Integer
        While allOcc
            For x = 0 To tempCons.Length - 1
                If GameScreen.gameMap(tempCons(pick)).getOwner() = GameScreen.turnOwner Or GameScreen.gameMap(tempCons(pick)).getLockLife() > 0 Then
                    fails += 1
                    If fails > failMax Then
                        skippedTurns += 1
                        If skippedTurns = 10 Then
                            GameScreen.surrender()
                            Exit Sub
                        Else
                            GameScreen.changePlayer()
                            Exit Sub
                        End If
                    Else
                        pick = GameScreen.rander.Next(tempCons.Length)
                    End If
                Else
                    allOcc = False
                End If
            Next
            If allOcc Then
                botStep = GameScreen.rander.Next(GameScreen.players(play - 1).owned.Count)
                Dim lil() As Integer = GameScreen.gameMap(GameScreen.players(play - 1).owned(botStep)).getConnections()
                Dim templength = lil.Length - 1
                ReDim tempCons(templength)
                tempCons = GameScreen.gameMap(GameScreen.players(play - 1).owned(botStep)).getConnections()
                pick = GameScreen.rander.Next(tempCons.Length)
            End If
        End While
        skippedTurns = 0
        GameScreen.makeMove(GameScreen.gameMap(tempCons(pick)))
    End Sub
    Public Sub Turtle(play As Integer)
        'BEHAVIOUR TYPE: Always makes sure all planetos it owns are shielded before moving to a new one, then uses WildExpand behaviour
        Dim AllCov As Boolean = True
        For x = 0 To GameScreen.players(play - 1).owned.Count - 1
            If GameScreen.gameMap(GameScreen.players(play - 1).owned(x)).getShield() = False Then
                GameScreen.makeMove(GameScreen.gameMap(GameScreen.players(play - 1).owned(x)))
                AllCov = False
                Exit For
            End If
        Next
        If AllCov Then
            WildExpand(play)
        End If
    End Sub
    Public Sub Bully(play As Integer)
        'BEHAVIOUR TYPE: Always hits the player with the lowest score if it can reach, otherwise, simple WildExpand behaviour
        WildExpand(play)
    End Sub
    Public Sub Dethroner(play As Integer)
        'BEHAVIOUR TYPE: Always hits the player with the highest score if it can reach, otherwise, simple WildExpand behaviour
        WildExpand(play)
    End Sub
    Public Sub plagueBot()
        'BEHAVIOUR TYPE: Behaves like the WildExpand, but with multiple moves per turn. Designated for the future "plague" gametype.

    End Sub

    'Bot getters and setters
    Public Sub setType(tp As Integer)
        type = tp
    End Sub
    Public Function getBotType()
        Return type
    End Function

End Class