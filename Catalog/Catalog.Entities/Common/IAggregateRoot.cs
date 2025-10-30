using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities.Common
{
    public interface IAggregateRoot
    {

        //Sadece aggregate'ler olayları tutar ve fırlatır...
        IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
        void ClearDomainEvents();
    }
}
