using DevExpress.ExpressApp;
using dxTestSolution.Module.BusinessObjects;
using DevExpress.ExpressApp.Blazor.Editors.Models;
using DevExpress.ExpressApp.Blazor.Editors;

namespace dxTestSolution.Module.Controllers {
    public class GridViewControllerBlazor : ObjectViewController<ListView, Contact> {
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            if (View.Editor is DxGridListEditor gridListEditor) {
                // Obtain the Component Adapter.
                IDxGridAdapter dataGridAdapter = gridListEditor.GetGridAdapter();

                // Access grid property.
              //  dataGridAdapter.GridModel.PagerVisible = false;

                // Access grid columns.
                // Use column settings to disable the sorting and grouping functionality. 
                foreach (DxGridDataColumnModel columnModel in dataGridAdapter.GridDataColumnModels) {
                    //columnModel.AllowSort = false;
                    //columnModel.AllowGroup = false;
                }
            }
        }
    }
}
