<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_UnLock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_UnLock))
        Me._IMSS_UnLock_Button = New System.Windows.Forms.Button()
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Cancel_Button = New System.Windows.Forms.Button()
        Me._IMSS_Desc = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Passwd_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Password_TextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_UnLock_Button
        '
        Me._IMSS_UnLock_Button.Location = New System.Drawing.Point(154, 48)
        Me._IMSS_UnLock_Button.Name = "_IMSS_UnLock_Button"
        Me._IMSS_UnLock_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_UnLock_Button.TabIndex = 2
        Me._IMSS_UnLock_Button.Text = "UnLock"
        Me._IMSS_UnLock_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Cancel_Button)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Desc)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Passwd_Label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Password_TextBox)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_UnLock_Button)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(233, 72)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 6
        '
        '_IMSS_Cancel_Button
        '
        Me._IMSS_Cancel_Button.Location = New System.Drawing.Point(73, 48)
        Me._IMSS_Cancel_Button.Name = "_IMSS_Cancel_Button"
        Me._IMSS_Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel_Button.TabIndex = 3
        Me._IMSS_Cancel_Button.Text = "Cancel"
        Me._IMSS_Cancel_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_Desc
        '
        Me._IMSS_Desc.AutoSize = True
        '
        '
        '
        Me._IMSS_Desc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Desc.Location = New System.Drawing.Point(4, 3)
        Me._IMSS_Desc.Name = "_IMSS_Desc"
        Me._IMSS_Desc.Size = New System.Drawing.Size(180, 15)
        Me._IMSS_Desc.TabIndex = 5
        Me._IMSS_Desc.Text = "Please insert password to unlock item"
        '
        '_IMSS_Passwd_Label
        '
        Me._IMSS_Passwd_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_Passwd_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Passwd_Label.Location = New System.Drawing.Point(3, 23)
        Me._IMSS_Passwd_Label.Name = "_IMSS_Passwd_Label"
        Me._IMSS_Passwd_Label.Size = New System.Drawing.Size(47, 15)
        Me._IMSS_Passwd_Label.TabIndex = 4
        Me._IMSS_Passwd_Label.Text = "Password"
        '
        '_IMSS_Password_TextBox
        '
        '
        '
        '
        Me._IMSS_Password_TextBox.Border.Class = "TextBoxBorder"
        Me._IMSS_Password_TextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Password_TextBox.Location = New System.Drawing.Point(50, 21)
        Me._IMSS_Password_TextBox.Name = "_IMSS_Password_TextBox"
        Me._IMSS_Password_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._IMSS_Password_TextBox.Size = New System.Drawing.Size(180, 20)
        Me._IMSS_Password_TextBox.TabIndex = 1
        '
        'IMSS_UnLock
        '
        Me.AcceptButton = Me._IMSS_UnLock_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 72)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(249, 110)
        Me.MinimumSize = New System.Drawing.Size(249, 110)
        Me.Name = "IMSS_UnLock"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unlock Item"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_UnLock_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Desc As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Passwd_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Password_TextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_Cancel_Button As System.Windows.Forms.Button
End Class
