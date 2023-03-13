namespace DesignPattern.Document
{
    public class DelegateWithExpressionDemo
    {
        public DelegateWithExpressionDemo()
        {
            //Action action = SimpleAction;
            //action += SimpleAction2;

            EasyAction(EasyInput);

            Action<GenericInput> action = EasyInput;

            EasyAction(action);

            //var labmda = x => x.Name = "";

            string test = "";
            EasyAction(x => test = x.Name);


            EasyFunc(SimpleFunc);
            //string input = "200";

            //Func<string,string> func = (input) => "";
            var func = (string input) => "";

            EasyFunc((input) => "");
        }

        private void SimpleAction()
        {

        }

        private void SimpleAction2()
        {

        }

        private string SimpleFunc(string input)
        {
            return "Ok";
        }

        private void EasyInput(GenericInput input)
        {
            input.Name = "EasyInput";
            Console.WriteLine(input.Name);
        }


        private void EasyAction(Action<GenericInput> action)
        {
            action.Invoke(new GenericInput());
        }

        private void EasyFunc(Func<string, string> func)
        {
            func.Invoke("404");
        }
    }

    public class GenericInput
    {
        public string Name { get; set; } = "DesignPattern";
    }
}