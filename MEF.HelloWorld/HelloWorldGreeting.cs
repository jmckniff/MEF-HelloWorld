using System.ComponentModel.Composition;
using MEF.Common;

namespace MEF.HelloWorld
{
    [Export(typeof(IGreet))]
    public class HelloWorldGreeting : IGreet
    {
        public string Greet()
        {
            return "Hello World!";
        }
    }
}
