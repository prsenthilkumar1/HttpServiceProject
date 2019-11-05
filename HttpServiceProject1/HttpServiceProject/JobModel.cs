using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpServiceProject
{
    public class JobModel
    {
        public string JobRole { get; set; }
        public List<JobDetail> JobDetailList { get; set; }
    }

    public class JobDetail
    {
        public string JobID { get; set; }
        public string JobRole { get; set; }
        public string JobDescription { get; set; }
    }
}