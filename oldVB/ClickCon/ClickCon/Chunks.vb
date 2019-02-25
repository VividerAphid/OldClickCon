Public Class Chunks
    Dim gridChunk() As Point = {New Point(50, 50), New Point(50, 100), New Point(50, 150), New Point(50, 200), New Point(50, 250), New Point(50, 300),
                                              New Point(100, 50), New Point(100, 100), New Point(100, 150), New Point(100, 200), New Point(100, 250), New Point(100, 300),
                                              New Point(150, 50), New Point(150, 100), New Point(150, 150), New Point(150, 200), New Point(150, 250), New Point(150, 300),
                                              New Point(200, 50), New Point(200, 100), New Point(200, 150), New Point(200, 200), New Point(200, 250), New Point(200, 300),
                                              New Point(250, 50), New Point(250, 100), New Point(250, 150), New Point(250, 200), New Point(250, 250), New Point(250, 300),
                                              New Point(300, 50), New Point(300, 100), New Point(300, 150), New Point(300, 200), New Point(300, 250), New Point(300, 300)} 'gridChunk (Medium)
    Dim clusterChunk() As Point = {New Point(21, 17), New Point(73, 8), New Point(187, 15), New Point(8, 68), New Point(54, 54), New Point(105, 58),
                                   New Point(154, 44), New Point(191, 68), New Point(228, 40), New Point(47, 104), New Point(103, 112), New Point(172, 116),
                                   New Point(232, 104), New Point(6, 159), New Point(64, 159), New Point(156, 151), New Point(205, 154), New Point(248, 175),
                                   New Point(39, 190), New Point(204, 266), New Point(90, 194), New Point(161, 200), New Point(203, 203), New Point(250, 226),
                                   New Point(6, 226), New Point(57, 234), New Point(25, 270), New Point(107, 248), New Point(163, 240)} 'clusterChunk (Medium)
    Dim antChunk() As Point = {New Point(10, 35), New Point(78, 13), New Point(175, 4), New Point(69, 77), New Point(238, 15), New Point(30, 75),
                               New Point(120, 79), New Point(150, 46), New Point(202, 50), New Point(264, 68), New Point(34, 126), New Point(97, 130),
                               New Point(211, 93), New Point(152, 117), New Point(14, 173), New Point(57, 200), New Point(117, 178), New Point(167, 182),
                               New Point(220, 171), New Point(244, 125), New Point(19, 246), New Point(65, 253), New Point(101, 220), New Point(128, 269),
                               New Point(157, 229), New Point(213, 230), New Point(266, 198), New Point(260, 264)} 'antChunk (Medium)
    Dim scatterChunk() As Point = {New Point(1, 8), New Point(254, 261), New Point(2, 260), New Point(263, 0), New Point(37, 38), New Point(95, 76), New Point(145, 132),
New Point(184, 202), New Point(113, 225), New Point(45, 103), New Point(26, 172), New Point(79, 146), New Point(52, 254), New Point(178, 267),
New Point(51, 196), New Point(130, 171), New Point(211, 150), New Point(237, 198), New Point(240, 74), New Point(158, 35), New Point(84, 6),
New Point(222, 2), New Point(206, 58), New Point(167, 81), New Point(122, 0), New Point(96, 41), New Point(7, 73), New Point(-3, 122), New Point(-5, 206),
New Point(248, 131)} 'ScatterChunk (Medium)
    Dim scatterChunk2() As Point = {New Point(12, 15), New Point(54, 17), New Point(17, 54), New Point(2, 88), New Point(50, 70), New Point(99, 34), New Point(100, 71),
                                  New Point(46, 117), New Point(101, 139), New Point(10, 128), New Point(41, 159), New Point(12, 206), New Point(104, 185), New Point(51, 234),
                                  New Point(94, 238), New Point(167, 220), New Point(269, 264), New Point(214, 224), New Point(158, 259), New Point(50, 192), New Point(142, 167),
                                  New Point(129, 216), New Point(186, 173), New Point(241, 192), New Point(246, 138), New Point(182, 122), New Point(138, 101), New Point(166, 40),
                                  New Point(227, 68), New Point(180, 76), New Point(266, 97), New Point(132, -2), New Point(257, 31), New Point(209, 37), New Point(187, 0), New Point(228, -3)} 'ScatterChunk2 (Medium)
    Dim dummyChunk As New List(Of Point)

    Function loadChunk(XShift As Integer, YShift As Integer, quad As Integer)
        Dim chunky() As Point
        Dim pick = GameScreen.rander.Next(4)
        Dim targArr() As Point
        Select Case pick
            Case 0
                ReDim targArr(gridChunk.Length - 1)
                targArr = gridChunk.ToArray()
            Case 1
                ReDim targArr(clusterChunk.Length - 1)
                targArr = clusterChunk.ToArray()
            Case 2
                ReDim targArr(antChunk.Length - 1)
                targArr = antChunk.ToArray()
            Case 3
                ReDim targArr(scatterChunk2.Length - 1)
                targArr = scatterChunk2.ToArray()
        End Select
        If pick <> 0 Then
            Select Case quad
                Case 1

                Case 2
                    XShift += 30
                Case 3
                    YShift += 30
                    XShift += 30
                Case 4
                    YShift += 30
            End Select
        End If
        ReDim chunky(targArr.Length - 1)
        For q = 0 To chunky.Length - 1
            chunky(q) = New Point(targArr(q).X + XShift, targArr(q).Y + YShift)
        Next
        Return chunky.ToList()
    End Function
    Function makeChunk(count As Integer, dia As Integer)
        Dim scaleX, scaleY As Integer
        If count > 150 Then
            scaleX = 850
            scaleY = 650
        ElseIf count > 120 Then
            scaleX = 750
            scaleY = 550
        ElseIf count > 100 Then
            scaleX = 650
            scaleY = 500
        Else
            scaleX = 550
            scaleY = 500
        End If
        Dim tempPoint As New Point(GameScreen.rander.Next(30, scaleX), GameScreen.rander.Next(30, scaleY))
        Dim attempts As Integer = 0
        dummyChunk.Add(tempPoint)
        While attempts < 30 And dummyChunk.Count <> count
            attempts = 0
            tempPoint = New Point(GameScreen.rander.Next(30, scaleX), GameScreen.rander.Next(30, scaleY))
            For x = 0 To dummyChunk.Count - 1
                If tempPoint.X > dummyChunk(x).X - dia And tempPoint.X < dummyChunk(x).X + (dia * 2) + 10 Then
                    If tempPoint.Y > dummyChunk(x).Y - dia And tempPoint.Y < dummyChunk(x).Y + (dia * 2) + 10 Then
                        attempts += 1
                        tempPoint = New Point(GameScreen.rander.Next(30, scaleX), GameScreen.rander.Next(30, scaleY))
                        x = 0
                    End If
                End If
            Next
            dummyChunk.Add(tempPoint)
        End While
        Return dummyChunk
    End Function
End Class