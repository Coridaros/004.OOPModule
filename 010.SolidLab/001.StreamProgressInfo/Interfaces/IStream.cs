namespace StreamProgressInfo.Interfaces;

public interface IStream
{
    public int Length { get; set; }

    public int BytesSent { get; set; }
}