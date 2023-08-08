using QLBH_Chauquoctoan.MODELL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Chauquoctoan.DALL
{
    internal class SanPhamDAL : DBConnection
    {
        public List<SanPhamBEL> ReadSanPham()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from products ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<SanPhamBEL> lstCus = new List<SanPhamBEL>();

            while (reader.Read())
            {
                SanPhamBEL cus = new SanPhamBEL();
                cus.product_id = int.Parse(reader["product_id"].ToString());
                cus.name = reader["name"].ToString();
                cus.price = int.Parse(reader["price"].ToString());
                cus.quantity_in_stock = int.Parse(reader["quantity_in_stock"].ToString());
                cus.Image = reader["Image"].ToString();
              
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
        public void EditSanPham(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update products set name=@name, price=@price, quantity_in_stock=@quantity_in_stock, Image=@Image WHERE product_id=@product_id", conn);

            cmd.Parameters.Add(new SqlParameter("@product_id", cus.product_id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.name));
            cmd.Parameters.Add(new SqlParameter("@price", cus.price));
            cmd.Parameters.Add(new SqlParameter("@quantity_in_stock", cus.quantity_in_stock));
            cmd.Parameters.Add(new SqlParameter("@Image", cus.Image));

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    

        public void DeleteSanPham(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from products where product_id=@product_id", conn);
            cmd.Parameters.Add(new SqlParameter("@product_id", cus.product_id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void AddSanPham(SanPhamBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into products values(@product_id,@name,@price,@quantity_in_stock,@Image)", conn);
            cmd.Parameters.Add(new SqlParameter("@product_id", cus.product_id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.name));
            cmd.Parameters.Add(new SqlParameter("@price", cus.price));
            cmd.Parameters.Add(new SqlParameter("@quantity_in_stock", cus.quantity_in_stock));
            cmd.Parameters.Add(new SqlParameter("@Image", cus.Image));
          // nút xuất dữ liệu
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
