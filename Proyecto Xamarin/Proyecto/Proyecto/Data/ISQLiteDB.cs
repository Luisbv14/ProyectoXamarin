using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto.Data
{
    public interface ISQLiteDB
    {
        
        SQLiteAsyncConnection GetConnection();
    }

}
