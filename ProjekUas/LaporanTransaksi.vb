Public Class LaporanTransaksi
    Private Sub LaporanTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TokoKomikDataSet.transaction' table. You can move, or remove it, as needed.
        Me.transactionTableAdapter.Fill(Me.TokoKomikDataSet.transaction)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class