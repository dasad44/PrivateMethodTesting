using System.Reflection;

namespace PrivateMethodTesting.Helpers
{
    public static class PrivateMethodTestingHelper
    {
        internal static TReturn InvokePrivateMethod<TReturn>(
            this object instance,
            string methodName,
            params object[] parameters)
        {
            Type type = instance.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            MethodInfo method = type.GetMethod(methodName, bindingAttr);

            return (TReturn)method.Invoke(instance, parameters);
        }
    }
}
