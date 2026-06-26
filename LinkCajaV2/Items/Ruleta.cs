using LinkCajaV2.Catalogs;
using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LinkCajaV2.Items
{
    public partial class Ruleta : Form
    {
        public List<PrizeModel> listaPremios {  get; set; }
        private Timer timerRuleta;
        private Random random = new Random();

        // Variables de control de la animación
        private float anguloActual = 0f;
        private float velocidad = 0f;
        private float desaceleracion = 0.95f; // Qué tan rápido frena (0.95 es suave)

        // Lista de premios (puedes cambiar la cantidad y los textos)
        private string[] premios;

        // Colores para los sectores
        private Color[] colores; 
        public Ruleta()
        {
            InitializeComponent();
            // Configurar el formulario para que el dibujo no parpadee (Double Buffered)
            this.DoubleBuffered = true;
            this.Width = 450;
            this.Height = 500;
            this.Text = "Tiendas Mino, Ruleta de la suerte";

            // Crear el Botón de Girar
            Button btnGirar = new Button();
            btnGirar.Text = "¡GIRAR!";
            btnGirar.Size = new Size(120, 40);
            btnGirar.Location = new Point((this.Width / 2) - 65, 380);
            btnGirar.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnGirar.Click += BtnGirar_Click;
            this.Controls.Add(btnGirar);

            // Configurar el Timer para la animación
            timerRuleta = new Timer();
            timerRuleta.Interval = 15; // ~60 FPS
            timerRuleta.Tick += TimeRuleta_Tick;         
        }
        private void GenerarColoresDinamicos()
        {
            colores = new Color[premios.Length];
            for (int i = 0; i < premios.Length; i++)
            {
                // Distribuye el tono (Hue) uniformemente entre 0 y 360 grados
                float tono = (360f / premios.Length) * i;
                colores[i] = ColorDesdeHSL(tono, 0.6f, 0.5f); // 60% saturación, 50% brillo
            }
        }
        private Color ColorDesdeHSL(float h, float s, float l)
        {
            float v2 = (l < 0.5f) ? (l * (1f + s)) : ((l + s) - (s * l));
            float v1 = 2f * l - v2;

            Func<float, float, float, byte> aColor = (v_1, v_2, v_h) => {
                if (v_h < 0f) v_h += 1f;
                if (v_h > 1f) v_h -= 1f;
                if ((6f * v_h) < 1f) return (byte)((v_1 + (v_2 - v_1) * 6f * v_h) * 255);
                if ((2f * v_h) < 1f) return (byte)(v_2 * 255);
                if ((3f * v_h) < 2f) return (byte)((v_1 + (v_2 - v_1) * ((2f / 3f) - v_h) * 6f) * 255);
                return (byte)(v_1 * 255);
            };

            return Color.FromArgb(
                aColor(v1, v2, (h / 360f) + (1f / 3f)),
                aColor(v1, v2, (h / 360f)),
                aColor(v1, v2, (h / 360f) - (1f / 3f))
            );
        }
        private void Ruleta_Load(object sender, EventArgs e)
        {                
             List<string> premiosBase = listaPremios.Select(x => "Premio " +  x.Id.ToString()).ToList();

            // 2. Mezclamos los "Sin premio" de forma aleatoria
            List<string> listaFinal = IntercalarSinPremioAleatorio(premiosBase);

            // 3. Lo asignamos a tu arreglo global 'premios'
            premios = listaFinal.ToArray();
            GenerarColoresDinamicos();
        }
        private List<string> IntercalarSinPremioAleatorio(List<string> premiosReales)
        {
            List<string> resultado = new List<string>(premiosReales);
            Random rand = new Random();

            // Decidimos cuántos "Sin premio" queremos meter. 
            // Por ejemplo, uno por cada 3 premios reales (puedes cambiar este número)
            int cantidadSinPremio = premiosReales.Count / 3;
            if (cantidadSinPremio < 1) cantidadSinPremio = 1; // Al menos uno

            int intentos = 0;
            int insertados = 0;

            while (insertados < cantidadSinPremio && intentos < 100)
            {
                intentos++;
                // Elegimos un índice al azar en la lista que va creciendo
                int indiceAlAzar = rand.Next(0, resultado.Count + 1);

                // Validaciones para que no queden pegados:
                // ¿El de atrás es "Sin premio"?
                bool atrasEsSinPremio = (indiceAlAzar > 0 && resultado[indiceAlAzar - 1] == "Sin premio");
                // ¿El de adelante es "Sin premio"?
                bool adelanteEsSinPremio = (indiceAlAzar < resultado.Count && resultado[indiceAlAzar] == "Sin premio");

                if (!atrasEsSinPremio && !adelanteEsSinPremio)
                {
                    resultado.Insert(indiceAlAzar, "Sin premio");
                    insertados++;
                }
            }

            return resultado;
        }
        private void BtnGirar_Click(object sender, EventArgs e)
        {
            if (!timerRuleta.Enabled)
            {
                // Le damos una velocidad inicial aleatoria alta para arrancar
                velocidad = random.Next(30, 50);
                timerRuleta.Start();
            }
        }

        private void TimeRuleta_Tick(object sender, EventArgs e)
        {
            // Incrementamos el ángulo según la velocidad actual
            anguloActual += velocidad;
            anguloActual %= 360; // Mantenerlo entre 0 y 360 grados

            // Aplicamos fricción/desaceleración
            velocidad *= desaceleracion;

            // Si va muy lento, la detenemos por completo
            if (velocidad < 0.1f)
            {
                velocidad = 0;
                timerRuleta.Stop();
                CalcularPremioGanador();
            }

            // Forzar al formulario a redibujarse
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Centro y tamaño de la ruleta
            int centroX = this.Width / 2;
            int centroY = 180;
            int radio = 150;

            // Dibujar los sectores de la ruleta
            float arcoSector = 360f / premios.Length;
            float anguloSuma = anguloActual;

            for (int i = 0; i < premios.Length; i++)
            {
                // Dibujar el fondo del sector
                using (SolidBrush brush = new SolidBrush(colores[i % colores.Length]))
                {
                    g.FillPie(brush, centroX - radio, centroY - radio, radio * 2, radio * 2, anguloSuma, arcoSector);
                }

                // Dibujar el texto del premio dentro de su sector
                GraphicsState estadoLienzo = g.Save();

                // Mover el origen al centro de la ruleta y rotar para escribir derecho
                g.TranslateTransform(centroX, centroY);
                g.RotateTransform(anguloSuma + (arcoSector / 2));

                using (SolidBrush textBrush = new SolidBrush(Color.White))
                using (Font font = new Font("Segoe UI", 7, FontStyle.Bold))
                {
                    // Dibujamos el texto hacia el borde del círculo
                    g.DrawString(premios[i], font, textBrush, radio / 2, -10);
                }

                // 2. Le pasamos el estado guardado al Restore para solucionar el error
                g.Restore(estadoLienzo);

                anguloSuma += arcoSector;
            }

            // Dibujar el borde de la ruleta
            using (Pen penBorde = new Pen(Color.FromArgb(40, 40, 40), 5))
            {
                g.DrawEllipse(penBorde, centroX - radio, centroY - radio, radio * 2, radio * 2);
            }

            // Dibujar la flecha indicadora fija (arriba, apuntando hacia abajo)
            Point[] flecha = {
                new Point(centroX, centroY - radio + 10),
                new Point(centroX - 15, centroY - radio -15),
                new Point(centroX + 15, centroY - radio -15)
            };
            g.FillPolygon(Brushes.Red, flecha);
            g.DrawPolygon(Pens.White, flecha);
        }

        private void CalcularPremioGanador()
        {
            // La flecha está apuntando arriba (-90 grados en el plano cartesiano estándar)
            // Calculamos qué sector quedó exactamente debajo de la flecha
            float anguloFlecha = 270f;
            float anguloGanador = (anguloFlecha - anguloActual + 360) % 360;

            float arcoSector = 360f / premios.Length;
            int indiceGanador = (int)(anguloGanador / arcoSector);

            // Seguridad por si el redondeo da un índice fuera de rango
            indiceGanador = Math.Min(indiceGanador, premios.Length - 1);

            string premioObtenido = premios[indiceGanador];
            Resultado r = new Resultado();
            var Idpremio = premioObtenido.Split(' ');
            AppRepository obj = new AppRepository();
            if (Idpremio[1] == "premio")
                r.Premio  = "Sin premio";
            else
            {
             PrizeModel detalles = listaPremios.Where(x => x.Id == Convert.ToInt32(Idpremio[1])).First();
             List<ListPrizesModel> detalles2= obj.GetPrizes(detalles.Id,string.Empty).Result;
                r.Premio = detalles2.First().Nombre+ " " + detalles2.First().Cantidad;
                TransactionHistoryModel t = new TransactionHistoryModel();
                t.IdArticles = detalles2.First().IdArticle;
                t.Stock = detalles.Stock < 0 ? detalles.Stock * -1 : detalles.Stock;
                t.Concept = "Premio";
                var Article = obj.GetStock(t.IdArticles).Result;
                StockModel Stock = new StockModel()
                {
                    Id = t.IdArticles,
                    Stock = Article.Stock - t.Stock,
                    StockMin = Article.StockMin,
                    IdPresentation = Article.IdPresentation,
                    Price = Article.Price,
                    SuggestedStock = Article.SuggestedStock,
                    Margen = Article.Margen
                };
                var result = obj.SaveStock(Stock).Result;
                if (result)
                {
                    var re = obj.SaveTransactionHistory(t).Result;
                }
                else
                {
                    MessageBox.Show("Error al guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }            
            }
            r.Show();
            MessageBox.Show("Stock guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
