using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private List<Superheroe> superLista = Superheroe.GetSamples();

        public event PropertyChangedEventHandler PropertyChanged;

        private Superheroe superActual;

        public Superheroe SuperActual
        {
            get { return superActual; }
            set { superActual = value;
                this.NotifyPropertyChanged("superActual");
            }
        }
        private int contadorActual;
        public int ContadorActual
        {
            get { return contadorActual; }
            set
            {
                contadorActual = value;
                this.NotifyPropertyChanged("contadorActual");
            }
        }
        private int totalHeroes;
        public int TotalHeroes
        {
            get { return totalHeroes; }
            set
            {
                totalHeroes = value;
                this.NotifyPropertyChanged("totalHeroes");
            }
        }
       

        public MainWindowVM()
        {
            SuperActual = superLista[0];
            ContadorActual = 1;
            TotalHeroes = superLista.Count;
        }

        public void Avanzar()
        {
            if (ContadorActual<TotalHeroes)
            {
                ContadorActual++;
                SuperActual = superLista[ContadorActual - 1];
            }
            
        }

        public void Retroceder()
        {
            if (ContadorActual > 1)
            {
                ContadorActual--;
                SuperActual = superLista[ContadorActual - 1];
            }

        }
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
