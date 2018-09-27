using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerFramework.Application
{
    public interface ICommandBus
    {
        void Dispatch<T>(T command);
    }
}
