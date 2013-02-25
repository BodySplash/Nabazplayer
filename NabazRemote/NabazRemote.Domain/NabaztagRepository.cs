using System;
using System.Collections.Generic;
using System.Text;

namespace NabazRemote.Domain
{
    public interface NabaztagRepository
    {
        IList<Nabaztag> GetAll();
        void Add(Nabaztag nabaztag);
        void Remove(Nabaztag nabaztag);
        Nabaztag GetBySerialNumber(string serialNumber);
    }
}
