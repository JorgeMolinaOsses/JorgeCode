using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.ComponentModel;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockP1
{
	
	public partial class stock : Window
	{

		ObservableCollection<Product> Products;

		public stock()
		{
			InitializeComponent();

			Products = new ObservableCollection<Product>()
			{
				//new Product("5", "pendrive Kingston 8 GB 3.0"),
				//new Product("4", "Teclado + mouse 850 inalambrico(microsoft)"),

			};

			dataS.ItemsSource = Products;

			//dataA.SelectionChanged += DataA_SelectionChanged;

		}

		public class Product
		{

			[DisplayName("producto")]
			public string quantity { set; get; }

			public string description { set; get; }

			/*public Product(string cant, string Desc)
			{
				quantity = cant;
				description = Desc;

			}*/

		}
		public void description()
		{


		}

		public void quantity()
		{


		}


		/*private void DataA_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var item = dataA.SelectedItem as Product;

			if (item != null)
			{
				Cantidad.Text = item.quantity;
				Descripcion.Text = item.description;

			}
		}



		private void Agregar_Click(object sender, RoutedEventArgs e)
		{



			if (Cantidad.Text == "" || Descripcion.Text == "")
			{
				MessageBox.Show("Escribir Informacion");

			}
			else
			{
				Products.Add(new Product(Cantidad.Text, Descripcion.Text));

			}
			
		}

		private void Eliminar_Click(object sender, RoutedEventArgs e)
		{
			var item = dataA.SelectedItem as Product;

			if (item == null)
			{
				MessageBox.Show("Seleccionar producto");
			}
			else
			{
				Products.Remove(item);

			}
		}

		private void Editar_Click(object sender, RoutedEventArgs e)
		{
			var item = dataA.SelectedItem as Product;

			if (item != null)
			{
				item.quantity = Cantidad.Text;
				item.description = Descripcion.Text;
				dataA.ItemsSource = new ObservableCollection<Product>();
				dataA.ItemsSource = Products;

			}
		}*/


	}
}

