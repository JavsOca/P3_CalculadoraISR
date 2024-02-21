using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Managers.Interfaces;
using MyCompany.Intranet.Core.Services.Interfaces;

namespace MyCompany.Intranet.Core.Managers;

public class IsrManager : IIsrManager {
    private readonly IIsrService _service;

    public IsrManager(IIsrService service){
        _service = service;
    }

    public ISR GetImpuesto(Person person){
        return _service.GetISR(person);
    }
}