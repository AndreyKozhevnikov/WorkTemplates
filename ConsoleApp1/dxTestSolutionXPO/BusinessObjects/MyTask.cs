using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.Diagnostics;

namespace dxTestSolutionXPO.Module.BusinessObjects {
     [DebuggerDisplay("Subject: {Subject}")]
    public class MyTask : XPObject { 
        public MyTask(Session session)
            : base(session) {
        }
        public override void AfterConstruction() {
            base.AfterConstruction();
        }
        string subject;
        public string Subject {
            get {
                return subject;
            }
            set {
                SetPropertyValue("Subject", ref subject, value);
            }
        }
        Contact assignedTo;
        [Association("Contact-Tasks")]
        public Contact AssignedTo {
            get {
                return assignedTo;
            }
            set {
                SetPropertyValue("AssignedTo", ref assignedTo, value);
            }
        }
        bool isActive;
        public bool IsActive {
            get {
                return isActive;
            }
            set {
                SetPropertyValue("IsActive", ref isActive, value);
            }
        }
    }
}