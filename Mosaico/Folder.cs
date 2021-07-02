using System.IO;
using System.Windows.Forms;

namespace Mosaico
{
    public class Folder
    {
        private string path = "";
        private FileInfo[] _arquivos;
        private FolderBrowserDialog browser = new FolderBrowserDialog();
        
        public Folder()
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            this._arquivos = dir.GetFiles("*.png *.jpeg");
        }
        
        public string BrowseFiles()
        {
            this.browser.ShowDialog();
            return browser.SelectedPath;
        }

        public FileInfo[] GetArquivos()
        {
            return this._arquivos;
        }
    }
}