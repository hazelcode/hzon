namespace HazelCode.Hzon;

public struct HzonDocument
{
    public string Content { get; set; }
    
    public static HzonDocument FromStreamReader(StreamReader stream)
    {
        HzonDocument document = new HzonDocument
        {
            Content = stream.ReadToEnd()
        };

        stream.Close();

        return document;
    }
}