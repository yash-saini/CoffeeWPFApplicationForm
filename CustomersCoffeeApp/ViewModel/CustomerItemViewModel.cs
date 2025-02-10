﻿using CustomersCoffeeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersCoffeeApp.ViewModel
{
    public class CustomerItemViewModel : ValidationViewModelBase
    {
        private readonly Customer _model;
        public CustomerItemViewModel(Customer model)
        {
            _model = model;      
        }

        public int ID { get; set; }

        public string FirstName

        {
            get => _model.FirstName;
            set
            {
                _model.FirstName = value;
                RaisePropertyChanged();
                if (string.IsNullOrWhiteSpace(value))
                {
                    AddError("First Name is required");
                }
                else
                {
                    ClearErrors();
                }
            }
        }

        public string LastName
        {
            get => _model.LastName;
            set
            {
                _model.LastName = value;
                RaisePropertyChanged();
                if (string.IsNullOrWhiteSpace(value))
                {
                    AddError("Last Name is required");
                }
                else
                {
                    ClearErrors();
                }
            }
        }

       public bool IsDeveloper
        {
            get => _model.IsDeveloper;
            set
            {
                _model.IsDeveloper = value;
                RaisePropertyChanged();
            }
        }

    }
}
