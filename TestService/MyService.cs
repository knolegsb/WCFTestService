using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    class MyService : IMyService
    {
        public List<Country> GetAllCountries()
        {
            List<Country> LC = new List<Country>();

            string ConnectionStr = @"data source=(localdb)\MSSQLLocalDB;initial catalog=WCFTest;integrated security=True";

            SqlConnection con = new SqlConnection(ConnectionStr);
            SqlCommand cmd = new SqlCommand("Select * from Country", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Country c = new Country();
                c.CountryId = int.Parse(dr[0].ToString());
                c.CountryName = dr[1].ToString();
                LC.Add(c);
            }
            dr.Close();
            con.Close();

            return LC;
        }

        public string GetData()
        {
            return "www.goodsean.com";
        }

        public int GetMax(int[] ar)
        {
            int Max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > Max)
                {
                    Max = ar[i];
                }
            }
            return Max;
        }

        public string GetMessage(string Name)
        {
            return "Hello Mr./Ms " + Name;
        }

        //public string GetResult(int Sid, string SName, int M1, int M2, int M3)
        public string GetResult(Student s)
        {
            double Avg = (s.M1 + s.M2 + s.M3) / 3.0;
            if (Avg < 35)
                return "Fail";
            else
                return "Pass";
        }

        public int[] GetSorted(int[] ar)
        {
            Array.Sort(ar);
            return ar;
        }

        public Student GetTopper(List<Student> LS)
        {
            throw new NotImplementedException();
        }
    }
}
