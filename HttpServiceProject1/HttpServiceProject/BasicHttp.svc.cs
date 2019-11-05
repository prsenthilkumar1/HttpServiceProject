using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HttpServiceProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BasicHttp" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BasicHttp.svc or BasicHttp.svc.cs at the Solution Explorer and start debugging.
    public class BasicHttp : IBasicHttp
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

        public string SayHello(string name)
        {
            string sayHello = string.Empty;
            if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour < 12)
            {
                sayHello = string.Concat("Good Morning ", name);
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 15)
            {
                sayHello = string.Concat("Good Afternoon ", name);
            }
            else if (DateTime.Now.Hour >= 15 && DateTime.Now.Hour < 19)
            {
                sayHello = string.Concat("Good Evening ", name);
            }
            else if (DateTime.Now.Hour >= 19 && DateTime.Now.Hour < 4)
            {
                sayHello = string.Concat("Good Night ", name);
            }
            return sayHello;
        }

        private List<JobDetail> JobList()
        {
            List<JobDetail> l_JobList = new List<JobDetail>();

            l_JobList.Add(new JobDetail { JobID = "1", JobRole = "PAT", JobDescription = "Programer Analyst Trinee" });
            l_JobList.Add(new JobDetail { JobID = "2", JobRole = "PA", JobDescription = "Programer Analyst" });
            l_JobList.Add(new JobDetail { JobID = "3", JobRole = "A", JobDescription = "Associate" });
            l_JobList.Add(new JobDetail { JobID = "4", JobRole = "SA", JobDescription = "Senior Associate" });
            l_JobList.Add(new JobDetail { JobID = "5", JobRole = "TL", JobDescription = "Tech Lead" });
            l_JobList.Add(new JobDetail { JobID = "6", JobRole = "M", JobDescription = "Manager" });

            return l_JobList;
        }

        public JobModel OpeningJobs()
        {
            JobModel job = new JobModel();
            job.JobDetailList = new List<JobDetail>();
            job.JobDetailList = JobList();
            return job;
        }

        public JobModel OpeningJobsByRole(string Role)
        {
            JobModel job = new JobModel();
            job.JobDetailList = new List<JobDetail>();
            job.JobDetailList = JobList().Where(t => t.JobRole == Role).Select(t => t).ToList();
            return job;
        }

        public decimal Addition(decimal firstNumber, decimal secondNumber)
        {
            decimal Result = 0;
            Result = firstNumber + secondNumber;
            return Result;
        }

        public decimal Subtraction(decimal firstNumber, decimal secondNumber)
        {
            decimal Result = 0;
            Result = firstNumber - secondNumber;
            return Result;
        }

    }
}
