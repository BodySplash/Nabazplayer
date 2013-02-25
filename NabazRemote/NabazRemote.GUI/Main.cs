using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NabazRemote.Controllers;
using NabazRemote.MemoryRepositories;

namespace NabazRemote.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            NabaztagController controller = new NabaztagController();
            controller.Repository = new MemNabaztagRepository();
            controller.AttachView(newNabaztagView1);
            controller.AttachView(nabaztagList1);

        }
    }
}