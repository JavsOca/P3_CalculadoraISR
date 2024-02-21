using MyCompany.Intranet.Core.Entities;

namespace MyCompany.Intranet.Core.Managers.Interfaces;

public interface IIsrManager{
    ISR GetImpuesto(Person person);
}
    
