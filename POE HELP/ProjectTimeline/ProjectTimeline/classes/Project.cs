using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTimeline.classes
{
    public class Project
    {
		List<Project> prList = new List<Project>();
        public string ProjectCode { get; set; }
		private string _projectName;

		public string ProjectName
		{
			get { return _projectName; }
			set {
				if (value.Trim().Length < 3)
				{
					throw new Exception($"Project name ({value}) should at least be 3 characters long");
				}
				_projectName = value; 
			}
		}
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		private readonly double _duration;

		public double Duration
		{
			get { return _duration; }
			set {
				if (StartDate > EndDate)
				{
					throw new Exception($"Start date ({StartDate}) cannot be after the end date ({EndDate})");
				}
				//_duration = value; 
			}
		}
		public double EstimatedCost { get; set; }

		public Project(string theCode, string theName, DateTime sDate, DateTime eDate)
		{
			ProjectCode = theCode;
			ProjectName = theName;
			StartDate = sDate;
			EndDate = eDate;
			Duration = (EndDate - StartDate).TotalDays;
		}

		//public double calcEstimatedCost(double rate)
		//{
		//	return (rate * Duration) * 8;
		//}
		public void calcEstimatedCost(double rate)
		{
			EstimatedCost = (rate * Duration) * 8;
        }


        public override string ToString()
		{
            //Code: PR123  Name: SISONKE 14 days, EC: R22 400.00
            return $"Code: {ProjectCode} Name: {ProjectName} {Duration} days, EC: {EstimatedCost:c}";
		}

		public Project this[string code]
		{
			get {
				foreach (Project p in prList)
				{
					if (p.ProjectCode.Equals(code))
					{
						return p;
					}
				}
				return null;
			}
		}
	}
}
