namespace TestAIFinForms.Providers
{
    public class ImageConverter
    {
        public static Image ConvertBase64ToImage(string base64String)
        {
            if (base64String.Contains(','))
            {
                base64String = base64String[(base64String.IndexOf(',') + 1)..];
            }

            byte[] imageBytes = Convert.FromBase64String(base64String);

            using MemoryStream ms = new(imageBytes);
            return Image.FromStream(ms);
        }
    }
}
