using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Editors;
using System.Diagnostics;
using DevExpress.Persistent.Base.General;
using DevExpress.ExpressApp.SystemModule;

namespace dxTestSolution.Module.BusinessObjects {
     [DefaultClassOptions]
	  [DebuggerDisplay("FirstName: {FirstName}")]
    public class Contact : BaseObject { 
        public Contact(Session session)
            : base(session) {
        }
        public override void AfterConstruction() {
            base.AfterConstruction();
        }
        string firstName;
        public string FirstName {
            get {
                return firstName;
            }
            set {
                SetPropertyValue(nameof(FirstName), ref firstName, value);
            }
        }
        string lastName;
        public string LastName {
            get {
                return lastName;
            }
            set {
                SetPropertyValue(nameof(LastName), ref lastName, value);
            }
        }
		int age;
        public int Age {
            get {
                return age;
            }
            set {
                SetPropertyValue(nameof(Age), ref age, value);
            }
        }
        // DateTime _birthDate;
        // public DateTime BirthDate {
        // get {
        // return _birthDate;
        // }
        // set {
        // SetPropertyValue(nameof(BirthDate), ref _birthDate, value);
        // }
        // }	
        //office#3		
        [Association("Contact-Tasks")]
        public XPCollection<MyTask> Tasks {
            get {
                return GetCollection<MyTask>(nameof(Tasks));
            }
        }
    }
}