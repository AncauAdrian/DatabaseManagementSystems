using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab1Forms
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection();

        private BindingNavigator bnPerson = new BindingNavigator(true);
        private BindingSource bsPerson = new BindingSource();

        private BindingNavigator bnVehicle = new BindingNavigator(true);
        private BindingSource bsVehicle = new BindingSource();

        private DataSet ds;

        private SqlDataAdapter daPersons;
        private SqlDataAdapter daVehicles;


        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=DESKTOP-4NP2T6Q\\SQLEXPRESS;Initial Catalog=Lab1;Integrated Security=true";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds = new DataSet();

            daPersons = new SqlDataAdapter("select * from Person", conn);
            daVehicles = new SqlDataAdapter("select * from Vehicle", conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(daVehicles);

            daPersons.Fill(ds, "Person");
            daVehicles.Fill(ds, "Vehicle");

            DataRelation dr = new DataRelation("fk_Person_Vehicle", ds.Tables["Person"].Columns["CNP"], ds.Tables["Vehicle"].Columns["CNP"]);
            ds.Relations.Add(dr);

            bsPerson.DataSource = ds;
            bsPerson.DataMember = "Person";

            bsVehicle.DataSource = bsPerson;
            bsVehicle.DataMember = "fk_Person_Vehicle";

            personDataGrid.DataSource = bsPerson;
            vehicleDataGrid.DataSource = bsVehicle;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (daVehicles == null)
                return;


            daVehicles.Update(ds, "Vehicle");
        }
    }
}
