using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KohYoungTest
{
    public class Word
    {
        public string Text { get; set; }
        public int Length { get; set; }
    }

    public class Input : Notifier
    {

        private string input;
        public string Text { get { return input; } set { input = value; OnPropertyChanged(nameof(Text)); } }
    }

}
