using TigerFramework.Domain;

namespace ProductManagment.Domain.Model.Constraints
{
    public class Constraint : AggregateRoot<int>
    {
        public string Title { get; }
        public Constraint(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}