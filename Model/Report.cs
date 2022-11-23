namespace Model
{
    public class Report
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Number { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
