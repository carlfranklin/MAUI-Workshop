# Overview of .NET MAUI

.NET Multi-platform App UI (.NET MAUI) lets you build native apps using a .NET cross-platform UI toolkit that targets the mobile and desktop form factors on Android, iOS, macOS, Windows, and Tizen.

## History

MAUI is the latest incarnation of Xamarin Forms, but written for .NET Core. Xamarin Forms only ran on the .NET Framework. In many ways, MAUI is a rewrite of Xamarin Forms for .NET Core, but XF developers will be happy that most of their known tools are there, and many have been improved.

Xamarin Forms was introduced in May, 2014, as a single XAML-based User Interface for all platforms. The goal was to abstract the UI layer away from platform-specific UI as much as possible. It was a good start, but still required more platform knowledge than most .NET developers had. It was also notoriously delicate to work with in Visual Studio.

Before Xamarin Forms, Xamarin developers had to use native UI constructs for each mobile platform. Many .NET developers with no knowledge of the individual platforms did not use Xamarin because of the learning curve. 

Xamarin, the company, was started in 2011 by Nat Friedman and Miguel De Icaza. Before Xamarin, Miguel created Mono, an open source version of the .NET Framework (2001) that ran on Linux. Although he was reviled by Microsoft at the time (they perceived Linux to be a threat to Windows) his code turned out to be critical to Microsoft in their open-sourcing of C#, which ultimately led to .NET Core. In 2016, Microsoft acquired Xamarin. Terms of the deal were not disclosed, though the Wall Street Journal reported the price at between $400 million and $500 million.

## The MAUI Experience in Visual Studio

Xamarin Forms, and even early versions of MAUI, were plagued by bad first experiences in Visual Studio. I personally taught hands-on Xamarin Forms classes for a few years in a row. Every year I would get all my software up to date and try to build a Xamarin Forms app out of the box. Invariably it would fail for one reason or another. You had to manually download the latest Android SDKs and manage them. Many .NET developers simply didn't know enough about Android to navigate this world.

The .NET MAUI experience is very different. The Visual Studio team has done a great job of ensuring developers that the "Hello World" experience will work on an Android device or emulator right out of the box. Of course, the Windows platform experience is as good as you would expect. The iOS experience, however, requires either a Mac or a provisioned device. That means you need to create a certificate to deploy to a local iOS device for testing. I don't fault Microsoft for making us jump through hoops for iOS testing. Apple's process is simply more controlled than the Android experience, which is a) install the USB driver, b) connect the phone, and c) Run. The iOS and Mac platform personally give me the most grief.

> :point_up: Note: During this workshop we will encounter UI quirks where some things simply don't work the way they should, or work differently (or not at all) on certain platforms. You always have the option of using Blazor (markup and code) instead of XAML. In this workshop, however, we will stick with XAML.

## Controls

The user interface of a .NET Multi-platform App UI (.NET MAUI) app is constructed of objects that map to the native controls of each target platform.

The main control groups used to create the user interface of a .NET MAUI app are **pages**, **layouts**, and **views**. 

A .NET MAUI page generally occupies the full screen or window. The page usually contains a layout, which contains views and possibly other layouts. 

Pages, layouts, and views derive from the [VisualElement](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.visualelement) class. This class provides a variety of properties, methods, and events that are useful in derived classes.

#### Pages

.NET MAUI apps consist of one or more **pages**. A page usually occupies all of the screen, or window, and each page typically contains at least one layout.

.NET MAUI contains the following pages:

- ContentPage
- FlyoutPage
- NavigationPage
- TabbedPage

#### Layouts

.NET MAUI **layouts** are used to compose user-interface controls into visual structures, and each layout typically contains multiple views. Layout classes typically contain logic to set the position and size of child elements.

.NET MAUI contains the following **layouts**:

- AbsoluteLayout
- BindableLayout
- FlexLayout
- Grid
- HorizontalStackLayout
- StackLayout
- VerticalStackLayout

#### Views

.NET MAUI **views** are the UI objects such as labels, buttons, and sliders that are commonly known as *controls* or *widgets* in other environments.

.NET MAUI contains the following **views**:

- ActivityIndicator
- BlazorWebView
- Border
- BoxView
- Button
- CarouselView
- CheckBox
- CollectionView
- ContentView
- DatePicker
- Editor
- Ellipse
- Entry
- Frame
- GraphicsView
- Image
- ImageButton
- IndicatorView
- Label
- Line
- ListView
- Map
- Path
- Picker
- Polygon
- Polyline
- ProgressBar
- RadioButton
- Rectangle
- RefreshView
- RoundRectangle
- ScrollView
- SearchBar
- Slider
- Stepper
- SwipeView
- Switch
- TableView
- TimePicker
- TwoPaneView
- WebView

For more details about MAUI controls check out [https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/?view=net-maui-7.0](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/?view=net-maui-7.0)
