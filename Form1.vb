Imports System.IO
Imports System

Public Class Form1
    Dim appPath As String = IO.Path.Combine(Application.StartupPath, "") 'Pobiera ścieżke aplikacji do stringa

    Private Sub Open_Click(sender As Object, e As EventArgs) Handles Open.Click

        If Disks.Text.Length = 0 Then
            MsgBox("Please select disk drive first !!!")
        Else
            Process.Start(Mid(Disks.Text, 1, 3)) ' -> Pobiera 3 pierwsze znaki z pola disks i otwiera folder
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log1.AppendText(Me.Text)
        Log1.AppendText(Environment.NewLine + "")
        vOS.SelectedItem = "6.60"
    End Sub

    Private Sub vOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vOS.SelectedIndexChanged
        If vOS.SelectedItem = "6.60" Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
        If vOS.SelectedItem = "6.61" Then
            GroupBox3.Visible = True
        Else
            GroupBox3.Visible = False
        End If
    End Sub

    Private Sub Disks_DropDown(sender As Object, e As EventArgs) Handles Disks.DropDown
        Disks.Items.Clear()

        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives()

            ' Detection drive type
            Dim drive_type As String = ""
            If drive.DriveType = DriveType.Fixed Then
                drive_type = "Local Disk"
            ElseIf drive.DriveType = DriveType.CDRom Then
                drive_type = "CD-Rom drive"
            ElseIf drive.DriveType = DriveType.Network Then
                drive_type = "Network drive"
            ElseIf drive.DriveType = DriveType.Removable Then
                drive_type = "Removable Disk"
            ElseIf drive.DriveType = DriveType.Unknown Then
                drive_type = "Unknown"
            End If

            ' The drive name and its type is added to the list of drives
            Me.Disks.Items.Add(drive.Name & " [" & drive_type & "]")
        Next

        ' It selects the first item in the list (ComboBox)
        ' Disks.SelectedIndex = 0
    End Sub

    Private Sub OFW_Click(sender As Object, e As EventArgs) Handles OFW.Click

        If Disks.Text.Length = 0 Then
            MsgBox("Please select disk drive first !!!")
            Exit Sub
        Else
            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP") Then
            Else
                Log1.Clear()
                Log1.AppendText(Me.Text)
                Log1.AppendText(Environment.NewLine + "")
                Log1.AppendText(Environment.NewLine + "Creating basic directories...")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty

                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME") Then
            Else
                Log1.Clear()
                Log1.AppendText(Me.Text)
                Log1.AppendText(Environment.NewLine + "")
                Log1.AppendText(Environment.NewLine + "Creating directories: GAME\UPDATE..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE") Then
            Else
                Log1.Clear()
                Log1.AppendText(Me.Text)
                Log1.AppendText(Environment.NewLine + "")
                Log1.AppendText(Environment.NewLine + "Creating directories: GAME\UPDATE..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If
        End If

        If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP") = True Then

            Log1.AppendText(Environment.NewLine + "Deleting old file..")
            System.IO.File.Delete(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP")
            If R4.Checked Then
                Log1.AppendText(Environment.NewLine + "Copying the OFW 6.60 file for PSP Go to SD..")
                System.IO.File.Copy(appPath & "\PSP\GAME\Go\6.60\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.AppendText(Environment.NewLine + "Done.")
                    Log1.AppendText(Environment.NewLine + "")
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty

                End If
            Else
                Log1.AppendText(Environment.NewLine + "Copying the OFW 6.60 file to SD..")
                System.IO.File.Copy(appPath & "\PSP\GAME\UPDATE\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.AppendText(Environment.NewLine + "Done.")
                    Log1.AppendText(Environment.NewLine + "")
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty

                End If
            End If
        Else
            If R4.Checked Then
                Log1.AppendText(Environment.NewLine + "Copying the OFW 6.60 file for PSP Go to SD..")
                System.IO.File.Copy(appPath & "\PSP\GAME\Go\6.60\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.AppendText(Environment.NewLine + "Done.")
                    Log1.AppendText(Environment.NewLine + "")
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty

                End If
            Else
                Log1.AppendText(Environment.NewLine + "Copying the OFW 6.60 file to SD..")
                System.IO.File.Copy(appPath & "\PSP\GAME\UPDATE\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.AppendText(Environment.NewLine + "Done.")
                    Log1.AppendText(Environment.NewLine + "")
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty

                End If
            End If
        End If
    End Sub

    Private Sub Disks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Disks.SelectedIndexChanged
        Log1.AppendText(Environment.NewLine + "Selected disk " & Mid(Disks.Text, 1, 2))
    End Sub

    Private Sub CFW_Click(sender As Object, e As EventArgs) Handles CFW.Click
        If Disks.Text.Length = 0 Then
            MsgBox("Please select disk drive first !!!")
            Exit Sub
        Else
            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP") Then
            Else
                Log1.Clear()
                Log1.AppendText(Me.Text)
                Log1.AppendText(Environment.NewLine + "")
                Log1.AppendText(Environment.NewLine + "Creating basic directories..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "ISO")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "seplugins")

                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty

                End If
            End If

            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME") Then
            Else
                Log1.AppendText(Environment.NewLine + "Creating directories: GAME\PROUPDATE")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE") Then
            Else
                Log1.AppendText(Environment.NewLine + "Creating directories: GAME\PROUPDATE..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "Seplugins") Then
            Else
                Log1.AppendText(Environment.NewLine + "Creating directories: Seplugins..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "Seplugins")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "Seplugins") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "ISO") Then
            Else
                Log1.AppendText(Environment.NewLine + "Creating directories: ISO..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "ISO")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "ISO") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If
        End If
        If R1.Checked = True Then
            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher") Then
            Else
                Log1.AppendText(Environment.NewLine + "Creating directory: CIPL_Flasher..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP") = True Then
                Log1.AppendText(Environment.NewLine + "The PROUPDATE file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the PROUPDATE file..")
                System.IO.File.Copy(appPath & "\PSP\GAME\PROUPDATE\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher\EBOOT.PBP") = True Then
                Log1.AppendText(Environment.NewLine + "The CIPL_Flasher file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the CIPL_Flasher file..")
                System.IO.File.Copy(appPath & "\PSP\GAME\CIPL_Flasher\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "seplugins\localizer.dat") = True Then
                Log1.AppendText(Environment.NewLine + "The localizer.dat file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the localizer.dat file..")
                System.IO.File.Copy(appPath & "\Seplugins\localizer.dat", Mid(Disks.Text, 1, 3) & "Seplugins\localizer.dat")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "Seplugins\localizer.dat") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx") = True Then
                Log1.AppendText(Environment.NewLine + "The localizer.prx file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the localizer.prx file..")
                System.IO.File.Copy(appPath & "\seplugins\localizer.prx", Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt") = True Then
                Log1.AppendText(Environment.NewLine + "The vsh.txt file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the vsh.txt file..")
                System.IO.File.Copy(appPath & "\seplugins\vsh.txt", Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If
            Log1.AppendText(Environment.NewLine + "")
            Log1.AppendText(Environment.NewLine + "Done.")
            Log1.AppendText(Environment.NewLine + "")
        End If

        If R2.Checked = True Then
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery") Then
                Else
                    Log1.AppendText(Environment.NewLine + "Creating directory: FastRecovery..")
                    System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery")
                    If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery") Then
                        Log1.SelectionColor = Color.ForestGreen
                        Log1.AppendText("OK")
                        Log1.SelectionColor = Color.Empty
                    Else
                        Log1.SelectionColor = Color.Red
                        Log1.AppendText("FAIL")
                        Log1.SelectionColor = Color.Empty
                    End If
                End If

                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher") Then
                Else
                    Log1.AppendText(Environment.NewLine + "Creating directory: CIPL_Flasher..")
                    System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher")
                    If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher") Then
                        Log1.SelectionColor = Color.ForestGreen
                        Log1.AppendText("OK")
                        Log1.SelectionColor = Color.Empty
                    Else
                        Log1.SelectionColor = Color.Red
                        Log1.AppendText("FAIL")
                        Log1.SelectionColor = Color.Empty
                    End If
                End If

                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP") = True Then
                    Log1.AppendText(Environment.NewLine + "The PROUPDATE file already exists")
                Else
                    Log1.AppendText(Environment.NewLine + "Copying the PROUPDATE file..")
                    System.IO.File.Copy(appPath & "\PSP\GAME\PROUPDATE\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP")
                    If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP") = True Then
                        Log1.SelectionColor = Color.ForestGreen
                        Log1.AppendText("OK")
                        Log1.SelectionColor = Color.Empty
                    Else
                        Log1.SelectionColor = Color.Red
                        Log1.AppendText("FAIL")
                        Log1.SelectionColor = Color.Empty
                    End If
                End If

                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery\EBOOT.PBP") = True Then
                    Log1.AppendText(Environment.NewLine + "The FastRecovery file already exists")
                Else
                    Log1.AppendText(Environment.NewLine + "Copying the FastRecovery file..")
                    System.IO.File.Copy(appPath & "\PSP\GAME\FastRecovery\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery\EBOOT.PBP")
                    If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery\EBOOT.PBP") = True Then
                        Log1.SelectionColor = Color.ForestGreen
                        Log1.AppendText("OK")
                        Log1.SelectionColor = Color.Empty
                    Else
                        Log1.SelectionColor = Color.Red
                        Log1.AppendText("FAIL")
                        Log1.SelectionColor = Color.Empty
                    End If
                End If

                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher\EBOOT.PBP") = True Then
                    Log1.AppendText(Environment.NewLine + "The CIPL_Flasher file already exists")
                Else
                    Log1.AppendText(Environment.NewLine + "Copying the CIPL_Flasher file..")
                    System.IO.File.Copy(appPath & "\PSP\GAME\CIPL_Flasher\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher\EBOOT.PBP")
                    If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\CIPL_Flasher\EBOOT.PBP") = True Then
                        Log1.SelectionColor = Color.ForestGreen
                        Log1.AppendText("OK")
                        Log1.SelectionColor = Color.Empty
                    Else
                        Log1.SelectionColor = Color.Red
                        Log1.AppendText("FAIL")
                        Log1.SelectionColor = Color.Empty
                    End If
                End If

                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "seplugins\localizer.dat") = True Then
                    Log1.AppendText(Environment.NewLine + "The localizer.dat file already exists")
                Else
                    Log1.AppendText(Environment.NewLine + "Copying the localizer.dat file..")
                    System.IO.File.Copy(appPath & "\Seplugins\localizer.dat", Mid(Disks.Text, 1, 3) & "Seplugins\localizer.dat")
                    If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "Seplugins\localizer.dat") = True Then
                        Log1.SelectionColor = Color.ForestGreen
                        Log1.AppendText("OK")
                        Log1.SelectionColor = Color.Empty
                    Else
                        Log1.SelectionColor = Color.Red
                        Log1.AppendText("FAIL")
                        Log1.SelectionColor = Color.Empty
                    End If
                End If

                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx") = True Then
                    Log1.AppendText(Environment.NewLine + "The localizer.prx file already exists")
                Else
                    Log1.AppendText(Environment.NewLine + "Copying the localizer.prx file..")
                    System.IO.File.Copy(appPath & "\seplugins\localizer.prx", Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx")
                    If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx") = True Then
                        Log1.SelectionColor = Color.ForestGreen
                        Log1.AppendText("OK")
                        Log1.SelectionColor = Color.Empty
                    Else
                        Log1.SelectionColor = Color.Red
                        Log1.AppendText("FAIL")
                        Log1.SelectionColor = Color.Empty
                    End If
                End If

                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt") = True Then
                    Log1.AppendText(Environment.NewLine + "The vsh.txt file already exists")
                Else
                    Log1.AppendText(Environment.NewLine + "Copying the vsh.txt file..")
                    System.IO.File.Copy(appPath & "\seplugins\vsh.txt", Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt")
                    If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt") = True Then
                        Log1.SelectionColor = Color.ForestGreen
                        Log1.AppendText("OK")
                        Log1.SelectionColor = Color.Empty
                    Else
                        Log1.SelectionColor = Color.Red
                        Log1.AppendText("FAIL")
                        Log1.SelectionColor = Color.Empty
                    End If
                End If
                Log1.AppendText(Environment.NewLine + "")
                Log1.AppendText(Environment.NewLine + "Done.")
                Log1.AppendText(Environment.NewLine + "")
            End If

        'PSP 3000 / Street
        If R3.Checked = True Then
            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery") Then
            Else
                Log1.AppendText(Environment.NewLine + "Creating directory: FastRecovery..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP") = True Then
                Log1.AppendText(Environment.NewLine + "The PROUPDATE file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the PROUPDATE file..")
                System.IO.File.Copy(appPath & "\PSP\GAME\PROUPDATE\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery\EBOOT.PBP") = True Then
                Log1.AppendText(Environment.NewLine + "The FastRecovery file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the FastRecovery file..")
                System.IO.File.Copy(appPath & "\PSP\GAME\FastRecovery\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "seplugins\localizer.dat") = True Then
                Log1.AppendText(Environment.NewLine + "The localizer.dat file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the localizer.dat file..")
                System.IO.File.Copy(appPath & "\Seplugins\localizer.dat", Mid(Disks.Text, 1, 3) & "Seplugins\localizer.dat")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "Seplugins\localizer.dat") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx") = True Then
                Log1.AppendText(Environment.NewLine + "The localizer.prx file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the localizer.prx file..")
                System.IO.File.Copy(appPath & "\seplugins\localizer.prx", Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt") = True Then
                Log1.AppendText(Environment.NewLine + "The vsh.txt file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the vsh.txt file..")
                System.IO.File.Copy(appPath & "\seplugins\vsh.txt", Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If
            Log1.AppendText(Environment.NewLine + "")
            Log1.SelectionColor = Color.ForestGreen
            Log1.AppendText(Environment.NewLine + "Done.")
            Log1.SelectionColor = Color.Empty
            Log1.AppendText(Environment.NewLine + "")
        End If

        'PSP Go
        If R4.Checked = True Then
            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery") Then
            Else
                Log1.AppendText(Environment.NewLine + "Creating directory: FastRecovery..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP") = True Then
                Log1.AppendText(Environment.NewLine + "The PROUPDATE file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the PROUPDATE file..")
                System.IO.File.Copy(appPath & "\PSP\GAME\PROUPDATE\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\PROUPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery\EBOOT.PBP") = True Then
                Log1.AppendText(Environment.NewLine + "The FastRecovery file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the FastRecovery file..")
                System.IO.File.Copy(appPath & "\PSP\GAME\FastRecovery\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\FastRecovery\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "seplugins\localizer.dat") = True Then
                Log1.AppendText(Environment.NewLine + "The localizer.dat file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the localizer.dat file..")
                System.IO.File.Copy(appPath & "\PSP\GAME\Go\seplugins\localizer.dat", Mid(Disks.Text, 1, 3) & "Seplugins\localizer.dat")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "Seplugins\localizer.dat") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx") = True Then
                Log1.AppendText(Environment.NewLine + "The localizer.prx file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the localizer.prx file..")
                System.IO.File.Copy(appPath & "\PSP\GAME\Go\seplugins\localizer.prx", Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\localizer.prx") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt") = True Then
                Log1.AppendText(Environment.NewLine + "The vsh.txt file already exists")
            Else
                Log1.AppendText(Environment.NewLine + "Copying the vsh.txt file..")
                System.IO.File.Copy(appPath & "\PSP\GAME\Go\seplugins\vsh.txt", Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "\seplugins\vsh.txt") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If
            Log1.AppendText(Environment.NewLine + "")
            Log1.SelectionColor = Color.ForestGreen
            Log1.AppendText(Environment.NewLine + "Done.")
            Log1.SelectionColor = Color.Empty
            Log1.AppendText(Environment.NewLine + "")
        End If

    End Sub

    Private Sub R1_CheckedChanged(sender As Object, e As EventArgs) Handles R1.CheckedChanged
        If R1.Checked = True Then
            Log1.AppendText(Environment.NewLine + "Selected model 100x")
        End If
    End Sub

    Private Sub R2_CheckedChanged(sender As Object, e As EventArgs) Handles R2.CheckedChanged
        If R2.Checked = True Then
            Log1.AppendText(Environment.NewLine + "Selected model 200x")
        End If
    End Sub

    Private Sub R3_CheckedChanged(sender As Object, e As EventArgs) Handles R3.CheckedChanged
        If R3.Checked = True Then
            Log1.AppendText(Environment.NewLine + "Selected model 300x / Street")
        End If
    End Sub

    Private Sub Log1_DoubleClick(sender As Object, e As EventArgs) Handles Log1.DoubleClick
        Log1.Clear()
        Log1.AppendText(Me.Text)
        Log1.AppendText(Environment.NewLine + "")
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub OFW_61_Click(sender As Object, e As EventArgs) Handles OFW_61.Click
        If Disks.Text.Length = 0 Then
            MsgBox("Please select disk drive first !!!")
            Exit Sub
        Else
            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP") Then
            Else
                Log1.Clear()
                Log1.AppendText(Me.Text)
                Log1.AppendText(Environment.NewLine + "")
                Log1.AppendText(Environment.NewLine + "Creating basic directories...")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME") Then
            Else
                Log1.Clear()
                Log1.AppendText(Me.Text)
                Log1.AppendText(Environment.NewLine + "")
                Log1.AppendText(Environment.NewLine + "Creating directories: GAME\UPDATE..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If

            If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE") Then
            Else
                Log1.Clear()
                Log1.AppendText(Me.Text)
                Log1.AppendText(Environment.NewLine + "")
                Log1.AppendText(Environment.NewLine + "Creating directories: GAME\UPDATE..")
                System.IO.Directory.CreateDirectory(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE")
                If System.IO.Directory.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE") Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.SelectionColor = Color.Empty
                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            End If
        End If

        If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP") = True Then

            Log1.AppendText(Environment.NewLine + "Deleting old file..")
            System.IO.File.Delete(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP")
            If R4.Checked = True Then
                Log1.AppendText(Environment.NewLine + "Copying the OFW 6.61 file for PSP Go to SD..")
                System.IO.File.Copy(appPath & "\PSP\GAME\Go\6.61\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.AppendText(Environment.NewLine + "Done.")
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.SelectionColor = Color.Empty

                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            Else
                Log1.AppendText(Environment.NewLine + "Copying the OFW 6.61 file to SD..")
                System.IO.File.Copy(appPath & "\PSP\GAME\UPDATE_661\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.AppendText(Environment.NewLine + "Done.")
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.SelectionColor = Color.Empty

                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty

                End If
            End If
        Else
            If R4.Checked = True Then
                Log1.AppendText(Environment.NewLine + "Copying the OFW 6.61 file for PSP Go to SD..")
                System.IO.File.Copy(appPath & "\PSP\GAME\Go\6.61\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.AppendText(Environment.NewLine + "Done.")
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.SelectionColor = Color.Empty

                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty
                End If
            Else
                Log1.AppendText(Environment.NewLine + "Copying the OFW 6.61 file to SD..")
                System.IO.File.Copy(appPath & "\PSP\GAME\UPDATE_661\EBOOT.PBP", Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP")
                If System.IO.File.Exists(Mid(Disks.Text, 1, 3) & "PSP\GAME\UPDATE\EBOOT.PBP") = True Then
                    Log1.SelectionColor = Color.ForestGreen
                    Log1.AppendText("OK")
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.AppendText(Environment.NewLine + "Done.")
                    Log1.AppendText(Environment.NewLine + "")
                    Log1.SelectionColor = Color.Empty

                Else
                    Log1.SelectionColor = Color.Red
                    Log1.AppendText("FAIL")
                    Log1.SelectionColor = Color.Empty

                End If
            End If
        End If
    End Sub

    Private Sub R4_CheckedChanged(sender As Object, e As EventArgs) Handles R4.CheckedChanged
        If R4.Checked = True Then
            Log1.AppendText(Environment.NewLine + "Selected model Go [ N100x ]")
        End If
    End Sub
End Class
