using System.Collections.Generic;

namespace Vidly.Controllers.Api
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}