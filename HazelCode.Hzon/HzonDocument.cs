namespace HazelCode.Hzon;

public struct HzonDocument
{
    public string Content { get; set; }
    private Lexer _lexer { get; set; }
    
    public static HzonDocument FromStreamReader(StreamReader stream)
    {
        HzonDocument document = new HzonDocument
        {
            Content = stream.ReadToEnd()
        };

        stream.Close();

        return document;
    }

    public static HzonDocument FromFilePath(string path)
    {
        HzonDocument document = new HzonDocument
        {
            Content = File.ReadAllText(path)
        };

        return document;
    }

    public T Deserialize<T>() where T : IDataRecipient
    {
        _lexer = new Lexer(Content);
        return (T)_lexer.GetData();
    }
}