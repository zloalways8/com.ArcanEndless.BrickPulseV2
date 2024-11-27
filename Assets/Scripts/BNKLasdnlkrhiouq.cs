using System;
using System.Collections.Generic;

public class BNKLasdnlkrhiouq
{
        private static BNKLasdnlkrhiouq KLASNlkvnklert;
        private readonly Dictionary<Type, object> VBnaslqwejmo = new Dictionary<Type, object>();

        public static BNKLasdnlkrhiouq WQcvrety => KLASNlkvnklert ??= new BNKLasdnlkrhiouq();
        
        private BNKLasdnlkrhiouq()
        {
        }

        public void WSlqweojpgo5<TContract>(TContract obj)
        {
                var key = typeof(TContract);
                
                if (VBnaslqwejmo.ContainsKey(key))
                        throw new ArgumentException($"{key}V lkdkldsnfl");

                VBnaslqwejmo[key] = obj;
        }

        public TContract CVNklasnklrqwoi<TContract>()
        {
                var key = typeof(TContract);

                if (!VBnaslqwejmo.ContainsKey(key))
                        throw new ArgumentException($"{key}vd wenoikr");

                return (TContract) VBnaslqwejmo[key];
        }
}