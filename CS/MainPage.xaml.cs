using DevExpress.Maui.Controls;
using DevExpress.Maui.CollectionView;

namespace MasterDetailBottomSheet {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }
        private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e) {
            if (bottomSheet.HalfExpandedRatio == 0.4) bottomSheet.Animate("bottomsheet", x=>bottomSheet.HalfExpandedRatio=x, 0.4, 0.2);
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            bottomSheet.State = BottomSheetState.HalfExpanded;
            if (bottomSheet.HalfExpandedRatio == 0.2) bottomSheet.Animate("bottomsheet", x=>bottomSheet.HalfExpandedRatio=x, 0.2, 0.4);
        }
    }
}