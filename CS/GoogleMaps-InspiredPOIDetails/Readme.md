# Google Maps-Inspired POI Details

This example uses the DevExpress [BottomSheet](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet) control to replicate POI (point of interest) details from Google Maps. The detail view includes an image gallery, action buttons, and description.

<img src="https://github.com/DevExpress-Examples/maui-bottom-sheet/assets/12169834/20ae4825-4c89-4346-8730-f0481c233714" width="30%"/>


## Requirements

Please register the DevExpress NuGet Gallery in Visual Studio to restore NuGet packages used in this solution. See the following topic for more information: [Get Started with DevExpress Mobile UI for .NET MAUI](https://docs.devexpress.com/MAUI/403249/get-started).

You can also refer to the following YouTube video for more information on how to get started with the DevExpress .NET MAUI Controls: [Setting up a .NET MAUI Project](https://www.youtube.com/watch?v=juJvl5UicIQ).

## Implementation Details

* The **Map Control** displays Google Maps. Refer to the following Microsoft documentation topic for more information on the [Map Control](https://docs.microsoft.com/en-us/dotnet/maui/user-interface/controls/map). 
* This example uses a Google API key with a limited number of API calls. Refer to the following topic for more information on how to set up your Google API key: [Set up your Google Cloud project](https://developers.google.com/maps/documentation/android-sdk/cloud-setup).
* The following code gets POIs (points of interest) from the *Cities* collection and adds them to the Map control: 
    ```xml
    <maps:Map ItemsSource="{Binding Cities}">
        <maps:Map.ItemTemplate>
            <maps:Pin Label="{Binding Name}" Location="{Binding Location}" MarkerClicked="Pin_MarkerClicked" Type="Place"/>
        </maps:Map.ItemTemplate>
    </maps:Map>
    ``` 
* Set the [State](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet.State) property to *HalfExpanded* on the POI click to display the BottomSheet with POI details. Use the [HalfExpandedRatio](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet.HalfExpandedRatio) property to define the BottomSheet's height in *HalfExpanded* state.
* The [BindableLayout.ItemsSource](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/layouts/bindablelayout) property fills the container (a [FlexLayout](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/layouts/flexlayout) in this demo) with items from the bound collection. The project uses the property to display items from the *Places* collection as buttons. The [FlexLayout.Basis](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.flexlayout.basisproperty?view=net-maui-8.0) attached property specifies the width of layout items within the container.
  
    ```xml
    <BindableLayout.ItemTemplate>
        <DataTemplate x:DataType="{x:Type local:ActionItem}">
            <dx:DXStackLayout Orientation="Vertical" Margin="5" HorizontalOptions="Center" FlexLayout.Basis="25%">
                <!-- ... -->
            </dx:DXStackLayout>
        </DataTemplate>
    </BindableLayout.ItemTemplate>
    ```

## Files to Review

<!-- default file list -->
* [MainPage.xaml](MainPage.xaml)
* [MainPage.xaml.cs](MainPage.xaml.cs)
* [MainViewModel.cs](MainViewModel.cs)
<!-- default file list end -->

## Documentation

- [Featured Scenarios: Google Maps-Inspired POI Details](https://docs.devexpress.com/MAUI/404467/)
- [More Featured Scenarios](https://docs.devexpress.com/MAUI/404291/scenarios)
- [BottomSheet](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet)
- [DXButton](https://docs.devexpress.com/MAUI/DevExpress.Maui.Core.DXButton)

## More Examples

* [Stocks App](https://github.com/DevExpress-Examples/maui-stocks-mini)
* [Demo Application](https://github.com/DevExpress-Examples/maui-demo-app)
