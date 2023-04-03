using TemplateMethod.Entity;
using TemplateMethod.Exception;
using TemplateMethod.Validate.Interface;

namespace TemplateMethod.Validate.Base
{
    internal abstract class ValidateBase : IValidate
    {
        protected virtual string MessageError => "Default message error";
        public abstract bool Rule(Pessoa input);

        public void Validate(Pessoa input)
        {
            if (Rule(input))
            {
                // Publisher
                throw new RuleException(MessageError);
            }
        }
    }
}
