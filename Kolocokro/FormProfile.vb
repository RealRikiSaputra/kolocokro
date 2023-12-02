Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports OpenQA.Selenium.Chrome
Imports SeleniumUndetectedChromeDriver

Public Class FormProfile

    Dim document As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bwAddProfile.WorkerSupportsCancellation = True
        showProfile()
    End Sub

    Private Sub btnBackProfile_Click(sender As Object, e As EventArgs) Handles btnBackProfile.Click
        Dim form1 As FormMenu = DirectCast(Application.OpenForms("FormMenu"), FormMenu)
        form1.Show()
        Close()
    End Sub

    Private Sub btnProfileCopyClip_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub addTask_Click(sender As Object, e As EventArgs) Handles addTask.Click

    End Sub

    Private Sub btnAddProfile_Click(sender As Object, e As EventArgs) Handles btnAddProfile.Click
        If btnAddProfile.Text = "Add Profile" Then

            If tbNameProfile.Text = "" Then
                MsgBox("Nama Profile Tidak Boleh Kosong")
                Exit Sub
            End If

            Dim path = document + "\Kolocokro\Profile\" + tbNameProfile.Text ' Kumpulan Profile Combobox Disave Disini

            If My.Computer.FileSystem.DirectoryExists(path) Then
                MsgBox("Nama Profile Sudah Ada")
                Exit Sub
            End If
            btnAddProfile.Text = "Close Profile"
            bwAddProfile.RunWorkerAsync(argument:=path) ' agar mengakses function dibackground worker | kesalahan sebelumnya adalah (argument:=TempatProfileDokumen) Akibatnya Profile yg Baru di input Tidak Membuat Directory baru dan Seluruh  File Dari Profile Baru berada di dalam Profile Dokumen, tanpa Membuat directory baru untuk Profilenya
            'ElseIf btnAddProfile.Text = "Close Profile" Then
            '    btnAddProfile.Text = "Wait For Profile"
        End If
    End Sub

    Private Sub bwAddProfile_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwAddProfile.DoWork
        Dim path = e.Argument 'deklarasi argument (Run Worker Async)

        Dim driver As UndetectedChromeDriver
        Dim options = New ChromeOptions

        options.AddArgument("--user-data-dir=" + path)
        MsgBox("Cek Dokumen")
        driver = UndetectedChromeDriver.Create(hideCommandPromptWindow:=True, browserExecutablePath:="C:\Program Files\Google\Chrome\Application\chrome.exe", driverExecutablePath:=document + "\Kolocokro\Driver\chromedriver.exe", options:=options)
        driver.GoToUrl("https://google.com")
        'For i = 0 To 10
        '    Threading.Thread.Sleep(1000)

        '    i = 0
        '    Dim tombol = ""
        '    btnAddProfile.Invoke(Sub() tombol = btnAddProfile.Text)

        '    If tombol = "Wait For Profile" Then
        '        Exit For
        '    End If

        'Next
        'Try

        'driver.Close()
        driver.Quit()
        'Catch ex As Exception

        'End Try
        'Try
        '    driver.Quit()
        'Catch ex As Exception

        'End Try
        showProfile() 'Function untuk  Menampilkan Seluruh Profile Yang Sudah Dibuat
        btnAddProfile.Invoke(Sub() btnAddProfile.Text = "Add Profile")
    End Sub

    Function showProfile()
        Dim path = document + "\Kolocokro\Profile\"
        ' Menampilkan Seluruh Profile Di Textbox
        Dim profile = My.Computer.FileSystem.GetDirectories(path) ' proses Scan Directories

        tbDaftarProfile.Invoke(Sub() tbDaftarProfile.Clear()) ' Mengganti ComboBox1.Items.Clear() menjadi tbNameProfile.Clear()
        For Each ProfileDokumen In profile
            Dim nombresdeperfil = Split(ProfileDokumen, "\").Last ' Menampilkan Direktori Folder terakhir
            tbDaftarProfile.Invoke(Sub() tbDaftarProfile.AppendText(nombresdeperfil & Environment.NewLine)) ' Mengganti ComboBox1.Invoke(...) menjadi tbNameProfile.AppendText(...)
        Next
    End Function

End Class