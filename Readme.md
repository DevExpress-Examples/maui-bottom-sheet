<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/619814269/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1156269)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DevExpress Bottom Sheet for .NET MAUI

This example shows how you can use our [BottomSheet](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet?v=23.1) control to implement a master-detail view. The detail view includes a list ([CollectionView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/collectionview/?view=net-maui-7.0)) and custom buttons ([SimpleButtons](https://docs.devexpress.com/Maui/DevExpress.Maui.Controls.SimpleButton)).

<img src="https://user-images.githubusercontent.com/12169834/227953850-11c0d7cc-e6c5-49ec-ac59-80837663c0d0.png" width="30%"/>

## Requirements

Please register the DevExpress NuGet Gallery in Visual Studio to restore NuGet packages used in this solution. See the following topic for more information: [Get Started with DevExpress Mobile UI for .NET MAUI](https://docs.devexpress.com/MAUI/403249/get-started).

You can also refer to the following YouTube video for more information on how to get started with the DevExpress .NET MAUI Controls: [Setting up a .NET MAUI Project](https://www.youtube.com/watch?v=juJvl5UicIQ).

## Implementation Details

* Handle the [CollectionView.SelectionChanged](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.selectableitemsview.selectionchanged?view=net-maui-7.0) event and set the [BottomSheet.State](https://docs.devexpress.com/Maui/DevExpress.Maui.Controls.BottomSheet.State?v=23.1) and [BottomSheet.HalfExpandedRatio](https://docs.devexpress.com/Maui/DevExpress.Maui.Controls.BottomSheet.HalfExpandedRatio?v=23.1) properties to expand the bottom sheet when a user selects an item.
* Handle the [CollectionView.Scrolled](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.itemsview.scrolled?view=net-maui-7.0) event and decrease the [BottomSheet.HalfExpandedRatio](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet.HalfExpandedRatio?v=23.1) property value to adjust the bottom sheet height and give users more space to observe the master view.
* Bind the detail [CollectionView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/collectionview/?view=net-maui-7.0) to the master's  [CollectionView.SelectedItem](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.selectableitemsview.selecteditem?view=net-maui-7.0) property to populate the detail collection.

## Files to Review

<!-- default file list -->
* [MainPage.xaml](./CS/MainPage.xaml)
* [MainPage.xaml.cs](./CS/MainPage.xaml.cs)
* [MainViewModel.cs](./CS/MainViewModel.cs)
* [Converters.cs](./CS/Converters.cs)
* [App.xaml](./CS/App.xaml)
<!-- default file list end -->

## Documentation

- [BottomSheet](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet?v=23.1)
- [SimpleButtons](https://docs.devexpress.com/Maui/DevExpress.Maui.Controls.SimpleButton)

## More Examples

* [Stocks App](https://github.com/DevExpress-Examples/maui-stocks-mini)
* [Demo Application](https://github.com/DevExpress-Examples/maui-demo-app)
