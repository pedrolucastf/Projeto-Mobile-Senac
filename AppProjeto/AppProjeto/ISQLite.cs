using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProjeto
{
    public interface ISQLite
    {
        SQLiteAsyncConnection AcessarDB();

    }
}
