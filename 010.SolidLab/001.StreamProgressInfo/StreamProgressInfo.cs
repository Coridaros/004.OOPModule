using StreamProgressInfo.Interfaces;

namespace StreamProgressInfo;

public class StreamProgressInfo
{
    private IStream stream;

    public StreamProgressInfo(IStream stream)
    {
        this.stream = stream;
    }

    public int CalculateCurrentPercent()
    {
        return (stream.BytesSent * 100) / stream.Length;
    }
}