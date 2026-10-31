Imports System.IO.Ports

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupTrackBars()
        LoadAvailablePorts()
    End Sub

    Private Sub SetupTrackBars()
        ' Default Value = 0°
        trbBase.Minimum = 0
        trbBase.Maximum = 180
        trbBase.Value = 0
        lblBaseVal.Text = "0°"

        trbShoulder.Minimum = 0
        trbShoulder.Maximum = 180
        trbShoulder.Value = 0
        lblShoulderVal.Text = "0°"

        trbGripper.Minimum = 0
        trbGripper.Maximum = 180
        trbGripper.Value = 0
        lblGripperVal.Text = "0°"
    End Sub

    Private Sub LoadAvailablePorts()
        cmbPorts.Items.Clear()
        For Each port As String In SerialPort.GetPortNames()
            cmbPorts.Items.Add(port)
        Next
        If cmbPorts.Items.Count > 0 Then cmbPorts.SelectedIndex = 0
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
                btnConnect.Text = "Connect"
                cmbPorts.Enabled = True
                MessageBox.Show("Disconnected to Arduino.")
            Else
                If cmbPorts.SelectedItem IsNot Nothing Then
                    SerialPort1.PortName = cmbPorts.SelectedItem.ToString()
                    SerialPort1.BaudRate = 9600
                    SerialPort1.DtrEnable = True
                    SerialPort1.RtsEnable = True
                    SerialPort1.Open()

                    btnConnect.Text = "Disconnect"
                    cmbPorts.Enabled = False
                    MessageBox.Show("Connected to " & SerialPort1.PortName & "!")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error connection: " & ex.Message)
        End Try
    End Sub

    Private Sub SendCommand(cmd As String)
        Try
            If SerialPort1.IsOpen Then
                SerialPort1.Write(cmd & vbLf)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub trbBase_Scroll(sender As Object, e As EventArgs) Handles trbBase.Scroll
        lblBaseVal.Text = trbBase.Value.ToString() & "°"
        SendCommand("B" & trbBase.Value)
    End Sub

    Private Sub trbShoulder_Scroll(sender As Object, e As EventArgs) Handles trbShoulder.Scroll
        lblShoulderVal.Text = trbShoulder.Value.ToString() & "°"
        SendCommand("S" & trbShoulder.Value)
    End Sub

    Private Sub trbGripper_Scroll(sender As Object, e As EventArgs) Handles trbGripper.Scroll
        lblGripperVal.Text = trbGripper.Value.ToString() & "°"
        SendCommand("G" & trbGripper.Value)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If SerialPort1.IsOpen Then SerialPort1.Close()
    End Sub

End Class