using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Windows.Forms;

namespace disk
{
    class Disk
    {
        private static readonly ExplorerService service = new ExplorerService();
        const string DIRECTORY_DIVIDER = "/";
        private byte?[] content;
        private List<Meta.Meta> meta = new List<Meta.Meta>();
        public Disk(int size)
        {
            content = new byte?[size];
        }
        public void write(File file)
        {
            if (isExist(file.getPath()))
                throw new PathExistsException();
            var index = makeIndex(file);
            write(file, index);
        }
        private void write(File file, int index)
        {
            var counter = index;
            foreach (var element in file.getContent())
                content[counter++] = element;
            addMeta(file, index);
        }
        private void addMeta(File file, int index)
        {
            meta.Add(new Meta.Meta(index, file.getSize(), file.getPath()));
            meta.Sort((first, second) => first.index.CompareTo(second.index));
        }
        private int makeIndex(File file)
        {
            if (meta.Count == 0 || meta[0].index >= file.getSize())
                return 0;
            for (var i = 0; i < meta.Count - 1; ++i)
                if (Meta.Meta.spaceBetween(meta[i], meta[i + 1]) >= file.getSize())
                    return meta[i].index + meta[i].length;
            if (content.Length - meta.Last().index + meta.Last().length >= file.getSize())
                return meta.Last().index + meta.Last().length;
            throw new NotEnoughSpaceException();
        }
        private bool isExist(string path)
        {
            return meta.Any(element => element.path == path);
        }
        public void delete(string path)
        {
            var file = meta.Single(element => element.path == path);
            if (file == null)
                throw new FileNotFoundException();
            meta.Remove(file);
            clearContent(file.index, file.index + file.length);
        }
        private void clearContent(int start, int finish)
        {
            while (start <= finish)
                content[start++] = null;
        }
        public List<string> viewDirectory(string path)
        {
            var regex = new Regex(path + ".+");
            var folderNameRegex = new Regex(path + DIRECTORY_DIVIDER + ".+?(" + DIRECTORY_DIVIDER + "|$)");
            return new HashSet<string>(meta.Where(element => regex.IsMatch(element.path))
                .Select(element => folderNameRegex.Match(element.path).Groups[1].ToString())
                .Where(element => element != "")
                .ToList()).ToList();
        }
        public void createDirectory(string path)
        {
            path += ".dir";
            if (!isExist(path))
                meta.Add(new Meta.Meta(0, 0, path));
            else
                throw new PathExistsException();
        }
        public void createPath(string path)
        {
            var resultPath = DIRECTORY_DIVIDER;
            foreach(var dir in path.Split(DIRECTORY_DIVIDER.ToCharArray()))
            {
                resultPath += dir + DIRECTORY_DIVIDER;
                if (!isExist(resultPath))
                    createDirectory(resultPath);
            }
        }
        public byte?[] getSize()
        {
            return content;
        }
    }
}
