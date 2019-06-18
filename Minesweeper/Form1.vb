Public Class Form1
    Dim grid(50, 50) As Button
    Dim r As New Random
    Dim mineChecker As Boolean = False
    Dim sizeOfGrid As Integer = 10
#Region "Gameplay"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sizeOfGrid = InputBox("How Big would you like the grid to be?")
        makeGrid()
        placeBombs(3)
    End Sub
    Private Sub makeGrid()
        For x = 0 To sizeOfGrid
            For y = 0 To sizeOfGrid
                grid(x, y) = New Button
                With grid(x, y)
                    .Height = 75
                    .Width = 75
                    .Top = 50 + (y * 77)
                    .Left = 50 + (x * 77)
                    .BackColor = Color.Gray
                    .Tag = "e"
                    .Text = x & y
                    .ForeColor = Color.Gray

                End With
                Me.Controls.Add(grid(x, y))
                AddHandler grid(x, y).MouseClick, AddressOf buttonEventHandler
                AddHandler grid(x, y).MouseDoubleClick, AddressOf buttonEventHandler
            Next
        Next
    End Sub
    Private Sub buttonEventHandler(sender As Object, e As EventArgs)
        Dim thisX As Integer
        Dim thisY As Integer
        Dim numberOfPosition As Integer
        numberOfPosition = Val(sender.text)
        thisY = numberOfPosition Mod 10
        thisX = numberOfPosition \ 10
        Me.Text = thisX & thisY

        If mineChecker Then
            If sender.tag = "x" Then
                sender.Backcolor = Color.Purple
                clearAllBombs()
            Else
                sender.backcolor = Color.Red
            End If
        If thisY = 0 Then
            'this is the top Row
            sender.text = checktopRow(thisX, thisY)
        ElseIf thisY = sizeOfGrid Then
            sender.text = checkBottomRow(thisX, thisY)
        ElseIf thisX = 0 Then
            sender.text = leftRow(thisX, thisY)
        ElseIf thisX = sizeOfGrid Then
            sender.text = rightRow(thisX, thisY)
        Else
            sender.text = middle(thisX, thisY)
        End If
    Else
        sender.image = PictureBox1.Image
        End If

        Dim BombNearme As Integer = 0
    End Sub
    Private Sub placeBombs(numberofBombs As Integer)
        Dim r_y As Integer
        Dim r_x As Integer

        For i = 0 To numberofBombs
            r_y = r.Next(0, 6)
            r_x = r.Next(0, 6)
            Do While grid(r_x, r_y).Tag = "x"
                r_y = r.Next(0, 6)
                r_x = r.Next(0, 6)
            Loop
            grid(r_x, r_y).Tag = "x"
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mineChecker = then
            mineChecker = False
            Button1_Click.text = "Mine "
        Else
            mineChecker = True
            Button1_Click.text = "Mine Checker"
        End If
    End Sub
#End Region
    Sub clearAllBombs()
        For x = 0 To sizeOfGrid
            For y = 0 To sizeOfGrid
                grid(x, y).Enabled = False
                If grid(x, y).Tag = "x" Then
                    grid(x, y).BackColor = Color.Red
                End If
            Next
        Next
    End Sub
#Region "Checking Rows, columns and middle"
    Function checktopRow(thisX As Integer, thisY As Integer) As Integer
        Dim bombBeside As Integer = 0
        If thisX = 0 Then
            'this is the top left square
            bombBeside += checkBelow(thisX, thisY)
            bombBeside += checkBelowRight(thisX, thisY)
            bombBeside += CheckRight(thisX, thisY)
        ElseIf thisX = sizeOfGrid Then
            'this means we are top Right
            bombBeside += checkBelow(thisX, thisY)
            bombBeside += checkbelowLeft(thisX, thisY)
            bombBeside += Checkleft(thisX, thisY)
        Else
            bombBeside += checkBelow(thisX, thisY)
            bombBeside += checkBelowRight(thisX, thisY)
            bombBeside += CheckRight(thisX, thisY)
            bombBeside += checkbelowLeft(thisX, thisY)
            bombBeside += Checkleft(thisX, thisY)
        End If

        Return bombBeside
    End Function
    Function checkBottomRow(thisX As Integer, thisY As Integer) As Integer
        Dim bombsBeside As Integer = 0
        If thisX = 0 Then
            bombsBeside += checkAbove(thisX, thisY)
            bombsBeside += CheckaboveRight(thisX, thisY)
            bombsBeside += CheckRight(thisX, thisY)
        ElseIf thisX = sizeOfGrid Then
            bombsBeside += checkAbove(thisX, thisY)
            bombsBeside += CheckaboveLeft(thisX, thisY)
            bombsBeside += Checkleft(thisX, thisY)
        Else
            bombsBeside += checkAbove(thisX, thisY)
            bombsBeside += CheckaboveRight(thisX, thisY)
            bombsBeside += CheckRight(thisX, thisY)
            bombsBeside += CheckaboveLeft(thisX, thisY)
            bombsBeside += Checkleft(thisX, thisY)
        End If
        Return 0
    End Function
    Function rightRow(thisX As Integer, thisY As Integer) As Integer
        Dim bombBeside As Integer = 0
        If thisX = 0 Then
            bombBeside += checkBelow(thisX, thisY)
            bombBeside += checkbelowLeft(thisX, thisY)
            bombBeside += Checkleft(thisX, thisY)
        ElseIf thisY = 5 Then
            bombBeside += checkAbove(thisX, thisY)
            bombBeside += CheckaboveLeft(thisX, thisY)


        End If
        Return bombBeside
    End Function
    Function leftRow(thisX As Integer, thisY As Integer) As Integer
        Dim bombBeside As Integer = 0
        If thisY = 0 Then
            bombBeside += checkBelow(thisX, thisY)
            bombBeside += checkBelowRight(thisX, thisY)
            bombBeside += CheckRight(thisX, thisY)
        ElseIf thisY = 5 Then
            bombBeside += checkAbove(thisX, thisY)
            bombBeside += CheckaboveRight(thisX, thisY)
            bombBeside += CheckRight(thisX, thisY)
        Else
            bombBeside += checkAbove(thisX, thisY)
            bombBeside += CheckaboveRight(thisX, thisY)
            bombBeside += CheckRight(thisX, thisY)
            bombBeside += checkBelowRight(thisX, thisY)
            bombBeside += checkBelow(thisX, thisY)
        End If
        Return bombBeside
    End Function
    Function middle(thisX As Integer, thisY As Integer) As Integer
        Dim BombBeside As Integer = 0
        BombBeside += checkBelow(thisX, thisY)
        BombBeside += checkBelowRight(thisX, thisY)
        BombBeside += CheckRight(thisX, thisY)
        BombBeside += checkAbove(thisX, thisY)
        BombBeside += CheckaboveLeft(thisX, thisY)
        BombBeside += Checkleft(thisX, thisY)
        BombBeside += checkbelowLeft(thisX, thisY)
        Return BombBeside
    End Function
#End Region
#Region "Check adjacent Squares"
    Function checkAbove(ThisX As Integer, thisY As Integer) As Integer
        If grid(ThisX, thisY - 1).Tag = "x" Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Function CheckaboveRight(ThisX As Integer, thisY As Integer) As Integer
        If grid(ThisX + 1, thisY - 1).Tag = "x" Then
            Return 1
        Else
            Return 0
        End If
        Return 0
    End Function
    Function CheckaboveLeft(thisX As Integer, thisY As Integer) As Integer
        If grid(thisX - 1, thisY - 1).Tag = "x" Then
            Return 1
        Else
            Return 0
        End If
        Return 0
    End Function
    Function Checkleft(thisX As Integer, thisY As Integer) As Integer
        If grid(thisX - 1, thisY).Tag = "x" Then
            Return 1
        Else
            Return 0
        End If

    End Function
    Function CheckRight(thisX As Integer, thisY As Integer) As Integer
        If grid(thisX + 1, thisY).Tag = "x" Then
            Return 1
        Else
            Return 0
        End If
        Return 0
    End Function
    Function checkBelow(thisX As Integer, thisY As Integer) As Integer
        If grid(thisX, thisY + 1).Tag = "x" Then
            Return 1
        Else
            Return 0
        End If

    End Function
    Function checkbelowLeft(thisX As Integer, thisY As Integer) As Integer
        If grid(thisX - 1, thisY + 1).Tag = "x" Then
            Return 1
        Else
            Return 0
        End If

    End Function
    Function checkBelowRight(thisX As Integer, thisY As Integer) As Integer
        If grid(thisX + 1, thisY + 1).Tag = "x" Then
            Return 1
        Else
            Return 0
        End If
        Return 0
    End Function
#End Region

End Class
