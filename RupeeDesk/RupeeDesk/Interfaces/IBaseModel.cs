using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RupeeDesk.Interfaces
{
    public interface IBaseModel
    {
        Guid Id { get; set; }
        void SetProperty(string key, string value);
    }
}
