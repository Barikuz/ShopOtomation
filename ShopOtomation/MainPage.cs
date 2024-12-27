using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using static ShopOtomation.CommonFunctions;

namespace ShopOtomation
{
    public partial class MainPage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainPage()
        {
            InitializeComponent();
            FormClosing += Page_FormClosing;
        }
    }
}