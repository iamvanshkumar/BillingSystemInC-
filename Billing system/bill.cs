using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_system
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
            this.label5.Text = DateTime.Now.ToString();//date and time
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void p_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_mode.ResetText();
            total.Clear();
            tr_id.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p_name.Clear();
            age.Clear();
            ref_by.Clear();
            gender.ResetText();
        }
        // -------------delete item------------ 
        private void button4_Click(object sender, EventArgs e)
        {
            iDelete();
        }
        private void iDelete()
        {

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            main ss = new main();
            ss.Show();
        }
        // -------------____EXIT____------------
        private void exit_Click(object sender, EventArgs e)
        {
            MeExit();
        }
        private void MeExit()
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Save DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        // ------------add data------------
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(t_name.Text, t_code.Text, t_charges.Text);
            t_code.ResetText();
            t_name.ResetText();
            t_charges.Clear();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }
        double total1;  
        private void button2_Click(object sender, EventArgs e)
        {

            for (int i=0; i<=dataGridView1.Rows.Count -1; i++)
            {
                total1 += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());    
            }
            dataGridView1.Rows.Add(null, "TOTAL :", total1);

          /*  ttl.Text = "0";
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ttl.Text = Convert.ToString(double.Parse(ttl.Text) + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }*/
        }
    }
}
