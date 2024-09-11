using C1.DataCollection;
using C1.DataCollection.BindingList;
using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static C1.Util.Win.Win32;

namespace TestFlexGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Company c = new Company();

            C1DataCollection<Company> c1Data = new C1DataCollection<Company>(c.Companies());
            C1DataCollectionBindingList binding = new C1DataCollectionBindingList(c1Data);

            grid.DataSource = binding;

        }
    }
}
