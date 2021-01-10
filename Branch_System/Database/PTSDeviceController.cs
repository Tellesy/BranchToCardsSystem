using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MPBS.Database
{
    public static class PTSDeviceController
    {


        public static Status<PTSDevice> getDevice(string walletNumber)
        {
            Status<PTSDevice> statusObject = new Status<PTSDevice>();
            statusObject.status = false;
            PTSDevice device = new PTSDevice();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"SELECT Top 1 [device_number],[wallet_number],[active] ,[card_pack_id] FROM [CTS].[dbo].[PTS_Device] where wallet_number = " + walletNumber;

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
                                device.DeviceNumber = reader[0].ToString();
                                device.WalletNumber = reader[1].ToString();
                                device.Active = bool.Parse(reader[2].ToString());
                                device.CardPackID = reader[3].ToString();


                                statusObject.status = true;
                                statusObject.Object = device;
                                conn.Close();
                                return statusObject;
                            }
                            conn.Close();
                            return statusObject;

                        }
                    }
                    catch (Exception e)
                    {
                        conn.Close();
                        statusObject.status = false;
                        statusObject.message = "Get PTS Device \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status addDevice(PTSDevice device)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[PTS_Device]
           ([device_number]
           ,[wallet_number]
           ,[active]
           ,[card_pack_id])
             VALUES
           (@v1
           ,@v2
           ,@v3
           ,@v4 )";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", device.DeviceNumber);
                    cmd.Parameters.AddWithValue("@v2", device.WalletNumber);
                    cmd.Parameters.AddWithValue("@v3", device.Active);
                    cmd.Parameters.AddWithValue("@v4", device.CardPackID);



                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to PTS Device\n" + Errors.ErrorsString.Error002 + "\n" + e;
                    return status;
                }
            }
            else
            {
                status.status = false;
                status.message = Errors.ErrorsString.Error001;
                return status;
            }
        }

        public static Status<PTSDevice> getExistingDevice(string customerID)
        {
            Status<PTSDevice> statusObject = new Status<PTSDevice>();
            statusObject.status = false;
            PTSDevice device = new PTSDevice();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"SELECT TOP 1 [device_number]
      ,d.[wallet_number]
      ,[active]
      ,[card_pack_id]
  FROM [CTS].[dbo].[PTS_Device] as d join PTS_Account as a on a.wallet_number = d.wallet_number where a.customer_ID = " + customerID;

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
                                device.DeviceNumber = reader[0].ToString();
                                device.WalletNumber = reader[1].ToString();
                                device.Active = bool.Parse(reader[2].ToString());
                                device.CardPackID = reader[3].ToString();


                                statusObject.status = true;
                                statusObject.Object = device;
                                conn.Close();
                                return statusObject;
                            }
                            conn.Close();
                            return statusObject;

                        }
                    }
                    catch (Exception e)
                    {
                        conn.Close();
                        statusObject.status = false;
                        statusObject.message = "Get PTS Device \n" + Errors.ErrorsString.Error002 + "\n" + e;
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
