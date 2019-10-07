using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Park
    {
        private string _name;
        private string _location;
        private string _type;
        private decimal _fee;
        private int _employeecount;
        private int _visitorcountytd;
        private decimal _annualbudget;

        public Park(string name, string location, string type, decimal fee, int employeecount, int visitorcountytd, decimal annualbudget)
        {
            Name = name;
            Location = location;
            Type = type;
            EmployeeCount = employeecount;
            VisitorCountYTD = visitorcountytd;
            AnnualBudget = annualbudget;
            Fee = fee;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Location { get { return _location; } set { _location = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public decimal Fee { get { return _fee; } set { _fee = value; } }
        public int EmployeeCount { get { return _employeecount; } set { _employeecount = value; } }
        public int VisitorCountYTD { get { return _visitorcountytd; } set { _visitorcountytd = value; } }
        public decimal AnnualBudget { get { return _annualbudget; } set { _annualbudget = value; } }

        public string NameAndLocation { get { return $"{_name} {_location}"; } }
        public string NameLocationType { get { return $"{_name} {_location} {_type}"; } }
        public string CostPerVisotor { get { return $"${_annualbudget / _visitorcountytd}"; } }
        public string Revenue { get { return $"${_fee * VisitorCountYTD}"; } }

        public override string ToString()
        {
            return $"Name: {Name}\nLocation: {Location}\nType: {Type}\nFee: {Fee:C}\nEmployee Count: {EmployeeCount}\nVisitor Count: {VisitorCountYTD}\nRevenue: {Revenue:C}\nAnnual Budget: {AnnualBudget:C}";
        }


    }
}
