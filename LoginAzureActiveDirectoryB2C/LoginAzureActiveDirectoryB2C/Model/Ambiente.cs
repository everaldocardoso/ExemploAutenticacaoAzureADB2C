namespace LoginAzureActiveDirectoryB2C.Model
{
    public class Ambiente
    {
        public string Description { get; set; }
        public string ClienteId { get; set; }
        public string TenantId { get; set; }
        public string UrlRedirecionamento { get; set; }
        public string UrlEscopo { get; set; }
        public string UrlAutoridade { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
