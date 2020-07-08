using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiniUm
{
    public class Dataset
    {
        public string result_type { get; set; }
        public string text { get; set; }
        public string screenshot { get; set; }
    }

    public class TestcasesResult
    {
        public TestcasesResult()
        {
            datasets = new List<Dataset>();
        }

        public string browser_type { get; set; }
        public List<Dataset> datasets { get; set; }
        public string testcase_name { get; set; }
    }

    public class RootObject
    {
        public RootObject() {
            testcases_result = new List<TestcasesResult>();
        }

        public string start_time { get; set; }
        public string end_time { get; set; }
        public string report_type { get; set; }
        public List<TestcasesResult> testcases_result { get; set; }
    }
}
