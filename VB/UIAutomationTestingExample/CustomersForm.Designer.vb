Namespace UIAutomationTestingExample

    Partial Class CustomersForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.customersGrid = New DevExpress.XtraGrid.GridControl()
            Me.customersGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.customersGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.customersGridView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.Caption = "Is Modified"
            Me.gridColumn3.FieldName = "IsModified"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.UnboundDataType = GetType(Boolean)
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            ' 
            ' customersGrid
            ' 
            Me.customersGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.customersGrid.Location = New System.Drawing.Point(0, 0)
            Me.customersGrid.MainView = Me.customersGridView
            Me.customersGrid.Name = "customersGrid"
            Me.customersGrid.Size = New System.Drawing.Size(800, 450)
            Me.customersGrid.TabIndex = 0
            Me.customersGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.customersGridView})
            ' 
            ' customersGridView
            ' 
            Me.customersGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
            gridFormatRule1.Column = Me.gridColumn3
            gridFormatRule1.Name = "Format0"
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((192)))))), (CInt(((CByte((192)))))))
            formatConditionRuleValue1.Appearance.Options.UseBackColor = True
            formatConditionRuleValue1.Value1 = True
            gridFormatRule1.Rule = formatConditionRuleValue1
            Me.customersGridView.FormatRules.Add(gridFormatRule1)
            Me.customersGridView.GridControl = Me.customersGrid
            Me.customersGridView.Name = "customersGridView"
            AddHandler Me.customersGridView.CellValueChanged, New DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(AddressOf Me.customersGridView_CellValueChanged)
            AddHandler Me.customersGridView.CustomUnboundColumnData, New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(AddressOf Me.customersGridView_CustomUnboundColumnData)
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "ID"
            Me.gridColumn1.FieldName = "ID"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "Name"
            Me.gridColumn2.FieldName = "Name"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            Me.gridColumn2.Width = 253
            ' 
            ' CustomersForm
            ' 
            Me.AccessibleName = "CRM Customers Form"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.customersGrid)
            Me.Name = "CustomersForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Customers"
            CType((Me.customersGrid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.customersGridView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private customersGrid As DevExpress.XtraGrid.GridControl

        Private customersGridView As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
