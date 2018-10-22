using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels
{
    public static class CustomDoSomethingStaticClass
    {
        public static void Map<TRead, TWrite>(TRead read, ref TWrite write) where TRead : class
                                                                            where TWrite : class
        {
            if (read == null)
            {
                throw new ArgumentNullException("read");
            }

            if (write == null)
            {
                throw new ArgumentNullException("write");
            }

            Type readType = typeof(TRead);
            Type writeType = typeof(TWrite);


            foreach (var readProperty in readType.GetProperties())
            {
                var writeProperty = writeType.GetProperty(readProperty.Name);
                if (writeProperty != null)
                {
                    if (readProperty.CanRead && writeProperty.CanWrite)
                    {
                        var value = readProperty.GetValue(read);
                        writeProperty.SetValue(write, value);
                    }
                }
            }
        }
    }
}
