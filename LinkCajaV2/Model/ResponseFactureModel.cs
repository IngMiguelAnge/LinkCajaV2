namespace LinkCajaV2.Model
{
    public class ResponseFactureModel
    {
        public string message { get; set; }
        public string pos_ticket_id { get; set; }
        public string status { get; set; }
        public bool facturado { get; set; }
        public string cfdi_uuid { get; set; }
        public string issued_at { get; set; }
        public string expires_at { get; set; }
        public string total { get; set; }
    }
}
