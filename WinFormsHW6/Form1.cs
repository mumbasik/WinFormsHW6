namespace WinFormsHW6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(dateTimePicker1.Text))
            {

                MessageBox.Show("You need to enter Name and Date of the event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                label4.Text = "Event is running ";


                progressBar1.Value += 10;
                if (progressBar1.Value == progressBar1.Maximum)
                {




                    label4.Text = "Event is completed!";
                    progressBar1.Value = progressBar1.Minimum;



                    Events.Items.Add(textBox1.Text);
                    Events.Items.Add(dateTimePicker1.Text);


                    textBox1.Text = string.Empty;
                    dateTimePicker1.Text = string.Empty;





                }






            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("You need to enter Name and Date of the event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Events.Items.Count == 0) 
            {
                MessageBox.Show("The list is empty. Nothing to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Events.Items.Contains(textBox1.Text) || !Events.Items.Contains(dateTimePicker1.Text))
            {
                MessageBox.Show("Current event is not in the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Events.Items.Remove(textBox1.Text);
                Events.Items.Remove(dateTimePicker1.Text);
                textBox1.Text = string.Empty;
                dateTimePicker1.Text = string.Empty;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
