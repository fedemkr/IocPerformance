using System;
using System.Collections.Generic;
using System.Linq;
using IocPerformance.Adapters;

namespace IocPerformance
{
    internal static class ContainerAdapterFactory
    {
        public static IEnumerable<IContainerAdapter> CreateAdapters()
        {
            yield return new NoContainerAdapter();

            //var containers = CreateAdaptersByDefault();
            var containers = CreateAdaptersForMvvmCross();

            foreach (var container in containers)
                yield return container;
        }

        private static IEnumerable<IContainerAdapter> CreateAdaptersForMvvmCross()
        {
            yield return new MvvmCrossIoCContainerAdapter();

            yield return new NinjectContainerAdapter();

            yield return new AutofacContainerAdapter();

            yield return new CatelContainerAdapter();

            yield return new DryIocAdapter();

            yield return new LightInjectContainerAdapter();

            yield return new SimpleInjectorContainerAdapter();
        }

        private static IEnumerable<IContainerAdapter> CreateAdaptersByDefault()
        {
            var containers = typeof(ContainerAdapterFactory).Assembly.GetTypes()
                 .Where(t => t.IsClass && !t.IsAbstract && t.GetInterfaces().Contains(typeof(IContainerAdapter)))
                 .Where(t => !t.Equals(typeof(NoContainerAdapter))
                     && !t.Equals(typeof(SpeediocContainerAdapter)) // Causes exceptions at runtime
                     && !t.Equals(typeof(StilettoContainerAdapter))) // Uses Fody which makes build process unstable
                 .Select(t => Activator.CreateInstance(t))
                 .Cast<IContainerAdapter>()
                 .OrderBy(c => c.Name);

            if (containers.Count() != containers.Select(b => b.Name).Distinct().Count())
            {
                var duplicateNames = containers
                    .GroupBy(b => b.Name)
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key);

                throw new InvalidOperationException(string.Format(
                    "ContainerAdapters must have unique names, the following names are used several times: {0}",
                    string.Join(", ", duplicateNames)));
            }

            return containers;
        }
    }
}
