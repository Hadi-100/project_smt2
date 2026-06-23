using LiveCharts;
using LiveCharts.WinForms; // atau LiveCharts.Wpf untuk PieSeries
using LiveCharts.Wpf;
using project_smt2.Controllers;      // PieSeries, ChartValues
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace project_smt2
{
    public partial class LaporanPenjualanForm : UserControl
    {
        public LaporanPenjualanForm()
        {
            InitializeComponent();
            LoadPiePenjualanPeternak();
            LoadMonthlyChart();
            LoadData();
        }

        
        private void LoadPiePenjualanPeternak()
        {
            try
            {
                LaporanController ctrl = new LaporanController();
                var dt = ctrl.GetPenjualanPeternak();

                if (dt == null || dt.Rows.Count == 0)
                {
                    pieChartPeternak.Series = new SeriesCollection();
                    return;
                }

                var series = new SeriesCollection();
                foreach (DataRow r in dt.Rows)
                {
                    var name = r["nama_peternak"].ToString();
                    var value = Convert.ToDouble(r["total_penjualan"]);
                    series.Add(new PieSeries
                    {
                        Title = name,
                        Values = new ChartValues<double> { value },
                        DataLabels = true,
                        LabelPoint = chartPoint => $"{chartPoint.Participation:P}"
                    });
                }

                pieChartPeternak.Series = series;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat chart penjualan peternak: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadMonthlyChart()
        {
            try
            {
                var ctrl = new LaporanController();
                var dt = ctrl.GetKeuntunganPerBulan();

                if (dt == null || dt.Rows.Count == 0)
                {
                    cerChartBulanan.Series = new SeriesCollection();
                    return;
                }

                var labels = new List<string>();
                var gross = new ChartValues<double>();
                var net = new ChartValues<double>();

                foreach (DataRow r in dt.Rows)
                {
                    labels.Add(r["bulan_label"].ToString());
                    gross.Add(Convert.ToDouble(r["kotor"]));
                    net.Add(Convert.ToDouble(r["bersih"]));
                }

                var series = new SeriesCollection
                {
                    new ColumnSeries { Title = "Keuntungan Kotor", Values = gross },
                    new ColumnSeries { Title = "Keuntungan Bersih", Values = net }
                };

                cerChartBulanan.Series = series;

                // X axis labels
                cerChartBulanan.AxisX = new AxesCollection
                {
                    new Axis { Labels = labels }
                };

                // Y axis formatter
                var id = new System.Globalization.CultureInfo("id-ID");
                cerChartBulanan.AxisY = new AxesCollection
                {
                    new Axis { LabelFormatter = value => value.ToString("N0", id) }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat chart bulanan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            LaporanController controller = new LaporanController();
            DataTable dt = controller.GetPerformaPeternak();
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["nama_peternak"].HeaderText = "Nama Peternak"; 
            dataGridView1.Columns["total_hewan_terjual"].HeaderText = "Hewan Terjual"; 
            dataGridView1.Columns["total_penjualan"].HeaderText = "Total Pendapatan";
            lbNilaiTotal.Text = "Rp " + controller.GetPendapatan().ToString("N0");
            lbRataRata.Text = "Rp " + controller.GetRataPenjualan().ToString("N0");
            lbTotalTransaksi.Text = controller.GetTotalTransaksi().ToString();
            lbHewanDitangani.Text = controller.GetTotalHewanDitangani().ToString();
        }
    }
}
