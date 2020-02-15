﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class CheckupHelper
    {
        public static bool SaveCheckUP(string patientID,string bp,string temperature,string pr,string timeArrived)
        {
            using (DAL dal = new DAL())
            {
                SqlParameter[] spParams = {
                    new SqlParameter("@patientID", patientID),
                    new SqlParameter("@bp", bp),
                    new SqlParameter("@temperature", temperature),
                    new SqlParameter("@pr", pr),
                    new SqlParameter("@time_arrived",timeArrived),
                };
                try
                {
                    dal.ExecuteQuery("spSaveCheckup", spParams);

                }
                catch (Exception)
                {

                    return false;
                }

                return true;
              
            }
        }

        public static List<Checkup> ListCheckup()
        {
            using (DAL dal = new DAL())
            {
                List<Checkup> checkups = new List<Checkup>();
                try
                {
                    var data = dal.ExecuteQuery("spCheckupList").Tables[0];

                    foreach (DataRow dr in data.AsEnumerable())
                    {
                        checkups.Add(new Checkup()
                        {
                            patientID = dr.Field<string>(1),
                            blood_pressure = dr.Field<string>(2),
                            temperature = dr.Field<string>(3),
                            pulse_rate = dr.Field<string>(4),
                            time_arrived = dr.Field<TimeSpan>(5),
                            isTreated = dr.Field<int>(6),
                            patient = new Patient()
                            {
                                firstname = dr.Field<string>("firstname"),
                                middlename = dr.Field<string>("middlename"),
                                lastname = dr.Field<string>("lastname"),
                                gender = char.Parse(dr.Field<string>("gender")),
                                birthdate = dr.Field<DateTime>("birthyear")

                            }

                        });
                    }

                    return checkups;

                }
                catch (Exception )
                {

                    return null;
                }

            }
        }
    }
}