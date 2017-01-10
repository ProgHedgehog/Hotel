using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;


namespace Hotel
{
    class DateBase
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public void AddDatabase()
        {
            SQLiteConnection.CreateFile(@"C:\Hotel\Hotel\Hotel\bin\Debug\Database.sqlite");
            SQLiteCommand Client = new SQLiteCommand("create table if not exists Client(ClientID INTEGER PRIMARY KEY, FIO VARCHAR, Passport VARCHAR, Number VARCHAR)",sql);
            SQLiteCommand Type = new SQLiteCommand("create table if not exists Type(TypeID INTEGER PRIMARY KEY, Name VARCHAR)", sql);
            SQLiteCommand Room = new SQLiteCommand("create table if not exists Room(RoomID INTEGER PRIMARY KEY, Name VARCHAR, Description VARCHAR, Status VARCHAR, Price DOUBLE, TypeName VARCHAR, CONSTRAINT Room_Typefk FOREIGN KEY (TypeName) REFERENCES Type(Name))", sql);
            SQLiteCommand Book = new SQLiteCommand("create table if not exists Book(BookID INTEGER PRIMARY KEY, Data DATATIME, ArrivalDate DATATIME, DepartureDate DATATIME, RoomID INTEGER, ClientID INTEGER, CONSTRAINT Book_Roomfk FOREIGN KEY (RoomID) REFERENCES Room(RoomID), CONSTRAINT Book_Clientfk FOREIGN KEY (ClientID) REFERENCES Client(ClientID))", sql);
            SQLiteCommand AdditionalService = new SQLiteCommand("create table if not exists AdditionalService(AdditionalServiceID INTEGER PRIMARY KEY, Name VARCHAR, Description VARCHAR, Price DOUBLE)", sql);
            SQLiteCommand Contract = new SQLiteCommand("create table if not exists Contract(ContractID INTEGER PRIMARY KEY, Data DATATIME, ArrivalDate DATATIME, DepartureDate DATATIME, Sum DOUBLE, RoomID INTEGER, ClientID INTEGER,BookID INTEGER, CONSTRAINT Contract_Roomfk FOREIGN KEY (RoomID) REFERENCES Room(RoomID),CONSTRAINT Contract_Clientfk FOREIGN KEY (ClientID) REFERENCES Client(ClientID),CONSTRAINT Contract_Bookfk FOREIGN KEY (BookID) REFERENCES Book(BookID))", sql);
            SQLiteCommand TablePart = new SQLiteCommand("create table if not exists TablePart(TablePartID INTEGER PRIMARY KEY, Amount INTEGER, Sum DOUBLE, AdditionalServiceID INTEGER, ContractID INTEGER, CONSTRAINT TablePart_AdditionalServicefk FOREIGN KEY (AdditionalServiceID) REFERENCES AdditionalService(AdditionalServiceID), CONSTRAINT TablePart_Contractfk FOREIGN KEY (ContractID) REFERENCES Contract(ContractID))", sql);
            SQLiteCommand Registeration = new SQLiteCommand("create table if not exists Registration(ID INTEGER PRIMARY KEY, Login Varchar, Password Varchar, Role Varchar)", sql);
            sql.Open();
            Client.ExecuteNonQuery();
            Type.ExecuteNonQuery();
            Room.ExecuteNonQuery();
            Book.ExecuteNonQuery();
            AdditionalService.ExecuteNonQuery();
            Contract.ExecuteNonQuery();
            TablePart.ExecuteNonQuery();
            Registeration.ExecuteNonQuery();
            sql.Close();
        }
    }
}