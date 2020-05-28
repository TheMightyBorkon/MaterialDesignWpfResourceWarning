using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		void AddButtonClick(object sender, RoutedEventArgs e)
		{
			var tb = new TextBox
			{
				Text = "Hello",
				HorizontalAlignment = HorizontalAlignment.Left,
				VerticalAlignment = VerticalAlignment.Top,
				Margin = new Thickness(20),
				Width = 200
			};

			_grid.Children.Add(tb);
		}

		void RemoveButtonClick(object sender, RoutedEventArgs e)
		{
			_grid.Children.Remove(_grid.Children[0]);
		}
	}
}