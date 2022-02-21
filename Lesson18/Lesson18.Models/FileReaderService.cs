using System;
using System.IO;
using System.Linq;
using System.Security;

namespace Lesson18.Modules
{
    public class FileReaderService : FilePath
    {
       
        public FileReaderService(string fileName) : base(fileName){}
        public void GetAllLines()
        {
            try
            {
                var lines = File.ReadAllLines(Path);
                lines.ToList();
            }
            
            // find file problems
            catch (ArgumentNullException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            catch (DirectoryNotFoundException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            catch (DriveNotFoundException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            catch (EndOfStreamException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            catch (FileLoadException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            catch (FileNotFoundException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            catch (PathTooLongException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            catch (NotSupportedException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            ///// file read problems
            catch (IOException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            catch (UnauthorizedAccessException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            catch (SecurityException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }
            catch (OutOfMemoryException er)
            {
                Console.WriteLine($"error in {nameof(FilePath)}: Mesage - {er}");
            }



        }

    }

    
   
}
