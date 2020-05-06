using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab1Forms
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection();

        private BindingNavigator bnParent = new BindingNavigator(true);
        private BindingSource bsParent = new BindingSource();

        private BindingNavigator bnChild = new BindingNavigator(true);
        private BindingSource bsChild = new BindingSource();

        private DataSet ds;

        private SqlDataAdapter daParent;
        private SqlDataAdapter daChild;

        private String parent_name;
        private String child_name;
        private String parent_fk;
        private String child_fk;


        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.AppSettings.Get("connection");
            this.parent_name = ConfigurationManager.AppSettings.Get("parent");
            this.child_name = ConfigurationManager.AppSettings.Get("child");
            this.parent_fk = ConfigurationManager.AppSettings.Get("parentfk");
            this.child_fk = ConfigurationManager.AppSettings.Get("childfk");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds = new DataSet();

            String selectParent = "select * from " + parent_name;
            String selectChild = "select * from " + child_name;
            daParent = new SqlDataAdapter(selectParent, conn);
            daChild = new SqlDataAdapter(selectChild, conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(daChild);

            daParent.Fill(ds, parent_name);
            daChild.Fill(ds, child_name);

            String fk_name = "fk_" + parent_name + "_" + child_name;

            DataRelation dr = new DataRelation(fk_name, ds.Tables[parent_name].Columns[parent_fk], ds.Tables[child_name].Columns[child_fk]);
            ds.Relations.Add(dr);

            bsParent.DataSource = ds;
            bsParent.DataMember = parent_name;

            bsChild.DataSource = bsParent;
            bsChild.DataMember = fk_name;

            personDataGrid.DataSource = bsParent;
            vehicleDataGrid.DataSource = bsChild;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (daChild == null)
                return;


            daChild.Update(ds, child_name);
        }
    }
}
