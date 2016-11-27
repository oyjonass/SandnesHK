using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace wwwroot.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "eda5673f-9716-40f0-8504-b5e2118f96e0", Description = "")]
    public class StartPage : SitePageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}