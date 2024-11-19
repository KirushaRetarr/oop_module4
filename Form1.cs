namespace oop_module4
{
    public class ComputerConfiguration
    {
        public string Processor { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public string GraphicsCard { get; set; }
        public decimal Price { get; set; }
    }

    public partial class Form1 : Form
    {
        private List<ComputerConfiguration> configurations;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Пример данных конфигурации ПК
            configurations = new List<ComputerConfiguration>
            {
                new ComputerConfiguration { Processor = "Intel i5", RAM = 8, Storage = 256, GraphicsCard = "NVIDIA GTX 1050", Price = 700 },
                new ComputerConfiguration { Processor = "Intel i7", RAM = 16, Storage = 512, GraphicsCard = "NVIDIA GTX 1660", Price = 1000 },
                new ComputerConfiguration { Processor = "AMD Ryzen 5", RAM = 8, Storage = 512, GraphicsCard = "AMD Radeon RX 5500", Price = 850 },
                new ComputerConfiguration { Processor = "AMD Ryzen 7", RAM = 16, Storage = 1024, GraphicsCard = "NVIDIA RTX 2060", Price = 1200 },
                new ComputerConfiguration { Processor = "Intel i9", RAM = 32, Storage = 1024, GraphicsCard = "NVIDIA RTX 3080", Price = 2000 },
                new ComputerConfiguration { Processor = "Intel i3", RAM = 4, Storage = 128, GraphicsCard = "Intel UHD Graphics 620", Price = 500 },
                new ComputerConfiguration { Processor = "AMD Ryzen 3", RAM = 8, Storage = 256, GraphicsCard = "AMD Radeon Vega 3", Price = 600 },
                new ComputerConfiguration { Processor = "Intel i5", RAM = 16, Storage = 512, GraphicsCard = "NVIDIA GTX 1650", Price = 900 },
                new ComputerConfiguration { Processor = "AMD Ryzen 9", RAM = 32, Storage = 2048, GraphicsCard = "NVIDIA RTX 3070", Price = 1800 },
                new ComputerConfiguration { Processor = "Intel Xeon", RAM = 64, Storage = 4096, GraphicsCard = "NVIDIA Quadro RTX 4000", Price = 3000 }
            };

            dataGridView1.DataSource = configurations;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filter = txtProcessorFilter.Text;
            var filteredData = configurations
                .Where(c => c.Processor.Contains(filter, StringComparison.OrdinalIgnoreCase))
                .ToList();
            dataGridView1.DataSource = filteredData;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var sortedData = configurations
                .OrderBy(c => c.Price)
                .ToList();
            dataGridView1.DataSource = sortedData;
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            var groupedData = configurations
                .GroupBy(c => c.RAM)
                .Select(g => new { RAM = g.Key, Configurations = g.ToList() })
                .ToList();

            string message = string.Join(Environment.NewLine, groupedData
                .Select(g => $"RAM: {g.RAM} GB - {g.Configurations.Count} конфигураций"));
            MessageBox.Show(message, "Сгруппировано по ОЗУ");
        }
    }
}
    