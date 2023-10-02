using System.Collections.ObjectModel;
using System.Windows;

namespace WPFListviewAlternatingRowColors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> _PersonCollection = new ObservableCollection<Person>();

        public MainWindow()
        {
            PersonCollection.Add(new Person() { Name = "test1", Address = "Guam", Contact = "test1@mail.com" });
            PersonCollection.Add(new Person() { Name = "test2", Address = "Guam", Contact = "test1@mail.com" });
            PersonCollection.Add(new Person() { Name = "test3", Address = "Hongkong", Contact = "test1@mail.com" });
            PersonCollection.Add(new Person() { Name = "test4", Address = "Guam", Contact = "test1@mail.com" });
            PersonCollection.Add(new Person() { Name = "test5", Address = "Moscow", Contact = "test1@mail.com" });

            this.DataContext = this;

            InitializeComponent();
        }

        public ObservableCollection<Person> PersonCollection
        {
            get
            {
                return _PersonCollection;
            }
        }
    }
}
