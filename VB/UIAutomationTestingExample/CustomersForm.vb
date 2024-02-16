Imports DevExpress.XtraGrid
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Drawing

Namespace UIAutomationTestingExample

    Public Partial Class CustomersForm
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            Dim customers As ObservableCollection(Of Customer) = New ObservableCollection(Of Customer)()
            For i As Integer = 1 To 30 - 1
                customers.Add(New Customer() With {.ID = i, .Name = "Customer" & i})
            Next

            customersGrid.DataSource = customers
        End Sub

        Private modifiedItems As HashSet(Of Customer) = New HashSet(Of Customer)()

        Private Sub customersGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDataEventArgs)
            If Not Equals(e.Column.FieldName, "IsModified") Then Return
            Dim customer As Customer = TryCast(e.Row, Customer)
            If customer IsNot Nothing AndAlso modifiedItems.Contains(customer) Then
                e.Value = True
            End If
        End Sub

        Private Sub customersGridView_CellValueChanged(ByVal sender As Object, ByVal e As Views.Base.CellValueChangedEventArgs)
            modifiedItems.Add(CType(customersGridView.GetRow(e.RowHandle), Customer))
        End Sub
    End Class

    Public Class Customer

        Public Property ID As Integer

        Public Property Name As String
    End Class
End Namespace
