// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace BigData
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BigData.Model;

    public static class DataAccessor
    {

        public static Product GetProducts()
        {
            using (var conn = new SqlConnection("Data Source=.;Initial Catalog=TestDB;Integrated Security=True;Persist Security Info=False;Max Pool Size=2000;Connection Timeout=15;"))
            {
                var cmd = new SqlCommand() { Connection = conn };
                cmd.CommandText = "select * from product";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return new Product()
                    {
                        ID = Convert.ToInt32(reader["bi_id"]),
                        Name = reader["nvc_product_name"].ToString(),
                        Description = reader["nvc_product_description"].ToString()
                    };
                }

                return null;
            }
        }
    }
}
