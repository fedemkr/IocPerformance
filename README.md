Ioc Performance
===============

Source code of my performance comparison of the most popular .NET IoC containers:  
[www.palmmedia.de/Blog/2011/8/30/ioc-container-benchmark-performance-comparison](http://www.palmmedia.de/Blog/2011/8/30/ioc-container-benchmark-performance-comparison)

Author: Daniel Palme  
Blog: [www.palmmedia.de](http://www.palmmedia.de)  
Twitter: [@danielpalme](http://twitter.com/danielpalme)  

Results
-------
### Explantions
**First value**: Time of single-threaded execution in [ms]  
**Second value**: Time of multi-threaded execution in [ms]  
**_*_**: Benchmark was stopped after 1 minute and result is extrapolated.  
### Basic Features
|**Container**|**Singleton**|**Transient**|**Combined**|**Complex**|
|:------------|------------:|------------:|-----------:|----------:|
|**No**|78<br/>119|95<br/>119|139<br/>147|211<br/>159|
|**[MvvmCross 5.1.1](https://github.com/MvvmCross/MvvmCross)**|318<br/>371|1088<br/>1170|3065<br/>3152|8354<br/>8584|
|**[Ninject 3.2.2.0](http://ninject.org)**|4603<br/>2829|16562<br/>11829|43867<br/>27879|125045*<br/>77335*|
|**[Autofac 4.6.1](https://github.com/autofac/Autofac)**|732<br/>544|725<br/>515|2022<br/>1358|6379<br/>4396|
|**[Catel 5.0.0](http://www.catelproject.com)**|292<br/>357|3774<br/>3937|8577<br/>8754|19296<br/>19376|
|**[DryIoc 2.11.6](https://bitbucket.org/dadhi/dryioc)**|**44**<br/>**69**|65<br/>**99**|103<br/>**110**|**167**<br/>**140**|
|**[LightInject 5.0.3](https://github.com/seesharper/LightInject)**|54<br/>88|**63**<br/>106|**102**<br/>112|173<br/>147|
|**[SimpleInjector 4.0.8](https://simpleinjector.org)**|87<br/>86|129<br/>123|165<br/>182|270<br/>189|
### Advanced Features
|**Container**|**Property**|**Generics**|**IEnumerable**|**Conditional**|**Child Container**|**Asp Net Core**|**Interception With Proxy**|
|:------------|-----------:|-----------:|--------------:|--------------:|------------------:|---------------:|--------------------------:|
|**No**|191<br/>155|123<br/>139|412<br/>268|127<br/>134|726<br/>497|<br/>|92<br/>174|
|**[MvvmCross 5.1.1](https://github.com/MvvmCross/MvvmCross)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Ninject 3.2.2.0](http://ninject.org)**|112310*<br/>68850*|45954<br/>25917|102237*<br/>62166*|31843<br/>19002|125354000*<br/>113662878*|<br/>|434366*<br/>28779214*|
|**[Autofac 4.6.1](https://github.com/autofac/Autofac)**|6448<br/>4357|2007<br/>1269|7491<br/>4141|1512<br/>1034|**53977**<br/>**29022**|13743<br/>8586|23132<br/>11853|
|**[Catel 5.0.0](http://www.catelproject.com)**|<br/>|8587<br/>8725|<br/>|<br/>|<br/>|<br/>|**3840**<br/>**3953**|
|**[DryIoc 2.11.6](https://bitbucket.org/dadhi/dryioc)**|**161**<br/>180|98<br/>**108**|350<br/>310|**106**<br/>**111**|<br/>|<br/>|366750*<br/>10954810*|
|**[LightInject 5.0.3](https://github.com/seesharper/LightInject)**|166<br/>**142**|**93**<br/>125|**337**<br/>**239**|381<br/>245|<br/>|**2194**<br/>**1413**|450507*<br/>12174371*|
|**[SimpleInjector 4.0.8](https://simpleinjector.org)**|296<br/>231|153<br/>155|878<br/>509|165<br/>187|<br/>|<br/>|384554*<br/>30945876*|
### Prepare
|**Container**|**Prepare And Register**|**Prepare And Register And Simple Resolve**|
|:------------|-----------------------:|------------------------------------------:|
|**No**|3<br/>|3<br/>|
|**[MvvmCross 5.1.1](https://github.com/MvvmCross/MvvmCross)**|**7**<br/>|**10**<br/>|
|**[Ninject 3.2.2.0](http://ninject.org)**|228678*<br/>|229920*<br/>|
|**[Autofac 4.6.1](https://github.com/autofac/Autofac)**|295<br/>|317<br/>|
|**[Catel 5.0.0](http://www.catelproject.com)**|24344<br/>|26201<br/>|
|**[DryIoc 2.11.6](https://bitbucket.org/dadhi/dryioc)**|72<br/>|290<br/>|
|**[LightInject 5.0.3](https://github.com/seesharper/LightInject)**|139<br/>|893<br/>|
|**[SimpleInjector 4.0.8](https://simpleinjector.org)**|621<br/>|2017<br/>|
### Charts
![Basic features](http://www.palmmedia.de/content/blogimages/5225c515-2f25-498f-84fe-6c6e931d2042.png)
![Advanced features](http://www.palmmedia.de/content/blogimages/e0401485-20c6-462e-b5d4-c9cf854e6bee.png)
![Prepare](http://www.palmmedia.de/content/blogimages/67b056a5-9da8-40b4-9ae6-0c838cdac180.png)
### Machine
The benchmark was executed on the following machine:  
**CPU**: Intel(R) Core(TM) i7-4710HQ CPU @ 2.50GHz  
**Memory**: 15.93GB
