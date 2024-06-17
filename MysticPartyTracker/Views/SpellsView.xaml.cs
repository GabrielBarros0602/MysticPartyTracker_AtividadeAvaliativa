using MysticPartyTracker.ViewModels;

namespace MysticPartyTracker.Views;

public partial class SpellsView : ContentPage
{
	public SpellsView()
	{
		InitializeComponent();
		BindingContext = new SpellsViewModel();
	}
}