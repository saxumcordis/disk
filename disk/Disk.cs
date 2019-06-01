using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace disk
{
    class Disk
    {
        private static readonly ExplorerService service = new ExplorerService();
        public List<File> files = new List<File>();

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
            addFile(file);
            
        }
        private void addFile(File file)
        {
            files.Add(new File(file.path, file.getContent()));
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
        public void deleteFile(string path)
        {
            var file = files.Single(element => element.path == path);
            files.Remove(file);
        }
        public File getFile(string path)
        {
            return files.Single(element => element.path.Contains(path));
        }


        private void clearContent(int start, int finish)
        {
            while (start <= finish)
                content[start++] = null;
        }

        public List<string> viewDirectory(string path)
        {
            var regex = new Regex("^" + path + ".*");
            var folderNameRegex = new Regex("(.+?)(" + DIRECTORY_DIVIDER + "|$)");

            return new HashSet<string>(
            meta.Select(element => element.path)
                .Where(element => regex.IsMatch(element))
                .Select(element => Regex.Replace(element, "^" + path, ""))
                .Where(element => element != "/.dir" && element != ".dir")
                .Select(element => folderNameRegex.Match(element).Groups[1].ToString())
                .ToList()
                ).ToList();
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
            foreach (var dir in path.Split(DIRECTORY_DIVIDER.ToCharArray()))
            {
                if (dir != "")
                {
                    resultPath += dir + DIRECTORY_DIVIDER;
                    if (!isExist(resultPath + ".dir"))
                        createDirectory(resultPath);
                }
            }
        }

        public byte?[] getSize()
        {
            return content;
        }
        public int getIndexOfFile(File file)
        {
            return meta[meta.IndexOf(meta.Single(element => element.path == file.path))].index;
        }
        //public string createFilePath(string path)
        //{
        //    var resultPath = DIRECTORY_DIVIDER;
        //    foreach (var dir in path.Split(DIRECTORY_DIVIDER.ToCharArray()))
        //    {
        //        if (dir != "")
        //        {
        //            resultPath += dir + DIRECTORY_DIVIDER;
        //            if (!isExist(resultPath + ".file"))
        //                createFile(resultPath);
        //        }
        //    }
        //    return resultPath;
        //}
        //public void createFile(string path)
        //{
        //    path += ".file";
        //    if (!isExist(path))
        //        meta.Add(new Meta.Meta(0, 0, path));
        //    else
        //        throw new PathExistsException();
        //}
    }
}
