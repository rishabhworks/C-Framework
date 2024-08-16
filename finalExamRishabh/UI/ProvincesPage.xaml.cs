using finalExamRishabh.BusinessLogic;


namespace finalExamRishabh.UI;

public partial class ProvincesPage : ContentPage
{
	private ProvincesManager _manager;
	public ProvincesPage()
	{
		InitializeComponent();
		_manager = new ProvincesManager();
	}

    private void OnGetDataClicked(object sender, EventArgs e)
    {
        var repository = new Repository();
        
        using var stream = FileSystem.OpenAppPackageFileAsync("provinces.txt").Result;
        using var reader = new StreamReader(stream);

        var provinces = repository.LoadProvinces(reader);

        foreach (var province in provinces)
        {
            _manager.AddProvince(province);
        }

        ProvincesListView.ItemsSource = _manager.Provinces;
    }

    private void OnProvinceSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            var selectedProvince = (Province)e.SelectedItem;
            Navigation.PushAsync(new DetailsPage(selectedProvince));
        }
    }
}