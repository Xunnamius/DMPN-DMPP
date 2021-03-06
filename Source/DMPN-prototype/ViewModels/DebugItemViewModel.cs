﻿using System;
using System.ComponentModel;

namespace DMPN_prototype.ViewModels
{
    public class DebugItemViewModel : INotifyPropertyChanged 
    {
        private string _Title, _Data;

        /// <summary>
        /// Title associated with this debug entry
        /// </summary>
        /// <returns>Title of the debug entry</returns>
        public string Title
        {
            get 
            {
                return _Title;
            }

            set 
            {
                _Title = value;
                NotifyPropertyChanged("Title");
            }
        }
        
        /// <summary>
        /// Data (toString()ed) associated with this debug entry
        /// </summary>
        /// <returns>Debug data</returns>
        public string Data
        {
            get
            {
                return _Data;
            }

            set
            {
                _Data = value.ToString();
                NotifyPropertyChanged("Data");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName) 
        {
            if (null != PropertyChanged) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}