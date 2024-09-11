using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TestFlexGrid
{
    public class Company
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "TaxNo")]
        public string TaxNo { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Sum of purchases without Vat")]
        public decimal Sum { get; set; }

        [Display(Name = "Sum Vat")]
        public decimal SumVat { get { return Sum * 10 / 100; } }

        [Display(Name = "Amount")] 
        public decimal Amount {  get { return Sum + SumVat; } }

        private static Random rand = new Random();

        public Company() { }
        public Company(int id, string name, string taxNo, string description)
        {
            Id = id;
            Name = name;
            TaxNo = taxNo;
            Description = description;
            Sum = rand.Next(100, 1000) * 1000;

        }

        public ObservableCollection<Company> Companies(int count = 100)
        {
            ObservableCollection<Company> companies = new ObservableCollection<Company>();
            for (int i = 0; i < count; i++)
            {
                rand.Next();
                Company company = new Company(i, "Company "+i.ToString(), "000" + i.ToString(), "Description "+i.ToString());
                companies.Add(company);
            }

            return companies;
        }

    }
}
