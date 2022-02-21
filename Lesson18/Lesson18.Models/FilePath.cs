

namespace Lesson18.Modules
{
    public class FilePath
    {
        public string FileName { get; private set; }
        public string Path { get; set; }
        public FilePath(string fileName)
        {
            FileName = fileName;
            Path = $@"C:\Users\audri\Documents\Code_Academy_mokymai\lesson18\Lesson18\Lesson18\{FileName}";
            
        }
    }
}
