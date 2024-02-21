using MyCompany.Intranet.Core.Entities;

namespace MyCompany.Intranet.Core.Services.Interfaces;

public interface IIsrService{
    ISR GetISR(Person person);
}