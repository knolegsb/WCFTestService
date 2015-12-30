using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    [ServiceContract]
    interface IMyService
    {
        [OperationContract]
        string GetData();

        [OperationContract]
        string GetMessage(string Name);

        [OperationContract]
        //string GetResult(int Sid, string SName, int M1, int M2, int M3);
        string GetResult(Student s);

        [OperationContract]
        int GetMax(int[] ar);

        [OperationContract]
        int[] GetSorted(int[] ar);

        [OperationContract]
        Student GetTopper(List<Student> LS);

        [OperationContract]
        List<Country> GetAllCountries();
    }
    [DataContract]
    public class Country
    {
        [DataMember]
        public int CountryId { get; set; }
        [DataMember]
        public string CountryName { get; set; }
    }

    [DataContract]
    class Student
    {
        [DataMember]
        public int Sid { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public int M1 { get; set; }
        [DataMember]
        public int M2 { get; set; }
        [DataMember]
        public int M3 { get; set; }
    }
}
