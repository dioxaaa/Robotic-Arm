<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmbPorts = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.trbBase = New System.Windows.Forms.TrackBar()
        Me.trbShoulder = New System.Windows.Forms.TrackBar()
        Me.trbGripper = New System.Windows.Forms.TrackBar()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lblBaseVal = New System.Windows.Forms.Label()
        Me.lblShoulderVal = New System.Windows.Forms.Label()
        Me.lblGripperVal = New System.Windows.Forms.Label()
        CType(Me.trbBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbShoulder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbGripper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbPorts
        '
        Me.cmbPorts.FormattingEnabled = True
        Me.cmbPorts.Location = New System.Drawing.Point(348, 103)
        Me.cmbPorts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPorts.Name = "cmbPorts"
        Me.cmbPorts.Size = New System.Drawing.Size(160, 24)
        Me.cmbPorts.TabIndex = 0
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(681, 101)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(100, 28)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'trbBase
        '
        Me.trbBase.Location = New System.Drawing.Point(371, 164)
        Me.trbBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.trbBase.Maximum = 180
        Me.trbBase.Name = "trbBase"
        Me.trbBase.Size = New System.Drawing.Size(139, 56)
        Me.trbBase.TabIndex = 2
        Me.trbBase.Value = 90
        '
        'trbShoulder
        '
        Me.trbShoulder.Location = New System.Drawing.Point(371, 258)
        Me.trbShoulder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.trbShoulder.Maximum = 180
        Me.trbShoulder.Name = "trbShoulder"
        Me.trbShoulder.Size = New System.Drawing.Size(139, 56)
        Me.trbShoulder.TabIndex = 3
        Me.trbShoulder.Value = 90
        '
        'trbGripper
        '
        Me.trbGripper.Location = New System.Drawing.Point(371, 372)
        Me.trbGripper.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.trbGripper.Maximum = 180
        Me.trbGripper.Name = "trbGripper"
        Me.trbGripper.Size = New System.Drawing.Size(139, 56)
        Me.trbGripper.TabIndex = 4
        Me.trbGripper.Value = 90
        '
        'lblBaseVal
        '
        Me.lblBaseVal.AutoSize = True
        Me.lblBaseVal.Location = New System.Drawing.Point(411, 228)
        Me.lblBaseVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBaseVal.Name = "lblBaseVal"
        Me.lblBaseVal.Size = New System.Drawing.Size(48, 16)
        Me.lblBaseVal.TabIndex = 5
        Me.lblBaseVal.Text = "Label1"
        '
        'lblShoulderVal
        '
        Me.lblShoulderVal.AutoSize = True
        Me.lblShoulderVal.Location = New System.Drawing.Point(411, 318)
        Me.lblShoulderVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblShoulderVal.Name = "lblShoulderVal"
        Me.lblShoulderVal.Size = New System.Drawing.Size(48, 16)
        Me.lblShoulderVal.TabIndex = 6
        Me.lblShoulderVal.Text = "Label2"
        '
        'lblGripperVal
        '
        Me.lblGripperVal.AutoSize = True
        Me.lblGripperVal.Location = New System.Drawing.Point(411, 443)
        Me.lblGripperVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGripperVal.Name = "lblGripperVal"
        Me.lblGripperVal.Size = New System.Drawing.Size(48, 16)
        Me.lblGripperVal.TabIndex = 7
        Me.lblGripperVal.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 554)
        Me.Controls.Add(Me.lblGripperVal)
        Me.Controls.Add(Me.lblShoulderVal)
        Me.Controls.Add(Me.lblBaseVal)
        Me.Controls.Add(Me.trbGripper)
        Me.Controls.Add(Me.trbShoulder)
        Me.Controls.Add(Me.trbBase)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.cmbPorts)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.trbBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbShoulder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbGripper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbPorts As ComboBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents trbBase As TrackBar
    Friend WithEvents trbShoulder As TrackBar
    Friend WithEvents trbGripper As TrackBar
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents lblBaseVal As Label
    Friend WithEvents lblShoulderVal As Label
    Friend WithEvents lblGripperVal As Label
End Class
