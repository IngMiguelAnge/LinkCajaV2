using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinkCajaV2.Data
{
    public class HardwareID
    {
        public string ObtenerHardwareID()
        {
            string idCombinado = "";
            try
            {
                // 1. Obtener ID del Procesador
                using (ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_Processor"))
                {
                    foreach (ManagementObject mo in mbs.Get())
                    {
                        idCombinado += mo["ProcessorId"].ToString();
                        break;
                    }
                }

                // 2. Obtener Número de Serie de la Placa Base
                using (ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select SerialNumber From Win32_BaseBoard"))
                {
                    foreach (ManagementObject mo in mbs.Get())
                    {
                        idCombinado += mo["SerialNumber"].ToString();
                        break;
                    }
                }
            }
            catch { idCombinado = "ID_GENERICO_ERROR"; }

            // Convertimos la cadena larga en un Hash corto y limpio (ej: A1B2-C3D4-E5F6)
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(idCombinado));
                string hash = BitConverter.ToString(bytes).Replace("-", "");
                return hash.Substring(0, 16); // Retornamos solo los primeros 16 caracteres
            }
        }

    }
}
