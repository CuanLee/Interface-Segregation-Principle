namespace Interface_Segregation_Principle
{
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}