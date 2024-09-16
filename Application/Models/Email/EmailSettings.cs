namespace Application.Models.Email;

public class EmailSettings
{
    public const string EmailSetting = "EmailSettings";
    public string ApiKey {  get; set; }
    public string FromAddress { get; set; }

    public string FromName { get; set; }
}
