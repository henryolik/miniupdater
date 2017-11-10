﻿Imports System.Net
Imports System.IO

Public Class updater
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Contains("-elder") = True Then
            elder()
        End If
        If My.Application.CommandLineArgs.Contains("-launcher") = True Then
            launcher()
        End If
        If My.Application.CommandLineArgs.Contains("-mhd") = True Then
            mhd()
        End If
        If My.Application.CommandLineArgs.Contains("-antiezo") = True Then
            antiezo()
        End If
        If My.Application.CommandLineArgs.Contains("-fdc") = True Then
            fdc()
        End If
        If My.Application.CommandLineArgs.Contains("-elder") = False And My.Application.CommandLineArgs.Contains("-launcher") = False And My.Application.CommandLineArgs.Contains("-mhd") = False And My.Application.CommandLineArgs.Contains("-antiezo") = False And My.Application.CommandLineArgs.Contains("-fdc") = False Then
            MsgBox("Nebyl zadán nebo rozpoznán žádný argument.", MsgBoxStyle.Critical, "Chyba")
            Application.Exit()
        End If
    End Sub

    Public Sub launcher()
        Dim wc As WebClient = New WebClient()
        If Application.ExecutablePath.Contains("Program Files") Then
            wc.DownloadFile("https://dl.ministudios.ml/mini/launcher/updater.exe", "migrate.exe")
            Process.Start(Application.StartupPath & "/migrate.exe")
            Me.Close()
        End If
        Do Until FileInUse(Application.StartupPath & "/launcher.exe") = False
            Snooze(1)
        Loop
        Me.Show()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 1
        Try
            wc.DownloadFile("https://dl.ministudios.ml/mini/launcher/files/launcher.exe", Application.StartupPath & "\launcher.exe")
            ProgressBar1.Value = 10
            wc.DownloadFile("https://dl.ministudios.ml/mini/launcher/files/mini.exe", Application.StartupPath & "\mini.exe")
            ProgressBar1.Value = 20
            wc.DownloadFile("https://dl.ministudios.ml/mini/launcher/files/mini2.exe", Application.StartupPath & "\mini2.exe")
            ProgressBar1.Value = 30
            wc.DownloadFile("https://dl.ministudios.ml/mini/launcher/files/icon.ico", Application.StartupPath & "\icon.ico")
            ProgressBar1.Value = 35
        Catch ex As Exception
            MsgBox("Aktualizace se nezdařila! Chyba: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "/7z") Then
            System.IO.Directory.Delete(Application.StartupPath & "/7z", True)
            ProgressBar1.Value = 40
        Else
            ProgressBar1.Value = 40
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/7za.exe") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/7za.exe")
            ProgressBar1.Value = 50
        Else
            ProgressBar1.Value = 50
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/7za.dll") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/7za.dll")
            ProgressBar1.Value = 60
        Else
            ProgressBar1.Value = 60
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/7zxa.dll") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/7zxa.dll")
            ProgressBar1.Value = 70
        Else
            ProgressBar1.Value = 70
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/update.bat") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/update.bat")
            ProgressBar1.Value = 80
        Else
            ProgressBar1.Value = 80
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/mini.zip") Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/mini.zip")
            ProgressBar1.Value = 90
        Else
            ProgressBar1.Value = 90
        End If
        ProgressBar1.Value = 100
        Process.Start(Application.StartupPath & "\launcher.exe")
        Me.Close()
    End Sub

    Public Sub elder()
        Dim wc As WebClient = New WebClient()
        If Application.ExecutablePath.Contains("Program Files") Then
            wc.DownloadFile("http://nonssl.dl.ministudios.ml/mini/elder/updater.exe", Application.StartupPath & "/migrate.exe")
            Process.Start(Application.StartupPath & "/migrate.exe")
            Me.Close()
        End If
        Do Until FileInUse(Application.StartupPath & "/launcher.exe") = False
            Snooze(1)
        Loop
        Me.Show()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        Try
            ProgressBar1.Value = 1
            wc.DownloadFile("http://nonssl.dl.ministudios.ml/mini/elder/files/launcher.exe", Application.StartupPath & "\launcher.exe")
            ProgressBar1.Value = 20
            wc.DownloadFile("http://nonssl.dl.ministudios.ml/mini/elder/files/mini.exe", Application.StartupPath & "\mini.exe")
            ProgressBar1.Value = 40
            wc.DownloadFile("http://nonssl.dl.ministudios.ml/mini/elder/files/mini2.exe", Application.StartupPath & "\mini2.exe")
            ProgressBar1.Value = 60
            wc.DownloadFile("http://nonssl.dl.ministudios.ml/mini/elder/files/icon.ico", Application.StartupPath & "\icon.ico")
            ProgressBar1.Value = 80
        Catch ex As Exception
            MsgBox("Aktualizace se nezdařila! Chyba: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        ProgressBar1.Value = 100
        Process.Start(Application.StartupPath & "\launcher.exe")
        Me.Close()
    End Sub

    Public Sub mhd()
        Me.Show()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        Dim wc As WebClient = New WebClient()
        Try
            ProgressBar1.Value = 1
            wc.DownloadFile("https://dl.ministudios.ml/mhd/mhd.exe", Application.StartupPath & "/mhd.exe")
        Catch ex As Exception
            MsgBox("Aktualizace se nezdařila! Chyba: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        ProgressBar1.Value = 100
        Process.Start(Application.StartupPath & "/mhd.exe")
        Me.Close()
    End Sub

    Public Sub fdc()
        Me.Show()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        Dim wc As WebClient = New WebClient()
        Try
            ProgressBar1.Value = 1
            wc.DownloadFile("https://dl.ministudios.ml/fdc/fdc.exe", Application.StartupPath & "/fdc.exe")
        Catch ex As Exception
            MsgBox("Update was not intstalled! Error: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        ProgressBar1.Value = 100
        Process.Start(Application.StartupPath & "/fdc.exe")
        Me.Close()
    End Sub

    Public Sub antiezo()
        Me.Show()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        Dim wc As WebClient = New WebClient()
        Try
            ProgressBar1.Value = 1
            wc.DownloadFile("https://dl.ministudios.ml/antiezo/files/antiezo.exe", Application.StartupPath & "/antiezo.exe")
            ProgressBar1.Value = 50
            wc.DownloadFile("https://dl.ministudios.ml/antiezo/files/tov.bat", Application.StartupPath & "/tov.bat")
        Catch ex As Exception
            MsgBox("Aktualizace se nezdařila! Chyba: " & ex.ToString, MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End Try
        ProgressBar1.Value = 100
        Process.Start(Application.StartupPath & "/antiezo.exe")
        Me.Close()
    End Sub

    Public Function Internet() As Boolean
        Dim objUrl As New System.Uri("https://dl.ministudios.ml/status.txt")
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            objWebReq = Nothing
            Return False
        End Try
    End Function

    Private Sub Snooze(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Public Function FileInUse(ByVal sFile As String) As Boolean
        Dim thisFileInUse As Boolean = False
        If System.IO.File.Exists(sFile) Then
            Try
                Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                    ' thisFileInUse = False
                End Using
            Catch
                thisFileInUse = True
            End Try
        End If
        Return thisFileInUse
    End Function
End Class

