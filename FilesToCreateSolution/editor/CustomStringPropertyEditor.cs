using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;

namespace dxT1158800.Blazor.Server.Editors.editor {
    [PropertyEditor(typeof(string), false)]
    public class CustomStringPropertyEditor : BlazorPropertyEditorBase {
        public CustomStringPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        protected override IComponentAdapter CreateComponentAdapter() => new InputAdapter(new InputModel());
		    protected override RenderFragment CreateViewComponentCore(object dataContext) {

            bool result = (bool)this.GetPropertyValue(dataContext);
            InputModel switchmodel = new InputModel();
            return InputRenderer.Create(switchmodel);
        }
    }
}
