namespace AppArchivo;

public class program
{
    static void Main(string[] args)
    {
        var directorio = Directory.GetCurrentDirectory();
        Console.WriteLine(directorio);
        string ruta = directorio + Path.DirectorySeparatorChar + "Archivo.txt";

        var file = new FileStream(ruta, FileMode.OpenOrCreate);
        //for(int i =65; i<= 90; i++)
        //{
        //    file.WriteByte((byte)i + );    
        //}
        int j;
        while((j = file.ReadByte()) != -1)
        {
            Console.WriteLine((char)j);
        }
        file.Close();
    }
}