namespace ConsoleNotes;

internal class Note
{
    // Note myNote = new Note("Note Title", "Note Content", myNotebook);

    #region Properties
    public Guid UID { get; private set; }
    public string Title { get; set; }
    public DateTime Created { get; private set; }
    public DateTime LastModified { get; private set; }
    public string[] Tags { get; set; }
    public Notebook Notebook { get; set; }
    public string Content { get; set; }
    #endregion

    #region Constructor
    public Note(string title, Notebook notebook, string[] tags = null, string content = null)
    {
        UID = Guid.NewGuid();
        Title = title;
        Created = DateTime.Now;
        LastModified = DateTime.Now;
        Tags = tags;
        Notebook = notebook;
        Content = content;
    }
    #endregion
}
