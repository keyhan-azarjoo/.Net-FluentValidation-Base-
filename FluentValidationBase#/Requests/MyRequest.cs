using System.ComponentModel.DataAnnotations;

namespace FluentValidationBase_.Requests;

public sealed record MyRequest
{
    [Required]
    public Guid Guid { get; init; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public string Phone {  get; set; }
    public int credit {  get; set; }
}
