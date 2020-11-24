using System;
using System.Collections;
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

namespace Practica4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Sala> salas_list = new List<Sala>();
        List<Asiento> asiestos1 = new List<Asiento>();
        List<Asiento> asiestos2 = new List<Asiento>();
        List<Asiento> asiestos3 = new List<Asiento>();
        List<Asiento> asiestos4 = new List<Asiento>();
        List<Asiento> asiestos5 = new List<Asiento>();
        List<Asiento> asiestos6 = new List<Asiento>();

        



        public MainWindow()
        {
            InitializeComponent();
      
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (peli1.IsVisible)
            {

                peli1.Visibility = Visibility.Hidden;
                peli2.Visibility = Visibility.Hidden;
                peli3.Visibility = Visibility.Hidden;
                anabelle_txt.Visibility = Visibility.Hidden;
                expediente_txt.Visibility = Visibility.Hidden;
                caroline_txt.Visibility = Visibility.Hidden;
                fecha1.Visibility = Visibility.Hidden;
                fecha2.Visibility = Visibility.Hidden;
                fecha3.Visibility = Visibility.Hidden;

                peli4.Visibility = 0;
                peli5.Visibility = 0;
                peli6.Visibility = 0;
                it_txt.Visibility = 0;
                insidious_txt.Visibility = 0;
                aquietplace_txt.Visibility = 0;
                fecha4.Visibility = 0;
                fecha5.Visibility = 0;
                fecha6.Visibility = 0;

            }
            else
            {
                peli1.Visibility = 0;
                peli2.Visibility = 0;
                peli3.Visibility = 0;
                anabelle_txt.Visibility = 0;
                expediente_txt.Visibility =0;
                caroline_txt.Visibility = 0;
                fecha1.Visibility = 0;
                fecha2.Visibility =0;
                fecha3.Visibility =0;

                peli4.Visibility = Visibility.Hidden;
                peli5.Visibility = Visibility.Hidden;
                peli6.Visibility = Visibility.Hidden;
                it_txt.Visibility = Visibility.Hidden;
                insidious_txt.Visibility = Visibility.Hidden;
                aquietplace_txt.Visibility = Visibility.Hidden;
                fecha4.Visibility = Visibility.Hidden;
                fecha5.Visibility = Visibility.Hidden;
                fecha6.Visibility = Visibility.Hidden;
            }
        }

        

        private void fecha_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int cont = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            int cont5 = 0;
            int cont6 = 0;

            ComboBox fecha = sender as ComboBox;
            
            
            if (fecha.Name =="fecha1")
            {
                if (cont == 0)
                {

                    salas_list.Add(new Sala("Sala1", fecha.Text, asiestos1));
                    cont++;

                }
               
                this.Hide();

                var firstEven = salas_list.FirstOrDefault(n => n.nombre_evento.Equals("Sala1"));
                //salas_list.Where(w => w.nombre_evento == "Sala1").ToList().ForEach(s => s.nombre_evento = "libre");
                Salas_cine salas = new Salas_cine(firstEven,this,4,4);

                salas.Show();

            }
            else if (fecha.Name == "fecha2")
            {
                if (cont2 == 0)
                {
                    salas_list.Add(new Sala("Sala2", fecha.Text, asiestos2));
                    cont2++;

                }
                this.Hide();

                var firstEven = salas_list.FirstOrDefault(n => n.nombre_evento.Equals("Sala2"));
                Salas_cine salas = new Salas_cine(firstEven,this,4,4);

                salas.Show();


            }
            else if (fecha.Name == "fecha3")
            {

                if (cont3 == 0)
                {
                    salas_list.Add(new Sala("Sala3", fecha.Text, asiestos3));
                    cont3++;

                }
                this.Hide();

                var firstEven = salas_list.FirstOrDefault(n => n.nombre_evento.Equals("Sala3"));
                Salas_cine salas = new Salas_cine(firstEven,this,4,4);

                salas.Show();


            }
            else if (fecha.Name == "fecha4")
            {

                if (cont4 == 0)
                {
                    salas_list.Add(new Sala("Sala4", fecha.Text, asiestos4));
                    cont4++;

                }
                this.Hide();

                var firstEven = salas_list.FirstOrDefault(n => n.nombre_evento.Equals("Sala4"));
                Salas_cine salas = new Salas_cine(firstEven, this,4,4);

                salas.Show();

            }
            else if (fecha.Name == "fecha5")
            {

                if (cont5 == 0)
                {
                    salas_list.Add(new Sala("Sala5", fecha.Text, asiestos5));
                    cont5++;

                }
                this.Hide();

                var firstEven = salas_list.FirstOrDefault(n => n.nombre_evento.Equals("Sala5"));
                Salas_cine salas = new Salas_cine(firstEven, this,4,4);

                salas.Show();

            }
            else if (fecha.Name == "fecha6")
            {

                if (cont6 == 0)
                {

                    salas_list.Add(new Sala("Sala6", fecha.Text, asiestos6));
                    cont6++;

                }
                this.Hide();

                var firstEven = salas_list.FirstOrDefault(n => n.nombre_evento.Equals("Sala6"));
                Salas_cine salas = new Salas_cine(firstEven,this,4,4);

                salas.Show();

            }







        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           
        }
    }
}
