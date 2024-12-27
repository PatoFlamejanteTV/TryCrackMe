Public Class Form1

    Dim coiso As Integer

    Function updateBar()
        BAR.Value = coiso
        Label2.Text = coiso
        'Console.WriteLine(coiso)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Create a new Process object to access system processes
        Dim proc As New Process()

        Dim processes() As Process = Process.GetProcesses()

        ' Iterate through each process
        For Each p As Process In processes
            ' based on this list: https://github.com/ayoubfaouzi/al-khaser/blob/master/al-khaser/AntiAnalysis/process.cpp
            If p.ProcessName.ToLower() = "resourcehacker" OrElse p.ProcessName.ToLower() = "x32dbg" OrElse p.ProcessName.ToLower() = "x64dbg" OrElse p.ProcessName.ToLower() = "cheatengine-i386" OrElse p.ProcessName.ToLower() = "cheatengine-x86_64" OrElse p.ProcessName.ToLower() = "cheatengine-x86_64-SSE4-AVX2" Then
                Label1.Text = "STATUS: Detected"
                Label1.ForeColor = Color.Red ' bad
                Exit For
            Else
                Label1.Text = "STATUS: Not Detected"
                Label1.ForeColor = Color.Green ' good
            End If
        Next

        ' Release the process object
        proc.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub MINUS_Click(sender As Object, e As EventArgs) Handles MINUS.Click
        If Not coiso - 1 = -1 Then
            coiso = coiso - 1
            updateBar()
        End If
    End Sub
    Private Sub PLUS_Click(sender As Object, e As EventArgs) Handles PLUS.Click
        If Not coiso + 1 = 101 Then
            coiso = coiso + 1
            updateBar()
        End If
    End Sub
End Class
