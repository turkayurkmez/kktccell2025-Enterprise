using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities.Common
{
    public interface IDomainEvent
    {
        Guid Id { get; }
        DateTime OccuredOn { get; }
    }
}
