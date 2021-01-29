using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MPBS.Database
{
    public static class PTSProgramController
    {
        public static Status<List<PTSProgram>> getPrograms()
        {
            Status<List<PTSProgram>> statusObject = new Status<List<PTSProgram>>();
            statusObject.status = false;
            List<PTSProgram> programs = new List<PTSProgram>();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"
                   SELECT [program_code],[name_ar],[name_en],[CBS_catagory],Active, Yearly_Limit FROM [CTS].[dbo].[PTS_Program]";

                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            statusObject.status = false;
                            statusObject.message = Errors.ErrorsString.Error012;
                            conn.Close();
                            return statusObject;

                        }
                        else
                        {
                            while (reader.Read())
                            {
                                PTSProgram p = new PTSProgram();
                                
                                p.Code = string.Concat(reader[0].ToString().Where(c => !Char.IsWhiteSpace(c)));
                                p.NameAR = reader[1].ToString();
                                p.NameEN = reader[2].ToString();
                                p.CBSCatagory = reader[3].ToString();
                                p.Active = bool.Parse(reader[4].ToString());
                                p.YearlyLimit = int.Parse(reader[5].ToString());


                                programs.Add(p);

                      
                            }
                            statusObject.status = true;
                            statusObject.Object = programs;
                            conn.Close();
                            return statusObject;

                        }
                    }
                    catch (Exception e)
                    {
                        conn.Close();
                        statusObject.status = false;
                        statusObject.message = "Get Customer Info\n" + Errors.ErrorsString.Error002 + "\n" + e;
                        return statusObject;
                    }


                }

            }
            else
            {
                conn.Close();
                statusObject.status = false;
                statusObject.message = Errors.ErrorsString.Error001;

                return statusObject;
            }
        }

        public static Status<List<PTSProgram>> getActivePrograms()
        {
            Status<List<PTSProgram>> statusObject = new Status<List<PTSProgram>>();
            statusObject.status = false;
            List<PTSProgram> programs = new List<PTSProgram>();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"
                   SELECT [program_code],[name_ar],[name_en],[CBS_catagory],Active, Yearly_Limit FROM [CTS].[dbo].[PTS_Program] where Active = 1";

                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            statusObject.status = false;
                            statusObject.message = Errors.ErrorsString.Error012;
                            conn.Close();
                            return statusObject;

                        }
                        else
                        {
                            while (reader.Read())
                            {
                                PTSProgram p = new PTSProgram();

                                p.Code = string.Concat(reader[0].ToString().Where(c => !Char.IsWhiteSpace(c)));
                                p.NameAR = reader[1].ToString();
                                p.NameEN = reader[2].ToString();
                                p.CBSCatagory = reader[3].ToString();
                                p.Active = bool.Parse(reader[4].ToString());
                                p.YearlyLimit = int.Parse(reader[5].ToString());


                                programs.Add(p);


                            }
                            conn.Close();
                            statusObject.status = true;
                            statusObject.Object = programs;
                            return statusObject;

                        }
                    }
                    catch (Exception e)
                    {
                        conn.Close();
                        statusObject.status = false;
                        statusObject.message = "Get Customer Info\n" + Errors.ErrorsString.Error002 + "\n" + e;
                        return statusObject;
                    }


                }

            }
            else
            {
                conn.Close();
                statusObject.status = false;
                statusObject.message = Errors.ErrorsString.Error001;

                return statusObject;
            }
        }

    }
}
