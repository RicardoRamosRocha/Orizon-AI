namespace OrizonAI.Domain.Enums;

[Flags]
public enum AIModelModality
{
    Text = 1,
    Image = 2,
    Audio = 4,
    Video = 8,
    Tools = 16,
    Streaming = 32
}