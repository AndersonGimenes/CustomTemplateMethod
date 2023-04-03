namespace TemplateMethod.Entity
{
    internal class Pessoa
    {
        public Pessoa(int age, string name, string document)
        {
            Age = age;
            Name = name;
            Document = document;
        }

        public int Age { get; }
        public string Name { get; }
        public string Document { get; }
    }
}
