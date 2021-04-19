using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class PlayerCharacter: INotifyPropertyChanged
    {
        private int _health = 100;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Nickname { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
