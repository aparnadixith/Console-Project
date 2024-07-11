using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Project.Data
{
    public static class TodoSequencer
    {
        private static int todoId = 0;
        public static int NextTodoId()
            { 
            return  ++todoId;
        }
        public static void Reset()
            { 
            todoId = 0;
        }
    }
}
