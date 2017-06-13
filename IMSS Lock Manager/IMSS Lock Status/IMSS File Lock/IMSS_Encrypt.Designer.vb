<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_Encrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_Encrypt))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Desc = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Cancel_Button = New System.Windows.Forms.Button()
        Me._IMSS_Lock_Button = New System.Windows.Forms.Button()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_txtConPassEncrypt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_txtPassEncrypt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Desc)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Cancel_Button)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Lock_Button)
        Me._IMSS_MainPanel.Controls.Add(Me.LabelX2)
        Me._IMSS_MainPanel.Controls.Add(Me.LabelX1)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_txtConPassEncrypt)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_txtPassEncrypt)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(236, 92)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 1
        '
        '_IMSS_Desc
        '
        Me._IMSS_Desc.AutoSize = True
        '
        '
        '
        Me._IMSS_Desc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Desc.Location = New System.Drawing.Point(12, 0)
        Me._IMSS_Desc.Name = "_IMSS_Desc"
        Me._IMSS_Desc.Size = New System.Drawing.Size(168, 15)
        Me._IMSS_Desc.TabIndex = 6
        Me._IMSS_Desc.Text = "Please insert password to lock item"
        '
        '_IMSS_Cancel_Button
        '
        Me._IMSS_Cancel_Button.Location = New System.Drawing.Point(73, 64)
        Me._IMSS_Cancel_Button.Name = "_IMSS_Cancel_Button"
        Me._IMSS_Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel_Button.TabIndex = 3
        Me._IMSS_Cancel_Button.Text = "Cancel"
        Me._IMSS_Cancel_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_Lock_Button
        '
        Me._IMSS_Lock_Button.Location = New System.Drawing.Point(154, 64)
        Me._IMSS_Lock_Button.Name = "_IMSS_Lock_Button"
        Me._IMSS_Lock_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Lock_Button.TabIndex = 2
        Me._IMSS_Lock_Button.Text = "Lock"
        Me._IMSS_Lock_Button.UseVisualStyleBackColor = True
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(13, 46)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(39, 15)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Confrim"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(13, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(47, 15)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Password"
        '
        '_IMSS_txtConPassEncrypt
        '
        '
        '
        '
        Me._IMSS_txtConPassEncrypt.Border.Class = "TextBoxBorder"
        Me._IMSS_txtConPassEncrypt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_txtConPassEncrypt.Location = New System.Drawing.Point(61, 42)
        Me._IMSS_txtConPassEncrypt.Name = "_IMSS_txtConPassEncrypt"
        Me._IMSS_txtConPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._IMSS_txtConPassEncrypt.Size = New System.Drawing.Size(169, 20)
        Me._IMSS_txtConPassEncrypt.TabIndex = 1
        '
        '_IMSS_txtPassEncrypt
        '
        '
        '
        '
        Me._IMSS_txtPassEncrypt.Border.Class = "TextBoxBorder"
        Me._IMSS_txtPassEncrypt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_txtPassEncrypt.Location = New System.Drawing.Point(61, 16)
        Me._IMSS_txtPassEncrypt.Name = "_IMSS_txtPassEncrypt"
        Me._IMSS_txtPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._IMSS_txtPassEncrypt.Size = New System.Drawing.Size(169, 20)
        Me._IMSS_txtPassEncrypt.TabIndex = 0
        '
        'IMSS_Encrypt
        '
        Me.AcceptButton = Me._IMSS_Lock_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 92)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(252, 130)
        Me.MinimumSize = New System.Drawing.Size(252, 130)
        Me.Name = "IMSS_Encrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lock File"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Desc As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Lock_Button As System.Windows.Forms.Button
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_txtConPassEncrypt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_txtPassEncrypt As DevComponents.DotNetBar.Controls.TextBoxX
End Class
