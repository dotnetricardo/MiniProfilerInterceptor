# MiniProfilerInterceptor
Interceptor for CodeCop (http://getcodecop.com) that automatically integrates MiniProfiler onto intercepted methods. 

# Instructions
To place this Interceptor on all intercepted methods, just insert "MiniProfilerInterceptor" in the GlobalInterceptors array of your copconfig.json file, like so:

```
{
    "Types": [
        {
            "TypeName": "ConsoleApplication1.FooClass, ConsoleApplication1",
            "Methods": [
                {
                    "MethodSignature": "FooMethod1(System.Object, System.String)",
                    "Interceptors": [ ]
                },
                {
                    "MethodSignature": "FooMethod2(System.String)",
                    "Interceptors": [ ]
                }
            ],
          "GenericArgumentTypes": [ ]
        }
    ],
    "GlobalInterceptors": ["MiniProfilerInterceptor"],
    "Key":"Your product key or leave empty for free product mode"

}
```
If you want to use this Interceptor on just some methods, inside the copconfig.json file insert "MiniProfilerInterceptor" in the Interceptors array of those methods, like so:
```
{
    "Types": [
        {
            "TypeName": "ConsoleApplication1.FooClass, ConsoleApplication1",
            "Methods": [
                {
                    "MethodSignature": "FooMethod1(System.Object, System.String)",
                    "Interceptors": ["MiniProfilerInterceptor" ]
                },
                {
                    "MethodSignature": "FooMethod2(System.String)",
                    "Interceptors": [ ]
                }
            ],
          "GenericArgumentTypes": [ ]
        }
    ],
    "GlobalInterceptors": [],
    "Key":"Your product key or leave empty for free product mode"

}
```
# Nuget Package
https://www.nuget.org/packages/MiniProfiler.CodeCop/

Make sure you read the CodeCop wiki page at https://bitbucket.org/codecop_team/codecop/wiki/Home to get started using this powerful method interception tool for .NET .

