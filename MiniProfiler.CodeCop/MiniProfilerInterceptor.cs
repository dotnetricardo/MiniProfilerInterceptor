using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CodeCop.Core;
using CodeCop.Core.Contracts;
using StackExchange.Profiling;

namespace MiniProfiler.CodeCop
{
    public class MiniProfilerInterceptor : ICopIntercept
    {
        private readonly StackExchange.Profiling.MiniProfiler _profiler;
        private IDisposable _step;

        public MiniProfilerInterceptor()
        {
            _profiler = StackExchange.Profiling.MiniProfiler.Current;
        }

        public void OnBeforeExecute(InterceptionContext context)
        {
            _step = _profiler.Step(context.InterceptedMethod.Name);
        }

        public void OnAfterExecute(InterceptionContext context)
        {
            if (_step != null)
            {
                _step.Dispose();
                _step = null;
            }
        }
    }
}
