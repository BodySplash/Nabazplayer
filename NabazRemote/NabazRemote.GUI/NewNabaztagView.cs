using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NabazRemote.GUI;
using NabazRemote.Controllers.ViewInterfaces;
using NabazRemote.Controllers;
using NabazRemote.Domain;

namespace NabazRemote.GUI
{
    public partial class NewNabaztagView : UserControl, NabazRemote.Controllers.ViewInterfaces.NabaztagView
    {
        public NewNabaztagView()
        {
            InitializeComponent();
        }

        //string NabazRemote.Controllers.ViewInterfaces.NewNabaztagView.Name
        //{
        //    get { return textBoxName.Text; }
        //}

        //string NabazRemote.Controllers.ViewInterfaces.NewNabaztagView.SerialNumber
        //{
        //    get { return textBoxSerial.Text ; }
        //}

        //string NabazRemote.Controllers.ViewInterfaces.NewNabaztagView.Token
        //{
        //    get { return textBoxToken.Text; }
        //}

        void NabazRemote.Controllers.ViewInterfaces.NabaztagView.AttachController(NabaztagController controller)
        {
            this.controller = controller;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Nabaztag tag = new Nabaztag();
            tag.Name = textBoxName.Text;
            tag.SerialNumber = textBoxSerial.Text;
            tag.Token = textBoxToken.Text;
            controller.AddNabaztag(tag);
        }

        private NabaztagController controller;
    }
}
