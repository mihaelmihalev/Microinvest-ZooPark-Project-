using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Models;

namespace ZooPark;
public class BozainiciVM : INotifyPropertyChanged
{


    private readonly BozainiciHandler _bozainiciHandler;
    private CategoryDbContext context;
    private Category selectedCategory;
    private DelegateCommand continueCommand;
    private DelegateCommand selectAnimalsCommand;


    public BozainiciVM()
    {

       _bozainiciHandler = new BozainiciHandler();
       _bozainiciHandler.Add(new Bozainik("Делфин"));
       _bozainiciHandler.Add(new Bozainik("Немска овчарка"));
        
        

    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
