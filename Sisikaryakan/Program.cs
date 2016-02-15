using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Program
    {
        public static void Main()
        {
            Manager Tegar = new Manager("Manager Drilling");
            Manager Haidar = new Manager("Manager Drilling");
            Manager Hasani = new Manager("Manager Refinery");
            Manager Adi = new Manager("Manager General Affair");

            Supervisor Iqbal = new Supervisor("Supervisor Drilling Riau");
            Supervisor Ucu = new Supervisor("Supervisor Drilling Luwuk");
            Supervisor Dani = new Supervisor("Supervisor Refinery Balikpapan");

            Staff Dwi = new Staff("Staff Drilling Riau 1");
            Staff Trio = new Staff("Staff Drilling Riau 2");
            Staff Agus = new Staff("Staff Drilling Luwuk");
            Staff Sofi = new Staff("Staff Refinery Balikpapan");
            Staff Seta = new Staff("Staff General Affair");

            Tegar.name = "Tegar";
            Tegar.dateOfEntry = "2 December 2016";
            Tegar.basicSalary = 3000000;
            Tegar.employeeBenefits = 500000;
            Tegar.transportAllowance = 300000;
            Tegar.lodgingAllowance = 900000;
            Tegar.internetAllowance = 200000;
            Tegar.holidayAllowance = 1000000;
            Tegar.TourStudyAllowance = 900000;
            Tegar.healthBenefits = 100000;

            Haidar.name = "Haidar";
            Haidar.dateOfEntry = "2 December 2016";
            Haidar.basicSalary = 3000000;
            Haidar.employeeBenefits = 500000;
            Haidar.transportAllowance = 300000;
            Haidar.lodgingAllowance = 900000;
            Haidar.internetAllowance = 200000;
            Haidar.holidayAllowance = 1000000;
            Haidar.TourStudyAllowance = 900000;
            Haidar.healthBenefits = 100000;

            Hasani.name = "Hasani";
            Hasani.dateOfEntry = "2 December 2016";
            Hasani.basicSalary = 3000000;
            Hasani.employeeBenefits = 500000;
            Hasani.transportAllowance = 300000;
            Hasani.lodgingAllowance = 900000;
            Hasani.internetAllowance = 200000;
            Hasani.holidayAllowance = 1000000;
            Hasani.TourStudyAllowance = 900000;
            Hasani.healthBenefits = 100000;

            Adi.name = "Adi";
            Adi.dateOfEntry = "2 December 2016";
            Adi.basicSalary = 3000000;
            Adi.employeeBenefits = 500000;
            Adi.transportAllowance = 300000;
            Adi.lodgingAllowance = 900000;
            Adi.internetAllowance = 200000;
            Adi.holidayAllowance = 1000000;
            Adi.TourStudyAllowance = 900000;
            Adi.healthBenefits = 100000;


            Iqbal.name = "Iqbal";
            Iqbal.dateOfEntry = "2 December 2016";
            Iqbal.basicSalary = 3000000;
            Iqbal.employeeBenefits = 1000000;
            Iqbal.transportAllowance = 300000;
            Iqbal.lodgingAllowance = 800000;
            Iqbal.internetAllowance = 200000;

            Ucu.name = "Ucu";
            Ucu.dateOfEntry = "2 December 2016";
            Ucu.basicSalary = 3000000;
            Ucu.employeeBenefits = 1000000;
            Ucu.transportAllowance = 400000;
            Ucu.lodgingAllowance = 800000;
            Ucu.internetAllowance = 300000;

            Dani.name = "Dani";
            Dani.dateOfEntry = "2 December 2016";
            Dani.basicSalary = 3000000;
            Dani.employeeBenefits = 1000000;
            Dani.transportAllowance = 300000;
            Dani.lodgingAllowance = 800000;
            Dani.internetAllowance = 200000;

            Dwi.name = "Dwi";
            Dwi.dateOfEntry = "2 December 2016";
            Dwi.basicSalary = 3000000;
            Dwi.employeeBenefits = 500000;
            Dwi.transportAllowance = 300000;

            Trio.name = "Trio";
            Trio.dateOfEntry = "2 December 2016";
            Trio.basicSalary = 3000000;
            Trio.employeeBenefits = 1000000;
            Trio.transportAllowance = 300000;

            Sofi.name = "Sofi";
            Sofi.dateOfEntry = "2 December 2016";
            Sofi.basicSalary = 3000000;
            Sofi.employeeBenefits = 1000000;
            Sofi.transportAllowance = 500000;

            Seta.name = "Seta";
            Seta.dateOfEntry = "2 December 2016";
            Seta.basicSalary = 3000000;
            Seta.employeeBenefits = 1000000;
            Seta.transportAllowance = 3000000;
        }
    }
}
