﻿using JhankaulSainik.ViewModels.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JhankaulSainik.Views.Result
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultAddPage : ContentPage
    {
        public ResultAddPage()
        {
            InitializeComponent();
            BindingContext = new ResultAddViewModel(Navigation);
        }
    }
}