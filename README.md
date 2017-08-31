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
|**No**|82<br/>128|87<br/>125|147<br/>144|208<br/>161|
|**[MvvmCross 5.1.1](https://github.com/MvvmCross/MvvmCross)**|336<br/>379|<br/>|<br/>|8713<br/>8750|
|**[Ninject 3.2.2.0](http://ninject.org)**|4633<br/>2954|15471<br/>9828|44304<br/>27886|124101*<br/>76003*|
|**[Autofac 4.6.1](https://github.com/autofac/Autofac)**|759<br/>557|832<br/>548|1987<br/>1323|6496<br/>4316|
|**[Catel 5.0.0](http://www.catelproject.com)**|288<br/>334|4150<br/>4156|9225<br/>9297|20772<br/>20488|
|**[DryIoc 2.11.6](https://bitbucket.org/dadhi/dryioc)**|62<br/>**75**|67<br/>107|**99**<br/>161|**163**<br/>159|
|**[LightInject 5.0.3](https://github.com/seesharper/LightInject)**|**43**<br/>97|**62**<br/>**87**|107<br/>**135**|176<br/>**148**|
|**[SimpleInjector 4.0.8](https://simpleinjector.org)**|81<br/>108|124<br/>124|158<br/>166|268<br/>240|
### Advanced Features
|**Container**|**Property**|**Generics**|**IEnumerable**|**Conditional**|**Child Container**|**Asp Net Core**|**Interception With Proxy**|
|:------------|-----------:|-----------:|--------------:|--------------:|------------------:|---------------:|--------------------------:|
|**No**|193<br/>180|138<br/>136|407<br/>306|125<br/>114|739<br/>440|<br/>|96<br/>100|
|**[MvvmCross 5.1.1](https://github.com/MvvmCross/MvvmCross)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Ninject 3.2.2.0](http://ninject.org)**|106420*<br/>67173*|42032<br/>23420|99456*<br/>62654*|32969<br/>17873|123797000*<br/>119458333*|<br/>|432287*<br/>25557021*|
|**[Autofac 4.6.1](https://github.com/autofac/Autofac)**|6495<br/>4335|2094<br/>1258|7439<br/>4172|1528<br/>1031|**54677**<br/>**29229**|13988<br/>8353|21981<br/>11994|
|**[Catel 5.0.0](http://www.catelproject.com)**|<br/>|9140<br/>9220|<br/>|<br/>|<br/>|<br/>|**4130**<br/>**4155**|
|**[DryIoc 2.11.6](https://bitbucket.org/dadhi/dryioc)**|**163**<br/>**141**|**95**<br/>**109**|362<br/>282|**106**<br/>**130**|<br/>|<br/>|374267*<br/>10982802*|
|**[LightInject 5.0.3](https://github.com/seesharper/LightInject)**|166<br/>165|96<br/>**109**|**345**<br/>**248**|392<br/>281|<br/>|**2156**<br/>**1461**|476777*<br/>11238487*|
|**[SimpleInjector 4.0.8](https://simpleinjector.org)**|299<br/>249|153<br/>159|894<br/>537|181<br/>192|<br/>|<br/>|399986*<br/>30682515*|
### Prepare
|**Container**|**Prepare And Register**|**Prepare And Register And Simple Resolve**|
|:------------|-----------------------:|------------------------------------------:|
|**No**|3<br/>|3<br/>|
|**[MvvmCross 5.1.1](https://github.com/MvvmCross/MvvmCross)**|**5**<br/>|**9**<br/>|
|**[Ninject 3.2.2.0](http://ninject.org)**|232560*<br/>|234717*<br/>|
|**[Autofac 4.6.1](https://github.com/autofac/Autofac)**|301<br/>|323<br/>|
|**[Catel 5.0.0](http://www.catelproject.com)**|27134<br/>|28615<br/>|
|**[DryIoc 2.11.6](https://bitbucket.org/dadhi/dryioc)**|67<br/>|307<br/>|
|**[LightInject 5.0.3](https://github.com/seesharper/LightInject)**|180<br/>|963<br/>|
|**[SimpleInjector 4.0.8](https://simpleinjector.org)**|623<br/>|2017<br/>|
### Charts (Not updated yet)
![Basic features](http://www.palmmedia.de/content/blogimages/5225c515-2f25-498f-84fe-6c6e931d2042.png)
![Advanced features](http://www.palmmedia.de/content/blogimages/e0401485-20c6-462e-b5d4-c9cf854e6bee.png)
![Prepare](http://www.palmmedia.de/content/blogimages/67b056a5-9da8-40b4-9ae6-0c838cdac180.png)
### Machine
The benchmark was executed on the following machine:  
**CPU**: Intel(R) Core(TM) i7-4710HQ CPU @ 2.50GHz  
**Memory**: 16.38GB
