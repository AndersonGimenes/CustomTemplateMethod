using TemplateMethod.Entity;
using TemplateMethod.Validate.Base;

namespace TemplateMethod.Validate.ValidateRules
{
    internal class DocumentValidate : ValidateBase
    {
        const int VALID_DOCUMENT = 11;

        protected override string MessageError => "Invalid Document";

        public override bool Rule(Pessoa input) => !(input.Document.Length == VALID_DOCUMENT);
    }
}
