using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ZooPark.Models;
using ZooPark.Views;

namespace ZooPark
{

    public class WelcomeVM : INotifyPropertyChanged
    {

        
        private readonly CategoryHandler _categoryHandler;
        private readonly BozainiciHandler _bozainiciHandler;
        private CategoryDbContext context;
        private Category selectedCategory;
        private DelegateCommand continueCommand;
        private DelegateCommand selectAnimalsCommand;
        private DelegateCommand selectEventsCommand;



        public WelcomeVM()
        {

            _categoryHandler = new CategoryHandler();
            _categoryHandler.Add(new Category("Бозайници"));
            _categoryHandler.Add(new Category("Хищници"));
            _categoryHandler.Add(new Category("Влечуги"));
            _bozainiciHandler = new BozainiciHandler();
            _bozainiciHandler.Add(new Bozainik("Делфин"));
            _bozainiciHandler.Add(new Bozainik("Немска овчарка"));


        }
        public ICommand SelectEventsCommand
        {
            get
            {
                return selectEventsCommand ?? (selectEventsCommand = new DelegateCommand(() =>
                {
                    Categories.Clear();
                }));
            }
        }
        public List<Category> Categories
        {
            get { return _categoryHandler.Categories; }
        }

       
        public ICommand ContinueCommand
        {
            get
            {
                
                {
                    return continueCommand ?? (continueCommand = new DelegateCommand(() =>
                    {
                        if (SelectedCategory.Equals("Бозайници")){
                            {
                                Bozainici window = new Bozainici();
                                window.Show();


                            }
                        } }));
                }
            }
        }
        public Category SelectedCategory
        {
            get
            {
                return selectedCategory;
            }
            set
            {
                selectedCategory = value;
                OnPropertyChanged("SelectedCategory");
            }
        }

        private void OnPropertyChanged(string v)
        {
           
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        


    }
}
