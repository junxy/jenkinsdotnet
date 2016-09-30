using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace JenkinsDotNet.Tests
{
    [TestClass]
    public class JenkinsClientUnitTest
    {
//        [TestMethod]
        public void RealTest1()
        {
            var jenkins = new JenkinsServer("https://.com", "x", "107f2063eaf5fb7fa40151acc79a784a");
            var job = jenkins.GetJobDetails("test");
            var strJob = JsonConvert.SerializeObject(job);

            Assert.IsNotNull(job);
            Assert.IsFalse(string.IsNullOrEmpty(strJob));

        }

    }
}
