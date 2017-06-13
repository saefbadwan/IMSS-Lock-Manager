Imports System.Security.AccessControl
Imports ComponentOwl.BetterListView
Imports System.Runtime.InteropServices

Public Class MainWindow
#Region "IMSS ResizeImage "
    Private Function _IMSS_ResizeImage(ByVal SourceImage As Drawing.Image, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmSource = New Drawing.Bitmap(SourceImage)
        Return _IMSS_ResizeImage(bmSource, TargetWidth, TargetHeight)
    End Function

    Private Function _IMSS_ResizeImage(ByVal bmSource As Drawing.Bitmap, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver
                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using
        Return bmDest
    End Function
#End Region
#Region "IMSS File Properties Show Dialog Var"
    <DllImport("Shell32", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ShellExecuteEx(ByRef lpExecInfo As SHELLEXECUTEINFO) As Boolean
    End Function
    Private Const SEE_MASK_INVOKEIDLIST = &HC
    Private Const SEE_MASK_NOCLOSEPROCESS = &H40
    Private Const SEE_MASK_FLAG_NO_UI = &H400
    Public Const SW_SHOW As Short = 5
    Public Structure SHELLEXECUTEINFO
        Public cbSize As Integer
        Public fMask As Integer
        Public hwnd As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpVerb As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpFile As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpParameters As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpDirectory As String
        Dim nShow As Integer
        Dim hInstApp As IntPtr
        Dim lpIDList As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpClass As String
        Public hkeyClass As IntPtr
        Public dwHotKey As Integer
        Public hIcon As IntPtr
        Public hProcess As IntPtr
    End Structure
#End Region
#Region "IMSS Folder Lock OPER"
    Private Function _IMSS_CheckIfItemIsAlreadyExsits(ByRef _IMSS_TargetItem As String, ByRef _IMSS_LIST_TARGET As BetterListView)
        For Each _IMSS_ITEM As BetterListViewItem In _IMSS_LIST_TARGET.Items
            If _IMSS_ITEM.Text = _IMSS_TargetItem Then
                Return True
                Exit For
            End If
        Next : Return False
    End Function
    Private Function _IMSS_CheckIfFolderIslocked(ByRef _IMSS_TARGET As String) As Boolean
        Return IIf(_IMSS_TARGET.Contains(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"), True, False)
    End Function
    Public Sub _IMSS_LOCKDIR(ByRef _IMSS_TARGET As String, ByRef _IMSS_Passwd As String)
        Dim d As New IO.DirectoryInfo(_IMSS_TARGET)
        My.Computer.FileSystem.WriteAllText(IO.Path.Combine(_IMSS_TARGET, "_IMSS_Password.IMSS"), _IMSS_Passwd, False)
        d.MoveTo(_IMSS_TARGET & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")
        _IMSS_LockWithAccessControl(_IMSS_TARGET & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")
        Try
            If Not _IMSS_CheckIfItemIsAlreadyExsits(IO.Path.GetFileName(_IMSS_TARGET), _IMSS_LOCKED_LISTVIEW) = True Then
                With _IMSS_LOCKED_LISTVIEW.Groups(0).Items.Add(IO.Path.GetFileName(_IMSS_TARGET))
                    .Image = My.Resources._IMSS_LockFolder_Icon_16x16
                    .SubItems.Add("Locked").Image = My.Resources._IMSS_Locked_Icon_16x16
                    .SubItems.Add(_IMSS_TARGET)
                End With
            End If
            For i As Integer = 0 To _IMSS_UNLOCKED_LISTVIEW.Items.Count - 1 Step 1
                If _IMSS_UNLOCKED_LISTVIEW.Items(i).SubItems(2).Text = _IMSS_TARGET Then
                    _IMSS_UNLOCKED_LISTVIEW.Items.RemoveAt(i)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub _IMSS_LockWithAccessControl(ByVal _IMSS_TARGET As String)
        Dim fs As FileSystemSecurity = IO.File.GetAccessControl(_IMSS_TARGET)
        fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        IO.File.SetAccessControl(_IMSS_TARGET, fs)
    End Sub
    Public Sub _IMSS_UNLOCKDIR(ByRef _IMSS_TARGET As String)
        Dim d As New IO.DirectoryInfo(_IMSS_TARGET & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")
        IO.File.Delete(_IMSS_TARGET & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\_IMSS_Password.IMSS")
        d.MoveTo(_IMSS_TARGET)
        Try
            If Not _IMSS_CheckIfItemIsAlreadyExsits(IO.Path.GetFileName(_IMSS_TARGET), _IMSS_UNLOCKED_LISTVIEW) = True Then
                With _IMSS_UNLOCKED_LISTVIEW.Groups(0).Items.Add(IO.Path.GetFileName(_IMSS_TARGET))
                    .Image = My.Resources._IMSS_UnLockFolder_Icon_16x16
                    .SubItems.Add("Unlocked").Image = My.Resources._IMSS_UnLocked_Icon_16x16
                    .SubItems.Add(_IMSS_TARGET)
                End With
            End If
            For i As Integer = 0 To _IMSS_LOCKED_LISTVIEW.Items.Count - 1 Step 1
                If _IMSS_LOCKED_LISTVIEW.Items(i).SubItems(2).Text = _IMSS_TARGET Then
                    _IMSS_LOCKED_LISTVIEW.Items.RemoveAt(i)
                End If
            Next
        Catch : End Try
    End Sub
#End Region
#Region "IMSS Files Lock OPER"
    Public Sub _IMSS_LOCKFILE(ByRef _IMSS_TARGET As String)
        Try
            If Not _IMSS_CheckIfItemIsAlreadyExsits(IO.Path.GetFileName(_IMSS_TARGET), _IMSS_LOCKED_LISTVIEW) = True Then
                With _IMSS_LOCKED_LISTVIEW.Groups(0).Items.Add(IO.Path.GetFileName(_IMSS_TARGET))
                    .Image = My.Resources._IMSS_LockedFile_Icon_16x16
                    .SubItems.Add("Locked").Image = My.Resources._IMSS_Locked_Icon_16x16
                    .SubItems.Add(_IMSS_TARGET)
                End With
            End If
            For i As Integer = 0 To _IMSS_UNLOCKED_LISTVIEW.Items.Count - 1 Step 1
                If _IMSS_UNLOCKED_LISTVIEW.Items(i).SubItems(2).Text = _IMSS_TARGET.Substring(0, _IMSS_TARGET.IndexOf(".")).Replace("_", ".") Then
                    _IMSS_UNLOCKED_LISTVIEW.Items.RemoveAt(i)
                End If
            Next
        Catch : End Try
    End Sub
    Public Sub _IMSS_UNLOCKFILE(ByRef _IMSS_TARGET As String)
        Try
            If Not _IMSS_CheckIfItemIsAlreadyExsits(IO.Path.GetFileName(_IMSS_TARGET), _IMSS_UNLOCKED_LISTVIEW) = True Then
                With _IMSS_UNLOCKED_LISTVIEW.Groups(0).Items.Add(IO.Path.GetFileName(_IMSS_TARGET))
                    .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_TARGET).ToBitmap(), 16, 16)
                    .SubItems.Add("Unlocked").Image = My.Resources._IMSS_UnLocked_Icon_16x16
                    .SubItems.Add(_IMSS_TARGET)
                End With
            End If
            For i As Integer = 0 To _IMSS_LOCKED_LISTVIEW.Items.Count - 1 Step 1
                If _IMSS_LOCKED_LISTVIEW.Items(i).SubItems(2).Text = _IMSS_TARGET.Replace(".", "_") & ".encrypt" Then
                    _IMSS_LOCKED_LISTVIEW.Items.RemoveAt(i)
                End If
            Next
        Catch : End Try
    End Sub
#End Region
#Region "IMSS INSTALL ITEMS GROUPS"
    Private Sub _IMSS_SetupGroups()
        _IMSS_LOCKED_LISTVIEW.Groups.Add("Locked items").Image = My.Resources._IMSS_LockedGroups_icon_16x16
        _IMSS_UNLOCKED_LISTVIEW.Groups.Add("Unloced items").Image = My.Resources._IMSS_UnLockedGroups_icon_16x16
        _IMSS_LOCKED_LISTVIEW.ShowGroups = True : _IMSS_UNLOCKED_LISTVIEW.ShowGroups = True
        _IMSS_AddFile.FileName = ""
        _IMSS_AddFile.Title = "Choose a file to encrypt"
        _IMSS_AddFile.InitialDirectory = "C:\"
        _IMSS_AddFile.Filter = "All Files (*.*) | *.*"
    End Sub
#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_SetupGroups()
    End Sub
    Private Sub _IMSS_AddFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AddFolder.Click
        If _IMSS_AddFolders.ShowDialog() = DialogResult.OK Then
            If _IMSS_CheckIfFolderIslocked(_IMSS_AddFolders.SelectedPath) Then
                _IMSS_LOCKED_LISTVIEW.Focus()
                If Not _IMSS_CheckIfItemIsAlreadyExsits(IO.Path.GetFileName(IO.Path.GetFileName(_IMSS_AddFolders.SelectedPath.Substring(0, _IMSS_AddFolders.SelectedPath.IndexOf("{") - 1))), _IMSS_LOCKED_LISTVIEW) = True Then
                    With _IMSS_LOCKED_LISTVIEW.Groups(0).Items.Add(IO.Path.GetFileName(_IMSS_AddFolders.SelectedPath.Substring(0, _IMSS_AddFolders.SelectedPath.IndexOf("{") - 1)))
                        .Image = My.Resources._IMSS_LockFolder_Icon_16x16
                        .SubItems.Add("Locked").Image = My.Resources._IMSS_Locked_Icon_16x16
                        .SubItems.Add(_IMSS_AddFolders.SelectedPath.Substring(0, _IMSS_AddFolders.SelectedPath.IndexOf("{") - 1))
                    End With
                End If : Else
                _IMSS_UNLOCKED_LISTVIEW.Focus()
                If Not _IMSS_CheckIfItemIsAlreadyExsits(IO.Path.GetFileName(_IMSS_AddFolders.SelectedPath), _IMSS_UNLOCKED_LISTVIEW) = True Then
                    With _IMSS_UNLOCKED_LISTVIEW.Groups(0).Items.Add(IO.Path.GetFileName(_IMSS_AddFolders.SelectedPath))
                        .Image = My.Resources._IMSS_UnLockFolder_Icon_16x16
                        .SubItems.Add("Unlocked").Image = My.Resources._IMSS_UnLocked_Icon_16x16
                        .SubItems.Add(_IMSS_AddFolders.SelectedPath)
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub UnlockItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnlockItemToolStripMenuItem.Click
        If Not _IMSS_LOCKED_LISTVIEW.SelectedItems.Count = 0 Then
            Select Case _IMSS_CheckIfIsFileOrDirctory(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text)
                Case "_IMSS_DIRCTORY"
                    If IO.Directory.Exists(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}") Then
                        Dim _IMSS_UnLock As New IMSS_UnLock
                        _IMSS_UnLock._IMSS_TARGET = _IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text
                        _IMSS_UnLock.ShowDialog()
                        Exit Select
                    Else
                        _IMSS_LOCKED_LISTVIEW.SelectedItems(0).Remove()
                    End If
                Case "_IMSS_FILE"
                    If IO.File.Exists(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text) Then
                        Dim _IMSS_FileUnLock As New IMSS_Decrypt
                        _IMSS_FileUnLock._IMSS_TARGET = _IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text
                        _IMSS_FileUnLock.ShowDialog()
                        Exit Select
                    Else
                        _IMSS_LOCKED_LISTVIEW.SelectedItems(0).Remove()
                    End If
            End Select
        End If
    End Sub

    Private Sub RemoveItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveItemsToolStripMenuItem.Click
        If Not _IMSS_LOCKED_LISTVIEW.SelectedItems.Count = 0 Then _IMSS_LOCKED_LISTVIEW.SelectedItems(0).Remove()
    End Sub

    Private Sub AddFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFolderToolStripMenuItem.Click
        _IMSS_AddFolder_Click(Nothing, Nothing)
    End Sub

    Private Sub AddFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFileToolStripMenuItem.Click
        _IMSS_AddFiles_Click(Nothing, Nothing)
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        If Not _IMSS_LOCKED_LISTVIEW.SelectedItems.Count = 0 Then
            Select Case _IMSS_CheckIfIsFileOrDirctory(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text)
                Case "_IMSS_DIRCTORY"
                    If IO.Directory.Exists(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}") Then
                        _IMSS_Properties(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}")
                        Exit Select
                    Else
                        _IMSS_LOCKED_LISTVIEW.SelectedItems(0).Remove()
                        Exit Select
                    End If
                Case "_IMSS_FILE"
                    If IO.File.Exists(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text) Then
                        _IMSS_Properties(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text)
                        Exit Select
                    Else
                        _IMSS_LOCKED_LISTVIEW.SelectedItems(0).Remove()
                        Exit Select
                    End If
            End Select
        End If
    End Sub
    Private Sub _IMSS_Properties(ByRef _IMSS_TARGET As String)
        On Error GoTo _IMSS_ON_ERROR
        Dim sei As New SHELLEXECUTEINFO
        sei.cbSize = Marshal.SizeOf(sei)
        sei.lpVerb = "properties"
        sei.lpFile = _IMSS_TARGET
        sei.nShow = SW_SHOW
        sei.fMask = SEE_MASK_INVOKEIDLIST
        If Not ShellExecuteEx(sei) Then
            Dim ex As New System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error())
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
_IMSS_ON_ERROR:
        ' MessageBox.Show("Pleas select item to show it's propertis !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub _IMSS_LOCK_ContextMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _IMSS_LOCK_ContextMenu.Opening
        If _IMSS_LOCKED_LISTVIEW.SelectedItems.Count = 0 Then
            UnlockItemToolStripMenuItem.Visible = False
            RemoveItemsToolStripMenuItem.Visible = False
            PropertiesToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
            ToolStripSeparator2.Visible = False
        Else
            UnlockItemToolStripMenuItem.Visible = True
            RemoveItemsToolStripMenuItem.Visible = True
            PropertiesToolStripMenuItem.Visible = True
            ToolStripSeparator1.Visible = True
            ToolStripSeparator2.Visible = True
        End If
    End Sub
    Private Function _IMSS_CheckIfIsFileOrDirctory(ByRef _IMSS_TARGET) As String
        If IO.File.Exists(_IMSS_TARGET) Then
            Return "_IMSS_FILE"
        ElseIf IO.Directory.Exists(_IMSS_TARGET) Then
            Return "_IMSS_DIRCTORY"
        Else
            Return "_IMSS_DIRCTORY"
        End If
    End Function
    Private Sub _IMSS_LockItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_LockItem.Click
        If Not _IMSS_UNLOCKED_LISTVIEW.SelectedItems.Count = 0 Then
            Select Case _IMSS_CheckIfIsFileOrDirctory(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text)
                Case "_IMSS_DIRCTORY"
                    If IO.Directory.Exists(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text) Then
                        Dim _IMSS_Lock As New IMSS_Lock
                        _IMSS_Lock._IMSS_TARGET = _IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text
                        _IMSS_Lock.ShowDialog()
                    Else
                        _IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).Remove()
                    End If
                    Exit Select
                Case "_IMSS_FILE"
                    If IO.File.Exists(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text) Then
                        Dim _IMSS_FileLock As New IMSS_Encrypt
                        _IMSS_FileLock._IMSS_TARGET = _IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text
                        _IMSS_FileLock.ShowDialog()
                    Else
                        _IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).Remove()
                    End If
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub _IMSS_UnLockContextMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _IMSS_UnLockContextMenu.Opening
        If _IMSS_UNLOCKED_LISTVIEW.SelectedItems.Count = 0 Then
            _IMSS_LockItem.Visible = False
            _IMSS_RemoveItems.Visible = False
            _IMSS_PropertiesToolStrip.Visible = False
            ToolStripSeparator3.Visible = False
            ToolStripSeparator4.Visible = False
        Else
            _IMSS_LockItem.Visible = True
            _IMSS_RemoveItems.Visible = True
            _IMSS_PropertiesToolStrip.Visible = True
            ToolStripSeparator3.Visible = True
            ToolStripSeparator4.Visible = True
        End If
    End Sub

    Private Sub _IMSS_RemoveItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_RemoveItems.Click
        If Not _IMSS_UNLOCKED_LISTVIEW.SelectedItems.Count = 0 Then _IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).Remove()
    End Sub

    Private Sub _IMSS_AddFolderToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AddFolderToolStrip.Click
        _IMSS_AddFolder_Click(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_AddFileToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AddFileToolStrip.Click
        _IMSS_AddFiles_Click(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_PropertiesToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_PropertiesToolStrip.Click
        If Not _IMSS_UNLOCKED_LISTVIEW.SelectedItems.Count = 0 Then
            Select Case _IMSS_CheckIfIsFileOrDirctory(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text)
                Case "_IMSS_DIRCTORY"
                    If IO.Directory.Exists(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text) Then
                        _IMSS_Properties(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text)
                        Exit Select
                    Else
                        _IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).Remove()
                        Exit Select
                    End If
                Case "_IMSS_FILE"
                    If IO.File.Exists(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text) Then
                        _IMSS_Properties(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text)
                        Exit Select
                    Else
                        _IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).Remove()
                        Exit Select
                    End If
            End Select
        End If
    End Sub

    Private Sub _IMSS_LOCKED_LISTVIEW_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_LOCKED_LISTVIEW.DoubleClick
        If Not _IMSS_LOCKED_LISTVIEW.SelectedItems.Count = 0 Then
            UnlockItemToolStripMenuItem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub _IMSS_UNLOCKED_LISTVIEW_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_UNLOCKED_LISTVIEW.DoubleClick
        If Not _IMSS_UNLOCKED_LISTVIEW.SelectedItems.Count = 0 Then
            _IMSS_LockItem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub _IMSS_UNLOCKED_LISTVIEW_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _IMSS_UNLOCKED_LISTVIEW.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not _IMSS_UNLOCKED_LISTVIEW.SelectedItems.Count = 0 Then
                _IMSS_LockItem_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub _IMSS_LOCKED_LISTVIEW_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _IMSS_LOCKED_LISTVIEW.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not _IMSS_LOCKED_LISTVIEW.SelectedItems.Count = 0 Then
             UnlockItemToolStripMenuItem_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub _IMSS_AddFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AddFiles.Click
        If _IMSS_AddFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If IO.Path.GetExtension(_IMSS_AddFile.FileName) = ".encrypt" Then
                _IMSS_LOCKED_LISTVIEW.Focus()
                If Not _IMSS_CheckIfItemIsAlreadyExsits(IO.Path.GetFileName(_IMSS_AddFile.FileName), _IMSS_LOCKED_LISTVIEW) = True Then
                    With _IMSS_LOCKED_LISTVIEW.Groups(0).Items.Add(IO.Path.GetFileName(_IMSS_AddFile.FileName))
                        .Image = My.Resources._IMSS_LockedFile_Icon_16x16
                        .SubItems.Add("Locked").Image = My.Resources._IMSS_Locked_Icon_16x16
                        .SubItems.Add(_IMSS_AddFile.FileName)
                    End With
                End If
            Else
                _IMSS_UNLOCKED_LISTVIEW.Focus()
                If Not _IMSS_CheckIfItemIsAlreadyExsits(IO.Path.GetFileName(_IMSS_AddFile.FileName), _IMSS_UNLOCKED_LISTVIEW) = True Then
                    With _IMSS_UNLOCKED_LISTVIEW.Groups(0).Items.Add(IO.Path.GetFileName(_IMSS_AddFile.FileName))
                        .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_AddFile.FileName).ToBitmap(), 16, 16)
                        .SubItems.Add("Unlocked").Image = My.Resources._IMSS_UnLocked_Icon_16x16
                        .SubItems.Add(_IMSS_AddFile.FileName)
                    End With
                End If
            End If
        End If
    End Sub

    Private Sub ClearListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearListToolStripMenuItem.Click
        _IMSS_UNLOCKED_LISTVIEW.Items.Clear()
    End Sub

    Private Sub ClearListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearListToolStripMenuItem1.Click
        _IMSS_LOCKED_LISTVIEW.Items.Clear()
    End Sub

    Private Sub OpenLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLocationToolStripMenuItem.Click
        Try
            If IO.File.Exists(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text) Or IO.Directory.Exists(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text) Then
                Process.Start(IO.Path.GetDirectoryName(_IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text))
            Else
                _IMSS_UNLOCKED_LISTVIEW.SelectedItems(0).Remove()
            End If
        Catch : End Try
    End Sub

    Private Sub OpenLocationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLocationToolStripMenuItem1.Click
        Try
            If IO.File.Exists(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text) Or IO.Directory.Exists(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}") Then
                Process.Start(IO.Path.GetDirectoryName(_IMSS_LOCKED_LISTVIEW.SelectedItems(0).SubItems(2).Text))
            Else
                _IMSS_LOCKED_LISTVIEW.SelectedItems(0).Remove()
            End If
        Catch : End Try
    End Sub

End Class
