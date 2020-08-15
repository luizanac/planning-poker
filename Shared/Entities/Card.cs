namespace PlanningPoker.Shared.Entities
{
    public class Card
    {
        public string Value { get; private set; }

        public Card(string value)
        {
            Value = value;
        }
    }
}