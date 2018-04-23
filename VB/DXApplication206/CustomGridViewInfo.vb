Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DXApplication206
    Public Class CustomGridViewInfo
        Inherits DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo

        Public Sub New(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView)
            MyBase.New(view)
        End Sub
        Protected Overrides Function GetShowDetailButtonInCell(ByVal ri As GridDataRowInfo, ByVal ci As DevExpress.XtraGrid.Drawing.GridColumnInfoArgs) As Boolean
            Dim showDetailButton As Boolean = False
            If ShowDetailButtons AndAlso (Not ri.IsSpecialRow) Then
                If ci.Info.CellIndex = 2 AndAlso ci.Info.StartRow = 0 Then ' ci.Info.CellIndex denotes the first visible column
                    showDetailButton = True
                End If
            End If
            Return showDetailButton
        End Function
    End Class
End Namespace