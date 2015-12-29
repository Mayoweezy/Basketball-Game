<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeagueTable
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
        Me.LeagueDataSet = New Aspiring_Rookie___Basketball.LeagueDataSet()
        Me.LeagueTableTrialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeagueTableTrialTableAdapter = New Aspiring_Rookie___Basketball.LeagueDataSetTableAdapters.LeagueTableTrialTableAdapter()
        Me.TableAdapterManager = New Aspiring_Rookie___Basketball.LeagueDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.LeagueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeagueTableTrialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeagueDataSet
        '
        Me.LeagueDataSet.DataSetName = "LeagueDataSet"
        Me.LeagueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LeagueTableTrialBindingSource
        '
        Me.LeagueTableTrialBindingSource.DataMember = "LeagueTableTrial"
        Me.LeagueTableTrialBindingSource.DataSource = Me.LeagueDataSet
        '
        'LeagueTableTrialTableAdapter
        '
        Me.LeagueTableTrialTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LeagueTableTrialTableAdapter = Me.LeagueTableTrialTableAdapter
        Me.TableAdapterManager.UpdateOrder = Aspiring_Rookie___Basketball.LeagueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(538, 264)
        Me.DataGridView1.TabIndex = 0
        '
        'LeagueTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 355)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "LeagueTable"
        Me.Text = "LeagueTable"
        CType(Me.LeagueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeagueTableTrialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LeagueDataSet As Aspiring_Rookie___Basketball.LeagueDataSet
    Friend WithEvents LeagueTableTrialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LeagueTableTrialTableAdapter As Aspiring_Rookie___Basketball.LeagueDataSetTableAdapters.LeagueTableTrialTableAdapter
    Friend WithEvents TableAdapterManager As Aspiring_Rookie___Basketball.LeagueDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
