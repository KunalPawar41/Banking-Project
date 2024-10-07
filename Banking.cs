using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class Banking
    {
        public class Customer
        {
            int _CustID;
            private bool _Status;

            private string _CustName;
            private double _Balance;
            Cities _City;
            public Customer(int CustID, bool Status, string CustName, double Balance, Cities City)    // Custructor to Activate this Attributes 
            {
                _CustID = CustID;
                _Status = Status;
                _CustName = CustName;
                _Balance = Balance;
                _City = City;


            }
            public int CustID  //property
            {
                get { return _CustID; }
            }

            //public bool Status  //property
            //{
            //    get { return _Status; }
            //}
            public bool Status
            {
                get { return _Status; }

            }

            public string CustName
            {

                get { return _CustName; }
                //set { _CustName = value; }   //to check when account is inactive
                // name of customer cannot be changed
                set
                {
                    if (_Status == true)
                        _CustName = value;
                }
            }

            public double Balance
            {
                get { return _Balance; }
                //  set { _Balance = value; }
                set
                {
                    if (_Status == true)
                    {
                        if (value > 500)
                            _Balance = value;
                    }

                }




            }

            public Cities City  // using enmun which is collection of perticular type of data
            {
                get { return _City; }
                set
                {
                    if (_Status == true)
                        _City = value;
                }
                //public string City
                //{
                //    get
                //    {
                //        { return _City; }
                //    }
                //    set
                //    {
                //        if (Status == true)
                //        {
                //            if (value == "Pune" || value == "Mumbai" || value == "Nashik" || value == "Bengluru" || value == "Hyderabad")
                //            {
                //                _City = value;
                //            }
                //            else
                //            {
                //                Console.WriteLine("No City Exits");
                //            }
                //        }
                //    }
                //}
            }
        }
    }
}
