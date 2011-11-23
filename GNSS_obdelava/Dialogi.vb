Public Class Dialogi
    Shared Sub Save_file(ByVal ime_dialoga As String, ByRef pot_do_datoteke As String)
        Dim outputfile As New SaveFileDialog
        outputfile.Filter = ("tekstovne datoteke|*.txt")
        outputfile.Title = (ime_dialoga)
        outputfile.ShowDialog()
        pot_do_datoteke = outputfile.FileName
    End Sub
    Shared Sub Open_file(ByVal ime_dialoga As String, ByRef pot_do_datoteke As String)
        Dim open As New OpenFileDialog
        open.Filter = ("ASCII datoteke|*.asc")
        open.Title = (ime_dialoga)
        open.ShowDialog()
        pot_do_datoteke = open.FileName
        Return
    End Sub


End Class
