Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        LoadRecords()
    End Sub

    Sub LoadRecords()
        DataGridView1.Rows.Clear()
        cm = New SqlCommand("SELECT * FROM tbl_product WHERE description LIKE '" & txtSearch.Text & "%' ", cn)
        dr = cm.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item(0).ToString, dr.Item(1).ToString, dr.Item(2).ToString, dr.Item(3).ToString, dr.Item(4).ToString)
        End While
        dr.Close()
    End Sub

    Private Sub btnLoadRecord_Click(sender As Object, e As EventArgs) Handles btnLoadRecord.Click
        LoadRecords()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'LoadRecords()
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        With Form2
            .LoadReport()
            .ShowDialog()
        End With
    End Sub
End Class
