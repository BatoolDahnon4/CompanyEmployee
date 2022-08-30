namespace CompEmplyee.interfaces
{
    public interface ICompanyRepo
    {
       
        List<Company> Get();
        Company GetId(int id);
        Company Addemployee(Company employee);
        Company updateEmployee(Company request);
        Company Delete(int id);

    }
    public class companyRepo : ICompanyRepo
    {
        private List<Company> companies = new List<Company>()
            {
                 new Company{Id=1,  Name="Iconnect",Location="Ramallah-Alersael"},

                new Company{Id=2,  Name="Hari",Location="Ramallah"},

            };
        public List<Company> Get()
        {
            return companies;
        }
        public Company GetId(int Id)
        {
            return companies.FirstOrDefault(f => f.Id == Id);
        }
        public Company Addemployee(Company company)
        {
            companies.Add(company);
            return company;
        }
        public Company updateEmployee(Company request)
        {
            var company = companies.Find(p => p.Id == request.Id);

            company.Id = request.Id;
            company.Name = request.Name;

            company.Location = request.Location;

            return company;
        }
        public Company Delete(int id)
        {
            var company = companies.Find(x => x.Id == id);

            companies.Remove(company);
            return company;
        }
        
    }
}
