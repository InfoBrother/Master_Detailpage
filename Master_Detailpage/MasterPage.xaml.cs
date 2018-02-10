using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Master_Detailpage
{
	
	public partial class MasterPage : ContentPage
	{
        public ListView Listview { get { return listView; } }
		public MasterPage ()
		{
			InitializeComponent ();

            var masterPageItem = new List<MasterPageItem>();
            masterPageItem.Add(new MasterPageItem
            {
                Title = "HomePage",
                IconSource = "home.png",
                TargetType = typeof(HomePage)
            });

            masterPageItem.Add(new MasterPageItem
            {
                Title = "TutorialPage",
                IconSource = "tutorial.png",
                TargetType = typeof(TutorialPage)
            });

            masterPageItem.Add(new MasterPageItem
            {
                Title = "AboutPage",
                IconSource = "about.png",
                TargetType = typeof(AboutPage)
            });

            masterPageItem.Add(new MasterPageItem
            {
                Title = "ContactPage",
                IconSource = "contact.png",
                TargetType = typeof(ContactPage)
            });

            listView = new ListView
            {
                ItemsSource = masterPageItem,
                ItemTemplate = new DataTemplate(() =>
                {
                    var grid = new Grid { Padding = new Thickness(5, 10) };
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                    var image = new Image();
                    image.SetBinding(Image.SourceProperty, "IconSource");
                    var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
                    label.SetBinding(Label.TextProperty, "Title");

                    grid.Children.Add(image);
                    grid.Children.Add(label, 1, 0);

                    return new ViewCell { View = grid };
                }),

                SeparatorVisibility = SeparatorVisibility.None
            };

            Icon = "icon.png";
            Title = "InfoBrother";
            Content = new StackLayout
            {
                Children = { listView }
            };
        }
	}
}