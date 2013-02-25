using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NabazRemote.Controllers.ViewInterfaces;
using NabazRemote.Controllers;
using NabazRemote.Domain;

namespace NabazRemote.GUI
{
    public partial class NabaztagList : UserControl, NabaztagView
    {
        public NabaztagList()
        {
            InitializeComponent();
        }

        void NabaztagView.AttachController(NabaztagController controller)
        {
            this.controller = controller;
        }

        void NabaztagView.Refresh()
        {
            checkedListBox.Items.Clear();
            IList<Nabaztag> nabaztags = controller.ListNabaztag();
            foreach (Nabaztag tag in nabaztags)
            {
                checkedListBox.Items.Add(tag.Name, false);
            }

        }

        NabaztagController controller;
    }
}
