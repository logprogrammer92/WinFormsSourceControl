namespace WinFormsSourceControl;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcAreaAndPerimeterButton_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(lengthTextBox.Text);
            int width = Convert.ToInt32(widthTextBox.Text);

            int area = length * width;
            int perimeter = length * 2 + width * 2;

            areaTextbox.Text = "Area is: " + area;
            perimeterTextBox.Text = "Perimeter is: " + perimeter;
        }
    }

