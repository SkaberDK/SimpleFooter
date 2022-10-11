using System;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.WebAssets;
using Umbraco.Cms.Infrastructure.WebAssets;

namespace SimpleFooter.PropertyEditors
{

    [DataEditor("Maps", EditorType.PropertyValue, "Maps", "/App_Plugins/Maps/Maps.html", ValueType = ValueTypes.Json, HideLabel = true)]
    [PropertyEditorAsset(AssetType.Javascript, "/App_Plugins/Maps/Maps.controller.js")]
    public class MapsEditor : DataEditor
    {
        public MapsEditor(
            IDataValueEditorFactory dataValueEditorFactory,
            EditorType type = EditorType.PropertyValue)
            : base(dataValueEditorFactory, type)
        {
        }
    }
}
