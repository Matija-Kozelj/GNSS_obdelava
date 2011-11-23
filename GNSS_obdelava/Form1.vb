Imports GNSS_obdelava.Dialogi
Imports GNSS_obdelava.Manage_Kin
Imports GNSS_obdelava.Manage_RTK
Public Class Form1
    Public seznam_vseh_tock() As ListViewItem
    Public seznam_aktivnih_tock() As ListViewItem
    Private Sub LeicaGeoOfficeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeicaGeoOfficeToolStripMenuItem.Click
        Dim pot_do_datoteke As String
        Dialogi.Open_file("Odprite željeno datoteko", pot_do_datoteke)
        Manage_Kin.read_KIN(pot_do_datoteke)
        posodobi_seznama()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each item As ListViewItem In tocke_vse.Items
            If item.Checked = True Then
                tocke_vse.Items.Remove(item)
                ListView1.Items.Add(item)
                ListView1.Items.Item(ListView1.Items.IndexOf(item)).Checked = False
            End If
        Next
        posodobi_seznama()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each item As ListViewItem In ListView1.Items
            If item.Checked = True Then
                ListView1.Items.Remove(item)
                tocke_vse.Items.Add(item)
                tocke_vse.Items.Item(tocke_vse.Items.IndexOf(item)).Checked = False
            End If
        Next
        posodobi_seznama()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For Each item As ListViewItem In tocke_vse.Items
            tocke_vse.Items.Remove(item)
            ListView1.Items.Add(item)
            ListView1.Items.Item(ListView1.Items.IndexOf(item)).Checked = False
        Next
        posodobi_seznama()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For Each item As ListViewItem In ListView1.Items
            ListView1.Items.Remove(item)
            tocke_vse.Items.Add(item)
            tocke_vse.Items.Item(tocke_vse.Items.IndexOf(item)).Checked = False
        Next
        posodobi_seznama()
    End Sub

    Private Sub posodobi_seznama()
        ReDim seznam_aktivnih_tock(ListView1.Items.Count - 1)
        ReDim seznam_vseh_tock(tocke_vse.Items.Count - 1)
        ListView1.Items.CopyTo(seznam_aktivnih_tock, 0)
        tocke_vse.Items.CopyTo(seznam_vseh_tock, 0)
    End Sub

    Private Sub VseTočkeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VseTočkeToolStripMenuItem.Click
        Dim str As String = ""
        Dim item As ListViewItem
        For Each item In seznam_vseh_tock
            str += item.Text & "    " & item.SubItems(1).Text & "    " & item.SubItems(2).Text & "    " & item.SubItems(3).Text & vbCrLf
        Next
        Dim seznam As New Form
        seznam.CreateControl()
        Dim seznam_vsebina As New Windows.Forms.RichTextBox
        seznam_vsebina.Text = str
        seznam_vsebina.WordWrap = True
        seznam.Controls.Add(seznam_vsebina)
        seznam.Width = 450
        seznam.Height = 600
        seznam_vsebina.Width = 350
        seznam_vsebina.Height = 400
        seznam_vsebina.Left = 50
        seznam_vsebina.Top = 50
        seznam.Text = "Seznam vseh točk"
        'Dim okgumb As New Windows.Forms.Button
        'okgumb.Text = "Ok"
        'okgumb.Location = New Point((ClientSize.Width - okgumb.Width) \ 2,
        '                     (800))

        'seznam.Controls.Add(okgumb)
        seznam.Show()
        'AddHandler okgumb.Click, AddressOf okclicked
    End Sub
    'Private Sub okclicked(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    Private Sub AktivneTočkeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktivneTočkeToolStripMenuItem2.Click
        Dim str As String = ""
        Dim item As ListViewItem
        For Each item In seznam_aktivnih_tock
            str += item.Text & "    " & item.SubItems(1).Text & "    " & item.SubItems(2).Text & "    " & item.SubItems(3).Text & vbCrLf
        Next
        Dim seznam As New Form
        seznam.CreateControl()
        Dim seznam_vsebina As New Windows.Forms.RichTextBox
        seznam_vsebina.Text = str
        seznam_vsebina.WordWrap = True
        seznam.Controls.Add(seznam_vsebina)
        seznam.Width = 450
        seznam.Height = 600
        seznam_vsebina.Width = 350
        seznam_vsebina.Height = 400
        seznam_vsebina.Left = 50
        seznam_vsebina.Top = 50
        seznam.Text = "Seznam aktivnih točk"
        seznam.Show()
    End Sub
End Class
