namespace WinFormsSourceControl;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcAreaAndPerimeterButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lengthTextBox.Text, out int length))
            {
                MessageBox.Show("Please enter a valid integer for length.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(widthTextBox.Text, out int width))
            {
                MessageBox.Show("Please enter a valid integer for width.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int area = length * width;
            int perimeter = length * 2 + width * 2;

            areaTextbox.Text = "Area is: " + area;
            perimeterTextBox.Text = "Perimeter is: " + perimeter;
        }
    }

