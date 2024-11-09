namespace KandinskyLibrary.Model
{
    public record class ModelDTO(long id, string name, double version, string type)
    {
        public override string ToString()
        {
            return name + " " + version;
        }
    }
}
