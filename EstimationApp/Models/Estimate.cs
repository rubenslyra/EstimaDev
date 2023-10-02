public class Estimate
{
    public int Id { get; set; }
    public string? ProjectName { get; set; }
    public string? Description { get; set; }
    public double BestCase { get; set; }
    public double MostLikelyCase { get; set; }
    public double WorstCase { get; set; }
}
