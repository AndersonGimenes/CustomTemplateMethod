using System;
using TemplateMethod.Entity;
using TemplateMethod.Validate.Base;

namespace TemplateMethod.Validate
{
    internal class EngineValidate
    {
        private readonly Pessoa _input;

        public EngineValidate(Pessoa input)
        {
            _input = input;
        }
        
        public EngineValidate Execute<IValidate>()
        {
            var validate = Activator.CreateInstance(typeof(IValidate)) as ValidateBase;

            validate.Rule(_input);
            validate.Validate(_input);

            return this;
        }

        public static EngineValidate CreateInstance(Pessoa input) => new(input);
    }
}
