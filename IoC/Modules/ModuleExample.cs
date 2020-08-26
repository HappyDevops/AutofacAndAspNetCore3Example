using Autofac;
using HappyDevops.AutofacAndAspnetCore3.Dependences;

namespace HappyDevops.AutofacAndAspnetCore3.IoC.Modules
{
    public class ModuleExample : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.Register(c => new GenericComponent())
                .As<IGenericInterface>()
                .AsSelf()
                .InstancePerDependency();

        }
    }
}
