using System;
using System.Collections.Generic;
using System.Text;
using NabazRemote.Domain;
using Common.MemoryDatabase;

namespace NabazRemote.MemoryRepositories
{
    public class MemNabaztagRepository : NabaztagRepository
    {
        #region NabaztagRepository Members

        public IList<Nabaztag> GetAll()
        {
            return new List<object>(
                Database.Instance
                .GetAllOfType(typeof(Nabaztag)))
                .ConvertAll<Nabaztag>(
                    delegate(object o)
                    {
                        return (Nabaztag)o;
                    }
             );
        }

        public void Add(Nabaztag nabaztag)
        {
            Database.Instance.Add(nabaztag);
        }

        public void Remove(Nabaztag nabaztag)
        {
            Database.Instance.Remove(nabaztag);
        }

        public Nabaztag GetBySerialNumber(string serialNumber)
        {
            foreach (Nabaztag nabaztag in GetAll())
            {
                if (nabaztag.SerialNumber == serialNumber)
                {
                    return nabaztag;
                }
            }
            return null;
        }

        #endregion
    }
}
