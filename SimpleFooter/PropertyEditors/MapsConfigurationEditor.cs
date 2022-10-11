using SimpleFooter.PropertyEditors;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;

namespace SimpleFooter.PropertyEditors
{
    public class MapsConfigurationEditor : ConfigurationEditor<MapsConfiguration>
    {
        public MapsConfigurationEditor(IIOHelper ioHelper, IEditorConfigurationParser editorConfigurationParser) : base(ioHelper, editorConfigurationParser)
        {
        }
    }
}
