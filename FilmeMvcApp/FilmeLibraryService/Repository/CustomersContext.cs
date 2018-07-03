
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using FilmeLibraryService.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeLibraryService.Repository
{
    public class CustomersContext//:DbContext
    {

        string path = Path.Combine(Environment.CurrentDirectory, @"CustomerDB.db");
        public  DbSet<Custommer> CustomerItems{get;set; }

        private SQLiteConnection conne;
        //private DataSet dt;

        public CustomersContext()
        {
            ///path = @"./CustomerDB.db";
            conne = new SQLiteConnection("Data Source=" + path+";Version=3;");

        }

        public DataTable SelectQuery(string Query)
        {
            SQLiteDataAdapter adapter;
            DataTable dataTable = new DataTable();

            try
            {
                SQLiteCommand cmd;
                conne.Open();
                cmd = conne.CreateCommand();
                cmd.CommandText = Query;
                adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dataTable);

            }
            catch(SQLiteException ex)
            {
                 
            }
            conne.Close();
            return dataTable;





        }







        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Filename=../CustomerDB.sqlite");
        //}
    }
}
