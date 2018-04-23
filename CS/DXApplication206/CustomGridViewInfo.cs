using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DXApplication206 {
    public class CustomGridViewInfo : DevExpress.XtraGrid.Views.Grid.ViewInfo.GridViewInfo {
        public CustomGridViewInfo(DevExpress.XtraGrid.Views.Grid.GridView view) : base(view) {
        }
        protected override bool GetShowDetailButtonInCell(GridDataRowInfo ri, DevExpress.XtraGrid.Drawing.GridColumnInfoArgs ci) {
            bool showDetailButton = false;
            if (ShowDetailButtons && !ri.IsSpecialRow) {
                if (ci.Info.CellIndex == 2 && ci.Info.StartRow == 0) // ci.Info.CellIndex denotes the first visible column
                    showDetailButton = true;
            }
            return showDetailButton;
        }
    }
}