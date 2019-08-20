namespace FunctionalConsole
{
    using System;
    using System.Collections.Generic;

    internal static class Lambda
    {
        private static Dictionary<object, object> execFuncs = new Dictionary<object, object>();
        public static Pipe<T> Pipe<T>(Func<T> f)
        {
            T data = default;
            Func<T> startValue = () => data;
            Pipe<T> start(Func<T> arg)
            {
                data = arg();
                Pipe<T> pipe(Func<T, T> arg1)
                {
                    data = arg1(data);
                    return pipe;
                }

                Pipe<T> pipeObj = pipe;
                execFuncs[pipeObj] = startValue;
                return pipe;
            }

            return start(f);
        }

        public static T Value<T>(this Pipe<T> pipe)
        {
            if (execFuncs.TryGetValue(pipe, out var val))
            {
                return (T)val;
            }

            return default;
        }
    }

    delegate Pipe<T> Pipe<T>(Func<T, T> a);
}