Public Class frmArrSorting

    Dim arr As Integer() = New Integer(29) {}

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CreateArr()
    End Sub

    Private Sub btnInsertion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertion.Click
        Insertion()
        ViewSortedArray()
    End Sub

    Private Sub btnSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelection.Click
        Selection()
        ViewSortedArray()
    End Sub

    Private Sub btnBubble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBubble.Click
        Bubble()
        ViewSortedArray()
    End Sub

    Public Sub CreateArr()
        Static randomNumberGenerator As New System.Random
        For i = 0 To arr.Length - 1
            arr(i) = randomNumberGenerator.Next(10, 99)
            tbBefore.Text += CStr(arr(i)) + " "
        Next
    End Sub

    Public Sub ViewSortedArray()
        tbAfter.Text = ""
        For i = 0 To arr.Length - 1
            tbAfter.Text += CStr(arr(i)) + " "
        Next
    End Sub

    Sub Insertion()
        Dim i, j As Integer
        Dim length As Integer = arr.Length
        For i = 1 To length - 1
            Dim temp As Integer = arr(i)
            Dim inserted As Boolean = False
            j = i - 1
            While (j >= 0 And Not inserted)
                If (temp < arr(j)) Then
                    arr(j + 1) = arr(j)
                    j -= 1
                    arr(j + 1) = temp
                Else
                    inserted = True
                End If
            End While
        Next
    End Sub

    Sub Selection()
        Dim length As Integer = arr.Length
        For i As Integer = 0 To length - 1
            Dim min As Integer = i
            For j As Integer = i + 1 To length - 1
                If arr(j) < arr(min) Then
                    min = j
                End If
            Next
            Dim temp As Integer = arr(i)
            arr(i) = arr(min)
            arr(min) = temp
        Next
    End Sub

    Sub Bubble()
        Dim i, j As Integer
        Dim length As Integer = arr.Length
        For i = 0 To length Step 1
            For j = length - 1 To i + 1 Step -1
                If (arr(j) < arr(j - 1)) Then
                    Dim temp As Integer = arr(j)
                    arr(j) = arr(j - 1)
                    arr(j - 1) = temp
                End If
            Next
        Next
    End Sub
End Class
