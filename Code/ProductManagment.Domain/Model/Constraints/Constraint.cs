namespace ProductManagment.Domain.Model.Constraints
{
    public class Constraint
    {
        public int Id { get; }
        public string Title { get; }
        public Constraint(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}