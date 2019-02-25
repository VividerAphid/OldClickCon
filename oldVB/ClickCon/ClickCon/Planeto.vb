Public Class Planeto
    Public changed = True
    Public recentShield = False
    Dim Owner As Integer
    Dim prevOwner As Integer = -1
    Dim team As Integer
    Dim IDNum As Integer
    Dim Colour As Color
    Dim teamCol As Color
    Dim lockedLife As Integer
    Dim heatLife As Integer = 0
    Dim heat As Integer
    Dim heatCap As Integer
    Dim Connections As List(Of Integer)
    Dim Location As Point
    Dim diameter As Integer = 50
    Dim hasShield As Boolean = False
    Sub LoadUp(own As Integer, col As Color, loc As Point, cons() As Integer)
        Owner = own
        Colour = col
        Location = loc
        Connections = cons.ToList()
        heatCap = GameScreen.rander.Next(4, 8)
    End Sub
    Sub DrawCons(draw As Graphics, planetosArr() As Planeto)
        If GameScreen.cleanLoad Then
            For C = 0 To Connections.Count - 1
                If planetosArr(Connections(C)).getOwner <> Owner Or Owner = 0 Then
                    draw.DrawLine(New Pen(Color.Gray, 3), New Point(Location.X + diameter / 2, Location.Y + diameter / 2), New Point(planetosArr(Connections(C)).Location.X + planetosArr(Connections(C)).diameter / 2, planetosArr(Connections(C)).Location.Y + planetosArr(Connections(C)).diameter / 2))
                Else
                    draw.DrawLine(New Pen(Colour, 3), New Point(Location.X + diameter / 2, Location.Y + diameter / 2), New Point(planetosArr(Connections(C)).Location.X + planetosArr(Connections(C)).diameter / 2, planetosArr(Connections(C)).Location.Y + planetosArr(Connections(C)).diameter / 2))
                End If
            Next
        End If
    End Sub
    Sub DrawPlaneto(draw As Graphics)
        If GameScreen.cleanLoad Then
            Dim brush As New SolidBrush(Colour)
            draw.FillEllipse(brush, Location.X, Location.Y, diameter, diameter)
            If hasShield Then
                draw.DrawEllipse(New Pen(Brushes.Cyan, 2), Location.X - 5, Location.Y - 5, diameter + 10, diameter + 10)
                recentShield = True
            End If
            If lockedLife > 0 Then
                If diameter >= 25 Then
                    draw.FillEllipse(Brushes.Black, Location.X + 3, Location.Y + 3, diameter - 6, diameter - 6)
                Else
                    draw.FillEllipse(Brushes.Black, Location.X + 1, Location.Y + 1, diameter - 2, diameter - 2)
                End If
            End If
            If GameScreen.debugMode Then
                Dim idLbl As New Label
                idLbl.Location = New Point(Location.X, Location.Y)
                idLbl.Text = IDNum
                idLbl.AutoSize = True
                GameScreen.Controls.Add(idLbl)
            End If
            changed = False
        End If
    End Sub
    Sub setID(num As Integer)
        IDNum = num
    End Sub
    Sub setOwner(own As Integer)
        heatLife = 2
        If prevOwner = own Then
            heat += 1
            If heat = heatCap Then
                setLockLife(GameScreen.rander.Next(1, 6))
                heat = 0
                Owner = 0
                setColour(Color.White)
            Else
                prevOwner = Owner
                Owner = own
            End If
        Else
            prevOwner = Owner
            Owner = own
            heat = 0
        End If
        changed = True
    End Sub
    Sub setTeam(tm As Integer)
        team = tm
    End Sub
    Sub setColour(col As Color)
        Colour = col
    End Sub
    Sub setTeamColour(col As Color)
        teamCol = col
    End Sub
    Sub setDiameter(newDia As Integer)
        diameter = newDia
    End Sub
    Sub setShield(drep As Boolean)
        hasShield = drep
        changed = True
    End Sub
    Sub setLockLife(dur As Integer)
        lockedLife = dur
    End Sub
    Sub setConnections(cons As List(Of Integer))
        Connections = cons.ToList()
    End Sub
    Sub setConnections(cons() As Integer)
        Connections = cons.ToList()
    End Sub
    Sub setLocation(pnt As Point)
        Location = pnt
        changed = True
    End Sub
    Sub decayLockLife()
        If lockedLife > 0 Then
            lockedLife -= 1
            If lockedLife = 0 Then
                DrawPlaneto(GameScreen.CreateGraphics())
            End If
        End If
        If heatLife > 0 Then
            heatLife -= 1
            If heatLife < 1 Then
                heat = 0
            End If
        End If
    End Sub
    Sub addConnection(add As Integer)
        Connections.Add(add)
        Connections.Sort()
        Dim temp As New List(Of Integer)
        temp = Connections
        Connections = temp.Distinct().ToList()
    End Sub
    Sub removeConnection(del As Integer)
        Connections.Remove(del)
    End Sub
    Function getLocation()
        Return Location
    End Function
    Function getTeam()
        Return team
    End Function
    Function getDiameter()
        Return diameter
    End Function
    Function getOwner()
        Return Owner
    End Function
    Function getID()
        Return IDNum
    End Function
    Function getConnections()
        Return Connections.ToArray()
    End Function
    Function getShield()
        Return hasShield
    End Function
    Function getLockLife()
        Return lockedLife
    End Function
    Function getColour()
        Return Colour
    End Function
End Class