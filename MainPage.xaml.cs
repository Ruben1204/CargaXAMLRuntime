namespace CargaXAMLRuntime
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();

            string navigationButtonXAML = "<Button Text=\"Navegar\"/>";
            Button navigationButton = new Button().LoadFromXaml(navigationButtonXAML);
            stackLayout.Add(navigationButton);
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            string pageXAML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\nxmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\nx:Class=\"LoadRuntimeXAML.CatalogItemsPage\"\nTitle=\"Catalogo de Elementos\">\n</ContentPage>";

            ContentPage page = new ContentPage().LoadFromXaml(pageXAML);

            Navigation.PushAsync(page);
        }

        private void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            string pageXAML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\nxmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\nx:Class=\"LoadRuntimeXAML.CargaXAMLRuntime\"\nTitle=\"Pagina de Monos\">\n<StackLayout>\n<Button x:Name=\"monkeyName\"\n Text=\"Presiona el Boton\" />\n</StackLayout>\n</ContentPage>";
            ContentPage page = new ContentPage().LoadFromXaml(pageXAML);
            Navigation.PushAsync(page);

            Button miBoton = page.FindByName<Button>("monkeyName");

            miBoton.Clicked += async (sender, e) =>
            {
                await DisplayAlert("Alerta","Es hora de suscribirte y dar un like a este video","ok");
            };

        }
    }

}
