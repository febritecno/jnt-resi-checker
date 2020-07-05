Imports System
Imports System.IO
Imports PuppeteerSharp
Imports System.Text.RegularExpressions

Public Class Main

    Public resi() As String
    Public resipath As String
    Public headless As Boolean

    Public Async Function GetResi(resi) As Task
        Timer1.Start()

        ProgressBar1.Increment(20)

        Try
            Dim url = "https://ipsaya.com/cek-resi.php"

            Await New BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision)

            Dim b = Await Puppeteer.LaunchAsync(New LaunchOptions With {
                .Headless = headless,
                .Devtools = False,
                .Args = {"--no-sandbox --disable-notifications --window-size=500,500"}
            })


            ProgressBar1.Increment(20)

            Label1.Text = "[X] Tunggu Sebentar, masih memuat situs ..."

            Dim p = Await b.NewPageAsync()
            Await p.Client.SendAsync("Emulation.clearDeviceMetricsOverride")
            Await p.GoToAsync(url)
            Await p.ClickAsync("input#noresi")
            Await p.Keyboard.TypeAsync(resi)
            Await p.SelectAsync("select#namakurir", "jnt")
            Await p.ClickAsync("input#btn")
            Await p.WaitForSelectorAsync(".tab-content")

            ProgressBar1.Increment(20)

            Label1.Text = "[X] Menyiapkan dan mengisi data ..."

            Dim tgl_awal = Await p.EvaluateFunctionAsync(Of String)("()=>document.querySelector('#riwayat > table > tbody > tr:last-child > td:nth-child(1) > span').textContent")
            Dim kota_awal = Await p.EvaluateFunctionAsync(Of String)("()=>document.querySelector('#riwayat > table > tbody > tr:last-child > td:nth-child(3) > span').textContent")
            Dim tgl_update = Await p.EvaluateFunctionAsync(Of String)("()=>document.querySelector('#riwayat > table > tbody > tr:nth-child(1) > td:nth-child(1) > span').textContent")
            Dim kota_update = Await p.EvaluateFunctionAsync(Of String)("()=>document.querySelector('#riwayat > table > tbody > tr:nth-child(1) > td:nth-child(3) > span').textContent")
            Dim status_update = Await p.EvaluateFunctionAsync(Of String)("()=>document.querySelector('#riwayat > table > tbody > tr:nth-child(1) > td:nth-child(4) > span').textContent")
            Dim diterima = Await p.EvaluateFunctionAsync(Of String)("()=>document.querySelector('#status > table > tbody > tr:nth-child(1) > td:nth-child(3) > span').textContent")
            Dim result = resi + "|" + Regex.Replace(tgl_awal, "[^0-9-]", "") + "|" + kota_awal + "|" + Regex.Replace(tgl_update, "[^0-9-]", "") + "|" + kota_update + "|" + status_update + "|" + diterima

            ProgressBar1.Increment(20)

            Label1.Text = "[X] Mengambil data dari situs ..."
            ListBox1.Items.Add(result)
            Await b.CloseAsync()
            Label1.Text = "DATA RESI : " + resi + " , Data Berhasil Didapatkan!! ..."
            ProgressBar1.Increment(20)

        Catch ex As Exception
            MessageBox.Show(ex, "info")
            Label1.Text = "[X][X][X] TASK ERROR [ RESI: " + resi + " ]" + "[ " + ex + " ] ......"
            ProgressBar1.Value() = 100
        End Try


    End Function

    Public Function GetText(ByVal text As String)
        If (resipath = "" Or resipath = vbNullString) Then
            MessageBox.Show("Resi Belum Termuat, Tekan Tombol Load...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            resi = IO.File.ReadAllLines(text)
        End If
        Return 1
    End Function

    Public Function Reset()
        ProgressBar1.Value = 0
        Label1.Text = ""
        resipath = ""
        Erase resi
        lbTotal.Text = 0
        headless = True
        CheckBox1.Checked = False
        ''KILL ALL CHROME
        Dim lstOprograms As String() = {
     "chrome",
     "chromium"}
        '' etc. Until you have all your program names
        For Each prog As Process In Process.GetProcesses
            Timer1.Start()
            For Each nm As String In lstOprograms
                If prog.ProcessName = nm Then
                    prog.Kill()
                    Exit For
                End If
            Next
        Next
        Return 1
    End Function


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Reset()
    End Sub

    Private Sub Clear_btn_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Yakin Menghapus Hasil...", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ListBox1.Items.Clear()
            Reset()
        Else
            Return
        End If
    End Sub

    Private Sub Load_btn_Click(sender As Object, e As EventArgs) Handles Load_btn.Click
        Reset()
        OpenFileDialog1.DefaultExt = ".txt"
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.Filter = "Text Files|*.txt"
        If OpenFileDialog1.ShowDialog() =
        Windows.Forms.DialogResult.OK Then
            resipath = OpenFileDialog1.FileName
            GetText(resipath)
            lbTotal.Text = resi.Length
        End If
    End Sub

    Private Async Sub Cek_btn_ClickAsync(sender As Object, e As EventArgs) Handles Cek_btn.Click
        Try
            If (resipath = "" Or resipath = vbNullString) Then
                MessageBox.Show("Resi Belum Termuat, Tekan Tombol Load untuk memuat ...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else

                For i = 0 To (resi.Length - 1)
                    ProgressBar1.Value = 0
                    Label1.Text = "[Tips: Sabar, jika mancet disini berarti sedang download chrominium (>,<)] ......."
                    Await GetResi(resi(i))
                    Await Task.Delay(3000)
                Next
            End If
        Catch err As Exception
            MessageBox.Show(err, "info")
            Label1.Text = "ERROR !!!"
            ProgressBar1.Value() = 100
        End Try
    End Sub

    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sb As New Text.StringBuilder()

            For Each o As Object In ListBox1.Items
                sb.AppendLine(o)
            Next
            File.AppendAllText(OpenFileDialog1.FileName, "------------------------- [ " + todaysdate + " ] -------------------------" + vbCrLf + sb.ToString())
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            headless = False
        ElseIf CheckBox1.Checked = False Then
            headless = True
        End If
    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        Reset()
        Application.Exit()
    End Sub

    Private Sub SembunyikanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SembunyikanToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        NotifyIcon1.Visible = True
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object,
       ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class