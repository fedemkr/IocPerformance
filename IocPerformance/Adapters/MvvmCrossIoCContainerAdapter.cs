using System;
using IocPerformance.Classes.Complex;
using IocPerformance.Classes.Dummy;
using IocPerformance.Classes.Standard;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace IocPerformance.Adapters
{
    public sealed class MvvmCrossIoCContainerAdapter : ContainerAdapterBase
    {
        private IMvxIoCProvider provider;

        private static ISingleton1 _singleton1;
        private static ISingleton2 _singleton2;
        private static ISingleton3 _singleton3;

        private static IFirstService firstService;
        private static ISecondService secondService;
        private static IThirdService thirdService;

        public override string PackageName
        {
            get { return "MvvmCross"; }
        }

        public override string Url
        {
            get { return "https://github.com/MvvmCross/MvvmCross"; }
        }

        public override bool SupportsPropertyInjection => false;

        public override object Resolve(Type type)
        {
            return Mvx.Resolve(type);
        }

        public override void Dispose()
        {
            // Allow the container and everything it references to be garbage collected.
            if (this.provider == null)
            {
                return;
            }

            this.provider = null;
        }

        public override void Prepare()
        {
            this.provider = MvxSimpleIoCContainer.Initialize();

            RegisterBasic();

            //RegisterPropertyInjection(autofacContainerBuilder);
        }

        public override void PrepareBasic()
        {
            RegisterBasic();
        }

        private static void RegisterBasic()
        {
            RegisterDummies();
            RegisterStandard();
            RegisterComplexObject();
        }

        private static void RegisterDummies()
        {
            Mvx.RegisterType<IDummyOne, DummyOne>();
            Mvx.RegisterType<IDummyTwo, DummyTwo>();
            Mvx.RegisterType<IDummyThree, DummyThree>();
            Mvx.RegisterType<IDummyFour, DummyFour>();
            Mvx.RegisterType<IDummyFive, DummyFive>();
            Mvx.RegisterType<IDummySix, DummySix>();
            Mvx.RegisterType<IDummySeven, DummySeven>();
            Mvx.RegisterType<IDummyEight, DummyEight>();
            Mvx.RegisterType<IDummyNine, DummyNine>();
            Mvx.RegisterType<IDummyTen, DummyTen>();
        }

        private static void RegisterStandard()
        {
            _singleton1 = new Singleton1();
            Mvx.RegisterSingleton<ISingleton1>(_singleton1);

            _singleton2 = new Singleton2();
            Mvx.RegisterSingleton<ISingleton2>(_singleton2);

            _singleton3 = new Singleton3();
            Mvx.RegisterSingleton<ISingleton3>(_singleton3);

            Mvx.RegisterType<ITransient1, Transient1>();
            Mvx.RegisterType<ITransient2, Transient2>();
            Mvx.RegisterType<ITransient3, Transient3>();
            Mvx.RegisterType<ICombined1, Combined1>();
            Mvx.RegisterType<ICombined2, Combined2>();
            Mvx.RegisterType<ICombined3, Combined3>();
        }

        private static void RegisterComplexObject()
        {
            firstService = new FirstService();
            secondService = new SecondService();
            thirdService = new ThirdService();
            Mvx.RegisterSingleton<IFirstService>(firstService);
            Mvx.RegisterSingleton<ISecondService>(secondService);
            Mvx.RegisterSingleton<IThirdService>(thirdService);
            Mvx.RegisterType<ISubObjectOne, SubObjectOne>();
            Mvx.RegisterType<ISubObjectTwo, SubObjectTwo>();
            Mvx.RegisterType<ISubObjectThree, SubObjectThree>();
            Mvx.RegisterType<IComplex1, Complex1>();
            Mvx.RegisterType<IComplex2, Complex2>();
            Mvx.RegisterType<IComplex3, Complex3>();
        }

        //private static void RegisterPropertyInjection(ContainerBuilder autofacContainerBuilder)
        //{
        //    autofacContainerBuilder.RegisterType<ServiceA>().As<IServiceA>().SingleInstance();
        //    autofacContainerBuilder.RegisterType<ServiceB>().As<IServiceB>().SingleInstance();
        //    autofacContainerBuilder.RegisterType<ServiceC>().As<IServiceC>().SingleInstance();
        //    autofacContainerBuilder.RegisterType<SubObjectA>().As<ISubObjectA>().PropertiesAutowired();
        //    autofacContainerBuilder.RegisterType<SubObjectB>().As<ISubObjectB>().PropertiesAutowired();
        //    autofacContainerBuilder.RegisterType<SubObjectC>().As<ISubObjectC>().PropertiesAutowired();

        //    autofacContainerBuilder.RegisterType<ComplexPropertyObject1>().As<IComplexPropertyObject1>()
        //        .PropertiesAutowired();
        //    autofacContainerBuilder.RegisterType<ComplexPropertyObject2>().As<IComplexPropertyObject2>()
        //        .PropertiesAutowired();
        //    autofacContainerBuilder.RegisterType<ComplexPropertyObject3>().As<IComplexPropertyObject3>()
        //        .PropertiesAutowired();
        //}
    }
}