using DevExpress.XtraGrid;

namespace DXApplication206 {
    public class CustomGridView : DevExpress.XtraGrid.Views.Grid.GridView {
        public CustomGridView() {
        }

        public CustomGridView(GridControl grid) : base(grid) {
        }

        protected override string ViewName {
            get {
                return "CustomGridView";
            }
        }
    }
}