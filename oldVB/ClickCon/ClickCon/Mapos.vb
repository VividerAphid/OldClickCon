Public Class Mapos
    Public map() As Planeto
    Public boners(,) As Integer

    Function Tester(dia As Integer)
        ReDim map(11)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
        Next

        map(0).LoadUp(0, Color.White, New Point(100, 100), {3, 8, 11})
        map(1).LoadUp(0, Color.White, New Point(100, 400), {6, 9, 11})
        map(2).LoadUp(0, Color.White, New Point(400, 100), {5, 8, 10})
        map(3).LoadUp(0, Color.White, New Point(200, 200), {0, 5, 6, 8, 11})
        map(4).LoadUp(0, Color.White, New Point(300, 300), {5, 6, 7, 9, 10})
        map(5).LoadUp(0, Color.White, New Point(300, 200), {2, 3, 4, 8, 10})
        map(6).LoadUp(0, Color.White, New Point(200, 300), {1, 3, 4, 9, 11})
        map(7).LoadUp(0, Color.White, New Point(400, 400), {4, 9, 10})
        map(8).LoadUp(0, Color.White, New Point(250, 100), {0, 2, 3, 5})
        map(9).LoadUp(0, Color.White, New Point(250, 400), {1, 4, 6, 7})
        map(10).LoadUp(0, Color.White, New Point(400, 250), {2, 4, 5, 7})
        map(11).LoadUp(0, Color.White, New Point(100, 250), {0, 1, 3, 6})

        If GameScreen.spawnType = "preset" Then
            map(0).setColour(GameScreen.players(0).colour)
            map(0).setOwner(1)
            map(7).setColour(GameScreen.players(1).colour)
            map(7).setOwner(2)
            If GameScreen.playerCount >= 3 Then
                map(1).setColour(GameScreen.players(2).colour)
                map(1).setOwner(3)
            End If
            If GameScreen.playerCount = 4 Then
                map(2).setColour(GameScreen.players(3).colour)
                map(2).setOwner(4)
            End If
        Else
            spawnSetup()
        End If
        randBoners(3, 4)
        Return map
    End Function
    Function StandardMap(dia As Integer)
        ReDim map(26)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
        Next
        map(0).LoadUp(0, Color.White, New Point(50, 30), {1, 4})
        map(1).LoadUp(0, Color.White, New Point(140, 40), {0, 2, 4, 5, 6})
        map(2).LoadUp(0, Color.White, New Point(225, 20), {1, 6, 7})
        map(3).LoadUp(0, Color.White, New Point(375, 20), {7, 8})
        map(4).LoadUp(0, Color.White, New Point(45, 100), {0, 1, 5, 9})
        map(5).LoadUp(0, Color.White, New Point(125, 125), {1, 4, 6, 9, 10})
        map(6).LoadUp(0, Color.White, New Point(230, 110), {1, 2, 5, 7, 10, 11, 12})
        map(7).LoadUp(0, Color.White, New Point(305, 75), {2, 3, 6, 8, 12})
        map(8).LoadUp(0, Color.White, New Point(415, 100), {3, 7, 12, 13})
        map(9).LoadUp(0, Color.White, New Point(35, 190), {4, 5, 10, 14})
        map(10).LoadUp(0, Color.White, New Point(130, 210), {5, 6, 9, 11, 14, 15})
        map(11).LoadUp(0, Color.White, New Point(235, 210), {6, 10, 12, 15, 16})
        map(12).LoadUp(0, Color.White, New Point(315, 175), {6, 7, 8, 11, 13, 16, 17})
        map(13).LoadUp(0, Color.White, New Point(415, 190), {8, 12, 17, 18, 23})
        map(14).LoadUp(0, Color.White, New Point(65, 285), {9, 10, 15, 19, 20})
        map(15).LoadUp(0, Color.White, New Point(175, 280), {10, 11, 14, 16, 20, 21})
        map(16).LoadUp(0, Color.White, New Point(280, 290), {11, 12, 15, 17, 21, 22, 23})
        map(17).LoadUp(0, Color.White, New Point(355, 265), {12, 13, 16, 23})
        map(18).LoadUp(0, Color.White, New Point(470, 260), {13, 23})
        map(19).LoadUp(0, Color.White, New Point(20, 375), {14, 20})
        map(20).LoadUp(0, Color.White, New Point(115, 385), {14, 15, 19, 21, 24})
        map(21).LoadUp(0, Color.White, New Point(225, 375), {15, 16, 20, 22, 24, 26})
        map(22).LoadUp(0, Color.White, New Point(310, 390), {16, 21, 23, 25, 26})
        map(23).LoadUp(0, Color.White, New Point(415, 330), {13, 16, 17, 18, 22, 25})
        map(24).LoadUp(0, Color.White, New Point(185, 455), {20, 21, 26})
        map(25).LoadUp(0, Color.White, New Point(380, 435), {22, 23})
        map(26).LoadUp(0, Color.White, New Point(290, 490), {21, 22, 24})

        randBoners(4, 5)

        If GameScreen.spawnType = "preset" Then
            map(0).setColour(GameScreen.players(0).colour)
            map(0).setOwner(1)
            map(25).setColour(GameScreen.players(1).colour)
            map(25).setOwner(2)
            If GameScreen.playerCount >= 3 Then
                map(19).setColour(GameScreen.players(2).colour)
                map(19).setOwner(3)
            End If
            If GameScreen.playerCount = 4 Then
                map(3).setColour(GameScreen.players(3).colour)
                map(3).setOwner(4)
            End If
        Else
            spawnSetup()
        End If

        Return map
    End Function
    Function spiralGal(dia As Integer)
        ReDim map(81)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
        Next
        map(0).LoadUp(0, Color.White, New Point(140, 45), {2, 10})
        map(1).LoadUp(0, Color.White, New Point(705, 5), {6, 7, 8})
        map(2).LoadUp(0, Color.White, New Point(55, 65), {0, 9, 10})
        map(3).LoadUp(0, Color.White, New Point(345, 60), {4, 11})
        map(4).LoadUp(0, Color.White, New Point(445, 60), {3, 5, 12, 13})
        map(5).LoadUp(0, Color.White, New Point(530, 40), {4, 6, 14})
        map(6).LoadUp(0, Color.White, New Point(620, 25), {1, 5, 7, 14})
        map(7).LoadUp(0, Color.White, New Point(695, 45), {1, 6, 8, 15, 16})
        map(8).LoadUp(0, Color.White, New Point(765, 40), {1, 7, 16})
        map(9).LoadUp(0, Color.White, New Point(5, 110), {2, 17, 22})
        map(10).LoadUp(0, Color.White, New Point(130, 100), {0, 2, 17, 23})
        map(11).LoadUp(0, Color.White, New Point(305, 105), {3, 18})
        map(12).LoadUp(0, Color.White, New Point(405, 115), {4, 19, 24})
        map(13).LoadUp(0, Color.White, New Point(510, 105), {4, 14, 19, 20})
        map(14).LoadUp(0, Color.White, New Point(580, 90), {5, 6, 13, 15, 20})
        map(15).LoadUp(0, Color.White, New Point(655, 95), {7, 14, 16, 21})
        map(16).LoadUp(0, Color.White, New Point(740, 105), {7, 8, 15})
        map(17).LoadUp(0, Color.White, New Point(80, 135), {9, 10, 22, 23})
        map(18).LoadUp(0, Color.White, New Point(240, 135), {11, 28})
        map(19).LoadUp(0, Color.White, New Point(460, 140), {12, 13, 20, 24, 25})
        map(20).LoadUp(0, Color.White, New Point(535, 145), {13, 14, 19, 21, 25})
        map(21).LoadUp(0, Color.White, New Point(595, 150), {15, 20, 26})
        map(22).LoadUp(0, Color.White, New Point(30, 185), {9, 17, 23, 27})
        map(23).LoadUp(0, Color.White, New Point(135, 165), {10, 17, 22, 27, 28, 33})
        map(24).LoadUp(0, Color.White, New Point(410, 170), {12, 19, 25, 29, 30, 31})
        map(25).LoadUp(0, Color.White, New Point(490, 190), {19, 20, 24, 31})
        map(26).LoadUp(0, Color.White, New Point(685, 195), {21, 32, 39})
        map(27).LoadUp(0, Color.White, New Point(75, 230), {22, 23, 33, 40})
        map(28).LoadUp(0, Color.White, New Point(195, 200), {18, 23, 29, 33, 34})
        map(29).LoadUp(0, Color.White, New Point(290, 220), {24, 28, 30, 34, 35, 36})
        map(30).LoadUp(0, Color.White, New Point(375, 230), {24, 29, 31, 36, 37})
        map(31).LoadUp(0, Color.White, New Point(465, 230), {24, 25, 30, 37, 38, 45})
        map(32).LoadUp(0, Color.White, New Point(630, 235), {26, 39})
        map(33).LoadUp(0, Color.White, New Point(140, 235), {23, 27, 28, 34, 40, 41})
        map(34).LoadUp(0, Color.White, New Point(190, 260), {28, 29, 33, 35, 41, 42})
        map(35).LoadUp(0, Color.White, New Point(265, 280), {29, 34, 36, 42, 43})
        map(36).LoadUp(0, Color.White, New Point(325, 275), {29, 30, 35, 37, 43, 44})
        map(37).LoadUp(0, Color.White, New Point(425, 275), {30, 31, 36, 44, 45, 50})
        map(38).LoadUp(0, Color.White, New Point(550, 270), {31, 45, 46, 51})
        map(39).LoadUp(0, Color.White, New Point(715, 275), {26, 32, 53})
        map(40).LoadUp(0, Color.White, New Point(85, 300), {27, 33, 41})
        map(41).LoadUp(0, Color.White, New Point(160, 315), {33, 34, 40, 42, 47})
        map(42).LoadUp(0, Color.White, New Point(220, 335), {34, 35, 41, 43, 48})
        map(43).LoadUp(0, Color.White, New Point(310, 325), {35, 36, 42, 44, 48, 49})
        map(44).LoadUp(0, Color.White, New Point(375, 310), {36, 37, 43, 49, 50})
        map(45).LoadUp(0, Color.White, New Point(490, 305), {31, 37, 38, 50, 51, 57})
        map(46).LoadUp(0, Color.White, New Point(625, 295), {38, 51, 52, 53})
        map(47).LoadUp(0, Color.White, New Point(160, 385), {41, 54})
        map(48).LoadUp(0, Color.White, New Point(280, 395), {42, 43, 49, 55})
        map(49).LoadUp(0, Color.White, New Point(355, 375), {43, 44, 48, 50, 55, 56, 62})
        map(50).LoadUp(0, Color.White, New Point(425, 340), {37, 44, 45, 49, 56})
        map(51).LoadUp(0, Color.White, New Point(565, 330), {38, 45, 46, 52, 57})
        map(52).LoadUp(0, Color.White, New Point(630, 350), {46, 51, 58, 59})
        map(53).LoadUp(0, Color.White, New Point(705, 335), {39, 46, 59, 60})
        map(54).LoadUp(0, Color.White, New Point(165, 440), {47, 61})
        map(55).LoadUp(0, Color.White, New Point(310, 445), {48, 49, 62, 68})
        map(56).LoadUp(0, Color.White, New Point(440, 400), {49, 50, 57, 62, 63})
        map(57).LoadUp(0, Color.White, New Point(550, 375), {45, 51, 56, 58})
        map(58).LoadUp(0, Color.White, New Point(610, 410), {52, 57, 59, 64, 65, 66})
        map(59).LoadUp(0, Color.White, New Point(690, 395), {52, 53, 58, 60, 66})
        map(60).LoadUp(0, Color.White, New Point(770, 420), {53, 59, 67})
        map(61).LoadUp(0, Color.White, New Point(235, 475), {54, 68})
        map(62).LoadUp(0, Color.White, New Point(375, 460), {49, 55, 56, 63, 68, 69})
        map(63).LoadUp(0, Color.White, New Point(455, 465), {56, 62, 69})
        map(64).LoadUp(0, Color.White, New Point(565, 470), {58, 70})
        map(65).LoadUp(0, Color.White, New Point(640, 485), {58, 66, 71})
        map(66).LoadUp(0, Color.White, New Point(710, 455), {58, 59, 65, 67, 71})
        map(67).LoadUp(0, Color.White, New Point(775, 480), {60, 66, 71, 72})
        map(68).LoadUp(0, Color.White, New Point(310, 500), {55, 61, 62, 69, 75, 76})
        map(69).LoadUp(0, Color.White, New Point(410, 515), {62, 63, 68, 70, 76, 77})
        map(70).LoadUp(0, Color.White, New Point(490, 520), {64, 69})
        map(71).LoadUp(0, Color.White, New Point(705, 530), {65, 66, 67, 72})
        map(72).LoadUp(0, Color.White, New Point(765, 545), {67, 71})
        map(73).LoadUp(0, Color.White, New Point(80, 565), {74, 78})
        map(74).LoadUp(0, Color.White, New Point(165, 550), {73, 75, 78})
        map(75).LoadUp(0, Color.White, New Point(240, 565), {68, 74, 76, 78, 79})
        map(76).LoadUp(0, Color.White, New Point(340, 560), {68, 69, 75, 79, 80})
        map(77).LoadUp(0, Color.White, New Point(435, 570), {69, 80})
        map(78).LoadUp(0, Color.White, New Point(165, 600), {73, 74, 75, 81})
        map(79).LoadUp(0, Color.White, New Point(300, 620), {75, 76, 80})
        map(80).LoadUp(0, Color.White, New Point(390, 620), {76, 77, 79})
        map(81).LoadUp(0, Color.White, New Point(230, 655), {78, 79})

        randBoners(9, 5)

        If GameScreen.spawnType = "preset" Then
            map(0).setColour(GameScreen.players(0).colour)
            map(0).setOwner(1)
            map(72).setColour(GameScreen.players(1).colour)
            map(72).setOwner(2)
            If GameScreen.playerCount >= 3 Then
                map(8).setColour(GameScreen.players(2).colour)
                map(8).setOwner(3)
            End If
            If GameScreen.playerCount = 4 Then
                map(73).setColour(GameScreen.players(3).colour)
                map(73).setOwner(4)
            End If
        Else
            spawnSetup()
        End If
        Return map
    End Function
    Function ringODeth(dia As Integer)
        ReDim map(88)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
        Next
        map(0).LoadUp(0, Color.White, New Point(195, 40), {1, 6, 7, 8})
        map(1).LoadUp(0, Color.White, New Point(290, 35), {0, 2, 8, 9})
        map(2).LoadUp(0, Color.White, New Point(400, 20), {1, 3, 9, 10})
        map(3).LoadUp(0, Color.White, New Point(495, 40), {2, 4, 10, 11})
        map(4).LoadUp(0, Color.White, New Point(575, 35), {3, 5, 11, 12})
        map(5).LoadUp(0, Color.White, New Point(675, 55), {4, 12, 13})
        map(6).LoadUp(0, Color.White, New Point(150, 80), {0, 7, 14})
        map(7).LoadUp(0, Color.White, New Point(200, 115), {0, 6, 8, 14, 15})
        map(8).LoadUp(0, Color.White, New Point(260, 95), {0, 1, 7})
        map(9).LoadUp(0, Color.White, New Point(375, 85), {1, 2, 10, 16})
        map(10).LoadUp(0, Color.White, New Point(425, 100), {2, 3, 9, 16, 17})
        map(11).LoadUp(0, Color.White, New Point(545, 115), {3, 4, 12})
        map(12).LoadUp(0, Color.White, New Point(630, 125), {4, 5, 11, 13, 18})
        map(13).LoadUp(0, Color.White, New Point(720, 125), {5, 12, 18, 19, 25})
        map(14).LoadUp(0, Color.White, New Point(110, 140), {6, 7, 15, 20, 21})
        map(15).LoadUp(0, Color.White, New Point(180, 180), {7, 14, 21})
        map(16).LoadUp(0, Color.White, New Point(375, 155), {9, 10, 17, 22, 23})
        map(17).LoadUp(0, Color.White, New Point(430, 155), {10, 16, 23, 24})
        map(18).LoadUp(0, Color.White, New Point(670, 185), {12, 13, 25})
        map(19).LoadUp(0, Color.White, New Point(780, 175), {13, 25, 32})
        map(20).LoadUp(0, Color.White, New Point(60, 180), {14, 21, 26})
        map(21).LoadUp(0, Color.White, New Point(125, 210), {14, 15, 20, 26})
        map(22).LoadUp(0, Color.White, New Point(350, 220), {16, 23, 28})
        map(23).LoadUp(0, Color.White, New Point(400, 220), {16, 17, 22, 24, 29})
        map(24).LoadUp(0, Color.White, New Point(440, 210), {17, 23, 29})
        map(25).LoadUp(0, Color.White, New Point(715, 215), {13, 18, 19, 32})
        map(26).LoadUp(0, Color.White, New Point(45, 250), {20, 21, 33, 34})
        map(27).LoadUp(0, Color.White, New Point(325, 270), {28, 37})
        map(28).LoadUp(0, Color.White, New Point(380, 260), {22, 27, 29, 38})
        map(29).LoadUp(0, Color.White, New Point(430, 260), {23, 24, 28, 30, 38, 39, 40})
        map(30).LoadUp(0, Color.White, New Point(475, 250), {29, 31, 40})
        map(31).LoadUp(0, Color.White, New Point(525, 240), {30, 41})
        map(32).LoadUp(0, Color.White, New Point(795, 255), {19, 25, 54, 55})
        map(33).LoadUp(0, Color.White, New Point(10, 340), {26, 34, 44, 56})
        map(34).LoadUp(0, Color.White, New Point(95, 310), {26, 33, 35, 44})
        map(35).LoadUp(0, Color.White, New Point(195, 315), {34, 36, 44, 45, 46})
        map(36).LoadUp(0, Color.White, New Point(275, 320), {35, 46, 47})
        map(37).LoadUp(0, Color.White, New Point(345, 305), {27, 38, 47})
        map(38).LoadUp(0, Color.White, New Point(387, 310), {28, 29, 37, 39, 47})
        map(39).LoadUp(0, Color.White, New Point(425, 330), {29, 38, 40, 47, 48, 49, 50, 51})
        map(40).LoadUp(0, Color.White, New Point(480, 300), {29, 30, 39, 41, 51})
        map(41).LoadUp(0, Color.White, New Point(540, 285), {31, 40, 42, 51, 52})
        map(42).LoadUp(0, Color.White, New Point(590, 280), {41, 43, 52})
        map(43).LoadUp(0, Color.White, New Point(665, 285), {42, 52, 53})
        map(44).LoadUp(0, Color.White, New Point(110, 360), {33, 34, 35, 45, 56})
        map(45).LoadUp(0, Color.White, New Point(205, 380), {35, 44, 46, 59})
        map(46).LoadUp(0, Color.White, New Point(260, 370), {35, 36, 45, 47, 59})
        map(47).LoadUp(0, Color.White, New Point(340, 355), {36, 37, 38, 39, 46, 48, 60})
        map(48).LoadUp(0, Color.White, New Point(380, 375), {39, 47, 49, 60, 61})
        map(49).LoadUp(0, Color.White, New Point(410, 400), {39, 48, 50, 61, 62, 63, 71})
        map(50).LoadUp(0, Color.White, New Point(465, 365), {39, 49, 51, 63})
        map(51).LoadUp(0, Color.White, New Point(520, 350), {39, 40, 41, 50, 52, 63})
        map(52).LoadUp(0, Color.White, New Point(605, 325), {41, 42, 43, 51, 53, 64})
        map(53).LoadUp(0, Color.White, New Point(690, 325), {43, 52, 54, 64, 65})
        map(54).LoadUp(0, Color.White, New Point(750, 320), {32, 53, 55, 65})
        map(55).LoadUp(0, Color.White, New Point(800, 340), {32, 54, 65, 66})
        map(56).LoadUp(0, Color.White, New Point(50, 430), {33, 44, 57, 67})
        map(57).LoadUp(0, Color.White, New Point(145, 455), {56, 58, 67})
        map(58).LoadUp(0, Color.White, New Point(205, 465), {57, 67, 68})
        map(59).LoadUp(0, Color.White, New Point(265, 420), {45, 46, 60})
        map(60).LoadUp(0, Color.White, New Point(325, 400), {47, 48, 59, 61})
        map(61).LoadUp(0, Color.White, New Point(365, 430), {48, 49, 60, 62, 70})
        map(62).LoadUp(0, Color.White, New Point(410, 455), {49, 61, 70, 77})
        map(63).LoadUp(0, Color.White, New Point(485, 410), {50, 51, 49, 71})
        map(64).LoadUp(0, Color.White, New Point(675, 375), {52, 53, 65})
        map(65).LoadUp(0, Color.White, New Point(735, 365), {53, 54, 55, 64, 66, 73})
        map(66).LoadUp(0, Color.White, New Point(820, 405), {55, 65, 73})
        map(67).LoadUp(0, Color.White, New Point(125, 520), {56, 57, 58, 68, 74})
        map(68).LoadUp(0, Color.White, New Point(240, 505), {58, 67, 69, 74, 81})
        map(69).LoadUp(0, Color.White, New Point(310, 520), {68, 75, 81})
        map(70).LoadUp(0, Color.White, New Point(385, 500), {61, 62, 76, 77})
        map(71).LoadUp(0, Color.White, New Point(480, 460), {49, 63})
        map(72).LoadUp(0, Color.White, New Point(665, 480), {73, 79, 80, 84})
        map(73).LoadUp(0, Color.White, New Point(765, 465), {65, 66, 72, 80})
        map(74).LoadUp(0, Color.White, New Point(160, 570), {67, 68, 81})
        map(75).LoadUp(0, Color.White, New Point(320, 575), {69, 81, 82, 85})
        map(76).LoadUp(0, Color.White, New Point(385, 545), {70, 82})
        map(77).LoadUp(0, Color.White, New Point(430, 525), {62, 70, 78, 82})
        map(78).LoadUp(0, Color.White, New Point(475, 550), {77, 82, 86})
        map(79).LoadUp(0, Color.White, New Point(615, 515), {72, 83, 84})
        map(80).LoadUp(0, Color.White, New Point(750, 530), {72, 73, 84})
        map(81).LoadUp(0, Color.White, New Point(230, 605), {68, 69, 74, 75})
        map(82).LoadUp(0, Color.White, New Point(425, 575), {75, 76, 77, 78, 85, 86})
        map(83).LoadUp(0, Color.White, New Point(570, 555), {79, 84, 87, 88})
        map(84).LoadUp(0, Color.White, New Point(675, 560), {72, 79, 80, 83, 88})
        map(85).LoadUp(0, Color.White, New Point(400, 635), {75, 82, 86, 87})
        map(86).LoadUp(0, Color.White, New Point(460, 605), {78, 82, 85, 87})
        map(87).LoadUp(0, Color.White, New Point(530, 630), {83, 85, 86, 88})
        map(88).LoadUp(0, Color.White, New Point(640, 615), {83, 84, 87})

        randBoners(9, 5)

        If GameScreen.spawnType = "preset" Then
            map(33).setColour(GameScreen.players(0).colour)
            map(33).setOwner(1)
            map(55).setColour(GameScreen.players(1).colour)
            map(55).setOwner(2)
            If GameScreen.playerCount >= 3 Then
                map(2).setColour(GameScreen.players(2).colour)
                map(2).setOwner(3)
            End If
            If GameScreen.playerCount = 4 Then
                map(85).setColour(GameScreen.players(3).colour)
                map(85).setOwner(4)
            End If
        Else
            spawnSetup()
        End If
        Return map
    End Function
    Function gridLocked(dia As Integer)
        ReDim map(116)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
        Next

        map(0).LoadUp(0, Color.White, New Point(20, 20), {1, 13})
        map(1).LoadUp(0, Color.White, New Point(85, 20), {0, 2, 14})
        map(2).LoadUp(0, Color.White, New Point(145, 20), {1, 3, 15})
        map(3).LoadUp(0, Color.White, New Point(210, 20), {2, 4, 16})
        map(4).LoadUp(0, Color.White, New Point(275, 20), {3, 5, 17})
        map(5).LoadUp(0, Color.White, New Point(340, 20), {4, 6, 18})
        map(6).LoadUp(0, Color.White, New Point(405, 20), {5, 7, 19})
        map(7).LoadUp(0, Color.White, New Point(470, 20), {6, 8, 20})
        map(8).LoadUp(0, Color.White, New Point(535, 20), {7, 9, 21})
        map(9).LoadUp(0, Color.White, New Point(600, 20), {8, 10, 22})
        map(10).LoadUp(0, Color.White, New Point(665, 20), {9, 11, 23})
        map(11).LoadUp(0, Color.White, New Point(730, 20), {10, 12, 24})
        map(12).LoadUp(0, Color.White, New Point(795, 20), {11, 25})

        map(13).LoadUp(0, Color.White, New Point(20, 98), {0, 14, 26})
        map(14).LoadUp(0, Color.White, New Point(85, 98), {1, 13, 15, 27})
        map(15).LoadUp(0, Color.White, New Point(145, 98), {2, 14, 16, 28})
        map(16).LoadUp(0, Color.White, New Point(210, 98), {3, 15, 17, 29})
        map(17).LoadUp(0, Color.White, New Point(275, 98), {4, 16, 18, 30})
        map(18).LoadUp(0, Color.White, New Point(340, 98), {5, 17, 19, 31})
        map(19).LoadUp(0, Color.White, New Point(405, 98), {6, 18, 20, 32})
        map(20).LoadUp(0, Color.White, New Point(470, 98), {7, 19, 21, 33})
        map(21).LoadUp(0, Color.White, New Point(535, 98), {8, 20, 22, 34})
        map(22).LoadUp(0, Color.White, New Point(600, 98), {9, 21, 23, 35})
        map(23).LoadUp(0, Color.White, New Point(665, 98), {10, 22, 24, 36})
        map(24).LoadUp(0, Color.White, New Point(730, 98), {11, 23, 25, 37})
        map(25).LoadUp(0, Color.White, New Point(795, 98), {12, 24, 38})

        map(26).LoadUp(0, Color.White, New Point(20, 176), {13, 27, 39})
        map(27).LoadUp(0, Color.White, New Point(85, 176), {14, 26, 28, 40})
        map(28).LoadUp(0, Color.White, New Point(145, 176), {15, 27, 29, 41})
        map(29).LoadUp(0, Color.White, New Point(210, 176), {16, 28, 30, 42})
        map(30).LoadUp(0, Color.White, New Point(275, 176), {17, 29, 31, 43})
        map(31).LoadUp(0, Color.White, New Point(340, 176), {18, 30, 32, 44})
        map(32).LoadUp(0, Color.White, New Point(405, 176), {19, 31, 33, 45})
        map(33).LoadUp(0, Color.White, New Point(470, 176), {20, 32, 34, 46})
        map(34).LoadUp(0, Color.White, New Point(535, 176), {21, 33, 35, 47})
        map(35).LoadUp(0, Color.White, New Point(600, 176), {22, 34, 36, 48})
        map(36).LoadUp(0, Color.White, New Point(665, 176), {23, 35, 37, 49})
        map(37).LoadUp(0, Color.White, New Point(730, 176), {24, 36, 38, 50})
        map(38).LoadUp(0, Color.White, New Point(795, 176), {25, 37, 51})

        map(39).LoadUp(0, Color.White, New Point(20, 254), {26, 40, 52})
        map(40).LoadUp(0, Color.White, New Point(85, 254), {27, 39, 41, 53})
        map(41).LoadUp(0, Color.White, New Point(145, 254), {28, 40, 42, 54})
        map(42).LoadUp(0, Color.White, New Point(210, 254), {29, 41, 43, 55})
        map(43).LoadUp(0, Color.White, New Point(275, 254), {30, 42, 44, 56})
        map(44).LoadUp(0, Color.White, New Point(340, 254), {31, 43, 45, 57})
        map(45).LoadUp(0, Color.White, New Point(405, 254), {32, 44, 46, 58})
        map(46).LoadUp(0, Color.White, New Point(470, 254), {33, 45, 47, 59})
        map(47).LoadUp(0, Color.White, New Point(535, 254), {34, 46, 48, 60})
        map(48).LoadUp(0, Color.White, New Point(600, 254), {35, 47, 49, 61})
        map(49).LoadUp(0, Color.White, New Point(665, 254), {36, 48, 50, 62})
        map(50).LoadUp(0, Color.White, New Point(730, 254), {37, 49, 51, 63})
        map(51).LoadUp(0, Color.White, New Point(795, 254), {38, 50, 64})

        map(52).LoadUp(0, Color.White, New Point(20, 332), {39, 53, 65})
        map(53).LoadUp(0, Color.White, New Point(85, 332), {40, 52, 54, 66})
        map(54).LoadUp(0, Color.White, New Point(145, 332), {41, 53, 55, 67})
        map(55).LoadUp(0, Color.White, New Point(210, 332), {42, 54, 56, 68})
        map(56).LoadUp(0, Color.White, New Point(275, 332), {43, 55, 57, 69})
        map(57).LoadUp(0, Color.White, New Point(340, 332), {44, 56, 58, 70})
        map(58).LoadUp(0, Color.White, New Point(405, 332), {45, 57, 59, 71})
        map(59).LoadUp(0, Color.White, New Point(470, 332), {46, 58, 60, 72})
        map(60).LoadUp(0, Color.White, New Point(535, 332), {47, 59, 61, 73})
        map(61).LoadUp(0, Color.White, New Point(600, 332), {48, 60, 62, 74})
        map(62).LoadUp(0, Color.White, New Point(665, 332), {49, 61, 63, 75})
        map(63).LoadUp(0, Color.White, New Point(730, 332), {50, 62, 64, 76})
        map(64).LoadUp(0, Color.White, New Point(795, 332), {51, 63, 77})

        map(65).LoadUp(0, Color.White, New Point(20, 410), {52, 66, 78})
        map(66).LoadUp(0, Color.White, New Point(85, 410), {53, 65, 67, 79})
        map(67).LoadUp(0, Color.White, New Point(145, 410), {54, 66, 68, 80})
        map(68).LoadUp(0, Color.White, New Point(210, 410), {55, 67, 69, 81})
        map(69).LoadUp(0, Color.White, New Point(275, 410), {56, 68, 70, 82})
        map(70).LoadUp(0, Color.White, New Point(340, 410), {57, 69, 71, 83})
        map(71).LoadUp(0, Color.White, New Point(405, 410), {58, 70, 72, 84})
        map(72).LoadUp(0, Color.White, New Point(470, 410), {59, 71, 73, 85})
        map(73).LoadUp(0, Color.White, New Point(535, 410), {60, 72, 74, 86})
        map(74).LoadUp(0, Color.White, New Point(600, 410), {61, 73, 75, 87})
        map(75).LoadUp(0, Color.White, New Point(665, 410), {62, 74, 76, 88})
        map(76).LoadUp(0, Color.White, New Point(730, 410), {63, 75, 77, 89})
        map(77).LoadUp(0, Color.White, New Point(795, 410), {64, 76, 90})

        map(78).LoadUp(0, Color.White, New Point(20, 488), {65, 79, 91})
        map(79).LoadUp(0, Color.White, New Point(85, 488), {66, 78, 80, 92})
        map(80).LoadUp(0, Color.White, New Point(145, 488), {67, 79, 81, 93})
        map(81).LoadUp(0, Color.White, New Point(210, 488), {68, 80, 82, 94})
        map(82).LoadUp(0, Color.White, New Point(275, 488), {69, 81, 83, 95})
        map(83).LoadUp(0, Color.White, New Point(340, 488), {70, 82, 84, 96})
        map(84).LoadUp(0, Color.White, New Point(405, 488), {71, 83, 85, 97})
        map(85).LoadUp(0, Color.White, New Point(470, 488), {72, 84, 86, 98})
        map(86).LoadUp(0, Color.White, New Point(535, 488), {73, 85, 87, 99})
        map(87).LoadUp(0, Color.White, New Point(600, 488), {74, 86, 88, 100})
        map(88).LoadUp(0, Color.White, New Point(665, 488), {75, 87, 89, 101})
        map(89).LoadUp(0, Color.White, New Point(730, 488), {76, 88, 90, 102})
        map(90).LoadUp(0, Color.White, New Point(795, 488), {77, 89, 103})

        map(91).LoadUp(0, Color.White, New Point(20, 566), {78, 92, 104})
        map(92).LoadUp(0, Color.White, New Point(85, 566), {79, 91, 93, 105})
        map(93).LoadUp(0, Color.White, New Point(145, 566), {80, 92, 94, 106})
        map(94).LoadUp(0, Color.White, New Point(210, 566), {81, 93, 95, 107})
        map(95).LoadUp(0, Color.White, New Point(275, 566), {82, 94, 96, 108})
        map(96).LoadUp(0, Color.White, New Point(340, 566), {83, 95, 97, 109})
        map(97).LoadUp(0, Color.White, New Point(405, 566), {84, 96, 98, 110})
        map(98).LoadUp(0, Color.White, New Point(470, 566), {85, 97, 99, 111})
        map(99).LoadUp(0, Color.White, New Point(535, 566), {86, 98, 100, 112})
        map(100).LoadUp(0, Color.White, New Point(600, 566), {87, 99, 101, 113})
        map(101).LoadUp(0, Color.White, New Point(665, 566), {88, 100, 102, 114})
        map(102).LoadUp(0, Color.White, New Point(730, 566), {89, 101, 103, 115})
        map(103).LoadUp(0, Color.White, New Point(795, 566), {90, 102, 116})

        map(104).LoadUp(0, Color.White, New Point(20, 644), {91, 105})
        map(105).LoadUp(0, Color.White, New Point(85, 644), {92, 104, 106})
        map(106).LoadUp(0, Color.White, New Point(145, 644), {93, 105, 107})
        map(107).LoadUp(0, Color.White, New Point(210, 644), {94, 106, 108})
        map(108).LoadUp(0, Color.White, New Point(275, 644), {95, 107, 109})
        map(109).LoadUp(0, Color.White, New Point(340, 644), {96, 108, 110})
        map(110).LoadUp(0, Color.White, New Point(405, 644), {97, 109, 111})
        map(111).LoadUp(0, Color.White, New Point(470, 644), {98, 110, 112})
        map(112).LoadUp(0, Color.White, New Point(535, 644), {99, 111, 113})
        map(113).LoadUp(0, Color.White, New Point(600, 644), {100, 112, 114})
        map(114).LoadUp(0, Color.White, New Point(665, 644), {101, 113, 115})
        map(115).LoadUp(0, Color.White, New Point(730, 644), {102, 114, 116})
        map(116).LoadUp(0, Color.White, New Point(795, 644), {103, 115})

        randBoners(12, 6)

        If GameScreen.spawnType = "preset" Then
            map(0).setColour(GameScreen.players(0).colour)
            map(0).setOwner(1)
            map(116).setColour(GameScreen.players(1).colour)
            map(116).setOwner(2)
            If GameScreen.playerCount >= 3 Then
                map(12).setColour(GameScreen.players(2).colour)
                map(12).setOwner(3)
            End If
            If GameScreen.playerCount = 4 Then
                map(104).setColour(GameScreen.players(3).colour)
                map(104).setOwner(4)
            End If
        Else
            spawnSetup()
        End If

        Return map
    End Function
    Function heartBreak(dia As Integer)
        ReDim map(82)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
        Next

        map(0).LoadUp(0, Color.White, New Point(210, 75), {2, 3, 8})
        map(1).LoadUp(0, Color.White, New Point(550, 75), {4, 5})
        map(2).LoadUp(0, Color.White, New Point(160, 90), {0, 6})
        map(3).LoadUp(0, Color.White, New Point(255, 100), {0, 8, 9})
        map(4).LoadUp(0, Color.White, New Point(500, 90), {1, 10, 11})
        map(5).LoadUp(0, Color.White, New Point(590, 115), {1, 12, 13})
        map(6).LoadUp(0, Color.White, New Point(120, 125), {2, 7, 14})
        map(7).LoadUp(0, Color.White, New Point(175, 135), {6, 8, 15})
        map(8).LoadUp(0, Color.White, New Point(220, 135), {0, 3, 7, 16})
        map(9).LoadUp(0, Color.White, New Point(285, 150), {3, 17, 18})
        map(10).LoadUp(0, Color.White, New Point(455, 115), {4, 19, 20})
        map(11).LoadUp(0, Color.White, New Point(510, 145), {4, 12, 20, 21})
        map(12).LoadUp(0, Color.White, New Point(555, 150), {5, 11, 13, 21, 22})
        map(13).LoadUp(0, Color.White, New Point(610, 165), {5, 12, 23})
        map(14).LoadUp(0, Color.White, New Point(95, 175), {6, 15, 24})
        map(15).LoadUp(0, Color.White, New Point(145, 180), {7, 14, 25})
        map(16).LoadUp(0, Color.White, New Point(200, 185), {8, 17, 26})
        map(17).LoadUp(0, Color.White, New Point(250, 190), {9, 16, 28})
        map(18).LoadUp(0, Color.White, New Point(320, 205), {9, 19, 28})
        map(19).LoadUp(0, Color.White, New Point(420, 165), {10, 18, 29})
        map(20).LoadUp(0, Color.White, New Point(465, 170), {10, 11, 30})
        map(21).LoadUp(0, Color.White, New Point(530, 190), {11, 12, 30, 31})
        map(22).LoadUp(0, Color.White, New Point(580, 210), {12, 23, 32})
        map(23).LoadUp(0, Color.White, New Point(625, 220), {13, 22, 33})
        map(24).LoadUp(0, Color.White, New Point(80, 240), {14, 25, 34})
        map(25).LoadUp(0, Color.White, New Point(130, 225), {15, 24, 26})
        map(26).LoadUp(0, Color.White, New Point(185, 230), {16, 25, 27, 35, 36})
        map(27).LoadUp(0, Color.White, New Point(230, 260), {26, 28})
        map(28).LoadUp(0, Color.White, New Point(285, 245), {17, 18, 27, 37, 38})
        map(29).LoadUp(0, Color.White, New Point(440, 220), {19, 30, 39})
        map(30).LoadUp(0, Color.White, New Point(490, 220), {20, 21, 29, 40})
        map(31).LoadUp(0, Color.White, New Point(525, 250), {21, 32, 41})
        map(32).LoadUp(0, Color.White, New Point(575, 270), {22, 31, 33, 42})
        map(33).LoadUp(0, Color.White, New Point(625, 280), {23, 32, 43})
        map(34).LoadUp(0, Color.White, New Point(85, 295), {24, 35, 44})
        map(35).LoadUp(0, Color.White, New Point(125, 270), {26, 34, 45})
        map(36).LoadUp(0, Color.White, New Point(190, 300), {26, 37, 45, 46})
        map(37).LoadUp(0, Color.White, New Point(240, 300), {28, 36, 47, 48})
        map(38).LoadUp(0, Color.White, New Point(325, 285), {28, 39, 48})
        map(39).LoadUp(0, Color.White, New Point(405, 265), {29, 38, 49})
        map(40).LoadUp(0, Color.White, New Point(465, 260), {30, 41, 49})
        map(41).LoadUp(0, Color.White, New Point(505, 285), {31, 40, 42, 50})
        map(42).LoadUp(0, Color.White, New Point(560, 325), {32, 41, 43, 50})
        map(43).LoadUp(0, Color.White, New Point(615, 340), {33, 42, 51, 52})
        map(44).LoadUp(0, Color.White, New Point(105, 345), {34, 45, 53})
        map(45).LoadUp(0, Color.White, New Point(145, 310), {35, 36, 44, 46})
        map(46).LoadUp(0, Color.White, New Point(175, 350), {36, 45, 54})
        map(47).LoadUp(0, Color.White, New Point(235, 350), {37, 54, 55})
        map(48).LoadUp(0, Color.White, New Point(280, 325), {37, 38, 56})
        map(49).LoadUp(0, Color.White, New Point(435, 310), {39, 40, 57, 58})
        map(50).LoadUp(0, Color.White, New Point(510, 335), {41, 42, 51, 58})
        map(51).LoadUp(0, Color.White, New Point(550, 380), {43, 50, 52, 59})
        map(52).LoadUp(0, Color.White, New Point(595, 395), {43, 51, 61})
        map(53).LoadUp(0, Color.White, New Point(135, 395), {44, 54, 62})
        map(54).LoadUp(0, Color.White, New Point(200, 390), {46, 47, 53, 62, 63})
        map(55).LoadUp(0, Color.White, New Point(255, 390), {47, 63, 64})
        map(56).LoadUp(0, Color.White, New Point(305, 375), {48, 64})
        map(57).LoadUp(0, Color.White, New Point(405, 355), {49, 58, 65})
        map(58).LoadUp(0, Color.White, New Point(460, 355), {49, 50, 57, 59})
        map(59).LoadUp(0, Color.White, New Point(500, 405), {51, 58, 60, 66})
        map(60).LoadUp(0, Color.White, New Point(515, 445), {59, 61, 67, 68})
        map(61).LoadUp(0, Color.White, New Point(565, 445), {52, 60, 68})
        map(62).LoadUp(0, Color.White, New Point(165, 435), {53, 54, 69})
        map(63).LoadUp(0, Color.White, New Point(230, 430), {54, 55, 70})
        map(64).LoadUp(0, Color.White, New Point(295, 425), {55, 56, 70, 71})
        map(65).LoadUp(0, Color.White, New Point(440, 400), {57, 66, 72})
        map(66).LoadUp(0, Color.White, New Point(465, 445), {59, 65, 73})
        map(67).LoadUp(0, Color.White, New Point(480, 500), {60, 73, 74, 75})
        map(68).LoadUp(0, Color.White, New Point(535, 490), {60, 61, 75})
        map(69).LoadUp(0, Color.White, New Point(200, 475), {62, 76})
        map(70).LoadUp(0, Color.White, New Point(265, 470), {63, 64, 71, 76})
        map(71).LoadUp(0, Color.White, New Point(335, 470), {64, 70, 72, 77})
        map(72).LoadUp(0, Color.White, New Point(405, 445), {65, 71, 73})
        map(73).LoadUp(0, Color.White, New Point(435, 490), {66, 67, 72, 74})
        map(74).LoadUp(0, Color.White, New Point(440, 535), {67, 73, 79, 80})
        map(75).LoadUp(0, Color.White, New Point(500, 535), {67, 68, 80})
        map(76).LoadUp(0, Color.White, New Point(240, 515), {69, 70, 81})
        map(77).LoadUp(0, Color.White, New Point(320, 520), {71, 78, 81})
        map(78).LoadUp(0, Color.White, New Point(355, 560), {77, 79, 82})
        map(79).LoadUp(0, Color.White, New Point(410, 605), {74, 78, 80})
        map(80).LoadUp(0, Color.White, New Point(460, 575), {74, 75, 79})
        map(81).LoadUp(0, Color.White, New Point(280, 560), {76, 77, 82})
        map(82).LoadUp(0, Color.White, New Point(315, 600), {81, 78})

        randBoners(9, 5)

        If GameScreen.spawnType = "preset" Then
            map(7).setColour(GameScreen.players(0).colour)
            map(7).setOwner(1)
            map(12).setColour(GameScreen.players(1).colour)
            map(12).setOwner(2)
            If GameScreen.playerCount >= 3 Then
                map(59).setColour(GameScreen.players(2).colour)
                map(59).setOwner(3)
            End If
            If GameScreen.playerCount = 4 Then
                map(63).setColour(GameScreen.players(3).colour)
                map(63).setOwner(4)
            End If
        Else
            spawnSetup()
        End If

        Return map
    End Function
    Function jibbers(dia As Integer)
        ReDim map(84)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
        Next

        map(0).LoadUp(0, Color.White, New Point(80, 15), {1, 2})
        map(1).LoadUp(0, Color.White, New Point(140, 10), {0, 2, 3})
        map(2).LoadUp(0, Color.White, New Point(120, 50), {0, 1, 3, 7})
        map(3).LoadUp(0, Color.White, New Point(185, 35), {1, 2, 4})
        map(4).LoadUp(0, Color.White, New Point(225, 60), {3, 7, 8, 11})
        map(5).LoadUp(0, Color.White, New Point(70, 110), {6, 9})
        map(6).LoadUp(0, Color.White, New Point(135, 105), {5, 7, 9, 10})
        map(7).LoadUp(0, Color.White, New Point(180, 80), {2, 4, 6, 10})
        map(8).LoadUp(0, Color.White, New Point(290, 75), {4, 11, 12, 13})
        map(9).LoadUp(0, Color.White, New Point(110, 140), {5, 6, 10})
        map(10).LoadUp(0, Color.White, New Point(160, 140), {6, 7, 9, 11})
        map(11).LoadUp(0, Color.White, New Point(210, 115), {4, 8, 10, 12})
        map(12).LoadUp(0, Color.White, New Point(275, 125), {8, 11, 13, 14})
        map(13).LoadUp(0, Color.White, New Point(340, 120), {8, 12, 14, 15})
        map(14).LoadUp(0, Color.White, New Point(315, 170), {12, 13, 15, 20, 21})
        map(15).LoadUp(0, Color.White, New Point(385, 163), {13, 14, 21})
        map(16).LoadUp(0, Color.White, New Point(65, 250), {17})
        map(17).LoadUp(0, Color.White, New Point(130, 265), {16, 18})
        map(18).LoadUp(0, Color.White, New Point(190, 250), {17, 19, 28, 38, 39})
        map(19).LoadUp(0, Color.White, New Point(235, 215), {18, 20, 28})
        map(20).LoadUp(0, Color.White, New Point(295, 210), {14, 19, 21, 28, 29})
        map(21).LoadUp(0, Color.White, New Point(375, 215), {14, 15, 20, 22, 29, 30})
        map(22).LoadUp(0, Color.White, New Point(450, 230), {21, 30, 31})
        map(23).LoadUp(0, Color.White, New Point(530, 225), {31, 32, 33})
        map(24).LoadUp(0, Color.White, New Point(640, 225), {33, 34, 35})
        map(25).LoadUp(0, Color.White, New Point(725, 195), {26, 27, 35, 36})
        map(26).LoadUp(0, Color.White, New Point(770, 155), {25, 27})
        map(27).LoadUp(0, Color.White, New Point(800, 205), {25, 26, 36, 37})
        map(28).LoadUp(0, Color.White, New Point(275, 260), {18, 19, 20, 29, 39, 40})
        map(29).LoadUp(0, Color.White, New Point(340, 265), {20, 21, 28, 30, 40, 41})
        map(30).LoadUp(0, Color.White, New Point(405, 265), {21, 22, 29, 41, 42, 43})
        map(31).LoadUp(0, Color.White, New Point(490, 260), {22, 23, 32, 43, 57})
        map(32).LoadUp(0, Color.White, New Point(530, 280), {23, 31, 33, 44})
        map(33).LoadUp(0, Color.White, New Point(585, 270), {23, 24, 32, 34, 45})
        map(34).LoadUp(0, Color.White, New Point(640, 280), {24, 33, 35, 46})
        map(35).LoadUp(0, Color.White, New Point(685, 270), {24, 25, 34, 36, 47, 48})
        map(36).LoadUp(0, Color.White, New Point(745, 245), {25, 27, 35, 37})
        map(37).LoadUp(0, Color.White, New Point(785, 260), {27, 36, 48, 49})
        map(38).LoadUp(0, Color.White, New Point(185, 315), {18, 39, 52})
        map(39).LoadUp(0, Color.White, New Point(245, 310), {18, 28, 38, 53})
        map(40).LoadUp(0, Color.White, New Point(300, 300), {28, 29, 41, 53})
        map(41).LoadUp(0, Color.White, New Point(350, 330), {29, 30, 40, 42, 54, 55})
        map(42).LoadUp(0, Color.White, New Point(410, 325), {30, 41, 55, 56})
        map(43).LoadUp(0, Color.White, New Point(450, 295), {30, 31, 56})
        map(44).LoadUp(0, Color.White, New Point(530, 340), {32, 45, 57, 58})
        map(45).LoadUp(0, Color.White, New Point(585, 350), {33, 44, 46, 58, 59})
        map(46).LoadUp(0, Color.White, New Point(640, 335), {34, 45, 47, 59})
        map(47).LoadUp(0, Color.White, New Point(685, 340), {35, 46, 48, 59, 60, 61})
        map(48).LoadUp(0, Color.White, New Point(740, 300), {35, 37, 47, 49})
        map(49).LoadUp(0, Color.White, New Point(780, 330), {37, 48, 61, 62})
        map(50).LoadUp(0, Color.White, New Point(80, 395), {51})
        map(51).LoadUp(0, Color.White, New Point(140, 385), {50, 52})
        map(52).LoadUp(0, Color.White, New Point(200, 375), {38, 51, 53, 63})
        map(53).LoadUp(0, Color.White, New Point(275, 340), {39, 40, 52, 54, 63})
        map(54).LoadUp(0, Color.White, New Point(315, 375), {41, 53, 55, 63, 64})
        map(55).LoadUp(0, Color.White, New Point(385, 370), {41, 42, 54, 56, 64, 65})
        map(56).LoadUp(0, Color.White, New Point(450, 345), {42, 43, 55, 57, 66})
        map(57).LoadUp(0, Color.White, New Point(490, 360), {31, 44, 56, 58, 66})
        map(58).LoadUp(0, Color.White, New Point(530, 400), {44, 45, 57})
        map(59).LoadUp(0, Color.White, New Point(640, 400), {45, 46, 47})
        map(60).LoadUp(0, Color.White, New Point(715, 405), {47, 61, 62, 67})
        map(61).LoadUp(0, Color.White, New Point(735, 360), {47, 49, 60, 62})
        map(62).LoadUp(0, Color.White, New Point(790, 385), {49, 60, 61, 67})
        map(63).LoadUp(0, Color.White, New Point(250, 410), {52, 53, 54, 64})
        map(64).LoadUp(0, Color.White, New Point(320, 425), {54, 55, 63, 65, 68, 69})
        map(65).LoadUp(0, Color.White, New Point(380, 415), {55, 64, 66, 69})
        map(66).LoadUp(0, Color.White, New Point(445, 400), {56, 57, 65})
        map(67).LoadUp(0, Color.White, New Point(765, 440), {60, 62})
        map(68).LoadUp(0, Color.White, New Point(310, 475), {64, 69, 74, 75})
        map(69).LoadUp(0, Color.White, New Point(385, 465), {64, 65, 68, 75})
        map(70).LoadUp(0, Color.White, New Point(55, 475), {71, 76})
        map(71).LoadUp(0, Color.White, New Point(115, 490), {70, 72, 76, 77})
        map(72).LoadUp(0, Color.White, New Point(155, 525), {71, 73, 77})
        map(73).LoadUp(0, Color.White, New Point(210, 535), {72, 74, 78, 79})
        map(74).LoadUp(0, Color.White, New Point(265, 515), {68, 73, 75, 79, 80})
        map(75).LoadUp(0, Color.White, New Point(335, 520), {68, 69, 74, 80})
        map(76).LoadUp(0, Color.White, New Point(80, 515), {70, 71, 77})
        map(77).LoadUp(0, Color.White, New Point(125, 550), {71, 72, 76, 78, 81})
        map(78).LoadUp(0, Color.White, New Point(180, 570), {73, 77, 79, 83})
        map(79).LoadUp(0, Color.White, New Point(255, 565), {73, 74, 78, 80})
        map(80).LoadUp(0, Color.White, New Point(300, 555), {74, 75, 79})
        map(81).LoadUp(0, Color.White, New Point(95, 585), {77, 82, 83, 84})
        map(82).LoadUp(0, Color.White, New Point(50, 610), {81, 84})
        map(83).LoadUp(0, Color.White, New Point(135, 605), {78, 81, 84})
        map(84).LoadUp(0, Color.White, New Point(90, 635), {81, 82, 83})

        randBoners(9, 5)

        If GameScreen.spawnType = "preset" Then
            If GameScreen.playerCount = 2 Then
                map(0).setColour(GameScreen.players(0).colour)
                map(0).setOwner(1)
                map(82).setColour(GameScreen.players(1).colour)
                map(82).setOwner(2)

            ElseIf GameScreen.playerCount = 3 Then
                map(19).setColour(GameScreen.players(0).colour)
                map(19).setOwner(1)
                map(63).setColour(GameScreen.players(1).colour)
                map(63).setOwner(2)
                map(48).setColour(GameScreen.players(2).colour)
                map(48).setOwner(3)

            ElseIf GameScreen.playerCount = 4 Then
                map(19).setColour(GameScreen.players(0).colour)
                map(19).setOwner(1)
                map(63).setColour(GameScreen.players(1).colour)
                map(63).setOwner(2)
                map(23).setColour(GameScreen.players(2).colour)
                map(23).setOwner(3)
                map(58).setColour(GameScreen.players(3).colour)
                map(58).setOwner(4)
            End If
        Else
            spawnSetup()
        End If

        Return map
    End Function
    Function clusters(dia As Integer)
        ReDim map(70)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
        Next

        map(0).LoadUp(0, Color.White, New Point(67, 129), {1, 2, 3})
        map(1).LoadUp(0, Color.White, New Point(126, 94), {0, 2, 5})
        map(2).LoadUp(0, Color.White, New Point(118, 158), {0, 1, 3, 4, 5, 6, 7})
        map(3).LoadUp(0, Color.White, New Point(69, 201), {0, 2, 7}) '******1
        map(4).LoadUp(0, Color.White, New Point(153, 215), {2, 6, 7, 8})
        map(5).LoadUp(0, Color.White, New Point(178, 134), {1, 2, 6})
        map(6).LoadUp(0, Color.White, New Point(197, 179), {2, 4, 5, 8, 60})
        map(7).LoadUp(0, Color.White, New Point(102, 238), {2, 3, 4, 8})
        map(8).LoadUp(0, Color.White, New Point(176, 259), {4, 6, 7, 65})
        map(9).LoadUp(0, Color.White, New Point(638, 76), {10, 11, 15})
        map(10).LoadUp(0, Color.White, New Point(577, 103), {9, 11, 12, 61})
        map(11).LoadUp(0, Color.White, New Point(632, 145), {9, 10, 12, 16, 17})
        map(12).LoadUp(0, Color.White, New Point(565, 161), {10, 11, 13, 17})
        map(13).LoadUp(0, Color.White, New Point(578, 211), {12, 17})
        map(14).LoadUp(0, Color.White, New Point(657, 217), {16, 17, 18})
        map(15).LoadUp(0, Color.White, New Point(689, 76), {9, 16})
        map(16).LoadUp(0, Color.White, New Point(687, 156), {11, 14, 15, 17, 18})
        map(17).LoadUp(0, Color.White, New Point(618, 184), {11, 12, 13, 14, 16}) ' ******3
        map(18).LoadUp(0, Color.White, New Point(709, 202), {14, 16, 55})
        map(19).LoadUp(0, Color.White, New Point(131, 469), {20, 21, 64})
        map(20).LoadUp(0, Color.White, New Point(128, 519), {19, 20, 21, 24, 27})
        map(21).LoadUp(0, Color.White, New Point(86, 539), {19, 20, 22, 24})
        map(22).LoadUp(0, Color.White, New Point(77, 574), {21, 23, 24}) '*******4
        map(23).LoadUp(0, Color.White, New Point(88, 620), {22, 24, 25})
        map(24).LoadUp(0, Color.White, New Point(129, 572), {20, 21, 22, 23, 25, 26, 27})
        map(25).LoadUp(0, Color.White, New Point(144, 617), {23, 24, 26})
        map(26).LoadUp(0, Color.White, New Point(217, 601), {24, 25, 27, 68})
        map(27).LoadUp(0, Color.White, New Point(182, 536), {20, 24, 26})
        map(28).LoadUp(0, Color.White, New Point(892, 374), {29, 30, 35})
        map(29).LoadUp(0, Color.White, New Point(822, 394), {28, 30, 32, 57})
        map(30).LoadUp(0, Color.White, New Point(873, 418), {28, 29, 31, 32, 35})
        map(31).LoadUp(0, Color.White, New Point(852, 468), {30, 32, 33, 34, 35, 36})
        map(32).LoadUp(0, Color.White, New Point(816, 441), {29, 30, 31, 33})
        map(33).LoadUp(0, Color.White, New Point(783, 485), {31, 32, 34, 70})
        map(34).LoadUp(0, Color.White, New Point(870, 517), {31, 33, 36})
        map(35).LoadUp(0, Color.White, New Point(907, 437), {28, 30, 31, 36}) '*******2
        map(36).LoadUp(0, Color.White, New Point(924, 507), {31, 34, 35})
        map(37).LoadUp(0, Color.White, New Point(423, 348), {40, 41, 42, 51})
        map(38).LoadUp(0, Color.White, New Point(416, 414), {41, 42, 43, 44, 50})
        map(39).LoadUp(0, Color.White, New Point(494, 398), {40, 41, 44, 45, 46, 47})
        map(40).LoadUp(0, Color.White, New Point(475, 351), {37, 39, 41, 45, 51, 52, 53})
        map(41).LoadUp(0, Color.White, New Point(447, 379), {37, 38, 39, 40, 44})
        map(42).LoadUp(0, Color.White, New Point(368, 377), {37, 38, 66})
        map(43).LoadUp(0, Color.White, New Point(379, 453), {38, 50})
        map(44).LoadUp(0, Color.White, New Point(472, 444), {38, 39, 41, 47, 49, 50})
        map(45).LoadUp(0, Color.White, New Point(544, 355), {39, 40, 46, 53, 54})
        map(46).LoadUp(0, Color.White, New Point(563, 420), {39, 45, 47, 54})
        map(47).LoadUp(0, Color.White, New Point(523, 447), {39, 44, 46, 48, 49})
        map(48).LoadUp(0, Color.White, New Point(539, 494), {47, 49, 67})
        map(49).LoadUp(0, Color.White, New Point(469, 498), {44, 47, 48, 50})
        map(50).LoadUp(0, Color.White, New Point(418, 456), {38, 43, 44, 49})
        map(51).LoadUp(0, Color.White, New Point(440, 294), {37, 40, 62})
        map(52).LoadUp(0, Color.White, New Point(490, 297), {40, 53})
        map(53).LoadUp(0, Color.White, New Point(547, 301), {40, 45, 52})
        map(54).LoadUp(0, Color.White, New Point(588, 380), {45, 46, 56})
        map(55).LoadUp(0, Color.White, New Point(793, 267), {18, 56, 57, 58})
        map(56).LoadUp(0, Color.White, New Point(745, 294), {54, 55, 57})
        map(57).LoadUp(0, Color.White, New Point(797, 317), {29, 55, 56, 58})
        map(58).LoadUp(0, Color.White, New Point(860, 250), {55, 57})
        map(59).LoadUp(0, Color.White, New Point(343, 89), {60, 61})
        map(60).LoadUp(0, Color.White, New Point(365, 135), {6, 59, 61, 62})
        map(61).LoadUp(0, Color.White, New Point(400, 88), {10, 59, 60, 62})
        map(62).LoadUp(0, Color.White, New Point(414, 147), {51, 60, 61})
        map(63).LoadUp(0, Color.White, New Point(161, 349), {64, 65})
        map(64).LoadUp(0, Color.White, New Point(195, 394), {19, 63, 65, 66})
        map(65).LoadUp(0, Color.White, New Point(243, 345), {8, 63, 64, 66})
        map(66).LoadUp(0, Color.White, New Point(248, 392), {42, 64, 65})
        map(67).LoadUp(0, Color.White, New Point(552, 604), {48, 68, 69, 70})
        map(68).LoadUp(0, Color.White, New Point(502, 623), {26, 67, 69})
        map(69).LoadUp(0, Color.White, New Point(586, 638), {67, 68, 70})
        map(70).LoadUp(0, Color.White, New Point(611, 585), {33, 67, 69})

        randBoners(8, 5)

        If GameScreen.spawnType = "preset" Then
            If GameScreen.playerCount >= 2 Then
                map(3).setColour(GameScreen.players(0).colour)
                map(3).setOwner(1)
                map(35).setColour(GameScreen.players(1).colour)
                map(35).setOwner(2)
                If GameScreen.playerCount >= 3 Then
                    map(17).setColour(GameScreen.players(2).colour)
                    map(17).setOwner(3)
                End If
                If GameScreen.playerCount = 4 Then
                    map(22).setColour(GameScreen.players(3).colour)
                    map(22).setOwner(4)
                End If
            End If
        Else
            spawnSetup()
        End If

        Return map
    End Function
    Function triSpiral(dia As Integer)
        ReDim map(192)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
        Next

        map(0).LoadUp(0, Color.White, New Point(542, 446), {5, 7, 48})
        map(1).LoadUp(0, Color.White, New Point(420, 412), {9, 11, 12, 46, 62})
        map(2).LoadUp(0, Color.White, New Point(474, 348), {55, 56, 58, 65})
        map(3).LoadUp(0, Color.White, New Point(504, 342), {15, 18, 55, 65})
        map(4).LoadUp(0, Color.White, New Point(534, 422), {48, 50, 73})
        map(5).LoadUp(0, Color.White, New Point(562, 430), {0, 73, 189})
        map(6).LoadUp(0, Color.White, New Point(518, 468), {7, 35, 48, 67})
        map(7).LoadUp(0, Color.White, New Point(548, 468), {0, 6, 36, 37, 189})
        map(8).LoadUp(0, Color.White, New Point(458, 464), {9, 31, 33, 47, 67, 68})
        map(9).LoadUp(0, Color.White, New Point(436, 442), {1, 8, 10, 46, 47})
        map(10).LoadUp(0, Color.White, New Point(416, 454), {9, 12, 29, 31})
        map(11).LoadUp(0, Color.White, New Point(430, 392), {1, 46, 56, 57})
        map(12).LoadUp(0, Color.White, New Point(398, 428), {1, 10, 13, 28, 29})
        map(13).LoadUp(0, Color.White, New Point(384, 398), {12, 26, 27, 28, 62, 63})
        map(14).LoadUp(0, Color.White, New Point(452, 324), {25, 58, 59, 65})
        map(15).LoadUp(0, Color.White, New Point(518, 314), {3, 16, 18, 19, 20, 66})
        map(16).LoadUp(0, Color.White, New Point(548, 284), {15, 19, 20})
        map(17).LoadUp(0, Color.White, New Point(582, 334), {18, 19, 39, 74})
        map(18).LoadUp(0, Color.White, New Point(542, 344), {3, 15, 17, 19, 70, 74})
        map(19).LoadUp(0, Color.White, New Point(546, 324), {15, 16, 17, 18})
        map(20).LoadUp(0, Color.White, New Point(506, 276), {15, 16, 24, 64, 66})
        map(21).LoadUp(0, Color.White, New Point(432, 276), {22, 24, 25, 104})
        map(22).LoadUp(0, Color.White, New Point(406, 306), {21, 25, 40, 59, 60})
        map(23).LoadUp(0, Color.White, New Point(384, 338), {26, 41, 60, 63})
        map(24).LoadUp(0, Color.White, New Point(466, 274), {20, 21, 25, 64, 183})
        map(25).LoadUp(0, Color.White, New Point(444, 302), {14, 21, 22, 24, 59, 64})
        map(26).LoadUp(0, Color.White, New Point(368, 366), {13, 23, 42, 63})
        map(27).LoadUp(0, Color.White, New Point(344, 408), {13, 28, 42, 43})
        map(28).LoadUp(0, Color.White, New Point(368, 428), {12, 13, 27, 29, 43})
        map(29).LoadUp(0, Color.White, New Point(378, 468), {10, 12, 28, 30, 44, 45})
        map(30).LoadUp(0, Color.White, New Point(406, 492), {29, 31, 32, 45, 186})
        map(31).LoadUp(0, Color.White, New Point(434, 478), {8, 10, 30})
        map(32).LoadUp(0, Color.White, New Point(442, 502), {30, 33, 145, 186, 187})
        map(33).LoadUp(0, Color.White, New Point(464, 490), {8, 32, 34})
        map(34).LoadUp(0, Color.White, New Point(490, 506), {33, 35, 68, 145, 177})
        map(35).LoadUp(0, Color.White, New Point(518, 498), {6, 34, 36, 68, 176, 177})
        map(36).LoadUp(0, Color.White, New Point(552, 508), {7, 35, 37, 176})
        map(37).LoadUp(0, Color.White, New Point(570, 482), {7, 36, 123, 124})
        map(38).LoadUp(0, Color.White, New Point(590, 414), {72, 73, 122, 123, 188, 189})
        map(39).LoadUp(0, Color.White, New Point(590, 368), {17, 72, 74, 121})
        map(40).LoadUp(0, Color.White, New Point(380, 304), {22, 41, 60, 103, 104})
        map(41).LoadUp(0, Color.White, New Point(356, 334), {23, 40, 42, 101, 102, 103})
        map(42).LoadUp(0, Color.White, New Point(340, 372), {26, 27, 41, 101})
        map(43).LoadUp(0, Color.White, New Point(344, 432), {27, 28, 44})
        map(44).LoadUp(0, Color.White, New Point(352, 464), {29, 43, 45, 185})
        map(45).LoadUp(0, Color.White, New Point(362, 504), {29, 30, 44, 143, 186})
        map(46).LoadUp(0, Color.White, New Point(446, 416), {1, 9, 11, 47, 51, 52})
        map(47).LoadUp(0, Color.White, New Point(464, 436), {8, 9, 46, 49, 52, 67})
        map(48).LoadUp(0, Color.White, New Point(508, 442), {0, 4, 6, 49})
        map(49).LoadUp(0, Color.White, New Point(490, 422), {47, 48, 50, 52, 67})
        map(50).LoadUp(0, Color.White, New Point(508, 406), {4, 49, 53, 54, 71})
        map(51).LoadUp(0, Color.White, New Point(454, 398), {46, 52, 53, 56})
        map(52).LoadUp(0, Color.White, New Point(474, 408), {46, 47, 49, 51, 53}) '***** 4
        map(53).LoadUp(0, Color.White, New Point(480, 390), {50, 51, 52, 55, 56})
        map(54).LoadUp(0, Color.White, New Point(504, 384), {50, 55, 69, 71})
        map(55).LoadUp(0, Color.White, New Point(490, 368), {2, 3, 53, 54, 56, 69})
        map(56).LoadUp(0, Color.White, New Point(460, 370), {2, 11, 51, 53, 55, 57, 58})
        map(57).LoadUp(0, Color.White, New Point(428, 370), {11, 56, 61, 63})
        map(58).LoadUp(0, Color.White, New Point(446, 352), {2, 14, 56, 59, 61})
        map(59).LoadUp(0, Color.White, New Point(428, 322), {14, 22, 25, 58, 60})
        map(60).LoadUp(0, Color.White, New Point(406, 336), {22, 23, 40, 59, 61})
        map(61).LoadUp(0, Color.White, New Point(424, 350), {57, 58, 60})
        map(62).LoadUp(0, Color.White, New Point(406, 388), {1, 13, 63})
        map(63).LoadUp(0, Color.White, New Point(398, 364), {13, 23, 26, 57, 62})
        map(64).LoadUp(0, Color.White, New Point(472, 298), {20, 24, 25, 65, 66})
        map(65).LoadUp(0, Color.White, New Point(480, 326), {2, 3, 14, 64, 66})
        map(66).LoadUp(0, Color.White, New Point(492, 308), {15, 20, 64, 65})
        map(67).LoadUp(0, Color.White, New Point(482, 454), {6, 8, 47, 49, 68})
        map(68).LoadUp(0, Color.White, New Point(488, 482), {8, 34, 35, 67})
        map(69).LoadUp(0, Color.White, New Point(514, 364), {54, 55, 70, 71})
        map(70).LoadUp(0, Color.White, New Point(534, 372), {18, 69, 71, 72})
        map(71).LoadUp(0, Color.White, New Point(532, 392), {50, 54, 69, 70, 72, 73})
        map(72).LoadUp(0, Color.White, New Point(556, 384), {38, 39, 70, 71, 74})
        map(73).LoadUp(0, Color.White, New Point(558, 408), {4, 5, 38, 71})
        map(74).LoadUp(0, Color.White, New Point(560, 366), {17, 18, 39, 72})
        map(75).LoadUp(0, Color.White, New Point(348, 10), {78, 79, 109})
        map(76).LoadUp(0, Color.White, New Point(902, 532), {110, 111, 139, 140})
        map(77).LoadUp(0, Color.White, New Point(130, 768), {154, 173}) '***** 2
        map(78).LoadUp(0, Color.White, New Point(306, 36), {75, 79, 80, 81, 108})
        map(79).LoadUp(0, Color.White, New Point(350, 52), {75, 78, 81, 83, 109})
        map(80).LoadUp(0, Color.White, New Point(278, 74), {78, 81, 82, 84, 86, 107, 108})
        map(81).LoadUp(0, Color.White, New Point(308, 78), {78, 79, 80, 82, 83})
        map(82).LoadUp(0, Color.White, New Point(296, 120), {80, 81, 83, 84, 89, 90})
        map(83).LoadUp(0, Color.White, New Point(352, 98), {79, 81, 82, 179})
        map(84).LoadUp(0, Color.White, New Point(260, 116), {80, 82, 86, 87, 90, 106})
        map(85).LoadUp(0, Color.White, New Point(224, 160), {87, 88, 91, 106})
        map(86).LoadUp(0, Color.White, New Point(226, 96), {80, 84, 87, 107})
        map(87).LoadUp(0, Color.White, New Point(196, 142), {84, 85, 86, 88})
        map(88).LoadUp(0, Color.White, New Point(194, 192), {85, 87, 91, 92, 96})
        map(89).LoadUp(0, Color.White, New Point(324, 152), {82, 90})
        map(90).LoadUp(0, Color.White, New Point(284, 164), {82, 84, 89, 91, 93, 106})
        map(91).LoadUp(0, Color.White, New Point(240, 192), {85, 88, 90, 92, 93, 106})
        map(92).LoadUp(0, Color.White, New Point(238, 224), {88, 91, 96, 105})
        map(93).LoadUp(0, Color.White, New Point(296, 212), {90, 91, 94, 105})
        map(94).LoadUp(0, Color.White, New Point(330, 250), {93, 102, 103, 104, 105})
        map(95).LoadUp(0, Color.White, New Point(274, 266), {96, 97, 98, 99, 102, 105})
        map(96).LoadUp(0, Color.White, New Point(208, 250), {88, 92, 95, 97})
        map(97).LoadUp(0, Color.White, New Point(230, 284), {95, 96, 98})
        map(98).LoadUp(0, Color.White, New Point(260, 316), {95, 97, 99, 100})
        map(99).LoadUp(0, Color.White, New Point(294, 314), {95, 98, 100, 101, 102})
        map(100).LoadUp(0, Color.White, New Point(290, 360), {98, 99, 101, 184})
        map(101).LoadUp(0, Color.White, New Point(314, 338), {41, 42, 99, 100})
        map(102).LoadUp(0, Color.White, New Point(318, 286), {41, 94, 95, 99, 103})
        map(103).LoadUp(0, Color.White, New Point(348, 286), {40, 41, 94, 102, 104})
        map(104).LoadUp(0, Color.White, New Point(384, 252), {21, 40, 94, 103})
        map(105).LoadUp(0, Color.White, New Point(268, 228), {92, 93, 94, 95})
        map(106).LoadUp(0, Color.White, New Point(248, 158), {84, 85, 90, 91})
        map(107).LoadUp(0, Color.White, New Point(240, 56), {80, 86, 108})
        map(108).LoadUp(0, Color.White, New Point(266, 40), {78, 80, 107})
        map(109).LoadUp(0, Color.White, New Point(386, 22), {75, 79}) '***** 1
        map(110).LoadUp(0, Color.White, New Point(862, 548), {76, 111, 137, 138, 139})
        map(111).LoadUp(0, Color.White, New Point(886, 582), {76, 110}) '***** 3
        map(112).LoadUp(0, Color.White, New Point(886, 476), {113, 131, 139, 140})
        map(113).LoadUp(0, Color.White, New Point(902, 442), {112, 114, 131})
        map(114).LoadUp(0, Color.White, New Point(870, 412), {113, 115, 131, 141, 142})
        map(115).LoadUp(0, Color.White, New Point(816, 382), {114, 116, 128, 141, 142})
        map(116).LoadUp(0, Color.White, New Point(774, 350), {115, 117, 128})
        map(117).LoadUp(0, Color.White, New Point(738, 358), {116, 118, 127, 128})
        map(118).LoadUp(0, Color.White, New Point(700, 392), {117, 120, 127})
        map(119).LoadUp(0, Color.White, New Point(668, 416), {120, 122, 125, 126, 127})
        map(120).LoadUp(0, Color.White, New Point(650, 396), {118, 119, 121, 188})
        map(121).LoadUp(0, Color.White, New Point(622, 372), {39, 120, 178, 188})
        map(122).LoadUp(0, Color.White, New Point(618, 426), {38, 119, 122, 123, 125, 188})
        map(123).LoadUp(0, Color.White, New Point(606, 456), {37, 38, 122, 124, 125})
        map(124).LoadUp(0, Color.White, New Point(622, 486), {37, 123, 125})
        map(125).LoadUp(0, Color.White, New Point(658, 460), {119, 122, 123, 124, 126, 134, 191})
        map(126).LoadUp(0, Color.White, New Point(726, 442), {119, 125, 127, 129, 133, 134})
        map(127).LoadUp(0, Color.White, New Point(724, 402), {117, 118, 119, 126, 128, 129})
        map(128).LoadUp(0, Color.White, New Point(762, 392), {115, 116, 117, 127, 129, 142})
        map(129).LoadUp(0, Color.White, New Point(768, 428), {126, 127, 128, 130, 133, 142})
        map(130).LoadUp(0, Color.White, New Point(810, 446), {129, 131, 132, 133, 142})
        map(131).LoadUp(0, Color.White, New Point(844, 458), {112, 113, 114, 130, 132, 139, 142})
        map(132).LoadUp(0, Color.White, New Point(818, 484), {130, 131, 133, 135, 136, 138, 139})
        map(133).LoadUp(0, Color.White, New Point(762, 474), {126, 129, 130, 132, 135})
        map(134).LoadUp(0, Color.White, New Point(696, 474), {125, 126})
        map(135).LoadUp(0, Color.White, New Point(752, 500), {132, 133, 136, 181})
        map(136).LoadUp(0, Color.White, New Point(780, 522), {132, 135, 136, 138, 181})
        map(137).LoadUp(0, Color.White, New Point(806, 578), {110})
        map(138).LoadUp(0, Color.White, New Point(828, 522), {110, 132, 136, 139})
        map(139).LoadUp(0, Color.White, New Point(858, 506), {76, 110, 112, 131, 132, 138, 140})
        map(140).LoadUp(0, Color.White, New Point(904, 490), {76, 112, 139})
        map(141).LoadUp(0, Color.White, New Point(872, 384), {114, 115})
        map(142).LoadUp(0, Color.White, New Point(818, 420), {114, 115, 128, 129, 130, 131})
        map(143).LoadUp(0, Color.White, New Point(376, 532), {45, 144, 186})
        map(144).LoadUp(0, Color.White, New Point(396, 548), {143, 147, 151, 186, 187})
        map(145).LoadUp(0, Color.White, New Point(450, 536), {32, 34, 146, 177, 187})
        map(146).LoadUp(0, Color.White, New Point(452, 578), {145, 148, 149, 151, 177, 187})
        map(147).LoadUp(0, Color.White, New Point(348, 590), {144, 151, 152})
        map(148).LoadUp(0, Color.White, New Point(412, 610), {146, 149, 150, 151, 152, 167})
        map(149).LoadUp(0, Color.White, New Point(466, 612), {146, 148, 167})
        map(150).LoadUp(0, Color.White, New Point(410, 648), {148, 152, 153, 165, 167})
        map(151).LoadUp(0, Color.White, New Point(402, 586), {144, 146, 147, 148, 152, 187})
        map(152).LoadUp(0, Color.White, New Point(372, 626), {147, 148, 150, 151, 153, 169})
        map(153).LoadUp(0, Color.White, New Point(376, 688), {150, 152, 160, 162, 163, 165, 169, 171})
        map(154).LoadUp(0, Color.White, New Point(166, 778), {77, 155, 173})
        map(155).LoadUp(0, Color.White, New Point(222, 780), {154, 156, 157, 173, 175})
        map(156).LoadUp(0, Color.White, New Point(240, 726), {155, 157, 170, 172, 173, 174})
        map(157).LoadUp(0, Color.White, New Point(270, 768), {155, 156, 158, 161, 170, 175})
        map(158).LoadUp(0, Color.White, New Point(288, 788), {157, 161, 175})
        map(159).LoadUp(0, Color.White, New Point(360, 780), {161, 163, 164})
        map(160).LoadUp(0, Color.White, New Point(324, 714), {153, 161, 163, 170, 171})
        map(161).LoadUp(0, Color.White, New Point(320, 748), {157, 158, 159, 160, 163, 170})
        map(162).LoadUp(0, Color.White, New Point(396, 738), {153, 163, 164, 165})
        map(163).LoadUp(0, Color.White, New Point(364, 726), {153, 159, 160, 161, 162})
        map(164).LoadUp(0, Color.White, New Point(400, 760), {159, 162})
        map(165).LoadUp(0, Color.White, New Point(424, 710), {150, 153, 162, 167, 168})
        map(166).LoadUp(0, Color.White, New Point(496, 682), {167, 168})
        map(167).LoadUp(0, Color.White, New Point(442, 646), {148, 149, 150, 165, 166, 168})
        map(168).LoadUp(0, Color.White, New Point(454, 686), {165, 166, 167})
        map(169).LoadUp(0, Color.White, New Point(332, 648), {152, 153, 171})
        map(170).LoadUp(0, Color.White, New Point(288, 692), {156, 157, 160, 161, 171, 174})
        map(171).LoadUp(0, Color.White, New Point(328, 674), {153, 160, 169, 170})
        map(172).LoadUp(0, Color.White, New Point(196, 724), {156, 173})
        map(173).LoadUp(0, Color.White, New Point(180, 746), {77, 154, 155, 156, 172})
        map(174).LoadUp(0, Color.White, New Point(254, 686), {156, 170, 180})
        map(175).LoadUp(0, Color.White, New Point(250, 812), {155, 157, 158})
        map(176).LoadUp(0, Color.White, New Point(526, 538), {35, 36, 177, 190})
        map(177).LoadUp(0, Color.White, New Point(486, 538), {34, 35, 145, 146, 176})
        map(178).LoadUp(0, Color.White, New Point(622, 310), {121, 182})
        map(179).LoadUp(0, Color.White, New Point(388, 132), {83})
        map(180).LoadUp(0, Color.White, New Point(196, 656), {174})
        map(181).LoadUp(0, Color.White, New Point(718, 542), {135, 136})
        map(182).LoadUp(0, Color.White, New Point(572, 220), {178, 183})
        map(183).LoadUp(0, Color.White, New Point(474, 222), {24, 182})
        map(184).LoadUp(0, Color.White, New Point(240, 412), {100, 185})
        map(185).LoadUp(0, Color.White, New Point(292, 470), {44, 184})
        map(186).LoadUp(0, Color.White, New Point(404, 518), {30, 32, 45, 143, 144, 187})
        map(187).LoadUp(0, Color.White, New Point(424, 536), {32, 144, 145, 146, 151, 186})
        map(188).LoadUp(0, Color.White, New Point(616, 398), {38, 120, 121, 122})
        map(189).LoadUp(0, Color.White, New Point(574, 452), {5, 7, 38})
        map(190).LoadUp(0, Color.White, New Point(550, 572), {176, 191, 192})
        map(191).LoadUp(0, Color.White, New Point(626, 532), {125, 190, 192})
        map(192).LoadUp(0, Color.White, New Point(606, 596), {190, 191})

        randBoners(17, 10)

        If GameScreen.spawnType = "preset" Then
            If GameScreen.playerCount >= 2 Then
                map(109).setColour(GameScreen.players(0).colour)
                map(109).setOwner(1)
                map(77).setColour(GameScreen.players(1).colour)
                map(77).setOwner(2)
                If GameScreen.playerCount >= 3 Then
                    map(111).setColour(GameScreen.players(2).colour)
                    map(111).setOwner(3)
                End If
                If GameScreen.playerCount = 4 Then
                    map(52).setColour(GameScreen.players(3).colour)
                    map(52).setOwner(4)
                End If
            End If
        Else
            spawnSetup()
        End If

        Return map
    End Function
    Function superSpiral(dia As Integer)
        ReDim map(214)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
        Next
        map(0).LoadUp(0, Color.White, New Point(495, 303), {1, 2, 5, 12})
        map(1).LoadUp(0, Color.White, New Point(447, 286), {0, 2, 4, 13, 14, 29})
        map(2).LoadUp(0, Color.White, New Point(483, 260), {0, 1, 11, 12, 27, 29, 31})
        map(3).LoadUp(0, Color.White, New Point(445, 345), {4, 6, 14, 15, 16})
        map(4).LoadUp(0, Color.White, New Point(462, 315), {1, 3, 5, 6, 14})
        map(5).LoadUp(0, Color.White, New Point(486, 343), {0, 4, 6, 7, 8, 52})
        map(6).LoadUp(0, Color.White, New Point(463, 368), {3, 4, 5, 7, 16, 17})
        map(7).LoadUp(0, Color.White, New Point(502, 381), {5, 6, 8, 17, 18})
        map(8).LoadUp(0, Color.White, New Point(540, 374), {5, 7, 9, 18, 20})
        map(9).LoadUp(0, Color.White, New Point(559, 340), {8, 21, 22, 52})
        map(10).LoadUp(0, Color.White, New Point(537, 261), {11, 12, 22, 24, 25})
        map(11).LoadUp(0, Color.White, New Point(505, 237), {2, 10, 12, 25, 26, 27, 53})
        map(12).LoadUp(0, Color.White, New Point(515, 281), {0, 2, 10, 11, 22, 52})
        map(13).LoadUp(0, Color.White, New Point(392, 286), {1, 14, 29, 37, 59})
        map(14).LoadUp(0, Color.White, New Point(409, 331), {1, 3, 4, 13, 15, 58})
        map(15).LoadUp(0, Color.White, New Point(413, 369), {3, 14, 16, 33, 36, 58})
        map(16).LoadUp(0, Color.White, New Point(445, 397), {3, 6, 15, 17, 35, 36})
        map(17).LoadUp(0, Color.White, New Point(482, 412), {6, 7, 16, 18, 35, 39, 40, 41})
        map(18).LoadUp(0, Color.White, New Point(519, 410), {7, 8, 17, 43})
        map(19).LoadUp(0, Color.White, New Point(562, 400), {20, 43, 45, 47})
        map(20).LoadUp(0, Color.White, New Point(581, 366), {8, 19, 21, 47})
        map(21).LoadUp(0, Color.White, New Point(598, 327), {9, 20, 22, 23, 49, 50})
        map(22).LoadUp(0, Color.White, New Point(561, 300), {9, 10, 12, 21, 23, 24, 52})
        map(23).LoadUp(0, Color.White, New Point(603, 282), {21, 22, 50, 56, 57})
        map(24).LoadUp(0, Color.White, New Point(576, 250), {10, 22, 55, 56})
        map(25).LoadUp(0, Color.White, New Point(539, 230), {10, 11, 54})
        map(26).LoadUp(0, Color.White, New Point(478, 200), {11, 27, 32, 53})
        map(27).LoadUp(0, Color.White, New Point(464, 228), {2, 11, 26, 31})
        map(28).LoadUp(0, Color.White, New Point(379, 239), {29, 30, 37, 85})
        map(29).LoadUp(0, Color.White, New Point(422, 264), {1, 2, 13, 28, 31})
        map(30).LoadUp(0, Color.White, New Point(409, 217), {28, 31, 32})
        map(31).LoadUp(0, Color.White, New Point(433, 236), {2, 27, 29, 30, 32})
        map(32).LoadUp(0, Color.White, New Point(437, 187), {26, 30, 31})
        map(33).LoadUp(0, Color.White, New Point(375, 376), {15, 34, 58, 82, 98})
        map(34).LoadUp(0, Color.White, New Point(386, 403), {33, 36, 38, 98, 99})
        map(35).LoadUp(0, Color.White, New Point(432, 437), {16, 17, 36, 38, 41, 101})
        map(36).LoadUp(0, Color.White, New Point(416, 410), {15, 16, 34, 35, 38})
        map(37).LoadUp(0, Color.White, New Point(365, 272), {13, 28, 59, 60, 85})
        map(38).LoadUp(0, Color.White, New Point(397, 437), {34, 35, 36, 99, 100, 101})
        map(39).LoadUp(0, Color.White, New Point(504, 439), {17, 40, 42, 43})
        map(40).LoadUp(0, Color.White, New Point(484, 463), {17, 39, 41})
        map(41).LoadUp(0, Color.White, New Point(443, 461), {17, 35, 40, 101})
        map(42).LoadUp(0, Color.White, New Point(535, 462), {39, 43, 44})
        map(43).LoadUp(0, Color.White, New Point(542, 428), {18, 19, 39, 42, 44})
        map(44).LoadUp(0, Color.White, New Point(562, 445), {42, 43, 45})
        map(45).LoadUp(0, Color.White, New Point(591, 433), {19, 44, 46, 139})
        map(46).LoadUp(0, Color.White, New Point(618, 416), {45, 47, 48, 139, 161})
        map(47).LoadUp(0, Color.White, New Point(607, 379), {19, 20, 46, 49})
        map(48).LoadUp(0, Color.White, New Point(641, 380), {46, 49, 135, 138, 161})
        map(49).LoadUp(0, Color.White, New Point(623, 346), {21, 47, 48, 51})
        map(50).LoadUp(0, Color.White, New Point(627, 306), {21, 23, 51, 57})
        map(51).LoadUp(0, Color.White, New Point(648, 331), {49, 50, 135, 160})
        map(52).LoadUp(0, Color.White, New Point(514, 328), {5, 9, 12, 22})
        map(53).LoadUp(0, Color.White, New Point(517, 197), {11, 26, 54, 174})
        map(54).LoadUp(0, Color.White, New Point(559, 206), {25, 53, 55, 174, 197})
        map(55).LoadUp(0, Color.White, New Point(586, 215), {24, 54, 56, 193, 196})
        map(56).LoadUp(0, Color.White, New Point(611, 242), {23, 24, 55, 57, 193})
        map(57).LoadUp(0, Color.White, New Point(632, 275), {23, 50, 56})
        map(58).LoadUp(0, Color.White, New Point(374, 338), {14, 15, 33, 59})
        map(59).LoadUp(0, Color.White, New Point(359, 307), {13, 37, 58, 82, 83})
        map(60).LoadUp(0, Color.White, New Point(332, 279), {37, 61, 83, 84, 85})
        map(61).LoadUp(0, Color.White, New Point(296, 278), {60, 62, 80, 83, 84})
        map(62).LoadUp(0, Color.White, New Point(252, 265), {61, 63, 79, 84, 88})
        map(63).LoadUp(0, Color.White, New Point(219, 235), {62, 64, 88, 89, 97})
        map(64).LoadUp(0, Color.White, New Point(238, 195), {63, 65, 87, 88, 213})
        map(65).LoadUp(0, Color.White, New Point(176, 194), {64, 66, 89, 90, 91, 95})
        map(66).LoadUp(0, Color.White, New Point(202, 148), {65, 95, 213})
        map(67).LoadUp(0, Color.White, New Point(140, 144), {68, 91, 93, 94, 95})
        map(68).LoadUp(0, Color.White, New Point(162, 106), {67, 93})
        map(69).LoadUp(0, Color.White, New Point(129, 40), {70, 71, 72, 214})
        map(70).LoadUp(0, Color.White, New Point(92, 27), {69, 72, 73, 214})
        map(71).LoadUp(0, Color.White, New Point(128, 67), {69, 72, 93})
        map(72).LoadUp(0, Color.White, New Point(98, 67), {69, 70, 71, 73, 94})
        map(73).LoadUp(0, Color.White, New Point(67, 74), {70, 72, 74, 94})
        map(74).LoadUp(0, Color.White, New Point(57, 125), {73, 75, 94})
        map(75).LoadUp(0, Color.White, New Point(72, 158), {74, 76, 94})
        map(76).LoadUp(0, Color.White, New Point(105, 194), {75, 92, 96})
        map(77).LoadUp(0, Color.White, New Point(137, 256), {78, 89, 96})
        map(78).LoadUp(0, Color.White, New Point(167, 275), {77, 79, 97})
        map(79).LoadUp(0, Color.White, New Point(224, 300), {62, 78, 80})
        map(80).LoadUp(0, Color.White, New Point(276, 315), {61, 79, 81})
        map(81).LoadUp(0, Color.White, New Point(309, 337), {80, 82, 83})
        map(82).LoadUp(0, Color.White, New Point(341, 343), {33, 59, 81, 83})
        map(83).LoadUp(0, Color.White, New Point(320, 309), {59, 60, 61, 81, 82})
        map(84).LoadUp(0, Color.White, New Point(305, 240), {60, 61, 62, 85, 88})
        map(85).LoadUp(0, Color.White, New Point(346, 251), {28, 37, 60, 84, 86})
        map(86).LoadUp(0, Color.White, New Point(330, 210), {85, 87})
        map(87).LoadUp(0, Color.White, New Point(287, 204), {64, 86, 88})
        map(88).LoadUp(0, Color.White, New Point(268, 223), {62, 63, 64, 84, 87})
        map(89).LoadUp(0, Color.White, New Point(171, 223), {63, 65, 77, 90, 97})
        map(90).LoadUp(0, Color.White, New Point(141, 212), {65, 89, 91, 96})
        map(91).LoadUp(0, Color.White, New Point(133, 177), {65, 67, 90, 92})
        map(92).LoadUp(0, Color.White, New Point(98, 149), {76, 91, 94})
        map(93).LoadUp(0, Color.White, New Point(128, 109), {67, 68, 71, 94})
        map(94).LoadUp(0, Color.White, New Point(94, 117), {67, 72, 73, 74, 75, 92, 93})
        map(95).LoadUp(0, Color.White, New Point(167, 159), {65, 66, 67})
        map(96).LoadUp(0, Color.White, New Point(90, 227), {76, 77, 90})
        map(97).LoadUp(0, Color.White, New Point(203, 264), {63, 78, 89})
        map(98).LoadUp(0, Color.White, New Point(353, 406), {33, 34, 99, 105})
        map(99).LoadUp(0, Color.White, New Point(350, 443), {34, 38, 98, 100, 104, 108})
        map(100).LoadUp(0, Color.White, New Point(381, 471), {38, 99, 101, 102, 103})
        map(101).LoadUp(0, Color.White, New Point(420, 489), {35, 38, 41, 100, 102})
        map(102).LoadUp(0, Color.White, New Point(395, 520), {100, 101, 103, 112})
        map(103).LoadUp(0, Color.White, New Point(356, 504), {100, 102, 109, 110})
        map(104).LoadUp(0, Color.White, New Point(319, 466), {99, 106, 108, 109})
        map(105).LoadUp(0, Color.White, New Point(298, 415), {98, 106, 108})
        map(106).LoadUp(0, Color.White, New Point(286, 451), {104, 105, 107, 108})
        map(107).LoadUp(0, Color.White, New Point(292, 501), {106, 109, 118, 119})
        map(108).LoadUp(0, Color.White, New Point(324, 426), {99, 104, 105, 106})
        map(109).LoadUp(0, Color.White, New Point(326, 494), {103, 104, 107, 120})
        map(110).LoadUp(0, Color.White, New Point(337, 541), {103, 111, 112, 114, 120})
        map(111).LoadUp(0, Color.White, New Point(314, 587), {110, 114, 115, 124})
        map(112).LoadUp(0, Color.White, New Point(377, 543), {102, 110, 113})
        map(113).LoadUp(0, Color.White, New Point(378, 584), {112, 114})
        map(114).LoadUp(0, Color.White, New Point(352, 576), {110, 111, 113, 115})
        map(115).LoadUp(0, Color.White, New Point(334, 622), {111, 114})
        map(116).LoadUp(0, Color.White, New Point(275, 630), {117, 124, 134})
        map(117).LoadUp(0, Color.White, New Point(216, 639), {116, 125, 126, 133, 134})
        map(118).LoadUp(0, Color.White, New Point(251, 511), {107, 119, 122})
        map(119).LoadUp(0, Color.White, New Point(263, 538), {107, 118, 120, 121})
        map(120).LoadUp(0, Color.White, New Point(299, 538), {109, 110, 119, 121})
        map(121).LoadUp(0, Color.White, New Point(281, 569), {119, 120, 123, 124})
        map(122).LoadUp(0, Color.White, New Point(208, 554), {118, 123, 126, 131})
        map(123).LoadUp(0, Color.White, New Point(226, 573), {121, 122, 125, 126})
        map(124).LoadUp(0, Color.White, New Point(270, 599), {111, 116, 121, 125})
        map(125).LoadUp(0, Color.White, New Point(234, 604), {117, 123, 124, 126})
        map(126).LoadUp(0, Color.White, New Point(177, 605), {117, 122, 123, 125, 127, 131, 132})
        map(127).LoadUp(0, Color.White, New Point(157, 641), {126, 128, 133})
        map(128).LoadUp(0, Color.White, New Point(113, 644), {127, 129})
        map(129).LoadUp(0, Color.White, New Point(105, 619), {128, 130, 132}) '***** 4
        map(130).LoadUp(0, Color.White, New Point(121, 582), {129, 131, 132})
        map(131).LoadUp(0, Color.White, New Point(171, 560), {122, 126, 130, 132})
        map(132).LoadUp(0, Color.White, New Point(147, 606), {126, 129, 130, 131})
        map(133).LoadUp(0, Color.White, New Point(188, 659), {117, 127})
        map(134).LoadUp(0, Color.White, New Point(250, 662), {116, 117})
        map(135).LoadUp(0, Color.White, New Point(672, 367), {48, 51, 136, 138, 160})
        map(136).LoadUp(0, Color.White, New Point(718, 371), {135, 137, 138, 159, 160})
        map(137).LoadUp(0, Color.White, New Point(734, 409), {136, 142, 158, 163})
        map(138).LoadUp(0, Color.White, New Point(686, 400), {48, 135, 136, 139, 142, 161, 162})
        map(139).LoadUp(0, Color.White, New Point(655, 449), {45, 46, 138, 140, 141, 161, 162})
        map(140).LoadUp(0, Color.White, New Point(627, 485), {139, 141, 145})
        map(141).LoadUp(0, Color.White, New Point(683, 491), {139, 140, 144, 145, 165, 166})
        map(142).LoadUp(0, Color.White, New Point(716, 437), {137, 138, 162, 165})
        map(143).LoadUp(0, Color.White, New Point(738, 494), {163, 164, 165, 166, 167})
        map(144).LoadUp(0, Color.White, New Point(670, 526), {141, 145, 146, 147, 166})
        map(145).LoadUp(0, Color.White, New Point(640, 523), {140, 141, 144, 146})
        map(146).LoadUp(0, Color.White, New Point(649, 548), {144, 145, 147})
        map(147).LoadUp(0, Color.White, New Point(682, 562), {144, 146, 149, 168})
        map(148).LoadUp(0, Color.White, New Point(718, 591), {149, 168, 170, 171})
        map(149).LoadUp(0, Color.White, New Point(669, 609), {147, 148, 150, 171, 172})
        map(150).LoadUp(0, Color.White, New Point(638, 627), {149, 151, 172, 173})
        map(151).LoadUp(0, Color.White, New Point(620, 675), {150, 173}) '***** 2
        map(152).LoadUp(0, Color.White, New Point(678, 672), {153, 173})
        map(153).LoadUp(0, Color.White, New Point(718, 654), {152, 154, 170, 171, 172})
        map(154).LoadUp(0, Color.White, New Point(777, 635), {153, 170})
        map(155).LoadUp(0, Color.White, New Point(800, 577), {156, 167, 169})
        map(156).LoadUp(0, Color.White, New Point(799, 523), {155, 157, 167})
        map(157).LoadUp(0, Color.White, New Point(794, 467), {156, 158, 163, 164})
        map(158).LoadUp(0, Color.White, New Point(786, 406), {137, 157, 159, 163})
        map(159).LoadUp(0, Color.White, New Point(756, 368), {136, 158, 160})
        map(160).LoadUp(0, Color.White, New Point(705, 332), {51, 135, 136, 159})
        map(161).LoadUp(0, Color.White, New Point(653, 411), {46, 48, 138, 139})
        map(162).LoadUp(0, Color.White, New Point(684, 459), {138, 139, 142})
        map(163).LoadUp(0, Color.White, New Point(747, 444), {137, 143, 157, 158, 164})
        map(164).LoadUp(0, Color.White, New Point(772, 495), {143, 157, 163, 167})
        map(165).LoadUp(0, Color.White, New Point(723, 471), {141, 142, 143})
        map(166).LoadUp(0, Color.White, New Point(721, 515), {141, 143, 144, 167, 168})
        map(167).LoadUp(0, Color.White, New Point(759, 539), {143, 155, 156, 164, 166, 168, 169})
        map(168).LoadUp(0, Color.White, New Point(707, 553), {147, 148, 166, 167, 169})
        map(169).LoadUp(0, Color.White, New Point(765, 574), {155, 167, 168, 170})
        map(170).LoadUp(0, Color.White, New Point(745, 615), {148, 153, 154, 169})
        map(171).LoadUp(0, Color.White, New Point(698, 624), {148, 149, 153, 172})
        map(172).LoadUp(0, Color.White, New Point(675, 642), {149, 150, 153, 171, 173})
        map(173).LoadUp(0, Color.White, New Point(650, 657), {150, 151, 152, 172})
        map(174).LoadUp(0, Color.White, New Point(541, 164), {53, 54, 175, 197})
        map(175).LoadUp(0, Color.White, New Point(558, 139), {174, 176, 199})
        map(176).LoadUp(0, Color.White, New Point(574, 106), {175, 177, 178, 198})
        map(177).LoadUp(0, Color.White, New Point(579, 76), {176, 178, 212})
        map(178).LoadUp(0, Color.White, New Point(608, 77), {176, 177, 179, 198, 200, 212})
        map(179).LoadUp(0, Color.White, New Point(651, 74), {178, 180, 200, 202, 203})
        map(180).LoadUp(0, Color.White, New Point(644, 36), {179, 181, 212})
        map(181).LoadUp(0, Color.White, New Point(684, 29), {180, 202, 211})
        map(182).LoadUp(0, Color.White, New Point(733, 32), {202, 204, 205, 210, 211})
        map(183).LoadUp(0, Color.White, New Point(800, 25), {205, 209, 210})
        map(184).LoadUp(0, Color.White, New Point(815, 56), {206, 207, 208, 209})
        map(185).LoadUp(0, Color.White, New Point(872, 35), {186, 209})
        map(186).LoadUp(0, Color.White, New Point(890, 71), {185, 187, 208}) '***** 3
        map(187).LoadUp(0, Color.White, New Point(855, 110), {186, 188, 207})
        map(188).LoadUp(0, Color.White, New Point(827, 137), {187, 189, 207})
        map(189).LoadUp(0, Color.White, New Point(785, 116), {188, 190, 206})
        map(190).LoadUp(0, Color.White, New Point(737, 121), {189, 191, 195, 201, 204})
        map(191).LoadUp(0, Color.White, New Point(732, 157), {190, 192, 195})
        map(192).LoadUp(0, Color.White, New Point(694, 183), {191, 194, 195})
        map(193).LoadUp(0, Color.White, New Point(631, 217), {55, 56, 194, 196})
        map(194).LoadUp(0, Color.White, New Point(638, 174), {192, 193, 195, 196, 198})
        map(195).LoadUp(0, Color.White, New Point(676, 136), {190, 191, 192, 194, 198, 200, 203})
        map(196).LoadUp(0, Color.White, New Point(594, 175), {55, 193, 194, 197, 198, 199})
        map(197).LoadUp(0, Color.White, New Point(570, 170), {54, 174, 196, 199})
        map(198).LoadUp(0, Color.White, New Point(620, 123), {176, 178, 194, 195, 196, 199, 200})
        map(199).LoadUp(0, Color.White, New Point(588, 141), {175, 196, 197, 198})
        map(200).LoadUp(0, Color.White, New Point(654, 106), {178, 179, 195, 198, 203})
        map(201).LoadUp(0, Color.White, New Point(711, 79), {190, 202, 204})
        map(202).LoadUp(0, Color.White, New Point(686, 54), {179, 181, 182, 201, 203, 204})
        map(203).LoadUp(0, Color.White, New Point(691, 107), {179, 195, 200, 202})
        map(204).LoadUp(0, Color.White, New Point(742, 70), {182, 190, 201, 202, 205})
        map(205).LoadUp(0, Color.White, New Point(781, 60), {182, 183, 204, 206})
        map(206).LoadUp(0, Color.White, New Point(794, 84), {184, 189, 205})
        map(207).LoadUp(0, Color.White, New Point(829, 90), {184, 187, 188, 207, 208})
        map(208).LoadUp(0, Color.White, New Point(849, 72), {184, 186, 207})
        map(209).LoadUp(0, Color.White, New Point(842, 26), {183, 184, 185})
        map(210).LoadUp(0, Color.White, New Point(760, 9), {182, 183, 211})
        map(211).LoadUp(0, Color.White, New Point(721, 3), {181, 182, 210})
        map(212).LoadUp(0, Color.White, New Point(611, 42), {177, 178, 180})
        map(213).LoadUp(0, Color.White, New Point(235, 158), {64, 66})
        map(214).LoadUp(0, Color.White, New Point(158, 7), {69, 70}) '***** 1

        randBoners(18, 11)

        If GameScreen.spawnType = "preset" Then
            If GameScreen.playerCount >= 2 Then
                map(214).setColour(GameScreen.players(0).colour)
                map(214).setOwner(1)
                map(151).setColour(GameScreen.players(1).colour)
                map(151).setOwner(2)
                If GameScreen.playerCount >= 3 Then
                    map(186).setColour(GameScreen.players(2).colour)
                    map(186).setOwner(3)
                End If
                If GameScreen.playerCount = 4 Then
                    map(129).setColour(GameScreen.players(3).colour)
                    map(129).setOwner(4)
                End If
            End If
        Else
            spawnSetup()
        End If

        Return map
    End Function
    Function tutorial()
        ReDim map(10)
        For x = 0 To map.Length - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(50)
        Next

        map(0).LoadUp(1, Color.Red, New Point(148, 219), {1, 2, 4})
        map(1).LoadUp(0, Color.White, New Point(163, 343), {0, 4})
        map(2).LoadUp(0, Color.White, New Point(283, 179), {0, 4, 5})
        map(3).LoadUp(0, Color.White, New Point(392, 334), {3, 4, 5, 7})
        map(4).LoadUp(0, Color.White, New Point(273, 284), {0, 1, 2, 3})
        map(5).LoadUp(0, Color.White, New Point(443, 213), {2, 3, 6, 8})
        map(6).LoadUp(0, Color.White, New Point(557, 293), {5, 7, 8, 9, 10})
        map(7).LoadUp(0, Color.White, New Point(479, 384), {3, 6, 10})
        map(8).LoadUp(0, Color.White, New Point(577, 195), {5, 6, 9})
        map(9).LoadUp(2, Color.Blue, New Point(710, 260), {6, 8, 10})
        map(10).LoadUp(0, Color.White, New Point(626, 362), {6, 7, 9})

        ReDim boners(0, 2)

        map(6).setLockLife(4)
        boners = {{1, 4, 2}}

        Return map
    End Function
    Function loadCustom()
        If GameScreen.OFUser.FileName <> Nothing Then
            Dim fileData As New List(Of String)
            MapEditor.reader = New IO.StreamReader(GameScreen.OFUser.FileName)
            While MapEditor.reader.EndOfStream = False
                fileData.Add(MapEditor.reader.ReadLine())
            End While
            ReDim map(fileData.Count - 1)
            Try
                For s = 0 To fileData.Count - 1

                    Dim splitString() As String = fileData(s).Split(ControlChars.Tab)
                    Dim tempOwner As Integer
                    Dim tempLocation As Point
                    Dim tempShield As Integer = splitString(3)
                    Dim tempRad As Integer = splitString(4)

                    splitString(1) = splitString(1).Substring(1, splitString(1).Length - 2)
                    Dim tempLoc() As String = splitString(1).Split(",")
                    tempLocation = New Point(Int(tempLoc(0)), Int(tempLoc(1)))

                    splitString(2) = splitString(2).Substring(1, splitString(2).Length - 2)
                    Dim temp() As String = splitString(2).Split(",")
                    Dim tempCons(temp.Length - 1) As Integer
                    If temp(0) <> "" Then
                        For q = 0 To temp.Length - 1
                            tempCons(q) = temp(q)
                        Next
                    End If
                    map(s) = New Planeto
                    map(s).setID(s)
                    Dim tempColour As Color
                    If GameScreen.spawnType = "preset" Then
                        tempOwner = splitString(0)
                        Select Case tempOwner
                            Case 0
                                tempColour = Color.White
                            Case 1
                                tempColour = GameScreen.players(0).colour
                            Case 2
                                tempColour = GameScreen.players(1).colour
                            Case 3
                                If GameScreen.playerCount > 2 Then
                                    tempColour = GameScreen.players(2).colour
                                Else
                                    tempColour = Color.White
                                End If
                            Case 4
                                If GameScreen.playerCount > 3 Then
                                    tempColour = GameScreen.players(3).colour
                                Else
                                    tempColour = Color.White
                                End If
                        End Select
                    Else
                        tempOwner = 0
                        tempColour = Color.White
                    End If
                    If temp(0) <> Nothing Then
                        map(s).LoadUp(tempOwner, tempColour, tempLocation, tempCons)
                    Else
                        map(s).LoadUp(tempOwner, tempColour, tempLocation, {})
                    End If
                    map(s).setShield(tempShield)
                    map(s).setDiameter(tempRad)
                Next
                If GameScreen.spawnType <> "preset" Then
                    spawnSetup()
                End If
                If map.Length > 40 Then
                    randBoners(Int(map.Length / 12) + 1, Int(map.Length / 20) + 1)
                Else
                    randBoners(GameScreen.rander.Next(3, 6), 4)
                End If
                GameScreen.cleanLoad = True
                GameScreen.BackgroundImage = Nothing
                Return map
            Catch out As IndexOutOfRangeException
                GameScreen.BackgroundImage = My.Resources.derpDogError
                GameScreen.BackgroundImageLayout = ImageLayout.Zoom
                GameScreen.cleanLoad = False
                Return {New Planeto}
            End Try
        Else
            GameScreen.BackgroundImage = My.Resources.derpDogError
            GameScreen.BackgroundImageLayout = ImageLayout.Zoom
            GameScreen.cleanLoad = False
            Return {New Planeto}
        End If
    End Function
    Sub randBoners(count As Integer, length As Integer)
        Debug.Print("Generating " & count & " formations of " & length & " length")
        ReDim boners(count - 1, length - 1)
        Dim masterList(length - 1) As Integer
        Dim conList As New List(Of Integer)
        For p = 0 To count - 1
            Dim currPlaneto As Integer = GameScreen.rander.Next(map.Length - 1)
            For q = 0 To masterList.Length - 1
                masterList(q) = -1
            Next
            For w = 0 To masterList.Length - 1
                conList.AddRange(map(currPlaneto).getConnections())
                For ay = 0 To masterList.Length - 1
                    If currPlaneto = masterList(ay) Then
                        conList.Remove(currPlaneto)
                        If conList.Count > 0 Then
                            currPlaneto = conList(GameScreen.rander.Next(conList.Count - 1))
                            ay = 0
                        End If
                    End If
                Next
                masterList(w) = currPlaneto
                conList.RemoveRange(0, conList.Count)
            Next
            For u = 0 To masterList.Length - 1
                boners(p, u) = masterList(u)
            Next
        Next
        If GameScreen.chkStartShields.Checked = True Then
            randShields()
        End If
        If GameScreen.chkRoadBlocks.Checked = True Then
            randRoadBlocks()
        End If
    End Sub
    Sub randShields()
        Dim count As Integer = GameScreen.rander.Next(map.Length / 2)
        For x = 1 To count
            Dim pick As Integer = GameScreen.rander.Next(map.Length)
            map(pick).setShield(True)
        Next
    End Sub
    Sub randRoadBlocks()
        Dim count As Integer = GameScreen.rander.Next(map.Length / 4)
        For x = 1 To count
            Dim pick As Integer = GameScreen.rander.Next(map.Length)
            map(pick).setLockLife(GameScreen.rander.Next(10))
            map(pick).setShield(False)
        Next
    End Sub
    Sub spawnSetup()
        If GameScreen.spawnType = "chosen" Then
            GameScreen.pickingSpawns = True
        Else
            Dim reps As Integer
            Dim planList As New List(Of Integer)
            For x = 0 To map.Length - 1
                planList.Add(map(x).getID)
            Next
            Select Case GameScreen.spawnType
                Case "ran1"
                    reps = 1
                Case "ran3"
                    reps = 3
                Case "ranF"
                    reps = Int(map.Length / GameScreen.playerCount)
            End Select
            For g = 1 To GameScreen.playerCount
                For x = 1 To reps
                    Dim pickedInd = GameScreen.rander.Next(planList.Count)
                    Dim pick = planList(pickedInd)
                    map(pick).setColour(GameScreen.players(g - 1).colour)
                    map(pick).setOwner(g)
                    planList.RemoveAt(pickedInd)
                Next
            Next
        End If
    End Sub
    Function randMap()
        Dim dia As Integer
        Dim locList As New List(Of Point)
        Dim allCons As New List(Of List(Of Integer))
        Dim planCount As Integer = GameScreen.rander.Next(80, 201)
        If planCount > 120 Then
            dia = 20
        Else
            dia = 30
        End If
        locList = findPlans(planCount, dia)
        For t = 0 To locList.Count - 1
            allCons.Add(New List(Of Integer))
        Next
        findCons(locList, allCons)
        ReDim map(locList.Count - 1)
        For x = 0 To locList.Count - 1
            map(x) = New Planeto()
            map(x).setID(x)
            map(x).setDiameter(dia)
            map(x).LoadUp(0, Color.White, locList(x), allCons(x).ToArray())
        Next
        If GameScreen.rbPreSet.Checked Then
            For a = 1 To GameScreen.players.Length
                Dim found As Boolean = False
                While found = False
                    Dim pick = GameScreen.rander.Next(map.Length)
                    If map(pick).getOwner() = 0 Then
                        map(pick).setOwner(a)
                        map(pick).setColour(GameScreen.players(a - 1).colour)
                        found = True
                    End If
                End While
            Next
        Else
            spawnSetup()
        End If
        randBoners(map.Length / 10, map.Length / 15)
        Return map
    End Function
    Function findPlans(count As Integer, dia As Integer)
        Dim chunker As New Chunks
        Dim type = GameScreen.rander.Next(2)
        type = 1
        Dim master As New List(Of Point)
        Select Case type
            Case 0
                Dim quad1 = chunker.loadChunk(0, 0, 1)
                Dim quad2 = chunker.loadChunk(300, 0, 2)
                Dim quad3 = chunker.loadChunk(300, 300, 3)
                Dim quad4 = chunker.loadChunk(0, 300, 4)
                Dim reps As Integer = Int(count / 4)
                For x = 0 To reps
                    Dim temp = GameScreen.rander.Next(quad1.Count)
                    master.Add(quad1(temp))
                    quad1.RemoveAt(temp)
                Next
                For x = 0 To reps
                    Dim temp = GameScreen.rander.Next(quad2.Count)
                    master.Add(quad2(temp))
                    quad2.RemoveAt(temp)
                Next
                For x = 0 To reps
                    Dim temp = GameScreen.rander.Next(quad3.Count)
                    master.Add(quad3(temp))
                    quad3.RemoveAt(temp)
                Next
                For x = 0 To reps
                    Dim temp = GameScreen.rander.Next(quad4.Count)
                    master.Add(quad4(temp))
                    quad4.RemoveAt(temp)
                Next
                master.RemoveAt(GameScreen.rander.Next(master.Count))
            Case 1
                Dim tempList = chunker.makeChunk(count, dia)
                For v = 0 To tempList.Count - 1
                    Dim pick = GameScreen.rander.Next(tempList.Count)
                    master.Add(tempList(pick))
                    tempList.RemoveAt(pick)
                Next
            Case 2
        End Select
        Return master
    End Function
    Sub findCons(locs As List(Of Point), ByRef cons As List(Of List(Of Integer)))
        'Initial runthrough of the connectors
        For x = 0 To cons.Count - 1
            Dim notFound As Boolean = True
            Dim searchRad As Integer = 50
            While notFound = True
                For y = 0 To cons.Count - 1
                    If locs(x).X + searchRad >= locs(y).X And locs(x).X - searchRad <= locs(y).X Then
                        If locs(x).Y + searchRad >= locs(y).Y And locs(x).Y - searchRad <= locs(y).Y And x <> y Then
                            cons(x).Add(y)
                            cons(y).Add(x)
                            notFound = False
                        End If
                    End If
                Next
                searchRad += 25
            End While
        Next
        Dim totalCount As Integer = locs.Count
        Dim foundCount As Integer
        'BFS and connector fixer loop, continues until all planetos are reachable
        While foundCount <> totalCount
            Dim visited(locs.Count) As Boolean
            foundCount = 0
            Dim queue As New List(Of Integer)
            queue.Add(0)
            Debug.Print("Landed at planeto " & queue(0))
            Debug.Print("Landing spot is (" & locs(queue(0)).X & ", " & locs(queue(0)).Y & ")")
            visited(queue(0)) = True
            foundCount += 1
            'BFS, a little derpy
            While queue.Count > 0
                Dim checking As New List(Of Integer)
                checking = queue.ToList()
                queue.RemoveRange(0, queue.Count)
                For x = 0 To checking.Count - 1
                    For y = 0 To cons(checking(x)).Count - 1
                        If visited(cons(checking(x))(y)) = False Then
                            visited(cons(checking(x))(y)) = True
                            queue.Add(cons(checking(x))(y))
                            foundCount += 1
                        End If
                    Next
                Next
            End While
            'Counts up everything found to see if we found everything
            Dim foundList As New List(Of Integer)
            For u = 0 To visited.Length - 1
                If visited(u) Then
                    foundList.Add(u)
                End If
            Next
            'If we didnt find everything, look for a fix
            If foundList.Count < totalCount Then
                Dim avgX As Integer = 0
                Dim avgY As Integer = 0
                For b = 0 To foundList.Count - 1
                    avgX += locs(b).X
                    avgY += locs(b).Y
                Next
                avgX = avgX / foundList.Count
                avgY = avgY / foundList.Count
                Debug.Print("Average point is: (" & avgX & ", " & avgY & ")")
                Dim avgPoint As Point = New Point(avgX, avgY)
                Dim target As Integer
                Dim notFound As Boolean = True
                Dim searchRad As Integer = 50
                While notFound = True
                    For x = 0 To locs.Count - 1
                        If visited(x) = False Then
                            If locs(x).X + searchRad >= avgPoint.X And locs(x).X - searchRad <= avgPoint.X Then
                                If locs(x).Y + searchRad >= avgPoint.X And locs(x).Y - searchRad <= avgPoint.X Then
                                    target = x
                                    Debug.Print("Found planeto " & x)
                                    notFound = False
                                    Exit For
                                End If
                            End If
                        End If
                    Next
                    searchRad += 25
                End While
                Dim nF As Boolean = True
                Dim sR As Integer = 50
                While nF = True

                    For x = 0 To locs.Count - 1
                        If visited(x) = True Then
                            If locs(x).X + sR >= locs(target).X And locs(x).X - sR <= locs(target).X Then
                                If locs(x).Y + sR >= locs(target).Y And locs(x).Y - sR <= locs(target).Y Then
                                    cons(target).Add(x)
                                    cons(x).Add(target)
                                    Debug.Print("Connecting planeto " & target & " to planeto " & x)
                                    nF = False
                                End If
                            End If
                        End If
                    Next
                    sR += 25
                End While
            Else
                foundCount = totalCount
            End If
        End While
        For t = 0 To cons.Count - 1
            Dim finList As New List(Of Integer)
            finList = cons(t).Distinct().ToList()
            finList.Sort()
            cons(t) = finList
        Next
    End Sub
End Class