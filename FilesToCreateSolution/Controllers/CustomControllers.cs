﻿using System;
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
	//public class CustomController : ObjectViewController<ListView,Contact> {
    public class CustomController : ViewController {
        public CustomController() {
          // var myAction1 = new SimpleAction(this, "MyAction1", PredefinedCategory.Edit);
          // myAction1.Execute += MyAction1_Execute;
            
        }

        private void MyAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {
            //var os = Application.CreateObjectSpace(typeof(MyNonPersistentClass));
            //var obj = os.CreateObject<MyNonPersistentClass>();
            //var detailView = Application.CreateDetailView(os, obj);
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
