using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using dxTestSolution.Module.BusinessObjects;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using System.IO;
using System.ComponentModel;

namespace dxTestSolution.Module.Controllers {
	//public class CustomWebController : ObjectViewController<ListView,Contact> {
    public class CustomWebController : ViewController {
        public CustomWebController() {
            // var mypopAction1 = new PopupWindowShowAction(this, "MyWebPopupAction1", null);
            // mypopAction1.CustomizePopupWindowParams += MyAction1_CustomizePopupWindowParams;
            var myAction1 = new SimpleAction(this, "MyWebAction1", PredefinedCategory.Edit);
            myAction1.Execute += MyAction1_Execute;
            
        }

        private void MyAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {
            // ASPxGridListEditor listEditor = ((ListView)View).Editor as ASPxGridListEditor;
            // if(listEditor != null) {
                // listEditor.Grid.Selection.UnselectAll();
            // }           
        }
        private void MyAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
            var os = Application.CreateObjectSpace(typeof(Contact));
            var obj = os.CreateObject<Contact>();
            var view = Application.CreateDetailView(os, obj);
            e.View = view;
        }

        protected override void OnActivated() {
            base.OnActivated();
            var cnt = Frame.GetController<NewObjectViewController>();
            if(cnt != null) {

            }
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
        }
    }
}
