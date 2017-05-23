using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StockP1
{
	/// <summary>
	/// Lógica de interacción para user.xaml
	/// </summary>
	public partial class user : Window
	{
		public user()
		{
			InitializeComponent();
		}

		private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		public class users
		{

			[DisplayName("Usuarios")]
			public string user { set; get; }

			public string descriptionU { set; get; }

			public string quantityU { set; get; }

			/*public Product(string cant, string Desc)
			{
				quantity = cant;
				description = Desc;

			}*/
		}

		
	}
}
