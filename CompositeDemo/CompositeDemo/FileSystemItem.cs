
namespace CompositeDemo
{
    public abstract class FileSystemItem
    {
        public bool Deleted { get; private set; }
        public FileSystemItem(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public virtual void Delete()
        {
            Deleted = true;
        }
    }
}
