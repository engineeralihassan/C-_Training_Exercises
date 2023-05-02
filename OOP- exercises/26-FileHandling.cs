using System.Text;

namespace OOP__exercises
{
    public class FileHandling
    {
        public void CheckFileExist(string file)
        {
            string path = $"D://{file}.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("The File is Exist Now");

            }
            else
            {
                Console.WriteLine("The File is not  Exist Now");

            }

        }
        public void CreateFile(string file)
        {
            string path = $"D://{file}.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("The File is already Exist ");

            }
            else
            {
                FileStream file1 = new FileStream(path, FileMode.Create, FileAccess.Write);
                Console.WriteLine("File is Creat");
                file1.WriteByte(66);
                file1.Close();


            }

        }
        public void InsertData(string file, dynamic data)
        {
            string path = $"D://{file}.txt";

            if (File.Exists(path))
            {
                FileStream file1 = new FileStream(path, FileMode.Append, FileAccess.Write);

                byte[] datawrite = Encoding.UTF8.GetBytes(data);
                file1.Write(datawrite, 0, data.Length);
                Console.WriteLine("Data is added successfully");
                file1.Close();

            }
            else
            {

                Console.WriteLine("this file could not exist" +
                    " please check the file name");

            }

        }
        public void ReadData(string file)
        {
            string path = $"D://{file}.txt";
            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                Console.WriteLine(data);

            }
            else
            {
                Console.WriteLine("The File is not  Exist Now");

            }

        }
        public void MakeCopy(string file, string file2)
        {
            string path = $"D://{file}.txt";
            string path2 = $"D://{file2}.txt";
            if (File.Exists(path) && !File.Exists(path2))
            {
                File.Copy(path, path2);
                Console.WriteLine("The copy of the file is created");

            }
            else if (File.Exists(path2))
            {
                Console.WriteLine("The File is   Exist Now");

            }

        }
        public void CreateDirectory(string foldername)
        {
            string path = $"D://{foldername}";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            // directoryInfo.Create();
            directoryInfo.CreateSubdirectory("New Folder");


        }
        public void DeleteDirectory(string foldername)
        {
            string path = $"D://{foldername}";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            directoryInfo.Delete(true);
            Console.WriteLine("The file is deleted");


        }



        // Main Method
        static void Main(string[] args)
        {

            FileHandling wr = new FileHandling();
            // wr.CheckFileExist("fileHandling");
            // wr.ReadData("fileHandling");
            //wr.MakeCopy("fileHandling", "DataCopy");
            // wr.CreateDirectory("FileHandlingDirectory");
            //wr.DeleteDirectory("FileHandlingDirectory");
            // wr.CreateFile("DataFile");
            wr.InsertData("DataFile", "Hello Ali Please focus on your carrer work hard in the silence not hear the loose talk of the poeples only blieve your self and work hard anf get patience one dat is your success make the noise of your ability please do this no other things . also remember the Allah not forget your heart ");

        }
    }
}


