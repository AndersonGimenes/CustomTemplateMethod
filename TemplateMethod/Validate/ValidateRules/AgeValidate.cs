using TemplateMethod.Entity;
using TemplateMethod.Validate.Base;

namespace TemplateMethod.Validate.ValidateRules
{
    internal class AgeValidate : ValidateBase
    {
        const int VALID_AGE = 18;
        protected override string MessageError => "Invalid Age";

        public override bool Rule(Pessoa input) => input.Age < VALID_AGE;
    }
}
