using LinkCajaV2.Model;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
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
                    // Configuramos para que ignore si hay diferencias entre Mayúsculas/Minúsculas en el JSON
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    // Convertimos el JSON (texto) a un objeto C# usable
                    ResponseFactureModel miTicket = JsonSerializer.Deserialize<ResponseFactureModel>(resultadoServidor, opciones);
                    return new RespuestaFactureModel { Exito = respuesta.IsSuccessStatusCode, Data = miTicket };

                    //Para ver que json envias descomento esto
                    // Esto genera el JSON en formato bonito (indented) para que lo puedas leer
                    //string jsonGenerado = System.Text.Json.JsonSerializer.Serialize(billing, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });

                    //// Lo imprime en la ventana de "Salida" (Output) de Visual Studio
                    //System.Diagnostics.Debug.WriteLine("--- JSON GENERADO POR MI BACKEND ---");
                    //System.Diagnostics.Debug.WriteLine(jsonGenerado);
                }
                catch (Exception ex)
                {
                    ResponseFactureModel miTicket = new ResponseFactureModel
                    {
                        message = ex.Message,
                        pos_ticket_id = billing.pos_ticket_id,
                        status = "Error",
                        facturado = false,
                        cfdi_uuid = null,
                        issued_at = null,
                        expires_at = null,
                        total = null
                    };
                    return new RespuestaFactureModel { Exito = false, Data = miTicket };
                }
            }
        }

        public async Task<RespuestaFactureModel> EstatusFactura(string pos_ticket_id)
        {
            string url = $"https://facturacion.tiendasmino.com/api/tickets/{pos_ticket_id}/status";
            string apiKey = "change_me_pos_secret";

            // 2. Enviamos usando HttpClient
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-POS-API-KEY", apiKey);

                try
                {
                    // PostAsJsonAsync se encarga de convertir el objeto 'ticket' a JSON 
                    // y configurar los headers de "application/json" automáticamente.
                    HttpResponseMessage respuesta = await client.GetAsync(url);
                    string resultadoServidor = await respuesta.Content.ReadAsStringAsync();
                    // Configuramos para que ignore si hay diferencias entre Mayúsculas/Minúsculas en el JSON
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    // Convertimos el JSON (texto) a un objeto C# usable
                    ResponseFactureModel miTicket = JsonSerializer.Deserialize<ResponseFactureModel>(resultadoServidor, opciones);
                    return new RespuestaFactureModel { Exito = respuesta.IsSuccessStatusCode, Data = miTicket };
                }
                catch (Exception ex)
                {
                    ResponseFactureModel miTicket = new ResponseFactureModel
                    {
                        message = ex.Message,
                        pos_ticket_id = pos_ticket_id,
                        status = "Error",
                        facturado = false,
                        cfdi_uuid = null,
                        issued_at = null,
                        expires_at = null,
                        total = null
                    };
                    return new RespuestaFactureModel { Exito = false, Data = miTicket };
                }
            }
        }

        public async Task<RespuestaFactureModel> CancelarFactura(string pos_ticket_id)
        {
            // 1. Ajustas la URL según los requerimientos de tu API (ejemplo: apuntando al ID del ticket)
            string url = $"https://facturacion.tiendasmino.com/api/tickets/{pos_ticket_id}";
            string apiKey = "change_me_pos_secret";

            // 2. Enviamos usando HttpClient
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-POS-API-KEY", apiKey);

                try
                {
                    // CAMBIO CLAVE: Usamos DeleteAsync en lugar de GetAsync
                    HttpResponseMessage respuesta = await client.DeleteAsync(url);

                    string resultadoServidor = await respuesta.Content.ReadAsStringAsync();

                    // Configuramos para que ignore si hay diferencias entre Mayúsculas/Minúsculas en el JSON
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    // Convertimos la respuesta JSON de la API a tu objeto usable
                    ResponseFactureModel miTicket = JsonSerializer.Deserialize<ResponseFactureModel>(resultadoServidor, opciones);

                    return new RespuestaFactureModel { Exito = respuesta.IsSuccessStatusCode, Data = miTicket };
                }
                catch (Exception ex)
                {
                    // Mantenemos tu control de excepciones para que no rompa el Punto de Venta
                    ResponseFactureModel miTicket = new ResponseFactureModel
                    {
                        message = ex.Message,
                        pos_ticket_id = pos_ticket_id,
                        status = "Error",
                        facturado = false,
                        cfdi_uuid = null,
                        issued_at = null,
                        expires_at = null,
                        total = null
                    };
                    return new RespuestaFactureModel { Exito = false, Data = miTicket };
                }
            }
        }

        public async Task<RespuestaFactureModel> CancelarUnArticulo(string pos_ticket_id, string noIdentificacion)
        {
            // 1. Ajustas la URL según los requerimientos de tu API (ejemplo: apuntando al ID del ticket)
            string url = $"https://facturacion.tiendasmino.com/api/tickets/{pos_ticket_id}/concepts/{noIdentificacion}";
            string apiKey = "change_me_pos_secret";

            // 2. Enviamos usando HttpClient
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-POS-API-KEY", apiKey);

                try
                {
                    // CAMBIO CLAVE: Usamos DeleteAsync en lugar de GetAsync
                    HttpResponseMessage respuesta = await client.DeleteAsync(url);

                    string resultadoServidor = await respuesta.Content.ReadAsStringAsync();

                    // Configuramos para que ignore si hay diferencias entre Mayúsculas/Minúsculas en el JSON
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    // Convertimos la respuesta JSON de la API a tu objeto usable
                    ResponseFactureModel miTicket = JsonSerializer.Deserialize<ResponseFactureModel>(resultadoServidor, opciones);

                    return new RespuestaFactureModel { Exito = respuesta.IsSuccessStatusCode, Data = miTicket };
                }
                catch (Exception ex)
                {
                    // Mantenemos tu control de excepciones para que no rompa el Punto de Venta
                    ResponseFactureModel miTicket = new ResponseFactureModel
                    {
                        message = ex.Message,
                        pos_ticket_id = pos_ticket_id,
                        status = "Error",
                        facturado = false,
                        cfdi_uuid = null,
                        issued_at = null,
                        expires_at = null,
                        total = null
                    };
                    return new RespuestaFactureModel { Exito = false, Data = miTicket };
                }
            }
        }
    }
}
