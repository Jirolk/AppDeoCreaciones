using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeoCreaciones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            iniciarApp();
        }
        protected override void OnAppearing()
        {
            txtCopia1.Focus();
        }

        public void iniciarApp()
        {
            int precio = 150;

            DateTime dia = DateTime.Now;

            //DisplayAlert("dia ", dia.ToString("dddd"), "OK");

            if(dia.ToString("dddd")=="sábado"|| dia.ToString("dddd") == "domingo")
            {
                precio = 300;
            }



            txtprecio.Text = precio.ToString();
            
            //txtCopia1.Text = "0";
           // txtCantCopia1.Text = "0";
            
        }

       
        public  void Calculo()
        {

            int copias1 = 0;
            int Cantcopias1 = 0;
            int copias2 = 0;
            int Cantcopias2 = 0;
            int copias3 = 0;
            int Cantcopias3 = 0;
            int precio = 0;
            int sumaTotal = 0;

            if (!string.IsNullOrEmpty(txtprecio.Text))
            {
                precio = int.Parse(txtprecio.Text);
            }
                 
            
            if (string.IsNullOrEmpty(txtCantCopia1.Text)|| string.IsNullOrEmpty(txtCopia1.Text)){
                copias1 = 0;
                Cantcopias1 = 0;
                
            }
            else
            {
                copias1 = int.Parse(txtCopia1.Text);
                Cantcopias1 = int.Parse(txtCantCopia1.Text);
            }

            if (string.IsNullOrEmpty(txtCantCopia2.Text) || string.IsNullOrEmpty(txtCopia2.Text))
            {
                copias2 = 0;
                Cantcopias2 = 0;
               
            }
            else
            {
               copias2 = int.Parse(txtCopia2.Text);
                Cantcopias2 = int.Parse(txtCantCopia2.Text);
            }


            if (string.IsNullOrEmpty(txtCantCopia3.Text) || string.IsNullOrEmpty(txtCopia3.Text))
            {
                copias3 = 0;
                Cantcopias3 = 0;
                
            }
            else
            {
                copias3 = int.Parse(txtCopia3.Text);
                Cantcopias3 = int.Parse(txtCantCopia3.Text);
            }




            
            int total1 = copias1 * Cantcopias1;
            int total2 = copias2 * Cantcopias2;
            int total3 = copias3 * Cantcopias3;
            int totalCopias = total1 + total2 + total3;
            sumaTotal = (total1+total2+total3)*precio;

            NumberFormatInfo formato = new CultureInfo("es-PY").NumberFormat;
            formato.CurrencyGroupSeparator = ".";

            lblTotal.Text=sumaTotal.ToString("C",formato);
           lblCantCopias.Text=totalCopias.ToString("N",formato);
                       
            txtTotal1.Text = total1.ToString();
            txtTotal2.Text = total2.ToString();
            txtTotal3.Text = total3.ToString();



            //await DisplayAlert("hola", total.ToString(), "OK");
        }

        private void txtCopia1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculo();
        }

        private void txtCantCopia1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculo();
        }

        private void Refescar_Refreshing(object sender, EventArgs e)
        {
            txtCopia1.Text = "";
            txtCantCopia1.Text = "";
            txtCopia2.Text = "";
            txtCantCopia2.Text = "";
            txtCopia3.Text = "";
            txtCantCopia3.Text = "";

            txtCopia1.Focus();
            Refescar.IsRefreshing = false;
        }

        private void txtCopia2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculo();
        }

        private void txtCantCopia2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculo();
        }

        private void txtCopia3_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculo();
        }

        private void txtCantCopia3_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculo();
        }

        private void txtprecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculo();
        }

        private void txtCopia1_Completed(object sender, EventArgs e)
        {
            txtCantCopia1.Focus();
        }

        private void txtCantCopia1_Completed(object sender, EventArgs e)
        {
            txtCopia2.Focus();
        }

        private void txtCopia2_Completed(object sender, EventArgs e)
        {
            txtCantCopia2.Focus();
        }

        private void txtCantCopia2_Completed(object sender, EventArgs e)
        {
            txtCopia3.Focus();
        }

        private void txtCopia3_Completed(object sender, EventArgs e)
        {
            txtCantCopia3.Focus();
        }

        private void txtCantCopia3_Completed(object sender, EventArgs e)
        {

        }
    }
}
