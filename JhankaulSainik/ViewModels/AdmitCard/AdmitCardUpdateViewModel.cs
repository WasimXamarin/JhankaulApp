﻿using JhankaulSainik.ConstantFunction;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JhankaulSainik.ViewModels.AdmitCard
{
    public class AdmitCardUpdateViewModel : BaseViewModel
    {
        public INavigation Navigation { get; }
        public AdmitCardUpdateViewModel(INavigation navigation)
        {
            Title = "Admit Card Update";
            Navigation = navigation;
        }
        public Command EnglishCommand
        {
            get
            {
                return new Command(OnEnglishCommandClicked);
            }
        }

        private void OnEnglishCommandClicked(object obj)
        {
            ToastClass.EnglishLanguageMethod();
        }
        public Command HindiCommand
        {
            get
            {
                return new Command(OnHindiCommandClicked);
            }
        }

        private void OnHindiCommandClicked(object obj)
        {
            ToastClass.HindiLanguageMethod();
        }
    }
}
