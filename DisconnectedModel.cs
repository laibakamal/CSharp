
//disconnected Model


using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creatong dataset
            DataSet ds = new DataSet();

            //creating tables
            DataTable StudentTable = new DataTable();
            DataTable UniversityTable = new DataTable();

            //creating columns
            //without param constructor
            DataColumn IdColumn = new DataColumn();//col 1

            //setting properties of column
            IdColumn.ColumnName = "Id";//set name of column
            IdColumn.DataType = typeof(int);//set datatype of column

            //creating columns
            //with param constructor
            DataColumn NameColumn = new DataColumn("Name", typeof(string));//col 2
            DataColumn StdUniIdColumn = new DataColumn("UId", typeof(int));//col 3

            //column withour param constructor
            DataColumn UniIdColumn = new DataColumn();//col 1
            UniIdColumn.ColumnName = "Id";
            UniIdColumn.DataType = typeof(int);
            //column with param constructor
            DataColumn UniNameColumn = new DataColumn("Name", typeof(string));//col 2


            //AutoIncrement: Gets or sets a value that indicates whether the column automatically increments the value of the column for new rows added to the table.
            //AutoIncrementSeed: Gets or sets the starting value for a column that has its AutoIncrement property set to true. The default is 0.
            //AutoIncrementStep: Gets or sets the increment used by a column with its AutoIncrement property set to true.

            //setting the auto inc columns

            UniIdColumn.AutoIncrement = true;
            UniIdColumn.AutoIncrementSeed = 1;
            UniIdColumn.AutoIncrementStep = 1;

            IdColumn.AutoIncrement = true;
            IdColumn.AutoIncrementSeed = 1;
            IdColumn.AutoIncrementStep = 1;

            //adding columns to tables
            StudentTable.Columns.Add(IdColumn);
            StudentTable.Columns.Add(NameColumn);
            StudentTable.Columns.Add(StdUniIdColumn);

            UniversityTable.Columns.Add(UniIdColumn);
            UniversityTable.Columns.Add(UniNameColumn);

            //setting primary keys
            StudentTable.PrimaryKey = new DataColumn[] { IdColumn };
            UniversityTable.PrimaryKey = new DataColumn[] { UniIdColumn };

            //adding tables to data set
            ds.Tables.Add(StudentTable);
            ds.Tables.Add(UniversityTable);

            //adding foreign key
            DataRelation rel1 = new DataRelation("usr", UniversityTable.Columns["Id"], StudentTable.Columns["UId"]);
            ds.Relations.Add(rel1);

            //creating university rows
            DataRow ur1 = UniversityTable.NewRow();
            DataRow ur2 = UniversityTable.NewRow();

            //Adding some data 
            ur1["Name"] = "PU";
            ur2["Name"] = "PUCIT";

            //adding rows university to table
            UniversityTable.Rows.Add(ur1);
            UniversityTable.Rows.Add(ur2);

            //creating student rows
            //1
            DataRow sr1 = StudentTable.NewRow();
            sr1["Name"] = "tooba";
            sr1["UId"] = 1;
            //2
            DataRow sr2 = StudentTable.NewRow();
            sr2["Name"] = "Amna";
            sr2["UId"] = 2;
            //3
            DataRow sr3 = StudentTable.NewRow();
            sr3["Name"] = "laiba";
            sr3["UId"] = 1;
            //4
            DataRow sr4=StudentTable.NewRow();
            sr4["Name"] = "iqra";
            sr4["UId"] = 2;
            //5
            DataRow sr5 = StudentTable.NewRow();
            sr5["Name"] = "mashal";
            sr5["UId"] = 1;

            //adding rows to student table
            StudentTable.Rows.Add(sr1);
            StudentTable.Rows.Add(sr2);
            StudentTable.Rows.Add(sr3);
            StudentTable.Rows.Add(sr4);
            StudentTable.Rows.Add(sr5);


            //printing dataset
            foreach (DataRow row in UniversityTable.Rows)
            {
                //university table data
                Console.WriteLine("\n\nUniversity Id : " + row[0]);
                Console.WriteLine("University Name : " + row[1]);

                //for each university, this line gets those rows from the student table which are studying in that university
                //syntax to store the child table rows into an array
                DataRow[] childRows = row.GetChildRows("usr");

                Console.WriteLine($"\nStudents of {row[1]} are: ");
                //prints all students of the currently iterating university of university table
                foreach (DataRow crow in childRows)
                {
                    Console.WriteLine("Student Id : " + crow[0]);
                    Console.WriteLine("student Name : " + crow[1]);
                    DataRow r5 = crow.GetParentRow("usr");//gets the parent row of a datarow using the name of daa relation
                }
            }
        }
    }
}
