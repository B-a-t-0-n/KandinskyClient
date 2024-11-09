namespace TestAIFinForms
{
    public class ImageConverter
    {
        public static Image ConvertBase64ToImage(string base64String)
        {
            // Удаление части строки, если строка Base64 содержит метаданные о типе
            // Например, если строка начинается с "data:image/png;base64,"
            if (base64String.Contains(","))
            {
                base64String = base64String.Substring(base64String.IndexOf(",") + 1);
            }

            // Декодирование строки Base64 в массив байтов
            byte[] imageBytes = Convert.FromBase64String(base64String);

            // Создание изображения из байтового массива
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
