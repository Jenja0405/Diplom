using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
    public static class DBobjects
    {
        public static MyEntities Entities { get; } = new MyEntities();
    }
}
