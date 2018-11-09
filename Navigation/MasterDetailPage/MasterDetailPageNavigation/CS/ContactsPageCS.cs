using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class ContactsPageCS : ContentPage
	{
		public ContactsPageCS ()
		{
			Title = "Contacts Page";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Contacts data goes here Nathaniel",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
