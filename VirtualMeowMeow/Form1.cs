namespace VirtualMeowMeow
{
    public partial class Form1 : Form
    {
        int hunger = 50; 
        int happiness = 50;
        int energy = 50;
        public Form1()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnNap_Click(object sender, EventArgs e)
        {

        }

        private void UpdateUI ()
        {
            // updates the text labels so they show the current va
            lblHunger.Text = "Hunger: " + hunger; // shows hunger number
            lblHappiness.Text = "Happiness: " + happiness; // shows happiness number
            lblEnergy.Text = "Energy: " + energy; // shows energy number 

            // update the progress bars so they visually match the values
            barHunger.Value = hunger;
            barHappiness.Value = happiness;
            BarEnergy.Value = energy;

        }
    }
}
