using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _004_LukasHansel_FinalProject.Model
{
    public class ItemContext
    {
        public string ConnectionString { get; set; }

        public ItemContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<ItemData> GetAllPaytail()
        {
            List<ItemData> list = new List<ItemData>();
            
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM paymentdetail", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ItemData()
                        {
                            paymentDetailId = reader.GetInt32("paymentDetailId"),
                            cardOwnerName = reader.GetString("cardOwnerName"),
                            cardNumber = reader.GetString("cardNumber"),
                            expirationDate = reader.GetString("expirationDate"),
                            securityCode = reader.GetString("securityCode")
                        });
                    }
                }
            }
            return list;
        }

        public List<ItemData> GetPaytailById(string id)
        {
            List<ItemData> list = new List<ItemData>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM paymentdetail WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(new ItemData()
                        {
                            paymentDetailId = reader.GetInt32("paymentDetailId"),
                            cardOwnerName = reader.GetString("cardOwnerName"),
                            cardNumber = reader.GetString("cardNumber"),
                            expirationDate = reader.GetString("expirationDate"),
                            securityCode = reader.GetString("securityCode")
                        });
                    }
                }
            }
            return list;
        }

        public void PostPaytail (string cardOwnerName, string cardNumber, string expirationDate, string securityCode)
        {
            //List<ItemData> list = new List<ItemData>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `paymentdetail` " +
                    "(`cardOwnerName`, `cardNumber`, `expirationDate`, `securityCode`)" +
                    "VALUES (@cardOwnerName, @cardNumber, @expirationDate, @securityCode)", conn);
                cmd.Parameters.AddWithValue("@cardOwnerName", cardOwnerName);
                cmd.Parameters.AddWithValue("@cardNumber", cardNumber);
                cmd.Parameters.AddWithValue("@expirationDate", expirationDate);
                cmd.Parameters.AddWithValue("@securityCode", securityCode);
                cmd.ExecuteNonQuery();

                int rowsAffected = cmd.ExecuteNonQuery();
                //return rowsAffected;
            }
            //return list;
        }

        public void PutPaytail (string cardOwnerName, string cardNumber, string expirationDate, string securityCode)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE `paymentdetail` " +
                    "SET (`cardOwnerName` = @cardOwnerName, " +
                    "`cardNumber` = @cardNumber, " +
                   "`expirationDate` = @expirationDate, " +
                    "`securityCode` = @securityCode)", conn);
                cmd.Parameters.AddWithValue("@cardOwnerName", cardOwnerName);
                cmd.Parameters.AddWithValue("@cardNumber", cardNumber);
                cmd.Parameters.AddWithValue("@expirationDate", expirationDate);
                cmd.Parameters.AddWithValue("@securityCode", securityCode);
                cmd.ExecuteNonQuery();

                int rowsAffected = cmd.ExecuteNonQuery();
            }
        }

        public void DeletePaytail(string id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM paymentdetail WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                int rowsAffected = cmd.ExecuteNonQuery();
            }

        }
    }
}
