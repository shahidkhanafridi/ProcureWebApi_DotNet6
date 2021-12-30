namespace Procure.Data
{
    public abstract class SharedEntity
    {
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}