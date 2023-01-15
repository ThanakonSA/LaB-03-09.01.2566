using Microsoft.VisualBasic.Devices;

namespace LaB_03_09._01._2566
{
    public partial class Form1 : Form
    {
        List<Student> list = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int i = 0;
            //Create Student object
            //Student student0 = new Student("Monkey Mouse", 1900);

            //add value to object attribute
            //student0._Name = "Monkey Mouse";
            //student0._studentId= "653450288-1";
            //student0._Birthyear = 2001;
            //student0._High = 177;
            //student0._Grade = 4;
            //student0._Major = "Cs";
            //int Age = 2023 - student0._Birthyear;

            //get value from object attribute
            //textboxName0.Text = student0._Name;
            //textboxstudentId0.Text = student0._studentId;
            //textboxBirthyear0.Text = student0._Birthyear.ToString();
            //textboxhigh0.Text = student0._High.ToString();
            //textboxGrade0.Text = student0._Grade.ToString();
            //textboxMajor0.Text = student0._Major.ToString();

            //Calculate obj age
            //textboxBirthyear0.Text = student0.myAge().ToString();


        }

        private void click0_Click(object sender, EventArgs e)
        {
            //get value from textbox
            String _Name = this.textboxName0.Text;
            String _studenid = this.textboxstudentId0.Text;
            String _Birthyear = this.textboxBirthyear0.Text;
            String _High = this.textboxhigh0.Text;
            String _Grade = this.textboxGrade0.Text;
            String _Major = this.textboxMajor0.Text;

            //convert string to in
            int ibirthyear = Int32.Parse(_Birthyear);
            int ihigh = Int32.Parse(_High);
            double garde = Double.Parse(_Grade);

            //create obj from Student
            Student newStudent = new Student(_Name, _studenid, ibirthyear, ihigh, garde, _Major);

            //Add new student to list
            this.list.Add(newStudent);

            BindingSource source = new BindingSource();
            source.DataSource = this.list;
            this.dataGridView1.DataSource = source;

            //clear textbox
            this.textboxName0.Text = "";
            this.textboxstudentId0.Text = "";
            this.textboxBirthyear0.Text = "";
            this.textboxhigh0.Text = "";
            this.textboxGrade0.Text = "";
            this.textboxMajor0.Text = "";


            //MAX
            textBoxMax.Text = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[1].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Max().ToString();
            double max = 0;
            for (int i = 1; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (max < double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                {
                    max = double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }

            textBoxMax.Text = max.ToString();

            double[] Xmax = new double[dataGridView1.Rows.Count];
            Xmax = (from DataGridViewRow row in dataGridView1.Rows
                    where row.Cells[1].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

            textBoxMax.Text = Xmax.Max().ToString();

            //MIN
            textBoxMin.Text = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[1].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Min().ToString();
            double min = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (min < double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                {
                    min = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
            }

            textBoxMin.Text = min.ToString();

            double[] Xmin = new double[dataGridView1.Rows.Count];
            Xmin = (from DataGridViewRow row in dataGridView1.Rows
                    where row.Cells[1].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

            textBoxMin.Text = Xmin.Min().ToString();

            //SUM
            int SM = dataGridView1.Rows.Count;
            textBoxSum.Text = SM.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}