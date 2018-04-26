using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;

using dxTestSolution.Module.BusinessObjects;

namespace dxTestSolution.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppUpdatingModuleUpdatertopic.aspx
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            //string name = "MyName";
            //DomainObject1 theObject = ObjectSpace.FindObject<DomainObject1>(CriteriaOperator.Parse("Name=?", name));
            //if(theObject == null) {
            //    theObject = ObjectSpace.CreateObject<DomainObject1>();
            //    theObject.Name = name;
            //}

            for (int i = 0; i < 10; i++) {
                string contactName = "FirstName" + i;
                var contact = CreateObject<Contact>("FirstName", contactName);
                contact.FirstName = contactName;
                contact.LastName = "LastName" + i;
				contact.Age = i * 10;
                for(int j = 0; j < 5; j++) {
                    string taskName = "Subject" + i + " - " + j;
                    var task = CreateObject<MyTask>("Subject", taskName);
                    task.Subject = taskName;
                    task.AssignedTo = contact;
                }
            }
            //secur#0  
			ObjectSpace.CommitChanges(); //Uncomment this line to persist created object(s).
        }

        T CreateObject<T>(string propertyName,string value) {
       
            T theObject = ObjectSpace.FindObject<T>(new OperandProperty(propertyName) == value);
            if (theObject == null)
                theObject = ObjectSpace.CreateObject<T>();
          
            return theObject;

        }

        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}
