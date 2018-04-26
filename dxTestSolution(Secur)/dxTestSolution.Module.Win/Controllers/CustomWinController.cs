using DevExpress.ExpressApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Win.Layout;
using DevExpress.XtraLayout;
using DevExpress.ExpressApp.Actions;
using dxTestSolution.Module.BusinessObjects;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.ExpressApp.Editors;
using DevExpress.XtraEditors;

namespace dxTestSolution.Module.Win.Controllers {
    public class CustomWinController : ViewController {
        public CustomWinController() {
            // var myAction1 = new SimpleAction(this, "MyAction1", null);
            //  myAction1.Execute += MyAction1_Execute;
            
        }

        //private void MyAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {

        //}

        protected override void OnActivated() {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated() {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
