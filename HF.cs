using PoorEgybest.project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoorEgybest
{
    public partial class HF : Form
    {
        public HF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MediaContext obj = new MediaContext();
            dataGridView1.DataSource = obj.Libraries
    .Where(library => library.CatName == "movies")
    .ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MediaContext obj = new MediaContext();
            dataGridView1.DataSource = obj.Libraries
    .Where(library => library.CatName == "Series")
    .ToList();
        }
    }
}
