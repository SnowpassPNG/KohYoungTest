﻿using Prism.Commands;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace KohYoungTest
{
    /// <summary>
    /// This is my ViewModel
    /// </summary>
    public class MainVM : Notifier
    {
        #region Delegates and Events
        public ICommand ReverseCmd => new DelegateCommand(DataBind);
        #endregion

        #region Fields
        private string previous = string.Empty;
        #endregion

        #region C'Tor and Deconstructors
        public MainVM()
        {
            Input = new Input();
            Words = new ObservableCollection<Word>();
        }
        #endregion

        #region Public Properties
        private ObservableCollection<Word> word;
        public ObservableCollection<Word> Words
        {
            get { return word; }
            set { word = value; }
        }

        private Input input;
        public Input Input
        {
            get { return input; }
            set {input = value; OnPropertyChanged(nameof(Input));}
        }

        #endregion

        #region Private Methods
        private void DataBind()
        {
            if (string.IsNullOrWhiteSpace(Input.Text))
                return;

            string[] words = Input.Text.Split(' ');

            if (previous.Equals(Input.Text))
                    Array.Reverse(words);
             
            Words.Clear();

            Array.ForEach(words,  word =>  {
                Words.Add(new Word { Text = word, Length = word.Length });
            });
            
            Input.Text = string.Join(" ", words);
            previous = Input.Text;
        }
        #endregion
    }
}