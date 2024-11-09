using System.Windows.Forms;

namespace TestAIFinForms
{
    public partial class Form1 : Form
    {
        private readonly KandinskyAPI _api;
        private string _modelId;
        public Form1()
        {
            InitializeComponent();
            string apiKey = "1244FBBD0FD896833F90BCF4E01AF122";
            string secretKey = "9DA6E9D3F6EDF6D8324E9C840D20BD38";
            _api = new KandinskyAPI(apiUrl, apiKey, secretKey);
            LoadModel();
        }
        private async void LoadModel()
        {
            _modelId = await _api.GetModelAsync();
            MessageBox.Show("Model ID loaded: " + _modelId);
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            string prompt = promptTextBox.Text;
            if (string.IsNullOrWhiteSpace(prompt))
            {
                MessageBox.Show("Please enter a prompt.");
                return;
            }

            string uuid = await _api.GenerateAsync(prompt, _modelId);
            string[] images = await _api.CheckGenerationAsync(uuid);

            if (images != null && images.Length > 0)
            {
                pictureBox1.Image =  ImageConverter.ConvertBase64ToImage(images[0]);

            }
            else
            {
                MessageBox.Show("No images generated or generation failed.");
            }
            button1.Enabled = true;


        }
    }
}
