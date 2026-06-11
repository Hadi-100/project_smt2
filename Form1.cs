using System.IO;

namespace project_smt2
{
    public partial class Form1 : Form
    {
        //public Form1()
        //{
        //    InitializeComponent();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    FormLogin Login = new FormLogin();
        //    //Login.Show();

        //    //this.Hide();
        //}

        //private void datagridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.Columns.Clear();
        //    dataGridView1.RowTemplate.Height = 80;
        //    dataGridView1.Columns.Add("colText", "Text");

        //    var imgCol = new DataGridViewImageColumn
        //    {
        //        Name = "colImage",
        //        HeaderText = "Image",
        //        ImageLayout = DataGridViewImageCellLayout.Zoom,
        //        ValueType = typeof(Image)
        //    };
        //    dataGridView1.Columns.Add(imgCol);

        //    string path = @"C:\Users\LENOVO\Downloads\HalamanLogin(3).png";
        //    if (!File.Exists(path))
        //    {
        //        MessageBox.Show($"Image not found: {path}");
        //        return;
        //    }

        //    // copy the image so it doesn't depend on the file/stream lifetime
        //    using (var fs = File.OpenRead(path))
        //    using (var tmp = Image.FromStream(fs))
        //    {
        //        Image img = new Bitmap(tmp); // makes an independent copy
        //        var thumb = new Bitmap(img, new Size(100, 100));
        //        dataGridView1.Rows.Add("Row 1 text", thumb);
        //    }

        //    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        //    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        //    // row height large enough to show the image
        //    dataGridView1.RowTemplate.Height = 100;

        //    // fixed width for the image column
        //    imgCol.Width = 100;
        //    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

        //    // optionally set the other column width
        //    dataGridView1.Columns["colText"].Width = 200;

        //    imgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        //    dataGridView1.Refresh();
        //}

        //private void Form1_Load_1(object sender, EventArgs e)
        //{

        //}
    }
}
