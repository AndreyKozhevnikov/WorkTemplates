namespace dxTestSolution.Win {
    partial class dxTestSolutionWindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.module3 = new dxTestSolution.Module.dxTestSolutionModule();
            this.module4 = new dxTestSolution.Module.Win.dxTestSolutionWindowsFormsModule();
			//secur#2
			//report#0
			//office#4
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			//secur#3
			//report#1#
			//office#5
            // 
            // dxTestSolutionWindowsFormsApplication
            // 
            this.ApplicationName = "dxTestSolution";
            this.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
			//report#2
			//office#6
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
			//secur#4
            this.UseOldTemplates = false;
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.dxTestSolutionWindowsFormsApplication_DatabaseVersionMismatch);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.dxTestSolutionWindowsFormsApplication_CustomizeLanguagesList);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private dxTestSolution.Module.dxTestSolutionModule module3;
        private dxTestSolution.Module.Win.dxTestSolutionWindowsFormsModule module4;
		//secur#1
		//report#3
		//office#7
    }
}
