# DevExpress Bottom Sheet for .NET MAUI

This example shows you how to use our [BottomSheet](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet?v=23.1) control to implement a master-detail view. The detail view includes a detail list ([CollectionView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/collectionview/?view=net-maui-7.0)) and custom buttons ([SimpleButtons](https://docs.devexpress.com/Maui/DevExpress.Maui.Controls.SimpleButton)).

## Requirements

Please register the DevExpress NuGet Gallery in Visual Studio to restore the NuGet packages used in this solution. See the following topic for more information: [Get Started with DevExpress Mobile UI for .NET MAUI](https://docs.devexpress.com/MAUI/403249/get-started).

You can also refer to the following YouTube video for more information on how to get started with the DevExpress .NET MAUI Controls: [Setting up a .NET MAUI Project](https://www.youtube.com/watch?v=juJvl5UicIQ).

## Implementation Details

* Handle the [CollectionView.SelectionChanged)[https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.selectableitemsview.selectionchanged?view=net-maui-7.0] event to and set the [BottomSheet.State](https://docs.devexpress.com/Maui/DevExpress.Maui.Controls.BottomSheet.State?v=23.1) and [BottomSheet.HalfExpandedRatio](https://docs.devexpress.com/Maui/DevExpress.Maui.Controls.BottomSheet.HalfExpandedRatio?v=23.1) properties to exoand the bottom sheet when a user selectes an item.
* Handle the [CollectionView.Scrolled)[https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.itemsview.scrolled?view=net-maui-7.0] event and decrease the [BottomSheet.HalfExpandedRatio](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet.HalfExpandedRatio?v=23.1) property to adjust the bottom sheet height and give users more space to observe the master view items.
* Bind the detail [CollectionView](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/collectionview/?view=net-maui-7.0) to the master's  [CollectionView.SelectedItem](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.selectableitemsview.selecteditem?view=net-maui-7.0) property to populate a collection of details.

## How to Run This Application

1. Install Visual Studio 2022 and the latest .NET MAUI version. See the following topic on docs.microsoft.com for more information: [Installation](https://docs.microsoft.com/en-gb/dotnet/maui/get-started/installation).
1. Register [your personal NuGet feed](https://nuget.devexpress.com/) in Visual Studio:

   > If you are an active [DevExpress Universal](https://www.devexpress.com/subscriptions/universal.xml) customer, DevExpress Controls for .NET MAUI are available in your [personal NuGet feed](https://nuget.devexpress.com/).
    
    See the following topic on docs.microsoft.com for more information on how to register a NuGet source: [Install and manage packages in Visual Studio](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio#package-sources).

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
