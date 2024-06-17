using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class SpellsViewModel : ObservableObject
    {
        private readonly RestService _restservice;

        public SpellsViewModel() 
        {
            _restservice = new RestService();
            GetPostagemAsyncCommand = new Command(async () => await GetPostagemAsync());
        }

        [ObservableProperty]
        private int _index;

        [ObservableProperty]
        private int _name;

        [ObservableProperty]
        private string _level;

        [ObservableProperty]
        private string _url;

        public ICommand GetPostagemAsyncCommand { get; }

        [ObservableProperty]
        private ObservableCollection<Postagem> _postagens = new ObservableCollection<Postagem>();

        public async Task GetPostagemAsync()
        {
            Postagens = await _restservice.GetPostagensAsync();
        }
    }
}
