using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using MEF.Common;

namespace MEF
{
    public class GreetingService
    {
        private readonly CompositionContainer _container;

        [Import(typeof(IGreet))]
        private IGreet _greeting;

        public GreetingService()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Environment.CurrentDirectory));

            _container = new CompositionContainer(catalog);

            try
            {
                _container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
                Console.ReadLine();
            }
        }

        public void DisplayGreeting()
        {
            Console.WriteLine(_greeting.Greet());
        }
}
}
