﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.buttonHlsAppPath = New System.Windows.Forms.Button()
        Me.buttonUdpAppPath = New System.Windows.Forms.Button()
        Me.textBoxHlsOpt2 = New System.Windows.Forms.TextBox()
        Me.labelHlsOpt2 = New System.Windows.Forms.Label()
        Me.textBoxHlsApp = New System.Windows.Forms.TextBox()
        Me.labelHlsApp = New System.Windows.Forms.Label()
        Me.textBoxUdpApp = New System.Windows.Forms.TextBox()
        Me.labelUdpApp = New System.Windows.Forms.Label()
        Me.textHttpPortNumber = New System.Windows.Forms.TextBox()
        Me.labelPortNuber = New System.Windows.Forms.Label()
        Me.ButtonMovieStart = New System.Windows.Forms.Button()
        Me.ButtonMovieStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonWebStop = New System.Windows.Forms.Button()
        Me.ButtonWebStart = New System.Windows.Forms.Button()
        Me.ComboBoxNum = New System.Windows.Forms.ComboBox()
        Me.textBoxUdpPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxChSpace = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonWWWROOT = New System.Windows.Forms.Button()
        Me.TextBoxWWWroot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxLog = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonBonDriverPath = New System.Windows.Forms.Button()
        Me.TextBoxBonDriverPath = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxBonDriver = New System.Windows.Forms.ComboBox()
        Me.ComboBoxServiceID = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxResolution = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonHLSoption = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonFILEROOT = New System.Windows.Forms.Button()
        Me.TextBoxFILEROOT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBoxShowConsole = New System.Windows.Forms.CheckBox()
        Me.LabelStream = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonHlsAppPath
        '
        Me.buttonHlsAppPath.Location = New System.Drawing.Point(491, 233)
        Me.buttonHlsAppPath.Name = "buttonHlsAppPath"
        Me.buttonHlsAppPath.Size = New System.Drawing.Size(25, 19)
        Me.buttonHlsAppPath.TabIndex = 38
        Me.buttonHlsAppPath.Text = "..."
        Me.buttonHlsAppPath.UseVisualStyleBackColor = True
        '
        'buttonUdpAppPath
        '
        Me.buttonUdpAppPath.Location = New System.Drawing.Point(492, 139)
        Me.buttonUdpAppPath.Name = "buttonUdpAppPath"
        Me.buttonUdpAppPath.Size = New System.Drawing.Size(25, 19)
        Me.buttonUdpAppPath.TabIndex = 23
        Me.buttonUdpAppPath.Text = "..."
        Me.buttonUdpAppPath.UseVisualStyleBackColor = True
        '
        'textBoxHlsOpt2
        '
        Me.textBoxHlsOpt2.Location = New System.Drawing.Point(102, 258)
        Me.textBoxHlsOpt2.Multiline = True
        Me.textBoxHlsOpt2.Name = "textBoxHlsOpt2"
        Me.textBoxHlsOpt2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBoxHlsOpt2.Size = New System.Drawing.Size(415, 118)
        Me.textBoxHlsOpt2.TabIndex = 40
        '
        'labelHlsOpt2
        '
        Me.labelHlsOpt2.AutoSize = True
        Me.labelHlsOpt2.Location = New System.Drawing.Point(8, 261)
        Me.labelHlsOpt2.Name = "labelHlsOpt2"
        Me.labelHlsOpt2.Size = New System.Drawing.Size(73, 12)
        Me.labelHlsOpt2.TabIndex = 26
        Me.labelHlsOpt2.Text = "HLS オプション"
        '
        'textBoxHlsApp
        '
        Me.textBoxHlsApp.Location = New System.Drawing.Point(102, 233)
        Me.textBoxHlsApp.Name = "textBoxHlsApp"
        Me.textBoxHlsApp.Size = New System.Drawing.Size(384, 19)
        Me.textBoxHlsApp.TabIndex = 37
        '
        'labelHlsApp
        '
        Me.labelHlsApp.AutoSize = True
        Me.labelHlsApp.Location = New System.Drawing.Point(8, 236)
        Me.labelHlsApp.Name = "labelHlsApp"
        Me.labelHlsApp.Size = New System.Drawing.Size(51, 12)
        Me.labelHlsApp.TabIndex = 29
        Me.labelHlsApp.Text = "HLSアプリ"
        '
        'textBoxUdpApp
        '
        Me.textBoxUdpApp.Location = New System.Drawing.Point(102, 139)
        Me.textBoxUdpApp.Name = "textBoxUdpApp"
        Me.textBoxUdpApp.Size = New System.Drawing.Size(384, 19)
        Me.textBoxUdpApp.TabIndex = 22
        '
        'labelUdpApp
        '
        Me.labelUdpApp.AutoSize = True
        Me.labelUdpApp.Location = New System.Drawing.Point(7, 142)
        Me.labelUdpApp.Name = "labelUdpApp"
        Me.labelUdpApp.Size = New System.Drawing.Size(53, 12)
        Me.labelUdpApp.TabIndex = 27
        Me.labelUdpApp.Text = "UDPアプリ"
        '
        'textHttpPortNumber
        '
        Me.textHttpPortNumber.Location = New System.Drawing.Point(102, 80)
        Me.textHttpPortNumber.Name = "textHttpPortNumber"
        Me.textHttpPortNumber.Size = New System.Drawing.Size(43, 19)
        Me.textHttpPortNumber.TabIndex = 42
        Me.textHttpPortNumber.Text = "40003"
        '
        'labelPortNuber
        '
        Me.labelPortNuber.AutoSize = True
        Me.labelPortNuber.Location = New System.Drawing.Point(6, 83)
        Me.labelPortNuber.Name = "labelPortNuber"
        Me.labelPortNuber.Size = New System.Drawing.Size(80, 12)
        Me.labelPortNuber.TabIndex = 21
        Me.labelPortNuber.Text = "HTTPポート (*)"
        '
        'ButtonMovieStart
        '
        Me.ButtonMovieStart.Location = New System.Drawing.Point(374, 489)
        Me.ButtonMovieStart.Name = "ButtonMovieStart"
        Me.ButtonMovieStart.Size = New System.Drawing.Size(68, 28)
        Me.ButtonMovieStart.TabIndex = 49
        Me.ButtonMovieStart.Text = "Start"
        Me.ButtonMovieStart.UseVisualStyleBackColor = True
        '
        'ButtonMovieStop
        '
        Me.ButtonMovieStop.Location = New System.Drawing.Point(448, 489)
        Me.ButtonMovieStop.Name = "ButtonMovieStop"
        Me.ButtonMovieStop.Size = New System.Drawing.Size(68, 28)
        Me.ButtonMovieStop.TabIndex = 50
        Me.ButtonMovieStop.Text = "Stop"
        Me.ButtonMovieStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ButtonWebStop
        '
        Me.ButtonWebStop.Enabled = False
        Me.ButtonWebStop.Location = New System.Drawing.Point(233, 102)
        Me.ButtonWebStop.Name = "ButtonWebStop"
        Me.ButtonWebStop.Size = New System.Drawing.Size(68, 28)
        Me.ButtonWebStop.TabIndex = 52
        Me.ButtonWebStop.Text = "WebStop"
        Me.ButtonWebStop.UseVisualStyleBackColor = True
        Me.ButtonWebStop.Visible = False
        '
        'ButtonWebStart
        '
        Me.ButtonWebStart.Location = New System.Drawing.Point(233, 77)
        Me.ButtonWebStart.Name = "ButtonWebStart"
        Me.ButtonWebStart.Size = New System.Drawing.Size(68, 28)
        Me.ButtonWebStart.TabIndex = 51
        Me.ButtonWebStart.Text = "WebStart"
        Me.ButtonWebStart.UseVisualStyleBackColor = True
        Me.ButtonWebStart.Visible = False
        '
        'ComboBoxNum
        '
        Me.ComboBoxNum.FormattingEnabled = True
        Me.ComboBoxNum.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboBoxNum.Location = New System.Drawing.Point(102, 418)
        Me.ComboBoxNum.Name = "ComboBoxNum"
        Me.ComboBoxNum.Size = New System.Drawing.Size(51, 20)
        Me.ComboBoxNum.TabIndex = 53
        Me.ComboBoxNum.Text = "1"
        '
        'textBoxUdpPort
        '
        Me.textBoxUdpPort.Location = New System.Drawing.Point(102, 189)
        Me.textBoxUdpPort.Name = "textBoxUdpPort"
        Me.textBoxUdpPort.Size = New System.Drawing.Size(43, 19)
        Me.textBoxUdpPort.TabIndex = 55
        Me.textBoxUdpPort.Text = "42424"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 12)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "UDPポート (*)"
        '
        'TextBoxChSpace
        '
        Me.TextBoxChSpace.Location = New System.Drawing.Point(102, 469)
        Me.TextBoxChSpace.Name = "TextBoxChSpace"
        Me.TextBoxChSpace.Size = New System.Drawing.Size(28, 19)
        Me.TextBoxChSpace.TabIndex = 57
        Me.TextBoxChSpace.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 472)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 12)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "chspace"
        '
        'ButtonWWWROOT
        '
        Me.ButtonWWWROOT.Location = New System.Drawing.Point(492, 30)
        Me.ButtonWWWROOT.Name = "ButtonWWWROOT"
        Me.ButtonWWWROOT.Size = New System.Drawing.Size(25, 19)
        Me.ButtonWWWROOT.TabIndex = 60
        Me.ButtonWWWROOT.Text = "..."
        Me.ButtonWWWROOT.UseVisualStyleBackColor = True
        '
        'TextBoxWWWroot
        '
        Me.TextBoxWWWroot.Location = New System.Drawing.Point(102, 30)
        Me.TextBoxWWWroot.Name = "TextBoxWWWroot"
        Me.TextBoxWWWroot.Size = New System.Drawing.Size(384, 19)
        Me.TextBoxWWWroot.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 12)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "%WWWROOT% (*)"
        '
        'TextBoxLog
        '
        Me.TextBoxLog.Location = New System.Drawing.Point(0, 523)
        Me.TextBoxLog.Multiline = True
        Me.TextBoxLog.Name = "TextBoxLog"
        Me.TextBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxLog.Size = New System.Drawing.Size(529, 141)
        Me.TextBoxLog.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 447)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 12)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "BonDriver"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 497)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 12)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "ServiceID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 421)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 12)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "ストリーム Number"
        '
        'ButtonBonDriverPath
        '
        Me.ButtonBonDriverPath.Location = New System.Drawing.Point(492, 164)
        Me.ButtonBonDriverPath.Name = "ButtonBonDriverPath"
        Me.ButtonBonDriverPath.Size = New System.Drawing.Size(25, 19)
        Me.ButtonBonDriverPath.TabIndex = 69
        Me.ButtonBonDriverPath.Text = "..."
        Me.ButtonBonDriverPath.UseVisualStyleBackColor = True
        '
        'TextBoxBonDriverPath
        '
        Me.TextBoxBonDriverPath.Location = New System.Drawing.Point(102, 164)
        Me.TextBoxBonDriverPath.Name = "TextBoxBonDriverPath"
        Me.TextBoxBonDriverPath.Size = New System.Drawing.Size(384, 19)
        Me.TextBoxBonDriverPath.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 12)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "BonDriver Path"
        '
        'ComboBoxBonDriver
        '
        Me.ComboBoxBonDriver.FormattingEnabled = True
        Me.ComboBoxBonDriver.Location = New System.Drawing.Point(102, 443)
        Me.ComboBoxBonDriver.Name = "ComboBoxBonDriver"
        Me.ComboBoxBonDriver.Size = New System.Drawing.Size(210, 20)
        Me.ComboBoxBonDriver.TabIndex = 71
        '
        'ComboBoxServiceID
        '
        Me.ComboBoxServiceID.FormattingEnabled = True
        Me.ComboBoxServiceID.Location = New System.Drawing.Point(102, 494)
        Me.ComboBoxServiceID.Name = "ComboBoxServiceID"
        Me.ComboBoxServiceID.Size = New System.Drawing.Size(249, 20)
        Me.ComboBoxServiceID.TabIndex = 72
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(415, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 28)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "index.htmlを開く"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(200, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 12)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "＋Number"
        '
        'ComboBoxResolution
        '
        Me.ComboBoxResolution.FormattingEnabled = True
        Me.ComboBoxResolution.Location = New System.Drawing.Point(322, 382)
        Me.ComboBoxResolution.Name = "ComboBoxResolution"
        Me.ComboBoxResolution.Size = New System.Drawing.Size(87, 20)
        Me.ComboBoxResolution.TabIndex = 75
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(307, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 28)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "index.htmlを編集"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonHLSoption
        '
        Me.ButtonHLSoption.Location = New System.Drawing.Point(415, 377)
        Me.ButtonHLSoption.Name = "ButtonHLSoption"
        Me.ButtonHLSoption.Size = New System.Drawing.Size(102, 28)
        Me.ButtonHLSoption.TabIndex = 77
        Me.ButtonHLSoption.Text = "HLS_option.txt(*)"
        Me.ButtonHLSoption.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(148, 77)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(52, 25)
        Me.Button5.TabIndex = 79
        Me.Button5.Text = "初期値"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(148, 186)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(52, 25)
        Me.Button6.TabIndex = 80
        Me.Button6.Text = "初期値"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(312, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(204, 12)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "(*)変更後はこのアプリを再起動してください"
        '
        'ButtonFILEROOT
        '
        Me.ButtonFILEROOT.Location = New System.Drawing.Point(492, 55)
        Me.ButtonFILEROOT.Name = "ButtonFILEROOT"
        Me.ButtonFILEROOT.Size = New System.Drawing.Size(25, 19)
        Me.ButtonFILEROOT.TabIndex = 83
        Me.ButtonFILEROOT.Text = "..."
        Me.ButtonFILEROOT.UseVisualStyleBackColor = True
        '
        'TextBoxFILEROOT
        '
        Me.TextBoxFILEROOT.Location = New System.Drawing.Point(102, 55)
        Me.TextBoxFILEROOT.Name = "TextBoxFILEROOT"
        Me.TextBoxFILEROOT.Size = New System.Drawing.Size(384, 19)
        Me.TextBoxFILEROOT.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "%FILEROOT% (*)"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "TvRemoteViewer_VB"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.終了ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(76, 26)
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        'CheckBoxShowConsole
        '
        Me.CheckBoxShowConsole.AutoSize = True
        Me.CheckBoxShowConsole.Location = New System.Drawing.Point(395, 458)
        Me.CheckBoxShowConsole.Name = "CheckBoxShowConsole"
        Me.CheckBoxShowConsole.Size = New System.Drawing.Size(122, 16)
        Me.CheckBoxShowConsole.TabIndex = 86
        Me.CheckBoxShowConsole.Text = "コンソールを表示する"
        Me.CheckBoxShowConsole.UseVisualStyleBackColor = True
        '
        'LabelStream
        '
        Me.LabelStream.AutoSize = True
        Me.LabelStream.Location = New System.Drawing.Point(165, 422)
        Me.LabelStream.Name = "LabelStream"
        Me.LabelStream.Size = New System.Drawing.Size(47, 12)
        Me.LabelStream.TabIndex = 88
        Me.LabelStream.Text = "配信中："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 665)
        Me.Controls.Add(Me.LabelStream)
        Me.Controls.Add(Me.CheckBoxShowConsole)
        Me.Controls.Add(Me.ButtonFILEROOT)
        Me.Controls.Add(Me.TextBoxFILEROOT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ButtonHLSoption)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxResolution)
        Me.Controls.Add(Me.textBoxUdpPort)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBoxServiceID)
        Me.Controls.Add(Me.ComboBoxBonDriver)
        Me.Controls.Add(Me.ButtonBonDriverPath)
        Me.Controls.Add(Me.TextBoxBonDriverPath)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxLog)
        Me.Controls.Add(Me.ButtonWWWROOT)
        Me.Controls.Add(Me.TextBoxWWWroot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxChSpace)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxNum)
        Me.Controls.Add(Me.ButtonWebStop)
        Me.Controls.Add(Me.ButtonWebStart)
        Me.Controls.Add(Me.ButtonMovieStop)
        Me.Controls.Add(Me.ButtonMovieStart)
        Me.Controls.Add(Me.buttonHlsAppPath)
        Me.Controls.Add(Me.buttonUdpAppPath)
        Me.Controls.Add(Me.textBoxHlsOpt2)
        Me.Controls.Add(Me.labelHlsOpt2)
        Me.Controls.Add(Me.textBoxHlsApp)
        Me.Controls.Add(Me.labelHlsApp)
        Me.Controls.Add(Me.textBoxUdpApp)
        Me.Controls.Add(Me.labelUdpApp)
        Me.Controls.Add(Me.textHttpPortNumber)
        Me.Controls.Add(Me.labelPortNuber)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(545, 702)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "TvRemoteViewer_VB"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents buttonHlsAppPath As System.Windows.Forms.Button
    Private WithEvents buttonUdpAppPath As System.Windows.Forms.Button
    Private WithEvents textBoxHlsOpt2 As System.Windows.Forms.TextBox
    Private WithEvents labelHlsOpt2 As System.Windows.Forms.Label
    Private WithEvents textBoxHlsApp As System.Windows.Forms.TextBox
    Private WithEvents labelHlsApp As System.Windows.Forms.Label
    Private WithEvents textBoxUdpApp As System.Windows.Forms.TextBox
    Private WithEvents labelUdpApp As System.Windows.Forms.Label
    Private WithEvents textHttpPortNumber As System.Windows.Forms.TextBox
    Private WithEvents labelPortNuber As System.Windows.Forms.Label
    Friend WithEvents ButtonMovieStart As System.Windows.Forms.Button
    Friend WithEvents ButtonMovieStop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonWebStop As System.Windows.Forms.Button
    Friend WithEvents ButtonWebStart As System.Windows.Forms.Button
    Friend WithEvents ComboBoxNum As System.Windows.Forms.ComboBox
    Private WithEvents textBoxUdpPort As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents TextBoxChSpace As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents ButtonWWWROOT As System.Windows.Forms.Button
    Private WithEvents TextBoxWWWroot As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLog As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents ButtonBonDriverPath As System.Windows.Forms.Button
    Private WithEvents TextBoxBonDriverPath As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxBonDriver As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxServiceID As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxResolution As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonHLSoption As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents ButtonFILEROOT As System.Windows.Forms.Button
    Private WithEvents TextBoxFILEROOT As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 終了ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBoxShowConsole As System.Windows.Forms.CheckBox
    Private WithEvents LabelStream As System.Windows.Forms.Label

End Class
