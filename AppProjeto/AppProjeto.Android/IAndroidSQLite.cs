using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(AppProjeto.IAndroidSQLite))]
namespace AppProjeto
{
    public class IAndroidSQLite : ISQLite
    {
        public SQLiteAsyncConnection AcessarDB()
        {
            var pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var banco = Path.Combine(pasta, "AppSQLite.db");

            return new SQLiteAsyncConnection(banco);
        }
    }
}
