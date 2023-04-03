using TemplateMethod.Entity;

namespace TemplateMethod.Validate.Interface
{
    internal interface IValidate
    {
        void Validate(Pessoa input);
        bool Rule(Pessoa input); 
    }
}
