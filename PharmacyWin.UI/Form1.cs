using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PharmacyII.BLL;
using PharmacyII.BLL.Models;
using PharmacyII.BLL.Services;
using PharmacyIII.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyWin.UI
{
    public partial class Form1 : Form
    {

     

        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {

            var x = GlobalConfig.GenericService.GetById(1);
            textBox1.Text = x.GenericName;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
   
        }

    }
}
