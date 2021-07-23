using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExtensionMethods.MaybeMonad
{
    public static class Maybe
    {
        public static TResult With<TInput, TResult>(this TInput input, Func<TInput, TResult> evaluator)
            where TResult : class // Very Important
            where TInput : class
        {
            if (input is null)
            {
                return null;
            }
            else
            {
                return evaluator(input);
            }
        }


        public static TInput If<TInput>(this TInput input, Func<TInput, bool> evaluator)
            where TInput : class
        {
            if (input is null)
            {
                return null;
            }
            else
            {
                return evaluator(input) ? input : null;
            }
        }
    }
}
