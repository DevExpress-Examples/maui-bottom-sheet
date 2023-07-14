using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MapAndBottmSheetExample {
    public class MainViewModel : BaseViewModel {
        CityItem selectedCity;
        ObservableCollection<CityItem> cities;
        public CityItem SelectedCity {
            get {
                return selectedCity;
            }
            set {
                selectedCity = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<CityItem> Cities {
            get {
                return cities;
            }
            set {
                cities = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel() {
            ObservableCollection<ActionItem> defaultAdditionalActions = new ObservableCollection<ActionItem>() {
                new ActionItem(){ Name = "Restaurants", Color = Color.FromArgb("#669DF7"), IconPath = "restaurant" },
                new ActionItem(){ Name = "Hotels", Color = Color.FromArgb("#ED675C"), IconPath = "hotel" },
                new ActionItem(){ Name = "Gas", Color = Color.FromArgb("#F8CD28"), IconPath = "gas" },
                new ActionItem(){ Name = "Pubs", Color = Color.FromArgb("#59BA77"), IconPath = "pub" },
                new ActionItem(){ Name = "Attractions", Color = Color.FromArgb("#FD9242"), IconPath = "attractions" },
                new ActionItem(){ Name = "Groceries", Color = Color.FromArgb("#FD61B5"), IconPath = "groceries" },
                new ActionItem(){ Name = "Shopping", Color = Color.FromArgb("#AD59F5"), IconPath = "shoppingcart" },
                new ActionItem(){ Name = "More", Color = Color.FromArgb("#4DCDE6"), IconPath = "more" },
            };
            Cities = new ObservableCollection<CityItem>(){
                new CityItem() {
                    Name = "Athens",
                    Location = new Location(37.9838, 23.7275),
                    Address = "Greece",
                    ImagePaths = new ObservableCollection<string>(){ "academyofathens.jpg", "acropolisofathens.jpg", "nationallibraryofgreece.jpg", "templeofhephaestus.jpg", "templeofolympianzeus.jpg", "zappeion.jpg" },
                    Description = "Although there are many other acropoleis in Greece, the significance of the Acropolis of Athens is such that it is commonly known as The Acropolis without qualification. The Acropolis was formally proclaimed as the preeminent monument on the European Cultural Heritage list of monuments on 26 March 2007.",
                    AdditionalActions = defaultAdditionalActions
                },
                new CityItem() {
                    Name = "Paris",
                    Location = new Location(48.8566, 2.3522),
                    Address = "France",
                    ImagePaths = new ObservableCollection<string>(){ "arcdetriomphe.jpg", "eiffeltowe.jpgr", "louvre.jpg", "montmartre.jpg", "notredamedeparis.jpg", "saintechapelle.jpg" },
                    Description = "The Eiffel Tower is a puddle iron lattice tower located on the Champ de Mars in Paris. Built in 1889, it has become both a global icon of France and one of the most recognizable structures in the world.",
                    AdditionalActions = defaultAdditionalActions
                }
            };
        }
    }

    public class CityItem {
        public string Name {
            get;
            set;
        }
        public string Address {
            get;
            set;
        }
        public string Description {
            get;
            set;
        }
        public ObservableCollection<string> ImagePaths {
            get;
            set;
        }
        public Location Location {
            get;
            set;
        }
        public ObservableCollection<ActionItem> AdditionalActions {
            get;
            set;
        }
    }
    public class ActionItem {
        public string Name {
            get;
            set;
        }
        public Microsoft.Maui.Graphics.Color Color {
            get;
            set;
        }
        public string IconPath {
            get;
            set;
        }
    }

    public class BaseViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
