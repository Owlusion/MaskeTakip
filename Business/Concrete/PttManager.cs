using Business.Abstract;

namespace Entities.Concrete;

public class PttManager : ISupplierService
{
    //fieldlar class içinde alt çizgi ile yazılır
    private IApplicantService _applicantService;
    public PttManager(IApplicantService applicantService) //Construstor (Oluşturucu) : class newlendiğinde çalışır.
    {
        _applicantService = applicantService;
    }
    public void GiveMask(Person person)
    {
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine("A mask has been forwarded for " + person.FirstName);
        }
        else
        {
            Console.WriteLine("do not give mask.");
        }
    }
}
