<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_MainContanerSpleter = New System.Windows.Forms.SplitContainer()
        Me._IMSS_LOCKED_LISTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_ItemName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ItemStatus = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ItemPath = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_LOCK_ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UnlockItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenLocationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_UNLOCKED_LISTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_ItemName_Ulock = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ItemStatus_Unlock = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ItemPath_Unlock = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_UnLockContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me._IMSS_LockItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_RemoveItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me._IMSS_AddFolderToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_AddFileToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_PropertiesToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_DotNetBarManager = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me._IMSS_TitleBar = New DevComponents.DotNetBar.Bar()
        Me._IMSS_AddFolder = New DevComponents.DotNetBar.ButtonItem()
        Me._IMSS_AddFiles = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me._IMSS_AddFolders = New System.Windows.Forms.FolderBrowserDialog()
        Me._IMSS_AddFile = New System.Windows.Forms.OpenFileDialog()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_MainContanerSpleter.Panel1.SuspendLayout()
        Me._IMSS_MainContanerSpleter.Panel2.SuspendLayout()
        Me._IMSS_MainContanerSpleter.SuspendLayout()
        CType(Me._IMSS_LOCKED_LISTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_LOCK_ContextMenu.SuspendLayout()
        CType(Me._IMSS_UNLOCKED_LISTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_UnLockContextMenu.SuspendLayout()
        Me.DockSite7.SuspendLayout()
        CType(Me._IMSS_TitleBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_MainContanerSpleter)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 26)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(736, 493)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_MainContanerSpleter
        '
        Me._IMSS_MainContanerSpleter.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainContanerSpleter.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainContanerSpleter.Name = "_IMSS_MainContanerSpleter"
        '
        '_IMSS_MainContanerSpleter.Panel1
        '
        Me._IMSS_MainContanerSpleter.Panel1.Controls.Add(Me._IMSS_LOCKED_LISTVIEW)
        '
        '_IMSS_MainContanerSpleter.Panel2
        '
        Me._IMSS_MainContanerSpleter.Panel2.Controls.Add(Me._IMSS_UNLOCKED_LISTVIEW)
        Me._IMSS_MainContanerSpleter.Size = New System.Drawing.Size(736, 493)
        Me._IMSS_MainContanerSpleter.SplitterDistance = 360
        Me._IMSS_MainContanerSpleter.TabIndex = 2
        '
        '_IMSS_LOCKED_LISTVIEW
        '
        Me._IMSS_LOCKED_LISTVIEW.AllowDrag = True
        Me._IMSS_LOCKED_LISTVIEW.AllowDrop = True
        Me._IMSS_LOCKED_LISTVIEW.AutoSizeItemsInDetailsView = True
        Me._IMSS_LOCKED_LISTVIEW.Columns.AddRange(New Object() {Me._IMSS_ItemName, Me._IMSS_ItemStatus, Me._IMSS_ItemPath})
        Me._IMSS_LOCKED_LISTVIEW.ContextMenuStrip = Me._IMSS_LOCK_ContextMenu
        Me._IMSS_LOCKED_LISTVIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_LOCKED_LISTVIEW.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LOCKED_LISTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_LOCKED_LISTVIEW.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_LOCKED_LISTVIEW.MultiSelect = False
        Me._IMSS_LOCKED_LISTVIEW.Name = "_IMSS_LOCKED_LISTVIEW"
        Me._IMSS_LOCKED_LISTVIEW.ShowDefaultGroupHeader = False
        Me._IMSS_LOCKED_LISTVIEW.ShowEmptyGroups = True
        Me._IMSS_LOCKED_LISTVIEW.Size = New System.Drawing.Size(360, 493)
        Me._IMSS_LOCKED_LISTVIEW.TabIndex = 0
        '
        '_IMSS_ItemName
        '
        Me._IMSS_ItemName.Name = "_IMSS_ItemName"
        Me._IMSS_ItemName.Text = "Item Name"
        '
        '_IMSS_ItemStatus
        '
        Me._IMSS_ItemStatus.Name = "_IMSS_ItemStatus"
        Me._IMSS_ItemStatus.Text = "Item Status"
        Me._IMSS_ItemStatus.Width = 96
        '
        '_IMSS_ItemPath
        '
        Me._IMSS_ItemPath.Name = "_IMSS_ItemPath"
        Me._IMSS_ItemPath.Text = "Item Path"
        '
        '_IMSS_LOCK_ContextMenu
        '
        Me._IMSS_LOCK_ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnlockItemToolStripMenuItem, Me.RemoveItemsToolStripMenuItem, Me.ClearListToolStripMenuItem1, Me.ToolStripSeparator1, Me.AddFolderToolStripMenuItem, Me.AddFileToolStripMenuItem, Me.ToolStripSeparator2, Me.OpenLocationToolStripMenuItem1, Me.PropertiesToolStripMenuItem})
        Me._IMSS_LOCK_ContextMenu.Name = "_IMSS_LOCK_ContextMenu"
        Me._IMSS_LOCK_ContextMenu.Size = New System.Drawing.Size(153, 170)
        '
        'UnlockItemToolStripMenuItem
        '
        Me.UnlockItemToolStripMenuItem.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_UnLocked_Icon_16x16
        Me.UnlockItemToolStripMenuItem.Name = "UnlockItemToolStripMenuItem"
        Me.UnlockItemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UnlockItemToolStripMenuItem.Text = "Unlock Item"
        '
        'RemoveItemsToolStripMenuItem
        '
        Me.RemoveItemsToolStripMenuItem.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_DeleteButton_Icon_16x16
        Me.RemoveItemsToolStripMenuItem.Name = "RemoveItemsToolStripMenuItem"
        Me.RemoveItemsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RemoveItemsToolStripMenuItem.Text = "Remove Items"
        '
        'ClearListToolStripMenuItem1
        '
        Me.ClearListToolStripMenuItem1.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_Refresh_Icon_16x16
        Me.ClearListToolStripMenuItem1.Name = "ClearListToolStripMenuItem1"
        Me.ClearListToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ClearListToolStripMenuItem1.Text = "Clear List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'AddFolderToolStripMenuItem
        '
        Me.AddFolderToolStripMenuItem.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_ADD_ICON
        Me.AddFolderToolStripMenuItem.Name = "AddFolderToolStripMenuItem"
        Me.AddFolderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddFolderToolStripMenuItem.Text = "Add Folder"
        '
        'AddFileToolStripMenuItem
        '
        Me.AddFileToolStripMenuItem.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_ADD_FOLDER_ICON
        Me.AddFileToolStripMenuItem.Name = "AddFileToolStripMenuItem"
        Me.AddFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddFileToolStripMenuItem.Text = "Add File"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'OpenLocationToolStripMenuItem1
        '
        Me.OpenLocationToolStripMenuItem1.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_OpenFileLocation_Icon_16x16
        Me.OpenLocationToolStripMenuItem1.Name = "OpenLocationToolStripMenuItem1"
        Me.OpenLocationToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.OpenLocationToolStripMenuItem1.Text = "Open Location"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_SystemProcesses_Icon_16x16
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        '_IMSS_UNLOCKED_LISTVIEW
        '
        Me._IMSS_UNLOCKED_LISTVIEW.AllowDrag = True
        Me._IMSS_UNLOCKED_LISTVIEW.AllowDrop = True
        Me._IMSS_UNLOCKED_LISTVIEW.AutoSizeItemsInDetailsView = True
        Me._IMSS_UNLOCKED_LISTVIEW.Columns.AddRange(New Object() {Me._IMSS_ItemName_Ulock, Me._IMSS_ItemStatus_Unlock, Me._IMSS_ItemPath_Unlock})
        Me._IMSS_UNLOCKED_LISTVIEW.ContextMenuStrip = Me._IMSS_UnLockContextMenu
        Me._IMSS_UNLOCKED_LISTVIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_UNLOCKED_LISTVIEW.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_UNLOCKED_LISTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_UNLOCKED_LISTVIEW.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_UNLOCKED_LISTVIEW.MultiSelect = False
        Me._IMSS_UNLOCKED_LISTVIEW.Name = "_IMSS_UNLOCKED_LISTVIEW"
        Me._IMSS_UNLOCKED_LISTVIEW.ShowDefaultGroupHeader = False
        Me._IMSS_UNLOCKED_LISTVIEW.ShowEmptyGroups = True
        Me._IMSS_UNLOCKED_LISTVIEW.Size = New System.Drawing.Size(372, 493)
        Me._IMSS_UNLOCKED_LISTVIEW.TabIndex = 1
        '
        '_IMSS_ItemName_Ulock
        '
        Me._IMSS_ItemName_Ulock.Name = "_IMSS_ItemName_Ulock"
        Me._IMSS_ItemName_Ulock.Text = "Item Name"
        '
        '_IMSS_ItemStatus_Unlock
        '
        Me._IMSS_ItemStatus_Unlock.Name = "_IMSS_ItemStatus_Unlock"
        Me._IMSS_ItemStatus_Unlock.Text = "Item Status"
        Me._IMSS_ItemStatus_Unlock.Width = 105
        '
        '_IMSS_ItemPath_Unlock
        '
        Me._IMSS_ItemPath_Unlock.Name = "_IMSS_ItemPath_Unlock"
        Me._IMSS_ItemPath_Unlock.Text = "Item Status"
        '
        '_IMSS_UnLockContextMenu
        '
        Me._IMSS_UnLockContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._IMSS_LockItem, Me._IMSS_RemoveItems, Me.ClearListToolStripMenuItem, Me.ToolStripSeparator3, Me._IMSS_AddFolderToolStrip, Me._IMSS_AddFileToolStrip, Me.ToolStripSeparator4, Me.OpenLocationToolStripMenuItem, Me._IMSS_PropertiesToolStrip})
        Me._IMSS_UnLockContextMenu.Name = "_IMSS_LOCK_ContextMenu"
        Me._IMSS_UnLockContextMenu.Size = New System.Drawing.Size(153, 170)
        '
        '_IMSS_LockItem
        '
        Me._IMSS_LockItem.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_Locked_Icon_16x16
        Me._IMSS_LockItem.Name = "_IMSS_LockItem"
        Me._IMSS_LockItem.Size = New System.Drawing.Size(152, 22)
        Me._IMSS_LockItem.Text = "Lock Item"
        '
        '_IMSS_RemoveItems
        '
        Me._IMSS_RemoveItems.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_DeleteButton_Icon_16x16
        Me._IMSS_RemoveItems.Name = "_IMSS_RemoveItems"
        Me._IMSS_RemoveItems.Size = New System.Drawing.Size(152, 22)
        Me._IMSS_RemoveItems.Text = "Remove Items"
        '
        'ClearListToolStripMenuItem
        '
        Me.ClearListToolStripMenuItem.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_Refresh_Icon_16x16
        Me.ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem"
        Me.ClearListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearListToolStripMenuItem.Text = "Clear List"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        '_IMSS_AddFolderToolStrip
        '
        Me._IMSS_AddFolderToolStrip.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_ADD_ICON
        Me._IMSS_AddFolderToolStrip.Name = "_IMSS_AddFolderToolStrip"
        Me._IMSS_AddFolderToolStrip.Size = New System.Drawing.Size(152, 22)
        Me._IMSS_AddFolderToolStrip.Text = "Add Folder"
        '
        '_IMSS_AddFileToolStrip
        '
        Me._IMSS_AddFileToolStrip.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_ADD_FOLDER_ICON
        Me._IMSS_AddFileToolStrip.Name = "_IMSS_AddFileToolStrip"
        Me._IMSS_AddFileToolStrip.Size = New System.Drawing.Size(152, 22)
        Me._IMSS_AddFileToolStrip.Text = "Add File"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'OpenLocationToolStripMenuItem
        '
        Me.OpenLocationToolStripMenuItem.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_OpenFileLocation_Icon_16x16
        Me.OpenLocationToolStripMenuItem.Name = "OpenLocationToolStripMenuItem"
        Me.OpenLocationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenLocationToolStripMenuItem.Text = "Open Location"
        '
        '_IMSS_PropertiesToolStrip
        '
        Me._IMSS_PropertiesToolStrip.Image = Global.IMSS_Lock_Manager.My.Resources.Resources._IMSS_SystemProcesses_Icon_16x16
        Me._IMSS_PropertiesToolStrip.Name = "_IMSS_PropertiesToolStrip"
        Me._IMSS_PropertiesToolStrip.Size = New System.Drawing.Size(152, 22)
        Me._IMSS_PropertiesToolStrip.Text = "Properties"
        '
        '_IMSS_DotNetBarManager
        '
        Me._IMSS_DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me._IMSS_DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me._IMSS_DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me._IMSS_DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me._IMSS_DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me._IMSS_DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me._IMSS_DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me._IMSS_DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me._IMSS_DotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me._IMSS_DotNetBarManager.BottomDockSite = Me.DockSite4
        Me._IMSS_DotNetBarManager.EnableFullSizeDock = False
        Me._IMSS_DotNetBarManager.LeftDockSite = Me.DockSite1
        Me._IMSS_DotNetBarManager.ParentForm = Me
        Me._IMSS_DotNetBarManager.RightDockSite = Me.DockSite2
        Me._IMSS_DotNetBarManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_DotNetBarManager.ToolbarBottomDockSite = Me.DockSite8
        Me._IMSS_DotNetBarManager.ToolbarLeftDockSite = Me.DockSite5
        Me._IMSS_DotNetBarManager.ToolbarRightDockSite = Me.DockSite6
        Me._IMSS_DotNetBarManager.ToolbarTopDockSite = Me.DockSite7
        Me._IMSS_DotNetBarManager.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.Location = New System.Drawing.Point(0, 519)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(736, 0)
        Me.DockSite4.TabIndex = 4
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 26)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 493)
        Me.DockSite1.TabIndex = 1
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(736, 26)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 493)
        Me.DockSite2.TabIndex = 2
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 519)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(736, 0)
        Me.DockSite8.TabIndex = 8
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 26)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 493)
        Me.DockSite5.TabIndex = 5
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(736, 26)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 493)
        Me.DockSite6.TabIndex = 6
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Controls.Add(Me._IMSS_TitleBar)
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(736, 26)
        Me.DockSite7.TabIndex = 7
        Me.DockSite7.TabStop = False
        '
        '_IMSS_TitleBar
        '
        Me._IMSS_TitleBar.AccessibleDescription = "DotNetBar Bar (_IMSS_TitleBar)"
        Me._IMSS_TitleBar.AccessibleName = "DotNetBar Bar"
        Me._IMSS_TitleBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me._IMSS_TitleBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_TitleBar.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me._IMSS_TitleBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me._IMSS_TitleBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me._IMSS_TitleBar.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_AddFolder, Me._IMSS_AddFiles})
        Me._IMSS_TitleBar.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_TitleBar.Name = "_IMSS_TitleBar"
        Me._IMSS_TitleBar.Size = New System.Drawing.Size(736, 25)
        Me._IMSS_TitleBar.Stretch = True
        Me._IMSS_TitleBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_TitleBar.TabIndex = 0
        Me._IMSS_TitleBar.TabStop = False
        Me._IMSS_TitleBar.Text = "Menu Items"
        '
        '_IMSS_AddFolder
        '
        Me._IMSS_AddFolder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_AddFolder.Image = CType(resources.GetObject("_IMSS_AddFolder.Image"), System.Drawing.Image)
        Me._IMSS_AddFolder.Name = "_IMSS_AddFolder"
        Me._IMSS_AddFolder.Text = "Add Folder"
        '
        '_IMSS_AddFiles
        '
        Me._IMSS_AddFiles.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me._IMSS_AddFiles.Image = CType(resources.GetObject("_IMSS_AddFiles.Image"), System.Drawing.Image)
        Me._IMSS_AddFiles.Name = "_IMSS_AddFiles"
        Me._IMSS_AddFiles.Text = "Add Files"
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 26)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(736, 0)
        Me.DockSite3.TabIndex = 3
        Me.DockSite3.TabStop = False
        '
        '_IMSS_AddFolders
        '
        Me._IMSS_AddFolders.Description = "Add folder to lock/unlcok it"
        '
        '_IMSS_AddFile
        '
        Me._IMSS_AddFile.FileName = "OpenFileDialog1"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 519)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Lock Manager"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainContanerSpleter.Panel1.ResumeLayout(False)
        Me._IMSS_MainContanerSpleter.Panel2.ResumeLayout(False)
        Me._IMSS_MainContanerSpleter.ResumeLayout(False)
        CType(Me._IMSS_LOCKED_LISTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_LOCK_ContextMenu.ResumeLayout(False)
        CType(Me._IMSS_UNLOCKED_LISTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_UnLockContextMenu.ResumeLayout(False)
        Me.DockSite7.ResumeLayout(False)
        CType(Me._IMSS_TitleBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_DotNetBarManager As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents _IMSS_TitleBar As DevComponents.DotNetBar.Bar
    Friend WithEvents _IMSS_AddFolder As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_AddFiles As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents _IMSS_UNLOCKED_LISTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_LOCKED_LISTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_MainContanerSpleter As System.Windows.Forms.SplitContainer
    Friend WithEvents _IMSS_ItemName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ItemStatus As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ItemPath As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ItemName_Ulock As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ItemStatus_Unlock As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ItemPath_Unlock As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_AddFolders As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents _IMSS_LOCK_ContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UnlockItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_UnLockContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents _IMSS_LockItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_RemoveItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _IMSS_AddFolderToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_AddFileToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _IMSS_PropertiesToolStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_AddFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ClearListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenLocationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
