using DevExpress.ExpressApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Web;
using dxTestSolution.Module.BusinessObjects;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.Web;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Web.Controls;
using System.Web.UI;

namespace dxTestSolution.Module.Web.Controllers {
    public class CustomWebController : ViewController {
        public CustomWebController() {
             var myAction1 = new SimpleAction(this, "MyWebAction1", null);
              myAction1.Execute += MyAction1_Execute;
            
        }

        private void MyAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {

        }

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
