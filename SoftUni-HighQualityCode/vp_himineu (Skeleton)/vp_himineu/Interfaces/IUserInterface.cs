using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleParkSystem.Interfaces
{
    public interface IUserInterface
    {
        string ReadLine();
        void WriteLine(string format, params string[] args);
    }
}
