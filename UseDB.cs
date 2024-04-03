/*
using System.Diagnostics;
using System.IO;
using System.Windows;
using MySql.Data.MySqlClient;

class UseDB
{
    private MySqlConnection connection;
    private string server = "localhost";
    private string database = "mccampus";
    private string uid;
    private string password;

    //Constructor
    public UseDB(string uid, string password)
    {
        this.uid = uid;
        this.password = password;
        Initialize();
    }

    //Initialize values
    private void Initialize()
    {
        var connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
                               database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }

    //Open connection to database
    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            //When handling errors, you can your application's response based 
            //on the error number.
            //The two most common error numbers when connecting are as follows:
            //0: Cannot connect to server.
            //1045: Invalid user name and/or password.
            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server.  Contact administrator");
                    break;

                case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }

    //Close connection
    private bool CloseConnection()
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
    
    //Insert statement
    public void Insert()
    {
    }

    //Update statement
    public void Update()
    {
    }

    //Delete statement
    public void Delete()
    {
    }

    //Select statement
    public List <string> [] Select()
    {
    }

    //Count statement
    public int Count()
    {
        var query = "SELECT Count(*) FROM tableinfo";
        int Count = -1;

        //Open Connection
        if (this.OpenConnection() == true)
        {
            //Create Mysql Command
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //ExecuteScalar will return one value
            Count = int.Parse(cmd.ExecuteScalar()+"");
        
            //close Connection
            this.CloseConnection();

            return Count;
        }
        else
        {
            return Count;
        }
    }

    //Backup
    public void Backup()
    {
        
        try
        {
            var time = DateTime.Now;
            var year = time.Year;
            var month = time.Month;
            var day = time.Day;
            var hour = time.Hour;
            var minute = time.Minute;
            var second = time.Second;
            var millisecond = time.Millisecond;

            //Save file to C:\ with the current date as a filename
            var path = "C:\\MySqlBackup" + year + "-" + month + "-" + day + 
                       "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
            var file = new StreamWriter(path);

        
            var psi = new ProcessStartInfo
            {
                FileName = "mysqldump",
                RedirectStandardInput = false,
                RedirectStandardOutput = true,
                Arguments = $@"-u{_uid} -p{password} -h{server} {_database}",
                UseShellExecute = false
            };

            var process = Process.Start(psi);

            var output = process?.StandardOutput.ReadToEnd();
            file.WriteLine(output);
            process?.WaitForExit();
            file.Close();
            process?.Close();
        }
        catch (IOException ex)
        {
            MessageBox.Show("Error , unable to backup!");
        }
    }

    //Restore
    public void Restore()
    {
        var psi = new ProcessStartInfo();
        try
        {
            //Read file from C:\
            const string path = "C:\\MySqlBackup.sql";
            var file = new StreamReader(path);
            var input = file.ReadToEnd();
            file.Close();

            psi.FileName = "mysql";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = false;
            psi.Arguments = $@"-u{_uid} -p{password} -h{server} {_database}";
            psi.UseShellExecute = false;

        
            var process = Process.Start(psi);
            process?.StandardInput.WriteLine(input);
            process?.StandardInput.Close();
            process?.WaitForExit();
            process?.Close();
        }
        catch (IOException ex)
        {
            MessageBox.Show("Error , unable to Restore!");
        }
    }
}
*/