using LinkCajaV2.Model;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LinkCajaV2.Data
{
    public class BillingMethods
    {
        public async Task<RespuestaFactureModel> EnviarFactura(BillingDetails billing)
        {
            string url = "https://facturacion.tiendasmino.com/api/tickets";
            string apiKey = "change_me_pos_secret";

            // 2. Enviamos usando HttpClient
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-POS-API-KEY", apiKey);

                try
                {
                    // PostAsJsonAsync se encarga de convertir el objeto 'ticket' a JSON 
                    // y configurar los headers de "application/json" automáticamente.
                    HttpResponseMessage respuesta = await client.PostAsJsonAsync(url, billing);
                    string resultadoServidor = await respuesta.Content.ReadAsStringAsync();
                    //Para ver que json envias descomento esto
                    // Esto genera el JSON en formato bonito (indented) para que lo puedas leer
                    //string jsonGenerado = System.Text.Json.JsonSerializer.Serialize(billing, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });

                    //// Lo imprime en la ventana de "Salida" (Output) de Visual Studio
                    //System.Diagnostics.Debug.WriteLine("--- JSON GENERADO POR MI BACKEND ---");
                    //System.Diagnostics.Debug.WriteLine(jsonGenerado);
                    return new RespuestaFactureModel { Exito = respuesta.IsSuccessStatusCode, Mensaje = resultadoServidor};
                 }
                catch (Exception ex)
                {
                    return new RespuestaFactureModel { Exito = false, Mensaje = ex.Message };
                }
            }
        }
    }
}
