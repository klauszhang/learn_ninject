using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace learn_ninject
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var kernel=new Ninject.StandardKernel())
      {
        var service = kernel.Get<SalutationService>();
        service.SayHello();
      }
    }
  }
}
