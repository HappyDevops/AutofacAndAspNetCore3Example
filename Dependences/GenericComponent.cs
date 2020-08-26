namespace HappyDevops.AutofacAndAspnetCore3.Dependences
{
    public class GenericComponent :IGenericInterface
    {
        public string WriteText()
        {
            return "Generic Execution";
        }

        public string WriteCustomText()
        {
            return "Custom Execution";
        }
    }
}
