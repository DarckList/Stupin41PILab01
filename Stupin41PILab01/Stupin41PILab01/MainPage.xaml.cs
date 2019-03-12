using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stupin41PILab01
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            picker.ItemsSource = new List<string>(itSpesiality);
        }

        int item; 
        string[] itSpesiality = new string[] { "Тестувальник", "Мобільний розробник", "верстальшик","фронтенд","бекенд" };
        string[] requrment = new string[] { "Він займається тестуванням проектів", "він розробляє програми дня мобільних пристроїів",
             "він займається версткою макетів", "він робить усе для фронт розробки", "він робить усе для бекенд розробки" };
         
        private void BtnChange_Clicked(object sender, EventArgs e)
        {
            lblChange.Text = requrment[item];
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = picker.SelectedIndex;
        }
    }
}
