using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NabazRemote.Controllers.ViewInterfaces;
using NabazRemote.Controllers;

namespace NabazRemote.NewGui
{
    /// <summary>
    /// Interaction logic for NewNabaztagView.xaml
    /// </summary>
    public partial class NewNabaztagView : UserControl, NabaztagView
    {
        public NewNabaztagView()
        {
            InitializeComponent();
        }

        #region NabaztagView Members

        public void AttachController(NabaztagController controller)
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
