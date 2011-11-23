
Public Class Manage_Kin

    Public Shared name() As String = {}
    Public Shared fi() As String = {}
    Public Shared lambda() As String = {}
    Public Shared height() As String = {}
    Public Shared st_vrstic As Integer

    Shared Sub read_KIN(ByVal path As String)
        Dim a As String
        Static read As System.IO.StreamReader
        st_vrstic = 1
        read = System.IO.File.OpenText(path)
        a = read.ReadLine()
        a = read.ReadLine()
        a = read.ReadLine()
        a = read.ReadLine()
        Do Until a Is Nothing
            fit_to_table(a, st_vrstic)
            a = read.ReadLine()
        Loop
        MessageBox.Show(st_vrstic)
        read.Close()
    End Sub
    Shared Sub fit_to_table(ByRef a As String, ByRef st_vrstic As Integer)
        Dim check As String = Mid(a, 77, 3)
        If check = "NAV" Then
            ReDim Preserve name(st_vrstic + 1)
            name(st_vrstic) = Mid(a, 3, 17)
            ReDim Preserve fi(st_vrstic + 1)
            fi(st_vrstic) = Mid(a, 20, 2) & "." & Mid(a, 23, 2) & Mid(a, 26, 2) & Mid(a, 30, 6)
            ReDim Preserve lambda(st_vrstic + 1)
            lambda(st_vrstic) = Mid(a, 39, 2) & "." & Mid(a, 42, 2) & Mid(a, 45, 2) & Mid(a, 48, 6)
            ReDim Preserve height(st_vrstic + 1)
            height(st_vrstic) = Mid(a, 59, 8)
            st_vrstic = st_vrstic + 1
            create_list_item(name(st_vrstic - 1), fi(st_vrstic - 1), lambda(st_vrstic - 1), height(st_vrstic - 1))
        End If


    End Sub
    Shared Sub create_list_item(ByVal ime As String, ByVal fi As String, ByVal lambda As String, ByVal height As String)
        Dim listitem As New ListViewItem
        listitem.Text = ime
        listitem.SubItems.Add(fi)
        listitem.SubItems.Add(lambda)
        listitem.SubItems.Add(height)
        Form1.tocke_vse.Items.Add(listitem)
        listitem = Nothing
    End Sub
End Class
