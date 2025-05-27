<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamples
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
        Me.btnGetServersInfo = New System.Windows.Forms.Button
        Me.tabExamples = New System.Windows.Forms.TabControl
        Me.tabGetServersInfo = New System.Windows.Forms.TabPage
        Me.tabGetDIDsInfo = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtServerPOP = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtClient = New System.Windows.Forms.TextBox
        Me.txtDID = New System.Windows.Forms.TextBox
        Me.btnGetDIDsInfo = New System.Windows.Forms.Button
        Me.tabGetBalance = New System.Windows.Forms.TabPage
        Me.chkAdvanced = New System.Windows.Forms.CheckBox
        Me.btnGetBalance = New System.Windows.Forms.Button
        Me.tabExamples.SuspendLayout()
        Me.tabGetServersInfo.SuspendLayout()
        Me.tabGetDIDsInfo.SuspendLayout()
        Me.tabGetBalance.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGetServersInfo
        '
        Me.btnGetServersInfo.Location = New System.Drawing.Point(100, 68)
        Me.btnGetServersInfo.Name = "btnGetServersInfo"
        Me.btnGetServersInfo.Size = New System.Drawing.Size(100, 23)
        Me.btnGetServersInfo.TabIndex = 2
        Me.btnGetServersInfo.Text = "Get Data"
        Me.btnGetServersInfo.UseVisualStyleBackColor = True
        '
        'tabExamples
        '
        Me.tabExamples.Controls.Add(Me.tabGetServersInfo)
        Me.tabExamples.Controls.Add(Me.tabGetDIDsInfo)
        Me.tabExamples.Controls.Add(Me.tabGetBalance)
        Me.tabExamples.Location = New System.Drawing.Point(12, 12)
        Me.tabExamples.Name = "tabExamples"
        Me.tabExamples.SelectedIndex = 0
        Me.tabExamples.Size = New System.Drawing.Size(238, 158)
        Me.tabExamples.TabIndex = 0
        '
        'tabGetServersInfo
        '
        Me.tabGetServersInfo.Controls.Add(Me.txtServerPOP)
        Me.tabGetServersInfo.Controls.Add(Me.Label1)
        Me.tabGetServersInfo.Controls.Add(Me.btnGetServersInfo)
        Me.tabGetServersInfo.Location = New System.Drawing.Point(4, 22)
        Me.tabGetServersInfo.Name = "tabGetServersInfo"
        Me.tabGetServersInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGetServersInfo.Size = New System.Drawing.Size(230, 132)
        Me.tabGetServersInfo.TabIndex = 0
        Me.tabGetServersInfo.Text = "getServersInfo"
        Me.tabGetServersInfo.UseVisualStyleBackColor = True
        '
        'tabGetDIDsInfo
        '
        Me.tabGetDIDsInfo.Controls.Add(Me.btnGetDIDsInfo)
        Me.tabGetDIDsInfo.Controls.Add(Me.txtDID)
        Me.tabGetDIDsInfo.Controls.Add(Me.txtClient)
        Me.tabGetDIDsInfo.Controls.Add(Me.Label3)
        Me.tabGetDIDsInfo.Controls.Add(Me.Label2)
        Me.tabGetDIDsInfo.Location = New System.Drawing.Point(4, 22)
        Me.tabGetDIDsInfo.Name = "tabGetDIDsInfo"
        Me.tabGetDIDsInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGetDIDsInfo.Size = New System.Drawing.Size(230, 132)
        Me.tabGetDIDsInfo.TabIndex = 1
        Me.tabGetDIDsInfo.Text = "getDIDsInfo"
        Me.tabGetDIDsInfo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server POP"
        '
        'txtServerPOP
        '
        Me.txtServerPOP.Location = New System.Drawing.Point(100, 42)
        Me.txtServerPOP.Name = "txtServerPOP"
        Me.txtServerPOP.Size = New System.Drawing.Size(100, 20)
        Me.txtServerPOP.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Client"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DID"
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(85, 29)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(100, 20)
        Me.txtClient.TabIndex = 1
        '
        'txtDID
        '
        Me.txtDID.Location = New System.Drawing.Point(85, 55)
        Me.txtDID.Name = "txtDID"
        Me.txtDID.Size = New System.Drawing.Size(100, 20)
        Me.txtDID.TabIndex = 3
        '
        'btnGetDIDsInfo
        '
        Me.btnGetDIDsInfo.Location = New System.Drawing.Point(85, 81)
        Me.btnGetDIDsInfo.Name = "btnGetDIDsInfo"
        Me.btnGetDIDsInfo.Size = New System.Drawing.Size(100, 23)
        Me.btnGetDIDsInfo.TabIndex = 4
        Me.btnGetDIDsInfo.Text = "Get Data"
        Me.btnGetDIDsInfo.UseVisualStyleBackColor = True
        '
        'tabGetBalance
        '
        Me.tabGetBalance.Controls.Add(Me.btnGetBalance)
        Me.tabGetBalance.Controls.Add(Me.chkAdvanced)
        Me.tabGetBalance.Location = New System.Drawing.Point(4, 22)
        Me.tabGetBalance.Name = "tabGetBalance"
        Me.tabGetBalance.Size = New System.Drawing.Size(230, 132)
        Me.tabGetBalance.TabIndex = 2
        Me.tabGetBalance.Text = "getBalance"
        Me.tabGetBalance.UseVisualStyleBackColor = True
        '
        'chkAdvanced
        '
        Me.chkAdvanced.AutoSize = True
        Me.chkAdvanced.Location = New System.Drawing.Point(78, 37)
        Me.chkAdvanced.Name = "chkAdvanced"
        Me.chkAdvanced.Size = New System.Drawing.Size(75, 17)
        Me.chkAdvanced.TabIndex = 0
        Me.chkAdvanced.Text = "Advanced"
        Me.chkAdvanced.UseVisualStyleBackColor = True
        '
        'btnGetBalance
        '
        Me.btnGetBalance.Location = New System.Drawing.Point(78, 61)
        Me.btnGetBalance.Name = "btnGetBalance"
        Me.btnGetBalance.Size = New System.Drawing.Size(75, 23)
        Me.btnGetBalance.TabIndex = 1
        Me.btnGetBalance.Text = "Get Data"
        Me.btnGetBalance.UseVisualStyleBackColor = True
        '
        'frmExamples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 192)
        Me.Controls.Add(Me.tabExamples)
        Me.Name = "frmExamples"
        Me.Text = "VoIP.ms API Examples"
        Me.tabExamples.ResumeLayout(False)
        Me.tabGetServersInfo.ResumeLayout(False)
        Me.tabGetServersInfo.PerformLayout()
        Me.tabGetDIDsInfo.ResumeLayout(False)
        Me.tabGetDIDsInfo.PerformLayout()
        Me.tabGetBalance.ResumeLayout(False)
        Me.tabGetBalance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetServersInfo As System.Windows.Forms.Button
    Friend WithEvents tabExamples As System.Windows.Forms.TabControl
    Friend WithEvents tabGetServersInfo As System.Windows.Forms.TabPage
    Friend WithEvents tabGetDIDsInfo As System.Windows.Forms.TabPage
    Friend WithEvents txtServerPOP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGetDIDsInfo As System.Windows.Forms.Button
    Friend WithEvents txtDID As System.Windows.Forms.TextBox
    Friend WithEvents txtClient As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabGetBalance As System.Windows.Forms.TabPage
    Friend WithEvents btnGetBalance As System.Windows.Forms.Button
    Friend WithEvents chkAdvanced As System.Windows.Forms.CheckBox
End Class
