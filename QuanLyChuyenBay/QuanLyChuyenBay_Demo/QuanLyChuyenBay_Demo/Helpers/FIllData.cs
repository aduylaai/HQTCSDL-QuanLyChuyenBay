using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyChuyenBay_Demo.Helpers
{
    class FIllData
    {
        public void fillDataCbo(ComboBox cbo, DBConnect dbConn, string cauTruyVan, string cotHienThi, string cotGiaTriThat)
        {
            SqlDataReader reader = dbConn.ThucThiReader(cauTruyVan);

            while (reader.Read())
            {
                cbo.Items.Add(new ComboBoxItem
                {
                    Text = reader[cotHienThi].ToString(),
                    Value = reader[cotGiaTriThat].ToString()
                });
            }
        }

        public void fillDataCbo(ComboBox cbo, DBConnect dbConn, string cauTruyVan, string cotHienThi1, string cotHienThi2, string cotGiaTriThat)
        {
            SqlDataReader reader = dbConn.ThucThiReader(cauTruyVan);

            while (reader.Read())
            {
                cbo.Items.Add(new ComboBoxItem
                {
                    Text = reader[cotHienThi1].ToString() + " | " + reader[cotHienThi2].ToString(),
                    Value = reader[cotGiaTriThat].ToString()
                });
            }
        }

        public void fillDataGridView(DataGridView dgv, DBConnect dbConn, string cauTruyVan, string tenBangMuonDat)
        {
            dgv.DataSource = null;
            DataSet ds = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cauTruyVan, dbConn.conn))
            {
                adapter.Fill(ds, tenBangMuonDat);
            }
            dgv.DataSource = ds.Tables[tenBangMuonDat];
        }
    }
}
