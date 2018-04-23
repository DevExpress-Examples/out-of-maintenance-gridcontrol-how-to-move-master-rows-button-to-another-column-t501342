Imports System.ComponentModel
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base

Namespace DXApplication206
    <ToolboxItem(True)> _
    Public Class CustomGridControl
        Inherits GridControl

        Protected Overrides Function CreateDefaultView() As BaseView
            Return CreateView("CustomGridView")
        End Function

        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New CustomGridViewInfoRegistrator())
        End Sub
    End Class
End Namespace
