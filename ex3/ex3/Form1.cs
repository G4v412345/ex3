namespace ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountryMedal new_Country; 

            if (country.Text == "")
            {
                MessageBox.Show("�������� ������");
            }
            else
            {
                if (ath.Text == "")
                {
                    MessageBox.Show("�������� ���������� �����������");
                }
                else
                {
                    if (goldM.Text == "")
                    {
                        MessageBox.Show("�������� ���������� ������� �������");
                    }
                    else
                    {
                        if (silvM.Text == "")
                        {
                            MessageBox.Show("�������� ���������� ���������� �������");
                        }
                        else
                        {
                            if (bronM.Text == "")
                            {
                                MessageBox.Show("�������� ���������� ��������� �������");
                            }
                            else
                            {
                                new_Country = new CountryMedal(country.Text, Convert.ToInt32(ath.Text), Convert.ToInt32(goldM.Text), Convert.ToInt32(silvM.Text), Convert.ToInt32(bronM.Text));
                                resultBox.Text += new_Country.GetInformation();
                            }
                        }
                    }

                }
            }

        }

        private void resultBox_TextChanged(object sender, EventArgs e) 

        { 

        }
    }
}