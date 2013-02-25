using System;
using System.Collections.Generic;
using System.Text;

namespace Common.MemoryDatabase
{
    public class Database
    {
        private Database()
        {
            database = new Dictionary<Type, IList<Object>>();
        }

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (objectLock)
                    {
                        if (instance == null)
                        {
                            instance = new Database();
                        }
                    }
                }
                return instance;
            }
        }

        public IList<object> GetAllOfType(Type type)
        {
            if (database.ContainsKey(type))
            {
                return database[type];
            }
            return new List<Object>();
        }

        public void Add(object element)
        {
            Type objectType = element.GetType();
            if (!database.ContainsKey(objectType))
            {
                database.Add(objectType, new List<object>());
            }
            if (!database[objectType].Contains(element))
            {
                database[objectType].Add(element);
            }
        }

        public void Remove(object element)
        {
            Type objectType = element.GetType();
            if (database.ContainsKey(objectType))
            {
                database[objectType].Remove(element);
            }
        }

        private static Database instance;
        private static Object objectLock = new object();
        private IDictionary<Type, IList<object>> database;
    }
}
