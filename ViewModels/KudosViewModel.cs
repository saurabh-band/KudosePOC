using KudosePOC.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KudosePOC.ViewModels
{
    public class KudosViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<KudosItem> _kudosList = new();
        private ObservableCollection<KudosItem> _myTeamKudosList = new();
        private ObservableCollection<KudosItem> _allKudosList = new();

        private ObservableCollection<KudosItem> _displayList = new();

        private int _selectedSegmentIndex;

        public KudosViewModel()
        {
            GetKudosData();
            _selectedSegmentIndex = 0;
        }
        public ObservableCollection<KudosItem> KudosList
        {
            get => _kudosList;
            set { _kudosList = value; OnPropertyChanged(); }
        }

        public ObservableCollection<KudosItem> MyTeamKudosList
        {
            get => _myTeamKudosList;
            set { _myTeamKudosList = value; OnPropertyChanged(); }
        }

        public ObservableCollection<KudosItem> AllKudosList
        {
            get => _allKudosList;
            set { _allKudosList = value; OnPropertyChanged(); }
        }
        public ObservableCollection<KudosItem> DisplayedKudosList
        {
            get => _displayList;
            set { _displayList = value; OnPropertyChanged(); }
        }

        public int SelectedSegmentIndex
        {
            get => _selectedSegmentIndex;
            set
            {
                _selectedSegmentIndex = value;
                OnPropertyChanged();
                UpdateDisplayedKudosList();
            }
        }


        private void UpdateDisplayedKudosList()
        {
            switch (SelectedSegmentIndex)
            {
                case 0:
                    DisplayedKudosList = new ObservableCollection<KudosItem>(KudosList);
                    break;
                case 1:
                    DisplayedKudosList = new ObservableCollection<KudosItem>(MyTeamKudosList);
                    break;
                case 2:
                    DisplayedKudosList = new ObservableCollection<KudosItem>(AllKudosList);
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void GetKudosData()
        {
            KudosList.Add(new KudosItem { ImageURL = "iconfirst.png", ReceiverName = "Sophie Daltrey", GiverName = "Rosie Atkinson gave kudos to", Date = new DateOnly(2023, 6, 23) });
            KudosList.Add(new KudosItem { ImageURL = "iconsecond.png", ReceiverName = "Rose Daltrey", GiverName = "Sam Mills gave kudos to", Date = new DateOnly(2024, 5, 9) });
            KudosList.Add(new KudosItem { ImageURL = "iconthird.png", ReceiverName = "Rose Daltrey", GiverName = "Wendy Askewth gave kudos to", Date = new DateOnly(2024, 2, 10) });

            // Populate MyTeamKudosList (sample data)
            MyTeamKudosList.Add(new KudosItem { ImageURL = "iconfirst.png", ReceiverName = "Kevin Baker", GiverName = "Susan Barry gave kudos to", Date = new DateOnly(2023, 6, 23) });
            MyTeamKudosList.Add(new KudosItem { ImageURL = "iconsecond.png", ReceiverName = "Joe Blade", GiverName = "Sam curren gave kudos to", Date = new DateOnly(2024, 5, 9) });
            MyTeamKudosList.Add(new KudosItem { ImageURL = "iconthird.png", ReceiverName = "Kevin Piterson", GiverName = "Klassen jade gave kudos to", Date = new DateOnly(2024, 2, 10) });
            MyTeamKudosList.Add(new KudosItem { ImageURL = "iconfirst.png", ReceiverName = "Anderson Ratte", GiverName = "Michel Alterdon gave kudos to", Date = new DateOnly(2023, 6, 23) });
            MyTeamKudosList.Add(new KudosItem { ImageURL = "iconsecond.png", ReceiverName = "Peter Barnes", GiverName = "Rayan baat kudos to", Date = new DateOnly(2024, 5, 9) });

            // Populate AllKudosList (sample data)
            AllKudosList.Add(new KudosItem { ImageURL = "iconthird.png", ReceiverName = "User 3", GiverName = "User Z gave kudos to", Date = new DateOnly(2024, 2, 10) });
            AllKudosList.Add(new KudosItem { ImageURL = "iconfirst.png", ReceiverName = "Kevin Baker", GiverName = "Susan Barry gave kudos to", Date = new DateOnly(2023, 6, 23) });
            AllKudosList.Add(new KudosItem { ImageURL = "iconsecond.png", ReceiverName = "Joe Blade", GiverName = "Sam curren gave kudos to", Date = new DateOnly(2024, 5, 9) });
            AllKudosList.Add(new KudosItem { ImageURL = "iconthird.png", ReceiverName = "Kevin Piterson", GiverName = "Klassen jade gave kudos to", Date = new DateOnly(2024, 2, 10) });
            AllKudosList.Add(new KudosItem { ImageURL = "iconfirst.png", ReceiverName = "Sophie Daltrey", GiverName = "Rosie Atkinson gave kudos to", Date = new DateOnly(2023, 6, 23) });
            AllKudosList.Add(new KudosItem { ImageURL = "iconsecond.png", ReceiverName = "Rose Daltrey", GiverName = "Sam Mills gave kudos to", Date = new DateOnly(2024, 5, 9) });
            AllKudosList.Add(new KudosItem { ImageURL = "iconthird.png", ReceiverName = "Rose Daltrey", GiverName = "Wendy Askewth gave kudos to", Date = new DateOnly(2024, 2, 10) });
            AllKudosList.Add(new KudosItem { ImageURL = "iconfirst.png", ReceiverName = "Anderson Ratte", GiverName = "Michel Alterdon gave kudos to", Date = new DateOnly(2023, 6, 23) });
        }
    }
}
