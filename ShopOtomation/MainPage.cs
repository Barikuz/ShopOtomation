using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ShopOtomation.CommonFunctions;

namespace ShopOtomation
{
    public partial class MainPage : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainPage()
        {
            InitializeComponent();
            FormClosing += Page_FormClosing;
        }
    }
}
