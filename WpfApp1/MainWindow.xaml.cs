using System;
using System.Windows;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;


namespace WpfApp1
{
	/// <summary>
	/// Logika interakcji dla klasy MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Matrix<double> A = DenseMatrix.OfArray(new double[,] {
				{
				Double.Parse(cell1.Text), Double.Parse(cell2.Text), Double.Parse(cell3.Text), Double.Parse(cell4.Text), Double.Parse(cell5.Text)
				},
				{
				Double.Parse(cell6.Text), Double.Parse(cell7.Text), Double.Parse(cell8.Text), Double.Parse(cell9.Text), Double.Parse(cell10.Text)
				},
				{
				Double.Parse(cell11.Text), Double.Parse(cell12.Text), Double.Parse(cell13.Text), Double.Parse(cell14.Text), Double.Parse(cell15.Text)
				},
				{
				Double.Parse(cell16.Text), Double.Parse(cell17.Text), Double.Parse(cell18.Text), Double.Parse(cell19.Text), Double.Parse(cell20.Text)
				},
				{
				Double.Parse(cell21.Text), Double.Parse(cell22.Text), Double.Parse(cell23.Text), Double.Parse(cell24.Text), Double.Parse(cell25.Text)
				}
			});

			result1.Text = A.Determinant().ToString();
		}
	}
}
