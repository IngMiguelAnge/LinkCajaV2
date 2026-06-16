using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
// Importamos las librerías de OxyPlot
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using LinkCajaV2.Model;

namespace LinkCajaV2.Graphs
{
    public partial class Graph1 : Form
    {
        private PlotView plotView1;
        public List<GraphModel> Datos { get; set; }
        public string Titulo { get; set; }
        public string TituloProductos { get; set; }
        public string TituloCantidad { get; set; }
        public Graph1()
        {
            InitializeComponent();
        }

        private void Graph1_Load(object sender, EventArgs e)
        {
            // 1. Ajustar el panel al tamaño del formulario
            panelGrafica.Dock = DockStyle.Fill;

            // 2. Inicializar y agregar el control
            plotView1 = new PlotView();
            plotView1.Dock = DockStyle.Fill;
            panelGrafica.Controls.Add(plotView1);

            // 3. Configurar el Modelo General (Título y Tipografía global)
            var plotModel = new PlotModel
            {
                Title = Titulo ?? "Productos más vendidos",
                TitleFont = "Segoe UI",          // Tipo de letra del título
                TitleFontSize = 18,              // Tamaño del título
                TitleColor = OxyColor.FromRgb(1, 110, 203), // Color del título
                TitleFontWeight = FontWeights.Bold,
                Padding = new OxyThickness(10, 25, 10, 10) //Margenes para que el título no se vea tan pegado a la gráfica
            };
            // 4. Configurar el Eje de Valores Numéricos (Eje X - Horizontal - Bottom)
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = TituloCantidad ?? "CANTIDAD",
                TitleFont = "Segoe UI",             // Fuente del título del eje
                TitleFontSize = 12,              // Tamaño del título del eje
                TitleColor = OxyColor.FromRgb(108, 117, 125),    // Color del título del eje
                TitleFontWeight = FontWeights.Bold,
                Font = "Segoe UI",                 // Fuente de los números (0, 20, 40...)
                FontSize = 14,                   // Tamaño de los números
                TextColor = OxyColor.FromRgb(108, 117, 125),    // Color de los números
            };

            // 5. Configurar el Eje de Categorías (Eje Y - Vertical - Left)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Font = "Segoe UI",               // Fuente de los nombres de productos
                FontSize = 12,                   // Tamaño de la letra de los productos
                TextColor = OxyColor.FromRgb(108, 117, 125),   // Color de los nombres de productos
                FontWeight = FontWeights.Bold
            };
            categoryAxis.Labels.AddRange(Datos.Select(x => x.CordY));
            //categoryAxis.Labels.Add("Artículo A");
            //categoryAxis.Labels.Add("Artículo B");
            //categoryAxis.Labels.Add("Artículo C");

            // 6. Crear la serie de barras normales
            var barSeries = new BarSeries
            {
                Title = TituloProductos ?? "PRODUCTOS",
                FillColor = OxyColor.FromRgb(17, 159, 230),
                // ─── PROPÓSITO GENERAL: ACTIVAR LOS NÚMEROS EN LAS BARRAS ───
                LabelFormatString = "{0}", // Muestra el valor puro del BarItem (ej: 150)

                // ─── PERSONALIZACIÓN DE LAS LETRAS DE LOS NÚMEROS ───
                LabelPlacement = LabelPlacement.Inside, // Coloca el número DENTRO de la barra (puedes usar 'Outside' o 'Middle')
                TextColor = OxyColors.White,            // Color de la letra del número (Blanco resalta genial sobre el azul)
                FontSize = 12,                          // Tamaño de la letra del número
                Font = "Segoe UI",                      // Tipo de letra
                FontWeight = FontWeights.Bold
            };

            // 7. Agregar los datos
            barSeries.Items.AddRange(Datos.Select(x => new BarItem { Value = (double)x.CordX }));
            //barSeries.Items.Add(new BarItem(150));
            //barSeries.Items.Add(new BarItem(120));
            //barSeries.Items.Add(new BarItem(95));

            // 8. EL ORDEN IMPORTA AQUÍ: 
            // Primero agregamos el eje Horizontal (X) -> valueAxis
            plotModel.Axes.Add(valueAxis);

            // Segundo agregamos el eje Vertical (Y) -> categoryAxis (Así cumple el requisito de ser el eje Y)
            plotModel.Axes.Add(categoryAxis);

            // Finalmente la serie
            plotModel.Series.Add(barSeries);

            // 9. Renderizar
            plotView1.Model = plotModel;
        }
    }
}