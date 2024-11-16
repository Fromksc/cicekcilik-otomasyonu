using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace cicekcilikprojesi
{
    class VeriTabani
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=FROMKSC;Initial Catalog=eftalyacicekevi;Integrated Security=True");
        SqlCommand sqlkomut = new SqlCommand();
        DataTable datatbl = new DataTable();
        SqlDataAdapter adtr = new SqlDataAdapter();
        public DataTable Select(string sorgu)
        {
            if (baglan() == true)
            {
                datatbl = new DataTable();
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                adtr.SelectCommand = sqlkomut;
                adtr.Fill(datatbl);
                baglantiKapat();
                return datatbl;
            }
            else
                return null;
        }

        public int Insert(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;
        }

        public int UpdateDelete(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;
        }

        public int SorguCalistir(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;

        }


        bool baglan()
        {
            try
            {
                baglanti.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        void baglantiKapat()
        {
            try
            {
                baglanti.Close();
            }
            catch
            {

            }
        }
    }
}

