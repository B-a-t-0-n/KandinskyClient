namespace KandinskyLibrary.Model
{
    public record class ModelDTO(Guid id, string name, double version, string type)
    {
        public override string ToString()
        {
            return name + " " + version;
        }
    }
}
