using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoshaverAmlak
{
    public partial class Aparteman : Form
    {
        public Aparteman()
        {
            InitializeComponent();
        }

        private void Aparteman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amlakDataSet.Aparteman' table. You can move, or remove it, as needed.
            this.apartemanTableAdapter.Fill(this.amlakDataSet.Aparteman);
            // TODO: This line of code loads data into the 'amlakDataSet1.Aparteman' table. You can move, or remove it, as needed.
            this.apartemanTableAdapter.Fill(this.amlakDataSet.Aparteman);

        }
    }
}
