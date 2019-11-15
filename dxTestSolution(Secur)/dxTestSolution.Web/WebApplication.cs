using System;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.Web;
using System.Collections.Generic;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.ExpressApp.Security;

namespace dxTestSolution.Web {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/DevExpressExpressAppWebWebApplicationMembersTopicAll.aspx
    public partial class dxTestSolutionAspNetApplication : WebApplication {
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
        private dxTestSolution.Module.dxTestSolutionModule module3;
		//secur#1#
		//report#10
		//office#15#
        private dxTestSolution.Module.Web.dxTestSolutionAspNetModule module4;

        #region Default XAF configuration options (https://www.devexpress.com/kb=T501418)
        static dxTestSolutionAspNetApplication() {
			EnableMultipleBrowserTabsSupport = true;
            DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.AllowFilterControlHierarchy = true;
            DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.MaxFilterControlHierarchyDepth = 3;
            DevExpress.ExpressApp.Web.Editors.ASPx.ASPxCriteriaPropertyEditor.AllowFilterControlHierarchyDefault = true;
            DevExpress.ExpressApp.Web.Editors.ASPx.ASPxCriteriaPropertyEditor.MaxHierarchyDepthDefault = 3;
            DevExpress.Persistent.Base.PasswordCryptographer.EnableRfc2898 = true;
            DevExpress.Persistent.Base.PasswordCryptographer.SupportLegacySha512 = false;
        }
        private void InitializeDefaults() {
            LinkNewObjectToParentImmediately = false;
            OptimizedControllersCreation = true;
        }
        #endregion
        public dxTestSolutionAspNetApplication() {
            InitializeComponent();
			InitializeDefaults();
        }
		protected override IViewUrlManager CreateViewUrlManager() {
            return new ViewUrlManager();
        }
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            IObjectSpaceProvider provider;
            if(dxTestSolution.Module.dxTestSolutionModule.UseInMemoryStore) {
                provider = new XPObjectSpaceProvider(InMemoryDataStoreProvider.ConnectionString, null, false);
            } else {
                provider = new XPObjectSpaceProvider(XPObjectSpaceProvider.GetDataStoreProvider(args.ConnectionString, args.Connection, true), false);
            }
			//secur#9
            args.ObjectSpaceProviders.Add(provider);
            args.ObjectSpaceProviders.Add(new NonPersistentObjectSpaceProvider(TypesInfo, null));
        }
        private IXpoDataStoreProvider GetDataStoreProvider(string connectionString, System.Data.IDbConnection connection) {
            System.Web.HttpApplicationState application = (System.Web.HttpContext.Current != null) ? System.Web.HttpContext.Current.Application : null;
            IXpoDataStoreProvider dataStoreProvider = null;
            if(application != null && application["DataStoreProvider"] != null) {
                dataStoreProvider = application["DataStoreProvider"] as IXpoDataStoreProvider;
            }
            else {
                dataStoreProvider = XPObjectSpaceProvider.GetDataStoreProvider(connectionString, connection, true);
                if(application != null) {
                    application["DataStoreProvider"] = dataStoreProvider;
                }
            }
			return dataStoreProvider;
        }
        private void dxTestSolutionAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
#if EASYTEST
            e.Updater.Update();
            e.Handled = true;
#else
            if(System.Diagnostics.Debugger.IsAttached) {
                e.Updater.Update();
                e.Handled = true;
            }
            else {
				string message = "The application cannot connect to the specified database, " +
					"because the database doesn't exist, its version is older " +
					"than that of the application or its schema does not match " +
					"the ORM data model structure. To avoid this error, use one " +
					"of the solutions from the https://www.devexpress.com/kb=T367835 KB Article.";

                if(e.CompatibilityError != null && e.CompatibilityError.Exception != null) {
                    message += "\r\n\r\nInner exception: " + e.CompatibilityError.Exception.Message;
                }
                throw new InvalidOperationException(message);
            }
#endif
        }
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
            this.module3 = new dxTestSolution.Module.dxTestSolutionModule();
            this.module4 = new dxTestSolution.Module.Web.dxTestSolutionAspNetModule();
			//secur#2
			//report#11
	        //office#12#
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			//office#14#
			//secur#3
			//report#12
			
            // 
            // dxTestSolutionAspNetApplication
            // 
            this.ApplicationName = "dxTestSolution";
            this.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
			//report#14
            this.Modules.Add(this.module3);
			//office#13#
            this.Modules.Add(this.module4);
			//secur#4
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.dxTestSolutionAspNetApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
