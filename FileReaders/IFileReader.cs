namespace FileReaders
{
    public interface IFileReader
    {
        List<string> ReadFile(string file);
    }
}