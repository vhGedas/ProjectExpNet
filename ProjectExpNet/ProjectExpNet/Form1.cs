namespace ProjectExpNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            do
            {
                resultado = MessageBox.Show("Are you gay?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    resultado = MessageBox.Show("I know... Confirm you are gay?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

            } while (resultado != DialogResult.Yes);

            MessageBox.Show("I knew it! ??", "Gotcha", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
