using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KandinskyLibrary;
using TestAIFinForms.Providers;

namespace TestAIMauiApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private KandinskyAPI _kandinsky;

        public MainViewModel(KandinskyAPI kandinsky) 
        {
            _kandinsky = kandinsky;
        }

        [ObservableProperty]
        public string text = "";

        [ObservableProperty]
        public bool hasImage = false;

        [ObservableProperty]
        public bool isGenerated = true;

        [ObservableProperty]
        public bool isGenerate = false;

        [ObservableProperty]
        public ImageSource image = default!;

        [RelayCommand]
        public async Task Generate()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return;
            }

            IsGenerated = false;
            IsGenerate = true;
            var models = await _kandinsky.GetModelsAsync();
            var style = await _kandinsky.GetStylesAsync();
            var uuid = await _kandinsky.GenerateAsync(Text, models![0].id.ToString(), style![0].name);
            string[] images = await _kandinsky.CheckGenerationAsync(uuid);

            if (images != null && images.Length > 0)
            {
                Image = ImageConverter.ConvertBase64ToImageSource(images[0]);

            }
            IsGenerate = false;
            HasImage = true;
            IsGenerated = true;

        }
    }
}
