Imports DevExpress.XtraGrid

Namespace DXApplication206
    Public Class CustomGridView
        Inherits DevExpress.XtraGrid.Views.Grid.GridView

        Public Sub New()
        End Sub

        Public Sub New(ByVal grid As GridControl)
            MyBase.New(grid)
        End Sub

        Protected Overrides ReadOnly Property ViewName() As String
            Get
                Return "CustomGridView"
            End Get
        End Property
    End Class
End Namespace