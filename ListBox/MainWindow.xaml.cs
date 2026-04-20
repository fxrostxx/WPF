using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBox
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		void Button_Click(object sender, EventArgs e)
		{
			switch ((sender as Button).Content)
			{
				case "ADD":
					if (!string.IsNullOrWhiteSpace(txtInput.Text))
					{
						listBox.Items.Add(txtInput.Text);
						txtInput.Text = "";
					}
					break;
				case "CLR": listBox.Items.Clear(); break;
				case "DEL":
					if (listBox.SelectedIndex != -1) listBox.Items.RemoveAt(listBox.SelectedIndex);
					break;
			}
		}
	}
}
