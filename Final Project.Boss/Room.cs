using System.Data;
using System.Numerics;
using System.Text;
using System.Windows.Forms;


namespace Final_Project.Boss
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n = RoomGW.Rows.Add();
            RoomGW.Rows[n].Cells[0].Value = "เช็คอิน";
            RoomGW.Rows[n].Cells[1].Value = textBoxName.Text;
            RoomGW.Rows[n].Cells[2].Value = textBoxNumber.Text;
            RoomGW.Rows[n].Cells[3].Value = textBoxEmail.Text;
            RoomGW.Rows[n].Cells[4].Value = dateTimePicker1.Text;
            RoomGW.Rows[n].Cells[5].Value = label4.Text;
            RoomGW.Rows[n].Cells[6].Value = textBoxRoom.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = RoomGW.Rows.Add();
            RoomGW.Rows[n].Cells[0].Value = "เช็คเอาท์";
            RoomGW.Rows[n].Cells[1].Value = textBoxName.Text;
            RoomGW.Rows[n].Cells[2].Value = textBoxNumber.Text;
            RoomGW.Rows[n].Cells[3].Value = textBoxEmail.Text;
            RoomGW.Rows[n].Cells[4].Value = dateTimePicker1.Text;
            RoomGW.Rows[n].Cells[5].Value = label4.Text;
            RoomGW.Rows[n].Cells[6].Value = textBoxRoom.Text;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
           

            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.RoomGW.SelectedRows)
            {
                RoomGW.Rows.Remove(item);
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.Show();
            this.Hide();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RoomGW.Rows.Count > 0)
            {
                // Code to save the data
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Code to save the data
                }
                int columnCount = RoomGW.Columns.Count;
                string columnNames = "";
                string[] outputCSV = new string[RoomGW.Rows.Count + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += RoomGW.Columns[i].HeaderText.ToString() + ",";
                }
                outputCSV[0] += columnNames;

                    for (int i = 1; (i - 1) < RoomGW.Rows.Count; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            object cellValue = RoomGW.Rows[i - 1].Cells[j].Value;
                            outputCSV[i] += cellValue != null ? cellValue.ToString() : string.Empty + ",";
                        }
                    }

                
                File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);



            }




        }

        private void Room_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortTimeString();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxRoom.Text = "";
            Control.ControlCollection Controls = groupBox2.Controls;
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked == true)
                    {
                        if (this.textBoxRoom.Text != "")
                            this.textBoxRoom.Text = this.textBoxRoom.Text + ", ";

                        this.textBoxRoom.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

    }
} 
