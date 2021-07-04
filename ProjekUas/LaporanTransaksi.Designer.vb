<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TokoKomikDataSet = New ProjekUas.TokoKomikDataSet()
        Me.transactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.transactionTableAdapter = New ProjekUas.TokoKomikDataSetTableAdapters.transactionTableAdapter()
        CType(Me.TokoKomikDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetTransaksi"
        ReportDataSource1.Value = Me.transactionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProjekUas.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(799, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'TokoKomikDataSet
        '
        Me.TokoKomikDataSet.DataSetName = "TokoKomikDataSet"
        Me.TokoKomikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'transactionBindingSource
        '
        Me.transactionBindingSource.DataMember = "transaction"
        Me.transactionBindingSource.DataSource = Me.TokoKomikDataSet
        '
        'transactionTableAdapter
        '
        Me.transactionTableAdapter.ClearBeforeFill = True
        '
        'LaporanTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "LaporanTransaksi"
        Me.Text = "LaporanTransaksi"
        CType(Me.TokoKomikDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents transactionBindingSource As BindingSource
    Friend WithEvents TokoKomikDataSet As TokoKomikDataSet
    Friend WithEvents transactionTableAdapter As TokoKomikDataSetTableAdapters.transactionTableAdapter
End Class
