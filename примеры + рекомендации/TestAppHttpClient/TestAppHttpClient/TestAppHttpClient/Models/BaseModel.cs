using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class BaseModel:IBaseModel
    {
        public BaseModel()
        {
            Id = _id;
            _id++;
        }
        protected static int _id = 0;
        public int Id { get; set; }
    }
}
