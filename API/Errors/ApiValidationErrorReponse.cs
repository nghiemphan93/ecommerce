using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Errors
{
  public class ApiValidationErrorReponse : APIResponse
  {
    public ApiValidationErrorReponse() : base(400)
    {
    }

    public IEnumerable<string> Errors { get; set; }
  }
}