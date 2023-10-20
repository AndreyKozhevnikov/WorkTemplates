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

using System.IO;
using System.ComponentModel;

namespace dxTestSolution.Module.Controllers {
    //public class CustomBlazorController : ObjectViewController<DetailView,Contact> {
    public class CustomBlazorController : ViewController {
        public CustomBlazorController() {
            var myAction1 = new SimpleAction(this, "MyBlazorAction1", PredefinedCategory.Edit);
            myAction1.Execute += MyAction1_Execute;

        }

        private void MyAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {
            //var os = Application.CreateObjectSpace(typeof(MyNonPersistentClass));
            //var obj = os.CreateObject<MyNonPersistentClass>();
            //var detailView = Application.CreateDetailView(os, obj);
        }

        protected override void OnActivated() {
            base.OnActivated();
            var cnt = Frame.GetController<NewObjectViewController>();
            if (cnt != null) {

            }
            //View.CustomizeViewItemControl<StringPropertyEditor>(this, SetCalendarView, nameof(Contact.LastName));
        }
        //private void SetCalendarView(StringPropertyEditor propertyEditor) {

        //}
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            //if (View.Editor is DxGridListEditor gridListEditor) {
            //           IDxGridAdapter dataGridAdapter = gridListEditor.GetGridAdapter();
            //           dataGridAdapter.GridModel.ColumnResizeMode = DevExpress.Blazor.GridColumnResizeMode.ColumnsContainer;
            //       }
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
        }
    }
}
