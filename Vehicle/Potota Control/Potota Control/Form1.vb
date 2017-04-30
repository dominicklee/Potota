'ECET 270 - POTOTA Vehicle Controller
'Written by Dominick Lee

Public Class Form1
    Dim mode As String = "full"
    Dim vSFr As String = ""
    Dim vSRe As String = ""
    Dim vSRi As String = ""
    Dim vSLe As String = ""
    Dim vLidar As String = ""
    Dim vECUmode As String = ""
    Dim vSpeed As String = ""
    Dim vLineFollow As String = ""


    Private Sub fullMode()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True
    End Sub

    Private Sub windowMode()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Me.WindowState = FormWindowState.Normal
        Me.TopMost = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadPorts()
        cbLidar.Text = My.Settings.lidarCOM
        cbSonar.Text = My.Settings.sonarCOM
        cbECU.Text = My.Settings.ecuCOM
        cbSpeedLF.Text = My.Settings.speedCOM
        TextBox1.Text = Application.StartupPath & "\data.csv"
        Dim streamURL As String = "http://aws.makitronics.com/potota/send.php?apikey=1234"
        WebBrowser1.Navigate(streamURL)
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        If mode = "full" Then
            windowMode()
            mode = "window"
        Else
            fullMode()
            mode = "full"
        End If
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If btnConnect.Text = "Connect" Then
            Try
                spLidar.Encoding = System.Text.Encoding.Default
                spLidar.PortName = cbLidar.Text

                spSonar.Encoding = System.Text.Encoding.Default
                spSonar.PortName = cbSonar.Text

                'spECU.Encoding = System.Text.Encoding.Default
                'spECU.PortName = cbECU.Text

                spSpeedLF.Encoding = System.Text.Encoding.Default
                spSpeedLF.PortName = cbSpeedLF.Text

                btnConnect.Text = "Disconnect"
                updateLabels.Start()

                spLidar.Open()
                spSonar.Open()
                'spECU.Open()
                spSpeedLF.Open()

            Catch ex As Exception
                MsgBox("Failed to connect to COM ports")
            End Try
        Else
            Try
                btnConnect.Text = "Connect"
                updateLabels.Stop()

                spLidar.Close()
                spSonar.Close()
                'spECU.Close()
                spSpeedLF.Close()

            Catch ex As Exception
                MsgBox("Failed to disconnect from COM ports")
            End Try
        End If
    End Sub

    Private Sub loadPorts()
        cbLidar.Items.Clear()
        cbSonar.Items.Clear()
        cbECU.Items.Clear()
        cbSpeedLF.Items.Clear()

        Dim numPorts As Integer = My.Computer.Ports.SerialPortNames.Count

        For Each item As String In My.Computer.Ports.SerialPortNames
            Dim lastChar As String = item.Substring(item.Length - 1)
            If IsNumeric(lastChar) = False Then
                lastChar = (item.Substring(0, item.Length - 1))
            Else
                lastChar = item
            End If

            cbLidar.Items.Add(lastChar)
            cbSonar.Items.Add(lastChar)
            cbECU.Items.Add(lastChar)
            cbSpeedLF.Items.Add(lastChar)
        Next
        If numPorts = 0 Then
            cbLidar.Items.Add("No Ports Available")
            cbSonar.Items.Add("No Ports Available")
            cbECU.Items.Add("No Ports Available")
            cbSpeedLF.Items.Add("No Ports Available")
        End If
    End Sub

    Private Sub lblRefreshCOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRefreshCOM.Click
        loadPorts()

    End Sub

    Private Sub spLidar_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles spLidar.DataReceived
        'expecting lidar distance in inches
        Try
            vLidar = spLidar.ReadLine.ToString.Replace(vbCr, "").Replace(vbLf, "")
        Catch
        End Try
    End Sub

    Private Sub spSonar_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles spSonar.DataReceived
        'expecting sonar CSV
        Try
            Dim rawVal As String = spSonar.ReadLine
            Dim parts() As String = rawVal.Split(",")
            vSFr = Replace(parts(0), vbNewLine, "")
            vSRe = Replace(parts(1), vbNewLine, "")
            vSLe = Replace(parts(2), vbNewLine, "")
            vSRi = Replace(parts(3), vbNewLine, "")
            vSRi = vSRi.Replace(vbCr, "").Replace(vbLf, "")
        Catch
        End Try
    End Sub

    Private Sub spECU_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles spECU.DataReceived
        'expecting mode
        Try
            vECUmode = Replace(spECU.ReadLine, vbNewLine, "")
        Catch
        End Try
    End Sub

    Private Sub spSpeedLF_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles spSpeedLF.DataReceived
        'expecting speed / LF in CSV
        Try
            Dim rawVal As String = spSpeedLF.ReadLine

            vSpeed = Replace(rawVal, vbNewLine, "")
        Catch
        End Try
    End Sub

    Private Sub cbLidar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLidar.SelectedIndexChanged
        My.Settings.lidarCOM = cbLidar.Text
        My.Settings.Save()
    End Sub

    Private Sub cbSonar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSonar.SelectedIndexChanged
        My.Settings.sonarCOM = cbSonar.Text
        My.Settings.Save()
    End Sub

    Private Sub cbECU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbECU.SelectedIndexChanged
        My.Settings.ecuCOM = cbECU.Text
        My.Settings.Save()
    End Sub

    Private Sub cbSpeedLF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSpeedLF.SelectedIndexChanged
        My.Settings.speedCOM = cbSpeedLF.Text
        My.Settings.Save()
    End Sub

    Private Sub updateLabels_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateLabels.Tick
        valSonarFront.Text = vSFr
        valSonarRear.Text = vSRe
        valSonarLeft.Text = vSLe
        valSonarRight.Text = vSRi
        valECUmode.Text = vECUmode
        valSpeed.Text = vSpeed
        valLidar.Text = vLidar

        Try
            Dim uTime As Integer
            uTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds

            If valLidar.Text <> "" And valSpeed.Text <> "" Then

                Dim dataLine As String = uTime & "," & valLidar.Text & "," & valSonarFront.Text & "," & valSonarRear.Text & "," & valSonarLeft.Text & "," & valSonarRight.Text & "," & valECUmode.Text & "," & valSpeed.Text

                If My.Computer.FileSystem.FileExists(TextBox1.Text) Then
                    My.Computer.FileSystem.WriteAllText(TextBox1.Text, dataLine, True, System.Text.Encoding.UTF8)
                Else
                    'new file, needs header
                    My.Computer.FileSystem.WriteAllText(TextBox1.Text, "timestamp,lidar,sonarFront,sonarRear,sonarLeft,sonarRight,ecuMode,speed" & vbNewLine, True, System.Text.Encoding.UTF8)
                    My.Computer.FileSystem.WriteAllText(TextBox1.Text, dataLine, True, System.Text.Encoding.UTF8)
                End If

            End If

            lblDataLogging.Text = ""
        Catch
            lblDataLogging.Text = "Error saving file"
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Process.Start(TextBox1.Text)
        Catch ex As Exception
            MsgBox("Failed to open file")
        End Try
    End Sub

    Private Sub InvokeTestMethod(ByVal sensorID As String, ByVal msg As String)
        If (Not (WebBrowser1.Document Is Nothing)) Then
            Dim ObjArr(2) As Object
            ObjArr(0) = CObj(New String(sensorID))
            ObjArr(1) = CObj(New String(msg))
            WebBrowser1.Document.InvokeScript("sendEvent", ObjArr)
        End If
    End Sub

    Private Sub streamTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles streamTimer.Tick
        Dim JSONline As String
        JSONline = "{""lidar"":" & valLidar.Text & ",""sonarFront"":" & valSonarFront.Text & ",""sonarRear"":" & valSonarRear.Text & ",""sonarLeft"":" & valSonarLeft.Text & ",""sonarRight"":" & valSonarRight.Text & ",""speed"":" & valSpeed.Text & "}"
        Try
            InvokeTestMethod("Potota Vehicle", JSONline)
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label13.Show()
        streamTimer.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label13.Hide()
        streamTimer.Stop()
    End Sub
End Class
