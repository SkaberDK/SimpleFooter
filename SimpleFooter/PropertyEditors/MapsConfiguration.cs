using Umbraco.Cms.Core.PropertyEditors;

namespace SimpleFooter.PropertyEditors
{
    public class MapsConfiguration
    {
        [ConfigurationField("blockLimit", "Maximum number of blocks", "requiredfield",
            Description = "The total maximum number of blocks (of any type) that can be displayed (0 = infinite).")]
        public int BlockLimit { get; set; }

        [ConfigurationField("editorAlignCentered", "Align editor centered", "boolean",
            Description =
                "If the editor doesn't span the entire width of the content editing area, center it. Otherwise left aligned.")]
        public bool EditorAlignCentered { get; set; }

        [ConfigurationField("editorWidth", "Editor width", "requiredfield",
            Description = "The width the Sir Trevor editor will expand to, most likely 100%.")]
        public int EditorWidth { get; set; }

        [ConfigurationField("editorMaxWidth", "Maximum editor width", "requiredfield",
            Description = "The maximum width the Sir Trevor editor will expand to, i.e. 500px or 80%.")]
        public int EditorMaxWidth { get; set; }

        [ConfigurationField("blocktypes", "Block types", "/App_Plugins/SirTrevor/settings/blocktypes.html",
            Description = "Configure the block types available to the user.")]
        public object BlockTypes { get; set; }
    }
}