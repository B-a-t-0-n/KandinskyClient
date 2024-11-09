namespace KandinskyLibrary.Model
{
    public record class StyleDTO(string name, string title, string titleEn, string image)
    {
        public override string ToString()
        {
            return name;
        }
    }
}
