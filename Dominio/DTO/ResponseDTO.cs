namespace Dominio.DTO
{
    public class ResponseDTO<T>
    {
        public T Data { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
