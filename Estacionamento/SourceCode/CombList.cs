using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento.SourceCode
{
    public class CombList
    {
        public static void FillDriverTypes(ComboBox cmb)
        {
            DataTable dtCarType = new DataTable();
            dtCarType.Columns.Add("DriverTypeID");
            dtCarType.Columns.Add("DriverType");
            dtCarType.Rows.Add("0", "- - -Select- - -");
            try
            {
                DataTable dt = DataBaseAcess.Select("Select DriverTypeID, DriverType from DriverTypeTable");
                if (dt != null)
                {

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow usertype in dt.Rows)
                        {
                            dtCarType.Rows.Add(usertype["DriverTypeID"], usertype["DriverType"]);
                        }
                    }
                }
                cmb.DataSource = dtCarType;
                cmb.ValueMember = "DriverTypeID";
                cmb.DisplayMember = "DriverType";
            }
            catch
            {
                cmb.DataSource = dtCarType;
                cmb.ValueMember = "DriverTypeID";
                cmb.DisplayMember = "DriverType";
            }
        }
        public static void FillAutoTypes (ComboBox cmb)
        {
            DataTable dtDriverType = new DataTable();
            dtDriverType.Columns.Add("CarTypeID");
            dtDriverType.Columns.Add("CarType");
            dtDriverType.Rows.Add("0", "- - -Select- - -");
            try
            {
                DataTable dt = DataBaseAcess.Select("Select CarTypeID, CarType from CarTypeTable");
                if (dt != null)
                {

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow usertype in dt.Rows)
                        {
                            dtDriverType.Rows.Add(usertype["CarTypeID"], usertype["CarType"]);
                        }
                    }
                }
                cmb.DataSource = dtDriverType;
                cmb.ValueMember = "CarTypeID";
                cmb.DisplayMember = "CarType";
            }
            catch
            {
                cmb.DataSource = dtDriverType;
                cmb.ValueMember = "DriverTypeID";
                cmb.DisplayMember = "DriverType";
            }
        }
    }
}

