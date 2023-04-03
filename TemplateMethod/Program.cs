using System;
using TemplateMethod.Entity;
using TemplateMethod.Exception;
using TemplateMethod.Validate;
using TemplateMethod.Validate.ValidateRules;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Mock();
            new ValidateUseCase().Execute(input);
        }

        static Pessoa Mock()
        {
            #region [DATA]
            var cpf = "12345678911";
            var cnpj = "12345678911234";

            var validAge = 35;
            var invalidAge = 15;

            var name = "João;";
            #endregion

            return new Pessoa(age: validAge, name: name, document: cpf);
        }
    }

    internal class ValidateUseCase
    {
        public void Execute(Pessoa input)
        {
            try
            {
                EngineValidate
                    .CreateInstance(input)
                    .Execute<AgeValidate>()
                    .Execute<DocumentValidate>();

                //Log
                Console.WriteLine("Valid flow");
                //publisher
            }
            catch (RuleException ex)
            {
                //Log
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
