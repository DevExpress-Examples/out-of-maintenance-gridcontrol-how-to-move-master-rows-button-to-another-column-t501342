using System.ComponentModel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace DXApplication206 {
    [ToolboxItem(true)]
    public class CustomGridControl : GridControl {
        protected override BaseView CreateDefaultView() {
            return CreateView("CustomGridView");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new CustomGridViewInfoRegistrator());
        }
    }
}
