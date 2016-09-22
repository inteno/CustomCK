using CustomCK.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;
using Orchard.ContentManagement;

namespace CustomCK.Handlers
{
    public class CustomCKSettingsPartHandler : ContentHandler
    {
        public CustomCKSettingsPartHandler()
        {
            T = NullLocalizer.Instance;

            Filters.Add(new ActivatingFilter<CustomCKSettingsPart>("Site")); //Add a new Part to the Site content type

            //Loads Views/EditorTemplates/Parts.CustomCK.CustomCKSettings.cshtml
            Filters.Add(new TemplateFilterForPart<CustomCKSettingsPart>("CustomCKSettings", "Parts.CustomCK.CustomCKSettings", "CustomCK"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context)
        {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("CustomCK"))); //Adds Settings > CustomCK Menu item
        }
    }
}