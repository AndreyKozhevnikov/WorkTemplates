using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ConsoleApp1.dxT631023 {

    public partial class Contact {
        public Contact(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
