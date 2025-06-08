namespace KafkaFinalWorkingProject.Services
{
    public class FakeKafkaService
    {
        private readonly List<string> _messages = new();

        public void Publish(string message)
        {
            _messages.Add($"Published at {DateTime.Now}: {message}");
        }

        public List<string> Consume()
        {
            // Връща копие на всички съобщения
            return _messages.ToList();
        }
    }
}