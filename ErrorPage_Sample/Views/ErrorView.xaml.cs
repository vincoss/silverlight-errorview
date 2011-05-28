using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ErrorPage_Sample.Models;


namespace ErrorPage_Sample.Views
{
    public partial class ErrorView : UserControl
    {
        public ErrorView()
        {
            InitializeComponent();

            this.DataContext = new ErrorViewModel(GenerateException(), "Sample Version: 1.0, Is Release Version : false");
        }

        private Exception GenerateException()
        {
            Exception exception = null;
            try
            {
                int i = 0;
                int result = 10 / i;

            }
            catch (Exception ex)
            {
                exception = ex;
            }
            return exception;
        }
    }
}
