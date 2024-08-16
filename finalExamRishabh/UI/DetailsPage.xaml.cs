using finalExamRishabh.BusinessLogic;

namespace finalExamRishabh.UI;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Province province)
	{
		InitializeComponent();

        ProvinceName.Text = $"Name: {province.Name}";
        ProvinceCapital.Text = $"Capital: {province.Capital}";
        ProvinceDescription.Text = $"Description: {province.Description}";
        ProvincePopulation.Text = $"Population: {province.Population}";
        ProvinceFlag.Source = province.Flag;
    }
}