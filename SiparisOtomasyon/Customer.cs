using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon
{

   public class Customer
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6CF2A79;Initial Catalog=SiparisOtomasyonProje;Integrated Security=True");
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public void AddCustomer() //Müsteri bilgilerini alıp sql tablosuna ekleyen method
        {
            baglanti.Open();
            SqlCommand ekleme = new SqlCommand("insert into MusteriKayitBilgi (UserName,Password,FullName,Telephone,Mail,Address) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
           
            ekleme.Parameters.AddWithValue("@p1", UserName);
            ekleme.Parameters.AddWithValue("@p2", Password);
            ekleme.Parameters.AddWithValue("@p3", FullName);
            ekleme.Parameters.AddWithValue("@p4", Telephone);
            ekleme.Parameters.AddWithValue("@p5", Email);
            ekleme.Parameters.AddWithValue("@p6", Address);
            ekleme.ExecuteNonQuery();
            MessageBox.Show("Başarıyla kayıt oldunuz :) ");
            baglanti.Close();
        }

        public List<Order> MyOrders = new List<Order>();
        public void AddOrder(Order a)
        {
            MyOrders.Add(a);
        }
    }
    //-----------------------------------------------------

    public class Order
    {
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public double CalcTax(int a)
        {
            return a*0.18;
        }
        public double CalcTotal(int b,int c)
        {
            return 0;
        }
        public double CalcTotalWeight(Product d)
        {
            return 0;
        }

        public List<Payment> payments = new List<Payment>();
        public void AddPayment(Payment b)
        {
            payments.Add(b);
        }

        public List<OrderDetail> orderDetails = new List<OrderDetail>();
        public void AddOrderDetail(OrderDetail c)
        {
            orderDetails.Add(c);
        }
        

    }
    //---------------------------------------------------------

    public abstract class Payment
    {
        public double Amount { get; set; }

    }
    //---------------------------------------------------------
    public class OrderDetail
    {
        
        public double TaxStatus { get; set; }
        public Product product { get; set; }
        

    }
    //---------------------------------------------------------
    public class Creditt : Payment
    {
        public string CardNumber { get; set; }
        public string Type { get; set; }
        public string ExpDate { get; set; }
        public string CVC { get; set; }
    }
    //---------------------------------------------------------
    public class Cashh : Payment
    {
        public int CashTendered { get; set; }
    }
    //---------------------------------------------------------
    public class Checkk : Payment
    {
        public string Name { get; set; }
        public string BankkID { get; set; }
    }
    //---------------------------------------------------------
    public class Product
    {
        SqlConnection baglanti2 = new SqlConnection("Data Source=DESKTOP-6CF2A79;Initial Catalog=SiparisOtomasyonProje;Integrated Security=True");

        public string NameProduct { get; set; }
        public decimal Price { get; set; }
        public decimal WeightProduct { get; set; }
        public decimal Quantity { get; set; }

        public void AddProduct()//Ürün bilgilerini alıp sql tablosuna ekleyen method
        {
            baglanti2.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Urun (ProductName,ProductPrice,ProductQuantity,ProductWeight) values (@a1,@a2,@a3,@a4)", baglanti2);
            sqlCommand.Parameters.AddWithValue("@a1", NameProduct);
            sqlCommand.Parameters.AddWithValue("@a2", Price);
            sqlCommand.Parameters.AddWithValue("@a3", Quantity);
            sqlCommand.Parameters.AddWithValue("@a4", WeightProduct);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Added Succesfully :) ");
            baglanti2.Close();

        }

        public void RemoveProduct()//Seçilen ürünü sql den silen method
        {
            baglanti2.Open();
            SqlCommand komut = new SqlCommand("delete Urun where ProductName='" + NameProduct + "'", baglanti2);
            komut.ExecuteNonQuery();
            MessageBox.Show("Deleted Succesfully ");
            baglanti2.Close();
        }

        public void UpdateProduct()//Seçilen ürünüe ait bilgileri güncelleyen method
        {
            baglanti2.Open();
            
            SqlCommand komut2 = new SqlCommand("update Urun set ProductPrice=@a2,ProductQuantity =@a3 where ProductName=@a1", baglanti2);
            komut2.Parameters.AddWithValue("@a1", NameProduct);
            komut2.Parameters.AddWithValue("@a2", Price);
            komut2.Parameters.AddWithValue("@a3", Quantity);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Updates Succesfully");
            baglanti2.Close();

        }

    }

}
