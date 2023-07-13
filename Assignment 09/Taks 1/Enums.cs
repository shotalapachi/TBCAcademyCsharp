using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_1
{
    enum Vehicles
    {
        Military,
        Commerce,
        Public,
        Sport
    }
    enum Military
    {
        Transport,
        Fighting,
        Tank,
        Workload
    }
    enum Commerce
    {
        Sedan,
        Hatchback,
        Cabriolet,
        Picup,
        SUV,
        Van
    }
    enum Public
    {
        Bus,
        Train,
        Subway,
        Tramway
    }
    enum Sport
    {
        Drag,
        F1,
        Rallying,
        Offroad
    }

    public class PrintEnums
    {
        public static void PrintChildEnums<TChild>()
        {
            Console.WriteLine($"Category: {typeof(TChild).Name}");

            foreach (TChild childValue in Enum.GetValues(typeof(TChild)))
            {
                Console.WriteLine("  " + childValue);
            }
        }
    }
}
