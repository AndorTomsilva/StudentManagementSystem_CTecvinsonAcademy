using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public partial class Student
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("age")]
        public long Age { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }
    }

    public partial class Student
    {
        public static Student FromJson(string json) => JsonConvert.DeserializeObject<Student>(json);
    }

    public static class Serialize
    {
        public static string ToJson(this Student self) => JsonConvert.SerializeObject(self);
    }
}
