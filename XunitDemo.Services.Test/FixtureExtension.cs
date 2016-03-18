using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Kernel;

namespace XunitDemo.Services.Test
{
    /// <summary>
    /// 過濾Virtual屬性的Property不自動產生假資料 
    /// </summary>
    public class DoNotFillVirtualProperties : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new VirtualPropertyOmitter());
        }
    }

    public class VirtualPropertyOmitter : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var pi = request as PropertyInfo;

            if (pi != null && pi.GetGetMethod().IsVirtual)
                return null;

            return new NoSpecimen();
        }
    }
}
