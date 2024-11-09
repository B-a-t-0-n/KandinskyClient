using KandinskyLibrary;
using KandinskyLibrary.Model;
using TestAIFinForms.Providers;
using ImageConverter = TestAIFinForms.Providers.ImageConverter;

namespace TestAIFinForms
{
    public partial class MainForm : Form
    {
        private readonly KandinskyAPI _api;
        public MainForm()
        {
            InitializeComponent();
            string apiKey = "1244FBBD0FD896833F90BCF4E01AF122";
            string secretKey = "9DA6E9D3F6EDF6D8324E9C840D20BD38";
            _api = new KandinskyAPI(apiKey, secretKey);
            LoadData();
        }
        private async void LoadData()
        {
            var styles = await _api.GetStylesAsync();
            var models = await _api.GetModelsAsync();

            comboBoxStyles.Items.AddRange(styles!);
            comboBoxModels.Items.AddRange(models!);

            comboBoxModels.SelectedIndex = 0;
            comboBoxStyles.SelectedIndex = 0;

            textBoxHeight.Text = "1024";
            textBoxWeight.Text = "1024";
        }

        private void TextBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void ButtonGenerate_Click(object sender, EventArgs e)
        {
            buttonGenerate.Cursor = Cursors.WaitCursor;
            buttonGenerate.Click -= ButtonGenerate_Click!;
            pictureBoxGenImage.Image = Properties.Resources._402930e27f800b4045fce958ddddcef4;

            string prompt = richTextBoxPromt.Text;
            if (string.IsNullOrWhiteSpace(prompt))
            {
                MessageBox.Show("введите промт");
                buttonGenerate.Cursor = Cursors.Hand;
                buttonGenerate.Click += ButtonGenerate_Click!;
                pictureBoxGenImage.Image = null;
                return;
            }

            int width = int.Parse(textBoxWeight.Text);
            int height = int.Parse(textBoxHeight.Text);
            if (width > 1024 || height > 1024)
            {
                MessageBox.Show("высота и ширина не должны быть больше 1024");
                buttonGenerate.Cursor = Cursors.Hand;
                buttonGenerate.Click += ButtonGenerate_Click!;
                pictureBoxGenImage.Image = null;
                return;
            }

            var model = comboBoxModels.SelectedItem as ModelDTO;
            var style = comboBoxStyles.SelectedItem as StyleDTO;

            string uuid = await _api.GenerateAsync(
                prompt: prompt,
                modelId: model!.id.ToString(),
                style: style!.name,
                width: int.Parse(textBoxWeight.Text),
                height: int.Parse(textBoxHeight.Text),
                negativePrompt: richTextBoxNegativePromt.Text
                );

            string[] images = await _api.CheckGenerationAsync(uuid);

            if (images != null && images.Length > 0)
            {
                pictureBoxGenImage.Image = ImageConverter.ConvertBase64ToImage(images[0]);

            }
            else
            {
                MessageBox.Show("No images generated or generation failed.");
            }

            buttonGenerate.Cursor = Cursors.Hand;
            buttonGenerate.Click += ButtonGenerate_Click!;

        }

        private void ComboBoxStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var style = comboBoxStyles.SelectedItem as StyleDTO;
            pictureBoxGenImage.LoadAsync(style!.image);
        }
    }
}
