namespace shortner.DataAccessLayer.Entites;

public class Link
{
    public long Id { get; set; }
    public string OriginalLink { get; set; }
    public string BaseUrl { get; set; }
    public string ShortPath { get; set; }
    public int Count { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public bool SoftDelete { get; set; }
}
