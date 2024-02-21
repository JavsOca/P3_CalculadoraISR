using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Services.Interfaces;

namespace MyCompany.Intranet.Core.Services;

public class IsrService : IIsrService{
    
    public ISR GetISR(Person person){
        var isr = new ISR();

        if (person.Sueldo <= 7735.00)
        {
            isr.Impuestos = (float)(((decimal)(person.Sueldo - 0.01) * 1.92m / 100m) + 0.00m);
        } else if (person.Sueldo > 7735.00 && person.Sueldo <= 65651.07)
        {
            isr.Impuestos = (float)(((person.Sueldo - 7735.01) * (6.40) / 100) + 148.51);
        } else if (person.Sueldo > 65651.07 && person.Sueldo <= 115375.90)
        {
            isr.Impuestos = (float)(((person.Sueldo - 65651.08) * (10.88) / 100) + 3855.14);
        } else if (person.Sueldo > 115375.90 && person.Sueldo <= 134119.41)
        {
            isr.Impuestos = (float)(((person.Sueldo - 115375.91) * (16.00) / 100) + 9265.20);
        } else if (person.Sueldo > 134119.41 && person.Sueldo <= 160577.65)
        {
            isr.Impuestos = (float)(((person.Sueldo - 134119.42) * (17.92) / 100) + 12264.16);
        } else if (person.Sueldo > 160577.65 && person.Sueldo <= 323862.00)
        {
            isr.Impuestos = (float)(((person.Sueldo - 160577.66) * (21.36) / 100) + 17005.47);
        } else if (person.Sueldo > 323862.00 && person.Sueldo <= 510451.00)
        {
            isr.Impuestos = (float)(((person.Sueldo - 323862.01) * (23.52) / 100) + 51883.01);
        } else if (person.Sueldo > 510451.00 && person.Sueldo <= 974535.03)
        {
            isr.Impuestos = (float)(((person.Sueldo - 510451.01) * (30.00) / 100) + 95768.74);
        } else if (person.Sueldo > 974535.03 && person.Sueldo <= 1299380.04)
        {
            isr.Impuestos = (float)(((person.Sueldo - 974535.04) * (32.00) / 100) + 234993.95);
        } else if (person.Sueldo > 1299380.04 && person.Sueldo <= 3898140.12)
        {
            isr.Impuestos = (float)(((person.Sueldo - 1299380.05) * (34.00) / 100) + 338944.34);
        } else if (person.Sueldo > 3898140.12)
        {
            isr.Impuestos = (float)(((person.Sueldo - 3898140.12) * (35.00) / 100) + 1222522.76);
        }

        return isr;
    }
}