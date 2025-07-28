using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.Aplication.Common.Exceptions
{
    public class NotFoundException: Exception
    {
        public NotFoundException(string name, object key)
            :base($"Entity \"{name}\" ({key}) not found."){}
    }
}