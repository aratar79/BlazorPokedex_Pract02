using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Models
{
    public class PaginationParameters
    {

        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 5;

        public int Offset => (PageNumber - 1) * PageSize;
    }
}
