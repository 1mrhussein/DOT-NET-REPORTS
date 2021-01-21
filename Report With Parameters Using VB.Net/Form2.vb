Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub LoadReport()
        ReportViewer1.RefreshReport()
        Dim rptDataSource As ReportDataSource
        With ReportViewer1.LocalReport
            .ReportPath = Application.StartupPath & "\Report\Report1.rdlc"
            .DataSources.Clear()
        End With

        Dim ds As New DataSet1
        Dim da As New SqlDataAdapter

        da.SelectCommand = New SqlCommand("SELECT id, description, category, price, status FROM tbl_product WHERE description LIKE '" & Form1.txtSearch.Text & "%'", cn)
        da.Fill(ds.Tables("dtProduct"))

        rptDataSource = New ReportDataSource("DataSet1", ds.Tables("dtProduct"))
        ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class