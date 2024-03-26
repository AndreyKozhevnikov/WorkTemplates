using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using dxTestSolution.Module.BusinessObjects;

namespace dxTestSolution.Win.Controllers {
    public class GridViewControllerWin : ObjectViewController<ListView, Contact> {
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            // Obtain the List Editor: XAF's abstraction over the UI control.
            if (View.Editor is GridListEditor gridListEditor && gridListEditor.GridView != null) {
                // Access the GridView object (part of the DevExpress WinForms Grid Control architecture). 
                GridView gridView = gridListEditor.GridView;
                // Specify the behavior of the grid's columns.
                // Access grid columns.
                // Use column settings to disable the sorting and grouping functionality. 
                foreach (GridColumn columnModel in gridView.Columns) {
                    //columnModel.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    //columnModel.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
                }
            }
        }
    }
}
