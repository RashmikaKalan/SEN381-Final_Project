using DBAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface ICall
    {
        List<CallCentre> GetCalls();
        DataTable GetAllCalls();
        void AddCall(CallCentre call);

    }
    public class CallCentre
    {
        private int callID, empID;
        private double duration;
        private DateTime date;
        private string empName;

        public int CallID { get => callID; set => callID = value; }
        public int EmpID { get => empID; set => empID = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Duration { get => duration; set => duration = value; }
        public string EmpName { get => empName; set => empName = value; }

        public CallCentre()
        {
                
        }

        public CallCentre(int callID, int empID, double duration, DateTime date)
        {
            this.callID = callID;
            this.empID = empID;
            this.duration = duration;
            this.date = date;
        }

        public CallCentre(int callID, string empName, double duration, DateTime date)
        {
            this.callID = callID;
            this.empName = empName;
            this.duration = duration;
            this.date = date;
        }

        public List<CallCentre> GetCalls()
        {
            List<CallCentre> calls = new List<CallCentre>();
            DataSet ds = new GeneralDataHandler().GetData("tblCallCentre");
            foreach (DataRow item in ds.Tables["tblCallCentre"].Rows)
            {
                calls.Add(new CallCentre(int.Parse(item[0].ToString()), int.Parse(item[1].ToString()), double.Parse(item[3].ToString()), Convert.ToDateTime(item[2].ToString())));
            }
            return calls;               
        }

        public List<CallCentre> GetAllCalls()
        {
            List<CallCentre> calls = new List<CallCentre>();
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            DataTable dt = techSupportDataHandler.GetCalls();
            foreach (DataRow item in dt.Rows)
            {
                calls.Add(new CallCentre(int.Parse(item[0].ToString()), item[1].ToString(), double.Parse(item[3].ToString()), Convert.ToDateTime(item[2].ToString())));
            }
            return calls;
        }

        public void AddCall(CallCentre call)
        {
            TechSupportDataHandler techSupportDataHandler = new TechSupportDataHandler();
            techSupportDataHandler.RecordCall(call.empID, call.date, call.duration);     
        }
    }
}
