using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace testdrive1.Views
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco); }
        }
    }
    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListagemView()
        {
            InitializeComponent();
            this.Veiculos = new List<Veiculo>
            {
                new Veiculo { Nome = "Azera V6", Preco = 60000 },
                new Veiculo { Nome = "Fiesta", Preco = 50000 },
                new Veiculo { Nome = "HB20 S", Preco = 40000 },
                new Veiculo { Nome = "Ford KA 1.6", Preco = 50000 },
                new Veiculo { Nome = "Honda Fit", Preco = 60000 },
                new Veiculo { Nome = "Honda Civic LXS", Preco = 80000 },
            };
            this.BindingContext = this;
        }
        private void listviewveiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            /*DisplayAlert("Test Drive", string.Format("Você tocou no modelo'{0}', que custa {1}", veiculo.Nome, veiculo.PrecoFormatado), "ok");*/
            Navigation.PushAsync(new DetalheView(veiculo));
        }

       /* private void Button_DisplayAlertSimples(object sender, EventArgs e)
        {
            DisplayAlert("Cadastrado", string.Format("Parabens'{0}', você foi cadastrado com sucesso com o E-mail '{1}' ", nome.Text, email.Text), "OK");
        }*/
    }
}

