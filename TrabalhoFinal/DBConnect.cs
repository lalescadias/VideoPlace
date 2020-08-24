using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Drawing;

class DBConnect
{
    private MySqlConnection connection;
    private string server;
    private string dataBase;
    private string uid;
    private string password;
    private string port;

    public DBConnect()
    {
        initializer();
    }
    private void initializer()
    {
        server = "localhost";//ou o ip 127.0.0.1
        dataBase = "dbtrabalho";
        uid = "root";
        password = "q1w2e3r4";
        port = "3306";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            dataBase + ";" + "UID=" + uid + ";" + "PASSWORD=" +
            password + ";" + "PORT=" + port + ";";
        connection = new MySqlConnection(connectionString);
    }
    public bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }
    public bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }
    public bool insertUser(string name, string contact, string adress)
    {
        string query = "insert into users (name, contact, adress) values(" +
           "'" + name + "', '" + contact + "', '" + adress + "'); ";
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                flag = true;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public bool SearchUser(string id, ref string name, ref string contact, ref string adress)
    {
        string query = "Select name, contact, adress from users where userId= " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    name = dataReader["name"].ToString();
                    contact = dataReader["contact"].ToString();
                    adress = dataReader["adress"].ToString();
                    flag = true;
                }
                dataReader.Close();
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public bool DeleteUser(string id)
    {
        string query = "Delete from users where userId= " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                flag = true;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }

    public bool UpdateUser(string id, string name, string contact, string adress)
    {
        string query = "Update users set name = '" + name + "',contact = '" + contact + "', adress = '" + adress + "'where userId= " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                flag = true;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public List<string>[] UserList()
    {
        string query = "select * from users order by name  ";

        List<string>[] list = new List<string>[4];
        list[0] = new List<string>();
        list[1] = new List<string>();
        list[2] = new List<string>();
        list[3] = new List<string>();

        if (this.OpenConnection())
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                list[0].Add(dataReader["UserId"].ToString());
                list[1].Add(dataReader["name"].ToString());
                list[2].Add(dataReader["contact"].ToString());
                list[3].Add(dataReader["adress"].ToString());
            }
            dataReader.Close();
            this.CloseConnection();

        }
        return list;
    }
    public bool insertMovie(string title, string genre, string amount, string releaseYear, string description)
    {
        string query = "insert into movies (title, genre, amount, release_year, description) values(" +
           "'" + title + "', '" + genre + "', '" + amount + "', '" + releaseYear + "','" + description + "'); ";
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                flag = true;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }

    public bool SearchMovie(string id, ref string title, ref string genre, ref string amount, ref string release, ref string desc)
    {
        string query = "Select * from movies where movie_id= " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    title = dataReader["title"].ToString();
                    genre = dataReader["genre"].ToString();
                    amount = dataReader["amount"].ToString();
                    release = dataReader["release_year"].ToString();
                    desc = dataReader["description"].ToString();

                    flag = true;
                }
                dataReader.Close();
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public bool DeleteMovie(string id)
    {
        string query = "Delete from movies where movie_id= " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                flag = true;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public bool updateMovie(string id, string title, string genre, string amount, string releaseYear, string description)
    {
        string query ="Update movies set title = '" + title + "',genre = '" + genre + "', amount = '" + amount + "',release_year = '" + releaseYear + "',description = '" + description + "'where movie_id= " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                flag = true;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }

    public List<string>[] MovieList()
    {
        string query = "select * from movies order by title;";

        List<string>[] list = new List<string>[6];
        list[0] = new List<string>();
        list[1] = new List<string>();
        list[2] = new List<string>();
        list[3] = new List<string>();
        list[4] = new List<string>();
        list[5] = new List<string>();
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["movie_id"].ToString());
                    list[1].Add(dataReader["title"].ToString());
                    list[2].Add(dataReader["genre"].ToString());
                    list[3].Add(dataReader["amount"].ToString());
                    list[4].Add(dataReader["release_year"].ToString());
                    list[5].Add(dataReader["description"].ToString());
                }
                dataReader.Close();
                this.CloseConnection();
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return list;
    }

    public bool SearchMovie(string id, ref string title, ref string genre, ref string release, ref string amount)
    {
        string query = "Select title, genre, release_year,amount from movies where movie_id= " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    title = dataReader["title"].ToString();
                    genre = dataReader["genre"].ToString();
                    release = dataReader["release_year"].ToString();
                    amount = dataReader["amount"].ToString();
                    flag = true;
                }
                dataReader.Close();
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public bool SearchUser(string id, ref string name, ref string contact)
    {
        string query = "Select name, contact from users where userId= " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    name = dataReader["name"].ToString();
                    contact = dataReader["contact"].ToString();
                    flag = true;
                }
                dataReader.Close();
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public bool insertBorrowing(string movie_id, string userId, string Initialdate, string finalDate)
    {
        string query = "insert into borrowing (movie_id, userId, initial_date, final_date) values(" +
           "'" + movie_id + "', '" + userId + "', '" + Initialdate + "', '" + finalDate +"'); ";
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                flag = true;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public bool updateMovie(string id, string operador)
    {
        string query = "Update movies set amount = amount "+operador+" 1 where movie_id= " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                flag = true;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public bool SearchBorrowing(string id, ref string name, ref string contact, ref string title, ref string genre, ref string release, ref string initial_date, ref string final_date)
    {
        string query = "select users.name, users.contact, movies.title, movies.genre, movies.release_year, borrowing.initial_date, borrowing.final_date from borrowing" +
            " inner join movies on movies.movie_id = borrowing.movie_id " +
            "inner join users on users.userId = borrowing.userId where borrowing_id = " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    name = dataReader["name"].ToString();
                    contact = dataReader["contact"].ToString();
                    title = dataReader["title"].ToString();
                    genre = dataReader["genre"].ToString();
                    release = dataReader["release_year"].ToString();
                    initial_date = dataReader["initial_date"].ToString();
                    final_date = dataReader["final_date"].ToString();
                    flag = true;
                }
                dataReader.Close();
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public bool updateBorrowing(string id, string finalDate)
    {
        string query = "Update borrowing set final_date ='" + finalDate + "'where borrowing_id = " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                flag = true;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public List<string>[] BorrowingList()
    {
        string query = "select users.name, users.contact, movies.title, movies.genre, borrowing.borrowing_id, borrowing.initial_date, borrowing.final_date from borrowing" +
            " inner join movies on movies.movie_id = borrowing.movie_id " +
            "inner join users on users.userId = borrowing.userId;";

        List<string>[] list = new List<string>[7];
        list[0] = new List<string>();
        list[1] = new List<string>();
        list[2] = new List<string>();
        list[3] = new List<string>();
        list[4] = new List<string>();
        list[5] = new List<string>();
        list[6] = new List<string>();
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["borrowing_id"].ToString());
                    list[1].Add(dataReader["name"].ToString());
                    list[2].Add(dataReader["contact"].ToString());
                    list[3].Add(dataReader["title"].ToString());
                    list[4].Add(dataReader["genre"].ToString());
                    list[5].Add(dataReader["initial_date"].ToString().Substring(0,10));
                    list[6].Add(dataReader["final_date"].ToString().Substring(0, 10));
                }
                dataReader.Close();
                this.CloseConnection();
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return list;
    }
    public bool DeleteBorrowing(string id)
    {
        string query = "Delete from borrowing where borrowing_id= " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                flag = true;
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public bool SearchBorrowing(string id, ref string movie_id)
    {
        string query = "select movies.movie_id from borrowing" +
            " inner join movies on movies.movie_id = borrowing.movie_id  where borrowing_id = " + id;
        bool flag = false;
        try
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    movie_id = dataReader["movie_id"].ToString();
                    flag = true;
                }
                dataReader.Close();
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            this.CloseConnection();
        }
        return flag;
    }
    public MySqlTransaction BeginTransaction()
    {
        return connection.BeginTransaction();
    }
    public void DeleteBorrowingWithoutConnection(string id) 
    {
        string query = "Delete from borrowing where borrowing_id= " + id;
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.ExecuteNonQuery();
    }
    public void updateMovieWithoutConnection(string id, string operador)
    {
        string query = "Update movies set amount = amount " + operador + " 1 where movie_id= " + id;
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.ExecuteNonQuery(); 
    }
    public void insertBorrowingWithoutConnection(string movie_id, string userId, string Initialdate, string finalDate)
    {
        string query = "insert into borrowing (movie_id, userId, initial_date, final_date) values(" +
           "'" + movie_id + "', '" + userId + "', '" + Initialdate + "', '" + finalDate + "'); ";           
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                
        
    }
}