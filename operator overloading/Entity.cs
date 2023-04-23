using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    public class Entity
    {
        private int id;
        private int[] values;
        public int Id { get => id; set => id = value; }
        public int[] Values { get => values; set => values = value; }

        public Entity()
        {
        }

        public Entity(int id, int[] values)
        {
            this.id = id;
            this.values = values;
        }

        public static Entity operator+(Entity obj, int val)
        {
            obj.id += val;
            return obj;
        }

        public static int operator+(int val, Entity obj)
        {
            val += obj.id;
            return val;
        }

        public static Entity operator ++(Entity obj)
        {
            obj.id++;
            return obj;
        }

        public int this[int index]
        {
            get { return values[index]; }
            set { values[index] = value; }
        }

        public static bool operator <(Entity a, Entity b)
        {
            if (a.id < b.id)
                return true;
            else return false;
        }
        public static bool operator >(Entity a, Entity b)
        {
            if (a.id > b.id)
                return true;
            else return false;
        }
    }
}