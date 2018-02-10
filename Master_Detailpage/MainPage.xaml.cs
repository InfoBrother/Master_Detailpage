using System;
using Xamarin.Forms;

namespace Master_Detailpage
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();

            masterPage.Listview.ItemSelected += OnItemSelected;
		}

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.Listview.SelectedItem = null;
                IsPresented = false;
            }
        }
	}
}
