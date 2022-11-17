namespace BootcampApplication.model
{
    public class Bootcamp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Initial_date { get; set; }
        public DateTime End_date { get; set; }
        public BootcampStatus Status { get; set; }

        public virtual ICollection<Subscription> Subscription { get; set; }
    }

    public enum BootcampStatus
    {
        OpenForSubscriptions,
        WorkInProgress,
        AnalyzingResults,
        Closed
    }
}