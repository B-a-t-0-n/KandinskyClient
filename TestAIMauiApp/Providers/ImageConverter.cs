namespace TestAIFinForms.Providers
{
    public class ImageConverter
    {
        public static ImageSource ConvertBase64ToImageSource(string base64String)
        {
            if (base64String.Contains(','))
            {
                base64String = base64String[(base64String.IndexOf(',') + 1)..];
            }

            byte[] imageBytes = Convert.FromBase64String(base64String);

            // Возвращаем ImageSource, создавая новый поток каждый раз
            return ImageSource.FromStream(() =>
            {
                var ms = new MemoryStream(imageBytes);
                // Необходимо вернуть поток к началу перед его использованием
                ms.Position = 0;
                return ms;
            });
        }
    }
}
