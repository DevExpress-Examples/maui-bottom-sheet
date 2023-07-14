using DevExpress.Maui.Controls;
using Microsoft.Maui.Controls.Maps;

namespace MapAndBottmSheetExample {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void Map_Clicked(object sender, Microsoft.Maui.Controls.Maps.MapClickedEventArgs e){
            
        }
        private void Pin_MarkerClicked(object sender, Microsoft.Maui.Controls.Maps.PinClickedEventArgs e) {
            ((MainViewModel)this.BindingContext).SelectedCity = (CityItem)((Pin)sender).BindingContext;
            bottomSheet.HalfExpandedRatio = 0.6;
            bottomSheet.State = DevExpress.Maui.Controls.BottomSheetState.HalfExpanded;
        }
    }
}