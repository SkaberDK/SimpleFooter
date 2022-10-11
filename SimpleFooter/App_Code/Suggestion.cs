using System.Drawing;
using System.Text.RegularExpressions;
using Umbraco.Cms.Core.PropertyEditors;

namespace SimpleFooter.App_Code
{
    [DataEditor(
        alias: "Suggestions editor",
        name: "Suggestions",
        view: "~/App_Plugins/Suggestions/suggestion.html",
        Group = "Common",
        Icon = "icon-list")]
    public class Suggestions : DataEditor
    {
        public Suggestions(IDataValueEditorFactory dataValueEditorFactory)
            : base(dataValueEditorFactory)
        {
        }
    }
}
