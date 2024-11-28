namespace MauiHybridyApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    
    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        // string cultureName = 
        //     CultureInfo.CurrentCulture.Name=="en-US"?"fr-FR":"en-US";
		      //
        // var aUpdateCultureAction = new UpdateCultureAction(UpdateCulture)
        // {
        //     IsCultureChanged = true, 
        //     Culture = cultureName
        // };
        // await blazorWebView.TryDispatchAsync(serviceProvider =>
        // {
        //     Dispatcher = serviceProvider.GetRequiredService<Fluxor.IDispatcher>();
			     //
        // });
		      //
        // Dispatcher.Dispatch(aUpdateCultureAction); //  Culture changes in Fluxor components
    }
}