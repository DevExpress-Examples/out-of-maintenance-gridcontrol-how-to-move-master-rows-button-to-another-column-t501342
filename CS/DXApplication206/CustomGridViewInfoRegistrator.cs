using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace DXApplication206 {
    public class CustomGridViewInfoRegistrator : GridInfoRegistrator {
        public override string ViewName {
            get {
                return "CustomGridView";
            }
        }

        public override BaseView CreateView(GridControl grid) {
            return new CustomGridView(grid);
        }

        public override BaseViewInfo CreateViewInfo(BaseView view) {
            return new CustomGridViewInfo(view as CustomGridView);
        }
    }
}